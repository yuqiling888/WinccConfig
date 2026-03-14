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

namespace StudentGuanli
{
    public partial class FrmStudentManage : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();
        List<StudentExt> objStudeList = new List<StudentExt>();
        public FrmStudentManage()
        {
            InitializeComponent();
            this.comboBoxStudentClass.DataSource = objClassService.GetAllClass();
            this.comboBoxStudentClass.DisplayMember = "ClassName";
            this.comboBoxStudentClass.ValueMember = "ClassId";
            this.comboBoxStudentClass.SelectedIndex = -1; //默认不选中

            this.dgvStudentList.AutoGenerateColumns = false;
        }

        /// <summary>
        /// 按班级查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            StudentService objStudentService = new StudentService();
            if (comboBoxStudentClass.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级", "信息提示");
                return;
            }
            //this.dataGridViewStudentList.AutoGenerateColumns = false;//禁止生成其它列
            //执行查询
            objStudeList = objStudentService.GetStudentByClass(this.comboBoxStudentClass.Text);
            this.dgvStudentList.DataSource = this.objStudeList;
            new Common.DataGridViewStyle().DgvStyle1(this.dgvStudentList);
        }

        /// <summary>
        /// 按学号精确查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmitQuery_Click(object sender, EventArgs e)
        {
            if (this.textBoxInStudentId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入学号", "信息提示");
                this.textBoxInStudentId.Focus();
                return;
            }
            //进一步验证输入必须是数字，（请使用正则表达式.......）
            StudentExt objStudent = objStudentService.GetStudentByStudentId(this.textBoxInStudentId.Text.Trim());
            if (objStudent == null)
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
                buttonSubmitQuery_Click(null, null);

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
                if (this.dgvStudentList.RowCount == 0)
                {
                    MessageBox.Show("没有任何要修改的学员信息", "信息提示");
                    return;
                }
                if (this.dgvStudentList.CurrentRow == null)
                {
                    MessageBox.Show("请选中要修改的学员信息", "信息提示");
                    return;
                }
                //获取学号
                string StudentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
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
            if (this.dgvStudentList.CurrentRow != null)
            {
                string StudentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
                this.textBoxInStudentId.Text = StudentId;
                buttonSubmitQuery_Click(null, null);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("没有任何要删除的学员信息", "信息提示");
                return;
            }
            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选中要删除的学员信息", "信息提示");
                return;
            }
            //删除确认
            string studentName = this.dgvStudentList.CurrentRow.Cells["StudentName"].Value.ToString();
            DialogResult result = MessageBox.Show("确认要删除学员  [" + studentName + "]  吗？", "删除询问",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            //获取学号并删除除
            string StudentId = this.dgvStudentList.CurrentRow.Cells["StudentId"].Value.ToString();
            try
            {
                if (objStudentService.DeleteStudentById(StudentId) == 1)
                {
                    buttonFind_Click(null, null);  //  同步刷新修改信息（适合查询量小的数据）
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "提示信息");
            }


        }

        private void FrmStudentManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗？", "退出询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
             this.Close();
        }

        //添加行号
        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Common.DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList, e);
        }

        #region 排序
        class NameDESC : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return y.StudentName.CompareTo(x.StudentName);
            }
        }

        class StudntIdDESC : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return y.StudentId.CompareTo(x.StudentId);
            }
        }

        #endregion

        /// <summary>
        /// 姓名降序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNameDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0) return;   //如果列表的列数为0，即没有数据
            this.objStudeList.Sort(new NameDESC());
            this.dgvStudentList.Refresh();

        }

        private void btnStudentIdDESC_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0) return;   //如果列表的列数为0，即没有数据
            this.objStudeList.Sort(new StudntIdDESC());
            this.dgvStudentList.Refresh();
        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
