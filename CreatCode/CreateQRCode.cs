using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;

namespace StudentGuanli
{
    /// <summary>
    /// 二维码生成类
    /// </summary>
    public class CreateQRCode
    {
        /// <summary>
        /// 根据名片数据生成特定格式的字符串
        /// </summary>
        /// <param name="cardData"></param>
        /// <returns></returns>
        private string GetCodeInfo(CardData cardData )
        {
            StringBuilder card = new StringBuilder();
            card.Append("BENGIN:VCARD");
            card.Append("\r\nFN:" + cardData.Name);
            card.Append("\r\nTITLE:" + cardData.Post);
            card.Append("\r\nORG" + cardData.Company + ";" + cardData.Deparment);
            card.Append("\r\nTEL;CELL：" + cardData.MobilePhone);
            card.Append("\r\nTEL;WORK:" + cardData.TelePhone);
            card.Append("\r\nADR;WORK:" + cardData.Address);
            card.Append("\r\nURL:" + cardData.Url);
            card.Append("\r\nEMAIL:" + cardData.Email);
            card.Append("\r\nPHOTO;ENCODING=b;TYPE=JPEG:");
            card.Append("\r\nEND:VCARD\r\n");
            return card.ToString();
        }
        /// <summary>
        /// 根据图片大小和名片信息生成二维码图片
        /// </summary>
        /// <param name="cardData">名片信息对象</param>
        /// <param name="imageWidth">图片显示宽度</param>
        /// <param name="imageHeight">图片显示高度</param>
        /// <returns></returns>
        public Bitmap CreatCodeIamge(CardData cardData, int imageWidth, int imageHeight)
        {
            //【1】根据名片内容生成
            string cardString = GetCodeInfo(cardData);
            //【2】创建二维码需要的图片对象和绘图类对象
            Bitmap bmp = new Bitmap(imageWidth, imageHeight);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);//填上背景

            //【3】创建二维码编码类对象（第三方的dll）并设置属性
            QRCodeEncoder qRCodeEncoder = new QRCodeEncoder();
            qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//设置编码方式
            qRCodeEncoder.QRCodeScale = 8;//设置二维码图片大小
            qRCodeEncoder.QRCodeVersion = 0;//设置版本
            //设置错误校验级别，因为二维码有纠错能力，所以允许加入Logo图片
            qRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            //【4】按照编码格式将名片信息编码成图片文件
            Image image = qRCodeEncoder.Encode(cardString, Encoding.GetEncoding("utf-8"));

            //【5】画出二维码图片
            int x = (imageWidth - image.Width) / 2;
            int y = (imageHeight - image.Height) / 2;
            graphics.DrawImage(image, new Point(x, y));  //使用graphics对象在背景上画出二维码图片

            //【6】画出LoGO图片并添加到二维码上
            image = Properties.Resources.logo1; //通过资源文件获取图片
            x = (imageWidth - image.Width) / 2;
            y = (imageHeight - image.Height) / 2;
            graphics.DrawImage(image, new Point(x, y));  //使用graphics对象在背景上显示L

            return bmp;
        }


    }
}
