namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.print2000.update;
    using GlacialComponents.Controls;
    using GlacialComponents.Controls.Common;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Resources;
    using System.Threading;
    using System.Windows.Forms;

    public class ePrintUpdate : Form
    {
        public static long[] _everyFileSize;
        public static long[] _loadingAllSize;
        public static string[] _StrFileName;
        public static string[] _StrUrl;
        public static long AllEndSize = 0L;
        private long AllSize = 0L;
        private Button button1;
        private Button button2;
        private IContainer components;
        public static int FileNum = 0;
        private static GlacialList glacialList1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private Label label4;
        public static long loadingAllSize = 0L;
        public static long loadingEndSize = 0L;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private string SaveFilePath = null;
        private System.Windows.Forms.Timer timer1;
        private string UpdateFilePath = null;
        private long UpdateFileSize = 0L;
        private string WhichServer = null;
        public static int WhichUpdate = 0;

        public ePrintUpdate()
        {
            this.InitializeComponent();
            this.GetPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((!this.radioButton1.Checked && !this.radioButton2.Checked) && (!this.radioButton3.Checked && !this.radioButton4.Checked)) && (!this.radioButton5.Checked && !this.radioButton6.Checked))
            {
                MessageBox.Show("请选择服务器！");
            }
            else
            {
                if (this.radioButton1.Checked)
                {
                    this.WhichServer = "bj";
                }
                else
                {
                    this.WhichServer = "gz";
                }
                this.panel4.Visible = false;
                this.panel3.Visible = true;
                this.button2.Enabled = false;
                new Thread(new ThreadStart(this.GetFile)).Start();
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

        public static void DownFile()
        {
            if (WhichUpdate < FileNum)
            {
                loadingAllSize = _loadingAllSize[WhichUpdate];
                glacialList1.Items[WhichUpdate].SubItems[0].ImageIndex = 2;
                if (WhichUpdate > 0)
                {
                    glacialList1.Items[WhichUpdate - 1].SubItems[0].ImageIndex = 1;
                    glacialList1.Items[WhichUpdate - 1].RowBorderSize = 0;
                }
                glacialList1.Items[WhichUpdate].RowBorderSize = 1;
                glacialList1.Refresh();
                new UpdateDown { StrFileName = _StrFileName[WhichUpdate], StrUrl = _StrUrl[WhichUpdate], WhichUpdate = WhichUpdate }.down();
            }
        }

        private void ePrintUpdate_Load(object sender, EventArgs e)
        {
        }

        private void GetFile()
        {
            ePrintOutputLogin login = new ePrintOutputLogin();
            string[] strArray = login._GetUpdateFiles().Split(new char[] { '|' });
            FileNum = strArray.Length - 1;
            _StrFileName = new string[strArray.Length - 1];
            _StrUrl = new string[strArray.Length - 1];
            _loadingAllSize = new long[strArray.Length - 1];
            _everyFileSize = new long[strArray.Length - 1];
            for (int i = 0; i < (strArray.Length - 1); i++)
            {
                string[] strArray2 = strArray[i].Split(new char[] { ',' });
                this.AllSize += Convert.ToInt64(strArray2[1]);
                GLItem item = new GLItem();
                item.SubItems[0].ImageIndex = 0;
                item.SubItems[1].Text = strArray2[0];
                item.SubItems[2].Text = strArray2[1] + " 字节";
                item.SubItems[3].Text = strArray2[2];
                glacialList1.Items.Add(item);
                string path = this.SaveFilePath + @"\" + strArray2[2];
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                _StrFileName[i] = path + @"\" + strArray2[0];
                if (this.WhichServer == "bj")
                {
                    _StrUrl[i] = "http://210.192.124.201/ePrintServer/Update/" + strArray2[2] + "/" + strArray2[0];
                }
                else
                {
                    _StrUrl[i] = "http://u.print2000.cn/ePrintServer/ePrintSetup2/" + strArray2[2] + "/" + strArray2[0];
                }
                _loadingAllSize[i] = Convert.ToInt64(strArray2[1]);
                if (strArray2[0].IndexOf("ePrintOrderManager") >= 0)
                {
                    this.UpdateFileSize = Convert.ToInt64(strArray2[1]);
                    this.UpdateFilePath = path + @"\" + strArray2[0];
                }
            }
            glacialList1.Refresh();
            DownFile();
        }

        private void GetPath()
        {
            this.SaveFilePath = Environment.CurrentDirectory + @"\印易安装程序包";
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ResourceManager manager = new ResourceManager(typeof(ePrintUpdate));
            GLColumn column = new GLColumn();
            GLColumn column2 = new GLColumn();
            GLColumn column3 = new GLColumn();
            GLColumn column4 = new GLColumn();
            this.imageList1 = new ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new GroupBox();
            this.button1 = new Button();
            this.pictureBox1 = new PictureBox();
            this.panel3 = new Panel();
            this.panel2 = new Panel();
            this.panel1 = new Panel();
            this.progressBar2 = new ProgressBar();
            this.progressBar1 = new ProgressBar();
            this.label2 = new Label();
            this.label1 = new Label();
            glacialList1 = new GlacialList();
            this.panel4 = new Panel();
            this.label4 = new Label();
            this.groupBox2 = new GroupBox();
            this.radioButton4 = new RadioButton();
            this.radioButton3 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.radioButton1 = new RadioButton();
            this.radioButton6 = new RadioButton();
            this.radioButton5 = new RadioButton();
            this.button2 = new Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            base.SuspendLayout();
            this.imageList1.ImageSize = new Size(0x10, 0x10);
            this.imageList1.ImageStream = (ImageListStreamer) manager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.timer1.Enabled = true;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.groupBox1.BackColor = SystemColors.Control;
            this.groupBox1.Location = new Point(9, 0xf8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1f8, 3);
            this.groupBox1.TabIndex = 0x23;
            this.groupBox1.TabStop = false;
            this.button1.BackColor = SystemColors.Control;
            this.button1.Location = new Point(0x1b1, 0x108);
            this.button1.Name = "button1";
            this.button1.TabIndex = 30;
            this.button1.Text = "取消(&C)";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            this.pictureBox1.Image = (Image) manager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(9, 0x10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(120, 0xd8);
            this.pictureBox1.TabIndex = 0x1a;
            this.pictureBox1.TabStop = false;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.progressBar2);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(glacialList1);
            this.panel3.Location = new Point(0x88, 0x10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(0x180, 0xe0);
            this.panel3.TabIndex = 0x31;
            this.panel2.BackColor = SystemColors.Highlight;
            this.panel2.Location = new Point(0x45, 0xc1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(0, 0x10);
            this.panel2.TabIndex = 0x37;
            this.panel1.BackColor = SystemColors.Highlight;
            this.panel1.Location = new Point(0x45, 0xa1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0, 0x10);
            this.panel1.TabIndex = 0x36;
            this.progressBar2.Location = new Point(0x44, 0xc0);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new Size(0x138, 0x12);
            this.progressBar2.TabIndex = 0x35;
            this.progressBar1.Location = new Point(0x44, 160);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new Size(0x138, 0x12);
            this.progressBar1.TabIndex = 0x34;
            this.label2.Location = new Point(4, 200);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x48, 0x10);
            this.label2.TabIndex = 0x33;
            this.label2.Text = "总体进度：";
            this.label1.Location = new Point(4, 0xa8);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x48, 0x18);
            this.label1.TabIndex = 50;
            this.label1.Text = "当前进度：";
            glacialList1.BackColor = SystemColors.Control;
            column.Name = "Column1";
            column.SortType = SortTypes.None;
            column.Text = "状态";
            column.Width = 40;
            column2.Name = "Column2";
            column2.SortType = SortTypes.None;
            column2.Text = "文件名";
            column2.Width = 120;
            column3.Name = "Column3";
            column3.SortType = SortTypes.None;
            column3.Text = "文件大小";
            column4.Name = "Column4";
            column4.SortType = SortTypes.None;
            column4.Text = "版本";
            column4.Width = 0x70;
            glacialList1.Columns.AddRange(new GLColumn[] { column, column2, column3, column4 });
            glacialList1.GridLineStyle = GLGridLineStyles.gridNone;
            glacialList1.HotTrackingColor = SystemColors.HotTrack;
            glacialList1.ImageList = this.imageList1;
            glacialList1.ItemHeight = 0x13;
            glacialList1.Location = new Point(4, 8);
            glacialList1.Name = "glacialList1";
            glacialList1.Selectable = false;
            glacialList1.SelectedTextColor = SystemColors.HighlightText;
            glacialList1.SelectionColor = SystemColors.Highlight;
            glacialList1.Size = new Size(0x178, 0x88);
            glacialList1.TabIndex = 0x31;
            glacialList1.Text = "glacialList1";
            glacialList1.UnfocusedSelectionColor = SystemColors.Highlight;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new Point(0x88, 0x10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(0x180, 0xd8);
            this.panel4.TabIndex = 50;
            this.label4.Location = new Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x110, 0x18);
            this.label4.TabIndex = 9;
            this.label4.Text = "请选择您所在城市或附近服务器进行升级操作！";
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new Point(8, 0x20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(360, 0xb8);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务器";
            this.radioButton4.Location = new Point(0x20, 0x60);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "广州";
            this.radioButton3.Location = new Point(0x20, 0x48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "杭州";
            this.radioButton2.Location = new Point(0x20, 0x30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "上海";
            this.radioButton1.Location = new Point(0x20, 0x18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "北京";
            this.radioButton6.Location = new Point(0x20, 0x90);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "重庆";
            this.radioButton5.Location = new Point(0x20, 120);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "武汉";
            this.button2.BackColor = SystemColors.Control;
            this.button2.Location = new Point(0x160, 0x108);
            this.button2.Name = "button2";
            this.button2.TabIndex = 0x33;
            this.button2.Text = "下一步(&N)";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x20a, 0x12f);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.panel4);
            base.Controls.Add(this.panel3);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.pictureBox1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ePrintUpdate";
            base.SizeGripStyle = SizeGripStyle.Hide;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "印易在线升级";
            base.TopMost = true;
            base.Load += new EventHandler(this.ePrintUpdate_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _everyFileSize[WhichUpdate] = loadingEndSize;
                this.panel1.Width = Convert.ToInt16((double) ((Convert.ToDouble(loadingEndSize) / Convert.ToDouble(loadingAllSize)) * 312.0)) - 2;
            }
            catch
            {
            }
            try
            {
                AllEndSize = 0L;
                for (int i = 0; i < FileNum; i++)
                {
                    AllEndSize += _everyFileSize[i];
                }
                if (AllEndSize <= this.AllSize)
                {
                    this.panel2.Width = Convert.ToInt16((double) ((Convert.ToDouble(AllEndSize) / Convert.ToDouble(this.AllSize)) * 310.0));
                }
                else
                {
                    this.panel2.Width = 310;
                }
            }
            catch
            {
            }
            if ((FileNum > 0) && (WhichUpdate >= FileNum))
            {
                FileInfo info = new FileInfo(this.UpdateFilePath);
                if (info.Length == this.UpdateFileSize)
                {
                    this.timer1.Enabled = false;
                    glacialList1.Items[WhichUpdate - 1].SubItems[0].ImageIndex = 1;
                    glacialList1.Refresh();
                    Thread.Sleep(0x3e8);
                    Process.Start("ePrintUpdate.exe");
                    Thread.Sleep(0x3e8);
                    base.Dispose();
                    ePrintMain.isClose = 1;
                    OutputLogin.isClose = 1;
                }
                else
                {
                    this.timer1.Enabled = false;
                    MessageBox.Show("下载升级包升级,升级程序将终止,请下次再试！", "印易提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}

