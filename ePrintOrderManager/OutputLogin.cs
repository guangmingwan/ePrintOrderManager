namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.com.print2000.output;
    using ePrintOrderManager.cn.print2000.update;
    using Microsoft.Win32;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Resources;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class OutputLogin : Form
    {
        public static string _AddHttp;
        public static string _AddPassword;
        public static string _AddUser;
        public string[] _UserInfo = new string[2];
        public static string allIP;
        private int beginNum = 3;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private IContainer components;
        public static string DownloadUrl;
        private ePrintOrderManager.ePrintLog ePrintLog;
        public static string FtpUser;
        private ImageList imageList1;
        public static int isClose = 0;
        public bool IsOk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private LinkLabel linkLabel1;
        private string loginHttp;
        private OpenFileDialog openFileDialog1;
        public static string Outputkey;
        public static string OutputName;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        public static string ServerIP;
        public static int ServerPort = 0x4e20;
        public static string SetupPath;
        private string strError = null;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Thread tdLogin = null;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ToolTip toolTip1;
        public static string UserLevel;
        private int waitTime = 0;
        public static string WebPlatEntry;
        public static string WebsUrl;
        public static int whichLogin = 0;

        public OutputLogin()
        {
            this.InitializeComponent();
            this.tabControl1.SelectedIndex = 1;
            this.ePrintLog = new ePrintOrderManager.ePrintLog();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void AlreadyRunning()
        {
            try
            {
                Process currentProcess = Process.GetCurrentProcess();
                foreach (Process process2 in Process.GetProcessesByName(currentProcess.ProcessName))
                {
                    if ((process2.Id != currentProcess.Id) && (process2.MainModule.ModuleName == currentProcess.MainModule.ModuleName))
                    {
                        MessageBox.Show("对不起，您已经登录印易平台，不允许再登录！");
                        base.Dispose();
                    }
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void beginLogin()
        {
            this.checkRegistry();
            byte[] bytes = Encoding.UTF8.GetBytes(this.textBox2.Text);
            string[] strUserInfo = new string[2];
            try
            {
                ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(WebsUrl + "/ePrintOutputLogin.asmx");
                if (login.UserLogin(this.comboBox2.Text.ToString(), bytes, Convert.ToInt16(Outputkey), out strUserInfo))
                {
                    Console.Write("\n\n安装路径" + Environment.CurrentDirectory + "\n\n");
                    this._UserInfo[0] = strUserInfo[0];
                    this._UserInfo[1] = strUserInfo[1];
                    UserLevel = strUserInfo[1];
                    this.IsOk = true;
                    _AddUser = this.comboBox2.Text.Trim().ToString();
                    _AddPassword = this.textBox2.Text.Trim();
                    string str = this.comboBox1.Text.Trim();
                    if ((this.comboBox1.Text.Trim().IndexOf("test.print2000.com.cn") >= 0) || (this.comboBox1.Text.Trim().IndexOf("alpha.print2000.cn") >= 0))
                    {
                        str = "output.print2000.com.cn";
                    }
                    else if ((this.comboBox1.Text.Trim().IndexOf("test.print2000.cn") >= 0) || (this.comboBox1.Text.Trim().IndexOf("beta.print2000.cn") >= 0))
                    {
                        str = "output.print2000.cn";
                    }
                    _AddHttp = str;
                    this.label3.Text = "登录信息：登录成功！";
                    this.ePrintLog.WriteLog("登录成功");
                }
                else
                {
                    this.IsOk = false;
                    this.label3.Text = "登录信息：登录失败！";
                    this.ePrintLog.WriteLog("登录失败");
                }
            }
            catch (Exception exception)
            {
                if (((exception.ToString().IndexOf("无法连接到远程服务器") >= 0) || (exception.ToString().IndexOf("无法解析此远程名称") >= 0)) || ((exception.ToString().IndexOf("基础连接已关闭") >= 0) || (exception.ToString().IndexOf("The underlying connection was closed") >= 0)))
                {
                    this.strError = "无法连接到远程服务器，请检查您的网络！";
                }
                else if (exception.ToString().IndexOf("操作已超时") >= 0)
                {
                    this.strError = "连接服务器超时，请检查网络或重新登录！";
                }
                else
                {
                    this.strError = exception.Message;
                }
                this.ePrintLog.WriteLog(exception.ToString());
            }
            if (this.IsOk)
            {
                base.Close();
            }
            else if (this.strError != null)
            {
                this.label3.Text = "";
                MessageBox.Show("\n会员名称或密码错误,请重新登录！\n\n附加信息:" + this.strError + "\n\n", "登录失败");
            }
            else
            {
                this.label3.Text = "";
                MessageBox.Show("\n会员名称或密码错误,请重新登录！\n\n", "登录失败");
            }
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
            this.textBox2.Enabled = true;
            this.checkBox1.Enabled = true;
            this.checkBox2.Enabled = true;
            this.tdLogin = null;
            this.waitTime = 0;
            this.beginNum = 3;
            this.button2.Text = "退出";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ePrintLog.WriteLog("尝试手动登录...[" + this.comboBox1.Text + "][" + this.comboBox2.Text + "]");
            this.LoginCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.Text == "退出")
            {
                Application.Exit();
            }
            this.label3.Text = "";
            this.label3.ForeColor = Color.Black;
            this.label3.Font = new Font("宋体", 9f);
            try
            {
                this.timer2.Enabled = false;
                this.button1.Text = "登录";
                this.waitTime = 0;
                if (this.tdLogin != null)
                {
                    this.tdLogin.Abort();
                    this.label6.Visible = false;
                    this.label7.Visible = false;
                    this.label3.Text = "";
                    this.button1.Enabled = true;
                    this.comboBox1.Enabled = true;
                    this.comboBox2.Enabled = true;
                    this.textBox2.Enabled = true;
                    this.checkBox1.Enabled = true;
                    this.checkBox2.Enabled = true;
                    this.tdLogin = null;
                    this.waitTime = 0;
                    this.beginNum = 3;
                    this.button2.Text = "退出";
                    this.ePrintLog.WriteLog("取消登录");
                }
                else if (!this.button1.Enabled)
                {
                    this.label6.Visible = false;
                    this.label7.Visible = false;
                    this.label3.Text = "";
                    this.button1.Enabled = true;
                    this.comboBox1.Enabled = true;
                    this.comboBox2.Enabled = true;
                    this.textBox2.Enabled = true;
                    this.checkBox1.Enabled = true;
                    this.checkBox2.Enabled = true;
                    this.tdLogin = null;
                    this.waitTime = 0;
                    this.beginNum = 3;
                    this.button2.Text = "退出";
                    this.ePrintLog.WriteLog("取消登录");
                }
                else
                {
                    this.ePrintLog.WriteLog("退出程序");
                    Application.Exit();
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ePrintUpdate().ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                new ePrintUnzip { zipFilePath = this.openFileDialog1.FileName }.Unzip();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.checkBox1.Checked)
            {
                this.checkBox2.Checked = false;
                this.checkBox2.Enabled = false;
            }
            else
            {
                this.checkBox2.Enabled = true;
            }
        }

        private void CheckHttp()
        {
            try
            {
                string[] strArray = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin("http://output.print2000.com.cn/ePrintServer_dynamic/ePrintOutputLogin.asmx") { Timeout = 0x7530 }._BeginInfo(this.comboBox1.Text.Trim());
                if (strArray[0] != "")
                {
                    ePrintMain.Outputkey = Outputkey = strArray[0];
                    ServerIP = strArray[1];
                    ServerPort = Convert.ToInt16(strArray[2]);
                    OutputName = strArray[3];
                    WebsUrl = strArray[4];
                    DownloadUrl = strArray[5];
                    FtpUser = strArray[6];
                    WebPlatEntry = strArray[7];
                    this.beginLogin();
                }
                else
                {
                    this.label3.Text = "";
                    this.button1.Enabled = true;
                    this.button2.Enabled = true;
                    this.comboBox1.Enabled = true;
                    this.comboBox2.Enabled = true;
                    this.textBox2.Enabled = true;
                    this.checkBox1.Enabled = true;
                    this.checkBox2.Enabled = true;
                    this.tdLogin = null;
                    this.waitTime = 0;
                    this.beginNum = 3;
                    this.button2.Text = "退出";
                    MessageBox.Show("您输入的网址有误,请重新输入!");
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
                this.label3.Text = "";
                this.button1.Enabled = true;
                this.button2.Enabled = true;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = true;
                this.textBox2.Enabled = true;
                this.checkBox1.Enabled = true;
                this.checkBox2.Enabled = true;
                this.tdLogin = null;
                this.waitTime = 0;
                this.beginNum = 3;
                this.button2.Text = "退出";
            }
        }

        private void checkRegistry()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("Software", true);
                RegistryKey key2 = rk.OpenSubKey("ePrint", true);
                if (key2 != null)
                {
                    RegistryKey key3 = key2.OpenSubKey("OutputManager", true);
                    if (key3 != null)
                    {
                        this.SetLoginInfo(key3);
                    }
                    else
                    {
                        key2 = key2.CreateSubKey("OutputManager");
                        key2.SetValue("OrderInfoSize", "9");
                        key2.SetValue("OrderInfoItemheight", "17");
                        this.SetLoginInfo(key2);
                    }
                    RegistryKey key4 = key2.OpenSubKey("LoginUriList", true);
                    if (key4 != null)
                    {
                        this.SetLoginUriList(key4);
                    }
                    else
                    {
                        key4 = key2.CreateSubKey("LoginUriList");
                        this.SetLoginUriList(key4);
                    }
                    RegistryKey key5 = key2.OpenSubKey("LoginUserList", true);
                    if (key5 != null)
                    {
                        this.SetLoginUserList(key5);
                    }
                    else
                    {
                        key5 = key2.CreateSubKey("LoginUserList");
                        this.SetLoginUserList(key5);
                    }
                }
                else
                {
                    rk = rk.CreateSubKey("ePrint").CreateSubKey("OutputManager");
                    this.SetLoginInfo(rk);
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private bool CheckVersion()
        {
            bool flag = false;
            try
            {
                this.ePrintLog.WriteLog("检查新版本,本地版本为:" + ePrintMain.SoftVersion);
                string[] strArray = new ePrintOrderManager.cn.print2000.update.ePrintOutputLogin("http://output.print2000.com.cn/ePrintServer_dynamic/ePrintOutputLogin.asmx") { Timeout = 0x493e0 }._UpdateInfo();
                this.ePrintLog.WriteLog("检查新版本,远程版本为:" + strArray[0]);
                int num = Convert.ToInt32(ePrintMain.SoftVersion.Replace(".", ""));
                int num2 = Convert.ToInt32(strArray[0].Replace(".", ""));
                if ((strArray[0] == null) || (num2 <= num))
                {
                    return flag;
                }
                flag = true;
                this.registerVersion(strArray[0]);
                if (MessageBox.Show("发现印易新版本 " + strArray[0] + "，是否升级？\n\n【升级原因:】\n" + strArray[1], "版本升级", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    try
                    {
                        this.ePrintLog.WriteLog("开始升级");
                        new ePrintUpdate().ShowDialog();
                    }
                    catch (Exception exception)
                    {
                        this.ePrintLog.WriteLog("升级错误:" + exception.ToString());
                        MessageBox.Show(exception.ToString());
                    }
                    return flag;
                }
                flag = false;
                this.ePrintLog.WriteLog("取消升级");
            }
            catch (Exception exception2)
            {
                this.ePrintLog.WriteLog(exception2.ToString());
            }
            return flag;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            this.ViewButton1();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            this.ViewButton1();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private string ePrintSecurity(string strData)
        {
            string str = null;
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(strData);
                int length = bytes.Length;
                foreach (byte num2 in bytes)
                {
                    int num3 = Convert.ToInt16(num2) + length--;
                    str = str + ((num3 - 2)).ToString() + " ";
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
            return str;
        }

        private string ePrintSecurity2(string strData)
        {
            string str = null;
            try
            {
                string[] strArray = strData.Trim().Split(new char[] { ' ' });
                int length = strArray.Length;
                int num2 = strArray.Length;
                byte[] bytes = new byte[strArray.Length];
                foreach (string str2 in strArray)
                {
                    int num3 = Convert.ToInt16(str2) + 2;
                    num3 -= length;
                    bytes[num2 - length] = Convert.ToByte(num3);
                    length--;
                }
                str = Encoding.UTF8.GetString(bytes);
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
            return str;
        }

        private void getLoginUri()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\LoginUriList", true);
                if (key != null)
                {
                    foreach (string str in key.GetValueNames())
                    {
                        this.comboBox1.Items.Add(key.GetValue(str));
                    }
                }
            }
            catch
            {
            }
        }

        private void getLoginUser()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\LoginUserList", true);
                if (key != null)
                {
                    foreach (string str in key.GetValueNames())
                    {
                        this.comboBox2.Items.Add(key.GetValue(str));
                    }
                }
            }
            catch
            {
            }
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ResourceManager manager = new ResourceManager(typeof(OutputLogin));
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.label3 = new Label();
            this.button3 = new Button();
            this.panel1 = new Panel();
            this.pictureBox2 = new PictureBox();
            this.label5 = new Label();
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.label8 = new Label();
            this.pictureBox1 = new PictureBox();
            this.tabPage2 = new TabPage();
            this.label7 = new Label();
            this.comboBox2 = new ComboBox();
            this.label6 = new Label();
            this.imageList1 = new ImageList(this.components);
            this.comboBox1 = new ComboBox();
            this.checkBox2 = new CheckBox();
            this.textBox3 = new TextBox();
            this.label4 = new Label();
            this.linkLabel1 = new LinkLabel();
            this.checkBox1 = new CheckBox();
            this.tabPage3 = new TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new ToolTip(this.components);
            this.openFileDialog1 = new OpenFileDialog();
            this.richTextBox1 = new RichTextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            base.SuspendLayout();
            this.textBox1.ForeColor = SystemColors.WindowText;
            this.textBox1.Location = new Point(0x88, 120);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0xe0, 0x15);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            this.textBox2.Location = new Point(0x68, 0x58);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new Size(0xe0, 0x15);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "";
            this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
            this.label1.Location = new Point(40, 0x40);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x48, 0x17);
            this.label1.TabIndex = 2;
            this.label1.Text = "会员帐号：";
            this.label2.Location = new Point(40, 0x60);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x48, 0x17);
            this.label2.TabIndex = 3;
            this.label2.Text = "会员密码：";
            this.button1.BackColor = SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.Location = new Point(0xf8, 0x15d);
            this.button1.Name = "button1";
            this.button1.TabIndex = 4;
            this.button1.Text = "登录";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.BackColor = SystemColors.Control;
            this.button2.Location = new Point(0x148, 0x15d);
            this.button2.Name = "button2";
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.label3.Location = new Point(0x80, 0xb0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(200, 0x17);
            this.label3.TabIndex = 6;
            this.button3.Location = new Point(0x130, 0x90);
            this.button3.Name = "button3";
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.Visible = false;
            this.button3.Click += new EventHandler(this.button3_Click_1);
            this.panel1.BackColor = SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x198, 0x30);
            this.panel1.TabIndex = 8;
            this.pictureBox2.BackColor = SystemColors.Window;
            this.pictureBox2.Image = (Image) manager.GetObject("pictureBox2.Image");
            this.pictureBox2.Location = new Point(320, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0x68, 0x2e);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.label5.Font = new Font("宋体", 12f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label5.Location = new Point(0x18, 0x10);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0xc0, 0x18);
            this.label5.TabIndex = 1;
            this.label5.Text = "印易在线服务平台";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new Point(4, 0x38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(400, 0x120);
            this.tabControl1.TabIndex = 9;
            this.tabPage1.BackColor = SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new Point(4, 0x15);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new Size(0x188, 0x107);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = ".关于印易平台";
            this.label8.Font = new Font("宋体", 26f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label8.Location = new Point(0xa8, 80);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x68, 0x40);
            this.label8.TabIndex = 2;
            this.label8.Text = "印易";
            this.pictureBox1.Image = (Image) manager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(120, 0x40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x40, 0x38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.tabPage2.BackColor = SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new Point(4, 0x15);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new Size(0x188, 0x107);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = ".登录印易在线服务平台";
            this.label7.Location = new Point(0x70, 0xb0);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x40, 0x17);
            this.label7.TabIndex = 15;
            this.label7.Text = "登录延时";
            this.label7.Visible = false;
            this.comboBox2.Location = new Point(0x68, 0x38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(0xe0, 20);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.TextChanged += new EventHandler(this.comboBox2_TextChanged);
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new Point(0x98, 160);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x58, 40);
            this.label6.TabIndex = 13;
            this.label6.Visible = false;
            this.imageList1.ColorDepth = ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new Size(0x20, 0x20);
            this.imageList1.ImageStream = (ImageListStreamer) manager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.comboBox1.BackColor = Color.LightSteelBlue;
            this.comboBox1.Location = new Point(0x68, 0x18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(0xe0, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new EventHandler(this.comboBox1_TextChanged);
            this.checkBox2.Location = new Point(0x18, 0x90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "下次自动登录";
            this.textBox3.BackColor = Color.LightSteelBlue;
            this.textBox3.Location = new Point(0x68, 120);
            this.textBox3.MaxLength = 30;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(0xe0, 0x15);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "";
            this.textBox3.Visible = false;
            this.label4.Location = new Point(0x10, 0x20);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x60, 0x18);
            this.label4.TabIndex = 10;
            this.label4.Text = "输出中心网址：";
            this.linkLabel1.Location = new Point(0x10, 0xe0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new Size(0x128, 0x17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "进入首页供求热线(http://www.print2000.cn)";
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.checkBox1.Location = new Point(0x18, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "记住密码";
            this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
            this.tabPage3.BackColor = SystemColors.ControlLight;
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new Point(4, 0x15);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new Size(0x188, 0x107);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = ".关于中国印网";
            this.timer1.Enabled = true;
            this.timer1.Interval = 0x3e8;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.timer2.Interval = 0x3e8;
            this.timer2.Tick += new EventHandler(this.timer2_Tick);
            this.richTextBox1.BackColor = SystemColors.ControlLight;
            this.richTextBox1.BorderStyle = BorderStyle.None;
            this.richTextBox1.ForeColor = SystemColors.HotTrack;
            this.richTextBox1.Location = new Point(8, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(0x178, 0xf8);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "    广州印网科技有限公司成立于网络界风云跌宕的1997年，成立之初，即将其定位在印刷行业软件及网络应用上。同年便推出了国内首家印刷行业网站www.print2000.cn。经过8年的不 断成长，印网科技的软件已经在行业内开花结果，拥有近千家长期客户，网站也在不断的为广大客户提供政策法规、软硬件行情、二手交易、行业信息、印刷竞价等各方面资讯，深受读者信赖。";
            this.richTextBox1.LinkClicked += new LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            base.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x198, 0x187);
            base.Controls.Add(this.tabControl1);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "OutputLogin";
            base.SizeGripStyle = SizeGripStyle.Hide;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "印易登录";
            base.KeyDown += new KeyEventHandler(this.UserLogin2);
            base.Load += new EventHandler(this.OutputLogin_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://www.print2000.cn");
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void LoginCheck()
        {
            try
            {
                if (this.comboBox1.Text.Trim() == "")
                {
                    MessageBox.Show("\n   请输入输出中心网址!   \n\n");
                }
                else if (((this.comboBox1.Text.Trim().IndexOf(".com") < 0) && (this.comboBox1.Text.Trim().IndexOf(".cn") < 0)) && (this.comboBox1.Text.Trim().IndexOf(".net") < 0))
                {
                    MessageBox.Show("\n   请输入正确的网址!   \n\n");
                }
                else if ((this.comboBox2.Text.Trim().ToString() == "") || (this.textBox2.Text.Trim().ToString() == ""))
                {
                    MessageBox.Show("\n 会员帐号或会员密码不能为空! \n\n");
                }
                else if ((this.comboBox2.Text.Trim().Length < 3) || (this.textBox2.Text.Trim().Length < 3))
                {
                    MessageBox.Show("\n会员帐号和会员密码长度不能小于3!\n\n");
                }
                else
                {
                    this.loginHttp = this.comboBox1.Text.Trim();
                    if ((this.comboBox1.Text.Trim().IndexOf("test.print2000.com.cn") >= 0) || (this.comboBox1.Text.Trim().IndexOf("alpha.print2000.cn") >= 0))
                    {
                        this.loginHttp = "output.print2000.com.cn";
                    }
                    else if ((this.comboBox1.Text.Trim().IndexOf("test.print2000.cn") >= 0) || (this.comboBox1.Text.Trim().IndexOf("beta.print2000.cn") >= 0))
                    {
                        this.loginHttp = "output.print2000.cn";
                    }
                    this.button1.Enabled = false;
                    this.comboBox1.Enabled = false;
                    this.comboBox2.Enabled = false;
                    this.textBox2.Enabled = false;
                    this.checkBox1.Enabled = false;
                    this.checkBox2.Enabled = false;
                    this.button2.Text = "取消登录";
                    this.tdLogin = new Thread(new ThreadStart(this.CheckHttp));
                    this.tdLogin.Start();
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void OutoLogin()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
                if (key != null)
                {
                    string str = "";
                    string strData = "";
                    string str3 = "";
                    string str4 = "";
                    if (key.GetValue("OutputHttp") != null)
                    {
                        str = (string) key.GetValue("OutputHttp");
                    }
                    if (key.GetValue("LoginUserName") != null)
                    {
                        strData = (string) key.GetValue("LoginUserName");
                    }
                    if (key.GetValue("LoginPassword") != null)
                    {
                        str3 = (string) key.GetValue("LoginPassword");
                    }
                    if (key.GetValue("isAutoLogin") != null)
                    {
                        str4 = (string) key.GetValue("isAutoLogin");
                    }
                    if (str != "")
                    {
                        this.comboBox1.SelectedText = str;
                    }
                    if (strData != "")
                    {
                        this.comboBox2.SelectedText = this.ePrintSecurity2(strData);
                    }
                    if ((strData != "") && (str3 != ""))
                    {
                        strData = this.ePrintSecurity2(strData);
                        str3 = this.ePrintSecurity2(str3);
                        if ((strData != "") && (str3 != ""))
                        {
                            this.textBox2.Text = str3;
                            this.checkBox1.Checked = true;
                            this.checkBox2.Enabled = true;
                            if (this.comboBox1.Text.Trim() == "")
                            {
                                MessageBox.Show("\n   请输入输出中心网址!   \n\n");
                            }
                            else if (str4 == "1")
                            {
                                this.checkBox2.Checked = true;
                                this.loginHttp = this.comboBox1.Text.Trim();
                                if ((this.comboBox1.Text.Trim().IndexOf("test.print2000.com.cn") >= 0) || (this.comboBox1.Text.Trim().IndexOf("alpha.print2000.cn") >= 0))
                                {
                                    this.loginHttp = "output.print2000.com.cn";
                                }
                                else if ((this.comboBox1.Text.Trim().IndexOf("test.print2000.cn") >= 0) || (this.comboBox1.Text.Trim().IndexOf("beta.print2000.cn") >= 0))
                                {
                                    this.loginHttp = "output.print2000.cn";
                                }
                                this.ePrintLog.WriteLog("尝试自动登录...[" + this.comboBox1.Text + "][" + this.comboBox2.Text + "]");
                                this.button1.Enabled = false;
                                this.comboBox1.Enabled = false;
                                this.comboBox2.Enabled = false;
                                this.textBox2.Enabled = false;
                                this.checkBox1.Enabled = false;
                                this.checkBox2.Enabled = false;
                                this.button2.Text = "取消登录";
                                this.timer2.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
            if (!this.checkBox1.Checked)
            {
                this.checkBox2.Enabled = false;
            }
        }

        private void OutputLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.CheckVersion())
                {
                    try
                    {
                        this.getLoginUri();
                        this.getLoginUser();
                        this.comboBox2.Focus();
                        SetupPath = Environment.CurrentDirectory;
                        this.OutoLogin();
                    }
                    catch (Exception exception)
                    {
                        this.ePrintLog.WriteLog("升级错误:" + exception.ToString());
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
            catch (Exception exception2)
            {
                this.ePrintLog.WriteLog(exception2.ToString());
            }
        }

        private void registerVersion(string NewVersion)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
                RegistryKey key2 = key.OpenSubKey("ePrint", true);
                if (key2 != null)
                {
                    RegistryKey key3 = key2.OpenSubKey("OutputManager", true);
                    if (key3 != null)
                    {
                        key3.SetValue("NewVersion", NewVersion);
                    }
                    else
                    {
                        key2.CreateSubKey("OutputManager").SetValue("NewVersion", NewVersion);
                    }
                }
                else
                {
                    key.CreateSubKey("ePrint").CreateSubKey("OutputManager").SetValue("NewVersion", NewVersion);
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void SetLoginInfo(RegistryKey rk)
        {
            try
            {
                string str = this.comboBox1.Text.Trim();
                string str2 = this.ePrintSecurity(this.comboBox2.Text.Trim());
                string str3 = this.ePrintSecurity(this.textBox2.Text.Trim());
                if (this.checkBox1.Checked)
                {
                    rk.SetValue("OutputHttp", str);
                    rk.SetValue("LoginUserName", str2);
                    rk.SetValue("LoginPassword", str3);
                    rk.SetValue("SetupPath", SetupPath);
                }
                else
                {
                    rk.SetValue("OutputHttp", str);
                    rk.SetValue("LoginUserName", str2);
                    rk.SetValue("LoginPassword", "");
                    rk.SetValue("SetupPath", SetupPath);
                    rk.SetValue("isAutoLogin", "0");
                }
                if (this.checkBox2.Checked)
                {
                    rk.SetValue("isAutoLogin", "1");
                }
                else
                {
                    rk.SetValue("isAutoLogin", "0");
                }
                if (rk.GetValue("DownLoadedList") == null)
                {
                    rk.SetValue("DownLoadedList", "0|0");
                }
                if (rk.GetValue("DeletedList") == null)
                {
                    rk.SetValue("DeletedList", "0|0");
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void SetLoginUriList(RegistryKey rk)
        {
            try
            {
                string str = this.comboBox1.Text.Trim();
                string[] valueNames = rk.GetValueNames();
                int num = 0;
                num = valueNames.Length + 1;
                bool flag = true;
                for (int i = 0; i < valueNames.Length; i++)
                {
                    if (str == ((string) rk.GetValue(valueNames[i])))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    rk.SetValue("LoginUri" + num, str);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void SetLoginUserList(RegistryKey rk)
        {
            try
            {
                string str = this.comboBox2.Text.Trim();
                string[] valueNames = rk.GetValueNames();
                int num = 0;
                num = valueNames.Length + 1;
                bool flag = true;
                for (int i = 0; i < valueNames.Length; i++)
                {
                    if (str == ((string) rk.GetValue(valueNames[i])))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    while (rk.GetValue("LoginUser" + num) != null)
                    {
                        num++;
                    }
                    rk.SetValue("LoginUser" + num, str);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.ViewButton1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.ViewButton1();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isClose > 0)
            {
                base.Dispose();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.beginNum != 0)
            {
                this.label6.ImageIndex = this.beginNum - 1;
                this.label6.Visible = true;
                this.label7.Visible = true;
            }
            else
            {
                this.label6.Visible = false;
                this.label7.Visible = false;
                this.label3.ForeColor = Color.Black;
                this.label3.Font = new Font("宋体", 9f);
                this.label3.Text = "登录中,请稍候......";
            }
            this.waitTime++;
            this.beginNum--;
            if (this.waitTime > 3)
            {
                this.timer2.Enabled = false;
                this.button1.Text = "登录";
                this.tdLogin = new Thread(new ThreadStart(this.CheckHttp));
                this.tdLogin.Start();
            }
        }

        private void UserLogin2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LoginCheck();
            }
        }

        private void ViewButton1()
        {
            if (((this.comboBox1.Text.Trim() != "") && (this.comboBox2.Text.Trim() != "")) && (this.textBox2.Text.Trim() != ""))
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }
    }
}

