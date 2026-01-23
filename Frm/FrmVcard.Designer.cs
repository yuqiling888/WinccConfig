
namespace StudentGuanli.Frm
{
    partial class FrmVcard
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
            this.btnCreat = new System.Windows.Forms.Button();
            this.pcbStuImage = new System.Windows.Forms.PictureBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxTelePhone = new System.Windows.Forms.TextBox();
            this.lblTele = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.lblCorp = new System.Windows.Forms.Label();
            this.textBoxDepartMent = new System.Windows.Forms.TextBox();
            this.lblOrg = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreat
            // 
            this.btnCreat.Location = new System.Drawing.Point(562, 369);
            this.btnCreat.Name = "btnCreat";
            this.btnCreat.Size = new System.Drawing.Size(101, 32);
            this.btnCreat.TabIndex = 36;
            this.btnCreat.Text = "开始生成";
            this.btnCreat.UseVisualStyleBackColor = true;
            // 
            // pcbStuImage
            // 
            this.pcbStuImage.Location = new System.Drawing.Point(500, 45);
            this.pcbStuImage.Name = "pcbStuImage";
            this.pcbStuImage.Size = new System.Drawing.Size(261, 258);
            this.pcbStuImage.TabIndex = 35;
            this.pcbStuImage.TabStop = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAddress.Location = new System.Drawing.Point(121, 188);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(337, 26);
            this.textBoxAddress.TabIndex = 34;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.Location = new System.Drawing.Point(40, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 16);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "地址：";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(121, 238);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(337, 26);
            this.textBoxPhoneNumber.TabIndex = 32;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(40, 241);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(56, 16);
            this.lblPhoneNumber.TabIndex = 31;
            this.lblPhoneNumber.Text = "手机：";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // textBoxTelePhone
            // 
            this.textBoxTelePhone.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTelePhone.Location = new System.Drawing.Point(121, 284);
            this.textBoxTelePhone.Name = "textBoxTelePhone";
            this.textBoxTelePhone.Size = new System.Drawing.Size(337, 26);
            this.textBoxTelePhone.TabIndex = 30;
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTele.Location = new System.Drawing.Point(40, 287);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(56, 16);
            this.lblTele.TabIndex = 29;
            this.lblTele.Text = "座机：";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxCompany.Location = new System.Drawing.Point(121, 135);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(337, 26);
            this.textBoxCompany.TabIndex = 28;
            // 
            // lblCorp
            // 
            this.lblCorp.AutoSize = true;
            this.lblCorp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCorp.Location = new System.Drawing.Point(40, 138);
            this.lblCorp.Name = "lblCorp";
            this.lblCorp.Size = new System.Drawing.Size(56, 16);
            this.lblCorp.TabIndex = 27;
            this.lblCorp.Text = "公司：";
            // 
            // textBoxDepartMent
            // 
            this.textBoxDepartMent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDepartMent.Location = new System.Drawing.Point(121, 86);
            this.textBoxDepartMent.Name = "textBoxDepartMent";
            this.textBoxDepartMent.Size = new System.Drawing.Size(337, 26);
            this.textBoxDepartMent.TabIndex = 24;
            // 
            // lblOrg
            // 
            this.lblOrg.AutoSize = true;
            this.lblOrg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrg.Location = new System.Drawing.Point(40, 89);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(56, 16);
            this.lblOrg.TabIndex = 23;
            this.lblOrg.Text = "部门：";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPost.Location = new System.Drawing.Point(338, 42);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(120, 26);
            this.textBoxPost.TabIndex = 22;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(287, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(56, 16);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "职位：";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxName.Location = new System.Drawing.Point(121, 42);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(120, 26);
            this.tbxName.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(40, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 16);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "姓名：";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEmail.Location = new System.Drawing.Point(121, 336);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(337, 26);
            this.textBoxEmail.TabIndex = 40;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblemail.Location = new System.Drawing.Point(40, 339);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(56, 16);
            this.lblemail.TabIndex = 39;
            this.lblemail.Text = "邮箱：";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUrl.Location = new System.Drawing.Point(121, 382);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(337, 26);
            this.textBoxUrl.TabIndex = 38;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblURL.Location = new System.Drawing.Point(40, 385);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(56, 16);
            this.lblURL.TabIndex = 37;
            this.lblURL.Text = "网址：";
            // 
            // FrmVcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnCreat);
            this.Controls.Add(this.pcbStuImage);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.textBoxTelePhone);
            this.Controls.Add(this.lblTele);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.lblCorp);
            this.Controls.Add(this.textBoxDepartMent);
            this.Controls.Add(this.lblOrg);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmVcard";
            this.Text = "FrmVcard";
            this.Load += new System.EventHandler(this.FrmVcard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbStuImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreat;
        private System.Windows.Forms.PictureBox pcbStuImage;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBoxTelePhone;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label lblCorp;
        private System.Windows.Forms.TextBox textBoxDepartMent;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label lblURL;
    }
}