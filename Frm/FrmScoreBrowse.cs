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

namespace StudentManager
{
    public partial class FrmScoreBrowse : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private ScoreListService objScoreListService = new ScoreListService();
        private DataTable dtScoreList = null;
        public FrmScoreBrowse()
        {
            InitializeComponent();
            //显示班级下拉框
          //  DataTable dt = objClassService.GetAllClass().Tables[0];
       //     this.comboBoxStudentClass.DataSource = dt;
            this.comboBoxStudentClass.ValueMember = "ClassId";
            this.comboBoxStudentClass.DisplayMember = "ClassName";
            //显示全部成绩
         //   dtScoreList = objScoreListService.GetStudentScore().Tables[0];
            this.dataGridViewScoreList.DataSource = dtScoreList;

        }

        private void FrmScoreBrowse_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDemo.objScoreBrowse = null;
        }

        private void comboBoxStudentClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtScoreList == null) return;          
            this.dtScoreList.DefaultView.RowFilter = string.Format("ClassName='{0}'", this.comboBoxStudentClass.Text.Trim());

            

        }

        private void buttonAllScore_Click(object sender, EventArgs e)
        {
            if (dtScoreList == null) return;
            this.dtScoreList.DefaultView.RowFilter = "ClassName like '%%'";

        }

        private void textBoxScoreBrowse_TextChanged(object sender, EventArgs e)
        {
            if (dtScoreList == null) return;
            if (this.textBoxScoreBrowse.Text.Trim().Length == 0) return;
            if (Common.DataValidate.IsInteger(this.textBoxScoreBrowse.Text.Trim())) return;            
            this.dtScoreList.DefaultView.RowFilter = string.Format("CSharp>'{0}'", this.textBoxScoreBrowse.Text.Trim());

        }

        private void buttonCloseWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
