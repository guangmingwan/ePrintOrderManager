namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Resources;
    using System.Threading;
    using System.Windows.Forms;

    public class ViewLogFile : Form
    {
        private IContainer components;
        private System.Windows.Forms.Timer timer1;
        private ToolBar toolBar1;
        private ToolBarButton toolBarButton1;
        private ToolBarButton toolBarButton2;
        private ToolBarButton toolBarButton3;
        private ToolBarButton toolBarButton4;

        public ViewLogFile()
        {
            this.InitializeComponent();
            ePrintMain.isShowLogView = true;
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
            this.components = new Container();
            ResourceManager manager = new ResourceManager(typeof(ViewLogFile));
            this.toolBar1 = new ToolBar();
            this.toolBarButton1 = new ToolBarButton();
            this.toolBarButton2 = new ToolBarButton();
            this.toolBarButton3 = new ToolBarButton();
            this.toolBarButton4 = new ToolBarButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            base.SuspendLayout();
            this.toolBar1.Appearance = ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new ToolBarButton[] { this.toolBarButton1, this.toolBarButton2, this.toolBarButton3, this.toolBarButton4 });
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Location = new Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new Size(0x250, 0x29);
            this.toolBar1.TabIndex = 2;
            this.toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            this.toolBarButton1.Text = "层叠";
            this.toolBarButton2.Text = "水平平铺";
            this.toolBarButton3.Text = "垂直平铺";
            this.toolBarButton4.Text = "退出";
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x250, 0x135);
            base.Controls.Add(this.toolBar1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.IsMdiContainer = true;
            base.Name = "ViewLogFile";
            this.Text = "平台日志查看";
            base.Closing += new CancelEventHandler(this.ViewLogFile_Closing);
            base.ResumeLayout(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ePrintMain.isShow)
            {
                int index = 0;
                string[] logFileName = ePrintMain.LogFileName;
                for (int i = 0; i < logFileName.Length; i++)
                {
                    string text1 = logFileName[i];
                    new LogFileInfo { MdiParent = this, Text = ePrintMain.LogFileName[index], FileName = ePrintMain.LogFileName[index] }.Show();
                    index++;
                }
                ePrintMain.isShow = false;
            }
            Thread.Sleep(100);
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == this.toolBarButton1)
            {
                base.LayoutMdi(MdiLayout.Cascade);
            }
            else if (e.Button == this.toolBarButton2)
            {
                base.LayoutMdi(MdiLayout.TileHorizontal);
            }
            else if (e.Button == this.toolBarButton3)
            {
                base.LayoutMdi(MdiLayout.TileVertical);
            }
            else if (e.Button == this.toolBarButton4)
            {
                base.Close();
            }
        }

        private void ViewLogFile_Closing(object sender, CancelEventArgs e)
        {
            ePrintMain.isShowLogView = false;
        }
    }
}

