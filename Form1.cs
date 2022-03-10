using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        FileStream fs;
        byte[] filecontents;
        AsyncCallback callback;
        delegate void InfoMessageDel(String info);

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_RdAsync_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Filter = "Text Files(*.txt)|*.txt";
            opFile.ShowDialog();
            callback = new AsyncCallback(fs_StateChanged);
            fs = new FileStream(opFile.FileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true);
            filecontents = new byte[fs.Length];
            fs.BeginRead(filecontents, 0, (int)fs.Length, callback, null);
            fs.BeginRead(filecontents, 0, (int)fs.Length, callback, null);
        }

        private void fs_StateChanged(IAsyncResult AsyncResult)
        {
            if (AsyncResult.IsCompleted)
            {
                string s = Encoding.UTF8.GetString(filecontents);
                InfoMessage(s);
                fs.Close();
            }

        }

        private void InfoMessage(String s)
        {
            if (this.textBox1.InvokeRequired)
            {
                InfoMessageDel msg = new InfoMessageDel(InfoMessage);
                this.Invoke(msg, new object[] {s});
            }
            else
            {
                textBox1.Text = s;
            }
        }

        private void btn_RdSync_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Text Files(*.txt)|*.txt";
            openfiledialog.ShowDialog();
            try
            {
                fs = new FileStream(openfiledialog.FileName, FileMode.Open);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            fs.Seek(0, SeekOrigin.Begin); 
            filecontents = new byte[fs.Length];
            fs.Read(filecontents,0, (int)fs.Length);
            string s = Encoding.UTF8.GetString(filecontents);
            InfoMessage(s);
            fs.Close();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "Text Files(*.txt)|*.txt";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(savefiledialog.FileName, FileMode.CreateNew);
                    BinaryWriter bw = new BinaryWriter(fs);
                    filecontents = Encoding.UTF8.GetBytes(textBox1.Text);
                    
                    bw.Write(filecontents);
                    
                    bw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {

            }
        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            Picture picture = new Picture();
            picture.Show();
        }

    }
}
