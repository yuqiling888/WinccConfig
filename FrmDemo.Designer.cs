
namespace StudentManager
{
    partial class FrmDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnfo = new System.Windows.Forms.Label();
            this.BtnGet = new System.Windows.Forms.Button();
            this.lblCurretUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.buttonQueryStudent = new System.Windows.Forms.Button();
            this.buttonScoreQuery = new System.Windows.Forms.Button();
            this.buttonAttendanceManage = new System.Windows.Forms.Button();
            this.buttonScoreBrowse = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnfo
            // 
            this.lblnfo.AutoSize = true;
            this.lblnfo.Location = new System.Drawing.Point(139, 395);
            this.lblnfo.Name = "lblnfo";
            this.lblnfo.Size = new System.Drawing.Size(71, 12);
            this.lblnfo.TabIndex = 4;
            this.lblnfo.Text = "1班学生总数";
            // 
            // BtnGet
            // 
            this.BtnGet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGet.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.BtnGet.Location = new System.Drawing.Point(279, 374);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(178, 54);
            this.BtnGet.TabIndex = 5;
            this.BtnGet.Text = "获取1班和2班学生总数";
            this.BtnGet.UseVisualStyleBackColor = true;
           
            // 
            // lblCurretUser
            // 
            this.lblCurretUser.AutoSize = true;
            this.lblCurretUser.Location = new System.Drawing.Point(116, 425);
            this.lblCurretUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurretUser.Name = "lblCurretUser";
            this.lblCurretUser.Size = new System.Drawing.Size(41, 12);
            this.lblCurretUser.TabIndex = 7;
            this.lblCurretUser.Text = "用户名";
            this.lblCurretUser.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "当前用户：";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(18, 235);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "添加学生";
            this.btnAddStudent.UseVisualStyleBackColor = true;
           // this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // buttonQueryStudent
            // 
            this.buttonQueryStudent.Location = new System.Drawing.Point(18, 293);
            this.buttonQueryStudent.Name = "buttonQueryStudent";
            this.buttonQueryStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonQueryStudent.TabIndex = 2;
            this.buttonQueryStudent.Text = "查询学生";
            this.buttonQueryStudent.UseVisualStyleBackColor = true;
            //this.buttonQueryStudent.Click += new System.EventHandler(this.buttonQueryStudent_Click);
            // 
            // buttonScoreQuery
            // 
            this.buttonScoreQuery.Location = new System.Drawing.Point(18, 264);
            this.buttonScoreQuery.Name = "buttonScoreQuery";
            this.buttonScoreQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonScoreQuery.TabIndex = 1;
            this.buttonScoreQuery.Text = "成绩查询";
            this.buttonScoreQuery.UseVisualStyleBackColor = true;
            //this.buttonScoreQuery.Click += new System.EventHandler(this.buttonScoreQuery_Click);
            // 
            // buttonAttendanceManage
            // 
            this.buttonAttendanceManage.Location = new System.Drawing.Point(18, 362);
            this.buttonAttendanceManage.Name = "buttonAttendanceManage";
            this.buttonAttendanceManage.Size = new System.Drawing.Size(75, 23);
            this.buttonAttendanceManage.TabIndex = 8;
            this.buttonAttendanceManage.Text = "考勤管理";
            this.buttonAttendanceManage.UseVisualStyleBackColor = true;
           // this.buttonAttendanceManage.Click += new System.EventHandler(this.buttonAttendanceManage_Click);
            // 
            // buttonScoreBrowse
            // 
            this.buttonScoreBrowse.Location = new System.Drawing.Point(118, 293);
            this.buttonScoreBrowse.Name = "buttonScoreBrowse";
            this.buttonScoreBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonScoreBrowse.TabIndex = 9;
            this.buttonScoreBrowse.Text = "成绩浏览";
            this.buttonScoreBrowse.UseVisualStyleBackColor = true;
           // this.buttonScoreBrowse.Click += new System.EventHandler(this.buttonScoreBrowse_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.学员管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.考勤管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 学员管理ToolStripMenuItem
            // 
            this.学员管理ToolStripMenuItem.Name = "学员管理ToolStripMenuItem";
            this.学员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学员管理ToolStripMenuItem.Text = "学员管理";
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonScoreBrowse);
            this.Controls.Add(this.buttonAttendanceManage);
            this.Controls.Add(this.buttonScoreQuery);
            this.Controls.Add(this.buttonQueryStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurretUser);
            this.Controls.Add(this.BtnGet);
            this.Controls.Add(this.lblnfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDemo";
            this.Text = "测试前台代码和后台代码分离";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemo_FormClosing);
            this.Load += new System.EventHandler(this.FrmDemo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnfo;
        private System.Windows.Forms.Button BtnGet;
        private System.Windows.Forms.Label lblCurretUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button buttonQueryStudent;
        private System.Windows.Forms.Button buttonScoreQuery;
        private System.Windows.Forms.Button buttonAttendanceManage;
        private System.Windows.Forms.Button buttonScoreBrowse;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}

