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
        //创建数据访问对象
        private StudentClassService objStudentClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        List<StudentExt> objStudetList = new List<StudentExt>();    //用来临时保存学员对象
        List<StudentExt> DeletestuList = new List<StudentExt>();      //这个集合主要用来保存己经删除的对象，而且是己经在数据库中己经存在的
        
        public FrmAddStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = objStudentClassService.GetAllClass();
            this.cboClassName.DisplayMember = "ClassName";//设置下拉框显示文本
            this.cboClassName.ValueMember = "ClassId";//设置下拉框显示文本对应的值
            this.cboClassName.SelectedIndex = -1; //默认不选中任何班级

            this.KeyPreview = true;//设置窗体接收键盘按下事件

            this.dgvStudentList.AutoGenerateColumns = false;//禁止自动生成列

            this.cboClassName2.DataSource = objStudentClassService.GetAllClass();
            this.cboClassName2.DisplayMember = "ClassName";//设置下拉框显示文本
            this.cboClassName2.ValueMember = "ClassId";//设置下拉框显示文本对应的值
                                                       //this.cboClassName2.SelectedIndex = -1; //默认不选中任何班级

            this.btnTransactionSave.Enabled = false;

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
            if(this.tbStudentIdNo.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入身份证号", "提示信息");
                return;
            }
            //验证身份证格式是否正确
            if (!Common.DataValidate.IsIdentityCard(this.tbStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号有误！", "验证提示");
                this.tbStudentIdNo.Focus();
                return;
            }
            //验证身份证是否重复
            if(objStudentService.IsIdNoExisted(this.tbStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证不能和现在学员重复，请认真检查", "验证提示");
                this.tbStudentIdNo.Focus();
                this.tbStudentIdNo.SelectAll();
                return;
            }

            //验证考勤卡号是否重复
            if(objStudentService.IsCardNoExisted(this.tbCardNo.Text.Trim()))
            {
                MessageBox.Show("当前考勤卡号己被其他学员使用", "验证提示");
                this.tbCardNo.Focus();
                this.tbStudentIdNo.SelectAll();
                return;
            }

            //验证身份证号和出生日期是否吻合
            string birthday = Convert.ToDateTime(this.dtpBirthday.Text).ToString("yyyyMMdd");
            if (!this.tbStudentIdNo.Text.Trim().Contains(birthday))
            {
                MessageBox.Show("身份证号日期与出生日期不一致", "验证提示");
                this.tbStudentIdNo.SelectAll();
                this.tbStudentIdNo.Focus();
                return;

            }
            //验证出生日期
            int age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year;
            if(age<18||age>35)
            {
                MessageBox.Show("年龄必面在18到35岁之间", "提示信息");
                return;
            }

            //从现在集合中验证考勤卡号或者身份证号不能重复
            var stu = from s in objStudetList where s.StudentIdNo == this.tbStudentIdNo.Text.Trim() select s;
            if(stu.Count()>0)
            {
                MessageBox.Show("身份证号不能重得", "验证提示");
            }

            //foreach(StudentExt item in this.objStudetList)
            //{
            //    if(item.StudentIdNo==this.tbStudentIdNo.Text.Trim())
            //    {
            //        MessageBox.Show("身份证号不能重得", "验证提示");
            //        return;
            //    }
            //}
            #endregion
            #region 封装学生对象
            StudentExt objStudents = new StudentExt()
            {
                StudentName = this.tbStudetName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = this.tbStudentIdNo.Text.Trim(),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                PhoneNumber = this.tbPhoneNumber.Text.Trim(),
                StudentAddress = this.tbStudentAdderss.Text.Trim()==""?"地址不详":this.tbStudentAdderss.Text.Trim(),
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                ClassName = this.cboClassName.Text,  //为了列表展示需要
                CardNo = this.tbCardNo.Text.Trim().ToString(),
                StuImage = this.pbStuImage.Image != null ? new Common.SerializeObjectToString().SerializeOboject(this.pbStuImage.Image):""

            };

            #endregion
            #region 调用后台数据访问方法[暂时不用]


            //try
            //{
            //    int studentId=objStudentService.AddStudent(objStudents);
            //    if(studentId>1)
            //    {
            //        //同步显示添加的学员
            //        objStudents.StudentId = studentId;
            //        this.objStudetList.Add(objStudents);
            //       // this.dgvStudentList.DataSource = null;
            //        this.dgvStudentList.DataSource = this.objStudetList;

            //        DialogResult result = MessageBox.Show("新学员添加成功，是否继续添加", "信息提示",
            //            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (result == DialogResult.Yes)//清空用户输入
            //        {
            //            this.cboClassName.SelectedIndex = -1;
            //            this.pbStuImage.Image = null;
            //            //this.rdoMale.Checked = false;
            //            //this.rdoFeMale.Checked = false;
            //            //清除文本信息
            //            //foreach (Control item in this.gbAddStuInfo.Controls)
            //            //{
            //            //    if (item is TextBox)
            //            //        item.Text = "";
            //            //    else if (item is CheckBox)
            //            //        ((CheckBox)item).Checked = false;
            //            //}
            //            //this.tbStudetName.Focus();


            //        }
            //        else
            //            this.Close();

            //    }

            //}
            //catch (Exception ex)
            //{

            //     MessageBox.Show(ex.Message);
            //}

            #endregion

            objStudents.OperationStatus = ObjectStatus.Inserted;//新添加的对象修改成添加状态
            this.objStudetList.Add(objStudents);//同时添加到集合

            this.btnTransactionSave.Enabled = true;

            this.dgvStudentList.DataSource = null;
            this.dgvStudentList.DataSource = this.objStudetList;
            
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

        private void gbAddStuInfo_Enter(object sender, EventArgs e)
        {

        }

       

        private void FrmAddStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==27)//按下ESC键
            {
                this.Close();
            }
        }

        //提交查询
        private void btnQudery_Click(object sender, EventArgs e)
        {
            this.objStudetList = objStudentService.GetStudentByClass(this.cboClassName2.Text);
            this.dgvStudentList.DataSource = this.objStudetList;
        }

        private void labelPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //没有列表为空
            if(this.objStudetList.Count==0)
            {
                MessageBox.Show("没有要删除的对象", "提示信息");
                return;
            }
            //删除前确认
            if(MessageBox.Show("确认要删除码？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.Cancel) return;
            //找到要删除的对象
            string stuIdNo = this.dgvStudentList.CurrentRow.Cells["StudentIdNo"].Value.ToString(); //获取到所选行的身份证号
            StudentExt deletestu = (from s in objStudetList where s.StudentIdNo == stuIdNo select s).First<StudentExt>();   //根据身份证号从集合中查询到对象
            //从集合中执行删除
            this.objStudetList.Remove(deletestu);
            if(deletestu.OperationStatus!= ObjectStatus.Inserted)
            {
                deletestu.OperationStatus = ObjectStatus.Deleted;
                this.DeletestuList.Add(deletestu);
            }



            //重新显示
            this.dgvStudentList.DataSource = null;
            this.dgvStudentList.DataSource = this.objStudetList;

            this.btnTransactionSave.Enabled = true;
        }

        //修改
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //没有列表为空
            if (this.objStudetList.Count == 0)
            {
                MessageBox.Show("没有要修改的对象", "修改提示");
                return;
            }
            //找到当前要修改的对象（从当前集合中查找，适合字段少的清空，如果很多属性在这里没有显示，请根据ID或身份证号，从数据库中查询）
            string stuIdNo = this.dgvStudentList.CurrentRow.Cells["StudentIdNo"].Value.ToString(); //获取到所选行的身份证号
            StudentExt currentstu = (from s in objStudetList where s.StudentIdNo == stuIdNo select s).First<StudentExt>();   //根据身份证号从集合中查询到对象

            FrmUpdate frm = new FrmUpdate(currentstu);
           DialogResult result= frm.ShowDialog();

            //获取窗体返回值
            if(result==DialogResult.OK)
            {
                
                StudentExt updatestu = (StudentExt)frm.Tag;  //找到要修改的对象
                //更新修改后的对象属性
                currentstu.Age = updatestu.Age;
                currentstu.Birthday = updatestu.Birthday;
                currentstu.CardNo = updatestu.CardNo;
                currentstu.ClassId = updatestu.ClassId;
                currentstu.ClassName = updatestu.ClassName;
                currentstu.Gender = updatestu.Gender;
                currentstu.StudentName = updatestu.StudentName;
                currentstu.StudentIdNo = updatestu.StudentIdNo;
                currentstu.Gender = updatestu.Gender;

                //判断是否需要修改状态
                if(updatestu.OperationStatus==ObjectStatus.Unchanged)
                {
                    currentstu.OperationStatus = ObjectStatus.Updeated;  //将修改过的对象的状态属性改为修改态
                }

            }
            this.dgvStudentList.Refresh();

            this.btnTransactionSave.Enabled = true;

        }

        private void btnTransactionSave_Click(object sender, EventArgs e)
        {

            //合并两个集合
            // this.objStudetList.Union(this.DeletestuList);  //这个方法不行
            this.objStudetList.AddRange(this.DeletestuList);
            try
            {
                bool result=this.objStudentService.SaveStudent(this.objStudetList);
                if (result)
                {

                    this.DeletestuList.Clear();//清除删除的集合
                    for (int i = 0; i < this.objStudetList.Count; i++)
                    {
                        this.objStudetList[i].OperationStatus = ObjectStatus.Updeated;

                    }
                    MessageBox.Show("保存成功", "提示信息");
                }
                else
                    MessageBox.Show("保存失败", "提示信息");
            }
            catch (Exception)
            {

                throw;
            }
            


        }
    }
   
}
