namespace ePrintOrderManager
{
    using Dart.PowerTCP.Ftp;
    using ePrintOrderManager.cn.com.print2000.output;
    using GlacialComponents.Controls;
    using GlacialComponents.Controls.Common;
    using Microsoft.Win32;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Resources;
    using System.Threading;
    using System.Windows.Forms;

    public class SendFileToUser : Form
    {
        public static string[] AddNewUser = null;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private IContainer components;
        private ContextMenu contextMenu1;
        private long[] FileSize = new long[0x2800];
        private Dart.PowerTCP.Ftp.Ftp ftp1;
        private int FtpState = 0;
        private GlacialList glacialList1;
        private GroupBox groupBox1;
        private bool isError = false;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private MenuItem menuItem6;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private string PuttingFileName = null;
        private int PuttingWhich = 0;
        public string[] ReceiveCompanyName;
        private long[] ReceivedSize = new long[0x2800];
        public string[] ReceiveUser;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private System.Windows.Forms.Timer timer1;
        public static System.Windows.Forms.Timer timer2;
        private int WhichItem = 0;
        private int WhichItemSelected;

        public SendFileToUser()
        {
            this.InitializeComponent();
            ePrintMain.SendFileIsOpen = true;
        }

        private void AddFiles()
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (this.glacialList1.Items[i].Selected)
                    {
                        for (int j = 0; j < this.openFileDialog1.FileNames.Length; j++)
                        {
                            if ((this.glacialList1.Items[i].SubItems[1].Text == "") && (j == 0))
                            {
                                this.glacialList1.Items[i].SubItems[1].Text = this.openFileDialog1.FileNames[0];
                                FileInfo info = new FileInfo(this.openFileDialog1.FileNames[0]);
                                this.glacialList1.Items[i].SubItems[2].Text = this.sizeChange(info.Length);
                            }
                            else
                            {
                                GLItem item = new GLItem {
                                    Tag = this.glacialList1.Items[i].Tag,
                                    BackColor = this.glacialList1.Items[i].BackColor
                                };
                                item.SubItems[0].Text = "";
                                item.SubItems[1].Text = this.openFileDialog1.FileNames[j];
                                FileInfo info2 = new FileInfo(this.openFileDialog1.FileNames[j]);
                                item.SubItems[2].Text = this.sizeChange(info2.Length);
                                this.AddNewFile(i, item);
                            }
                        }
                        this.glacialList1.Refresh();
                        this.glacialList1.Focus();
                        return;
                    }
                }
            }
        }

        private void AddLog(string Entry)
        {
            try
            {
                string str = DateTime.Now + " " + Entry;
                int length = this.richTextBox1.Text.Length;
                int num2 = str.Length;
                this.richTextBox1.AppendText(string.Concat(new object[] { DateTime.Now, " ", Entry, "\r\n" }));
                this.richTextBox1.SelectionStart = length;
                this.richTextBox1.SelectionLength = num2;
                if (Entry.IndexOf("连接到") >= 0)
                {
                    this.richTextBox1.SelectionColor = Color.DarkRed;
                }
                else if (Entry.IndexOf("开始上传") >= 0)
                {
                    this.richTextBox1.SelectionColor = Color.DarkBlue;
                }
                else if (Entry.IndexOf("成功") >= 0)
                {
                    this.richTextBox1.SelectionColor = Color.DarkGreen;
                }
                else if (((Entry.IndexOf("中止") >= 0) || (Entry.IndexOf("失败") >= 0)) || (Entry.IndexOf("错误") >= 0))
                {
                    this.richTextBox1.SelectionColor = Color.Red;
                    this.richTextBox1.SelectionFont = new Font("宋体", 10f, FontStyle.Bold);
                }
                else
                {
                    this.richTextBox1.SelectionColor = Color.Black;
                }
                this.richTextBox1.HideSelection = false;
            }
            catch
            {
            }
        }

        private void AddNewFile(int Index, GLItem item)
        {
            int num = (this.glacialList1.Items.Count - Index) - 1;
            GLItem[] items = new GLItem[num];
            int index = 0;
            for (int i = 0; i < this.glacialList1.Items.Count; i++)
            {
                if (i > Index)
                {
                    items[index] = this.glacialList1.Items[i];
                    index++;
                }
            }
            for (int j = 0; j < this.glacialList1.Items.Count; j++)
            {
                if (j > Index)
                {
                    this.glacialList1.Items.Remove(j);
                    j--;
                }
            }
            this.glacialList1.Items.Add(item);
            this.glacialList1.Items.AddRange(items);
        }

        private void BeginPub(string FilePath)
        {
            try
            {
                this.PuttingFileName = this.GetFilename(FilePath);
                if ((((this.PuttingFileName.IndexOf(" ") >= 0) || (this.GetFilename(FilePath).IndexOf("'") >= 0)) || ((this.GetFilename(FilePath).IndexOf(";") >= 0) || (this.GetFilename(FilePath).IndexOf("%") >= 0))) || (((this.GetFilename(FilePath).IndexOf("&") >= 0) || (this.GetFilename(FilePath).IndexOf("#") >= 0)) || ((this.GetFilename(FilePath).IndexOf("+") >= 0) || (this.GetFilename(FilePath).IndexOf(",") >= 0))))
                {
                    this.AddLog("文件名中含有 \"空格,单引号,逗号,;,%,&,#,+\" 中的特殊特号!");
                    this.PuttingFileName = this.PuttingFileName.Replace(" ", "_").Replace("'", "’").Replace(";", "；").Replace("%", "％").Replace("&", "＆").Replace("#", "＃").Replace("+", "＋").Replace(",", "，");
                    this.AddLog("文件名更改为: " + this.PuttingFileName);
                }
                FtpFile result = this.ftp1.Put(FilePath, ePrintMain.Outputkey + @"\userfile\" + this.PuttingFileName);
                this.ShowResult(result);
            }
            catch
            {
                this.ftp1.AbortTransfer();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.delete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.glacialList1.Items.Count <= 0)
            {
                MessageBox.Show("请先添加客户以及要发送的文件!");
            }
            else
            {
                this.FtpState = 0;
                this.SetProperties();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.HideViewRemark();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.FtpState = 2;
            this.ftp1.AbortTransfer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AllUserInfo().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.glacialList1.Items.Count > 0)
            {
                if (this.glacialList1.Items.SelectedItems.Count > 0)
                {
                    this.AddFiles();
                }
                else
                {
                    MessageBox.Show("请先选择要添加文件的客户!");
                }
            }
            else
            {
                MessageBox.Show("请先添加客户!");
            }
        }

        private void contextMenu1_Popup(object sender, EventArgs e)
        {
            this.glacialList1.Refresh();
            if (this.glacialList1.SelectedItems.Count <= 0)
            {
                for (int i = 0; i < this.contextMenu1.MenuItems.Count; i++)
                {
                    if (i == 3)
                    {
                        this.contextMenu1.MenuItems[i].Enabled = true;
                    }
                    else
                    {
                        this.contextMenu1.MenuItems[i].Enabled = false;
                    }
                }
            }
            else
            {
                for (int j = 0; j < this.glacialList1.Items.Count; j++)
                {
                    if (this.glacialList1.Items[j].Selected)
                    {
                        if (j < this.PuttingWhich)
                        {
                            for (int m = 0; m < this.contextMenu1.MenuItems.Count; m++)
                            {
                                if (m == 0)
                                {
                                    this.contextMenu1.MenuItems[m].Enabled = false;
                                }
                                else
                                {
                                    this.contextMenu1.MenuItems[m].Enabled = true;
                                }
                            }
                            return;
                        }
                        for (int k = 0; k < this.contextMenu1.MenuItems.Count; k++)
                        {
                            this.contextMenu1.MenuItems[k].Enabled = true;
                        }
                        return;
                    }
                }
            }
        }

        private void delete()
        {
            if (this.glacialList1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (this.glacialList1.Items[i].Selected)
                    {
                        this.glacialList1.Items.Remove(i);
                        if (i < this.PuttingWhich)
                        {
                            this.PuttingWhich--;
                        }
                        i--;
                    }
                }
            }
            this.glacialList1.Refresh();
            this.glacialList1.Focus();
            if (this.glacialList1.Items.Count <= 0)
            {
                this.button1.Enabled = this.button3.Enabled = this.button8.Enabled = false;
            }
        }

        private void delRegFile()
        {
            try
            {
                int num = 5;
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\UserFiles", true);
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();
                    if (valueNames.Length > num)
                    {
                        for (int i = 0; i < (valueNames.Length - num); i++)
                        {
                            key.DeleteValue(valueNames[i]);
                        }
                    }
                }
                else
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\ePrint\UserFiles");
                }
            }
            catch
            {
            }
        }

        private void delUserFile(string FileName)
        {
            new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx").DelFile(ePrintMain.Outputkey, FileName);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string str = null;
            Array data = (Array) e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < data.Length; i++)
            {
                str = str + data.GetValue(i) + "\n";
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ftp1_BusyChanged(object sender, EventArgs e)
        {
            this.button2.Enabled = !this.ftp1.Busy;
            this.button4.Enabled = this.ftp1.Busy;
        }

        private void ftp1_ConnectedChanged(object sender, EventArgs e)
        {
            if (this.ftp1.Connected)
            {
                this.FtpState = 1;
                this.AddLog("连接到服务器: " + this.ftp1.Connection.RemoteEndPoint.Address.ToString());
            }
            else
            {
                this.AddLog("与服务器连接已经关闭！");
            }
        }

        private void ftp1_Progress(object sender, FtpProgressEventArgs e)
        {
            try
            {
                if (e.Length > 0L)
                {
                    this.ReceivedSize[this.PuttingWhich] = e.Position;
                    this.FileSize[this.PuttingWhich] = e.Length;
                    string str = (Convert.ToString(Math.Round((double) ((Convert.ToDouble(e.Position) / Convert.ToDouble(e.Length)) * 100.0), 2)) == "100") ? "99.9" : Convert.ToString(Math.Round((double) ((Convert.ToDouble(e.Position) / Convert.ToDouble(e.Length)) * 100.0), 2));
                    this.glacialList1.Items[this.PuttingWhich].SubItems[3].Text = this.sizeChange(e.Position);
                    this.glacialList1.Items[this.PuttingWhich].SubItems[4].Text = str + "%";
                }
                long totalFiles = e.TotalFiles;
                if (((e.CurrentFile == 1L) && (e.Count == 0L)) && (e.Status != FtpFileStatus.TransferCompleted))
                {
                    this.AddLog("连接服务器成功!");
                    this.AddLog("开始上传文件: " + this.PuttingFileName);
                    this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "文件上传中...";
                }
            }
            catch (Exception exception)
            {
                this.isError = true;
                this.AddLog("在程序事件中发生错误： " + exception.Message);
            }
        }

        private string GetFilename(string Path)
        {
            int num = Path.LastIndexOf(@"\");
            int num2 = Path.LastIndexOf("/");
            if (num2 > num)
            {
                num = num2;
            }
            return Path.Substring(num + 1);
        }

        private string GetPath(string Filename)
        {
            int num = Filename.LastIndexOf(@"\");
            int num2 = Filename.LastIndexOf("/");
            if (num2 > num)
            {
                num = num2;
            }
            return Filename.Substring(0, num + 1);
        }

        private void glacialList1_Click(object sender, EventArgs e)
        {
        }

        private void glacialList1_DragDrop(object sender, DragEventArgs e)
        {
            string str = null;
            Array data = (Array) e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < data.Length; i++)
            {
                str = str + data.GetValue(i) + "\n";
            }
        }

        private void glacialList1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void glacialList1_MouseDown(object sender, MouseEventArgs e)
        {
            this.glacialList1.Focus();
            if (e.Button == MouseButtons.Right)
            {
                this.glacialList1.Focus();
                if (this.glacialList1.GetItemAt(e.X, e.Y) != null)
                {
                    if (!this.glacialList1.GetItemAt(e.X, e.Y).Selected)
                    {
                        this.glacialList1.Items.ClearSelection();
                        this.glacialList1.GetItemAt(e.X, e.Y).Selected = true;
                        this.glacialList1.Refresh();
                    }
                }
                else
                {
                    this.glacialList1.Items.ClearSelection();
                }
            }
            if ((e.Button == MouseButtons.Left) && (this.glacialList1.GetItemAt(e.X, e.Y) == null))
            {
                this.glacialList1.Items.ClearSelection();
                this.glacialList1.Refresh();
            }
            if (this.glacialList1.Items.Count > 0)
            {
                if (this.glacialList1.SelectedItems.Count > 0)
                {
                    this.button1.Enabled = this.button3.Enabled = this.button8.Enabled = true;
                }
                else
                {
                    this.button1.Enabled = this.button3.Enabled = this.button8.Enabled = false;
                }
            }
            else
            {
                this.button1.Enabled = this.button3.Enabled = this.button8.Enabled = false;
            }
            this.viewRemark();
        }

        private void glacialList1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.glacialList1.Items.Count > 0)
                {
                    if (this.glacialList1.GetItemAt(e.X, e.Y) != null)
                    {
                        int nColumn = 0;
                        if ((e.X > this.glacialList1.GetColumnScreenX(0)) && (e.X < this.glacialList1.GetColumnScreenX(1)))
                        {
                            nColumn = 0;
                        }
                        if ((e.X > this.glacialList1.GetColumnScreenX(1)) && (e.X < this.glacialList1.GetColumnScreenX(2)))
                        {
                            nColumn = 1;
                        }
                        if ((e.X > this.glacialList1.GetColumnScreenX(2)) && (e.X < this.glacialList1.GetColumnScreenX(3)))
                        {
                            nColumn = 2;
                        }
                        if ((e.X > this.glacialList1.GetColumnScreenX(3)) && (e.X < this.glacialList1.GetColumnScreenX(4)))
                        {
                            nColumn = 3;
                        }
                        if ((e.X > this.glacialList1.GetColumnScreenX(4)) && (e.X < this.glacialList1.GetColumnScreenX(5)))
                        {
                            nColumn = 4;
                        }
                        if ((e.X > this.glacialList1.GetColumnScreenX(5)) && (e.X < this.glacialList1.GetColumnScreenX(6)))
                        {
                            nColumn = 5;
                        }
                        int width = this.glacialList1.Columns[nColumn].Width;
                        SizeF ef = base.CreateGraphics().MeasureString(this.glacialList1.GetItemAt(e.X, e.Y).SubItems[nColumn].Text.Trim(), this.Font);
                        if ((ef.Width + 4f) > width)
                        {
                            for (int i = 0; i < this.glacialList1.Items.Count; i++)
                            {
                                if (this.glacialList1.Items[i] == this.glacialList1.GetItemAt(e.X, e.Y))
                                {
                                    this.WhichItem = i;
                                }
                            }
                            this.label1.Width = Convert.ToInt32(ef.Width) + 4;
                            this.label1.Height = Convert.ToInt32(ef.Height);
                            this.label1.Location = new Point(this.glacialList1.GetColumnScreenX(nColumn) + 0x15, (this.WhichItem * 0x10) + 0x37);
                            this.label1.Text = this.glacialList1.GetItemAt(e.X, e.Y).SubItems[nColumn].Text.Trim();
                            this.label1.BringToFront();
                            this.label1.Visible = true;
                        }
                        else
                        {
                            this.label1.Visible = false;
                        }
                    }
                    else
                    {
                        this.label1.Visible = false;
                    }
                }
                else
                {
                    this.label1.Visible = false;
                }
            }
            catch (Exception exception)
            {
                Console.Write("\n\n\n" + exception.ToString() + "\n\n\n");
            }
        }

        private void glacialList1_Paint(object sender, PaintEventArgs e)
        {
            if (this.ftp1.Connected)
            {
                try
                {
                    Graphics graphics = e.Graphics;
                    if (this.glacialList1.Items.Count > 0)
                    {
                        int columnScreenX = this.glacialList1.GetColumnScreenX(4);
                        int y = (this.PuttingWhich * 0x10) + 0x15;
                        int width = this.glacialList1.Columns[4].Width - 0x27;
                        graphics.DrawRectangle(new Pen(Brushes.Black), columnScreenX, y, width, 8);
                        int x = columnScreenX + 1;
                        int num5 = y + 1;
                        int num6 = 0;
                        try
                        {
                            num6 = Convert.ToInt16((double) ((Convert.ToDouble(this.ReceivedSize[this.PuttingWhich]) / Convert.ToDouble(this.FileSize[this.PuttingWhich])) * width)) - 1;
                        }
                        catch
                        {
                        }
                        graphics.FillRectangle(Brushes.DarkGreen, x, num5, num6, 7);
                        this.glacialList1.Items[this.PuttingWhich].RowBorderSize = 1;
                        this.glacialList1.Items[this.PuttingWhich].RowBorderColor = Color.DarkBlue;
                    }
                }
                catch (Exception exception)
                {
                    Console.Write(exception.ToString());
                }
            }
        }

        private void glacialList1_SelectedIndexChanged(object source, GLClickEventArgs e)
        {
            this.viewRemark();
        }

        private void HideViewRemark()
        {
            if (!this.groupBox1.Visible)
            {
                this.glacialList1.Width -= 0xb8;
                this.groupBox1.Visible = true;
                this.richTextBox2.Focus();
                this.richTextBox2.SelectionStart = this.richTextBox2.Text.Length;
            }
            else
            {
                this.groupBox1.Visible = false;
                this.glacialList1.Width += 0xb8;
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ResourceManager manager = new ResourceManager(typeof(SendFileToUser));
            GLColumn column = new GLColumn();
            GLColumn column2 = new GLColumn();
            GLColumn column3 = new GLColumn();
            GLColumn column4 = new GLColumn();
            GLColumn column5 = new GLColumn();
            GLColumn column6 = new GLColumn();
            GLColumn column7 = new GLColumn();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.contextMenu1 = new ContextMenu();
            this.menuItem1 = new MenuItem();
            this.menuItem2 = new MenuItem();
            this.menuItem3 = new MenuItem();
            this.menuItem4 = new MenuItem();
            this.menuItem5 = new MenuItem();
            this.menuItem6 = new MenuItem();
            this.openFileDialog1 = new OpenFileDialog();
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.groupBox1 = new GroupBox();
            this.richTextBox2 = new RichTextBox();
            this.label3 = new Label();
            this.label2 = new Label();
            this.pictureBox3 = new PictureBox();
            this.button8 = new Button();
            this.button7 = new Button();
            this.button5 = new Button();
            this.glacialList1 = new GlacialList();
            this.button4 = new Button();
            this.button6 = new Button();
            this.richTextBox1 = new RichTextBox();
            this.pictureBox1 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.label1 = new Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            timer2 = new System.Windows.Forms.Timer(this.components);
            this.ftp1 = new Dart.PowerTCP.Ftp.Ftp(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.button1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button1.BackColor = SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.Location = new Point(0xa8, 0xd8);
            this.button1.Name = "button1";
            this.button1.TabIndex = 1;
            this.button1.Text = "删除";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button2.BackColor = SystemColors.Control;
            this.button2.Location = new Point(0x148, 0xd8);
            this.button2.Name = "button2";
            this.button2.TabIndex = 2;
            this.button2.Text = "开始发送";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button3.BackColor = SystemColors.Control;
            this.button3.Enabled = false;
            this.button3.Location = new Point(0xf8, 0xd8);
            this.button3.Name = "button3";
            this.button3.TabIndex = 3;
            this.button3.Text = "备注";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.contextMenu1.MenuItems.AddRange(new MenuItem[] { this.menuItem1, this.menuItem2, this.menuItem3, this.menuItem4, this.menuItem5, this.menuItem6 });
            this.contextMenu1.Popup += new EventHandler(this.contextMenu1_Popup);
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "添加文件";
            this.menuItem1.Click += new EventHandler(this.menuItem1_Click);
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "填写备注";
            this.menuItem2.Click += new EventHandler(this.menuItem2_Click);
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "添加客户";
            this.menuItem4.Click += new EventHandler(this.menuItem4_Click);
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            this.menuItem6.DefaultItem = true;
            this.menuItem6.Index = 5;
            this.menuItem6.Shortcut = Shortcut.Del;
            this.menuItem6.Text = "删除";
            this.menuItem6.Click += new EventHandler(this.menuItem6_Click);
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "添加文件(可多选)";
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(680, 0x110);
            this.tabControl1.TabIndex = 4;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.glacialList1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new Point(4, 0x15);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new Size(0x2a0, 0xf7);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文件传送";
            this.groupBox1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Location = new Point(0x1e8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0xb8, 200);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "备注";
            this.richTextBox2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.richTextBox2.Location = new Point(8, 0x38);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new Size(0xa8, 0x88);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new EventHandler(this.richTextBox2_TextChanged);
            this.label3.ForeColor = Color.Blue;
            this.label3.Location = new Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0xa8, 0x10);
            this.label3.TabIndex = 1;
            this.label3.Text = "发送文件名称";
            this.label2.ForeColor = Color.Blue;
            this.label2.Location = new Point(8, 0x18);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0xa8, 0x10);
            this.label2.TabIndex = 0;
            this.label2.Text = "收件公司名称";
            this.pictureBox3.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.pictureBox3.Image = (Image) manager.GetObject("pictureBox3.Image");
            this.pictureBox3.Location = new Point(0, 0x60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(8, 8);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
            this.button8.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button8.Enabled = false;
            this.button8.Location = new Point(0x58, 0xd8);
            this.button8.Name = "button8";
            this.button8.TabIndex = 9;
            this.button8.Text = "添加文件";
            this.button8.Click += new EventHandler(this.button8_Click);
            this.button7.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button7.Location = new Point(8, 0xd8);
            this.button7.Name = "button7";
            this.button7.TabIndex = 8;
            this.button7.Text = "添加客户";
            this.button7.Click += new EventHandler(this.button7_Click);
            this.button5.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button5.Location = new Point(0x228, 0xd8);
            this.button5.Name = "button5";
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.Visible = false;
            this.button5.Click += new EventHandler(this.button5_Click);
            this.glacialList1.AllowDrop = true;
            this.glacialList1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.glacialList1.AutoHeight = false;
            this.glacialList1.BackColor = SystemColors.Window;
            column.Name = "Column1";
            column.SortType = SortTypes.MergeSort;
            column.Text = "收件客户";
            column.Width = 150;
            column2.Name = "Column2";
            column2.SortType = SortTypes.QuickSort;
            column2.Text = "发送文件";
            column2.Width = 200;
            column3.Name = "Column3";
            column3.SortType = SortTypes.None;
            column3.Text = "文件大小";
            column3.Width = 60;
            column4.Name = "Column1x";
            column4.Text = "完成数";
            column4.Width = 60;
            column5.Name = "Column4";
            column5.Text = "百分比";
            column5.TextAlignment = ContentAlignment.MiddleRight;
            column5.Width = 150;
            column6.Name = "Column5";
            column6.Text = "备注";
            column6.Width = 200;
            column7.Name = "Column1xx";
            column7.Text = "状态";
            this.glacialList1.Columns.AddRange(new GLColumn[] { column, column2, column3, column4, column5, column6, column7 });
            this.glacialList1.ContextMenu = this.contextMenu1;
            this.glacialList1.GridLineStyle = GLGridLineStyles.gridNone;
            this.glacialList1.HeaderHeight = 0x10;
            this.glacialList1.HideSelection = true;
            this.glacialList1.HotTrackingColor = SystemColors.HotTrack;
            this.glacialList1.ImageList = null;
            this.glacialList1.ItemHeight = 0x10;
            this.glacialList1.Location = new Point(8, 8);
            this.glacialList1.MultiSelect = true;
            this.glacialList1.Name = "glacialList1";
            this.glacialList1.SelectedTextColor = SystemColors.HighlightText;
            this.glacialList1.SelectionColor = SystemColors.Highlight;
            this.glacialList1.Size = new Size(0x1d8, 200);
            this.glacialList1.TabIndex = 1;
            this.glacialList1.Text = "glacialList1";
            this.glacialList1.UnfocusedSelectionColor = SystemColors.Highlight;
            this.glacialList1.Click += new EventHandler(this.glacialList1_Click);
            this.glacialList1.DragEnter += new DragEventHandler(this.glacialList1_DragEnter);
            this.glacialList1.Paint += new PaintEventHandler(this.glacialList1_Paint);
            this.glacialList1.DragDrop += new DragEventHandler(this.glacialList1_DragDrop);
            this.glacialList1.MouseMove += new MouseEventHandler(this.glacialList1_MouseMove);
            this.glacialList1.MouseDown += new MouseEventHandler(this.glacialList1_MouseDown);
            this.glacialList1.SelectedIndexChanged += new GlacialList.ClickedEventHandler(this.glacialList1_SelectedIndexChanged);
            this.button4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button4.BackColor = SystemColors.Control;
            this.button4.Enabled = false;
            this.button4.Location = new Point(0x198, 0xd8);
            this.button4.Name = "button4";
            this.button4.TabIndex = 5;
            this.button4.Text = "暂停";
            this.button4.Click += new EventHandler(this.button4_Click);
            this.button6.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button6.BackColor = SystemColors.Control;
            this.button6.Location = new Point(0x260, 0x120);
            this.button6.Name = "button6";
            this.button6.TabIndex = 5;
            this.button6.Text = "退出";
            this.button6.Click += new EventHandler(this.button6_Click);
            this.richTextBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new Point(0, 0x148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(0x2b8, 0x98);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.pictureBox1.Image = (Image) manager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(0x10, 0x128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x40, 0x10);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
            this.pictureBox2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.pictureBox2.Image = (Image) manager.GetObject("pictureBox2.Image");
            this.pictureBox2.Location = new Point(0x10, 0x128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0x40, 0x10);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
            this.label1.BackColor = Color.LightSteelBlue;
            this.label1.BorderStyle = BorderStyle.FixedSingle;
            this.label1.ContextMenu = this.contextMenu1;
            this.label1.Location = new Point(0x120, 0x120);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x10, 8);
            this.label1.TabIndex = 8;
            this.label1.Visible = false;
            this.label1.MouseDown += new MouseEventHandler(this.label1_MouseDown);
            this.timer1.Enabled = true;
            this.timer1.Interval = 0x3e8;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            timer2.Tick += new EventHandler(this.timer2_Tick);
            this.ftp1.ClientDataPort = "";
            this.ftp1.Connection.Charset = "gb2312";
            this.ftp1.Connection.DoEvents = false;
            this.ftp1.Editor = this.ftp1;
            this.ftp1.Password = "";
            this.ftp1.Server = "";
            this.ftp1.Username = "";
            this.ftp1.Progress += new FtpProgressEventHandler(this.ftp1_Progress);
            this.ftp1.BusyChanged += new EventHandler(this.ftp1_BusyChanged);
            this.ftp1.ConnectedChanged += new EventHandler(this.ftp1_ConnectedChanged);
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x2b8, 0x1dd);
            base.Controls.Add(this.pictureBox2);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.richTextBox1);
            base.Controls.Add(this.button6);
            base.Controls.Add(this.tabControl1);
            base.Controls.Add(this.label1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "SendFileToUser";
            this.Text = "文件发送";
            base.Closing += new CancelEventHandler(this.SendFileToUser_Closing);
            base.Load += new EventHandler(this.SendFileToUser_Load);
            base.DragDrop += new DragEventHandler(this.Form1_DragDrop);
            base.DragEnter += new DragEventHandler(this.Form1_DragEnter);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.glacialList1.Focus();
            if (this.glacialList1.Items.Count > 0)
            {
                this.glacialList1.Items.ClearSelection();
                this.glacialList1.Items[this.WhichItem].Selected = true;
            }
            if (this.glacialList1.Items.Count > 0)
            {
                if (this.glacialList1.SelectedItems.Count > 0)
                {
                    this.button1.Enabled = this.button3.Enabled = this.button8.Enabled = true;
                }
                else
                {
                    this.button1.Enabled = this.button3.Enabled = this.button8.Enabled = false;
                }
            }
            else
            {
                this.button1.Enabled = this.button3.Enabled = this.button8.Enabled = false;
            }
        }

        private void listUserInfo()
        {
            int length = this.ReceiveUser.Length;
            Color lightGray = Color.LightGray;
            for (int i = 0; i < length; i++)
            {
                GLItem item = new GLItem {
                    Tag = this.ReceiveUser[i] + "|" + this.ReceiveCompanyName[i]
                };
                item.SubItems[0].Text = this.ReceiveCompanyName[i];
                this.glacialList1.Items.Add(item);
            }
            this.glacialList1.Refresh();
        }

        private void Logout()
        {
            if (this.ftp1.Connected)
            {
                this.ftp1.Close();
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.AddFiles();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (!this.groupBox1.Visible)
            {
                this.glacialList1.Width -= 0xb8;
                this.groupBox1.Visible = true;
                this.richTextBox2.Focus();
                this.richTextBox2.SelectionStart = this.richTextBox2.Text.Length;
            }
            else
            {
                this.richTextBox2.Focus();
                this.richTextBox2.SelectionStart = this.richTextBox2.Text.Length;
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            new AllUserInfo().ShowDialog();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            this.delete();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Visible)
            {
                this.richTextBox1.Visible = false;
                base.Height -= 0x98;
                this.tabControl1.Height += 0x98;
                this.button6.Location = new Point(this.button6.Location.X, this.button6.Location.Y + 0x98);
                this.pictureBox1.Location = this.pictureBox2.Location = new Point(this.pictureBox1.Location.X, this.pictureBox1.Location.Y + 0x98);
            }
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!this.richTextBox1.Visible)
            {
                this.richTextBox1.Visible = true;
                base.Height += 0x98;
                this.tabControl1.Height -= 0x98;
                this.button6.Location = new Point(this.button6.Location.X, this.button6.Location.Y - 0x98);
                this.pictureBox1.Location = this.pictureBox2.Location = new Point(this.pictureBox1.Location.X, this.pictureBox1.Location.Y - 0x98);
            }
            this.pictureBox2.Visible = false;
            this.pictureBox1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
            this.glacialList1.Width += 0xb8;
        }

        private void PubAllFiles()
        {
            this.isError = false;
            for (int i = 0; i < this.glacialList1.Items.Count; i++)
            {
                if (this.glacialList1.Items[i].SubItems[6].Text != "完成")
                {
                    this.PuttingWhich = i;
                    if (this.glacialList1.Items[i].SubItems[1].Text.Trim() != "")
                    {
                        this.saveFileInfo(this.glacialList1.Items[i].SubItems[1].Text.Trim());
                        this.BeginPub(this.glacialList1.Items[i].SubItems[1].Text.Trim());
                    }
                    this.glacialList1.Items[this.PuttingWhich].RowBorderSize = 0;
                    if (this.FtpState == 2)
                    {
                        break;
                    }
                }
            }
            if (this.FtpState != 2)
            {
                this.Logout();
                if (this.ftp1.Connected)
                {
                    try
                    {
                        this.ftp1.Close();
                    }
                    catch
                    {
                        this.ftp1.Abort();
                    }
                }
                if (this.isError)
                {
                    this.AddLog("重新检查上传文件!\r\n");
                    this.FtpState = 0;
                    this.SetProperties();
                }
            }
            MessageBox.Show("操作完成！\n\n[注：] 百分比为 100% 的文件表示上传成功，小于 100% 的则表示上传失败，需再次点击“开始发送”按钮进行补传操作！", "印易揭示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.glacialList1.Refresh();
        }

        private void registry()
        {
            try
            {
                if (Registry.CurrentUser.OpenSubKey(@"Software\ePrint\UserFiles", true) == null)
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\ePrint\UserFiles");
                }
            }
            catch
            {
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.glacialList1.Items.Count > 0)
            {
                this.glacialList1.Items[this.WhichItemSelected].SubItems[5].Text = this.richTextBox2.Text.Trim();
            }
        }

        private void saveFileInfo(string FilePath)
        {
            FileInfo info = new FileInfo(FilePath);
            string str = info.Name + "|" + info.Length.ToString() + "|" + info.LastWriteTime.ToString();
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\UserFiles", true);
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();
                    if (valueNames.Length > 0)
                    {
                        this.ftp1.Restart = false;
                        for (int i = 0; i < valueNames.Length; i++)
                        {
                            if (key.GetValue(valueNames[i]).ToString() == str)
                            {
                                this.ftp1.Restart = true;
                                break;
                            }
                        }
                        if (!this.ftp1.Restart)
                        {
                            this.delUserFile(info.Name);
                            bool flag = false;
                            int num2 = 1;
                            while (!flag)
                            {
                                if (key.GetValue("file" + num2.ToString()) == null)
                                {
                                    key.SetValue("file" + num2.ToString(), str);
                                    flag = true;
                                }
                                else
                                {
                                    num2++;
                                }
                            }
                        }
                    }
                    else
                    {
                        this.delUserFile(info.Name);
                        this.ftp1.Restart = false;
                        key.SetValue("file1", str);
                    }
                }
                else
                {
                    Registry.CurrentUser.CreateSubKey(@"Software\ePrint\UserFiles");
                }
            }
            catch
            {
            }
        }

        private void SendFileToUser_Closing(object sender, CancelEventArgs e)
        {
            ePrintMain.SendFileIsOpen = false;
        }

        private void SendFileToUser_Load(object sender, EventArgs e)
        {
            this.delRegFile();
            this.registry();
            if (this.ReceiveUser != null)
            {
                this.listUserInfo();
            }
        }

        private void SendFileToUser_MouseEnter(object sender, EventArgs e)
        {
        }

        private void SendFileToUser_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void SetProperties()
        {
            string serverIP = OutputLogin.ServerIP;
            int num = 0x15;
            string ftpUser = OutputLogin.FtpUser;
            string str3 = "790128083";
            this.ftp1.Server = serverIP;
            this.ftp1.ServerPort = num;
            this.ftp1.Username = ftpUser;
            this.ftp1.Password = str3;
            this.ftp1.FileType = FileType.Image;
            new Thread(new ThreadStart(this.PubAllFiles)).Start();
        }

        private void ShowResult(FtpFile Result)
        {
            bool flag = false;
            FtpFile file = Result;
            if (file.Exception != null)
            {
                this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "上传出错";
                this.isError = true;
                this.AddLog("上传错误： (" + this.PuttingFileName + "): " + file.Exception.Message.Replace("\r\n", " "));
            }
            else if (file.Count == -1L)
            {
                flag = true;
            }
            else if (file.Position != file.Length)
            {
                this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "上传出错";
                this.isError = true;
                this.AddLog("上传失败: " + this.PuttingFileName);
                flag = true;
            }
            else
            {
                this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "文件上传成功";
                this.AddLog("文件: " + this.PuttingFileName + " 已上传成功!");
                this.AddLog("开始提交相关数据信息至数据库,请稍候...");
                string[] fileInfo = new string[6];
                string[] strArray2 = this.glacialList1.Items[this.PuttingWhich].Tag.ToString().Split(new char[] { '|' });
                fileInfo[0] = strArray2[0];
                fileInfo[1] = strArray2[1];
                fileInfo[2] = ePrintMain.Outputkey;
                fileInfo[3] = this.PuttingFileName;
                fileInfo[4] = this.FileSize[this.PuttingWhich].ToString();
                fileInfo[5] = this.glacialList1.Items[this.PuttingWhich].SubItems[5].Text;
                ePrintOutputLogin login = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                if (login._OutputSendFileToUser(fileInfo))
                {
                    this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "完成";
                    this.glacialList1.Items[this.PuttingWhich].SubItems[4].Text = "100%";
                    this.AddLog("写数据库成功!");
                }
                else
                {
                    this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "写数据失败";
                    this.AddLog("写数据库失败!");
                }
            }
            if (flag)
            {
                this.isError = true;
                this.AddLog("上传已中止: " + this.PuttingFileName + " 已被略过！");
                this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "上传中止";
            }
        }

        private void ShowResults(FtpFile[] Results)
        {
            bool flag = false;
            if (Results.GetLength(0) == 0)
            {
                this.AddLog("文件不存在！");
            }
            else
            {
                long length = Results.GetLength(0);
                foreach (FtpFile file in Results)
                {
                    if (file.Exception != null)
                    {
                        this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "上传出错";
                        this.isError = true;
                        this.AddLog("上传错误： (" + this.PuttingFileName + "): " + file.Exception.Message.Replace("\r\n", " "));
                        length -= 1L;
                        continue;
                    }
                    if (file.Count == -1L)
                    {
                        flag = true;
                        length -= 1L;
                        continue;
                    }
                    if (file.Position != file.Length)
                    {
                        this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "上传出错";
                        this.isError = true;
                        this.AddLog("上传失败: " + this.PuttingFileName);
                        flag = true;
                        length -= 1L;
                        continue;
                    }
                    this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "文件上传成功";
                    this.AddLog("文件: " + this.PuttingFileName + " 已上传成功!");
                    this.AddLog("开始提交相关数据信息至数据库！");
                    string[] fileInfo = new string[6];
                    string[] strArray2 = this.glacialList1.Items[this.PuttingWhich].Tag.ToString().Split(new char[] { '|' });
                    fileInfo[0] = strArray2[0];
                    fileInfo[1] = strArray2[1];
                    fileInfo[2] = ePrintMain.Outputkey;
                    fileInfo[3] = this.PuttingFileName;
                    fileInfo[4] = this.FileSize[this.PuttingWhich].ToString();
                    fileInfo[5] = this.glacialList1.Items[this.PuttingWhich].SubItems[5].Text;
                    bool flag2 = false;
                    while (!flag2)
                    {
                        try
                        {
                            flag2 = this.submitData(fileInfo);
                            continue;
                        }
                        catch (Exception exception)
                        {
                            this.AddLog(exception.ToString());
                            continue;
                        }
                    }
                    if (flag2)
                    {
                        this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "完成";
                        this.AddLog("写数据库成功!");
                    }
                    else
                    {
                        this.glacialList1.Items[this.PuttingWhich].SubItems[6].Text = "写数据失败";
                        this.AddLog("写数据库失败!");
                    }
                }
                if (flag)
                {
                    this.isError = true;
                    this.AddLog("上传已中止: " + this.PuttingFileName + " 已被略过！");
                }
            }
        }

        private string sizeChange(long FileSize)
        {
            double num = Convert.ToDouble(FileSize);
            if (num < 1024.0)
            {
                return (num.ToString() + "字节");
            }
            if (num < 1048576.0)
            {
                return (Convert.ToSingle(Math.Round((double) (num / 1024.0), 2)) + "K");
            }
            return (Convert.ToSingle(Math.Round((double) (num / 1048576.0), 2)) + "M");
        }

        private bool submitData(string[] FileInfo)
        {
            ePrintOutputLogin login = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
            return login._OutputSendFileToUser(FileInfo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (AddNewUser != null)
            {
                string[] strArray = null;
                for (int i = 0; i < AddNewUser.Length; i++)
                {
                    strArray = AddNewUser[i].Split(new char[] { '|' });
                    GLItem item = new GLItem {
                        Tag = AddNewUser[i]
                    };
                    item.SubItems[0].Text = strArray[1];
                    this.glacialList1.Items.Add(item);
                }
                this.glacialList1.Refresh();
            }
            timer2.Enabled = false;
            Thread.Sleep(500);
        }

        private void viewRemark()
        {
            if ((this.glacialList1.Items.Count > 0) && (this.glacialList1.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (this.glacialList1.Items[i].Selected)
                    {
                        this.WhichItemSelected = i;
                        string[] strArray = this.glacialList1.Items[i].Tag.ToString().Split(new char[] { '|' });
                        this.label2.Text = strArray[1];
                        this.label3.Text = this.GetFilename(this.glacialList1.Items[i].SubItems[1].Text);
                        this.label2.ForeColor = this.label3.ForeColor = Color.Blue;
                        this.richTextBox2.Text = this.glacialList1.Items[i].SubItems[5].Text;
                        return;
                    }
                }
            }
        }
    }
}

