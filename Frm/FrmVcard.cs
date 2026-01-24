using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGuanli
{
    public partial class FrmVcard : Form
    {
        private CreateQRCode createQRCode = new CreateQRCode();
        public FrmVcard()
        {
            InitializeComponent();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            //封装数据
            CardData data = new CardData
            {
                Name = this.tbxName.Text.Trim(),
                Post = this.textBoxPost.Text.Trim(),
                Deparment = this.textBoxDepartMent.Text.Trim(),
                Company = this.textBoxCompany.Text.Trim(),
                MobilePhone = this.tbMobilePhone.Text.Trim(),
                TelePhone = this.textBoxTelePhone.Text.Trim(),
                Address = this.textBoxAddress.Text.Trim(),
                Url = this.tbUrl.Text.Trim(),
                Email=this.textBoxEmail.Text.Trim()

            };
            //调用二维码生成类生成二维码
            this.pbImage.Image = createQRCode.CreatCodeIamge(data, this.pbImage.Width, this.pbImage.Height);

            //// 调用二维码生成类生成二维码
            //Bitmap qrCodeBitmap = createQRCode.CreatCodeIamge(data, this.pbImage.Width, this.pbImage.Height);

            //// 将生成的二维码图像设置到PictureBox的Image属性
            //this.pbImage.Image = qrCodeBitmap;
        }
    }
    
}
