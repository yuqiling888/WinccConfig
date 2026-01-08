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
    public partial class AttendanceCheck : Form
    {
        public AttendanceCheck()
        {
            InitializeComponent();
            this.textBoxYear.Text = DateTime.Now.Year.ToString();
            this.textBoxMonth.Text = DateTime.Now.Month.ToString();
        }

        private void AttendanceCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmDemo.objAttendanceCheck = null;
        }
    }
}
