using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Picture : Form
    {
        protected string[] pFileNames;
        protected int pCurrentImage = -1;
        public Picture()
        {
            InitializeComponent();
        }

        private void btn_opimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pFileNames = openFileDialog.FileNames;
                pCurrentImage = 0;
                ShowCurrentImage();
            }
        }
        
        protected void ShowCurrentImage()
        {
            if (pCurrentImage >= 0 && pCurrentImage < pFileNames.Length)
            {
                pictureBox1.Image = Bitmap.FromFile(pFileNames[pCurrentImage]);
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            ++pCurrentImage;
            //check if this was last image in list
            if (pCurrentImage >= pFileNames.Length)
                pCurrentImage = pFileNames.Length == 0 ? -1 : 0;//if this was last image, go to first image
            ShowCurrentImage();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            --pCurrentImage;
            //check if this was first image in list
            if (pCurrentImage < 0)
                pCurrentImage = pFileNames.Length == 0 ? -1 : pFileNames.Length - 1;//if this was first image, go to last image
            ShowCurrentImage();
        }
    }
}
