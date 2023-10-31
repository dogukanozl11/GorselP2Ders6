using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselP2Ders6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Uygulama Yazı Tura.
     
        private void btnat_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("yazi.jpeg"); //resimekleme
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch; //Resime göre stretch ayarını kodla yapımı.
            btnçık.BackgroundImage = Image.FromFile("images.jpg"); //Resim ekleme
            btnçık.BackgroundImageLayout = ImageLayout.Stretch;  //Resime göre stretch ayarını kodla yapımı.
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rnd = new Random();
            int gelen = rnd.Next(1,3);
            if (gelen == 1)
            {
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpeg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpeg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpeg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpeg");
            }
            
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpeg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpeg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("yazi.jpeg");
                System.Threading.Thread.Sleep(250);
                pictureBox1.BackgroundImage = Image.FromFile("tura.jpg");
            }
        }

        private void btnçık_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
       
    }
}
