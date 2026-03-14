
namespace StudentGuanli
{
    partial class FrmScoreReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cbStudentClass = new System.Windows.Forms.ComboBox();
            this.labelStudentClass = new System.Windows.Forms.Label();
            this.btnQudery = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStudentClass
            // 
            this.cbStudentClass.FormattingEnabled = true;
            this.cbStudentClass.Location = new System.Drawing.Point(226, 53);
            this.cbStudentClass.Margin = new System.Windows.Forms.Padding(4);
            this.cbStudentClass.Name = "cbStudentClass";
            this.cbStudentClass.Size = new System.Drawing.Size(160, 20);
            this.cbStudentClass.TabIndex = 3;
            // 
            // labelStudentClass
            // 
            this.labelStudentClass.AutoSize = true;
            this.labelStudentClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStudentClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStudentClass.Location = new System.Drawing.Point(119, 53);
            this.labelStudentClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentClass.Name = "labelStudentClass";
            this.labelStudentClass.Size = new System.Drawing.Size(88, 16);
            this.labelStudentClass.TabIndex = 2;
            this.labelStudentClass.Text = "学员班级：";
            // 
            // btnQudery
            // 
            this.btnQudery.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQudery.Location = new System.Drawing.Point(490, 41);
            this.btnQudery.Name = "btnQudery";
            this.btnQudery.Size = new System.Drawing.Size(149, 39);
            this.btnQudery.TabIndex = 32;
            this.btnQudery.Text = "提交查询";
            this.btnQudery.UseVisualStyleBackColor = true;
            this.btnQudery.Click += new System.EventHandler(this.btnQudery_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentGuanli.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(38, 108);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1169, 446);
            this.reportViewer1.TabIndex = 33;
            // 
            // StudentBindingSource
            // 
            this.StudentBindingSource.DataSource = typeof(Models.Student);
            // 
            // FrmScoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 624);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnQudery);
            this.Controls.Add(this.cbStudentClass);
            this.Controls.Add(this.labelStudentClass);
            this.Name = "FrmScoreReport";
            this.Text = "基于RDLC学员成绩表";
            this.Load += new System.EventHandler(this.FrmScoreReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudentClass;
        private System.Windows.Forms.Label labelStudentClass;
        private System.Windows.Forms.Button btnQudery;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentBindingSource;
    }
}