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

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        public FrmStudentManage()
        {
            InitializeComponent();
            this.comboBoxStudentClass.DataSource = objClassService.GetAllClasses();
            this.comboBoxStudentClass.DisplayMember = "ClassName";
            this.comboBoxStudentClass.ValueMember = "ClassId";
            this.comboBoxStudentClass.SelectedIndex = -1; //默认不选中
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            StudentService objStudentService = new StudentService();
            if(comboBoxStudentClass.SelectedIndex==-1)
            {
                MessageBox.Show("请选择班级", "信息提示");
                return;
            }
           //this.dataGridViewStudentList.AutoGenerateColumns = false;//禁止生成其它列
            //执行查询

            this.dataGridViewStudentList.DataSource = objStudentService.GetStudentByClass(this.comboBoxStudentClass.Text);
        }

        private void buttonSubmitQuery_Click(object sender, EventArgs e)
        {
            if(this.textBoxInStudentId.Text.Trim().Length==0)
            {
                MessageBox.Show("请输入学号", "信息提示");
                this.textBoxInStudentId.Focus();
                return;
            }
            //进一步验证输入必须是数字，（请使用正则表达式.......）
            StudentExt objStudent = objStudentService.GetStudentByStudentId(this.textBoxInStudentId.Text.Trim());
            if(objStudent==null)
            {
                MessageBox.Show("学员信息不存在", "信息提示");
                this.textBoxInStudentId.Focus();
                return;
            }

          
            else  //在学员详细信息窗体显示
            {
                FrmStudentInfo objFrmStudentInfo = new FrmStudentInfo(objStudent);
                objFrmStudentInfo.Show();
            }

        }

        private void textBoxInStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && this.textBoxInStudentId.Text.Trim().Length != 0)
            {
                buttonSubmitQuery_Click(null,null);
                
            }
        }

       

        private void FrmStudentManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDemo.objFrmStudentManage = null;
        }

        /// <summary>
        /// 右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAmend_Click(null, null);
        }

        /// <summary>
        /// 修改学员对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAmend_Click(object sender, EventArgs e)
        {
            {
                if (this.dataGridViewStudentList.RowCount == 0)
                {
                    MessageBox.Show("没有任何要修改的学员信息", "信息提示");
                    return;
                }
                if (this.dataGridViewStudentList.CurrentRow == null)
                {
                    MessageBox.Show("请选中要修改的学员信息", "信息提示");
                    return;
                }
                //获取学号
                string StudentId = this.dataGridViewStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
                //获取要修改学员的详细信息
                StudentExt objStudent = objStudentService.GetStudentByStudentId(StudentId);
                //显示要修改学员信息的窗口
                FrmModifyStudent objFrmModify = new FrmModifyStudent(objStudent);
                //objFrmModify.ShowDialog();
                DialogResult result = objFrmModify.ShowDialog();
                if (result == DialogResult.OK)
                {
                    buttonFind_Click(null, null);  //  同步刷新修改信息（适合查询量小的数据）

                }

            }
    }
    
       

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 双击查询学员详细情况
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dataGridViewStudentList.CurrentRow!=null)
            {
                string StudentId = this.dataGridViewStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
                this.textBoxInStudentId.Text = StudentId;
                buttonSubmitQuery_Click(null, null);
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewStudentList.RowCount == 0)
            {
                MessageBox.Show("没有任何要删除的学员信息", "信息提示");
                return;
            }
            if (this.dataGridViewStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选中要删除的学员信息", "信息提示");
                return;
            }
            //删除确认
            string studentName = this.dataGridViewStudentList.CurrentRow.Cells["StudentName"].Value.ToString();
            DialogResult result = MessageBox.Show("确认要删除学员  ["+studentName+"]  吗？", "删除询问", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取学号并删除除
            string StudentId = this.dataGridViewStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            try
            {
                if(objStudentService.DeleteStudentById(StudentId)==1)
                {
                    buttonFind_Click(null, null);  //  同步刷新修改信息（适合查询量小的数据）
                }

            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message,"提示信息");
            }


        }

        private void FrmStudentManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？", "退出询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result!=DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
           // FrmStudentManage_FormClosing(null, e);
        }
    }
}
