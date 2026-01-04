
namespace StudentManager
{
    partial class FrmScoreAnalyse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelStudentClass = new System.Windows.Forms.Label();
            this.comboBoxStudentClass = new System.Windows.Forms.ComboBox();
            this.buttonWholeSchoolScore = new System.Windows.Forms.Button();
            this.dataGridViewScoreList = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelScoerCount = new System.Windows.Forms.Label();
            this.labelNumberOfExaminees = new System.Windows.Forms.Label();
            this.textBoxNumberOfExaminess = new System.Windows.Forms.TextBox();
            this.textBoxAbsentCount = new System.Windows.Forms.TextBox();
            this.labelNumberOfNoExaminess = new System.Windows.Forms.Label();
            this.textBoxAvgSQLScore = new System.Windows.Forms.TextBox();
            this.labelDBAverage = new System.Windows.Forms.Label();
            this.textBoxAvgCSharp = new System.Windows.Forms.TextBox();
            this.labelCAverage = new System.Windows.Forms.Label();
            this.labelNoExaminess = new System.Windows.Forms.Label();
            this.listBoxAbsensList = new System.Windows.Forms.ListBox();
            this.CloseWindows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentClass
            // 
            this.labelStudentClass.AutoSize = true;
            this.labelStudentClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStudentClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStudentClass.Location = new System.Drawing.Point(82, 27);
            this.labelStudentClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentClass.Name = "labelStudentClass";
            this.labelStudentClass.Size = new System.Drawing.Size(88, 16);
            this.labelStudentClass.TabIndex = 0;
            this.labelStudentClass.Text = "学员班级：";
            // 
            // comboBoxStudentClass
            // 
            this.comboBoxStudentClass.FormattingEnabled = true;
            this.comboBoxStudentClass.Location = new System.Drawing.Point(189, 27);
            this.comboBoxStudentClass.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStudentClass.Name = "comboBoxStudentClass";
            this.comboBoxStudentClass.Size = new System.Drawing.Size(160, 24);
            this.comboBoxStudentClass.TabIndex = 1;
            // 
            // buttonWholeSchoolScore
            // 
            this.buttonWholeSchoolScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonWholeSchoolScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonWholeSchoolScore.Location = new System.Drawing.Point(470, 23);
            this.buttonWholeSchoolScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWholeSchoolScore.Name = "buttonWholeSchoolScore";
            this.buttonWholeSchoolScore.Size = new System.Drawing.Size(249, 31);
            this.buttonWholeSchoolScore.TabIndex = 2;
            this.buttonWholeSchoolScore.Text = "统计全校考试信息";
            this.buttonWholeSchoolScore.UseVisualStyleBackColor = true;
            this.buttonWholeSchoolScore.Click += new System.EventHandler(this.buttonWholeSchoolScore_Click);
            // 
            // dataGridViewScoreList
            // 
            this.dataGridViewScoreList.AllowUserToAddRows = false;
            this.dataGridViewScoreList.AllowUserToDeleteRows = false;
            this.dataGridViewScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.ClassName,
            this.CSharp,
            this.SQLScore});
            this.dataGridViewScoreList.Location = new System.Drawing.Point(48, 59);
            this.dataGridViewScoreList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewScoreList.Name = "dataGridViewScoreList";
            this.dataGridViewScoreList.ReadOnly = true;
            this.dataGridViewScoreList.RowTemplate.Height = 23;
            this.dataGridViewScoreList.Size = new System.Drawing.Size(671, 304);
            this.dataGridViewScoreList.TabIndex = 3;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 120;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 150;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // CSharp
            // 
            this.CSharp.DataPropertyName = "CSharp";
            this.CSharp.HeaderText = "C#成绩";
            this.CSharp.Name = "CSharp";
            this.CSharp.ReadOnly = true;
            this.CSharp.Width = 120;
            // 
            // SQLScore
            // 
            this.SQLScore.DataPropertyName = "SQLScore";
            this.SQLScore.HeaderText = "数据库成绩";
            this.SQLScore.Name = "SQLScore";
            this.SQLScore.ReadOnly = true;
            this.SQLScore.Width = 120;
            // 
            // labelScoerCount
            // 
            this.labelScoerCount.AutoSize = true;
            this.labelScoerCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScoerCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelScoerCount.Location = new System.Drawing.Point(34, 408);
            this.labelScoerCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScoerCount.Name = "labelScoerCount";
            this.labelScoerCount.Size = new System.Drawing.Size(136, 16);
            this.labelScoerCount.TabIndex = 4;
            this.labelScoerCount.Text = "全校考试成绩统计";
            // 
            // labelNumberOfExaminees
            // 
            this.labelNumberOfExaminees.AutoSize = true;
            this.labelNumberOfExaminees.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNumberOfExaminees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNumberOfExaminees.Location = new System.Drawing.Point(34, 446);
            this.labelNumberOfExaminees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfExaminees.Name = "labelNumberOfExaminees";
            this.labelNumberOfExaminees.Size = new System.Drawing.Size(104, 16);
            this.labelNumberOfExaminees.TabIndex = 5;
            this.labelNumberOfExaminees.Text = "参考总人数：";
            // 
            // textBoxNumberOfExaminess
            // 
            this.textBoxNumberOfExaminess.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNumberOfExaminess.Location = new System.Drawing.Point(146, 446);
            this.textBoxNumberOfExaminess.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumberOfExaminess.Name = "textBoxNumberOfExaminess";
            this.textBoxNumberOfExaminess.Size = new System.Drawing.Size(112, 26);
            this.textBoxNumberOfExaminess.TabIndex = 6;
            // 
            // textBoxAbsentCount
            // 
            this.textBoxAbsentCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAbsentCount.Location = new System.Drawing.Point(360, 449);
            this.textBoxAbsentCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAbsentCount.Name = "textBoxAbsentCount";
            this.textBoxAbsentCount.Size = new System.Drawing.Size(104, 26);
            this.textBoxAbsentCount.TabIndex = 8;
            // 
            // labelNumberOfNoExaminess
            // 
            this.labelNumberOfNoExaminess.AutoSize = true;
            this.labelNumberOfNoExaminess.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNumberOfNoExaminess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNumberOfNoExaminess.Location = new System.Drawing.Point(266, 449);
            this.labelNumberOfNoExaminess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfNoExaminess.Name = "labelNumberOfNoExaminess";
            this.labelNumberOfNoExaminess.Size = new System.Drawing.Size(104, 16);
            this.labelNumberOfNoExaminess.TabIndex = 7;
            this.labelNumberOfNoExaminess.Text = "缺考总人数：";
            // 
            // textBoxAvgSQLScore
            // 
            this.textBoxAvgSQLScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAvgSQLScore.Location = new System.Drawing.Point(360, 508);
            this.textBoxAvgSQLScore.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAvgSQLScore.Name = "textBoxAvgSQLScore";
            this.textBoxAvgSQLScore.Size = new System.Drawing.Size(104, 26);
            this.textBoxAvgSQLScore.TabIndex = 12;
            // 
            // labelDBAverage
            // 
            this.labelDBAverage.AutoSize = true;
            this.labelDBAverage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDBAverage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDBAverage.Location = new System.Drawing.Point(266, 508);
            this.labelDBAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDBAverage.Name = "labelDBAverage";
            this.labelDBAverage.Size = new System.Drawing.Size(88, 16);
            this.labelDBAverage.TabIndex = 11;
            this.labelDBAverage.Text = "DB平均分：";
            // 
            // textBoxAvgCSharp
            // 
            this.textBoxAvgCSharp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAvgCSharp.Location = new System.Drawing.Point(146, 505);
            this.textBoxAvgCSharp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAvgCSharp.Name = "textBoxAvgCSharp";
            this.textBoxAvgCSharp.Size = new System.Drawing.Size(112, 26);
            this.textBoxAvgCSharp.TabIndex = 10;
            // 
            // labelCAverage
            // 
            this.labelCAverage.AutoSize = true;
            this.labelCAverage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCAverage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCAverage.Location = new System.Drawing.Point(34, 505);
            this.labelCAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCAverage.Name = "labelCAverage";
            this.labelCAverage.Size = new System.Drawing.Size(88, 16);
            this.labelCAverage.TabIndex = 9;
            this.labelCAverage.Text = "C#平均分：";
            // 
            // labelNoExaminess
            // 
            this.labelNoExaminess.AutoSize = true;
            this.labelNoExaminess.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNoExaminess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNoExaminess.Location = new System.Drawing.Point(489, 408);
            this.labelNoExaminess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoExaminess.Name = "labelNoExaminess";
            this.labelNoExaminess.Size = new System.Drawing.Size(120, 16);
            this.labelNoExaminess.TabIndex = 14;
            this.labelNoExaminess.Text = "缺考人员名单：";
            // 
            // listBoxAbsensList
            // 
            this.listBoxAbsensList.FormattingEnabled = true;
            this.listBoxAbsensList.ItemHeight = 16;
            this.listBoxAbsensList.Location = new System.Drawing.Point(492, 440);
            this.listBoxAbsensList.Name = "listBoxAbsensList";
            this.listBoxAbsensList.Size = new System.Drawing.Size(248, 100);
            this.listBoxAbsensList.TabIndex = 16;
            // 
            // CloseWindows
            // 
            this.CloseWindows.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseWindows.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseWindows.Location = new System.Drawing.Point(670, 556);
            this.CloseWindows.Margin = new System.Windows.Forms.Padding(4);
            this.CloseWindows.Name = "CloseWindows";
            this.CloseWindows.Size = new System.Drawing.Size(94, 31);
            this.CloseWindows.TabIndex = 17;
            this.CloseWindows.Text = "关闭窗口";
            this.CloseWindows.UseVisualStyleBackColor = true;
            this.CloseWindows.Click += new System.EventHandler(this.CloseWindows_Click);
            // 
            // ScoreQueryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(805, 600);
            this.Controls.Add(this.CloseWindows);
            this.Controls.Add(this.listBoxAbsensList);
            this.Controls.Add(this.labelNoExaminess);
            this.Controls.Add(this.textBoxAvgSQLScore);
            this.Controls.Add(this.labelDBAverage);
            this.Controls.Add(this.textBoxAvgCSharp);
            this.Controls.Add(this.labelCAverage);
            this.Controls.Add(this.textBoxAbsentCount);
            this.Controls.Add(this.labelNumberOfNoExaminess);
            this.Controls.Add(this.textBoxNumberOfExaminess);
            this.Controls.Add(this.labelNumberOfExaminees);
            this.Controls.Add(this.labelScoerCount);
            this.Controls.Add(this.dataGridViewScoreList);
            this.Controls.Add(this.buttonWholeSchoolScore);
            this.Controls.Add(this.comboBoxStudentClass);
            this.Controls.Add(this.labelStudentClass);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScoreQueryList";
            this.Text = "成绩查询";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScoreQueryList_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentClass;
        private System.Windows.Forms.ComboBox comboBoxStudentClass;
        private System.Windows.Forms.Button buttonWholeSchoolScore;
        private System.Windows.Forms.DataGridView dataGridViewScoreList;
        private System.Windows.Forms.Label labelScoerCount;
        private System.Windows.Forms.Label labelNumberOfExaminees;
        private System.Windows.Forms.TextBox textBoxNumberOfExaminess;
        private System.Windows.Forms.TextBox textBoxAbsentCount;
        private System.Windows.Forms.Label labelNumberOfNoExaminess;
        private System.Windows.Forms.TextBox textBoxAvgSQLScore;
        private System.Windows.Forms.Label labelDBAverage;
        private System.Windows.Forms.TextBox textBoxAvgCSharp;
        private System.Windows.Forms.Label labelCAverage;
        private System.Windows.Forms.Label labelNoExaminess;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLScore;
        private System.Windows.Forms.ListBox listBoxAbsensList;
        private System.Windows.Forms.Button CloseWindows;
    }
}