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
    public partial class FrmScoreReport : Form
    {
        private StudentClassService objStudentClassService = new StudentClassService();
        private ScoreListService objScoreListService = new ScoreListService();
        private reportService objreportService = new reportService();
        public FrmScoreReport()
        {
            InitializeComponent();
            this.cbStudentClass.DataSource = objStudentClassService.GetAllClass();

            this.cbStudentClass.ValueMember = "ClassId";
            this.cbStudentClass.DisplayMember = "ClassName";
        }

        private void FrmScoreReport_Load(object sender, EventArgs e)
        {



            this.reportViewer1.RefreshReport();
        }

        //查询并预临览
        private void btnQudery_Click(object sender, EventArgs e)
        {
            //根据班级查询
            List<StudentExt> scoreList = objreportService.GetScoreByClassName(this.cbStudentClass.Text);
            //设置报表视图属性
            //this.reportViewer1.LocalReport.DisplayName = "学员成绩表";
            this.reportViewer1.LocalReport.DataSources.Clear();
            //添加数据集，为成绩集合绑定数据
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", scoreList));
            //显示
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
