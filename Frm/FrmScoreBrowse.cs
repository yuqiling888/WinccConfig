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

using System.Windows.Forms.DataVisualization.Charting;

namespace StudentGuanli
{
    public partial class FrmScoreBrowse : Form
    {
        private StudentClassService objClassService = new StudentClassService();
        private ScoreListService objScoreListService = new ScoreListService();
        private DataTable dtScoreList = null;

        #region 数据图表新建变量

        private SuperChart superchart = null;
        private List<ChartData> chartDataList = new List<ChartData>();//用来保存数据的集合
        #endregion
        public FrmScoreBrowse()
        {
            InitializeComponent();
            //显示班级下拉框
            //  DataTable dt = objClassService.GetAllClass().Tables[0];
            //     this.comboBoxStudentClass.DataSource = dt;
            this.comboBoxStudentClass.ValueMember = "ClassId";
            this.comboBoxStudentClass.DisplayMember = "ClassName";
            //显示全部成绩
            //dtScoreList = objScoreListService.GetStudentScore().Tables[0];
            this.dataGridViewScoreList.DataSource = dtScoreList;


            //初始化自定义图表设置对象
            superchart = new SuperChart(this.chart1);
            Init();//实际开发中，可以从数据库或其他数据源查询

        }

        private void Init()
        {
            //创建一个随机数用来生成数据
            Random random = new Random();
            chartDataList.Add(new ChartData("北京", random.Next(100)));
            chartDataList.Add(new ChartData("上海", random.Next(100)));
            chartDataList.Add(new ChartData("杭州", random.Next(100)));
            chartDataList.Add(new ChartData("深圳", random.Next(100)));
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

        //横条形图
        private void btnhongtiao_Click(object sender, EventArgs e)
        {
            this.superchart.ShowChart(SeriesChartType.Bar, chartDataList);
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            this.superchart.ShowChart(SeriesChartType.Pie, chartDataList);
        }

        private void btnCylindricality_Click(object sender, EventArgs e)
        {
            this.superchart.ShowChart(SeriesChartType.Column, chartDataList);

        }

        private void btnyuanhuan_Click(object sender, EventArgs e)
        {
            this.superchart.ShowChart(SeriesChartType.Doughnut, chartDataList);

        }
    }   
}
