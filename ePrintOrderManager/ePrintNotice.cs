namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;

    public class ePrintNotice : Form
    {
        private Container components = null;
        private Label label1;
        public string NoticeInfo = null;

        public ePrintNotice()
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

        private void ePrintNotice_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.NoticeInfo;
        }

        private void InitializeComponent()
        {
            ResourceManager manager = new ResourceManager(typeof(ePrintNotice));
            this.label1 = new Label();
            base.SuspendLayout();
            this.label1.Location = new Point(0x18, 0x10);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x160, 0xb0);
            this.label1.TabIndex = 0;
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = Color.LightGray;
            base.ClientSize = new Size(0x192, 0xd7);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ePrintNotice";
            base.StartPosition = FormStartPosition.CenterScreen;
            base.Load += new EventHandler(this.ePrintNotice_Load);
            base.ResumeLayout(false);
        }
    }
}

