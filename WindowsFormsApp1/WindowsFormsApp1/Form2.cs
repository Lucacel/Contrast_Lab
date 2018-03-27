using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gamma_value = double.Parse(gammaValueTextBox.Text);
            Graphics g = Graphics.FromImage(Form1.toEditBitmap);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetGamma((float) gamma_value);
            g.DrawImage(Form1.loadedBitmap, new Rectangle(0, 0, Form1.toEditBitmap.Width, 
                    Form1.toEditBitmap.Height)
                , 0, 0, Form1.loadedBitmap.Width, Form1.loadedBitmap.Height,
                GraphicsUnit.Pixel, imageAttributes);
            mainForm.pictureBox2.Image = Form1.toEditBitmap;
            //
            //            Form1.toEditBitmap = Form1.GammaCorrection(Form1.loadedBitmap, gamma_value);
            //            mainForm.pictureBox2.Image = Form1.toEditBitmap;

        }
    }
}
