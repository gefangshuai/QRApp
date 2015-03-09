using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private bool isHeighted = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void generateBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = !File.Exists(logoPath.Text)?
                QRGenerate.GeneratorQrImage(qrTextBox.Text, null) :
                QRGenerate.GeneratorQrImage(qrTextBox.Text, new Bitmap(logoPath.Text));
            if (bitmap != null)
            {
                qrPictureBox.Image = bitmap;
                qrPictureBox.DoubleClick += (o, args) =>
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PNG(*.png)|*.png";
                    DialogResult result = saveFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        qrPictureBox.Image.Save(saveFileDialog.FileName);
                    }
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG (*.jpg,*.jpeg)|*.jpg;*.jpeg|PNG(*.png)|*.png";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                logoPath.Text = openFileDialog.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wincn.net");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("mailto:gefangshuai@163.com");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}
