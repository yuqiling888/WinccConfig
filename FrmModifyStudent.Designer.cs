
namespace StudentManager
{
    partial class FrmModifyStudent
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
            this.textBoxStudetName = new System.Windows.Forms.TextBox();
            this.lblStudenName = new System.Windows.Forms.Label();
            this.lblStudentIdNo = new System.Windows.Forms.Label();
            this.textBoxStudentIdNo = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.textBoxCardNo = new System.Windows.Forms.TextBox();
            this.labelCardNo = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxStudentAdderss = new System.Windows.Forms.TextBox();
            this.labelFamliyAddress = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.CheckBox();
            this.rdoFeMale = new System.Windows.Forms.CheckBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxStudetName
            // 
            this.textBoxStudetName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStudetName.Location = new System.Drawing.Point(163, 66);
            this.textBoxStudetName.Name = "textBoxStudetName";
            this.textBoxStudetName.Size = new System.Drawing.Size(100, 26);
            this.textBoxStudetName.TabIndex = 0;
            // 
            // lblStudenName
            // 
            this.lblStudenName.AutoSize = true;
            this.lblStudenName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudenName.Location = new System.Drawing.Point(60, 68);
            this.lblStudenName.Name = "lblStudenName";
            this.lblStudenName.Size = new System.Drawing.Size(104, 19);
            this.lblStudenName.TabIndex = 11;
            this.lblStudenName.Text = "学生姓名：";
            // 
            // lblStudentIdNo
            // 
            this.lblStudentIdNo.AutoSize = true;
            this.lblStudentIdNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudentIdNo.Location = new System.Drawing.Point(60, 255);
            this.lblStudentIdNo.Name = "lblStudentIdNo";
            this.lblStudentIdNo.Size = new System.Drawing.Size(104, 19);
            this.lblStudentIdNo.TabIndex = 15;
            this.lblStudentIdNo.Text = "身份证号：";
            // 
            // textBoxStudentIdNo
            // 
            this.textBoxStudentIdNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStudentIdNo.Location = new System.Drawing.Point(163, 253);
            this.textBoxStudentIdNo.Name = "textBoxStudentIdNo";
            this.textBoxStudentIdNo.Size = new System.Drawing.Size(325, 26);
            this.textBoxStudentIdNo.TabIndex = 5;
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnModify.Location = new System.Drawing.Point(73, 453);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(104, 39);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "提交修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // textBoxCardNo
            // 
            this.textBoxCardNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCardNo.Location = new System.Drawing.Point(163, 293);
            this.textBoxCardNo.Name = "textBoxCardNo";
            this.textBoxCardNo.Size = new System.Drawing.Size(325, 26);
            this.textBoxCardNo.TabIndex = 6;
            // 
            // labelCardNo
            // 
            this.labelCardNo.AutoSize = true;
            this.labelCardNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCardNo.Location = new System.Drawing.Point(60, 295);
            this.labelCardNo.Name = "labelCardNo";
            this.labelCardNo.Size = new System.Drawing.Size(104, 19);
            this.labelCardNo.TabIndex = 16;
            this.labelCardNo.Text = "考勤卡号：";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(163, 332);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(325, 26);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(60, 334);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(104, 19);
            this.labelPhoneNumber.TabIndex = 17;
            this.labelPhoneNumber.Text = "联系电话：";
            // 
            // textBoxStudentAdderss
            // 
            this.textBoxStudentAdderss.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStudentAdderss.Location = new System.Drawing.Point(163, 370);
            this.textBoxStudentAdderss.Name = "textBoxStudentAdderss";
            this.textBoxStudentAdderss.Size = new System.Drawing.Size(325, 26);
            this.textBoxStudentAdderss.TabIndex = 8;
            // 
            // labelFamliyAddress
            // 
            this.labelFamliyAddress.AutoSize = true;
            this.labelFamliyAddress.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFamliyAddress.Location = new System.Drawing.Point(60, 372);
            this.labelFamliyAddress.Name = "labelFamliyAddress";
            this.labelFamliyAddress.Size = new System.Drawing.Size(104, 19);
            this.labelFamliyAddress.TabIndex = 18;
            this.labelFamliyAddress.Text = "家庭住址：";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBirthday.Location = new System.Drawing.Point(60, 144);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(104, 19);
            this.labelBirthday.TabIndex = 13;
            this.labelBirthday.Text = "出生日期：";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGender.Location = new System.Drawing.Point(73, 108);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(66, 19);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "性别：";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(326, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "关闭窗口";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClass.Location = new System.Drawing.Point(60, 182);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(104, 19);
            this.lblClass.TabIndex = 14;
            this.lblClass.Text = "所在班级：";
            // 
            // cboClassName
            // 
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(163, 185);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(121, 20);
            this.cboClassName.TabIndex = 4;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(163, 111);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(36, 16);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFeMale
            // 
            this.rdoFeMale.AutoSize = true;
            this.rdoFeMale.Location = new System.Drawing.Point(205, 111);
            this.rdoFeMale.Name = "rdoFeMale";
            this.rdoFeMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoFeMale.Size = new System.Drawing.Size(36, 16);
            this.rdoFeMale.TabIndex = 2;
            this.rdoFeMale.Text = "女";
            this.rdoFeMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(163, 144);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 21);
            this.dtpBirthday.TabIndex = 3;
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStudentId.Location = new System.Drawing.Point(91, 30);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(66, 19);
            this.labelStudentId.TabIndex = 20;
            this.labelStudentId.Text = "学号：";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxStudentId.Location = new System.Drawing.Point(163, 23);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(100, 26);
            this.textBoxStudentId.TabIndex = 19;
            // 
            // FrmModifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.rdoFeMale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.cboClassName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelFamliyAddress);
            this.Controls.Add(this.textBoxStudentAdderss);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelCardNo);
            this.Controls.Add(this.textBoxCardNo);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblStudentIdNo);
            this.Controls.Add(this.textBoxStudentIdNo);
            this.Controls.Add(this.lblStudenName);
            this.Controls.Add(this.textBoxStudetName);
            this.Name = "FrmModifyStudent";
            this.Text = "FrmModifyStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudetName;
        private System.Windows.Forms.Label lblStudenName;
        private System.Windows.Forms.Label lblStudentIdNo;
        private System.Windows.Forms.TextBox textBoxStudentIdNo;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox textBoxCardNo;
        private System.Windows.Forms.Label labelCardNo;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxStudentAdderss;
        private System.Windows.Forms.Label labelFamliyAddress;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.CheckBox rdoMale;
        private System.Windows.Forms.CheckBox rdoFeMale;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.TextBox textBoxStudentId;
    }
}