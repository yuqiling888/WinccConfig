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

namespace StudentGuanli.Frm
{
    public partial class FrmNPOI : Form
    {
        public FrmNPOI()
        {
            InitializeComponent();

            this.dgvProductList1
        }

        private void FrmNPOI_Load(object sender, EventArgs e)
        {

        }

        //将集合导出到Excel文件
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            //设置导出的列标题（实际开发中，也可以放到xml文件中)
            Dictionary<string, string> columnNames = new Dictionary<string, string>();
            columnNames.Add("StudentName", "学生姓名");
            columnNames.Add("Gender","性别");
            columnNames.Add("Birthday","出生日期");
            columnNames.Add("StudentIdNo", "身份证号");
            columnNames.Add("Age", "年龄");
            columnNames.Add("PhoneNumber", "电话号码");
            columnNames.Add("StudentAddress", "地址");
            columnNames.Add("ClassId", "班级编号");
            columnNames.Add("ClassName", "班级名称");
            columnNames.Add("CardNo", "考勤卡号");
            //调用导出方法：fileName将来可以通过让用户选择路径方式获取
            bool result=NPOIService.ExportToExcel<PRODUCT>("productList.xls",
                this.Ex)

            

        }
    }
}
