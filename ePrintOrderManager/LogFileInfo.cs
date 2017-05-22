namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Resources;
    using System.Text;
    using System.Windows.Forms;

    public class LogFileInfo : Form
    {
        private Container components = null;
        public string FileName;
        private RichTextBox richTextBox1;

        public LogFileInfo()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ResourceManager manager = new ResourceManager(typeof(LogFileInfo));
            this.richTextBox1 = new RichTextBox();
            base.SuspendLayout();
            this.richTextBox1.Dock = DockStyle.Fill;
            this.richTextBox1.Location = new Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(280, 0x111);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(280, 0x111);
            base.Controls.Add(this.richTextBox1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "LogFileInfo";
            this.Text = "平台日志";
            base.WindowState = FormWindowState.Maximized;
            base.Load += new EventHandler(this.LogFileInfo_Load);
            base.ResumeLayout(false);
        }

        private void LogFileInfo_Load(object sender, EventArgs e)
        {
            this.ReadFileInfo();
        }

        private void ReadFileInfo()
        {
            FileStream stream = new FileStream(OutputLogin.SetupPath + @"\ePrintLog\" + this.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(stream, Encoding.Default);
            this.richTextBox1.Text = reader.ReadToEnd();
            reader.Close();
            stream.Close();
        }
    }
}

