namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class ViewInfoWindow : Form
    {
        private Container components = null;
        private Panel panel1;

        public ViewInfoWindow()
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
            this.panel1 = new Panel();
            base.SuspendLayout();
            this.panel1.BackColor = Color.RosyBrown;
            this.panel1.BorderStyle = BorderStyle.Fixed3D;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x268, 0x18);
            this.panel1.TabIndex = 0;
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(0x268, 0x18);
            base.ControlBox = false;
            base.Controls.Add(this.panel1);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "ViewInfoWindow";
            base.ShowInTaskbar = false;
            this.Text = "ViewInfoWindow";
            base.TopMost = true;
            base.ResumeLayout(false);
        }
    }
}

