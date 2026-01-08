using Models;
using StudentGuanli;
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



namespace StudentGuanli
{
    public partial class FrmModifyPwd : Form
    {
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
            #region 密码验证
            //1.数据验证
            if (this.tbFormer.Text.Length==0)
            {
                MessageBox.Show("原密码不能为空", "输入提示");
                this.tbFormer.Focus();
                return;
            }

            //2.判断原密码和登录保存的密码一致
            if(this.tbFormer.Text.Trim()!=Program.ObjCurrentAdmin.LoginPwd)
            {
                MessageBox.Show("输入的密码与原密码不一致", "信息提示");
                this.tbFormer.Focus();
                this.tbFormer.SelectAll();
                return;
            }
            //3.判断新密码的长度
            if(this.tbNewPwd.Text.Length<5)
            {
                MessageBox.Show("新密码长度不能小于5位", "信息提示");
                this.tbNewPwd.Focus();
                this.tbNewPwd.SelectAll();
                return;
            }
            //4.判断两次输入的密码不一致
            if(this.tbNewPwd.Text!=this.tbNewPwd2.Text)
            {
                MessageBox.Show("新密码两次输入不一致", "信息提示");
                
                return;
            }
            #endregion
            try
            {
                SysAdmin objAdmin = new SysAdmin()
                {
                    LoginId = Program.ObjCurrentAdmin.LoginId,
                    LoginPwd = this.tbNewPwd.Text.Trim(),
                 };
                if(new SysAdminService().ModifyPwd(objAdmin)==1)
                {
                    MessageBox.Show("密码修改成功，请妥善保管", "信息提示");
                    Program.ObjCurrentAdmin.LoginPwd = this.tbNewPwd.Text.Trim();
                    this.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }

            //3.数据访问

            //4.返回结果
        }

        private void tbFormer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
