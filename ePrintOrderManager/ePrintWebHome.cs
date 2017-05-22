namespace ePrintOrderManager
{
    using AxSHDocVw;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Resources;
    using System.Threading;
    using System.Windows.Forms;

    public class ePrintWebHome : Form
    {
        private AxWebBrowser axWebBrowser1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private IContainer components;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ImageList imageList1;
        private Label label1;
        private Panel panel1;
        private StatusBar statusBar1;
        private StatusBarPanel statusBarPanel1;
        private StatusBarPanel statusBarPanel2;
        private StatusBarPanel statusBarPanel3;
        private StatusBarPanel statusBarPanel4;
        private StatusBarPanel statusBarPanel5;
        private ToolBar toolBar2;
        private ToolBarButton toolBarButton1;
        private ToolBarButton toolBarButton2;
        private ToolBarButton toolBarButton3;
        private ToolBarButton toolBarButton4;

        public ePrintWebHome()
        {
            this.InitializeComponent();
            ePrintMain.ePrintWebHome = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strUri = this.comboBox1.Text.Trim();
            if (strUri == "")
            {
                strUri = "about:blank";
            }
            this.OpenWeb(strUri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Focused)
            {
                this.button1_Click(null, null);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void ePrintWebHome_Closing(object sender, CancelEventArgs e)
        {
            ePrintMain.ePrintWebHome = false;
        }

        private void ePrintWebHome_Load(object sender, EventArgs e)
        {
            string webPlatEntry = OutputLogin.WebPlatEntry;
            string strUri = webPlatEntry + "?UserName=" + OutputLogin._AddUser + "&Password=" + OutputLogin._AddPassword;
            this.OpenWeb(strUri);
            this.viewUrl();
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ResourceManager manager = new ResourceManager(typeof(ePrintWebHome));
            this.toolBar2 = new ToolBar();
            this.toolBarButton1 = new ToolBarButton();
            this.toolBarButton2 = new ToolBarButton();
            this.toolBarButton3 = new ToolBarButton();
            this.toolBarButton4 = new ToolBarButton();
            this.imageList1 = new ImageList(this.components);
            this.panel1 = new Panel();
            this.button1 = new Button();
            this.label1 = new Label();
            this.groupBox2 = new GroupBox();
            this.groupBox1 = new GroupBox();
            this.comboBox1 = new ComboBox();
            this.statusBar1 = new StatusBar();
            this.statusBarPanel1 = new StatusBarPanel();
            this.statusBarPanel2 = new StatusBarPanel();
            this.statusBarPanel3 = new StatusBarPanel();
            this.statusBarPanel4 = new StatusBarPanel();
            this.statusBarPanel5 = new StatusBarPanel();
            this.axWebBrowser1 = new AxWebBrowser();
            this.button2 = new Button();
            this.panel1.SuspendLayout();
            this.statusBarPanel1.BeginInit();
            this.statusBarPanel2.BeginInit();
            this.statusBarPanel3.BeginInit();
            this.statusBarPanel4.BeginInit();
            this.statusBarPanel5.BeginInit();
            this.axWebBrowser1.BeginInit();
            base.SuspendLayout();
            this.toolBar2.AllowDrop = true;
            this.toolBar2.Appearance = ToolBarAppearance.Flat;
            this.toolBar2.Buttons.AddRange(new ToolBarButton[] { this.toolBarButton1, this.toolBarButton2, this.toolBarButton3, this.toolBarButton4 });
            this.toolBar2.ButtonSize = new Size(60, 20);
            this.toolBar2.DropDownArrows = true;
            this.toolBar2.ImageList = this.imageList1;
            this.toolBar2.Location = new Point(0, 0);
            this.toolBar2.Name = "toolBar2";
            this.toolBar2.ShowToolTips = true;
            this.toolBar2.Size = new Size(680, 0x1b);
            this.toolBar2.TabIndex = 2;
            this.toolBar2.TextAlign = ToolBarTextAlign.Right;
            this.toolBar2.ButtonClick += new ToolBarButtonClickEventHandler(this.toolBar2_ButtonClick);
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Text = "后退";
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Text = "前进";
            this.toolBarButton3.ImageIndex = 3;
            this.toolBarButton3.Text = "停止";
            this.toolBarButton4.ImageIndex = 2;
            this.toolBarButton4.Text = "刷新";
            this.imageList1.ImageSize = new Size(15, 15);
            this.imageList1.ImageStream = (ImageListStreamer) manager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.panel1.BackColor = SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0x1b);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(680, 30);
            this.panel1.TabIndex = 5;
            this.button1.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.button1.BackColor = SystemColors.Control;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button1.Location = new Point(0x270, 4);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x30, 0x16);
            this.button1.TabIndex = 4;
            this.button1.Text = "转到";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label1.Location = new Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x30, 0x10);
            this.label1.TabIndex = 2;
            this.label1.Text = "地址(D)";
            this.groupBox2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox2.Location = new Point(-40, 0x1b);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(760, 3);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox1.Location = new Point(-32, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(760, 3);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.comboBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.comboBox1.Items.AddRange(new object[] { "http://www.print2000.cn" });
            this.comboBox1.Location = new Point(0x30, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(560, 20);
            this.comboBox1.TabIndex = 6;
            this.statusBar1.Location = new Point(0, 0x149);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new StatusBarPanel[] { this.statusBarPanel1, this.statusBarPanel2, this.statusBarPanel3, this.statusBarPanel4, this.statusBarPanel5 });
            this.statusBar1.RightToLeft = RightToLeft.No;
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new Size(680, 20);
            this.statusBar1.TabIndex = 6;
            this.statusBar1.Text = "statusBar1";
            this.statusBarPanel1.AutoSize = StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.Icon = (Icon) manager.GetObject("statusBarPanel1.Icon");
            this.statusBarPanel1.Width = 0x1b7;
            this.statusBarPanel2.Width = 0x19;
            this.statusBarPanel3.Width = 0x19;
            this.statusBarPanel4.Width = 0x19;
            this.statusBarPanel5.Icon = (Icon) manager.GetObject("statusBarPanel5.Icon");
            this.statusBarPanel5.Text = "印易网上平台";
            this.statusBarPanel5.Width = 150;
            this.axWebBrowser1.Dock = DockStyle.Fill;
            this.axWebBrowser1.Enabled = true;
            this.axWebBrowser1.Location = new Point(0, 0x39);
            this.axWebBrowser1.OcxState = (AxHost.State) manager.GetObject("axWebBrowser1.OcxState");
            this.axWebBrowser1.Size = new Size(680, 0x110);
            this.axWebBrowser1.TabIndex = 7;
            this.button2.Location = new Point(0x138, 8);
            this.button2.Name = "button2";
            this.button2.Size = new Size(0, 0);
            this.button2.TabIndex = 9;
            this.button2.Click += new EventHandler(this.button2_Click);
            base.AcceptButton = this.button2;
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(680, 0x15d);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.axWebBrowser1);
            base.Controls.Add(this.statusBar1);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.toolBar2);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.IsMdiContainer = true;
            base.KeyPreview = true;
            base.Name = "ePrintWebHome";
            this.Text = "印易在线服务平台";
            base.WindowState = FormWindowState.Maximized;
            base.Closing += new CancelEventHandler(this.ePrintWebHome_Closing);
            base.Load += new EventHandler(this.ePrintWebHome_Load);
            this.panel1.ResumeLayout(false);
            this.statusBarPanel1.EndInit();
            this.statusBarPanel2.EndInit();
            this.statusBarPanel3.EndInit();
            this.statusBarPanel4.EndInit();
            this.statusBarPanel5.EndInit();
            this.axWebBrowser1.EndInit();
            base.ResumeLayout(false);
        }

        private void OpenWeb(string strUri)
        {
            try
            {
                if (this.axWebBrowser1.Offline)
                {
                    MessageBox.Show("offline");
                }
                int num = 0;
                object flags = num;
                string str = "";
                object targetFrameName = str;
                this.axWebBrowser1.Navigate(strUri, ref flags, ref targetFrameName, ref targetFrameName, ref targetFrameName);
            }
            catch (Exception exception)
            {
                Console.Write(exception.ToString());
            }
        }

        private void toolBar2_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            try
            {
                if (e.Button.Text == "后退")
                {
                    this.axWebBrowser1.GoBack();
                }
                else if (e.Button.Text == "前进")
                {
                    this.axWebBrowser1.GoForward();
                }
                else if (e.Button.Text == "停止")
                {
                    this.axWebBrowser1.Stop();
                }
                else if (e.Button.Text == "刷新")
                {
                    this.axWebBrowser1.CtlRefresh();
                }
                Thread.Sleep(100);
                this.viewUrl();
            }
            catch (Exception exception)
            {
                Console.Write(exception.ToString());
            }
        }

        private void viewUrl()
        {
            if (this.axWebBrowser1.LocationURL == "")
            {
                this.comboBox1.Text = "http://www.eprinting.cn";
            }
            else
            {
                this.comboBox1.Text = this.axWebBrowser1.LocationURL;
            }
        }
    }
}

