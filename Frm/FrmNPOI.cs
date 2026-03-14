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
using NPOI.SS.Formula.Functions;
using Models;
using System.Diagnostics;

namespace StudentGuanli
{
    public partial class FrmNPOI : Form
    {
        private NPOIService studentService = new NPOIService();
        private StudentService objStudentService = new StudentService();
        private List<Student> ExportStudentList = null;
        private List<Student> ImportStudentList = null;
        private StudentExt objStudeList = new StudentExt();

        private StudentClassService objClassService = new StudentClassService();
        public FrmNPOI()
        {
            InitializeComponent();

            this.cboClassName1.DataSource = objClassService.GetAllClass();
            this.cboClassName1.DisplayMember = "ClassName";
            this.cboClassName1.ValueMember = "ClassId";
            this.cboClassName1.SelectedIndex = -1; //默认不选中

            this.dgvStudentList1.AutoGenerateColumns = false;
            this.dgvStudentList2.AutoGenerateColumns = false;



            
        }

        private void FrmNPOI_Load(object sender, EventArgs e)
        {

        }

        //将集合导出到Excel文件
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //设置导出的列标题（实际开发中，也可以放到xml文件中)
            Dictionary<string, string> columnNames = new Dictionary<string, string>();
            columnNames.Add("StudentId", "学号");
            columnNames.Add("StudentName", "学生姓名");
            columnNames.Add("Gender","性别");
            columnNames.Add("Birthday","出生日期");
            columnNames.Add("StudentIdNo","身份证号");
            columnNames.Add("PhoneNumber", "电话号码");
           //columnNames.Add("ClassName", "班级名称");
            columnNames.Add("ClassId", "班级编号");
            columnNames.Add("Age","年龄");
            
            columnNames.Add("StudentAddress", "地址");
           // columnNames.Add("CSharp", "C#");
            //columnNames.Add("SQLServerDB", "数据库");
           // columnNames.Add("DTime", "签到时间");
            columnNames.Add("CardNo","考勤卡号");          
            
            
            //columnNames.Add("StuImage", "图片");
           //columnNames.Add("OperationStatus", "状态");
            
            
            //调用导出方法：fileName将来可以通过让用户选择路径方式获取
            bool result = NPOIService.ExportToExcel<Student>("StudentExtlist.xls",
                this.ExportStudentList, columnNames);
            if(result)
            {
                DialogResult dialog = MessageBox.Show("导出成功！是否打开文件", "导出成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog==DialogResult.Yes)
                {
                    Process.Start("StudentExtlist.xls");
                }
                
            }

        }

        private void buttonSubmitQuery_Click(object sender, EventArgs e)
        {

            //StudentService objStudentService = new StudentService();
           
            if (cboClassName1.SelectedIndex == -1)
            {
                MessageBox.Show("请选择班级", "信息提示");
                return;
            }
            //this.dataGridViewStudentList.AutoGenerateColumns = false;//禁止生成其它列
            //执行查询
            ExportStudentList = objStudentService.GetNoStudentExtByClass(this.cboClassName1.Text);
            this.dgvStudentList1.DataSource = this.ExportStudentList;
            new Common.DataGridViewStyle().DgvStyle1(this.dgvStudentList1);

        }
        //将Excel导入集登工在DataGridViex显示
        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            //打开文件
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if(result==DialogResult.OK)
            {
                string path = openFile.FileName;//获取文件路径
                this.ImportStudentList = NPOIService.ImportToList<Student>(path);
                //显示数据
                this.dgvStudentList2.DataSource = null;
                this.dgvStudentList2.DataSource = this.ImportStudentList;
            }
        }
    }
}
