
namespace StudentManager
{
    partial class FrmScoreBrowse
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
            this.labelScoreBrowse = new System.Windows.Forms.Label();
            this.textBoxScoreBrowse = new System.Windows.Forms.TextBox();
            this.labeGrade = new System.Windows.Forms.Label();
            this.dataGridViewScoreList = new System.Windows.Forms.DataGridView();
            this.buttonAllScore = new System.Windows.Forms.Button();
            this.buttonCloseWindows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentClass
            // 
            this.labelStudentClass.AutoSize = true;
            this.labelStudentClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStudentClass.Location = new System.Drawing.Point(53, 52);
            this.labelStudentClass.Name = "labelStudentClass";
            this.labelStudentClass.Size = new System.Drawing.Size(80, 16);
            this.labelStudentClass.TabIndex = 0;
            this.labelStudentClass.Text = "学员班级:";
            // 
            // comboBoxStudentClass
            // 
            this.comboBoxStudentClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStudentClass.FormattingEnabled = true;
            this.comboBoxStudentClass.Location = new System.Drawing.Point(141, 49);
            this.comboBoxStudentClass.Name = "comboBoxStudentClass";
            this.comboBoxStudentClass.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStudentClass.TabIndex = 1;
            this.comboBoxStudentClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentClass_SelectedIndexChanged);
            // 
            // labelScoreBrowse
            // 
            this.labelScoreBrowse.AutoSize = true;
            this.labelScoreBrowse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelScoreBrowse.Location = new System.Drawing.Point(346, 52);
            this.labelScoreBrowse.Name = "labelScoreBrowse";
            this.labelScoreBrowse.Size = new System.Drawing.Size(160, 16);
            this.labelScoreBrowse.TabIndex = 2;
            this.labelScoreBrowse.Text = "按C#快速浏览： C# >";
            // 
            // textBoxScoreBrowse
            // 
            this.textBoxScoreBrowse.Location = new System.Drawing.Point(528, 53);
            this.textBoxScoreBrowse.Name = "textBoxScoreBrowse";
            this.textBoxScoreBrowse.Size = new System.Drawing.Size(100, 21);
            this.textBoxScoreBrowse.TabIndex = 3;
            this.textBoxScoreBrowse.TextChanged += new System.EventHandler(this.textBoxScoreBrowse_TextChanged);
            // 
            // labeGrade
            // 
            this.labeGrade.AutoSize = true;
            this.labeGrade.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeGrade.Location = new System.Drawing.Point(634, 53);
            this.labeGrade.Name = "labeGrade";
            this.labeGrade.Size = new System.Drawing.Size(24, 16);
            this.labeGrade.TabIndex = 4;
            this.labeGrade.Text = "分";
            // 
            // dataGridViewScoreList
            // 
            this.dataGridViewScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScoreList.Location = new System.Drawing.Point(65, 102);
            this.dataGridViewScoreList.Name = "dataGridViewScoreList";
            this.dataGridViewScoreList.RowTemplate.Height = 23;
            this.dataGridViewScoreList.Size = new System.Drawing.Size(605, 230);
            this.dataGridViewScoreList.TabIndex = 5;
            // 
            // buttonAllScore
            // 
            this.buttonAllScore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAllScore.Location = new System.Drawing.Point(65, 370);
            this.buttonAllScore.Name = "buttonAllScore";
            this.buttonAllScore.Size = new System.Drawing.Size(117, 40);
            this.buttonAllScore.TabIndex = 6;
            this.buttonAllScore.Text = "显示全部成绩";
            this.buttonAllScore.UseVisualStyleBackColor = true;
            this.buttonAllScore.Click += new System.EventHandler(this.buttonAllScore_Click);
            // 
            // buttonCloseWindows
            // 
            this.buttonCloseWindows.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCloseWindows.Location = new System.Drawing.Point(553, 359);
            this.buttonCloseWindows.Name = "buttonCloseWindows";
            this.buttonCloseWindows.Size = new System.Drawing.Size(117, 40);
            this.buttonCloseWindows.TabIndex = 7;
            this.buttonCloseWindows.Text = "关闭窗口";
            this.buttonCloseWindows.UseVisualStyleBackColor = true;
            this.buttonCloseWindows.Click += new System.EventHandler(this.buttonCloseWindows_Click);
            // 
            // FrmScoreBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.buttonCloseWindows);
            this.Controls.Add(this.buttonAllScore);
            this.Controls.Add(this.dataGridViewScoreList);
            this.Controls.Add(this.labeGrade);
            this.Controls.Add(this.textBoxScoreBrowse);
            this.Controls.Add(this.labelScoreBrowse);
            this.Controls.Add(this.comboBoxStudentClass);
            this.Controls.Add(this.labelStudentClass);
            this.Name = "FrmScoreBrowse";
            this.Text = "ScoreBrowse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmScoreBrowse_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentClass;
        private System.Windows.Forms.ComboBox comboBoxStudentClass;
        private System.Windows.Forms.Label labelScoreBrowse;
        private System.Windows.Forms.TextBox textBoxScoreBrowse;
        private System.Windows.Forms.Label labeGrade;
        private System.Windows.Forms.DataGridView dataGridViewScoreList;
        private System.Windows.Forms.Button buttonAllScore;
        private System.Windows.Forms.Button buttonCloseWindows;
    }
}