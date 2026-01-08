
namespace StudentGuanli
{
    partial class FrmModifyPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFormer = new System.Windows.Forms.TextBox();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewPwd2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(128, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码:";
            // 
            // tbFormer
            // 
            this.tbFormer.Location = new System.Drawing.Point(198, 63);
            this.tbFormer.Name = "tbFormer";
            this.tbFormer.PasswordChar = '.';
            this.tbFormer.Size = new System.Drawing.Size(100, 21);
            this.tbFormer.TabIndex = 1;
            this.tbFormer.UseSystemPasswordChar = true;
            this.tbFormer.TextChanged += new System.EventHandler(this.tbFormer_TextChanged);
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Location = new System.Drawing.Point(198, 106);
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.Size = new System.Drawing.Size(100, 21);
            this.tbNewPwd.TabIndex = 3;
            this.tbNewPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(128, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码:";
            // 
            // tbNewPwd2
            // 
            this.tbNewPwd2.Location = new System.Drawing.Point(198, 150);
            this.tbNewPwd2.Name = "tbNewPwd2";
            this.tbNewPwd2.Size = new System.Drawing.Size(100, 21);
            this.tbNewPwd2.TabIndex = 5;
            this.tbNewPwd2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(96, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "新密码确认:";
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModifyPwd.Location = new System.Drawing.Point(75, 228);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(92, 23);
            this.btnModifyPwd.TabIndex = 6;
            this.btnModifyPwd.Text = "修改密码";
            this.btnModifyPwd.UseVisualStyleBackColor = true;
            this.btnModifyPwd.Click += new System.EventHandler(this.btnModifyPwd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(237, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModifyPwd);
            this.Controls.Add(this.tbNewPwd2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFormer);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifyPwd";
            this.Text = "FrmModifyPwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFormer;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewPwd2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnCancel;
    }
}