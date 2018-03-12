using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Bitmap loadedBitmap;
        private Bitmap toEditBitmap;
        private static int THRESHOLD_VALUE_CONTRAST = 0;
        public Form1()
        {
            InitializeComponent();

        }

        public static Bitmap Contrast(Bitmap sourceBitmap, int threshold)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                        sourceBitmap.Width, sourceBitmap.Height),
                                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            double contrastLevel = Math.Pow((100.0 + threshold) / 100.0, 2);

            double blue = 0;
            double green = 0;
            double red = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = ((((pixelBuffer[k] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;

                green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;

                red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0;

                if (blue > 255)
                { blue = 255; }
                else if (blue < 0)
                { blue = 0; }

                if (green > 255)
                { green = 255; }
                else if (green < 0)
                { green = 0; }

                if (red > 255)
                { red = 255; }
                else if (red < 0)
                { red = 0; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }


        public void showLoadedImage(String fileToDisplay)
        {
            loadedBitmap?.Dispose();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            loadedBitmap = new Bitmap(fileToDisplay);
            pictureBox1.ClientSize = new Size(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = loadedBitmap;
        }
        public void showEditImage(String fileToDisplay)
        {
            toEditBitmap?.Dispose();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            toEditBitmap = new Bitmap(fileToDisplay);
            pictureBox2.ClientSize = new Size(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = toEditBitmap;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    mStream = openFileDialog.OpenFile();
                    using (mStream)
                    {
                        showLoadedImage(openFileDialog.FileName);
                        showEditImage(openFileDialog.FileName);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    MessageBox.Show("Error: Could not read file from disk.\n" + exception.Message);
                    throw;
                }
            }

        }

        private void higherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THRESHOLD_VALUE_CONTRAST += 20;
            toEditBitmap = Contrast(loadedBitmap, THRESHOLD_VALUE_CONTRAST);
            pictureBox2.Image = toEditBitmap;
        }

        

        private void lowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THRESHOLD_VALUE_CONTRAST -= 20;
            toEditBitmap = Contrast(loadedBitmap, THRESHOLD_VALUE_CONTRAST);
            pictureBox2.Image = toEditBitmap;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            ImageFormat format = ImageFormat.Jpeg;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".gif":
                        format = ImageFormat.Gif;
                        break;
                }
                pictureBox2.Image.Save(saveFileDialog.FileName, format);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
