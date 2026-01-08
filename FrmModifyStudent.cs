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
using DAL.Models;
using StudentManager;


namespace StudentManager
{
    public partial class FrmModifyStudent : Form
    {
        private StudentClassService objStudentClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        public FrmModifyStudent()
        {
            InitializeComponent();
            this.cboClassName.DataSource = objStudentClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
          
        }
        public FrmModifyStudent(ExtStudent objStudent):this()
        {
            this.textBoxStudentId.Text = objStudent.StudentId.ToString();
            this.textBoxStudetName.Text = objStudent.StudentName;
            this.textBoxStudentIdNo.Text = objStudent.StudentIdNo.ToString();
            this.dtpBirthday.Text = objStudent.Birthday.ToShortDateString();
            this.cboClassName.Text = objStudent.ClassName;
            this.textBoxCardNo.Text = objStudent.CardNo;
            this.textBoxPhoneNumber.Text = objStudent.PhoneNumber.ToString();
            this.textBoxStudentAdderss.Text = objStudent.StudentAddress;
            if (objStudent.Gender == "男") this.rdoMale.Checked = true;
            else this.rdoFeMale.Checked = true;
        }
              
        //提交修改   

        private void btnModify_Click(object sender, EventArgs e)
        {
            #region 数据验证

           
            //验证身份证格式是否正确
            if (!Common.DataValidate.IsIdentityCard(this.textBoxStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号有误！", "验证提示");
                this.textBoxStudentIdNo.Focus();
                return;
            }
            //验证身份证是否重复
            if(objStudentService.IsStudentIdNoExisted(this.textBoxStudentIdNo.Text.Trim(),this.textBoxStudentId.Text.Trim()))
                {
                MessageBox.Show("身份证不能和现有学员重复", "消息提示");
                this.textBoxStudentIdNo.Focus();
                this.textBoxStudentId.SelectAll();
                return;
            }

            //验证身份证号和出生日期是否吻合
           

            #endregion
            #region 封装学生对象
            ExtStudent objStudents = new ExtStudent()
            {
                StudentId = Convert.ToInt32(this.textBoxStudentId.Text.Trim()),
                StudentName = this.textBoxStudetName.Text.Trim(),
                Gender = this.rdoMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = Convert.ToDecimal(this.textBoxStudentIdNo.Text.Trim()),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year,
                PhoneNumber = this.textBoxPhoneNumber.Text.Trim(),
                StudentAddress = this.textBoxStudentAdderss.Text.Trim(),
                ClassId=Convert.ToInt32( this.cboClassName.SelectedValue),
                
            };

            #endregion
            #region 提交修改
            try
            {
                if(objStudentService.ModifyStudent(objStudents)==1)
                {
                    
                    MessageBox.Show("学员信息修改成功！", "提示信息");
                    
                    this.DialogResult = DialogResult.OK;//返回修改成功的信息
                    this.Close();

                }

            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
            }
            
            #endregion
        }

       

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
   
}
