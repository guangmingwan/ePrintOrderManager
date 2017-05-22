namespace ePrintOrderManager
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class myprogress : Control
    {
        private Brush captionbrush = Brushes.Black;
        private int fvalue;
        private int Max = 100;
        private Pen progressbrush = Pens.DarkGreen;

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                Bitmap image = new Bitmap(base.Width, base.Height);
                Graphics graphics = Graphics.FromImage(image);
                int x = 0;
                int y = 4;
                int width = base.Width;
                graphics.DrawRectangle(this.ProgressBrush, x, y, width - 0x19, 9);
                int num4 = x + 1;
                int num5 = y + 1;
                _fileinfo tag = (_fileinfo) base.Tag;
                int num6 = ((base.Width * this.Value) / this.Max) - 0x19;
                graphics.FillRectangle(Brushes.LightGreen, num4, num5, num6, 8);
                graphics.DrawString(Convert.ToString(this.Value) + "%", new Font("宋体", 9f), this.CaptionBrush, (float) (width - 0x17), 3f);
                base.CreateGraphics().DrawImage(image, 0, 0);
            }
            catch
            {
            }
        }

        public string Caption
        {
            get
            {
                return this.Caption;
            }
            set
            {
                this.Caption = value;
            }
        }

        public Brush CaptionBrush
        {
            get
            {
                return this.captionbrush;
            }
            set
            {
                this.captionbrush = value;
            }
        }

        public Pen ProgressBrush
        {
            get
            {
                return this.progressbrush;
            }
            set
            {
                this.progressbrush = value;
            }
        }

        public int Value
        {
            get
            {
                return this.fvalue;
            }
            set
            {
                this.fvalue = value;
                base.Invalidate();
            }
        }
    }
}

