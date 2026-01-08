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
    public partial class FrmScoreAnalyse : Form
    {
        private StudentService objSCorece = new StudentService();
        public FrmScoreAnalyse()
        {
            InitializeComponent();
        }


        


        private void buttonWholeSchoolScore_Click(object sender, EventArgs e)
        {
            this.labelScoerCount.Text = "全校考试成绩";
            //查询成绩列表
            this.dataGridViewScoreList.AutoGenerateColumns = false;
            this.dataGridViewScoreList.DataSource = objSCorece.GetScoreList("");



            //查询并显示成绩列表
   //         Dictionary<string, string> dic = objSCorece.GetScroreInfo();
   //         this.textBoxNumberOfExaminess.Text = dic["stuCount"];
            //this.textBoxAbsentCount.Text = dic["absentCount"];
            //this.textBoxAvgSQLScore.Text = dic["avgSQLScore"];
            //this.textBoxAvgCSharp.Text = dic["avgCSharp"];
            ////显示缺考的人员姓名
  //          List<string> list = objSCorece.GetAbsentList();
            this.listBoxAbsensList.Items.Clear();
        //    this.listBoxAbsensList.Items.AddRange(list.ToArray());

        }
       

        private void CloseWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScoreQueryList_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            FrmDemo.objFrmScoreQueryList = null;

        }

        private void textBoxNumberOfExaminess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
