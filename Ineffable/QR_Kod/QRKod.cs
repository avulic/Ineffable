using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Kod
{
    public class QRKod
    {
        public void SifrirajQRKod(string oznaka, PictureBox pictureBox)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                    encoder.QRCodeScale = 5;
                    Bitmap bmp = encoder.Encode(oznaka);
                    pictureBox.Image = bmp;
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
        }

        public string DesifrirajQRKod(PictureBox pictureBox)
        {
            
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    return decoder.Decode(new MessagingToolkit.QRCode.Codec.Data.QRCodeBitmapImage(pictureBox.Image as Bitmap));
                }
                return "";
            }
            
        }
    }
}
