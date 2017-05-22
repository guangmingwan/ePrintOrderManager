namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class ScreenProtectLogin : Form
    {
        private Container components = null;

        public ScreenProtectLogin()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
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
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(0x392, 0x207);
            base.FormBorderStyle = FormBorderStyle.None;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ScreenProtectLogin";
            base.ShowInTaskbar = false;
            this.Text = "登录";
            base.WindowState = FormWindowState.Maximized;
            base.Load += new EventHandler(this.ScreenProtectLogin_Load);
        }

        private void ScreenProtectLogin_Load(object sender, EventArgs e)
        {
            new ScreenProtectLogin2().ShowDialog();
        }
    }
}

