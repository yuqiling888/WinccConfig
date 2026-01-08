
namespace StudentGuanli
{
    partial class FrmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStudent));
            this.tbStudetName = new System.Windows.Forms.TextBox();
            this.lblStudenName = new System.Windows.Forms.Label();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.tbStudentIdNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.tbStudentAdderss = new System.Windows.Forms.TextBox();
            this.labelFamliyAddress = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.CheckBox();
            this.rdoFeMale = new System.Windows.Forms.CheckBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.gbAddStuInfo = new System.Windows.Forms.GroupBox();
            this.pbStuImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnChoseImage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransactionSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQudery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboClassName2 = new System.Windows.Forms.ComboBox();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbAddStuInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStudetName
            // 
            this.tbStudetName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStudetName.Location = new System.Drawing.Point(116, 34);
            this.tbStudetName.Name = "tbStudetName";
            this.tbStudetName.Size = new System.Drawing.Size(100, 26);
            this.tbStudetName.TabIndex = 0;
            this.tbStudetName.Text = "李小路";
            // 
            // lblStudenName
            // 
            this.lblStudenName.AutoSize = true;
            this.lblStudenName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudenName.Location = new System.Drawing.Point(6, 38);
            this.lblStudenName.Name = "lblStudenName";
            this.lblStudenName.Size = new System.Drawing.Size(104, 19);
            this.lblStudenName.TabIndex = 11;
            this.lblStudenName.Text = "学生姓名：";
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIdentityCard.Location = new System.Drawing.Point(6, 87);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(104, 19);
            this.lblIdentityCard.TabIndex = 15;
            this.lblIdentityCard.Text = "身份证号：";
            // 
            // tbStudentIdNo
            // 
            this.tbStudentIdNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStudentIdNo.Location = new System.Drawing.Point(116, 82);
            this.tbStudentIdNo.Name = "tbStudentIdNo";
            this.tbStudentIdNo.Size = new System.Drawing.Size(193, 26);
            this.tbStudentIdNo.TabIndex = 5;
            this.tbStudentIdNo.Text = "432632200201165241";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(682, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 39);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "确认添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbCardNo
            // 
            this.tbCardNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCardNo.Location = new System.Drawing.Point(412, 79);
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(131, 26);
            this.tbCardNo.TabIndex = 6;
            this.tbCardNo.Text = "52641552";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(315, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "考勤卡号:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(657, 82);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(135, 26);
            this.tbPhoneNumber.TabIndex = 7;
            this.tbPhoneNumber.Text = "021-52416352";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(547, 82);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(104, 19);
            this.labelPhoneNumber.TabIndex = 17;
            this.labelPhoneNumber.Text = "联系电话：";
            this.labelPhoneNumber.Click += new System.EventHandler(this.labelPhoneNumber_Click);
            // 
            // tbStudentAdderss
            // 
            this.tbStudentAdderss.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStudentAdderss.Location = new System.Drawing.Point(116, 139);
            this.tbStudentAdderss.Name = "tbStudentAdderss";
            this.tbStudentAdderss.Size = new System.Drawing.Size(278, 26);
            this.tbStudentAdderss.TabIndex = 8;
            this.tbStudentAdderss.Text = "广东省佛山市";
            // 
            // labelFamliyAddress
            // 
            this.labelFamliyAddress.AutoSize = true;
            this.labelFamliyAddress.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFamliyAddress.Location = new System.Drawing.Point(6, 142);
            this.labelFamliyAddress.Name = "labelFamliyAddress";
            this.labelFamliyAddress.Size = new System.Drawing.Size(104, 19);
            this.labelFamliyAddress.TabIndex = 18;
            this.labelFamliyAddress.Text = "家庭住址：";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBirthday.Location = new System.Drawing.Point(467, 41);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(104, 19);
            this.labelBirthday.TabIndex = 13;
            this.labelBirthday.Text = "出生日期：";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGender.Location = new System.Drawing.Point(277, 39);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(66, 19);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "性别：";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(1026, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClass.Location = new System.Drawing.Point(395, 140);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(104, 19);
            this.lblClass.TabIndex = 14;
            this.lblClass.Text = "所在班级：";
            // 
            // cboClassName
            // 
            this.cboClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(505, 137);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(121, 24);
            this.cboClassName.TabIndex = 4;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdoMale.Location = new System.Drawing.Point(349, 40);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(43, 20);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFeMale
            // 
            this.rdoFeMale.AutoSize = true;
            this.rdoFeMale.Location = new System.Drawing.Point(391, 40);
            this.rdoFeMale.Name = "rdoFeMale";
            this.rdoFeMale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdoFeMale.Size = new System.Drawing.Size(43, 20);
            this.rdoFeMale.TabIndex = 2;
            this.rdoFeMale.Text = "女";
            this.rdoFeMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(577, 36);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 26);
            this.dtpBirthday.TabIndex = 3;
            this.dtpBirthday.Value = new System.DateTime(2002, 1, 16, 14, 8, 0, 0);
            // 
            // gbAddStuInfo
            // 
            this.gbAddStuInfo.Controls.Add(this.lblStudenName);
            this.gbAddStuInfo.Controls.Add(this.cboClassName);
            this.gbAddStuInfo.Controls.Add(this.dtpBirthday);
            this.gbAddStuInfo.Controls.Add(this.lblClass);
            this.gbAddStuInfo.Controls.Add(this.tbStudetName);
            this.gbAddStuInfo.Controls.Add(this.labelFamliyAddress);
            this.gbAddStuInfo.Controls.Add(this.rdoFeMale);
            this.gbAddStuInfo.Controls.Add(this.tbStudentAdderss);
            this.gbAddStuInfo.Controls.Add(this.labelGender);
            this.gbAddStuInfo.Controls.Add(this.labelPhoneNumber);
            this.gbAddStuInfo.Controls.Add(this.rdoMale);
            this.gbAddStuInfo.Controls.Add(this.tbPhoneNumber);
            this.gbAddStuInfo.Controls.Add(this.label1);
            this.gbAddStuInfo.Controls.Add(this.labelBirthday);
            this.gbAddStuInfo.Controls.Add(this.tbStudentIdNo);
            this.gbAddStuInfo.Controls.Add(this.tbCardNo);
            this.gbAddStuInfo.Controls.Add(this.lblIdentityCard);
            this.gbAddStuInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbAddStuInfo.Location = new System.Drawing.Point(288, 144);
            this.gbAddStuInfo.Name = "gbAddStuInfo";
            this.gbAddStuInfo.Size = new System.Drawing.Size(808, 188);
            this.gbAddStuInfo.TabIndex = 19;
            this.gbAddStuInfo.TabStop = false;
            this.gbAddStuInfo.Text = "【学员基本信息】";
            this.gbAddStuInfo.Enter += new System.EventHandler(this.gbAddStuInfo_Enter);
            // 
            // pbStuImage
            // 
            this.pbStuImage.Location = new System.Drawing.Point(47, 144);
            this.pbStuImage.Name = "pbStuImage";
            this.pbStuImage.Size = new System.Drawing.Size(195, 185);
            this.pbStuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStuImage.TabIndex = 26;
            this.pbStuImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(258, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "启动摄像头";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(258, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "开始拍照";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnChoseImage
            // 
            this.btnChoseImage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseImage.Location = new System.Drawing.Point(79, 338);
            this.btnChoseImage.Name = "btnChoseImage";
            this.btnChoseImage.Size = new System.Drawing.Size(123, 31);
            this.btnChoseImage.TabIndex = 23;
            this.btnChoseImage.Text = "选择照片";
            this.btnChoseImage.UseVisualStyleBackColor = true;
            this.btnChoseImage.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(442, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 37);
            this.button4.TabIndex = 24;
            this.button4.Text = "关闭摄像头";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(442, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 36);
            this.button5.TabIndex = 25;
            this.button5.Text = "清除照片";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.Age,
            this.Birthday,
            this.ClassName,
            this.ClassId,
            this.CardNo,
            this.StudentIdNo,
            this.PhoneNumber,
            this.StudentAddress});
            this.dgvStudentList.Location = new System.Drawing.Point(25, 466);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            this.dgvStudentList.RowTemplate.Height = 23;
            this.dgvStudentList.Size = new System.Drawing.Size(1124, 339);
            this.dgvStudentList.TabIndex = 28;
            this.dgvStudentList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStudentList_RowPostPaint);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.Frozen = true;
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 40;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 80;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 40;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "年龄";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 50;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级名称";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "班级编号";
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "考勤卡号";
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            // 
            // StudentIdNo
            // 
            this.StudentIdNo.DataPropertyName = "StudentIdNo";
            this.StudentIdNo.HeaderText = "身份证号";
            this.StudentIdNo.Name = "StudentIdNo";
            this.StudentIdNo.ReadOnly = true;
            this.StudentIdNo.Width = 200;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "电话号码";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // StudentAddress
            // 
            this.StudentAddress.DataPropertyName = "StudentAddress";
            this.StudentAddress.HeaderText = "联系地址";
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.ReadOnly = true;
            // 
            // btnTransactionSave
            // 
            this.btnTransactionSave.Location = new System.Drawing.Point(965, 427);
            this.btnTransactionSave.Name = "btnTransactionSave";
            this.btnTransactionSave.Size = new System.Drawing.Size(131, 23);
            this.btnTransactionSave.TabIndex = 29;
            this.btnTransactionSave.Text = "基于事务保存全部";
            this.btnTransactionSave.UseVisualStyleBackColor = true;
            this.btnTransactionSave.Click += new System.EventHandler(this.btnTransactionSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQudery);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboClassName2);
            this.groupBox1.Location = new System.Drawing.Point(290, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 109);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按班级查询";
            // 
            // btnQudery
            // 
            this.btnQudery.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQudery.Location = new System.Drawing.Point(347, 32);
            this.btnQudery.Name = "btnQudery";
            this.btnQudery.Size = new System.Drawing.Size(149, 39);
            this.btnQudery.TabIndex = 31;
            this.btnQudery.Text = "提交查询";
            this.btnQudery.UseVisualStyleBackColor = true;
            this.btnQudery.Click += new System.EventHandler(this.btnQudery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "学员班级：";
            // 
            // cboClassName2
            // 
            this.cboClassName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassName2.FormattingEnabled = true;
            this.cboClassName2.Location = new System.Drawing.Point(128, 41);
            this.cboClassName2.Name = "cboClassName2";
            this.cboClassName2.Size = new System.Drawing.Size(179, 20);
            this.cboClassName2.TabIndex = 27;
            // 
            // btnDeleta
            // 
            this.btnDeleta.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeleta.Location = new System.Drawing.Point(916, 12);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(104, 39);
            this.btnDeleta.TabIndex = 31;
            this.btnDeleta.Text = "删除";
            this.btnDeleta.UseVisualStyleBackColor = true;
            this.btnDeleta.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Location = new System.Drawing.Point(806, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 39);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 817);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTransactionSave);
            this.Controls.Add(this.pbStuImage);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnChoseImage);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbAddStuInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmAddStudent";
            this.Text = "添加学员信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStudent_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAddStudent_KeyDown);
            this.gbAddStuInfo.ResumeLayout(false);
            this.gbAddStuInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbStudetName;
        private System.Windows.Forms.Label lblStudenName;
        private System.Windows.Forms.Label lblIdentityCard;
        private System.Windows.Forms.TextBox tbStudentIdNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox tbStudentAdderss;
        private System.Windows.Forms.Label labelFamliyAddress;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.CheckBox rdoMale;
        private System.Windows.Forms.CheckBox rdoFeMale;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.GroupBox gbAddStuInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChoseImage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pbStuImage;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Button btnTransactionSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQudery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboClassName2;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAddress;
    }
}