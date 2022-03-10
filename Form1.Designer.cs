namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OKbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RdAsync = new System.Windows.Forms.Button();
            this.btn_RdSync = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_pic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(695, 150);
            this.textBox1.TabIndex = 0;
            // 
            // OKbtn
            // 
            this.OKbtn.Location = new System.Drawing.Point(576, 391);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(132, 39);
            this.OKbtn.TabIndex = 1;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bro, say something !";
            // 
            // btn_RdAsync
            // 
            this.btn_RdAsync.Location = new System.Drawing.Point(76, 113);
            this.btn_RdAsync.Name = "btn_RdAsync";
            this.btn_RdAsync.Size = new System.Drawing.Size(145, 42);
            this.btn_RdAsync.TabIndex = 3;
            this.btn_RdAsync.Text = "Read Async";
            this.btn_RdAsync.UseVisualStyleBackColor = true;
            this.btn_RdAsync.Click += new System.EventHandler(this.btn_RdAsync_Click);
            // 
            // btn_RdSync
            // 
            this.btn_RdSync.Location = new System.Drawing.Point(262, 113);
            this.btn_RdSync.Name = "btn_RdSync";
            this.btn_RdSync.Size = new System.Drawing.Size(139, 42);
            this.btn_RdSync.TabIndex = 4;
            this.btn_RdSync.Text = "Read Sync";
            this.btn_RdSync.UseVisualStyleBackColor = true;
            this.btn_RdSync.Click += new System.EventHandler(this.btn_RdSync_Click);
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(576, 113);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(139, 42);
            this.btn_write.TabIndex = 5;
            this.btn_write.Text = "Write";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_pic
            // 
            this.btn_pic.Location = new System.Drawing.Point(76, 391);
            this.btn_pic.Name = "btn_pic";
            this.btn_pic.Size = new System.Drawing.Size(145, 39);
            this.btn_pic.TabIndex = 6;
            this.btn_pic.Text = "See Picture";
            this.btn_pic.UseVisualStyleBackColor = true;
            this.btn_pic.Click += new System.EventHandler(this.btn_pic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_pic);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_RdSync);
            this.Controls.Add(this.btn_RdAsync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hello world";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RdAsync;
        private System.Windows.Forms.Button btn_RdSync;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_pic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

