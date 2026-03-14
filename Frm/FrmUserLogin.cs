using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using StudentGuanli;
using System.Data.SqlClient;


namespace StudentGuanli
{
    public partial class FrmUserLogin : Form
    {
        //创建数据访问类对象
        private SysAdminService ObjSysAdminServer = new SysAdminService();
        public FrmUserLogin()
        {
            InitializeComponent();

            //
        }

            


    
        private void btnLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //【1】数据验证
            if(this.txtLoginId.Text.Length==0)
            {
                MessageBox.Show("请输入帐号","提示信息");
                this.txtLoginId.Focus();
                return;
            }
            if (Common.DataValidate.IsInteger(this.txtLoginId.Text.Trim())) 
            {
                MessageBox.Show("登录帐号必须为正整数", "提示信息");
                this.txtLoginId.Focus();
                return;
            }
            if(this.txtLoginPwd.Text.Length==0)
            {
                MessageBox.Show("请输入密码", "提示信息");
                this.txtLoginPwd.Focus();
                return;

            }
            //登录帐号和密码不能含危险字符


            //【2】封装对象（包含要提交的数据）
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim()

            };

            //【3】和后台交互
            try
            {
                
                Program.ObjCurrentAdmin = ObjSysAdminServer.AdminLogin(objAdmin);
                //【4】处理交互结果（保存交互数据，返回交互结果）
                if (Program.ObjCurrentAdmin!=null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("登录信息错误", "提示信息");
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"数据操作访问异常");
            }
            
            


        }

        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (this.txtLoginId.TextLength != 0)
                {
                    this.txtLoginPwd.Focus();
                }
            }

        }

        private void txtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                if(this.txtLoginPwd.TextLength!=0)
                {
                    btnLogin_Click_1(null, null);
                }
            }
        }
    }
}
