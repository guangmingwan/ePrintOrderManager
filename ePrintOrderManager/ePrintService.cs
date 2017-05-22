namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class ePrintService : Form
    {
        private Container components = null;

        public ePrintService()
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
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(0x124, 0x111);
            base.Name = "ePrintService";
        }
    }
}

