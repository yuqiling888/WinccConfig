using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;
using StudentGuanli.Common;


namespace StudentGuanli
{
    public partial class FrmAddStudent : Form
    {
        private StudentClassService objStudentClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        List<StudentExt> objStudetList = new List<StudentExt>();    //用来临时保存学员对象
        public FrmAddStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = objStudentClassService.GetAllClass();
            this.cboClassName.DisplayMember = "ClassName";//设置下拉框显示文本
            this.cboClassName.ValueMember = "ClassId";//设置下拉框显示文本对应的值
            this.cboClassName.SelectedIndex = -1; //默认不选中任何班级

            this.dgvStudentList.AutoGenerateColumns = false;//禁止自动生成列
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
           // FrmDemo.objFrmAddStudent = null;
        }

      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 数据验证

            if(this.tbStudetName.Text.Trim().Length==0)
            {
                MessageBox.Show("学生姓名不能为空","提示信息");
                tbStudetName.Focus();
                return;
            }
            //其它非空验证
            if (!this.rdoMale.Checked && !this.rdoFeMale.Checked)
            {
                MessageBox.Show("请选择学员性别", "提示信息");
                return;
            }
            if(cboClassName.SelectedIndex==-1)
            {
                MessageBox.Show("请选择班级", "提示信息");
                return;
            }
            if(this.tbIdentityCard.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入身份证号", "提示信息");
                return;
            }
            //验证身份证格式是否正确
            if (!Common.DataValidate.IsIdentityCard(this.tbIdentityCard.Text.Trim()))
            {
                MessageBox.Show("身份证号有误！", "验证提示");
                this.tbIdentityCard.Focus();
                return;
            }
            //验证身份证是否重复
            if(objStudentService.IsIdNoExisted(this.tbIdentityCard.Text.Trim()))
            {
                MessageBox.Show("身份证不能和现在学员重复，请认真检查", "验证提示");
                this.tbIdentityCard.Focus();
                this.tbIdentityCard.SelectAll();
                return;
            }

            //验证考勤卡号是否重复
            if(objStudentService.IsCardNoExisted(this.tbCardNo.Text.Trim()))
            {
                MessageBox.Show("当前考勤卡号己被其他学员使用", "验证提示");
                this.tbCardNo.Focus();
                this.tbIdentityCard.SelectAll();
                return;
            }

            //验证身份证号和出生日期是否吻合
            string birthday = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");
            if (!this.tbIdentityCard.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证号日期与出生日期不一致", "验证提示");
                this.tbIdentityCard.SelectAll();
                this.tbIdentityCard.Focus();
                return;

            }
            //验证出生日期
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if(age<18||age>35)
            {
                MessageBox.Show("年龄必面在18到35岁之间", "提示信息");
                return;
            }



            #endregion
            #region 封装学生对象
            StudentExt objStudents = new StudentExt()
            {
                StudentName = this.tbStudetName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = this.tbIdentityCard.Text.Trim(),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                PhoneNumber = this.tbPhoneNumber.Text.Trim(),
                StudentAddress = this.tbStudentAdderss.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                ClassName = this.cboClassName.Text,  //为了列表展示需要
                CardNo = this.tbCardNo.Text.Trim().ToString(),
                StuImage = this.pbStuImage.Image != null ? new Common.SerializeObjectToString().SerializeOboject(this.pbStuImage.Image):""

            };

            #endregion
            #region 调用后台数据访问方法


            try
            {
                int studentId=objStudentService.AddStudent(objStudents);
                if(studentId>1)
                {
                    //同步显示添加的学员
                    objStudents.StudentId = studentId;
                    this.objStudetList.Add(objStudents);
                    this.dgvStudentList.DataSource = null;
                    this.dgvStudentList.DataSource = this.objStudetList;

                    DialogResult result = MessageBox.Show("新学员添加成功，是否继续添加", "信息提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)//清空用户输入
                    {
                        this.cboClassName.SelectedIndex = -1;
                        this.pbStuImage.Image = null;
                        //this.rdoMale.Checked = false;
                        //this.rdoFeMale.Checked = false;
                        //清除文本信息
                        foreach (Control item in this.gbAddStuInfo.Controls)
                        {
                            if (item is TextBox)
                                item.Text = "";
                            else if (item is CheckBox)
                                ((CheckBox)item).Checked = false;
                        }
                        this.tbStudetName.Focus();


                    }
                    else
                        this.Close();

                }

            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
            }
            
            #endregion
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog objopenFileDialog = new OpenFileDialog();
            DialogResult result = objopenFileDialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                this.pbStuImage.Image = Image.FromFile(objopenFileDialog.FileName);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pbStuImage.Image = null;
        }

        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }
    }
   
}
