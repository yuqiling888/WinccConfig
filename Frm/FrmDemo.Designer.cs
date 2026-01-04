
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
            this.lblCurretUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnStudentManage = new System.Windows.Forms.Button();
            this.btnScoreAnalyse = new System.Windows.Forms.Button();
            this.btnAttendanceManage = new System.Windows.Forms.Button();
            this.btnScoreBrowse = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAttendanceCheck = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnAccountSwitch = new System.Windows.Forms.Button();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStudentManage = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurretUser
            // 
            this.lblCurretUser.AutoSize = true;
            this.lblCurretUser.Location = new System.Drawing.Point(93, 590);
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
            this.label1.Location = new System.Drawing.Point(24, 590);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "当前用户：";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(14, 219);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "添加学生";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.Location = new System.Drawing.Point(114, 219);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new System.Drawing.Size(75, 23);
            this.btnStudentManage.TabIndex = 2;
            this.btnStudentManage.Text = "学员管理";
            this.btnStudentManage.UseVisualStyleBackColor = true;
            this.btnStudentManage.Click += new System.EventHandler(this.btnStudentManage_Click);
            // 
            // btnScoreAnalyse
            // 
            this.btnScoreAnalyse.Location = new System.Drawing.Point(114, 305);
            this.btnScoreAnalyse.Name = "btnScoreAnalyse";
            this.btnScoreAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnScoreAnalyse.TabIndex = 1;
            this.btnScoreAnalyse.Text = "成绩分析";
            this.btnScoreAnalyse.UseVisualStyleBackColor = true;
            this.btnScoreAnalyse.Click += new System.EventHandler(this.buttonScoreQuery_Click);
            // 
            // btnAttendanceManage
            // 
            this.btnAttendanceManage.Location = new System.Drawing.Point(114, 260);
            this.btnAttendanceManage.Name = "btnAttendanceManage";
            this.btnAttendanceManage.Size = new System.Drawing.Size(75, 23);
            this.btnAttendanceManage.TabIndex = 8;
            this.btnAttendanceManage.Text = "考勤查询";
            this.btnAttendanceManage.UseVisualStyleBackColor = true;
            // 
            // btnScoreBrowse
            // 
            this.btnScoreBrowse.Location = new System.Drawing.Point(14, 305);
            this.btnScoreBrowse.Name = "btnScoreBrowse";
            this.btnScoreBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnScoreBrowse.TabIndex = 9;
            this.btnScoreBrowse.Text = "成绩浏览";
            this.btnScoreBrowse.UseVisualStyleBackColor = true;
            this.btnScoreBrowse.Click += new System.EventHandler(this.btnScoreBrowse_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(14, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // btnAttendanceCheck
            // 
            this.btnAttendanceCheck.Location = new System.Drawing.Point(14, 260);
            this.btnAttendanceCheck.Name = "btnAttendanceCheck";
            this.btnAttendanceCheck.Size = new System.Drawing.Size(75, 23);
            this.btnAttendanceCheck.TabIndex = 12;
            this.btnAttendanceCheck.Text = "考勤打卡";
            this.btnAttendanceCheck.UseVisualStyleBackColor = true;
            this.btnAttendanceCheck.Click += new System.EventHandler(this.btnAttendanceCheck_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(14, 352);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 14;
            this.btnChangePassword.Text = "密码修改";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnAccountSwitch
            // 
            this.btnAccountSwitch.Location = new System.Drawing.Point(114, 352);
            this.btnAccountSwitch.Name = "btnAccountSwitch";
            this.btnAccountSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnAccountSwitch.TabIndex = 13;
            this.btnAccountSwitch.Text = "账号切换";
            this.btnAccountSwitch.UseVisualStyleBackColor = true;
            this.btnAccountSwitch.Click += new System.EventHandler(this.btnAccountSwitch_Click);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 学员管理ToolStripMenuItem
            // 
            this.学员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStudent,
            this.tsmiStudentManage});
            this.学员管理ToolStripMenuItem.Name = "学员管理ToolStripMenuItem";
            this.学员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学员管理ToolStripMenuItem.Text = "学员管理";
            // 
            // tsmiAddStudent
            // 
            this.tsmiAddStudent.Name = "tsmiAddStudent";
            this.tsmiAddStudent.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddStudent.Text = "添加学生";
            this.tsmiAddStudent.Click += new System.EventHandler(this.tsmiAddStudent_Click);
            // 
            // tsmiStudentManage
            // 
            this.tsmiStudentManage.Name = "tsmiStudentManage";
            this.tsmiStudentManage.Size = new System.Drawing.Size(180, 22);
            this.tsmiStudentManage.Text = "学员管理";
            this.tsmiStudentManage.Click += new System.EventHandler(this.tsmiStudentManage_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1320, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Size = new System.Drawing.Size(150, 100);
            this.splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 618);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "版本号：";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(81, 618);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(29, 12);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "版本";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(22, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel1.Controls.Add(this.lblVersion);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddStudent);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnStudentManage);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurretUser);
            this.splitContainer1.Panel1.Controls.Add(this.btnChangePassword);
            this.splitContainer1.Panel1.Controls.Add(this.btnScoreAnalyse);
            this.splitContainer1.Panel1.Controls.Add(this.btnAccountSwitch);
            this.splitContainer1.Panel1.Controls.Add(this.btnAttendanceManage);
            this.splitContainer1.Panel1.Controls.Add(this.btnAttendanceCheck);
            this.splitContainer1.Panel1.Controls.Add(this.btnScoreBrowse);
            this.splitContainer1.Size = new System.Drawing.Size(1267, 659);
            this.splitContainer1.SplitterDistance = 467;
            this.splitContainer1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "系统升级";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "批量导入";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "访问官网";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 498);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "退出系统";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 720);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDemo";
            this.Text = "测试前台代码和后台代码分离";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemo_FormClosing);
            this.Load += new System.EventHandler(this.FrmDemo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurretUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnStudentManage;
        private System.Windows.Forms.Button btnScoreAnalyse;
        private System.Windows.Forms.Button btnAttendanceManage;
        private System.Windows.Forms.Button btnScoreBrowse;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAttendanceCheck;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnAccountSwitch;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStudent;
        private System.Windows.Forms.ToolStripMenuItem tsmiStudentManage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

