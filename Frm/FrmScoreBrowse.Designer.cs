
namespace StudentGuanli
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelStudentClass = new System.Windows.Forms.Label();
            this.comboBoxStudentClass = new System.Windows.Forms.ComboBox();
            this.labelScoreBrowse = new System.Windows.Forms.Label();
            this.textBoxScoreBrowse = new System.Windows.Forms.TextBox();
            this.labeGrade = new System.Windows.Forms.Label();
            this.dataGridViewScoreList = new System.Windows.Forms.DataGridView();
            this.buttonAllScore = new System.Windows.Forms.Button();
            this.buttonCloseWindows = new System.Windows.Forms.Button();
            this.btnCylindricality = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPie = new System.Windows.Forms.Button();
            this.btnhongtiao = new System.Windows.Forms.Button();
            this.btnyuanhuan = new System.Windows.Forms.Button();
            this.btnScoreReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScoreList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.buttonAllScore.Location = new System.Drawing.Point(65, 358);
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
            // btnCylindricality
            // 
            this.btnCylindricality.Location = new System.Drawing.Point(663, 495);
            this.btnCylindricality.Name = "btnCylindricality";
            this.btnCylindricality.Size = new System.Drawing.Size(75, 23);
            this.btnCylindricality.TabIndex = 8;
            this.btnCylindricality.Text = "柱形图";
            this.btnCylindricality.UseVisualStyleBackColor = true;
            this.btnCylindricality.Click += new System.EventHandler(this.btnCylindricality_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(65, 421);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(441, 225);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(772, 495);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(75, 23);
            this.btnPie.TabIndex = 10;
            this.btnPie.Text = "饼形图";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // btnhongtiao
            // 
            this.btnhongtiao.Location = new System.Drawing.Point(663, 554);
            this.btnhongtiao.Name = "btnhongtiao";
            this.btnhongtiao.Size = new System.Drawing.Size(75, 23);
            this.btnhongtiao.TabIndex = 11;
            this.btnhongtiao.Text = "横条图";
            this.btnhongtiao.UseVisualStyleBackColor = true;
            this.btnhongtiao.Click += new System.EventHandler(this.btnhongtiao_Click);
            // 
            // btnyuanhuan
            // 
            this.btnyuanhuan.Location = new System.Drawing.Point(772, 554);
            this.btnyuanhuan.Name = "btnyuanhuan";
            this.btnyuanhuan.Size = new System.Drawing.Size(75, 23);
            this.btnyuanhuan.TabIndex = 12;
            this.btnyuanhuan.Text = "圆环图";
            this.btnyuanhuan.UseVisualStyleBackColor = true;
            this.btnyuanhuan.Click += new System.EventHandler(this.btnyuanhuan_Click);
            // 
            // btnScoreReport
            // 
            this.btnScoreReport.Location = new System.Drawing.Point(247, 369);
            this.btnScoreReport.Name = "btnScoreReport";
            this.btnScoreReport.Size = new System.Drawing.Size(75, 23);
            this.btnScoreReport.TabIndex = 13;
            this.btnScoreReport.Text = "成绩报表";
            this.btnScoreReport.UseVisualStyleBackColor = true;
            
            // 
            // FrmScoreBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 675);
            this.Controls.Add(this.btnScoreReport);
            this.Controls.Add(this.btnyuanhuan);
            this.Controls.Add(this.btnhongtiao);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnCylindricality);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button btnCylindricality;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.Button btnhongtiao;
        private System.Windows.Forms.Button btnyuanhuan;
        private System.Windows.Forms.Button btnScoreReport;
    }
}