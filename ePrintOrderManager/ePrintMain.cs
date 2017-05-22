namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.com.print2000.output;
    using ePrintOrderManager.cn.print2000.update;
    using GlacialComponents.Controls;
    using GlacialComponents.Controls.Common;
    using Microsoft.Win32;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Resources;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class ePrintMain : Form
    {
        private string[] __OrderInfoFont1;
        private string[] __OrderInfoFont2;
        private string[] __OrderInfoForeColor1;
        private string[] __OrderInfoForeColor2;
        private ePrintOrderManager.ePrintWebHome _ePrintWebHome = null;
        private GLItem _lastItem = null;
        private GlacialList _lastList = null;
        private string _OrderInfoFont1 = null;
        private string _OrderInfoFont2 = null;
        private string _OrderInfoForeColor1 = null;
        private string _OrderInfoForeColor2 = null;
        private string _OrderInfoItemheight = null;
        private string _ReceiveInfo = "";
        private SendFileToUser _sendFile = null;
        public static int ActionWhich = -1;
        private double AllSize = 0.0;
        private Button button1;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button2;
        private Button button20;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Socket ClientSocket = null;
        private int closetime = 0;
        private ColorDialog colorDialog1;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private ColumnHeader columnHeader34;
        private ColumnHeader columnHeader35;
        private ColumnHeader columnHeader36;
        private ColumnHeader columnHeader37;
        private ColumnHeader columnHeader38;
        private ColumnHeader columnHeader39;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader40;
        private ColumnHeader columnHeader41;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private IContainer components;
        private ContextMenu contextMenu1;
        private ContextMenu contextMenu10;
        private ContextMenu contextMenu2;
        private ContextMenu contextMenu3;
        private ContextMenu contextMenu4;
        private ContextMenu contextMenu5;
        private ContextMenu contextMenu6;
        private ContextMenu contextMenu7;
        private ContextMenu contextMenu8;
        private ContextMenu contextMenu9;
        private ePrintOrderManager.ePrintLog ePrintLog;
        public static bool ePrintWebHome = false;
        private int errorTime = 0;
        public ArrayList FileInfoList;
        public static string FileSavePath = null;
        private FontDialog fontDialog1;
        private GlacialList glacialList1;
        private GlacialList glacialList2;
        private GlacialList glacialList3;
        private GlacialList glacialList4;
        private GlacialList glacialList5;
        private GlacialList glacialList6;
        private GlacialList glacialList7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        public Hashtable HtrecInfo;
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList imageList3;
        private ImageList imageList4;
        private ImageList imageList5;
        private ImageList imageList6;
        private ImageList imageList7;
        private ImageList imageList8;
        public static int isAutoDown = 0;
        public static int isClose = 0;
        private bool isDelServer = false;
        private bool isHide = false;
        public static bool isLock = false;
        private int isLoginSuccess = 0;
        private bool isMutliSystem = false;
        public static bool isShow = false;
        public static bool isShowLogView = false;
        private int isStop = 0;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GlacialList listView1;
        private ListView listView2;
        private ListView listView3;
        private ListView listView4;
        private ListView listView5;
        private ListView listView6;
        private ListView listView7;
        private ListView listView8;
        public static string[] LogFileName;
        private MainMenu mainMenu1;
        private int MaxDownNum = 5;
        private MenuItem menuItem1;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
        private MenuItem menuItem12;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
        private MenuItem menuItem15;
        private MenuItem menuItem16;
        private MenuItem menuItem17;
        private MenuItem menuItem18;
        private MenuItem menuItem19;
        private MenuItem menuItem2;
        private MenuItem menuItem20;
        private MenuItem menuItem21;
        private MenuItem menuItem22;
        private MenuItem menuItem23;
        private MenuItem menuItem24;
        private MenuItem menuItem25;
        private MenuItem menuItem26;
        private MenuItem menuItem27;
        private MenuItem menuItem28;
        private MenuItem menuItem29;
        private MenuItem menuItem3;
        private MenuItem menuItem30;
        private MenuItem menuItem31;
        private MenuItem menuItem32;
        private MenuItem menuItem33;
        private MenuItem menuItem34;
        private MenuItem menuItem35;
        private MenuItem menuItem36;
        private MenuItem menuItem37;
        private MenuItem menuItem38;
        private MenuItem menuItem39;
        private MenuItem menuItem4;
        private MenuItem menuItem40;
        private MenuItem menuItem41;
        private MenuItem menuItem42;
        private MenuItem menuItem43;
        private MenuItem menuItem44;
        private MenuItem menuItem45;
        private MenuItem menuItem46;
        private MenuItem menuItem47;
        private MenuItem menuItem48;
        private MenuItem menuItem49;
        private MenuItem menuItem5;
        private MenuItem menuItem50;
        private MenuItem menuItem51;
        private MenuItem menuItem52;
        private MenuItem menuItem53;
        private MenuItem menuItem54;
        private MenuItem menuItem55;
        private MenuItem menuItem56;
        private MenuItem menuItem57;
        private MenuItem menuItem58;
        private MenuItem menuItem59;
        private MenuItem menuItem6;
        private MenuItem menuItem60;
        private MenuItem menuItem61;
        private MenuItem menuItem62;
        private MenuItem menuItem63;
        private MenuItem menuItem64;
        private MenuItem menuItem65;
        private MenuItem menuItem66;
        private MenuItem menuItem67;
        private MenuItem menuItem68;
        private MenuItem menuItem69;
        private MenuItem menuItem7;
        private MenuItem menuItem70;
        private MenuItem menuItem71;
        private MenuItem menuItem72;
        private MenuItem menuItem73;
        private MenuItem menuItem74;
        private MenuItem menuItem75;
        private MenuItem menuItem76;
        private MenuItem menuItem77;
        private MenuItem menuItem78;
        private MenuItem menuItem79;
        private MenuItem menuItem8;
        private MenuItem menuItem80;
        private MenuItem menuItem81;
        private MenuItem menuItem82;
        private MenuItem menuItem83;
        private MenuItem menuItem84;
        private MenuItem menuItem85;
        private MenuItem menuItem9;
        private string NewVersion;
        private NotifyIcon notifyIcon1;
        private NumericUpDown numericUpDown1;
        public static string Outputkey = null;
        private Panel panel1;
        private Panel panel10;
        private Panel panel11;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel2;
        private Panel panel22;
        private Panel panel43;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Panel Pnldock;
        private Panel PnlFunc1;
        private Panel PnlFunc2;
        private Panel PnlFunc3;
        private Panel PnlFunc4;
        private Panel PnlFunc5;
        private Panel PnlFunc6;
        private int[] pointX = new int[0x9c];
        private int[] pointY = new int[0x9c];
        private long PreKey;
        public static string[] PubCompanyName;
        public static string[] PubUserInfo;
        private byte[] ReceiveBuffer = new byte[100];
        private string ReceiveInfo = "";
        private string returnInfo = null;
        private long RunTime = 0L;
        private SaveFileDialog saveFileDialog1;
        private SaveFileDialog saveFileDialog2;
        public static int SaveFileType = 0;
        public static bool SendFileIsOpen = false;
        public static string SetupPath;
        private const int SND_ASYNC = 1;
        private const int SND_MEMORY = 4;
        private string SocketKey;
        public static string SoftVersion = "3.3.9.10";
        private Splitter splitter1;
        private Splitter splitter2;
        private Splitter splitter3;
        private Splitter splitter4;
        private Splitter splitter5;
        private int StartPoint = 0x9c;
        private StatusBar statusBar1;
        private StatusBar statusBar2;
        private StatusBar statusBar3;
        private StatusBarPanel statusBarPanel1;
        private StatusBarPanel statusBarPanel10;
        private StatusBarPanel statusBarPanel2;
        private StatusBarPanel statusBarPanel3;
        private StatusBarPanel statusBarPanel4;
        private StatusBarPanel statusBarPanel5;
        private StatusBarPanel statusBarPanel6;
        private StatusBarPanel statusBarPanel7;
        private StatusBarPanel statusBarPanel8;
        private StatusBarPanel statusBarPanel9;
        public static string strCon = null;
        private Point t;
        private TabControl tabControl1;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Thread[] td = new Thread[5];
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private System.Windows.Forms.Timer timer_ToolTip = null;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ToolBar toolBar1;
        private ToolBar toolBar2;
        private ToolBarButton toolBarButton1;
        private ToolBarButton toolBarButton10;
        private ToolBarButton toolBarButton11;
        private ToolBarButton toolBarButton12;
        private ToolBarButton toolBarButton13;
        private ToolBarButton toolBarButton14;
        private ToolBarButton toolBarButton16;
        private ToolBarButton toolBarButton17;
        private ToolBarButton toolBarButton18;
        private ToolBarButton toolBarButton2;
        private ToolBarButton toolBarButton3;
        private ToolBarButton toolBarButton4;
        private ToolBarButton toolBarButton5;
        private ToolBarButton toolBarButton6;
        private ToolBarButton toolBarButton7;
        private ToolBarButton toolBarButton8;
        private ToolBarButton toolBarButton9;
        private ToolTip toolTip_Element;
        private TabPage tp3;
        private TreeView treeView1;
        private TreeView treeView2;
        private long UsedSize = 0L;
        private long UserFileSize = 0L;
        public static long[] viewdownedSize = new long[5];
        private ViewLogFile vlf = null;
        private int waitKey = 0;
        private int whichlistView = 0;

        public ePrintMain()
        {
            this.InitializeComponent();
            this.timer_ToolTip = new System.Windows.Forms.Timer();
            this.timer_ToolTip.Interval = 100;
            strCon = "Provider=Microsoft.Jet.OleDb.4.0;Data Source='" + OutputLogin.SetupPath + @"\ePrint'";
            OleDbConnection connection = new OleDbConnection(strCon);
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception e)
            {
                strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + OutputLogin.SetupPath + @"\ePrint'";
                //strCon = "Driver ={ Microsoft Access Driver(*.mdb, *.accdb)}; DBQ ='" + OutputLogin.SetupPath + @"\ePrint'";
                connection = new OleDbConnection(strCon);
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch (Exception e1)
                {

                    MessageBox.Show("系统没有安装Microsoft.Jet.OleDb.4.0|Microsoft.ACE.OLEDB.12.0驱动。");
                    //Application.Exit();
                    this.Close();
                    return;
                }
            }
    
            
            this.Text = "印易在线服务平台";
            this.statusBarPanel1.Text = OutputLogin.OutputName;
            this.ePrintLog = new ePrintOrderManager.ePrintLog();
            this.HtrecInfo = new Hashtable();
        }

        private void _getOutputNetInfo()
        {
            string str = new GetOutputNetInfo().NetInfo();
            string[] strInfo = new string[] { str, OutputLogin._AddUser, Outputkey, OutputLogin.OutputName };
            new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin("http://output.print2000.com.cn/ePrintServer_dynamic/ePrintOutputLogin.asmx")._InsertNetInfo(strInfo);
        }

        public void addInfo(int type, _fileinfo __myfileinfo, int which, string strInfo)
        {
            string[] strArray=null;
            IntPtr ptr= (IntPtr)0;
            string str = "";
            GLItem item = new GLItem();
            if (type == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    //str = strArray[(int) ptr];
                    (strArray = __myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) i)] = str + "stop," + DateTime.Now.ToString() + "," + strInfo + __myfileinfo.BlockDownloadSize_Abs[i].ToString() + "|｜";
                }
                item.SubItems[0].ImageIndex = 3;
                item.BackColor = Color.Pink;
                item.ForeColor = Color.DarkRed;
                strInfo = strInfo + __myfileinfo.BlockDownloadSize_Abs[ActionWhich].ToString();
                item.SubItems[0].Text = DateTime.Now.ToString();
                item.SubItems.Add(strInfo);
                this.listView1.Items.Add(item);
                this.listView1.Refresh();
            }
            if (type == 2)
            {
                //str = strArray[(int) ptr];
                (strArray = __myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) which)] = str + "ok," + DateTime.Now.ToString() + "," + strInfo + "|｜";
                if (ActionWhich == which)
                {
                    item.SubItems[0].ImageIndex = 2;
                    item.BackColor = Color.PaleGreen;
                    item.ForeColor = Color.ForestGreen;
                    item.SubItems[0].Text = DateTime.Now.ToString();
                    item.SubItems.Add(strInfo);
                    this.listView1.Items.Add(item);
                    this.listView1.Refresh();
                }
            }
            if (type == 3)
            {
                //str = strArray[(int) ptr];
                (strArray = __myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) which)] = str + "stop," + DateTime.Now.ToString() + "," + strInfo + "|｜";
                if (ActionWhich == which)
                {
                    item.SubItems[0].ImageIndex = 3;
                    item.BackColor = Color.Pink;
                    item.ForeColor = Color.DarkRed;
                    item.SubItems[0].Text = DateTime.Now.ToString();
                    item.SubItems.Add(strInfo);
                    this.listView1.Items.Add(item);
                    this.listView1.Refresh();
                }
            }
        }

        private GLItem addList(GlacialList myList, _fileinfo __myfileinfo, string[] listInfo)
        {
            GLItem item = new GLItem();
            item.SubItems[0].ImageIndex = 0;
            for (int i = 0; i < (listInfo.Length - 1); i++)
            {
                item.SubItems[i + 1].Text = listInfo[i];
            }
            myprogress myprogress = new myprogress {
                Tag = __myfileinfo
            };
            item.SubItems[5].Control = myprogress;
            item.Tag = __myfileinfo;
            myList.Items.Add(item);
            return item;
        }

        private void allStop()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (((this.glacialList1.Items[i].SubItems[0].ImageIndex == 4) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 0)) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 10))
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        try
                        {
                            this.glacialList1.Items[i].SubItems[9].Text = "0/1";
                            this.glacialList1.Items[i].SubItems[0].ImageIndex = 1;
                            tag.ns2.Close();
                            tag.fs2.Close();
                        }
                        catch
                        {
                        }
                    }
                    else if (this.glacialList1.Items[i].SubItems[0].ImageIndex == 15)
                    {
                        this.glacialList1.Items[i].SubItems[0].ImageIndex = 1;
                    }
                }
            }
        }

        private void backupLog()
        {
        }

        public void beginDown(long lStartPos, long lEndPos, int which, string FileSaveSet, string FileName, string FilePath, _fileinfo __myfileinfo)
        {
            if (which != 7)
            {
                ePrintDown down = new ePrintDown {
                    lStartPos = lStartPos,
                    lEndPos = lEndPos,
                    which = which,
                    FileSaveSet = FileSaveSet,
                    FileName = FileName,
                    StrDownPath = FilePath,
                    myfileinfo = __myfileinfo
                };
                OleDbConnection connection = new OleDbConnection(strCon);
                connection.Open();
                OleDbCommand command = new OleDbCommand(string.Concat(new object[] { "select ID from DownLoading2 where ID2=", __myfileinfo.orderkey, " and Which=", which }), connection);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    reader.Close();
                    new OleDbCommand(string.Concat(new object[] { "insert into DownLoading2(ID2,StartSize,EndSize,Which) values (", __myfileinfo.orderkey, ",", lStartPos, ",", lEndPos, ",", which, ")" }), connection).ExecuteNonQuery();
                }
                else
                {
                    reader.Close();
                }
                reader.Close();
                connection.Close();
                this.td[which] = new Thread(new ThreadStart(down.down));
                this.td[which].Name = "线程 ePrintDown._beginDown.down: " + which.ToString();
                this.td[which].Start();
                __myfileinfo.time = 0;
            }
            else
            {
                ePrintDown2 down2 = new ePrintDown2 {
                    lStartPos = lStartPos,
                    lEndPos = lEndPos,
                    which = which,
                    FileSaveSet = FileSaveSet,
                    FileName = FileName,
                    StrDownPath = FilePath,
                    myfileinfo = __myfileinfo
                };
                this.td[which] = new Thread(new ThreadStart(down2.down));
                this.td[which].Name = "线程 _beginDown2.down: " + which.ToString();
                this.td[which].Start();
                __myfileinfo.time = 0;
            }
        }

        public void beginDown2(long lStartPos, long lEndPos, int which, string FileSaveSet, string FileName, string FilePath, _fileinfo __myfileinfo)
        {
            ePrintDown2 down = new ePrintDown2 {
                lStartPos = lStartPos,
                lEndPos = lEndPos,
                which = which,
                FileSaveSet = FileSaveSet,
                FileName = FileName,
                StrDownPath = FilePath,
                myfileinfo = __myfileinfo
            };
            this.td[which] = new Thread(new ThreadStart(down.down));
            this.td[which].Name = "线程 _beginDown.down: " + which.ToString();
            this.td[which].Start();
            __myfileinfo.time = 0;
        }

        private void BeginDownAll()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (((this.glacialList1.Items[i].SubItems[0].ImageIndex != 4) && (this.glacialList1.Items[i].SubItems[0].ImageIndex != 0)) && (this.glacialList1.Items[i].SubItems[0].ImageIndex != 15))
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        tag.isError = 0;
                        if (this.waitDownload(this.MaxDownNum))
                        {
                            this.downloadContinue2(i, tag);
                        }
                        else
                        {
                            this.glacialList1.Items[i].SubItems[0].ImageIndex = 15;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listView5.CheckedItems.Count <= 0)
            {
                MessageBox.Show("请选择需要重置密码的帐号!");
            }
            else
            {
                DialogResult result;
                if (this.listView5.CheckedItems.Count == 1)
                {
                    result = MessageBox.Show("您此次打算重置 " + this.listView5.CheckedItems.Count.ToString() + " 个帐号密码,确定后将进行重置!", "印易提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }
                else
                {
                    result = MessageBox.Show("您此次打算重置 " + this.listView5.CheckedItems.Count.ToString() + " 个帐号密码,确定后将逐个进行重置!", "印易提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < this.listView5.CheckedItems.Count; i++)
                    {
                        if (this.listView5.CheckedItems[i].BackColor == Color.Silver)
                        {
                            MessageBox.Show(this.listView5.CheckedItems[i].SubItems[2].Text + " 为公共帐号,不允许重置密码!");
                        }
                        else
                        {
                            new EditUserPassword { OutputKey = Outputkey, UserId = this.listView5.CheckedItems[i].Tag.ToString(), UserCode = this.listView5.CheckedItems[i].SubItems[1].Text, myCompanyName = this.listView5.CheckedItems[i].SubItems[3].Text, UserName = this.listView5.CheckedItems[i].SubItems[2].Text }.ShowDialog();
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!SendFileIsOpen)
            {
                this._sendFile = new SendFileToUser();
                this._sendFile.Show();
            }
            else
            {
                this._sendFile.BringToFront();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.getUserFiles)) { Name = "getUserFiles" }.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.delUserFiles(2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.delUserFiles(3);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.editBulletin();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.delBulletin();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.ePrintLog.WriteLog("修改声明");
            string newOutputStatement = this.replaceChar(this.textBox5.Text.Trim());
            ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
            if (login._editOutputStatement(Convert.ToInt32(Outputkey), newOutputStatement))
            {
                this.ePrintLog.WriteLog("修改声明成功");
                MessageBox.Show("修改成功！");
            }
            else
            {
                this.ePrintLog.WriteLog("修改声明失败");
                MessageBox.Show("修改失败！");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            new AddBulletin().ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.getOutputBulletin)) { Name = "getOutputBulletin" }.Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
                if (key != null)
                {
                    if (this.checkBox2.Checked)
                    {
                        this._OrderInfoItemheight = "auto";
                    }
                    else
                    {
                        this._OrderInfoItemheight = this.numericUpDown1.Value.ToString();
                    }
                    key.SetValue("OrderInfoFont1", this._OrderInfoFont1);
                    key.SetValue("OrderInfoFont2", this._OrderInfoFont2);
                    key.SetValue("OrderInfoForeColor1", this._OrderInfoForeColor1);
                    key.SetValue("OrderInfoForeColor2", this._OrderInfoForeColor2);
                    key.SetValue("OrderInfoItemheight", this._OrderInfoItemheight);
                    try
                    {
                        this.__OrderInfoFont1 = this._OrderInfoFont1.Split(new char[] { '|' });
                        this.__OrderInfoFont2 = this._OrderInfoFont2.Split(new char[] { '|' });
                        this.__OrderInfoForeColor1 = this._OrderInfoForeColor1.Split(new char[] { ',' });
                        this.__OrderInfoForeColor2 = this._OrderInfoForeColor2.Split(new char[] { ',' });
                    }
                    catch
                    {
                    }
                    try
                    {
                        if (this._OrderInfoItemheight == "auto")
                        {
                            this.glacialList5.AutoHeight = true;
                        }
                        else
                        {
                            this.glacialList5.AutoHeight = false;
                            this.glacialList5.ItemHeight = Convert.ToInt16(this._OrderInfoItemheight);
                        }
                        foreach (GLItem item in this.glacialList5.Items)
                        {
                            if (item.SubItems[0].Text.IndexOf("订单类型") < 0)
                            {
                                item.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                                item.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                                for (int i = 1; i < this.glacialList5.Columns.Count; i++)
                                {
                                    item.SubItems[i].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                                    item.SubItems[i].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                                }
                            }
                        }
                        this.glacialList5.Refresh();
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            this.panel9.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.delUser();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.panel9.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            int num = 100;
            string str = "select max(dh) as dh from DownLoading";
            OleDbCommand command = new OleDbCommand {
                Connection = connection,
                CommandText = str
            };
            OleDbDataReader reader = null;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                num = Convert.ToInt32(reader["dh"].ToString());
            }
            connection.Open();
            for (int i = 0; i <= 0x1388; i++)
            {
                new OleDbCommand(string.Concat(new object[] { "insert into DownLoading(dh) values (", num, i, ")" }), connection).ExecuteNonQuery();
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.getOutputUser)) { Name = "getOutputUser" }.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listView5.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.selectUser();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new AddUser().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.delUserFiles(0);
        }

        private void cancelViewOrderInfo()
        {
            if ((this.glacialList4.Items.Count > 0) && (this.glacialList4.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList4.Items.Count; i++)
                {
                    if (this.glacialList4.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList4.Items[i].Tag;
                        this.viewOrderInfo(tag.OrderInfo);
                        return;
                    }
                }
            }
        }

        private void changeChecked()
        {
            if (((this.textBox1.Text.Trim() != "") || (this.textBox2.Text.Trim() != "")) || (this.textBox3.Text.Trim() != ""))
            {
                this.checkBox1.Checked = false;
            }
        }

        private void changeColor()
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this._OrderInfoForeColor1 = this.colorDialog1.Color.A.ToString() + "," + this.colorDialog1.Color.R.ToString() + "," + this.colorDialog1.Color.G.ToString() + "," + this.colorDialog1.Color.B.ToString();
                this.glacialList7.Items[0].SubItems[0].ForeColor = this.glacialList7.Items[1].SubItems[0].ForeColor = this.glacialList7.Items[2].SubItems[0].ForeColor = this.colorDialog1.Color;
                this.glacialList7.Refresh();
            }
        }

        private void changeColor2()
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this._OrderInfoForeColor2 = this.colorDialog1.Color.A.ToString() + "," + this.colorDialog1.Color.R.ToString() + "," + this.colorDialog1.Color.G.ToString() + "," + this.colorDialog1.Color.B.ToString();
                this.glacialList7.Items[0].SubItems[1].ForeColor = this.glacialList7.Items[1].SubItems[1].ForeColor = this.glacialList7.Items[2].SubItems[1].ForeColor = this.colorDialog1.Color;
                this.glacialList7.Refresh();
            }
        }

        private void changeFont()
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this._OrderInfoFont1 = this.fontDialog1.Font.Name + "|" + this.fontDialog1.Font.Size.ToString() + "|" + (this.fontDialog1.Font.Bold ? "1" : "0") + "|" + (this.fontDialog1.Font.Italic ? "1" : "0");
                this.glacialList7.Items[0].SubItems[0].Font = this.glacialList7.Items[1].SubItems[0].Font = this.glacialList7.Items[2].SubItems[0].Font = this.fontDialog1.Font;
                this.glacialList7.Refresh();
                Console.Write(this.fontDialog1.Font.Name + "|" + this.fontDialog1.Font.Size.ToString() + "|" + (this.fontDialog1.Font.Bold ? "1" : "0") + "|" + (this.fontDialog1.Font.Italic ? "1" : "0"));
            }
        }

        private void changeFont2()
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this._OrderInfoFont2 = this.fontDialog1.Font.Name + "|" + this.fontDialog1.Font.Size.ToString() + "|" + (this.fontDialog1.Font.Bold ? "1" : "0") + "|" + (this.fontDialog1.Font.Italic ? "1" : "0");
                this.glacialList7.Items[0].SubItems[1].Font = this.glacialList7.Items[1].SubItems[1].Font = this.glacialList7.Items[2].SubItems[1].Font = this.fontDialog1.Font;
                this.glacialList7.Refresh();
            }
        }

        private void changePassword()
        {
        }

        private void changeSpeed()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4)) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 10))
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        tag.time = 0;
                        tag.DownloadedSize_relatively = 0L;
                    }
                }
            }
        }

        private void ChangeUser()
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
                        this.SetLoginInfo(key2);
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
                this.ePrintLog.WriteLog("注销时出错: " + exception.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = "";
                this.checkBox1.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this._OrderInfoItemheight = "auto";
                this.glacialList7.AutoHeight = true;
            }
            else
            {
                this._OrderInfoItemheight = this.numericUpDown1.Value.ToString();
                this.glacialList7.AutoHeight = false;
            }
            this.glacialList7.Refresh();
        }

        private void CheckDownState()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4)) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 10))
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        if (tag.splitedNum <= 0)
                        {
                            this.downloadStop2(i, tag);
                            Thread.Sleep(100);
                            this.downloadContinue2(i, tag);
                        }
                    }
                }
            }
        }

        private void CheckDownState2()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if ((this.glacialList1.Items[i].Tag != null) && ((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4)))
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        if ((tag.isfinished == 0) && (tag.noDateTime >= 20))
                        {
                            this.ePrintLog.WriteLog("文件(" + tag.FileName + ")20秒无数据接收,重连续下!");
                            tag.noDateTime = 0;
                            try
                            {
                                tag.ns2.Close();
                                tag.fs2.Close();
                            }
                            catch
                            {
                            }
                            Thread.Sleep(100);
                            this.downloadContinue2(i, tag);
                        }
                    }
                }
            }
        }

        private bool checkisCheck(string FileId)
        {
            bool flag = true;
            OleDbConnection connection = new OleDbConnection(strCon);
            OleDbCommand command = new OleDbCommand("select top 1 dh from DownLoading where FileId='" + FileId + "'", connection);
            OleDbDataReader reader = null;
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                flag = false;
                try
                {
                    this.ePrintLog.WriteLog("文件[ " + FileId + " ]已接收，需返回更改状态！");
                }
                catch
                {
                }
            }
            reader.Close();
            connection.Close();
            return flag;
        }

        private bool checkRegisterInfo()
        {
            bool flag = false;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
            if (key != null)
            {
                SetupPath = (string) key.GetValue("SetupPath");
                this.NewVersion = (string) key.GetValue("NewVersion");
                if (SetupPath != "")
                {
                    flag = true;
                }
            }
            return flag;
        }

        private void CheckVersion()
        {
            try
            {
                this.ePrintLog.WriteLog("检查新版本,本地版本为:" + SoftVersion);
                string[] strArray = new ePrintOrderManager.cn.print2000.update.ePrintOutputLogin("http://u.print2000.cn/ePrintServer/ePrintOutputLogin.asmx") { Timeout = 0x493e0 }._UpdateInfo();
                this.ePrintLog.WriteLog("检查新版本,远程版本为:" + strArray[0]);
                int num = Convert.ToInt32(SoftVersion.Replace(".", ""));
                int num2 = Convert.ToInt32(strArray[0].Replace(".", ""));
                if ((strArray[0] != null) && (num2 > num))
                {
                    this.ePrintLog.WriteLog("发现印易新版本 " + strArray[0]);
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
                    }
                    else
                    {
                        this.ePrintLog.WriteLog("取消升级");
                    }
                }
                else
                {
                    this.ePrintLog.WriteLog("无新版本");
                }
            }
            catch (Exception exception2)
            {
                this.ePrintLog.WriteLog(exception2.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPath = this.comboBox1.SelectedItem.ToString();
            this.OpenPath(strPath);
        }

        private void contextMenu1_Popup(object sender, EventArgs e)
        {
            if (this.glacialList1.Items.Count == 0)
            {
                for (int i = 0; i < this.contextMenu1.MenuItems.Count; i++)
                {
                    this.contextMenu1.MenuItems[i].Enabled = false;
                }
            }
            else if (this.glacialList1.SelectedItems.Count == 0)
            {
                for (int j = 0; j < this.contextMenu1.MenuItems.Count; j++)
                {
                    switch (j)
                    {
                        case 2:
                        case 3:
                            this.contextMenu1.MenuItems[j].Enabled = true;
                            break;

                        default:
                            this.contextMenu1.MenuItems[j].Enabled = false;
                            break;
                    }
                }
            }
            else
            {
                for (int k = 0; k < this.contextMenu1.MenuItems.Count; k++)
                {
                }
            }
        }

        private void contextMenu5_Popup(object sender, EventArgs e)
        {
            if ((this.listView5.SelectedItems.Count <= 0) || (this.listView5.SelectedItems[0].BackColor == Color.Silver))
            {
                this.contextMenu5.MenuItems[5].Enabled = this.contextMenu5.MenuItems[6].Enabled = this.contextMenu5.MenuItems[7].Enabled = this.contextMenu5.MenuItems[8].Enabled = this.contextMenu5.MenuItems[9].Enabled = this.contextMenu5.MenuItems[10].Enabled = this.contextMenu5.MenuItems[11].Enabled = false;
            }
            else
            {
                this.contextMenu5.MenuItems[5].Enabled = this.contextMenu5.MenuItems[6].Enabled = this.contextMenu5.MenuItems[7].Enabled = this.contextMenu5.MenuItems[8].Enabled = this.contextMenu5.MenuItems[9].Enabled = this.contextMenu5.MenuItems[10].Enabled = this.contextMenu5.MenuItems[11].Enabled = true;
                if ((this.listView5.SelectedItems.Count > 1) || (this.listView5.SelectedItems[0].BackColor == Color.White))
                {
                    this.contextMenu5.MenuItems[6].Enabled = false;
                }
                else
                {
                    this.contextMenu5.MenuItems[6].Enabled = true;
                }
                if (this.listView5.SelectedItems[0].BackColor == Color.LightPink)
                {
                    this.contextMenu5.MenuItems[11].Enabled = true;
                }
                else
                {
                    this.contextMenu5.MenuItems[11].Enabled = false;
                }
            }
        }

        private void delBulletin()
        {
            if (((this.listView8.Items.Count > 0) && (this.listView8.SelectedItems.Count > 0)) && (MessageBox.Show("您确定此删除操作吗?", "印易提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes))
            {
                this.ePrintLog.WriteLog("删除公告:" + this.listView8.SelectedItems[0].SubItems[0].Text);
                int iD = Convert.ToInt32(this.listView8.SelectedItems[0].Tag.ToString());
                ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                if (login._delOutputBulletin(Convert.ToInt32(Outputkey), iD))
                {
                    this.listView8.SelectedItems[0].Remove();
                    this.listView8.Refresh();
                    this.ePrintLog.WriteLog("删除成功");
                }
                else
                {
                    this.ePrintLog.WriteLog("删除失败");
                    MessageBox.Show("删除失败!");
                }
            }
        }

        private void deledMuDel()
        {
            if (this.glacialList3.Items.Count > 0)
            {
                int count = this.glacialList3.SelectedItems.Count;
                int[] orderId = new int[count];
                string[] fileName = new string[count];
                int index = 0;
                string str = null;
                for (int i = 0; i < this.glacialList3.Items.Count; i++)
                {
                    if (this.glacialList3.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList3.Items[i].Tag;
                        orderId[index] = Convert.ToInt32(tag.FileId);
                        fileName[index] = this.glacialList3.Items[i].SubItems[2].Text;
                        str = str + tag.orderkey.ToString() + ",";
                        index++;
                    }
                }
                foreach (GLItem item in this.glacialList3.SelectedItems)
                {
                    this.glacialList3.Items.Remove(item);
                }
                this.glacialList3.Refresh();
                try
                {
                    new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._delOrder(Convert.ToInt16(Outputkey), orderId, fileName);
                }
                catch (Exception exception)
                {
                    this.ePrintLog.WriteLog("删除订单出错4：" + exception.ToString());
                }
                Thread.Sleep(100);
                this.OutputRoomInfo();
                delFile2(str.Remove(str.Length - 1, 1), 2);
                if (this.glacialList3.Items.Count <= 0)
                {
                    this.treeView1.Nodes[0].Nodes[2].ImageIndex = 3;
                    this.treeView1.Nodes[0].Nodes[2].SelectedImageIndex = 3;
                }
            }
        }

        public static void delFile(_fileinfo __myfileinfo, int type)
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            connection.Open();
            string cmdText = null;
            if (type == 0)
            {
                cmdText = string.Concat(new object[] { "update DownLoading set isWhich=2,DelTime='", DateTime.Now, "' where dh=", __myfileinfo.orderkey });
            }
            if (type == 1)
            {
                cmdText = string.Concat(new object[] { "update DownLoading set isWhich=2,DelTime='", DateTime.Now, "' where dh=", __myfileinfo.orderkey });
            }
            if (type == 2)
            {
                cmdText = "delete from DownLoading  where dh=" + __myfileinfo.orderkey;
            }
            if (type == 3)
            {
                cmdText = "update DownLoading set isWhich=0 where dh=" + __myfileinfo.orderkey;
            }
            if (type == 4)
            {
                cmdText = "update DownLoading set State=3 where dh=" + __myfileinfo.orderkey;
            }
            new OleDbCommand(cmdText, connection).ExecuteNonQuery();
            connection.Close();
        }

        public static void delFile2(string arrayKey, int type)
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            connection.Open();
            string cmdText = null;
            if (type == 0)
            {
                cmdText = string.Concat(new object[] { "update DownLoading set isWhich=2,DelTime='", DateTime.Now, "' where dh in (", arrayKey, ")" });
            }
            if (type == 1)
            {
                cmdText = string.Concat(new object[] { "update DownLoading set isWhich=2,DelTime='", DateTime.Now, "' where dh in (", arrayKey, ")" });
            }
            if (type == 2)
            {
                cmdText = "delete from DownLoading  where dh in (" + arrayKey + ")";
            }
            if (type == 3)
            {
                cmdText = "update DownLoading set isWhich=0 where dh in (" + arrayKey + ")";
            }
            if (type == 4)
            {
                cmdText = "update DownLoading set State=3 where dh in (" + arrayKey + ")";
            }
            new OleDbCommand(cmdText, connection).ExecuteNonQuery();
            connection.Close();
        }

        private void delLogFiles()
        {
            try
            {
                if (((this.listView7.Items.Count > 0) && (this.listView7.SelectedItems.Count > 0)) && (MessageBox.Show("日志文件有助于查找错误及解决相应问题,建议您至少保留30天以内的日志文件!\n\n您确认删除吗?", "印易提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes))
                {
                    for (int i = 0; i < this.listView7.SelectedItems.Count; i++)
                    {
                        try
                        {
                            File.Delete(@"ePrintLog\" + this.listView7.SelectedItems[i].SubItems[0].Text);
                        }
                        catch
                        {
                        }
                    }
                    foreach (ListViewItem item in this.listView7.SelectedItems)
                    {
                        this.listView7.Items.Remove(item);
                    }
                    this.listView7.Refresh();
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("删除日志时出错: " + exception.ToString());
            }
        }

        private void delUser()
        {
            if (this.listView5.CheckedItems.Count <= 0)
            {
                MessageBox.Show("请选择需要删除的帐号!");
            }
            else
            {
                string str = null;
                string str2 = null;
                int[] userId = new int[this.listView5.CheckedItems.Count];
                int num = 0;
                for (int i = 0; i < this.listView5.CheckedItems.Count; i++)
                {
                    userId[i] = Convert.ToInt32(this.listView5.CheckedItems[i].Tag.ToString());
                    string str3 = str;
                    str = str3 + this.listView5.CheckedItems[i].SubItems[1].Text + " [" + this.listView5.CheckedItems[i].SubItems[2].Text + "] [" + this.listView5.CheckedItems[i].SubItems[4].Text + "]\n";
                    if (this.listView5.CheckedItems[i].BackColor == Color.Silver)
                    {
                        num = 1;
                        str2 = this.listView5.CheckedItems[i].SubItems[1].Text + " [" + this.listView5.CheckedItems[i].SubItems[2].Text + "]";
                        break;
                    }
                    if (this.listView5.CheckedItems[i].BackColor == Color.SteelBlue)
                    {
                        num = 2;
                        str2 = this.listView5.CheckedItems[i].SubItems[1].Text + " [" + this.listView5.CheckedItems[i].SubItems[2].Text + "]";
                        break;
                    }
                }
                if (str2 != null)
                {
                    switch (num)
                    {
                        case 1:
                            MessageBox.Show(str2 + "\n\n此为公共帐号,不能被删除!");
                            return;

                        case 2:
                            MessageBox.Show(str2 + "\n\n此为管理员帐号,不能被删除!");
                            return;
                    }
                }
                else if (MessageBox.Show("操作将影响以下帐号:\n\n" + str + "\n\n帐号删除后将不能恢复,您确定此操作吗?\n", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                        if (login._delUserInfo(userId, Convert.ToInt32(Outputkey)))
                        {
                            foreach (ListViewItem item in this.listView5.CheckedItems)
                            {
                                this.listView5.Items.Remove(item);
                                this.listView5.Refresh();
                            }
                            this.ePrintLog.WriteLog("删除用户成功");
                            MessageBox.Show("删除操作成功!");
                        }
                        else
                        {
                            this.ePrintLog.WriteLog("删除用户失败");
                            MessageBox.Show("删除操作失败!");
                        }
                    }
                    catch (Exception exception)
                    {
                        this.ePrintLog.WriteLog("删除用户时出错: " + exception.ToString());
                        MessageBox.Show("删除操作失败!\n失败原因:\n" + exception.Message);
                    }
                }
            }
        }

        private void delUser2()
        {
            if (this.listView5.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择需要删除的帐号!");
            }
            else
            {
                this.ePrintLog.WriteLog("尝试删除用户操作");
                string str = null;
                string str2 = null;
                int[] userId = new int[this.listView5.SelectedItems.Count];
                int num = 0;
                for (int i = 0; i < this.listView5.SelectedItems.Count; i++)
                {
                    userId[i] = Convert.ToInt32(this.listView5.SelectedItems[i].Tag.ToString());
                    string str3 = str;
                    str = str3 + this.listView5.SelectedItems[i].SubItems[1].Text + " [" + this.listView5.SelectedItems[i].SubItems[2].Text + "] [" + this.listView5.SelectedItems[i].SubItems[4].Text + "]\n";
                    if (this.listView5.SelectedItems[i].BackColor == Color.Silver)
                    {
                        num = 1;
                        str2 = this.listView5.SelectedItems[i].SubItems[1].Text + " [" + this.listView5.SelectedItems[i].SubItems[2].Text + "]";
                        break;
                    }
                    if (this.listView5.SelectedItems[i].BackColor == Color.SteelBlue)
                    {
                        num = 2;
                        str2 = this.listView5.SelectedItems[i].SubItems[1].Text + " [" + this.listView5.SelectedItems[i].SubItems[2].Text + "]";
                        break;
                    }
                }
                if (str2 != null)
                {
                    switch (num)
                    {
                        case 1:
                            MessageBox.Show(str2 + "\n\n此为公共帐号,不能被删除!");
                            return;

                        case 2:
                            MessageBox.Show(str2 + "\n\n此为管理员帐号,不能被删除!");
                            return;
                    }
                }
                else if (MessageBox.Show("操作将影响以下帐号:\n\n" + str + "\n\n帐号删除后将不能恢复,您确定此操作吗?\n", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    try
                    {
                        ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                        if (login._delUserInfo(userId, Convert.ToInt32(Outputkey)))
                        {
                            foreach (ListViewItem item in this.listView5.SelectedItems)
                            {
                                this.listView5.Items.Remove(item);
                                this.listView5.Refresh();
                            }
                            this.ePrintLog.WriteLog("删除用户成功");
                            MessageBox.Show("删除操作成功!");
                        }
                        else
                        {
                            this.ePrintLog.WriteLog("删除用户失败");
                            MessageBox.Show("删除操作失败!");
                        }
                    }
                    catch (Exception exception)
                    {
                        this.ePrintLog.WriteLog("删除用户时出错: " + exception.ToString());
                        MessageBox.Show("删除操作失败!\n失败原因:\n" + exception.Message);
                    }
                }
            }
        }

        private void delUserFiles(int WhichDel)
        {
            if (this.listView6.Items.Count > 0)
            {
                int count = 0;
                if (WhichDel == 0)
                {
                    count = this.listView6.CheckedItems.Count;
                }
                else if (WhichDel == 1)
                {
                    count = this.listView6.SelectedItems.Count;
                }
                else if (WhichDel == 2)
                {
                    for (int i = 0; i < this.listView6.Items.Count; i++)
                    {
                        if (this.listView6.Items[i].ForeColor != Color.Red)
                        {
                            count++;
                        }
                    }
                }
                else if (WhichDel == 3)
                {
                    count = this.listView6.Items.Count;
                }
                if (count == 0)
                {
                    MessageBox.Show("请选择您要删除的文件!");
                }
                else if (MessageBox.Show("删除后将不能恢复,您确定此操作吗?", "印易提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    this.ePrintLog.WriteLog("删除用户文件");
                    this.button9.Enabled = this.button11.Enabled = this.button12.Enabled = this.button13.Enabled = false;
                    try
                    {
                        string fileId = null;
                        string fileName = null;
                        if (WhichDel == 0)
                        {
                            for (int j = 0; j < this.listView6.CheckedItems.Count; j++)
                            {
                                fileId = fileId + this.listView6.CheckedItems[j].Tag.ToString() + ",";
                                fileName = fileName + this.listView6.CheckedItems[j].SubItems[2].Text.Trim() + ",";
                            }
                        }
                        else if (WhichDel == 1)
                        {
                            for (int k = 0; k < this.listView6.SelectedItems.Count; k++)
                            {
                                fileId = fileId + this.listView6.SelectedItems[k].Tag.ToString() + ",";
                                fileName = fileName + this.listView6.SelectedItems[k].SubItems[2].Text.Trim() + ",";
                            }
                        }
                        else if (WhichDel == 2)
                        {
                            for (int m = 0; m < this.listView6.Items.Count; m++)
                            {
                                if (this.listView6.Items[m].ForeColor != Color.Red)
                                {
                                    fileId = fileId + this.listView6.Items[m].Tag.ToString() + ",";
                                    fileName = fileName + this.listView6.Items[m].SubItems[2].Text.Trim() + ",";
                                }
                            }
                        }
                        else if (WhichDel == 3)
                        {
                            for (int n = 0; n < this.listView6.Items.Count; n++)
                            {
                                fileId = fileId + this.listView6.Items[n].Tag.ToString() + ",";
                                fileName = fileName + this.listView6.Items[n].SubItems[2].Text.Trim() + ",";
                            }
                        }
                        fileId = fileId.TrimEnd(new char[] { ',' });
                        fileName = fileName.TrimEnd(new char[] { ',' });
                        ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                        if (login._delUserFiles2(Convert.ToInt32(Outputkey), fileId, fileName))
                        {
                            if (WhichDel == 0)
                            {
                                foreach (ListViewItem item in this.listView6.CheckedItems)
                                {
                                    this.listView6.Items.Remove(item);
                                }
                            }
                            else if (WhichDel == 1)
                            {
                                foreach (ListViewItem item2 in this.listView6.SelectedItems)
                                {
                                    this.listView6.Items.Remove(item2);
                                }
                            }
                            else if (WhichDel == 2)
                            {
                                for (int num7 = 0; num7 < this.listView6.Items.Count; num7++)
                                {
                                    if (this.listView6.Items[num7].ForeColor != Color.Red)
                                    {
                                        this.listView6.Items[num7].Remove();
                                        num7--;
                                    }
                                }
                            }
                            else if (WhichDel == 3)
                            {
                                this.listView6.Items.Clear();
                            }
                            this.listView6.Refresh();
                            this.label14.Text = "文件总数: " + this.listView6.Items.Count.ToString() + "  总大小: " + this.sizeChange(this.UserFileSize);
                            this.OutputRoomInfo();
                            this.ePrintLog.WriteLog("删除用户文件成功");
                        }
                        else
                        {
                            this.ePrintLog.WriteLog("删除用户文件失败");
                            MessageBox.Show("删除失败!");
                        }
                    }
                    catch (Exception exception)
                    {
                        this.ePrintLog.WriteLog("删除用户文件时出错:" + exception.ToString());
                        MessageBox.Show("删除失败!");
                    }
                    this.button9.Enabled = this.button11.Enabled = this.button12.Enabled = this.button13.Enabled = true;
                }
            }
        }

        private void delViewOrderInfo()
        {
            if ((this.glacialList3.Items.Count > 0) && (this.glacialList3.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList3.Items.Count; i++)
                {
                    if (this.glacialList3.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList3.Items[i].Tag;
                        this.viewOrderInfo(tag.OrderInfo);
                        return;
                    }
                }
            }
        }

        private void displayer(TabControl mytab, int Index)
        {
            switch (Index)
            {
                case 1:
                    this.PnlFunc1.BringToFront();
                    return;

                case 2:
                    this.PnlFunc2.BringToFront();
                    return;

                case 3:
                    this.PnlFunc3.BringToFront();
                    return;

                case 4:
                    this.PnlFunc4.BringToFront();
                    return;

                case 5:
                    this.PnlFunc5.BringToFront();
                    return;

                case 6:
                    this.PnlFunc6.BringToFront();
                    return;
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

        private void DoChangeDownloadedInfo(_fileinfo __myfileinfo, int which)
        {
            if (__myfileinfo.isError == 1)
            {
                this.glacialList1.Items[which].SubItems[0].ImageIndex = 3;
            }
            else if (__myfileinfo.isError == 2)
            {
                this.glacialList1.Items[which].SubItems[0].ImageIndex = 10;
            }
            else
            {
                if (__myfileinfo.DownloadedSize_absoluteness < __myfileinfo.FileSize)
                {
                    __myfileinfo.DownloadedSize_absoluteness = 0L;
                    __myfileinfo.DownloadedSize_relatively = 0L;
                    try
                    {
                        __myfileinfo.DownloadedSize_absoluteness = __myfileinfo.fs2.Length;
                    }
                    catch
                    {
                        try
                        {
                            FileStream stream = File.Open(__myfileinfo.FileSaveSet + @"\" + __myfileinfo.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                            __myfileinfo.DownloadedSize_absoluteness = stream.Length;
                            stream.Close();
                        }
                        catch
                        {
                        }
                    }
                    this.isDataDown(__myfileinfo, which);
                    __myfileinfo.DownloadedSize_lastcheck = __myfileinfo.DownloadedSize_absoluteness;
                    if ((__myfileinfo.time > 0) && ((__myfileinfo.time % 2) == 0))
                    {
                        try
                        {
                            string str;
                            string str2;
                            string str3;
                            TimeSpan span = TimeSpan.FromSeconds(Convert.ToDouble((int) (__myfileinfo.time / 2)));
                            if (span.Hours.ToString().Length < 2)
                            {
                                str = "0" + span.Hours.ToString();
                            }
                            else
                            {
                                str = span.Hours.ToString();
                            }
                            if (span.Minutes.ToString().Length < 2)
                            {
                                str2 = "0" + span.Minutes.ToString();
                            }
                            else
                            {
                                str2 = span.Minutes.ToString();
                            }
                            if (span.Seconds.ToString().Length < 2)
                            {
                                str3 = "0" + span.Seconds.ToString();
                            }
                            else
                            {
                                str3 = span.Seconds.ToString();
                            }
                            this.glacialList1.Items[which].SubItems[6].Text = str + ":" + str2 + ":" + str3;
                            if (__myfileinfo.DownloadedSize_absoluteness > __myfileinfo.DownloadedSize_initialize)
                            {
                                __myfileinfo.DownloadedSize_relatively = __myfileinfo.DownloadedSize_absoluteness - __myfileinfo.DownloadedSize_initialize;
                            }
                            if (__myfileinfo.DownloadedSize_absoluteness <= __myfileinfo.FileSize)
                            {
                                this.glacialList1.Items[which].SubItems[4].Text = this.sizeChange(__myfileinfo.DownloadedSize_absoluteness);
                                myprogress control = (myprogress) this.glacialList1.Items[which].SubItems[5].Control;
                                if (control != null)
                                {
                                    control.Value = Convert.ToInt16((long) ((__myfileinfo.DownloadedSize_absoluteness * 100L) / __myfileinfo.FileSize));
                                }
                            }
                            else
                            {
                                try
                                {
                                    this.glacialList1.Items[which].SubItems[4].Text = this.sizeChange(__myfileinfo.FileSize);
                                    this.glacialList1.Items[which].SubItems[5].Text = "100%";
                                }
                                catch
                                {
                                }
                            }
                            this.glacialList1.Items[which].SubItems[0].ImageIndex = 4;
                            if ((__myfileinfo.splitedNum == 0) || (__myfileinfo.splitedNum == 1))
                            {
                                this.glacialList1.Items[which].SubItems[9].Text = __myfileinfo.splitedNum.ToString() + "/1";
                            }
                            else if (__myfileinfo.splitedNum > 1)
                            {
                                this.glacialList1.Items[which].SubItems[9].Text = "1/1";
                            }
                            else if (__myfileinfo.splitedNum < 0)
                            {
                                this.glacialList1.Items[which].SubItems[9].Text = "0/1";
                            }
                            if ((__myfileinfo.noDateTime == 0) && (__myfileinfo.time > 10))
                            {
                                int time = 0;
                                if (__myfileinfo.time < 3)
                                {
                                    time = 3;
                                }
                                else
                                {
                                    time = __myfileinfo.time;
                                }
                                __myfileinfo.Speed = (Convert.ToDouble(__myfileinfo.DownloadedSize_relatively) / Convert.ToDouble((int) (time / 2))) / 1024.0;
                                string str4 = Convert.ToString(Math.Round(__myfileinfo.Speed, 2));
                                if ((str4.IndexOf("非数字") < 0) && (str4.IndexOf("无穷大") < 0))
                                {
                                    this.glacialList1.Items[which].SubItems[8].Text = str4 + "K/S";
                                }
                            }
                            double num2 = Math.Round((double) (Convert.ToDouble((long) (__myfileinfo.FileSize - __myfileinfo.DownloadedSize_absoluteness)) / (Convert.ToDouble(__myfileinfo.DownloadedSize_relatively) / Convert.ToDouble((int) (__myfileinfo.time / 2)))), 0);
                            try
                            {
                                string str5;
                                string str6;
                                string str7;
                                TimeSpan span2 = TimeSpan.FromSeconds(num2);
                                if (span2.Hours.ToString().Length < 2)
                                {
                                    str5 = "0" + span2.Hours.ToString();
                                }
                                else
                                {
                                    str5 = span2.Hours.ToString();
                                }
                                if (span2.Minutes.ToString().Length < 2)
                                {
                                    str6 = "0" + span2.Minutes.ToString();
                                }
                                else
                                {
                                    str6 = span2.Minutes.ToString();
                                }
                                if (span2.Seconds.ToString().Length < 2)
                                {
                                    str7 = "0" + span2.Seconds.ToString();
                                }
                                else
                                {
                                    str7 = span2.Seconds.ToString();
                                }
                                this.glacialList1.Items[which].SubItems[7].Text = str5 + ":" + str6 + ":" + str7;
                            }
                            catch
                            {
                            }
                        }
                        catch (Exception exception)
                        {
                            this.ePrintLog.WriteLog("定时检查下载文件状态时出错(3) (" + __myfileinfo.FileName + "): " + exception.ToString());
                        }
                    }
                }
                if ((__myfileinfo.time > 0) && ((__myfileinfo.time % 20) == 0))
                {
                    this.editSplitData(__myfileinfo);
                }
                if (__myfileinfo.DownloadedSize_absoluteness < __myfileinfo.FileSize)
                {
                    if (__myfileinfo.noDateTime <= 10)
                    {
                        __myfileinfo.time++;
                    }
                }
                else
                {
                    long length = 0L;
                    try
                    {
                        length = __myfileinfo.fs2.Length;
                    }
                    catch
                    {
                        try
                        {
                            FileStream stream2 = File.Open(__myfileinfo.FileSaveSet + @"\" + __myfileinfo.FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                            length = stream2.Length;
                            stream2.Close();
                        }
                        catch
                        {
                        }
                    }
                    if (length == __myfileinfo.FileSize)
                    {
                        __myfileinfo.isfinished = 1;
                        try
                        {
                            try
                            {
                                Console.Write("\n" + __myfileinfo.FileSaveSet + "\n");
                                this.editData(__myfileinfo);
                                ActionWhich = -1;
                                this.treeView2.Nodes[1].Nodes.Clear();
                                this.panel8.BringToFront();
                                this.ePrintLog.WriteLog("更新\"已下载\"列表：" + __myfileinfo.FileName);
                                this.isDown(__myfileinfo.FileId);
                                if (this.waitDownload(this.MaxDownNum))
                                {
                                    this.downNext();
                                }
                                this.statusBarPanel3.Text = "";
                                Thread.Sleep(100);
                                Console.Write(__myfileinfo.FileSaveSet + @"\" + __myfileinfo.FileName + ".eprinting");
                                string str9 = null;
                                if (__myfileinfo.FileName.IndexOf(".") >= 0)
                                {
                                    __myfileinfo.FileName.Substring(0, __myfileinfo.FileName.LastIndexOf("."));
                                    str9 = __myfileinfo.FileName.Substring(__myfileinfo.FileName.LastIndexOf("."));
                                }
                                else
                                {
                                    string fileName = __myfileinfo.FileName;
                                    str9 = "";
                                }
                                string zipFilePath = __myfileinfo.FileSaveSet + @"\" + __myfileinfo.FileName;
                                Console.Write(__myfileinfo.FileSaveSet);
                                Console.Write("\n555" + zipFilePath + "\n");
                                try
                                {
                                    this.glacialList1.Items.RemoveAt(which);
                                    this.glacialList1.Refresh();
                                    __myfileinfo.DownloadedSize_absoluteness = 0L;
                                }
                                catch
                                {
                                }
                                this.getDownedData();
                                __myfileinfo.fs2.Close();
                                Thread.Sleep(100);
                                try
                                {
                                    this.unzip(zipFilePath, str9.Substring(1, 3));
                                }
                                catch
                                {
                                }
                                this.ePrintLog.WriteLog("\n####################\n下载完成！" + __myfileinfo.DownloadedSize_absoluteness.ToString() + " | " + __myfileinfo.FileSize.ToString() + " | " + __myfileinfo.noDateTime.ToString() + "\n####################\n");
                            }
                            catch (Exception exception2)
                            {
                                try
                                {
                                    __myfileinfo.fs2.Close();
                                }
                                catch
                                {
                                }
                                this.ePrintLog.WriteLog("定时检查下载文件状态时出错(4) (" + __myfileinfo.FileName + ") : " + exception2.ToString());
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        private void dowith()
        {
            string str = this._ReceiveInfo;
            this.ReceiveInfo = "";
            this._ReceiveInfo = "";
            Console.Write("\n处理收到信息:" + str + "\n");
            try
            {
                string[] strArray = str.Split(new char[] { '|' });
                if (strArray[0] == "FileInfo")
                {
                    if (this.HtrecInfo[str] == null)
                    {
                        this.HtrecInfo.Add(str, "I 'v Got!");
                        Console.WriteLine("HashTable(HtrecInfo) add: {0}", str);
                        Console.WriteLine("HashTable(HtrecInfo) Count: {0}", this.HtrecInfo.Count);
                        this.ePrintLog.WriteLog(str);
                        if (this.checkisCheck(strArray[10]))
                        {
                            string str2;
                            long num = 0L;
                            long num2 = 0L;
                            string[] fileinfo = new string[13];
                            if (this.waitKey <= 0)
                            {
                                this.waitKey = 1;
                                OleDbConnection connection = new OleDbConnection(strCon);
                                str2 = "select top 1 dh from DownLoading order by dh desc";
                                OleDbCommand command = new OleDbCommand(str2, connection);
                                OleDbDataReader reader = null;
                                connection.Open();
                                reader = command.ExecuteReader();
                                if (reader.Read())
                                {
                                    num = Convert.ToInt64(reader["dh"]) + 1L;
                                }
                                else
                                {
                                    num = 0L;
                                }
                                reader.Close();
                                connection.Close();
                                this.PreKey = num;
                            }
                            else
                            {
                                OleDbConnection connection2 = new OleDbConnection(strCon);
                                str2 = "select top 1 dh from DownLoading order by dh desc";
                                OleDbCommand command2 = new OleDbCommand(str2, connection2);
                                OleDbDataReader reader2 = null;
                                connection2.Open();
                                reader2 = command2.ExecuteReader();
                                if (reader2.Read())
                                {
                                    num2 = Convert.ToInt64(reader2["dh"]) + 1L;
                                }
                                else
                                {
                                    num2 = 0L;
                                }
                                reader2.Close();
                                connection2.Close();
                                this.PreKey = num2;
                                num = this.PreKey + this.waitKey;
                                this.waitKey++;
                            }
                            Console.Write("\nwaitKey,PreKey,key:  " + this.waitKey.ToString() + "|" + this.PreKey.ToString() + "|" + num.ToString() + "\n\n");
                            _fileinfo _fileinfo = new _fileinfo {
                                isContinue = 0,
                                BlockDownloadSize_init = new long[5],
                                BlockDownloadSize_Abs = new long[5],
                                frontSize = new long[5],
                                SplitInfo = new string[5],
                                ns = new Stream[5],
                                fs = new FileStream[5],
                                FilePath = OutputLogin.DownloadUrl + "/" + Outputkey + "/" + strArray[2],
                                FileName = strArray[2],
                                FileSize = Convert.ToInt64(strArray[3]),
                                FileId = strArray[10]
                            };
                            string str3 = "1";
                            try
                            {
                                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
                                if (key != null)
                                {
                                    if (key.GetValue("ViewOrderCode") != null)
                                    {
                                        str3 = key.GetValue("ViewOrderCode").ToString();
                                    }
                                    else
                                    {
                                        key.SetValue("ViewOrderCode", "0");
                                    }
                                }
                            }
                            catch (Exception exception)
                            {
                                this.ePrintLog.WriteLog(exception.ToString());
                            }
                            fileinfo[0] = _fileinfo.FilePath;
                            fileinfo[1] = _fileinfo.FileName;
                            fileinfo[2] = _fileinfo.FileSize.ToString();
                            fileinfo[3] = strArray[1];
                            if (str3 == "1")
                            {
                                fileinfo[4] = "(" + strArray[1] + ")" + strArray[4];
                            }
                            else
                            {
                                fileinfo[4] = strArray[4];
                            }
                            fileinfo[5] = strArray[5];
                            fileinfo[6] = strArray[6];
                            fileinfo[7] = strArray[7];
                            fileinfo[8] = strArray[9] + "," + strArray[12] + "," + strArray[13];
                            fileinfo[9] = strArray[8];
                            fileinfo[10] = num.ToString();
                            fileinfo[11] = strArray[10];
                            fileinfo[12] = strArray[11];
                            if (strArray[11] != "")
                            {
                                _fileinfo.OrderInfo = strArray[11];
                            }
                            else
                            {
                                _fileinfo.OrderInfo = fileinfo[8];
                            }
                            try
                            {
                                if (this.isReceive(fileinfo[11]))
                                {
                                    this.HtrecInfo.Remove(str);
                                    Console.WriteLine("HashTable(HtrecInfo) Remove: {0}", str);
                                    Console.WriteLine("HashTable(HtrecInfo) Count: {0}", this.HtrecInfo.Count);
                                }
                            }
                            catch
                            {
                            }
                            Console.Write("\n网上ID号：" + strArray[10] + "\n");
                            this.getFileSavePath(_fileinfo, fileinfo[4], Convert.ToInt16(_fileinfo.OrderInfo.Substring(0, 1)));
                            this.insertDate(isAutoDown, fileinfo, _fileinfo);
                        }
                        else if (this.isReceive(strArray[10]))
                        {
                            this.HtrecInfo.Remove(str);
                            Console.WriteLine("HashTable(HtrecInfo) Remove: {0}", str);
                            Console.WriteLine("HashTable(HtrecInfo) Count: {0}", this.HtrecInfo.Count);
                        }
                    }
                }
                else if (strArray[0] == "SocketKey")
                {
                    this.SocketKey = strArray[1];
                    MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
                    byte[] bytes = Encoding.Default.GetBytes(this.SocketKey + Outputkey);
                    string str4 = Encoding.Default.GetString(provider.ComputeHash(bytes));
                    byte[] buffer = Encoding.UTF8.GetBytes("OutputKey|" + this.SocketKey + "|" + Outputkey + "|" + str4);
                    this.ClientSocket.Send(buffer);
                    this.ePrintLog.WriteLog("接收连接标识：[" + strArray[0] + "][" + strArray[1] + "]");
                    this.ePrintLog.WriteLog("确认标识：[OutputKey][" + this.SocketKey + "][" + Outputkey + "][md5key][" + str4 + "]");
                }
                else if (strArray[0] == "Systemgg")
                {
                    this.ePrintLog.WriteLog("收到平台公告:" + strArray[1]);
                    new ePrintNotice { NoticeInfo = strArray[1] }.ShowDialog(this.listView1);
                }
                else if (strArray[0] == "jjtz")
                {
                    this.ePrintLog.WriteLog("收到紧急通知:" + strArray[1]);
                    MessageBox.Show(this, strArray[1], "紧急通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!(strArray[0] == "gg") && (strArray[0] == "LogOff"))
                {
                    this.pauseget();
                    this.ePrintLog.WriteLog("您正在脱机工作:" + strArray[1]);
                    MessageBox.Show(this, strArray[1], "注意：您正在脱机工作", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception2)
            {
                this.ePrintLog.WriteLog("订单接收格式有错误: \r\n" + str + "\r\n" + exception2.ToString() + "\n");
            }
        }

        public static string dowithString(string strString)
        {
            return strString.Trim().Replace("'", "''").Replace("&", "＆").Replace("#", "＃").Replace("%", "％").Replace("+", "＋").Replace(",", "，").Replace(" ", "");
        }

        private void downedMuDel()
        {
            if (this.glacialList2.Items.Count > 0)
            {
                int[] orderId = new int[1];
                int index = 0;
                string str = "";
                string[] fileName = new string[] { "" };
                for (int i = 0; i < this.glacialList2.Items.Count; i++)
                {
                    if (this.glacialList2.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList2.Items[i].Tag;
                        orderId[index] = Convert.ToInt32(tag.FileId);
                        fileName[index] = tag.FileName;
                        str = str + tag.orderkey.ToString() + ",";
                        index++;
                        break;
                    }
                }
                foreach (GLItem item in this.glacialList2.SelectedItems)
                {
                    this.glacialList2.Items.Remove(item);
                }
                this.glacialList2.Refresh();
                if (this.isDelServer)
                {
                    try
                    {
                        new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._delOrder(Convert.ToInt16(Outputkey), orderId, fileName);
                    }
                    catch (Exception exception)
                    {
                        this.ePrintLog.WriteLog("删除订单出错3：" + exception.ToString());
                    }
                    Thread.Sleep(100);
                    this.OutputRoomInfo();
                }
                delFile2(str.Remove(str.Length - 1, 1), 1);
                if (this.glacialList3.Items.Count <= 0)
                {
                    this.treeView1.Nodes[0].Nodes[2].ImageIndex = 3;
                    this.treeView1.Nodes[0].Nodes[2].SelectedImageIndex = 3;
                }
                this.getDelData();
            }
        }

        private void downedViewOrderInfo()
        {
            if ((this.glacialList2.Items.Count > 0) && (this.glacialList2.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList2.Items.Count; i++)
                {
                    if (this.glacialList2.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList2.Items[i].Tag;
                        this.viewOrderInfo(tag.OrderInfo);
                        return;
                    }
                }
            }
        }

        public void downFile()
        {
            int num;
            OleDbConnection connection = new OleDbConnection(strCon);
            string cmdText = "select top 1 dh from DownLoading order by dh desc";
            OleDbCommand command = new OleDbCommand(cmdText, connection);
            OleDbDataReader reader = null;
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                num = Convert.ToInt32(reader["dh"]) + 1;
            }
            else
            {
                num = 0;
            }
            reader.Close();
            string strUri = "http://www.eprinting.cn/uploadfiles/1106/aaa.rar";
            string[] fileinfo = new string[11];
            fileinfo[3] = "1000";
            fileinfo[4] = "广州印网科技有限公司";
            fileinfo[5] = "广州市恒福路横枝岗68号三楼";
            fileinfo[6] = "020-83494875";
            fileinfo[7] = "杨先生";
            fileinfo[8] = "PC机，CMY，药膜向上";
            fileinfo[9] = "2004-10-13 13:20:50";
            fileinfo[10] = num.ToString();
            _fileinfo _fileinfo = new _fileinfo {
                orderkey = num
            };
            this.getFileSavePath(_fileinfo, fileinfo[4], Convert.ToInt16(_fileinfo.OrderInfo.Substring(0, 1)));
            ePrintDownGetDate date = new ePrintDownGetDate {
                FileSaveSet = _fileinfo.FileSaveSet
            };
            date.beginGetDate(strUri);
            _fileinfo.FilePath = date.FilePath;
            _fileinfo.FileName = _fileinfo.FilePath.Substring(_fileinfo.FilePath.LastIndexOf("/") + 1);
            _fileinfo.FileSize = date.FileSize;
            fileinfo[0] = _fileinfo.FilePath;
            fileinfo[1] = _fileinfo.FileName;
            fileinfo[2] = _fileinfo.FileSize.ToString();
            this.insertDate(0, fileinfo, _fileinfo);
        }

        private void downingViewOrderInfo()
        {
            if ((this.glacialList1.Items.Count > 0) && (this.glacialList1.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (this.glacialList1.Items[i].Selected && (this.glacialList1.Items[i].Tag != null))
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        this.viewOrderInfo(tag.OrderInfo);
                        this.glacialList1.Tag = tag;
                        return;
                    }
                }
            }
        }

        private void downloadContinue()
        {
            for (int i = 0; i < this.glacialList1.Items.Count; i++)
            {
                if ((this.glacialList1.Items[i].Tag != null) && this.glacialList1.Items[i].Selected)
                {
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = true;
                    _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                    tag.isError = 0;
                    if (this.waitDownload(this.MaxDownNum))
                    {
                        this.downloadContinue2(i, tag);
                        this.ePrintLog.WriteLog("开始续下操作(" + tag.FileName + ")...");
                        return;
                    }
                    this.glacialList1.Items[i].SubItems[0].ImageIndex = 15;
                    this.ePrintLog.WriteLog("队列已满,排队等候(" + tag.FileName + ")...");
                    return;
                }
            }
        }

        private void downloadContinue2(int i, _fileinfo __myfileinfo)
        {
            __myfileinfo.isContinue = 1;
            __myfileinfo.BlockDownloadSize_init = new long[5];
            __myfileinfo.BlockDownloadSize_Abs = new long[5];
            __myfileinfo.frontSize = new long[5];
            __myfileinfo.SplitInfo = new string[5];
            __myfileinfo.ns = new Stream[5];
            __myfileinfo.fs = new FileStream[5];
            string path = null;
            OleDbConnection connection = new OleDbConnection(strCon);
            OleDbCommand command = new OleDbCommand();
            OleDbDataReader reader = null;
            string str2 = "select FileId,FileName,FilePath,FileSize,EndSize,OrderInfo,SaveFilePath,ZipInfo from DownLoading where dh=" + __myfileinfo.orderkey;
            command.CommandText = str2;
            command.Connection = connection;
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                __myfileinfo.FileName = reader["FileName"].ToString();
                __myfileinfo.FilePath = reader["FilePath"].ToString();
                __myfileinfo.FileSize = Convert.ToInt64(reader["FileSize"].ToString());
                if (reader["ZipInfo"].ToString() != "")
                {
                    __myfileinfo.OrderInfo = reader["ZipInfo"].ToString();
                }
                else
                {
                    __myfileinfo.OrderInfo = reader["OrderInfo"].ToString();
                }
                __myfileinfo.FileId = reader["FileId"].ToString();
                path = reader["SaveFilePath"].ToString();
            }
            reader.Close();
            try
            {
                FileStream stream = File.Open(reader["SaveFilePath"].ToString(), FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                __myfileinfo.DownloadedSize_initialize = stream.Length;
                stream.Close();
            }
            catch
            {
            }
            this.getFileSavePath(__myfileinfo, this.glacialList1.Items[i].SubItems[10].Text.Trim().ToString(), Convert.ToInt16(__myfileinfo.OrderInfo.Substring(0, 1)));
            if (!File.Exists(path))
            {
                if (this.GetFreeRomm(FileSavePath) >= __myfileinfo.FileSize)
                {
                    string str3 = path;
                    FileStream stream2 = new FileStream(str3, FileMode.Create);
                    if (__myfileinfo.FileSize > 0L)
                    {
                        stream2.Seek(__myfileinfo.FileSize - 1L, SeekOrigin.Current);
                    }
                    byte[] buffer1 = new byte[1];
                    stream2.Close();
                }
                else
                {
                    MessageBox.Show("空间不足，请删除一部分文件！");
                }
            }
            this.OneDown(__myfileinfo.FileSaveSet, __myfileinfo.FileName, __myfileinfo.FilePath, __myfileinfo);
            this.glacialList1.Items[i].SubItems[0].ImageIndex = 0;
        }

        private void downloadDel()
        {
            if (this.whichlistView == 0)
            {
                this.ePrintLog.WriteLog("删除'正在下载列表'中的文件 ");
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (this.glacialList1.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        delFile(tag, 0);
                        if ((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4))
                        {
                            if (MessageBox.Show("此文件正在下载中,确定要删除吗?", "易印3.2", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.downloadStop();
                                this.glacialList1.Items.Remove(i);
                                this.glacialList1.Refresh();
                                this.getDelData();
                            }
                        }
                        else
                        {
                            this.glacialList1.Items.Remove(i);
                            this.glacialList1.Refresh();
                            this.getDelData();
                        }
                        if (this.glacialList3.Items.Count <= 0)
                        {
                            this.treeView1.Nodes[0].Nodes[2].ImageIndex = 3;
                            this.treeView1.Nodes[0].Nodes[2].SelectedImageIndex = 3;
                        }
                        break;
                    }
                }
            }
            if (this.whichlistView == 1)
            {
                this.ePrintLog.WriteLog("删除下载完成列表'中的文件 ");
                new Thread(new ThreadStart(this.downedMuDel)) { Name = "downedMuDel" }.Start();
            }
            if (this.whichlistView == 2)
            {
                this.ePrintLog.WriteLog("删除'已删除列表'中的文件 ");
                new Thread(new ThreadStart(this.deledMuDel)) { Name = "downedMuDel" }.Start();
            }
            this.toolBarButton1.Enabled = false;
            this.toolBarButton2.Enabled = false;
            this.toolBarButton3.Enabled = false;
            this.toolBarButton4.Enabled = false;
            this.toolBarButton5.Enabled = false;
        }

        private void downloadStop()
        {
            for (int i = 0; i < this.glacialList1.Items.Count; i++)
            {
                if (this.glacialList1.Items[i].Selected)
                {
                    _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                    try
                    {
                        this.glacialList1.Items[i].SubItems[9].Text = "0/1";
                        this.glacialList1.Items[i].SubItems[0].ImageIndex = 1;
                        tag.ns2.Close();
                        tag.fs2.Close();
                    }
                    catch
                    {
                    }
                    break;
                }
            }
        }

        private void downloadStop2(int i, _fileinfo __myfileinfo)
        {
            __myfileinfo.DownloadedSize_absoluteness = 0L;
            __myfileinfo.DownloadedSize_relatively = 0L;
            __myfileinfo.Speed = 0.0;
            for (int j = 0; j < 5; j++)
            {
                if (__myfileinfo.BlockDownloadSize_Abs[j] > __myfileinfo.frontSize[j])
                {
                    if (j == 4)
                    {
                        __myfileinfo.DownloadedSize_absoluteness += __myfileinfo.BlockDownloadSize_Abs[j] - __myfileinfo.frontSize[j];
                    }
                    else if (__myfileinfo.BlockDownloadSize_Abs[j] > __myfileinfo.frontSize[j + 1])
                    {
                        __myfileinfo.DownloadedSize_absoluteness += __myfileinfo.frontSize[j + 1] - __myfileinfo.frontSize[j];
                    }
                    else
                    {
                        __myfileinfo.DownloadedSize_absoluteness += __myfileinfo.BlockDownloadSize_Abs[j] - __myfileinfo.frontSize[j];
                    }
                }
                else if (__myfileinfo.isContinue == 1)
                {
                    try
                    {
                        __myfileinfo.DownloadedSize_absoluteness += __myfileinfo.BlockDownloadSize_init[i] - __myfileinfo.frontSize[i];
                    }
                    catch (Exception exception)
                    {
                        this.ePrintLog.WriteLog("计算已下载文件大小时出错: " + exception.ToString());
                    }
                }
            }
            for (int k = 0; k < 5; k++)
            {
                if (__myfileinfo.BlockDownloadSize_Abs[k] > __myfileinfo.BlockDownloadSize_init[k])
                {
                    if (k == 4)
                    {
                        __myfileinfo.DownloadedSize_relatively += __myfileinfo.BlockDownloadSize_Abs[k] - __myfileinfo.BlockDownloadSize_init[k];
                    }
                    else if (__myfileinfo.BlockDownloadSize_Abs[k] > __myfileinfo.BlockDownloadSize_init[k + 1])
                    {
                        __myfileinfo.DownloadedSize_relatively += __myfileinfo.BlockDownloadSize_init[k + 1] - __myfileinfo.BlockDownloadSize_init[k];
                    }
                    else
                    {
                        __myfileinfo.DownloadedSize_relatively += __myfileinfo.BlockDownloadSize_Abs[k] - __myfileinfo.BlockDownloadSize_init[k];
                    }
                }
            }
            StopDown(__myfileinfo);
            this.editSplitData(__myfileinfo);
            __myfileinfo.splitedNum = 0;
            this.glacialList1.Items[i].SubItems[9].Text = "0/5";
            this.glacialList1.Items[i].SubItems[0].ImageIndex = 1;
            if (__myfileinfo.DownloadedSize_absoluteness <= __myfileinfo.FileSize)
            {
                this.glacialList1.Items[i].SubItems[4].Text = this.sizeChange(__myfileinfo.DownloadedSize_absoluteness);
                this.glacialList1.Items[i].SubItems[5].Text = Convert.ToString(Math.Round((double) ((Convert.ToDouble(__myfileinfo.DownloadedSize_absoluteness) / Convert.ToDouble(__myfileinfo.FileSize)) * 100.0), 2)) + "%";
            }
            else
            {
                this.glacialList1.Items[i].SubItems[4].Text = this.sizeChange(__myfileinfo.FileSize);
                this.glacialList1.Items[i].SubItems[5].Text = "100%";
            }
            __myfileinfo.Speed = (Convert.ToDouble(__myfileinfo.DownloadedSize_relatively) / Convert.ToDouble((int) (__myfileinfo.time / 2))) / 1024.0;
            string str = Convert.ToString(Math.Round(__myfileinfo.Speed, 2));
            if ((str.IndexOf("非数字") < 0) && (str.IndexOf("无穷大") < 0))
            {
                this.glacialList1.Items[i].SubItems[8].Text = str + "K/S";
            }
            this.glacialList1.Refresh();
            this.toolBarButton1.Enabled = true;
            this.toolBarButton2.Enabled = false;
            if (this.waitDownload(this.MaxDownNum))
            {
                this.downNext();
            }
            this.addInfo(1, __myfileinfo, 5, "暂停在 ");
        }

        private void downNext()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (this.glacialList1.Items[i].SubItems[0].ImageIndex == 15)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        this.downloadContinue2(i, tag);
                        return;
                    }
                }
            }
        }

        private void editBulletin()
        {
            if ((this.listView8.Items.Count > 0) && (this.listView8.SelectedItems.Count > 0))
            {
                new ePrintOrderManager.editBulletin { ID = Convert.ToInt32(this.listView8.SelectedItems[0].Tag.ToString()), strTitle = this.textBox6.Text.Trim(), strContent = this.textBox4.Text.Trim() }.ShowDialog();
            }
        }

        private void editData(_fileinfo __myfileinfo)
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            connection.Open();
            new OleDbCommand(string.Concat(new object[] { "update DownLoading set isWhich=1,DownedTime='", DateTime.Now, "' where dh=", __myfileinfo.orderkey }), connection).ExecuteNonQuery();
            connection.Close();
        }

        private void editFileSavePath(long key, string strPath)
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            connection.Open();
            new OleDbCommand(string.Concat(new object[] { "update DownLoading set SaveFilePath='", strPath, "' where dh=", key }), connection).ExecuteNonQuery();
            connection.Close();
        }

        private void editSplitData(_fileinfo __myfileinfo)
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            for (int i = 0; i < 5; i++)
            {
                if (__myfileinfo.BlockDownloadSize_Abs[i] > __myfileinfo.BlockDownloadSize_init[i])
                {
                    string str = string.Concat(new object[] { "update DownLoading2 set StartSize = ", __myfileinfo.BlockDownloadSize_Abs[i], " where ID2 = ", __myfileinfo.orderkey, " and Which = ", i });
                    command.Connection = connection;
                    command.CommandText = str;
                    command.ExecuteNonQuery();
                }
            }
            string str2 = string.Concat(new object[] { "update DownLoading set EndSize=", __myfileinfo.DownloadedSize_absoluteness, " where dh=", __myfileinfo.orderkey });
            command.Connection = connection;
            command.CommandText = str2;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ePrintConnect()
        {
            this.ePrintLog.WriteLog("开始连接服务器...");
            try
            {
                this.ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.ClientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, 30);
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(OutputLogin.ServerIP), OutputLogin.ServerPort);
                this.ClientSocket.BeginConnect(remoteEP, new AsyncCallback(this.ePrintEndConnect), this.ClientSocket);
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("连接服务器出错: " + exception.ToString());
            }
        }

        private void ePrintEndConnect(IAsyncResult connectState)
        {
            try
            {
                this.ClientSocket = (Socket) connectState.AsyncState;
                this.ClientSocket.EndConnect(connectState);
                if (this.ClientSocket.Connected)
                {
                    this.ePrintLog.WriteLog("连接服务器成功,开始接收订单...");
                    this.isStop = 0;
                    Icon icon = new Icon(OutputLogin.SetupPath + @"\ico\online.ico");
                    this.statusBarPanel2.Icon = icon;
                    this.statusBarPanel2.Text = "接收中...";
                    this.ePrintReceive();
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void ePrintMain_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            base.WindowState = FormWindowState.Minimized;
            base.ShowInTaskbar = false;
            base.Hide();
        }

        private void ePrintMain_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.getOrderInfoFont)) { Name = "_getOrderInfo" }.Start();
            new Thread(new ThreadStart(this.GetUserLevel)) { Name = "GetUserLevel" }.Start();
            this.getSystemInfo();
            new Thread(new ThreadStart(this.getBeginData)) { Name = "getBeginData" }.Start();
            new Thread(new ThreadStart(this.getOutputUser)) { Name = "getOutputUser" }.Start();
            new Thread(new ThreadStart(this.getUserFiles)) { Name = "getUserFiles" }.Start();
            new Thread(new ThreadStart(this.OutputRoomInfo)) { Name = "OutputRoomInfo" }.Start();
            new Thread(new ThreadStart(this.ListLogFiles)) { Name = "ListLogFiles" }.Start();
            new Thread(new ThreadStart(this.getOutputStatement)) { Name = "getOutputStatement" }.Start();
            new Thread(new ThreadStart(this.getOutputBulletin)) { Name = "getOutputBulletin" }.Start();
            new Thread(new ThreadStart(this._getOutputNetInfo)) { Name = "_getOutputNetInfo" }.Start();
            new Thread(new ThreadStart(this.UpdateCheck)) { Name = "_UpdateCheck" }.Start();
            Console.WriteLine("UpdateCheck");
            this.initpanels();
        }

        private void ePrintMain_SizeChanged(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Maximized)
            {
                base.ShowInTaskbar = true;
                this.treeView1.ExpandAll();
                base.Show();
            }
        }

        private void ePrintReadData(IAsyncResult readState)
        {
            try
            {
                this.ClientSocket = (Socket) readState.AsyncState;
                if ((this.ClientSocket != null) && (this.isStop != 1))
                {
                    int count = this.ClientSocket.EndReceive(readState);
                    if (count > 0)
                    {
                        this.ReceiveInfo = this.ReceiveInfo + Encoding.UTF8.GetString(this.ReceiveBuffer, 0, count);
                    }
                    if (count < this.ReceiveBuffer.Length)
                    {
                        Console.Write("\n-------------\n收到总的信息:" + this.ReceiveInfo + "\n-------------\n");
                        if (this.ReceiveInfo.IndexOf("/") >= 0)
                        {
                            new Thread(new ThreadStart(this.OutputRoomInfo)) { Name = "OutputRoomInfo" }.Start();
                            string[] strArray = this.ReceiveInfo.Split(new char[] { '/' });
                            for (int i = 0; i < (strArray.Length - 1); i++)
                            {
                                this._ReceiveInfo = strArray[i];
                                new Thread(new ThreadStart(this.dowith)) { Name = "dowith" }.Start();
                                Thread.Sleep(0x3e8);
                            }
                        }
                        else
                        {
                            this._ReceiveInfo = this.ReceiveInfo;
                            new Thread(new ThreadStart(this.dowith)) { Name = "dowith" }.Start();
                        }
                    }
                    if (this.isStop == 0)
                    {
                        this.ePrintReceive();
                    }
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void ePrintReceive()
        {
            try
            {
                this.ClientSocket.BeginReceive(this.ReceiveBuffer, 0, this.ReceiveBuffer.Length, SocketFlags.None, new AsyncCallback(this.ePrintReadData), this.ClientSocket);
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void ExitSystem()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4)) || ((this.glacialList1.Items[i].SubItems[0].ImageIndex == 10) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 15)))
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        if (!this.button3.Visible)
                        {
                            this.button3.Visible = true;
                            this.button3.BringToFront();
                        }
                        this.ExitSystemSave1(tag);
                    }
                    this.closetime++;
                }
                if (this.closetime == this.glacialList1.Items.Count)
                {
                    Application.Exit();
                    base.Dispose();
                    base.Close();
                }
            }
            else
            {
                this.ePrintLog.WriteLog("退出系统");
                Application.Exit();
                base.Dispose();
                base.Close();
            }
        }

        private void ExitSystemSave1(_fileinfo __myfileinfo)
        {
            if (__myfileinfo == null)
            {
                this.ePrintLog.WriteLog("准备关闭文件流,但__myfileinfo ==null");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        if (__myfileinfo.ns[i] != null)
                        {
                            __myfileinfo.ns[i].Close();
                        }
                        if (__myfileinfo.fs[i] != null)
                        {
                            __myfileinfo.fs[i].Close();
                        }
                    }
                    catch (Exception exception)
                    {
                        this.ePrintLog.WriteLog("关闭文件流时出错: " + exception.ToString());
                    }
                }
                this.ExitSystemSave2(__myfileinfo);
            }
        }

        private void ExitSystemSave2(_fileinfo __myfileinfo)
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            for (int i = 0; i < 5; i++)
            {
                if (__myfileinfo.BlockDownloadSize_Abs[i] > __myfileinfo.BlockDownloadSize_init[i])
                {
                    string str = string.Concat(new object[] { "update DownLoading2 set StartSize = ", __myfileinfo.BlockDownloadSize_Abs[i], " where ID2 = ", __myfileinfo.orderkey, " and Which = ", i });
                    command.Connection = connection;
                    command.CommandText = str;
                    command.ExecuteNonQuery();
                }
            }
            string str2 = string.Concat(new object[] { "update DownLoading set EndSize=", __myfileinfo.DownloadedSize_absoluteness, " where dh=", __myfileinfo.orderkey });
            command.Connection = connection;
            command.CommandText = str2;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void fileSaveAs()
        {
            if ((this.glacialList2.Items.Count > 0) && (this.glacialList2.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList2.Items.Count; i++)
                {
                    if (this.glacialList2.Items[i].Selected)
                    {
                        string text = this.glacialList2.Items[i].SubItems[7].Text;
                        string str2 = this.glacialList2.Items[i].SubItems[2].Text;
                        this.saveFileDialog2.FileName = str2;
                        if (this.saveFileDialog2.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                File.Copy(text, this.saveFileDialog2.FileName, true);
                            }
                            catch (Exception exception)
                            {
                                this.ePrintLog.WriteLog("文件另存为出错：" + exception.ToString());
                            }
                        }
                        return;
                    }
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        private void Ftp_GetDiskPath()
        {
            string[] logicalDrives = Directory.GetLogicalDrives();
            for (int i = 0; i < logicalDrives.Length; i++)
            {
                this.comboBox1.Items.Add(logicalDrives[i]);
            }
        }

        private void getBeginData()
        {
            this.treeView1.ExpandAll();
            this.treeView2.ExpandAll();
            this.glacialList1.BringToFront();
            this.glacialList5.BringToFront();
            this.getDowningData();
            this.getDownedData();
            this.getDelData();
            this.getCancelData();
            this.Ftp_GetDiskPath();
        }

        private void getCancelData()
        {
            this.glacialList4.Items.Clear();
            OleDbConnection connection = new OleDbConnection(strCon);
            
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("系统没有安装OLE驱动。");
                Application.Exit();
                this.Close();
                return;
            }
            string cmdText = "select dh,FileId,State,OrderCode,FileName,FileSize,CompanyName,OrderTime,OrderInfo,ZipInfo from DownLoading  where isWhich=3 order by ID desc";
            OleDbCommand command = new OleDbCommand(cmdText, connection);
            OleDbDataReader reader = null;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int num;
                GLItem item = new GLItem();
                _fileinfo _fileinfo = new _fileinfo {
                    orderkey = Convert.ToInt32(reader["dh"].ToString()),
                    FileSize = Convert.ToInt64(reader["FileSize"].ToString()),
                    FileId = reader["FileId"].ToString(),
                    FileName = reader["FileName"].ToString()
                };
                if (reader["ZipInfo"].ToString() != "")
                {
                    _fileinfo.OrderInfo = reader["ZipInfo"].ToString();
                }
                else
                {
                    _fileinfo.OrderInfo = reader["OrderInfo"].ToString();
                }
                this.treeView1.Nodes[0].Nodes[2].ImageIndex = 4;
                this.treeView1.Nodes[0].Nodes[2].SelectedImageIndex = 4;
                if (Convert.ToInt16(reader["State"].ToString()) == 0)
                {
                    num = 10;
                }
                else
                {
                    num = Convert.ToInt16(reader["State"].ToString()) + 1;
                }
                item.SubItems[0].ImageIndex = num;
                item.SubItems[1].Text = reader["OrderCode"].ToString();
                item.SubItems[2].Text = reader["FileName"].ToString();
                item.SubItems[3].Text = this.sizeChange(Convert.ToInt64(reader["FileSize"].ToString()));
                item.SubItems[4].Text = reader["CompanyName"].ToString();
                item.SubItems[5].Text = reader["OrderTime"].ToString();
                item.Tag = _fileinfo;
                this.glacialList4.Items.Add(item);
            }
            reader.Close();
            connection.Close();
        }

        private void getDelData()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
            if ((key != null) && (key.GetValue("DeletedList") != null))
            {
                string[] strArray = key.GetValue("DeletedList").ToString().Split(new char[] { '|' });
                if (strArray[0] == "1")
                {
                    int num = Convert.ToInt32(strArray[1]);
                    OleDbConnection connection = new OleDbConnection(strCon);
                    connection.Open();
                    new OleDbCommand("delete from DownLoading where id not in (select top " + num + " ID from DownLoading where isWhich=2 order by id desc) and isWhich=2", connection).ExecuteNonQuery();
                    connection.Close();
                }
                else if (strArray[0] == "3")
                {
                    int num2 = Convert.ToInt32(strArray[1]);
                    DateTime time = DateTime.Now.AddDays((double) -num2);
                    OleDbConnection connection2 = new OleDbConnection(strCon);
                    connection2.Open();
                    new OleDbCommand("delete from DownLoading where OrderTime>'" + time + "' and  isWhich=2", connection2).ExecuteNonQuery();
                    connection2.Close();
                }
            }
            this.glacialList3.Items.Clear();
            OleDbConnection connection3 = new OleDbConnection(strCon);
           
            try
            {
                connection3.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("系统没有安装OLE驱动。");
                Application.Exit();
                this.Close();
                return;
            }
            string cmdText = "select dh,FileId,State,OrderCode,FileName,FileSize,DelTime,CompanyName,OrderTime,SaveFilePath,OrderInfo,ZipInfo from DownLoading  where isWhich=2 order by DelTime desc";
            OleDbCommand command3 = new OleDbCommand(cmdText, connection3);
            OleDbDataReader reader = null;
            reader = command3.ExecuteReader();
            int num3 = 0;
            while (reader.Read())
            {
                int num4;
                GLItem item = new GLItem();
                _fileinfo _fileinfo = new _fileinfo {
                    orderkey = Convert.ToInt32(reader["dh"].ToString()),
                    FileId = reader["FileId"].ToString(),
                    FileName = reader["FileName"].ToString()
                };
                if (reader["ZipInfo"].ToString() != "")
                {
                    _fileinfo.OrderInfo = reader["ZipInfo"].ToString();
                }
                else
                {
                    _fileinfo.OrderInfo = reader["OrderInfo"].ToString();
                }
                if (Convert.ToInt16(reader["State"].ToString()) == 0)
                {
                    num4 = 1;
                }
                else
                {
                    num4 = Convert.ToInt16(reader["State"].ToString());
                }
                item.SubItems[0].ImageIndex = num4;
                item.SubItems[1].Text = reader["OrderCode"].ToString();
                item.SubItems[2].Text = reader["FileName"].ToString();
                item.SubItems[3].Text = this.sizeChange(Convert.ToInt64(reader["FileSize"].ToString()));
                item.SubItems[4].Text = reader["DelTime"].ToString();
                item.SubItems[5].Text = reader["CompanyName"].ToString();
                item.SubItems[6].Text = reader["OrderTime"].ToString();
                item.SubItems[7].Text = reader["SaveFilePath"].ToString();
                item.Tag = _fileinfo;
                this.glacialList3.Items.Add(item);
                num3++;
            }
            reader.Close();
            connection3.Close();
            if (num3 > 0)
            {
                this.treeView1.Nodes[0].Nodes[2].ImageIndex = 4;
                this.treeView1.Nodes[0].Nodes[2].SelectedImageIndex = 4;
            }
        }

        [DllImport("kernel32.dll")]
        public static extern int GetDiskFreeSpace(string lpRootPathName, ref long lpSectorsPerCluster, ref long lpBytesPerSector, ref long lpNumberOfFreeClusters, ref long lpTotalNumberOfClusters);
        private void getDownedData()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
            if (key != null)
            {
                if (key.GetValue("DownLoadedList") != null)
                {
                    string[] strArray = key.GetValue("DownLoadedList").ToString().Split(new char[] { '|' });
                    if (strArray[0] == "1")
                    {
                        int num = Convert.ToInt32(strArray[1]);
                        OleDbConnection connection = new OleDbConnection(strCon);
                        int num2 = 0;
                        OleDbCommand command = new OleDbCommand("select Count(ID) as delFileNum from DownLoading where id not in (select top " + num + " ID from DownLoading where isWhich=1 order by id desc) and isWhich=1", connection);
                        OleDbDataReader reader = null;
                        connection.Open();
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            num2 = Convert.ToInt32(reader["delFileNum"].ToString());
                        }
                        reader.Close();
                        connection.Close();
                        if (num2 > 0)
                        {
                            int[] orderId = new int[num2];
                            string[] fileName = new string[num2];
                            OleDbCommand command2 = new OleDbCommand("select FileId,FileName from DownLoading where id not in (select top " + num + " ID from DownLoading where isWhich=1 order by id desc) and isWhich=1", connection);
                            OleDbDataReader reader2 = null;
                            connection.Open();
                            reader2 = command2.ExecuteReader();
                            for (int j = 0; reader2.Read(); j++)
                            {
                                orderId[j] = Convert.ToInt32(reader2["FileId"].ToString());
                                fileName[j] = reader2["FileName"].ToString();
                            }
                            reader2.Close();
                            connection.Close();
                            try
                            {
                                new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._delOrder(Convert.ToInt32(Outputkey), orderId, fileName);
                            }
                            catch (Exception exception)
                            {
                                this.ePrintLog.WriteLog("删除订单出错：" + exception.ToString());
                            }
                            Thread.Sleep(100);
                            this.OutputRoomInfo();
                            connection.Open();
                            new OleDbCommand("delete from DownLoading where id not in (select top " + num + " ID from DownLoading where isWhich=1 order by id desc) and isWhich=1", connection).ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    else if (strArray[0] == "3")
                    {
                        int num4 = Convert.ToInt32(strArray[1]);
                        DateTime time = DateTime.Now.AddDays((double) -num4);
                        OleDbConnection connection2 = new OleDbConnection(strCon);
                        int num5 = 0;
                        OleDbCommand command4 = new OleDbCommand("select Count(ID) as delFileNum from DownLoading where OrderTime<'" + time + "' and isWhich=1", connection2);
                        OleDbDataReader reader3 = null;
                        connection2.Open();
                        reader3 = command4.ExecuteReader();
                        if (reader3.Read())
                        {
                            num5 = Convert.ToInt32(reader3["delFileNum"].ToString());
                        }
                        reader3.Close();
                        connection2.Close();
                        if (num5 > 0)
                        {
                            int[] numArray2 = new int[num5];
                            string[] strArray3 = new string[num5];
                            OleDbCommand command5 = new OleDbCommand("select FileId,FileName from DownLoading where OrderTime<'" + time + "' and isWhich=1", connection2);
                            OleDbDataReader reader4 = null;
                            connection2.Open();
                            reader4 = command5.ExecuteReader();
                            for (int k = 0; reader4.Read(); k++)
                            {
                                numArray2[k] = Convert.ToInt32(reader4["FileId"].ToString());
                                strArray3[k] = reader4["FileName"].ToString();
                            }
                            reader4.Close();
                            connection2.Close();
                            try
                            {
                                new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._delOrder(Convert.ToInt32(Outputkey), numArray2, strArray3);
                            }
                            catch (Exception exception2)
                            {
                                this.ePrintLog.WriteLog("删除订单出错2：" + exception2.ToString());
                            }
                            Thread.Sleep(100);
                            this.OutputRoomInfo();
                            connection2.Open();
                            new OleDbCommand("delete from DownLoading where OrderTime<'" + time + "' and isWhich=1", connection2).ExecuteNonQuery();
                            connection2.Close();
                        }
                    }
                }
                this.glacialList2.Items.Clear();
                OleDbConnection connection3 = new OleDbConnection(strCon);
                try
                {
                    connection3.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("系统没有安装OLE驱动。");
                    Application.Exit();
                    this.Close();
                    return;
                }
                string cmdText = "select dh,FileId,OrderCode,FileName,FileSize,DownedTime,CompanyName,OrderTime,SaveFilePath,OrderInfo,ZipInfo from DownLoading  where isWhich=1 order by DownedTime desc";
                OleDbCommand command7 = new OleDbCommand(cmdText, connection3);
                OleDbDataReader reader5 = null;
                reader5 = command7.ExecuteReader();
                for (int i = 0; reader5.Read(); i++)
                {
                    GLItem item = new GLItem();
                    _fileinfo _fileinfo = new _fileinfo();
                    if (reader5["ZipInfo"].ToString() != "")
                    {
                        _fileinfo.OrderInfo = reader5["ZipInfo"].ToString();
                    }
                    else
                    {
                        _fileinfo.OrderInfo = reader5["OrderInfo"].ToString();
                    }
                    item.SubItems[0].ImageIndex = 2;
                    item.SubItems[1].Text = reader5["OrderCode"].ToString();
                    item.SubItems[2].Text = reader5["FileName"].ToString();
                    item.SubItems[3].Text = this.sizeChange(Convert.ToInt64(reader5["FileSize"].ToString()));
                    item.SubItems[4].Text = reader5["DownedTime"].ToString();
                    item.SubItems[5].Text = reader5["CompanyName"].ToString();
                    item.SubItems[6].Text = reader5["OrderTime"].ToString();
                    item.SubItems[7].Text = reader5["SaveFilePath"].ToString();
                    _fileinfo.orderkey = Convert.ToInt32(reader5["dh"].ToString());
                    _fileinfo.FileId = reader5["FileId"].ToString();
                    _fileinfo.FileName = reader5["FileName"].ToString();
                    _fileinfo.FileSaveSet = reader5["SaveFilePath"].ToString();
                    item.Tag = _fileinfo;
                    this.glacialList2.Items.Add(item);
                }
                this.glacialList2.Refresh();
                reader5.Close();
                connection3.Close();
            }
        }

        private void getDowningData()
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("系统没有安装OLE驱动。");
                Application.Exit();
                this.Close();
                return;
            }


            string cmdText = "select dh,FileId,State,OrderCode,FileName,FileSize,EndSize,CompanyName,OrderTime,OrderInfo,ZipInfo,SaveFilePath from DownLoading  where isWhich=0 order by id asc";
            OleDbCommand command = new OleDbCommand(cmdText, connection);
            OleDbDataReader reader = null;
            reader = command.ExecuteReader();
            this.glacialList1.BeginUpdate();
            while (reader.Read())
            {
                int num;
                if (Convert.ToInt16(reader["State"].ToString()) == 0)
                {
                    num = 1;
                }
                else
                {
                    num = Convert.ToInt16(reader["State"].ToString());
                }
                GLItem item = new GLItem();
                _fileinfo _fileinfo = new _fileinfo();
                myprogress myprogress = new myprogress {
                    Tag = _fileinfo
                };
                _fileinfo.SplitInfo = new string[5];
                _fileinfo.frontSize = new long[5];
                try
                {
                    FileStream stream = File.Open(reader["SaveFilePath"].ToString(), FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    _fileinfo.DownloadedSize_initialize = _fileinfo.DownloadedSize_absoluteness = stream.Length;
                    stream.Close();
                }
                catch
                {
                }
                _fileinfo.orderkey = Convert.ToInt32(reader["dh"].ToString());
                _fileinfo.FileSize = Convert.ToInt64(reader["FileSize"].ToString());
                _fileinfo.FileId = reader["FileId"].ToString();
                _fileinfo.FileName = reader["FileName"].ToString();
                if (reader["ZipInfo"].ToString() != "")
                {
                    _fileinfo.OrderInfo = reader["ZipInfo"].ToString();
                }
                else
                {
                    _fileinfo.OrderInfo = reader["OrderInfo"].ToString();
                }
                item.SubItems[0].ImageIndex = num;
                item.SubItems[1].Text = reader["OrderCode"].ToString();
                item.SubItems[2].Text = reader["FileName"].ToString();
                item.SubItems[3].Text = this.sizeChange(Convert.ToInt64(reader["FileSize"].ToString()));
                item.SubItems[4].Text = this.sizeChange(Convert.ToInt64(reader["EndSize"].ToString()));
                try
                {
                    myprogress.Value = Convert.ToInt16((long) ((_fileinfo.DownloadedSize_absoluteness * 100L) / _fileinfo.FileSize));
                }
                catch
                {
                }
                item.SubItems[6].Text = "00:00:00";
                item.SubItems[7].Text = "";
                item.SubItems[8].Text = "";
                item.SubItems[9].Text = "0/5";
                item.SubItems[10].Text = reader["CompanyName"].ToString();
                item.SubItems[11].Text = reader["OrderTime"].ToString();
                item.Tag = _fileinfo;
                item.SubItems[5].Control = myprogress;
                this.glacialList1.Items.Add(item);
            }
            this.glacialList1.EndUpdate();
            reader.Close();
            connection.Close();
        }

        private void getFileSavePath(_fileinfo __myfileinfo, string CompanyName, int OrderType)
        {
            string str = null;
            if (this.isMutliSystem)
            {
                switch (OrderType)
                {
                    case 0:
                        str = "输出";
                        break;

                    case 1:
                        str = "喷画";
                        break;

                    case 2:
                        str = "传统印刷";
                        break;

                    case 3:
                        str = "数码快印";
                        break;

                    case 4:
                        str = "打样制版";
                        break;
                }
            }
            if (SaveFileType == 0)
            {
                __myfileinfo.FileSaveSet = FileSavePath + @"\" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + @"\" + (this.isMutliSystem ? (str + @"\") : "") + CompanyName;
                if (!Directory.Exists(__myfileinfo.FileSaveSet))
                {
                    Directory.CreateDirectory(__myfileinfo.FileSaveSet);
                    this.editFileSavePath((long) __myfileinfo.orderkey, __myfileinfo.FileSaveSet + @"\" + __myfileinfo.FileName);
                }
            }
            else if (SaveFileType == 1)
            {
                __myfileinfo.FileSaveSet = FileSavePath + (this.isMutliSystem ? (@"\" + str) : "") + @"\" + CompanyName + @"\" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                if (!Directory.Exists(__myfileinfo.FileSaveSet))
                {
                    Directory.CreateDirectory(__myfileinfo.FileSaveSet);
                    this.editFileSavePath((long) __myfileinfo.orderkey, __myfileinfo.FileSaveSet + @"\" + __myfileinfo.FileName);
                }
            }
            else
            {
                __myfileinfo.FileSaveSet = FileSavePath + (this.isMutliSystem ? (@"\" + str) : "");
                this.editFileSavePath((long) __myfileinfo.orderkey, __myfileinfo.FileSaveSet + @"\" + __myfileinfo.FileName);
            }
        }

        private long GetFreeRomm(string RootPathName)
        {
            string lpRootPathName = RootPathName.Substring(0, RootPathName.IndexOf(@"\") + 1);
            long num = 0L;
            long lpSectorsPerCluster = 0L;
            long lpBytesPerSector = 0L;
            long lpNumberOfFreeClusters = 0L;
            long lpTotalNumberOfClusters = 0L;
            if (GetDiskFreeSpace(lpRootPathName, ref lpSectorsPerCluster, ref lpBytesPerSector, ref lpNumberOfFreeClusters, ref lpTotalNumberOfClusters) != 0)
            {
                num = (lpSectorsPerCluster * lpBytesPerSector) * lpNumberOfFreeClusters;
            }
            return num;
        }

        private void getOrderInfoFont()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
            if (key != null)
            {
                if (key.GetValue("MutliSystem") != null)
                {
                    if (key.GetValue("MutliSystem").ToString() == "1")
                    {
                        this.isMutliSystem = true;
                    }
                }
                else
                {
                    key.SetValue("MutliSystem", "0");
                }
                if (key.GetValue("OrderInfoFont1") == null)
                {
                    key.SetValue("OrderInfoFont1", "宋体|9|0|0");
                }
                if (key.GetValue("OrderInfoFont2") == null)
                {
                    key.SetValue("OrderInfoFont2", "宋体|9|0|0");
                }
                if (key.GetValue("OrderInfoForeColor1") == null)
                {
                    key.SetValue("OrderInfoForeColor1", "255|0|0|0");
                }
                if (key.GetValue("OrderInfoForeColor2") == null)
                {
                    key.SetValue("OrderInfoForeColor2", "255|0|0|0");
                }
                if (key.GetValue("OrderInfoItemheight") == null)
                {
                    key.SetValue("OrderInfoItemheight", "17");
                }
                this._OrderInfoFont1 = key.GetValue("OrderInfoFont1").ToString();
                this._OrderInfoFont2 = key.GetValue("OrderInfoFont2").ToString();
                this._OrderInfoForeColor1 = key.GetValue("OrderInfoForeColor1").ToString();
                this._OrderInfoForeColor2 = key.GetValue("OrderInfoForeColor2").ToString();
                this._OrderInfoItemheight = key.GetValue("OrderInfoItemheight").ToString();
                this.__OrderInfoFont1 = this._OrderInfoFont1.Split(new char[] { '|' });
                this.__OrderInfoFont2 = this._OrderInfoFont2.Split(new char[] { '|' });
                this.__OrderInfoForeColor1 = this._OrderInfoForeColor1.Split(new char[] { ',' });
                this.__OrderInfoForeColor2 = this._OrderInfoForeColor2.Split(new char[] { ',' });
                try
                {
                    if (this._OrderInfoItemheight == "auto")
                    {
                        this.glacialList5.AutoHeight = this.glacialList7.AutoHeight = true;
                        this.checkBox2.Checked = true;
                    }
                    else
                    {
                        this.checkBox2.Checked = false;
                        this.glacialList5.AutoHeight = this.glacialList7.AutoHeight = false;
                        this.glacialList5.ItemHeight = this.glacialList7.ItemHeight = Convert.ToInt16(this._OrderInfoItemheight);
                        this.numericUpDown1.Value = Convert.ToDecimal(this._OrderInfoItemheight);
                    }
                    foreach (GLItem item in this.glacialList7.Items)
                    {
                        item.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), ((this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular) | FontStyle.Italic);
                        item.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        for (int i = 1; i < this.glacialList5.Columns.Count; i++)
                        {
                            item.SubItems[i].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item.SubItems[i].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                        }
                    }
                    this.glacialList7.Refresh();
                }
                catch
                {
                }
            }
        }

        private void getOutputBulletin()
        {
            this.button18.Enabled = false;
            try
            {
                ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                this.ViewOutputBulletin(login._getOutputBulletin(Convert.ToInt32(Outputkey)));
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("获取公司公告时出错: " + exception.ToString());
            }
            this.button18.Enabled = true;
        }

        private void getOutputStatement()
        {
            string str = null;
            try
            {
                str = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._OutputStatement(Convert.ToInt32(Outputkey));
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("获取公司声明时出错: " + exception.ToString());
            }
            try
            {
                this.textBox5.Text = str.Replace("\n", "\r\n");
            }
            catch
            {
            }
        }

        private void getOutputUser()
        {
            try
            {
                string str;
                this.button7.Visible = true;
                this.listView5.Cursor = Cursors.WaitCursor;
                this.button1.Enabled = this.button2.Enabled = this.button4.Enabled = this.button5.Enabled = this.button6.Enabled = false;
                string[] strSearch = new string[4];
                strSearch[0] = Outputkey;
                strSearch[3] = str = "";
                strSearch[1] = strSearch[2] = str;
                if (this.textBox1.Text.Trim() != "")
                {
                    strSearch[1] = dowithString(this.textBox1.Text.Trim());
                }
                if (this.textBox2.Text.Trim() != "")
                {
                    strSearch[2] = dowithString(this.textBox2.Text.Trim());
                }
                if (this.textBox3.Text.Trim() != "")
                {
                    strSearch[3] = dowithString(this.textBox3.Text.Trim());
                }
                ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                this.ViewUserInfo(login.SearchUserInfo(strSearch));
                this.button1.Enabled = this.button2.Enabled = this.button4.Enabled = this.button5.Enabled = this.button6.Enabled = true;
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("获取用户资料时出错: " + exception.ToString());
                this.button1.Enabled = this.button2.Enabled = this.button4.Enabled = this.button5.Enabled = this.button6.Enabled = true;
            }
        }

        public void getRequestResponseInfo(_fileinfo __myfileinfo, int viewWhich)
        {
            this.listView1.BringToFront();
            try
            {
                this.listView1.Items.Clear();
                string[] strArray = __myfileinfo.SplitInfo[viewWhich].Split(new char[] { (char)0xff5c });
                this.listView1.BeginUpdate();
                for (int i = 0; i < (strArray.Length - 1); i++)
                {
                    string[] strArray2 = strArray[i].Split(new char[] { '|' });
                    for (int j = 0; j < (strArray2.Length - 1); j++)
                    {
                        string[] strArray3 = strArray2[j].Split(new char[] { ',' });
                        GLItem item = new GLItem();
                        if (strArray3[0] == "up")
                        {
                            item.SubItems[0].ImageIndex = 0;
                            item.BackColor = Color.PaleTurquoise;
                            item.ForeColor = Color.DarkBlue;
                        }
                        if (strArray3[0] == "down")
                        {
                            item.SubItems[0].ImageIndex = 1;
                            item.BackColor = Color.Lavender;
                        }
                        if (strArray3[0] == "ok")
                        {
                            item.SubItems[0].ImageIndex = 2;
                            item.BackColor = Color.PaleGreen;
                            item.ForeColor = Color.ForestGreen;
                        }
                        if (strArray3[0] == "stop")
                        {
                            item.SubItems[0].ImageIndex = 3;
                            item.BackColor = Color.Pink;
                            item.ForeColor = Color.DarkRed;
                        }
                        item.SubItems[0].Text = strArray3[1];
                        item.SubItems[1].Text = strArray3[2];
                        this.listView1.Items.Add(item);
                        this.listView1.Refresh();
                    }
                }
                this.listView1.EndUpdate();
            }
            catch (Exception exception)
            {
                GLItem item2 = new GLItem();
                item2.SubItems[0].ImageIndex = 0;
                item2.BackColor = Color.PaleTurquoise;
                item2.ForeColor = Color.DarkBlue;
                item2.SubItems[0].Text = DateTime.Now.ToString();
                item2.SubItems[1].Text = "正在连接远程服务器......" + exception.Message;
                this.listView1.Items.Add(item2);
                this.listView1.Refresh();
                Console.Write("\n\n正在连接远程服务器......\n\n");
            }
        }

        private void getSystemInfo()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(strCon);
                connection.Open();
                string str = "select * from SystemInfo";
                OleDbCommand command = new OleDbCommand {
                    Connection = connection,
                    CommandText = str
                };
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FileSavePath = reader["SaveFilePath"].ToString();
                    SaveFileType = Convert.ToInt16(reader["SaveFileType"]);
                    isAutoDown = Convert.ToInt16(reader["isAutoDown"]);
                    if ((FileSavePath == null) || (FileSavePath == ""))
                    {
                        MessageBox.Show("文件保存路径尚未设置，请您先设置!");
                        new SystemSet().ShowDialog();
                    }
                    else if (!Directory.Exists(FileSavePath))
                    {
                        MessageBox.Show("文件保存路径设置错误，请您重新设置!");
                        new SystemSet().ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("请您先设置文件保存路径!");
                    new SystemSet().ShowDialog();
                }
                connection.Close();
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("获取系统信息时出错: " + exception.ToString());
            }
        }

        private void getUserFiles()
        {
            this.button9.Enabled = this.button11.Enabled = this.button12.Enabled = this.button13.Enabled = false;
            bool flag = false;
            while (!flag)
            {
                try
                {
                    this.getUserFiles2();
                    flag = true;
                    continue;
                }
                catch (Exception exception)
                {
                    this.ePrintLog.WriteLog("获取客户文件时出错: " + exception.ToString());
                    this.button9.Enabled = this.button11.Enabled = this.button12.Enabled = this.button13.Enabled = true;
                    continue;
                }
            }
        }

        private void getUserFiles2()
        {
            try
            {
                ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                this.ViewUserFilesInfo(login._getUserFiles(Convert.ToInt32(Outputkey)));
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("获取客户文件时出错：" + exception.ToString());
            }
        }

        private void GetUserLevel()
        {
            string userLevel = OutputLogin.UserLevel;
            if (userLevel != "0000000000000000000000000000000000000000")
            {
                string str2 = userLevel.Substring(2, 8);
                if (str2.Substring(0, 1) == "0")
                {
                    this.toolBarButton6.Enabled = false;
                }
                if (str2.Substring(6, 1) == "0")
                {
                    this.toolBarButton7.Enabled = false;
                }
                if (str2.Substring(1, 1) == "0")
                {
                    this.contextMenu1.MenuItems[6].Enabled = false;
                    this.contextMenu2.MenuItems[0].Enabled = this.contextMenu2.MenuItems[1].Enabled = false;
                    this.contextMenu3.MenuItems[0].Enabled = false;
                    this.contextMenu4.MenuItems[0].Enabled = false;
                }
                for (int i = 0; i < this.treeView1.Nodes.Count; i++)
                {
                    bool flag = false;
                    if (this.treeView1.Nodes[i].Text == "本地用户管理")
                    {
                        if (str2.Substring(2, 1) == "0")
                        {
                            flag = true;
                        }
                    }
                    else if (this.treeView1.Nodes[i].Text == "印易网上平台")
                    {
                        flag = true;
                    }
                    else if (this.treeView1.Nodes[i].Text == "发送文件给客户")
                    {
                        if (str2.Substring(3, 1) == "0")
                        {
                            flag = true;
                        }
                    }
                    else if (this.treeView1.Nodes[i].Text == "客户文件管理")
                    {
                        if (str2.Substring(4, 1) == "0")
                        {
                            flag = true;
                        }
                    }
                    else if (this.treeView1.Nodes[i].Text == "声明/公告管理")
                    {
                        if (str2.Substring(5, 1) == "0")
                        {
                            flag = true;
                        }
                    }
                    else if ((this.treeView1.Nodes[i].Text == "系统日志管理") && (str2.Substring(7, 1) == "0"))
                    {
                        flag = true;
                    }
                    if (flag)
                    {
                        this.treeView1.Nodes[i].Remove();
                        i--;
                    }
                }
                this.treeView1.Refresh();
            }
        }

        private void glacialList1_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.glacialList1.Items.Count; i++)
            {
                if (this.glacialList1.Items[i].Selected)
                {
                    _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                    if (((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4)) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 10))
                    {
                        this.downloadStop();
                        return;
                    }
                    if (this.glacialList1.Items[i].SubItems[0].ImageIndex == 15)
                    {
                        this.glacialList1.Items[i].SubItems[0].ImageIndex = 1;
                        return;
                    }
                    this.downloadContinue();
                    return;
                }
            }
        }

        private void glacialList1_ItemChangedEvent(object source, GLChangedEventArgs e)
        {
            if (e.ChangedType == GLChangedTypes.SelectionChanged)
            {
                if (this.glacialList1.SelectedItems.Contains(e.Item) && (e.Item.SubItems[5].Control != null))
                {
                    ((myprogress) e.Item.SubItems[5].Control).BackColor = this.glacialList1.SelectionColor;
                    ((myprogress) e.Item.SubItems[5].Control).ForeColor = this.glacialList1.SelectedTextColor;
                    ((myprogress) e.Item.SubItems[5].Control).CaptionBrush = Brushes.White;
                    ((myprogress) e.Item.SubItems[5].Control).ProgressBrush = Pens.White;
                    ((myprogress) e.Item.SubItems[5].Control).Invalidate();
                }
                else
                {
                    ((myprogress) e.Item.SubItems[5].Control).BackColor = this.glacialList1.BackColor;
                    ((myprogress) e.Item.SubItems[5].Control).ForeColor = Color.LightGreen;
                    ((myprogress) e.Item.SubItems[5].Control).CaptionBrush = Brushes.Black;
                    ((myprogress) e.Item.SubItems[5].Control).ProgressBrush = Pens.DarkGreen;
                    ((myprogress) e.Item.SubItems[5].Control).Invalidate();
                }
            }
        }

        private void glacialList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.glacialList1.Focus();
                if (this.glacialList1.GetItemAt(e.X, e.Y) != null)
                {
                    this.glacialList1.GetItemAt(e.X, e.Y).Selected = true;
                    if (((this.glacialList1.GetItemAt(e.X, e.Y).SubItems[0].ImageIndex != 4) && (this.glacialList1.GetItemAt(e.X, e.Y).SubItems[0].ImageIndex != 0)) && (this.glacialList1.GetItemAt(e.X, e.Y).SubItems[0].ImageIndex != 15))
                    {
                        for (int i = 0; i < this.contextMenu1.MenuItems.Count; i++)
                        {
                            if (i == 1)
                            {
                                this.contextMenu1.MenuItems[i].Enabled = false;
                            }
                            else
                            {
                                this.contextMenu1.MenuItems[i].Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < this.contextMenu1.MenuItems.Count; j++)
                        {
                            if (j == 0)
                            {
                                this.contextMenu1.MenuItems[j].Enabled = false;
                            }
                            else
                            {
                                this.contextMenu1.MenuItems[j].Enabled = true;
                            }
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < this.glacialList1.Items.Count; k++)
                    {
                        this.glacialList1.Items[k].Selected = false;
                    }
                }
            }
            if (this.glacialList1.GetItemAt(e.X, e.Y) == null)
            {
                this.toolBarButton1.Enabled = false;
                this.toolBarButton2.Enabled = false;
                this.toolBarButton3.Enabled = false;
                this.toolBarButton4.Enabled = false;
                this.toolBarButton5.Enabled = false;
            }
            if ((OutputLogin.UserLevel != "0000000000000000000000000000000000000000") && (OutputLogin.UserLevel.Substring(3, 1) == "0"))
            {
                this.contextMenu1.MenuItems[6].Enabled = false;
            }
            this.viewSplit();
        }

        private void glacialList1_MouseMove(object sender, MouseEventArgs e)
        {
            this._lastList = (GlacialList) sender;
            GLItem itemAt = ((GlacialList) sender).GetItemAt(e.X, e.Y);
            if (itemAt == null)
            {
                this.toolTip_Element.Active = false;
                this.timer_ToolTip.Enabled = false;
            }
            else if (itemAt != this._lastItem)
            {
                this.toolTip_Element.Active = false;
                this.timer_ToolTip.Tick += new EventHandler(this.timer_ToolTip_Tick);
                this.timer_ToolTip.Enabled = true;
            }
            this._lastItem = itemAt;
        }

        private void glacialList1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.glacialList1.GetItemAt(e.X, e.Y) == null)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    this.glacialList1.Items[i].Selected = false;
                }
            }
        }

        private void glacialList1_SelectedIndexChanged(object source, GLClickEventArgs e)
        {
            this.viewSplit();
            this.downingViewOrderInfo();
        }

        private void glacialList2_DoubleClick(object sender, EventArgs e)
        {
            this.openFile(0);
        }

        private void glacialList2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.glacialList2.Focus();
                if ((this.glacialList2.GetItemAt(e.X, e.Y) != null) && !this.glacialList2.GetItemAt(e.X, e.Y).Selected)
                {
                    this.glacialList2.Items.ClearSelection();
                    this.glacialList2.GetItemAt(e.X, e.Y).Selected = true;
                }
            }
            if (this.glacialList2.Items.Count > 0)
            {
                if (this.glacialList2.SelectedItems.Count > 0)
                {
                    this.toolBarButton3.Enabled = true;
                    this.toolBarButton4.Enabled = true;
                    this.toolBarButton5.Enabled = true;
                    this.contextMenu2.MenuItems[0].Enabled = true;
                    this.contextMenu2.MenuItems[1].Enabled = true;
                    this.contextMenu2.MenuItems[2].Enabled = true;
                    this.contextMenu2.MenuItems[3].Enabled = true;
                    this.contextMenu2.MenuItems[4].Enabled = true;
                    this.contextMenu2.MenuItems[5].Enabled = true;
                }
                else
                {
                    this.contextMenu2.MenuItems[0].Enabled = false;
                    this.contextMenu2.MenuItems[1].Enabled = false;
                    this.contextMenu2.MenuItems[2].Enabled = false;
                    this.contextMenu2.MenuItems[3].Enabled = false;
                    this.contextMenu2.MenuItems[4].Enabled = false;
                    this.contextMenu2.MenuItems[5].Enabled = false;
                }
            }
            else
            {
                this.contextMenu2.MenuItems[0].Enabled = false;
                this.contextMenu2.MenuItems[1].Enabled = false;
                this.contextMenu2.MenuItems[2].Enabled = false;
                this.contextMenu2.MenuItems[3].Enabled = false;
                this.contextMenu2.MenuItems[4].Enabled = false;
                this.contextMenu2.MenuItems[5].Enabled = false;
            }
            if ((this.glacialList2.GetItemAt(e.X, e.Y) == null) && (this.glacialList2.Items.Count > 0))
            {
                this.glacialList2.Items.ClearSelection();
                this.glacialList2.Refresh();
            }
            if ((OutputLogin.UserLevel != "0000000000000000000000000000000000000000") && (OutputLogin.UserLevel.Substring(3, 1) == "0"))
            {
                this.contextMenu2.MenuItems[0].Enabled = this.contextMenu2.MenuItems[1].Enabled = false;
            }
        }

        private void glacialList2_SelectedIndexChanged(object source, GLClickEventArgs e)
        {
            this.downedViewOrderInfo();
        }

        private void glacialList3_DoubleClick(object sender, EventArgs e)
        {
            this.openFile2(0);
        }

        private void glacialList3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.glacialList3.Focus();
                if ((this.glacialList3.GetItemAt(e.X, e.Y) != null) && !this.glacialList3.GetItemAt(e.X, e.Y).Selected)
                {
                    this.glacialList3.Items.ClearSelection();
                    this.glacialList3.GetItemAt(e.X, e.Y).Selected = true;
                }
                this.contextMenu3.MenuItems[1].Enabled = false;
            }
            if (this.glacialList3.Items.Count > 0)
            {
                if (this.glacialList3.SelectedItems.Count > 0)
                {
                    if ((OutputLogin.UserLevel != "0000000000000000000000000000000000000000") && (OutputLogin.UserLevel.Substring(3, 1) == "0"))
                    {
                        this.toolBarButton3.Enabled = false;
                    }
                    else
                    {
                        this.toolBarButton3.Enabled = true;
                    }
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = true;
                    this.contextMenu3.MenuItems[0].Enabled = true;
                    this.contextMenu3.MenuItems[1].Enabled = true;
                    this.contextMenu3.MenuItems[2].Enabled = true;
                    this.contextMenu3.MenuItems[3].Enabled = true;
                    this.contextMenu3.MenuItems[4].Enabled = true;
                    this.contextMenu3.MenuItems[5].Enabled = true;
                }
                else
                {
                    this.contextMenu3.MenuItems[0].Enabled = false;
                    this.contextMenu3.MenuItems[1].Enabled = false;
                    this.contextMenu3.MenuItems[2].Enabled = false;
                    this.contextMenu3.MenuItems[3].Enabled = false;
                    this.contextMenu3.MenuItems[4].Enabled = false;
                    this.contextMenu3.MenuItems[5].Enabled = false;
                }
            }
            else
            {
                this.contextMenu3.MenuItems[0].Enabled = false;
                this.contextMenu3.MenuItems[1].Enabled = false;
                this.contextMenu3.MenuItems[2].Enabled = false;
                this.contextMenu3.MenuItems[3].Enabled = false;
                this.contextMenu3.MenuItems[4].Enabled = false;
                this.contextMenu3.MenuItems[5].Enabled = false;
            }
            if ((this.glacialList3.GetItemAt(e.X, e.Y) == null) && (this.glacialList3.Items.Count > 0))
            {
                this.glacialList3.Items.ClearSelection();
                this.glacialList3.Refresh();
            }
            if ((OutputLogin.UserLevel != "0000000000000000000000000000000000000000") && (OutputLogin.UserLevel.Substring(3, 1) == "0"))
            {
                this.contextMenu3.MenuItems[0].Enabled = false;
            }
        }

        private void glacialList3_SelectedIndexChanged(object source, GLClickEventArgs e)
        {
            this.delViewOrderInfo();
        }

        private void glacialList4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.glacialList4.Focus();
                if ((this.glacialList4.Items.Count > 0) && (this.glacialList4.GetItemAt(e.X, e.Y) != null))
                {
                    this.glacialList4.GetItemAt(e.X, e.Y).Selected = true;
                }
            }
            if (this.glacialList4.Items.Count > 0)
            {
                if (this.glacialList4.SelectedItems.Count > 0)
                {
                    this.contextMenu4.MenuItems[0].Enabled = true;
                    this.contextMenu4.MenuItems[1].Enabled = true;
                }
                else
                {
                    this.contextMenu4.MenuItems[0].Enabled = false;
                    this.contextMenu4.MenuItems[1].Enabled = false;
                }
            }
            else
            {
                this.contextMenu4.MenuItems[0].Enabled = false;
                this.contextMenu4.MenuItems[1].Enabled = false;
            }
            if ((OutputLogin.UserLevel != "0000000000000000000000000000000000000000") && (OutputLogin.UserLevel.Substring(3, 1) == "0"))
            {
                this.contextMenu4.MenuItems[0].Enabled = false;
            }
        }

        private void glacialList4_SelectedIndexChanged(object source, GLClickEventArgs e)
        {
            this.cancelViewOrderInfo();
        }

        private string GlaListViewTip(int i, long key)
        {
            OleDbConnection connection = new OleDbConnection(strCon);
            connection.Open();
            OleDbCommand command = new OleDbCommand("select CompanyName,CompanyAddress,CompanyTel,CompanyMan,OrderInfo,ZipInfo from DownLoading where dh=" + key, connection);
            OleDbDataReader reader = null;
            reader = command.ExecuteReader();
            string str2 = "";
            if (reader.Read())
            {
                string[] strArray = reader["OrderInfo"].ToString().Split(new char[] { ',' });
                str2 = string.Concat(new object[] { "公司名称：", reader["CompanyName"], "\n公司地址：", reader["CompanyAddress"], "\n联  系  人：", reader["CompanyMan"], "\n联系电话：", reader["CompanyTel"], "\n要求送货时间：", strArray[strArray.Length - 2], "\n要求送货地点：", strArray[strArray.Length - 1], "\n----------------------------------------------\n" }) + "附    言：\n" + strArray[strArray.Length - 3];
            }
            reader.Close();
            connection.Close();
            return str2;
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ResourceManager manager = new ResourceManager(typeof(ePrintMain));
            GLColumn column = new GLColumn();
            GLColumn column2 = new GLColumn();
            GLColumn column3 = new GLColumn();
            GLColumn column4 = new GLColumn();
            GLColumn column5 = new GLColumn();
            GLColumn column6 = new GLColumn();
            GLColumn column7 = new GLColumn();
            GLColumn column8 = new GLColumn();
            GLColumn column9 = new GLColumn();
            GLColumn column10 = new GLColumn();
            GLColumn column11 = new GLColumn();
            GLColumn column12 = new GLColumn();
            GLColumn column13 = new GLColumn();
            GLColumn column14 = new GLColumn();
            GLColumn column15 = new GLColumn();
            GLColumn column16 = new GLColumn();
            GLColumn column17 = new GLColumn();
            GLColumn column18 = new GLColumn();
            GLColumn column19 = new GLColumn();
            GLColumn column20 = new GLColumn();
            GLColumn column21 = new GLColumn();
            GLColumn column22 = new GLColumn();
            GLColumn column23 = new GLColumn();
            GLColumn column24 = new GLColumn();
            GLColumn column25 = new GLColumn();
            GLColumn column26 = new GLColumn();
            GLColumn column27 = new GLColumn();
            GLColumn column28 = new GLColumn();
            GLColumn column29 = new GLColumn();
            GLColumn column30 = new GLColumn();
            GLColumn column31 = new GLColumn();
            GLColumn column32 = new GLColumn();
            GLColumn column33 = new GLColumn();
            GLColumn column34 = new GLColumn();
            GLColumn column35 = new GLColumn();
            GLColumn column36 = new GLColumn();
            GLColumn column37 = new GLColumn();
            GLColumn column38 = new GLColumn();
            GLColumn column39 = new GLColumn();
            GLColumn column40 = new GLColumn();
            GLColumn column41 = new GLColumn();
            GLColumn column42 = new GLColumn();
            GLColumn column43 = new GLColumn();
            GLColumn column44 = new GLColumn();
            GLColumn column45 = new GLColumn();
            GLItem item = new GLItem();
            GLSubItem item2 = new GLSubItem();
            GLSubItem item3 = new GLSubItem();
            GLItem item4 = new GLItem();
            GLSubItem item5 = new GLSubItem();
            GLSubItem item6 = new GLSubItem();
            GLItem item7 = new GLItem();
            GLSubItem item8 = new GLSubItem();
            GLSubItem item9 = new GLSubItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainMenu1 = new MainMenu();
            this.menuItem1 = new MenuItem();
            this.menuItem73 = new MenuItem();
            this.menuItem74 = new MenuItem();
            this.menuItem75 = new MenuItem();
            this.menuItem76 = new MenuItem();
            this.menuItem77 = new MenuItem();
            this.menuItem2 = new MenuItem();
            this.menuItem3 = new MenuItem();
            this.menuItem4 = new MenuItem();
            this.menuItem5 = new MenuItem();
            this.menuItem6 = new MenuItem();
            this.menuItem7 = new MenuItem();
            this.menuItem8 = new MenuItem();
            this.toolBar1 = new ToolBar();
            this.toolBarButton9 = new ToolBarButton();
            this.toolBarButton1 = new ToolBarButton();
            this.toolBarButton2 = new ToolBarButton();
            this.toolBarButton3 = new ToolBarButton();
            this.toolBarButton10 = new ToolBarButton();
            this.toolBarButton4 = new ToolBarButton();
            this.toolBarButton5 = new ToolBarButton();
            this.toolBarButton11 = new ToolBarButton();
            this.toolBarButton6 = new ToolBarButton();
            this.toolBarButton12 = new ToolBarButton();
            this.toolBarButton13 = new ToolBarButton();
            this.toolBarButton7 = new ToolBarButton();
            this.toolBarButton8 = new ToolBarButton();
            this.imageList5 = new ImageList(this.components);
            this.statusBar1 = new StatusBar();
            this.statusBarPanel1 = new StatusBarPanel();
            this.statusBarPanel2 = new StatusBarPanel();
            this.statusBarPanel3 = new StatusBarPanel();
            this.statusBarPanel4 = new StatusBarPanel();
            this.panel2 = new Panel();
            this.treeView1 = new TreeView();
            this.imageList3 = new ImageList(this.components);
            this.splitter1 = new Splitter();
            this.contextMenu9 = new ContextMenu();
            this.menuItem57 = new MenuItem();
            this.menuItem61 = new MenuItem();
            this.menuItem63 = new MenuItem();
            this.menuItem78 = new MenuItem();
            this.menuItem79 = new MenuItem();
            this.menuItem69 = new MenuItem();
            this.menuItem62 = new MenuItem();
            this.menuItem64 = new MenuItem();
            this.menuItem65 = new MenuItem();
            this.menuItem66 = new MenuItem();
            this.menuItem67 = new MenuItem();
            this.menuItem68 = new MenuItem();
            this.imageList8 = new ImageList(this.components);
            this.imageList7 = new ImageList(this.components);
            this.contextMenu8 = new ContextMenu();
            this.menuItem58 = new MenuItem();
            this.menuItem59 = new MenuItem();
            this.menuItem60 = new MenuItem();
            this.imageList6 = new ImageList(this.components);
            this.contextMenu7 = new ContextMenu();
            this.menuItem51 = new MenuItem();
            this.menuItem54 = new MenuItem();
            this.menuItem55 = new MenuItem();
            this.menuItem56 = new MenuItem();
            this.menuItem52 = new MenuItem();
            this.menuItem53 = new MenuItem();
            this.contextMenu5 = new ContextMenu();
            this.menuItem26 = new MenuItem();
            this.menuItem27 = new MenuItem();
            this.menuItem28 = new MenuItem();
            this.menuItem29 = new MenuItem();
            this.menuItem30 = new MenuItem();
            this.menuItem31 = new MenuItem();
            this.menuItem82 = new MenuItem();
            this.menuItem32 = new MenuItem();
            this.menuItem33 = new MenuItem();
            this.menuItem34 = new MenuItem();
            this.menuItem83 = new MenuItem();
            this.menuItem84 = new MenuItem();
            this.imageList4 = new ImageList(this.components);
            this.contextMenu10 = new ContextMenu();
            this.menuItem85 = new MenuItem();
            this.imageList2 = new ImageList(this.components);
            this.contextMenu4 = new ContextMenu();
            this.menuItem24 = new MenuItem();
            this.menuItem25 = new MenuItem();
            this.imageList1 = new ImageList(this.components);
            this.contextMenu3 = new ContextMenu();
            this.menuItem17 = new MenuItem();
            this.menuItem23 = new MenuItem();
            this.menuItem18 = new MenuItem();
            this.menuItem19 = new MenuItem();
            this.menuItem35 = new MenuItem();
            this.menuItem36 = new MenuItem();
            this.contextMenu2 = new ContextMenu();
            this.menuItem72 = new MenuItem();
            this.menuItem14 = new MenuItem();
            this.menuItem22 = new MenuItem();
            this.menuItem80 = new MenuItem();
            this.menuItem81 = new MenuItem();
            this.menuItem70 = new MenuItem();
            this.menuItem71 = new MenuItem();
            this.menuItem15 = new MenuItem();
            this.menuItem16 = new MenuItem();
            this.menuItem37 = new MenuItem();
            this.menuItem38 = new MenuItem();
            this.contextMenu1 = new ContextMenu();
            this.menuItem9 = new MenuItem();
            this.menuItem10 = new MenuItem();
            this.menuItem20 = new MenuItem();
            this.menuItem11 = new MenuItem();
            this.menuItem12 = new MenuItem();
            this.menuItem21 = new MenuItem();
            this.menuItem13 = new MenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel11 = new Panel();
            this.toolTip_Element = new ToolTip(this.components);
            this.notifyIcon1 = new NotifyIcon(this.components);
            this.contextMenu6 = new ContextMenu();
            this.menuItem39 = new MenuItem();
            this.menuItem40 = new MenuItem();
            this.menuItem41 = new MenuItem();
            this.menuItem42 = new MenuItem();
            this.menuItem43 = new MenuItem();
            this.menuItem47 = new MenuItem();
            this.menuItem44 = new MenuItem();
            this.menuItem45 = new MenuItem();
            this.menuItem49 = new MenuItem();
            this.menuItem48 = new MenuItem();
            this.menuItem50 = new MenuItem();
            this.menuItem46 = new MenuItem();
            this.saveFileDialog1 = new SaveFileDialog();
            this.label19 = new Label();
            this.groupBox1 = new GroupBox();
            this.panel1 = new Panel();
            this.pictureBox1 = new PictureBox();
            this.saveFileDialog2 = new SaveFileDialog();
            this.fontDialog1 = new FontDialog();
            this.colorDialog1 = new ColorDialog();
            this.tabControl2 = new TabControl();
            this.tabPage7 = new TabPage();
            this.PnlFunc1 = new Panel();
            this.panel5 = new Panel();
            this.panel7 = new Panel();
            this.panel8 = new Panel();
            this.listView3 = new ListView();
            this.columnHeader3 = new ColumnHeader();
            this.columnHeader4 = new ColumnHeader();
            this.listView1 = new GlacialList();
            this.glacialList5 = new GlacialList();
            this.splitter3 = new Splitter();
            this.panel6 = new Panel();
            this.treeView2 = new TreeView();
            this.splitter2 = new Splitter();
            this.panel22 = new Panel();
            this.button3 = new Button();
            this.glacialList1 = new GlacialList();
            this.glacialList4 = new GlacialList();
            this.glacialList3 = new GlacialList();
            this.glacialList2 = new GlacialList();
            this.tabPage5 = new TabPage();
            this.PnlFunc2 = new Panel();
            this.button7 = new Button();
            this.listView5 = new ListView();
            this.columnHeader23 = new ColumnHeader();
            this.columnHeader13 = new ColumnHeader();
            this.columnHeader14 = new ColumnHeader();
            this.columnHeader16 = new ColumnHeader();
            this.columnHeader17 = new ColumnHeader();
            this.columnHeader18 = new ColumnHeader();
            this.columnHeader19 = new ColumnHeader();
            this.columnHeader20 = new ColumnHeader();
            this.columnHeader21 = new ColumnHeader();
            this.columnHeader24 = new ColumnHeader();
            this.columnHeader25 = new ColumnHeader();
            this.columnHeader22 = new ColumnHeader();
            this.panel17 = new Panel();
            this.groupBox2 = new GroupBox();
            this.checkBox1 = new CheckBox();
            this.label15 = new Label();
            this.label13 = new Label();
            this.label12 = new Label();
            this.label11 = new Label();
            this.label10 = new Label();
            this.label9 = new Label();
            this.label8 = new Label();
            this.label7 = new Label();
            this.label6 = new Label();
            this.textBox3 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.button8 = new Button();
            this.button6 = new Button();
            this.button5 = new Button();
            this.button4 = new Button();
            this.button2 = new Button();
            this.button1 = new Button();
            this.tabPage4 = new TabPage();
            this.PnlFunc4 = new Panel();
            this.panel10 = new Panel();
            this.button13 = new Button();
            this.button12 = new Button();
            this.button11 = new Button();
            this.button10 = new Button();
            this.button9 = new Button();
            this.label14 = new Label();
            this.listView6 = new ListView();
            this.columnHeader32 = new ColumnHeader();
            this.columnHeader26 = new ColumnHeader();
            this.columnHeader27 = new ColumnHeader();
            this.columnHeader28 = new ColumnHeader();
            this.columnHeader29 = new ColumnHeader();
            this.columnHeader30 = new ColumnHeader();
            this.columnHeader31 = new ColumnHeader();
            this.tp3 = new TabPage();
            this.PnlFunc3 = new Panel();
            this.listView7 = new ListView();
            this.columnHeader33 = new ColumnHeader();
            this.columnHeader34 = new ColumnHeader();
            this.columnHeader35 = new ColumnHeader();
            this.columnHeader36 = new ColumnHeader();
            this.toolBar2 = new ToolBar();
            this.toolBarButton14 = new ToolBarButton();
            this.toolBarButton16 = new ToolBarButton();
            this.toolBarButton17 = new ToolBarButton();
            this.toolBarButton18 = new ToolBarButton();
            this.tabPage6 = new TabPage();
            this.panel43 = new Panel();
            this.PnlFunc5 = new Panel();
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.button18 = new Button();
            this.label5 = new Label();
            this.label25 = new Label();
            this.button17 = new Button();
            this.textBox6 = new TextBox();
            this.button15 = new Button();
            this.button14 = new Button();
            this.textBox4 = new TextBox();
            this.listView8 = new ListView();
            this.columnHeader15 = new ColumnHeader();
            this.columnHeader40 = new ColumnHeader();
            this.columnHeader41 = new ColumnHeader();
            this.tabPage2 = new TabPage();
            this.button16 = new Button();
            this.textBox5 = new TextBox();
            this.tabPage8 = new TabPage();
            this.PnlFunc6 = new Panel();
            this.panel14 = new Panel();
            this.panel16 = new Panel();
            this.statusBar3 = new StatusBar();
            this.statusBarPanel8 = new StatusBarPanel();
            this.statusBarPanel9 = new StatusBarPanel();
            this.statusBarPanel10 = new StatusBarPanel();
            this.listView4 = new ListView();
            this.columnHeader8 = new ColumnHeader();
            this.columnHeader9 = new ColumnHeader();
            this.columnHeader12 = new ColumnHeader();
            this.columnHeader10 = new ColumnHeader();
            this.columnHeader11 = new ColumnHeader();
            this.comboBox2 = new ComboBox();
            this.splitter5 = new Splitter();
            this.panel15 = new Panel();
            this.statusBar2 = new StatusBar();
            this.statusBarPanel5 = new StatusBarPanel();
            this.statusBarPanel6 = new StatusBarPanel();
            this.statusBarPanel7 = new StatusBarPanel();
            this.listView2 = new ListView();
            this.columnHeader5 = new ColumnHeader();
            this.columnHeader6 = new ColumnHeader();
            this.columnHeader7 = new ColumnHeader();
            this.comboBox1 = new ComboBox();
            this.splitter4 = new Splitter();
            this.panel13 = new Panel();
            this.glacialList6 = new GlacialList();
            this.panel9 = new Panel();
            this.groupBox4 = new GroupBox();
            this.checkBox2 = new CheckBox();
            this.label20 = new Label();
            this.label21 = new Label();
            this.label1 = new Label();
            this.numericUpDown1 = new NumericUpDown();
            this.label18 = new Label();
            this.label23 = new Label();
            this.label22 = new Label();
            this.label24 = new Label();
            this.button20 = new Button();
            this.button19 = new Button();
            this.glacialList7 = new GlacialList();
            this.Pnldock = new Panel();
            this.label16 = new Label();
            this.label17 = new Label();
            this.columnHeader38 = new ColumnHeader();
            this.columnHeader39 = new ColumnHeader();
            this.columnHeader37 = new ColumnHeader();
            this.statusBarPanel1.BeginInit();
            this.statusBarPanel2.BeginInit();
            this.statusBarPanel3.BeginInit();
            this.statusBarPanel4.BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.PnlFunc1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.PnlFunc2.SuspendLayout();
            this.panel17.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.PnlFunc4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tp3.SuspendLayout();
            this.PnlFunc3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel43.SuspendLayout();
            this.PnlFunc5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.PnlFunc6.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.statusBarPanel8.BeginInit();
            this.statusBarPanel9.BeginInit();
            this.statusBarPanel10.BeginInit();
            this.panel15.SuspendLayout();
            this.statusBarPanel5.BeginInit();
            this.statusBarPanel6.BeginInit();
            this.statusBarPanel7.BeginInit();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.numericUpDown1.BeginInit();
            base.SuspendLayout();
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            this.mainMenu1.MenuItems.AddRange(new MenuItem[] { this.menuItem1, this.menuItem3, this.menuItem5 });
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new MenuItem[] { this.menuItem73, this.menuItem74, this.menuItem75, this.menuItem76, this.menuItem77, this.menuItem2 });
            this.menuItem1.Text = "文件(&F)";
            this.menuItem73.Enabled = false;
            this.menuItem73.Index = 0;
            this.menuItem73.Text = "登录(&I)...";
            this.menuItem74.Index = 1;
            this.menuItem74.Text = "注销(&N)";
            this.menuItem74.Click += new EventHandler(this.menuItem74_Click);
            this.menuItem75.Index = 2;
            this.menuItem75.Text = "-";
            this.menuItem76.Index = 3;
            this.menuItem76.Text = "发送文件给客户(&S)";
            this.menuItem76.Click += new EventHandler(this.menuItem76_Click);
            this.menuItem77.Index = 4;
            this.menuItem77.Text = "-";
            this.menuItem2.Index = 5;
            this.menuItem2.Text = "退出(&X)";
            this.menuItem2.Click += new EventHandler(this.menuItem2_Click);
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new MenuItem[] { this.menuItem4 });
            this.menuItem3.Text = "工具(&T)";
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "设置(&S)";
            this.menuItem4.Click += new EventHandler(this.menuItem4_Click);
            this.menuItem5.Index = 2;
            this.menuItem5.MenuItems.AddRange(new MenuItem[] { this.menuItem6, this.menuItem7, this.menuItem8 });
            this.menuItem5.Text = "帮助(&H)";
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "平台使用手册(&M)";
            this.menuItem6.Click += new EventHandler(this.menuItem6_Click);
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "广州印网主页(&W)";
            this.menuItem7.Click += new EventHandler(this.menuItem7_Click);
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "关于印易3.3(&A)";
            this.menuItem8.Click += new EventHandler(this.menuItem8_Click);
            this.toolBar1.Appearance = ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new ToolBarButton[] { this.toolBarButton9, this.toolBarButton1, this.toolBarButton2, this.toolBarButton3, this.toolBarButton10, this.toolBarButton4, this.toolBarButton5, this.toolBarButton11, this.toolBarButton6, this.toolBarButton12, this.toolBarButton13, this.toolBarButton7, this.toolBarButton8 });
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList5;
            this.toolBar1.Location = new Point(0, 0x40);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new Size(0x3b8, 0x2d);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            this.toolBarButton9.Style = ToolBarButtonStyle.Separator;
            this.toolBarButton1.Enabled = false;
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Text = "开始";
            this.toolBarButton1.ToolTipText = "开始下载文件";
            this.toolBarButton2.Enabled = false;
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Text = "暂停";
            this.toolBarButton2.ToolTipText = "暂停文件下载";
            this.toolBarButton3.Enabled = false;
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Text = "删除";
            this.toolBarButton3.ToolTipText = "删除选中文件(只删除订单信息，不删除文件)";
            this.toolBarButton10.Style = ToolBarButtonStyle.Separator;
            this.toolBarButton4.Enabled = false;
            this.toolBarButton4.ImageIndex = 3;
            this.toolBarButton4.Text = "打开";
            this.toolBarButton4.ToolTipText = "打开选择文件";
            this.toolBarButton5.Enabled = false;
            this.toolBarButton5.ImageIndex = 4;
            this.toolBarButton5.Text = "目录";
            this.toolBarButton5.ToolTipText = "打开选中文件所在的目录";
            this.toolBarButton11.Style = ToolBarButtonStyle.Separator;
            this.toolBarButton6.ImageIndex = 5;
            this.toolBarButton6.Text = "接收订单";
            this.toolBarButton12.Enabled = false;
            this.toolBarButton12.ImageIndex = 6;
            this.toolBarButton12.Text = "暂停接收";
            this.toolBarButton13.Style = ToolBarButtonStyle.Separator;
            this.toolBarButton7.ImageIndex = 8;
            this.toolBarButton7.Text = "设置";
            this.toolBarButton7.ToolTipText = "设置软件的一些参数";
            this.toolBarButton8.ImageIndex = 9;
            this.toolBarButton8.Text = "退出";
            this.toolBarButton8.ToolTipText = "退出软件";
            this.imageList5.ImageSize = new Size(20, 20);
            this.imageList5.ImageStream = (ImageListStreamer) manager.GetObject("imageList5.ImageStream");
            this.imageList5.TransparentColor = Color.Transparent;
            this.statusBar1.Location = new Point(0, 0x253);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new StatusBarPanel[] { this.statusBarPanel1, this.statusBarPanel2, this.statusBarPanel3, this.statusBarPanel4 });
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new Size(0x3b8, 0x16);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "statusBar1";
            this.statusBar1.DrawItem += new StatusBarDrawItemEventHandler(this.statusBar1_DrawItem);
            this.statusBarPanel1.Width = 200;
            this.statusBarPanel2.Icon = (Icon) manager.GetObject("statusBarPanel2.Icon");
            this.statusBarPanel2.Text = "就绪";
            this.statusBarPanel2.Width = 200;
            this.statusBarPanel4.AutoSize = StatusBarPanelAutoSize.Spring;
            this.statusBarPanel4.Style = StatusBarPanelStyle.OwnerDraw;
            this.statusBarPanel4.Width = 0x1b4;
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = DockStyle.Left;
            this.panel2.Location = new Point(0, 0x6d);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(0x88, 0x1e6);
            this.panel2.TabIndex = 3;
            this.treeView1.BorderStyle = BorderStyle.FixedSingle;
            this.treeView1.Dock = DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageList = this.imageList3;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Nodes.AddRange(new TreeNode[] { new TreeNode("本地订单管理", 0x17, 0x17, new TreeNode[] { new TreeNode("正在下载订单", 0x18, 0x18), new TreeNode("已下载订单", 0x19, 0x19), new TreeNode("已删除订单", 3, 3), new TreeNode("取消下载订单", 0x1a, 0x1a) }), new TreeNode("本地用户管理", 0x1d, 0x1d), new TreeNode("印易网上平台", 0x1c, 0x1c), new TreeNode("发送文件给客户", 0x1b, 0x1b), new TreeNode("客户文件管理", 0x21, 0x21), new TreeNode("声明/公告管理", 0x22, 0x22), new TreeNode("系统日志管理", 0x23, 0x23) });
            this.treeView1.Size = new Size(0x88, 0x1e6);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseUp += new MouseEventHandler(this.treeView1_MouseUp);
            this.treeView1.DoubleClick += new EventHandler(this.treeView1_DoubleClick);
            this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseLeave += new EventHandler(this.treeView1_MouseLeave);
            this.imageList3.ColorDepth = ColorDepth.Depth32Bit;
            this.imageList3.ImageSize = new Size(0x10, 0x10);
            this.imageList3.ImageStream = (ImageListStreamer) manager.GetObject("imageList3.ImageStream");
            this.imageList3.TransparentColor = Color.Transparent;
            this.splitter1.Location = new Point(0x88, 0x6d);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new Size(3, 0x1e6);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            this.contextMenu9.MenuItems.AddRange(new MenuItem[] { this.menuItem57, this.menuItem61, this.menuItem63, this.menuItem78, this.menuItem79, this.menuItem69, this.menuItem62, this.menuItem67, this.menuItem68 });
            this.menuItem57.Index = 0;
            this.menuItem57.Text = "查看日志(&O)";
            this.menuItem57.Click += new EventHandler(this.menuItem57_Click);
            this.menuItem61.Index = 1;
            this.menuItem61.Text = "删除日志(&D)";
            this.menuItem61.Click += new EventHandler(this.menuItem61_Click);
            this.menuItem63.Index = 2;
            this.menuItem63.Text = "-";
            this.menuItem78.Index = 3;
            this.menuItem78.Text = "日志备份(&B)";
            this.menuItem78.Click += new EventHandler(this.menuItem78_Click);
            this.menuItem79.Index = 4;
            this.menuItem79.Text = "-";
            this.menuItem69.Index = 5;
            this.menuItem69.Text = "刷新(&U)";
            this.menuItem69.Click += new EventHandler(this.menuItem69_Click);
            this.menuItem62.Index = 6;
            this.menuItem62.MenuItems.AddRange(new MenuItem[] { this.menuItem64, this.menuItem65, this.menuItem66 });
            this.menuItem62.Text = "查看方式(&V)";
            this.menuItem64.Index = 0;
            this.menuItem64.RadioCheck = true;
            this.menuItem64.Text = "图标(&N)";
            this.menuItem64.Click += new EventHandler(this.menuItem64_Click);
            this.menuItem65.Index = 1;
            this.menuItem65.RadioCheck = true;
            this.menuItem65.Text = "列表(&L)";
            this.menuItem65.Click += new EventHandler(this.menuItem65_Click);
            this.menuItem66.Checked = true;
            this.menuItem66.Index = 2;
            this.menuItem66.RadioCheck = true;
            this.menuItem66.Text = "详细信息(&D)";
            this.menuItem66.Click += new EventHandler(this.menuItem66_Click);
            this.menuItem67.Index = 7;
            this.menuItem67.Text = "-";
            this.menuItem68.Enabled = false;
            this.menuItem68.Index = 8;
            this.menuItem68.Text = "上传日志文件给管理员(&S)";
            this.imageList8.ImageSize = new Size(0x20, 0x20);
            this.imageList8.ImageStream = (ImageListStreamer) manager.GetObject("imageList8.ImageStream");
            this.imageList8.TransparentColor = Color.Transparent;
            this.imageList7.ImageSize = new Size(0x10, 0x10);
            this.imageList7.ImageStream = (ImageListStreamer) manager.GetObject("imageList7.ImageStream");
            this.imageList7.TransparentColor = Color.Transparent;
            this.contextMenu8.MenuItems.AddRange(new MenuItem[] { this.menuItem58, this.menuItem59, this.menuItem60 });
            this.menuItem58.Index = 0;
            this.menuItem58.RadioCheck = true;
            this.menuItem58.Text = "图标(&N)";
            this.menuItem58.Click += new EventHandler(this.menuItem58_Click);
            this.menuItem59.Index = 1;
            this.menuItem59.RadioCheck = true;
            this.menuItem59.Text = "列表(&L)";
            this.menuItem59.Click += new EventHandler(this.menuItem59_Click);
            this.menuItem60.Checked = true;
            this.menuItem60.Index = 2;
            this.menuItem60.RadioCheck = true;
            this.menuItem60.Text = "详细信息(&D)";
            this.menuItem60.Click += new EventHandler(this.menuItem60_Click);
            this.imageList6.ImageSize = new Size(0x10, 0x10);
            this.imageList6.ImageStream = (ImageListStreamer) manager.GetObject("imageList6.ImageStream");
            this.imageList6.TransparentColor = Color.Transparent;
            this.contextMenu7.MenuItems.AddRange(new MenuItem[] { this.menuItem51, this.menuItem54, this.menuItem55, this.menuItem56, this.menuItem52, this.menuItem53 });
            this.menuItem51.Index = 0;
            this.menuItem51.Text = "删除选中";
            this.menuItem51.Click += new EventHandler(this.menuItem51_Click);
            this.menuItem54.Index = 1;
            this.menuItem54.Text = "-";
            this.menuItem55.Index = 2;
            this.menuItem55.Text = "刷新";
            this.menuItem55.Click += new EventHandler(this.menuItem55_Click);
            this.menuItem56.Index = 3;
            this.menuItem56.Text = "-";
            this.menuItem52.Index = 4;
            this.menuItem52.Text = "删除已下载";
            this.menuItem52.Click += new EventHandler(this.menuItem52_Click);
            this.menuItem53.Index = 5;
            this.menuItem53.Text = "删除全部";
            this.menuItem53.Click += new EventHandler(this.menuItem53_Click);
            this.contextMenu5.MenuItems.AddRange(new MenuItem[] { this.menuItem26, this.menuItem27, this.menuItem28, this.menuItem29, this.menuItem30, this.menuItem31, this.menuItem82, this.menuItem32, this.menuItem33, this.menuItem34, this.menuItem83, this.menuItem84 });
            this.menuItem26.Index = 0;
            this.menuItem26.Text = "查找(&S)";
            this.menuItem26.Click += new EventHandler(this.menuItem26_Click);
            this.menuItem27.Index = 1;
            this.menuItem27.Text = "刷新(&U)";
            this.menuItem27.Click += new EventHandler(this.menuItem27_Click);
            this.menuItem28.Index = 2;
            this.menuItem28.Text = "-";
            this.menuItem29.Index = 3;
            this.menuItem29.Text = "清屏(&C)";
            this.menuItem29.Click += new EventHandler(this.menuItem29_Click);
            this.menuItem30.Index = 4;
            this.menuItem30.Text = "-";
            this.menuItem31.Index = 5;
            this.menuItem31.Text = "重置密码(&R)";
            this.menuItem31.Click += new EventHandler(this.menuItem31_Click);
            this.menuItem82.Index = 6;
            this.menuItem82.Text = "修改密码(&E)";
            this.menuItem82.Click += new EventHandler(this.menuItem82_Click);
            this.menuItem32.Index = 7;
            this.menuItem32.Text = "删除(&D)";
            this.menuItem32.Click += new EventHandler(this.menuItem32_Click);
            this.menuItem33.Index = 8;
            this.menuItem33.Text = "-";
            this.menuItem34.Index = 9;
            this.menuItem34.Text = "发送文件(&S)";
            this.menuItem34.Click += new EventHandler(this.menuItem34_Click);
            this.menuItem83.Index = 10;
            this.menuItem83.Text = "-";
            this.menuItem84.Index = 11;
            this.menuItem84.Text = "权限设置(&S)";
            this.menuItem84.Click += new EventHandler(this.menuItem84_Click);
            this.imageList4.ImageSize = new Size(0x10, 0x10);
            this.imageList4.ImageStream = (ImageListStreamer) manager.GetObject("imageList4.ImageStream");
            this.imageList4.TransparentColor = Color.Transparent;
            this.contextMenu10.MenuItems.AddRange(new MenuItem[] { this.menuItem85 });
            this.menuItem85.Index = 0;
            this.menuItem85.Text = "文字大小、颜色设置(&S)";
            this.menuItem85.Click += new EventHandler(this.menuItem85_Click);
            this.imageList2.ImageSize = new Size(0x10, 0x10);
            this.imageList2.ImageStream = (ImageListStreamer) manager.GetObject("imageList2.ImageStream");
            this.imageList2.TransparentColor = Color.Transparent;
            this.contextMenu4.MenuItems.AddRange(new MenuItem[] { this.menuItem24, this.menuItem25 });
            this.menuItem24.Index = 0;
            this.menuItem24.Shortcut = Shortcut.Del;
            this.menuItem24.Text = "删除(&D)";
            this.menuItem24.Click += new EventHandler(this.menuItem24_Click);
            this.menuItem25.Index = 1;
            this.menuItem25.Text = "下载文件(&D)";
            this.menuItem25.Click += new EventHandler(this.menuItem25_Click);
            this.imageList1.ColorDepth = ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new Size(30, 0x10);
            this.imageList1.ImageStream = (ImageListStreamer) manager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.contextMenu3.MenuItems.AddRange(new MenuItem[] { this.menuItem17, this.menuItem23, this.menuItem18, this.menuItem19, this.menuItem35, this.menuItem36 });
            this.menuItem17.Index = 0;
            this.menuItem17.Shortcut = Shortcut.Del;
            this.menuItem17.Text = "删除(连同服务器上相应的数据和文件)(&T)";
            this.menuItem17.Click += new EventHandler(this.menuItem17_Click);
            this.menuItem23.Index = 1;
            this.menuItem23.Text = "-";
            this.menuItem18.Index = 2;
            this.menuItem18.Text = "打开/运行已下载的文件(&F)";
            this.menuItem18.Click += new EventHandler(this.menuItem18_Click);
            this.menuItem19.Index = 3;
            this.menuItem19.Text = "打开存放该文件的目录(&S)";
            this.menuItem19.Click += new EventHandler(this.menuItem19_Click);
            this.menuItem35.Index = 4;
            this.menuItem35.Text = "-";
            this.menuItem36.Index = 5;
            this.menuItem36.Text = "查看订单信息(&V)";
            this.menuItem36.Click += new EventHandler(this.menuItem36_Click);
            this.contextMenu2.MenuItems.AddRange(new MenuItem[] { this.menuItem72, this.menuItem14, this.menuItem22, this.menuItem80, this.menuItem81, this.menuItem70, this.menuItem71, this.menuItem15, this.menuItem16, this.menuItem37, this.menuItem38 });
            this.menuItem72.Index = 0;
            this.menuItem72.Shortcut = Shortcut.Del;
            this.menuItem72.Text = "删除(&T)";
            this.menuItem72.Click += new EventHandler(this.menuItem72_Click);
            this.menuItem14.Index = 1;
            this.menuItem14.Shortcut = Shortcut.ShiftDel;
            this.menuItem14.Text = "删除(连同服务器中相应的数据和文件)(&T)";
            this.menuItem14.Click += new EventHandler(this.menuItem14_Click);
            this.menuItem22.Index = 2;
            this.menuItem22.Text = "-";
            this.menuItem80.Index = 3;
            this.menuItem80.Text = "另存为(&A)...";
            this.menuItem80.Click += new EventHandler(this.menuItem80_Click);
            this.menuItem81.Index = 4;
            this.menuItem81.Text = "-";
            this.menuItem70.Index = 5;
            this.menuItem70.Text = "重新下载(&D)";
            this.menuItem70.Click += new EventHandler(this.menuItem70_Click);
            this.menuItem71.Index = 6;
            this.menuItem71.Text = "-";
            this.menuItem15.Index = 7;
            this.menuItem15.Text = "打开/运行已下载的文件(&F)";
            this.menuItem15.Click += new EventHandler(this.menuItem15_Click);
            this.menuItem16.Index = 8;
            this.menuItem16.Text = "打开存放该文件的目录(&S)";
            this.menuItem16.Click += new EventHandler(this.menuItem16_Click);
            this.menuItem37.Index = 9;
            this.menuItem37.Text = "-";
            this.menuItem38.Index = 10;
            this.menuItem38.Text = "查看订单信息(&V)";
            this.menuItem38.Click += new EventHandler(this.menuItem38_Click);
            this.contextMenu1.MenuItems.AddRange(new MenuItem[] { this.menuItem9, this.menuItem10, this.menuItem20, this.menuItem11, this.menuItem12, this.menuItem21, this.menuItem13 });
            this.contextMenu1.Popup += new EventHandler(this.contextMenu1_Popup);
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "开始(&S)";
            this.menuItem9.Click += new EventHandler(this.menuItem9_Click);
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "暂停(&P)";
            this.menuItem10.Click += new EventHandler(this.menuItem10_Click);
            this.menuItem20.Index = 2;
            this.menuItem20.Text = "-";
            this.menuItem11.Index = 3;
            this.menuItem11.Text = "全部开始(&A)";
            this.menuItem11.Click += new EventHandler(this.menuItem11_Click);
            this.menuItem12.Index = 4;
            this.menuItem12.Text = "全部暂停(&A)";
            this.menuItem12.Click += new EventHandler(this.menuItem12_Click);
            this.menuItem21.Index = 5;
            this.menuItem21.Text = "-";
            this.menuItem13.Index = 6;
            this.menuItem13.Shortcut = Shortcut.Del;
            this.menuItem13.Text = "删除(&T)";
            this.menuItem13.Click += new EventHandler(this.menuItem13_Click);
            this.timer2.Enabled = true;
            this.timer2.Interval = 0x3e8;
            this.timer2.Tick += new EventHandler(this.timer2_Tick);
            this.panel11.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.panel11.BackColor = Color.Gainsboro;
            this.panel11.BorderStyle = BorderStyle.FixedSingle;
            this.panel11.ForeColor = Color.Coral;
            this.panel11.Location = new Point(0x310, 0x44);
            this.panel11.Name = "panel11";
            this.panel11.Size = new Size(160, 0x24);
            this.panel11.TabIndex = 7;
            this.panel11.Paint += new PaintEventHandler(this.panel11_Paint);
            this.toolTip_Element.AutoPopDelay = 0x7530;
            this.toolTip_Element.InitialDelay = 500;
            this.toolTip_Element.ReshowDelay = 100;
            this.toolTip_Element.ShowAlways = true;
            this.notifyIcon1.ContextMenu = this.contextMenu6;
            this.notifyIcon1.Icon = (Icon) manager.GetObject("notifyIcon1.Icon");
            this.notifyIcon1.Text = "印易在线服务平台";
            this.notifyIcon1.Visible = true;
            this.contextMenu6.MenuItems.AddRange(new MenuItem[] { this.menuItem39, this.menuItem40, this.menuItem41, this.menuItem42, this.menuItem43, this.menuItem47, this.menuItem44, this.menuItem45, this.menuItem49, this.menuItem48, this.menuItem50, this.menuItem46 });
            this.menuItem39.Index = 0;
            this.menuItem39.Text = "打开/隐藏(&O)";
            this.menuItem39.Click += new EventHandler(this.menuItem39_Click);
            this.menuItem40.Index = 1;
            this.menuItem40.Text = "-";
            this.menuItem41.Index = 2;
            this.menuItem41.Text = "设置(&S)";
            this.menuItem41.Click += new EventHandler(this.menuItem41_Click);
            this.menuItem42.Index = 3;
            this.menuItem42.Text = "-";
            this.menuItem43.Index = 4;
            this.menuItem43.Text = "平台使用手册(&M)";
            this.menuItem43.Click += new EventHandler(this.menuItem43_Click);
            this.menuItem47.Index = 5;
            this.menuItem47.Text = "广州印网主页(&W)";
            this.menuItem47.Click += new EventHandler(this.menuItem47_Click);
            this.menuItem44.Index = 6;
            this.menuItem44.Text = "关于印易在线服务平台(&A)";
            this.menuItem44.Click += new EventHandler(this.menuItem44_Click);
            this.menuItem45.Index = 7;
            this.menuItem45.Text = "-";
            this.menuItem49.Enabled = false;
            this.menuItem49.Index = 8;
            this.menuItem49.Text = "登录(&I)...";
            this.menuItem49.Click += new EventHandler(this.menuItem49_Click);
            this.menuItem48.Index = 9;
            this.menuItem48.Text = "注销(&N)";
            this.menuItem48.Click += new EventHandler(this.menuItem48_Click);
            this.menuItem50.Index = 10;
            this.menuItem50.Text = "-";
            this.menuItem46.Index = 11;
            this.menuItem46.Text = "退出(&X)";
            this.menuItem46.Click += new EventHandler(this.menuItem46_Click);
            this.saveFileDialog1.Filter = "平台日志文件|*.ePrintLog";
            this.label19.BackColor = SystemColors.Info;
            this.label19.BorderStyle = BorderStyle.FixedSingle;
            this.label19.Image = (Image) manager.GetObject("label19.Image");
            this.label19.ImageAlign = ContentAlignment.MiddleLeft;
            this.label19.Location = new Point(0, 0x128);
            this.label19.Name = "label19";
            this.label19.Size = new Size(80, 0x18);
            this.label19.TabIndex = 9;
            this.label19.Text = "　 双击打开";
            this.label19.Visible = false;
            this.groupBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.groupBox1.BackColor = SystemColors.ControlLight;
            this.groupBox1.Location = new Point(-32, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x3f0, 3);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.panel1.BackColor = SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x3b8, 0x40);
            this.panel1.TabIndex = 0;
            this.pictureBox1.BackgroundImage = (Image) manager.GetObject("pictureBox1.BackgroundImage");
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.Image = (Image) manager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x3b8, 0x40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.saveFileDialog2.Filter = "所有文件|*.*";
            this.fontDialog1.ShowColor = true;
            this.fontDialog1.ShowEffects = false;
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tp3);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new Point(0xb8, 0x88);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new Size(760, 440);
            this.tabControl2.TabIndex = 15;
            this.tabControl2.Visible = false;
            this.tabPage7.Controls.Add(this.PnlFunc1);
            this.tabPage7.Location = new Point(4, 0x15);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.RightToLeft = RightToLeft.Yes;
            this.tabPage7.Size = new Size(0x2f0, 0x19f);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Visible = false;
            this.PnlFunc1.Controls.Add(this.panel5);
            this.PnlFunc1.Controls.Add(this.splitter2);
            this.PnlFunc1.Controls.Add(this.panel22);
            this.PnlFunc1.Dock = DockStyle.Fill;
            this.PnlFunc1.Location = new Point(0, 0);
            this.PnlFunc1.Name = "PnlFunc1";
            this.PnlFunc1.Size = new Size(0x2f0, 0x19f);
            this.PnlFunc1.TabIndex = 6;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.splitter3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = DockStyle.Fill;
            this.panel5.Location = new Point(0, 0xc3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new Size(0x2f0, 220);
            this.panel5.TabIndex = 2;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.listView3);
            this.panel7.Controls.Add(this.listView1);
            this.panel7.Controls.Add(this.glacialList5);
            this.panel7.Location = new Point(120, 0x18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new Size(0x285, 220);
            this.panel7.TabIndex = 2;
            this.panel8.Location = new Point(0x80, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new Size(0x130, 0x20);
            this.panel8.TabIndex = 1;
            this.listView3.Columns.AddRange(new ColumnHeader[] { this.columnHeader3, this.columnHeader4 });
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HoverSelection = true;
            this.listView3.Location = new Point(0x58, 0x2f);
            this.listView3.Name = "listView3";
            this.listView3.Size = new Size(0x285, 80);
            this.listView3.Sorting = SortOrder.Ascending;
            this.listView3.TabIndex = 0;
            this.listView3.View = View.Details;
            this.columnHeader3.Text = "订单项";
            this.columnHeader4.Text = "订单信息";
            this.columnHeader4.TextAlign = HorizontalAlignment.Right;
            this.columnHeader4.Width = 400;
            this.listView1.AutoHeight = false;
            this.listView1.BackColor = SystemColors.Window;
            column.ImageIndex = 3;
            column.Name = "Column1";
            column.Text = "时间";
            column.Width = 150;
            column2.Name = "Column2";
            column2.Text = "信息";
            column2.Width = 700;
            this.listView1.Columns.AddRange(new GLColumn[] { column, column2 });
            this.listView1.ContextMenu = this.contextMenu10;
            this.listView1.GridLineStyle = GLGridLineStyles.gridDashed;
            this.listView1.HideSelection = true;
            this.listView1.HotTrackingColor = SystemColors.HotTrack;
            this.listView1.ImageList = this.imageList2;
            this.listView1.ItemHeight = 0x11;
            this.listView1.Location = new Point(0x38, 0x20);
            this.listView1.Name = "listView1";
            this.listView1.SelectedTextColor = SystemColors.HighlightText;
            this.listView1.SelectionColor = SystemColors.Highlight;
            this.listView1.Size = new Size(0x1a0, 0x80);
            this.listView1.TabIndex = 3;
            this.listView1.Text = "glacialList8";
            this.listView1.UnfocusedSelectionColor = SystemColors.Highlight;
            this.glacialList5.AutoHeight = false;
            this.glacialList5.BackColor = SystemColors.Window;
            column3.Name = "Column1";
            column3.Text = "订单项";
            column3.Width = 150;
            column4.Name = "Column2";
            column4.Text = "订单信息";
            column4.Width = 700;
            this.glacialList5.Columns.AddRange(new GLColumn[] { column3, column4 });
            this.glacialList5.ContextMenu = this.contextMenu10;
            this.glacialList5.GridLineStyle = GLGridLineStyles.gridDashed;
            this.glacialList5.HideSelection = true;
            this.glacialList5.HotTrackingColor = SystemColors.HotTrack;
            this.glacialList5.ImageList = null;
            this.glacialList5.ItemHeight = 0x11;
            this.glacialList5.Location = new Point(0x18, 0x10);
            this.glacialList5.Name = "glacialList5";
            this.glacialList5.SelectedTextColor = SystemColors.HighlightText;
            this.glacialList5.SelectionColor = SystemColors.Highlight;
            this.glacialList5.Size = new Size(0x285, 0xb0);
            this.glacialList5.TabIndex = 2;
            this.glacialList5.Text = "glacialList5";
            this.glacialList5.UnfocusedSelectionColor = SystemColors.Highlight;
            this.splitter3.Location = new Point(0x68, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new Size(3, 220);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            this.panel6.Controls.Add(this.treeView2);
            this.panel6.Dock = DockStyle.Left;
            this.panel6.Location = new Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new Size(0x68, 220);
            this.panel6.TabIndex = 0;
            this.treeView2.BorderStyle = BorderStyle.FixedSingle;
            this.treeView2.Dock = DockStyle.Fill;
            this.treeView2.ImageList = this.imageList3;
            this.treeView2.Location = new Point(0, 0);
            this.treeView2.Name = "treeView2";
            this.treeView2.Nodes.AddRange(new TreeNode[] { new TreeNode("订单信息", 0x11, 0x11, new TreeNode[] { new TreeNode("设置", 0x16, 0x16) }), new TreeNode("图表/日志", 0x12, 0x12) });
            this.treeView2.SelectedImageIndex = 0x16;
            this.treeView2.ShowPlusMinus = false;
            this.treeView2.Size = new Size(0x68, 220);
            this.treeView2.TabIndex = 0;
            this.treeView2.MouseDown += new MouseEventHandler(this.treeView2_MouseDown);
            this.treeView2.Leave += new EventHandler(this.treeView2_Leave);
            this.splitter2.Dock = DockStyle.Top;
            this.splitter2.Location = new Point(0, 0xc0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new Size(0x2f0, 3);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            this.panel22.Controls.Add(this.button3);
            this.panel22.Controls.Add(this.glacialList1);
            this.panel22.Controls.Add(this.glacialList4);
            this.panel22.Controls.Add(this.glacialList3);
            this.panel22.Controls.Add(this.glacialList2);
            this.panel22.Dock = DockStyle.Top;
            this.panel22.Location = new Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new Size(0x2f0, 0xc0);
            this.panel22.TabIndex = 0;
            this.button3.Enabled = false;
            this.button3.Location = new Point(0xa8, 0x40);
            this.button3.Name = "button3";
            this.button3.Size = new Size(300, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "正在保存数据，请稍候......";
            this.button3.Visible = false;
            this.glacialList1.AllowDrop = true;
            this.glacialList1.BackColor = SystemColors.Window;
            column5.ImageIndex = 15;
            column5.Name = "Column1";
            column5.Text = "状态";
            column5.Width = 40;
            column6.Name = "Column2";
            column6.Text = "工单编号";
            column6.Width = 60;
            column7.Name = "Column3";
            column7.Text = "文件名称";
            column8.Name = "Column4";
            column8.Text = "文件大小";
            column8.Width = 60;
            column9.Name = "Column5";
            column9.Text = "完成数";
            column9.Width = 60;
            column10.Name = "Column6";
            column10.Text = "百分比";
            column10.TextAlignment = ContentAlignment.MiddleRight;
            column10.Width = 120;
            column11.Name = "Column7";
            column11.Text = "已用时间";
            column11.TextAlignment = ContentAlignment.MiddleCenter;
            column11.Width = 0x4b;
            column12.Name = "Column8";
            column12.Text = "剩余时间";
            column12.TextAlignment = ContentAlignment.MiddleCenter;
            column12.Width = 0x4b;
            column13.Name = "Column9";
            column13.Text = "速度";
            column13.Width = 70;
            column14.Name = "Column10";
            column14.Text = "块数";
            column14.Width = 40;
            column15.Name = "Column11";
            column15.Text = "发件公司";
            column16.Name = "Column12";
            column16.Text = "发件时间";
            this.glacialList1.Columns.AddRange(new GLColumn[] { column5, column6, column7, column8, column9, column10, column11, column12, column13, column14, column15, column16 });
            this.glacialList1.ContextMenu = this.contextMenu1;
            this.glacialList1.Dock = DockStyle.Fill;
            this.glacialList1.GridLines = GLGridLines.gridHorizontal;
            this.glacialList1.GridLineStyle = GLGridLineStyles.gridNone;
            this.glacialList1.HotTrackingColor = SystemColors.HotTrack;
            this.glacialList1.ImageList = this.imageList1;
            this.glacialList1.ItemHeight = 20;
            this.glacialList1.Location = new Point(0, 0);
            this.glacialList1.Name = "glacialList1";
            this.glacialList1.SelectedTextColor = SystemColors.HighlightText;
            this.glacialList1.SelectionColor = SystemColors.Highlight;
            this.glacialList1.Size = new Size(0x2f0, 0xc0);
            this.glacialList1.TabIndex = 0;
            this.glacialList1.Text = "glacialList1";
            this.glacialList1.UnfocusedSelectionColor = SystemColors.Highlight;
            this.glacialList1.MouseUp += new MouseEventHandler(this.glacialList1_MouseUp);
            this.glacialList1.DoubleClick += new EventHandler(this.glacialList1_DoubleClick);
            this.glacialList1.MouseMove += new MouseEventHandler(this.glacialList1_MouseMove);
            this.glacialList1.MouseDown += new MouseEventHandler(this.glacialList1_MouseDown);
            this.glacialList1.ItemChangedEvent += new GLChangedEventHandler(this.glacialList1_ItemChangedEvent);
            this.glacialList1.SelectedIndexChanged += new GlacialList.ClickedEventHandler(this.glacialList1_SelectedIndexChanged);
            this.glacialList4.BackColor = SystemColors.Window;
            column17.Name = "Column1";
            column17.Text = "状态";
            column17.Width = 40;
            column18.Name = "Column2";
            column18.Text = "工单编号";
            column18.Width = 60;
            column19.Name = "Column3";
            column19.Text = "文件名称";
            column19.Width = 150;
            column20.Name = "Column4";
            column20.Text = "文件大小";
            column21.Name = "Column5";
            column21.Text = "发件公司";
            column21.Width = 150;
            column22.Name = "Column6";
            column22.Text = "发件时间";
            column22.Width = 150;
            column23.Name = "Column7";
            column23.SortType = SortTypes.None;
            column23.Text = "";
            column23.Width = 200;
            this.glacialList4.Columns.AddRange(new GLColumn[] { column17, column18, column19, column20, column21, column22, column23 });
            this.glacialList4.ContextMenu = this.contextMenu4;
            this.glacialList4.Dock = DockStyle.Fill;
            this.glacialList4.ForeColor = Color.DarkGoldenrod;
            this.glacialList4.GridLineStyle = GLGridLineStyles.gridNone;
            this.glacialList4.HideSelection = true;
            this.glacialList4.HotTrackingColor = SystemColors.HotTrack;
            this.glacialList4.ImageList = this.imageList1;
            this.glacialList4.ItemHeight = 0x13;
            this.glacialList4.Location = new Point(0, 0);
            this.glacialList4.Name = "glacialList4";
            this.glacialList4.SelectedTextColor = SystemColors.HighlightText;
            this.glacialList4.SelectionColor = SystemColors.Highlight;
            this.glacialList4.Size = new Size(0x2f0, 0xc0);
            this.glacialList4.TabIndex = 4;
            this.glacialList4.Text = "glacialList4";
            this.glacialList4.UnfocusedSelectionColor = SystemColors.Highlight;
            this.glacialList4.MouseDown += new MouseEventHandler(this.glacialList4_MouseDown);
            this.glacialList4.SelectedIndexChanged += new GlacialList.ClickedEventHandler(this.glacialList4_SelectedIndexChanged);
            this.glacialList3.BackColor = SystemColors.Window;
            column24.Name = "Column2";
            column24.Text = "状态";
            column24.Width = 40;
            column25.Name = "Column3";
            column25.Text = "工单编号";
            column25.Width = 60;
            column26.Name = "Column4";
            column26.Text = "文件名称";
            column27.Name = "Column5";
            column27.Text = "文件大小";
            column27.Width = 60;
            column28.Name = "Column6";
            column28.Text = "删除时间";
            column28.Width = 150;
            column29.Name = "Column7";
            column29.Text = "发件公司";
            column29.Width = 150;
            column30.Name = "Column8";
            column30.Text = "发件时间";
            column30.Width = 150;
            column31.Name = "Column9";
            column31.Text = "保存路径";
            column31.Width = 0xab;
            this.glacialList3.Columns.AddRange(new GLColumn[] { column24, column25, column26, column27, column28, column29, column30, column31 });
            this.glacialList3.ContextMenu = this.contextMenu3;
            this.glacialList3.Dock = DockStyle.Fill;
            this.glacialList3.ForeColor = Color.DarkRed;
            this.glacialList3.GridLineStyle = GLGridLineStyles.gridNone;
            this.glacialList3.HideSelection = true;
            this.glacialList3.HotTrackingColor = SystemColors.HotTrack;
            this.glacialList3.ImageList = this.imageList1;
            this.glacialList3.ItemHeight = 0x13;
            this.glacialList3.Location = new Point(0, 0);
            this.glacialList3.MultiSelect = true;
            this.glacialList3.Name = "glacialList3";
            this.glacialList3.SelectedTextColor = SystemColors.HighlightText;
            this.glacialList3.SelectionColor = SystemColors.Highlight;
            this.glacialList3.Size = new Size(0x2f0, 0xc0);
            this.glacialList3.TabIndex = 2;
            this.glacialList3.Text = "glacialList3";
            this.glacialList3.UnfocusedSelectionColor = SystemColors.Highlight;
            this.glacialList3.MouseMove += new MouseEventHandler(this.glacialList1_MouseMove);
            this.glacialList3.MouseDown += new MouseEventHandler(this.glacialList3_MouseDown);
            this.glacialList3.SelectedIndexChanged += new GlacialList.ClickedEventHandler(this.glacialList3_SelectedIndexChanged);
            this.glacialList2.BackColor = SystemColors.ControlLightLight;
            column32.Name = "Column1";
            column32.Text = "状态";
            column32.Width = 40;
            column33.Name = "Column2";
            column33.Text = "工单编号";
            column33.Width = 60;
            column34.Name = "Column3";
            column34.Text = "文件名称";
            column35.Name = "Column4";
            column35.Text = "文件大小";
            column35.Width = 60;
            column36.Name = "Column5";
            column36.Text = "下载完成时间";
            column36.Width = 150;
            column37.Name = "Column7";
            column37.Text = "发件公司";
            column37.Width = 150;
            column38.Name = "Column8";
            column38.Text = "发件时间";
            column38.Width = 150;
            column39.Name = "Column1x";
            column39.Text = "保存路径";
            column39.Width = 200;
            this.glacialList2.Columns.AddRange(new GLColumn[] { column32, column33, column34, column35, column36, column37, column38, column39 });
            this.glacialList2.ContextMenu = this.contextMenu2;
            this.glacialList2.Dock = DockStyle.Fill;
            this.glacialList2.ForeColor = Color.Blue;
            this.glacialList2.GridLines = GLGridLines.gridHorizontal;
            this.glacialList2.GridLineStyle = GLGridLineStyles.gridNone;
            this.glacialList2.HideSelection = true;
            this.glacialList2.HotTrackingColor = SystemColors.HotTrack;
            this.glacialList2.ImageList = this.imageList1;
            this.glacialList2.ItemHeight = 0x13;
            this.glacialList2.Location = new Point(0, 0);
            this.glacialList2.MultiSelect = true;
            this.glacialList2.Name = "glacialList2";
            this.glacialList2.SelectedTextColor = SystemColors.ControlLightLight;
            this.glacialList2.SelectionColor = SystemColors.Highlight;
            this.glacialList2.Size = new Size(0x2f0, 0xc0);
            this.glacialList2.SuperFlatHeaderColor = Color.LightSteelBlue;
            this.glacialList2.TabIndex = 1;
            this.glacialList2.Text = "glacialList2";
            this.glacialList2.UnfocusedSelectionColor = SystemColors.Highlight;
            this.glacialList2.DoubleClick += new EventHandler(this.glacialList2_DoubleClick);
            this.glacialList2.MouseMove += new MouseEventHandler(this.glacialList1_MouseMove);
            this.glacialList2.MouseDown += new MouseEventHandler(this.glacialList2_MouseDown);
            this.glacialList2.SelectedIndexChanged += new GlacialList.ClickedEventHandler(this.glacialList2_SelectedIndexChanged);
            this.tabPage5.Controls.Add(this.PnlFunc2);
            this.tabPage5.Location = new Point(4, 0x15);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new Size(0x2f0, 0x19f);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Visible = false;
            this.PnlFunc2.BackColor = SystemColors.Control;
            this.PnlFunc2.Controls.Add(this.button7);
            this.PnlFunc2.Controls.Add(this.listView5);
            this.PnlFunc2.Controls.Add(this.panel17);
            this.PnlFunc2.Dock = DockStyle.Fill;
            this.PnlFunc2.Location = new Point(0, 0);
            this.PnlFunc2.Name = "PnlFunc2";
            this.PnlFunc2.Size = new Size(0x2f0, 0x19f);
            this.PnlFunc2.TabIndex = 5;
            this.button7.Enabled = false;
            this.button7.Location = new Point(0x128, 0xa8);
            this.button7.Name = "button7";
            this.button7.Size = new Size(160, 0x30);
            this.button7.TabIndex = 8;
            this.button7.Text = "数据接收中,请稍候...";
            this.button7.Visible = false;
            this.listView5.AllowColumnReorder = true;
            this.listView5.BorderStyle = BorderStyle.FixedSingle;
            this.listView5.CheckBoxes = true;
            this.listView5.Columns.AddRange(new ColumnHeader[] { this.columnHeader23, this.columnHeader13, this.columnHeader14, this.columnHeader16, this.columnHeader17, this.columnHeader18, this.columnHeader19, this.columnHeader20, this.columnHeader21, this.columnHeader24, this.columnHeader25, this.columnHeader22 });
            this.listView5.ContextMenu = this.contextMenu5;
            this.listView5.Dock = DockStyle.Fill;
            this.listView5.FullRowSelect = true;
            this.listView5.GridLines = true;
            this.listView5.Location = new Point(0, 0);
            this.listView5.Name = "listView5";
            this.listView5.Size = new Size(0x2f0, 0xff);
            this.listView5.Sorting = SortOrder.Ascending;
            this.listView5.TabIndex = 12;
            this.listView5.View = View.Details;
            this.columnHeader23.Text = "";
            this.columnHeader23.Width = 20;
            this.columnHeader13.Text = "编号";
            this.columnHeader13.Width = 0x26;
            this.columnHeader14.Text = "帐号名称";
            this.columnHeader14.Width = 100;
            this.columnHeader16.Text = "公司名称";
            this.columnHeader16.Width = 150;
            this.columnHeader17.Text = "公司地址";
            this.columnHeader17.Width = 150;
            this.columnHeader18.Text = "联系人";
            this.columnHeader19.Text = "联系电话";
            this.columnHeader19.Width = 100;
            this.columnHeader20.Text = "传真";
            this.columnHeader20.Width = 100;
            this.columnHeader21.Text = "E-Mail";
            this.columnHeader21.Width = 150;
            this.columnHeader24.Text = "下单数";
            this.columnHeader25.Text = "上次登录时间";
            this.columnHeader25.Width = 150;
            this.columnHeader22.Text = "注册时间";
            this.columnHeader22.Width = 150;
            this.panel17.Controls.Add(this.groupBox2);
            this.panel17.Controls.Add(this.button8);
            this.panel17.Controls.Add(this.button6);
            this.panel17.Controls.Add(this.button5);
            this.panel17.Controls.Add(this.button4);
            this.panel17.Controls.Add(this.button2);
            this.panel17.Controls.Add(this.button1);
            this.panel17.Dock = DockStyle.Bottom;
            this.panel17.Location = new Point(0, 0xff);
            this.panel17.Name = "panel17";
            this.panel17.Size = new Size(0x2f0, 160);
            this.panel17.TabIndex = 13;
            this.groupBox2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new Point(3, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x2eb, 120);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.checkBox1.Location = new Point(0x1c, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(0x38, 0x18);
            this.checkBox1.TabIndex = 0x13;
            this.checkBox1.Text = "全部";
            this.label15.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            this.label15.Image = (Image) manager.GetObject("label15.Image");
            this.label15.Location = new Point(8, 0x10);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x2d3, 0x10);
            this.label15.TabIndex = 0x12;
            this.label15.TextAlign = ContentAlignment.TopCenter;
            this.label15.Click += new EventHandler(this.label15_Click);
            this.label13.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label13.BackColor = Color.LightPink;
            this.label13.BorderStyle = BorderStyle.FixedSingle;
            this.label13.Location = new Point(480, 0x58);
            this.label13.Name = "label13";
            this.label13.Size = new Size(100, 12);
            this.label13.TabIndex = 14;
            this.label12.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label12.BackColor = Color.SteelBlue;
            this.label12.BorderStyle = BorderStyle.FixedSingle;
            this.label12.Location = new Point(480, 0x48);
            this.label12.Name = "label12";
            this.label12.Size = new Size(100, 0x19);
            this.label12.TabIndex = 13;
            this.label11.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label11.BackColor = Color.Silver;
            this.label11.BorderStyle = BorderStyle.FixedSingle;
            this.label11.Location = new Point(480, 0x38);
            this.label11.Name = "label11";
            this.label11.Size = new Size(100, 0x19);
            this.label11.TabIndex = 12;
            this.label10.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label10.BackColor = SystemColors.ControlLightLight;
            this.label10.BorderStyle = BorderStyle.FixedSingle;
            this.label10.Location = new Point(480, 40);
            this.label10.Name = "label10";
            this.label10.Size = new Size(100, 0x19);
            this.label10.TabIndex = 11;
            this.label9.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label9.Location = new Point(0x1a8, 0x58);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x38, 0x1c);
            this.label9.TabIndex = 10;
            this.label9.Text = "前　　台";
            this.label8.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label8.Location = new Point(0x1a8, 0x48);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x38, 0x1c);
            this.label8.TabIndex = 9;
            this.label8.Text = "管 理 员";
            this.label7.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label7.Location = new Point(0x1a8, 0x38);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x38, 0x2c);
            this.label7.TabIndex = 8;
            this.label7.Text = "公共帐号";
            this.label6.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label6.Location = new Point(0x1a8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x38, 60);
            this.label6.TabIndex = 7;
            this.label6.Text = "普通用户";
            this.textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox3.Location = new Point(0x58, 0x58);
            this.textBox3.Name = "textBox3";
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "";
            this.textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox2.Location = new Point(0x58, 0x40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(240, 0x15);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "";
            this.textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox1.Location = new Point(0x58, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x90, 0x15);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            this.label4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label4.Location = new Point(0x18, 0x60);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x40, 0x12);
            this.label4.TabIndex = 2;
            this.label4.Text = "联 系 人:";
            this.label3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label3.Location = new Point(0x18, 0x48);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x40, 0x1c);
            this.label3.TabIndex = 1;
            this.label3.Text = "公司名称:";
            this.label2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label2.Location = new Point(0x18, 0x30);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x40, 0x34);
            this.label2.TabIndex = 0;
            this.label2.Text = "帐号名称:";
            this.button8.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button8.BackColor = Color.LightSteelBlue;
            this.button8.Location = new Point(0x1a0, 0x80);
            this.button8.Name = "button8";
            this.button8.TabIndex = 10;
            this.button8.Text = "增加客户";
            this.button8.ContextMenuChanged += new EventHandler(this.button8_Click);
            this.button6.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button6.BackColor = SystemColors.Control;
            this.button6.Location = new Point(0x10, 0x80);
            this.button6.Name = "button6";
            this.button6.TabIndex = 5;
            this.button6.Text = "查找";
            this.button6.Click += new EventHandler(this.button6_Click);
            this.button5.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button5.BackColor = SystemColors.Control;
            this.button5.Location = new Point(0xb0, 0x80);
            this.button5.Name = "button5";
            this.button5.TabIndex = 4;
            this.button5.Text = "清屏";
            this.button5.Click += new EventHandler(this.button5_Click);
            this.button4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button4.BackColor = SystemColors.Control;
            this.button4.Location = new Point(0x60, 0x80);
            this.button4.Name = "button4";
            this.button4.TabIndex = 3;
            this.button4.Text = "刷新";
            this.button4.Click += new EventHandler(this.button4_Click);
            this.button2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button2.BackColor = SystemColors.Control;
            this.button2.Location = new Point(0x150, 0x80);
            this.button2.Name = "button2";
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button1.BackColor = SystemColors.Control;
            this.button1.Location = new Point(0x100, 0x80);
            this.button1.Name = "button1";
            this.button1.TabIndex = 1;
            this.button1.Text = "重置密码";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.tabPage4.Controls.Add(this.PnlFunc4);
            this.tabPage4.Location = new Point(4, 0x15);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new Size(0x2f0, 0x19f);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Visible = false;
            this.PnlFunc4.Controls.Add(this.panel10);
            this.PnlFunc4.Controls.Add(this.listView6);
            this.PnlFunc4.Dock = DockStyle.Fill;
            this.PnlFunc4.Location = new Point(0, 0);
            this.PnlFunc4.Name = "PnlFunc4";
            this.PnlFunc4.Size = new Size(0x2f0, 0x19f);
            this.PnlFunc4.TabIndex = 6;
            this.panel10.Controls.Add(this.button13);
            this.panel10.Controls.Add(this.button12);
            this.panel10.Controls.Add(this.button11);
            this.panel10.Controls.Add(this.button10);
            this.panel10.Controls.Add(this.button9);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Dock = DockStyle.Bottom;
            this.panel10.Location = new Point(0, 0x16f);
            this.panel10.Name = "panel10";
            this.panel10.Size = new Size(0x2f0, 0x30);
            this.panel10.TabIndex = 7;
            this.button13.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button13.BackColor = SystemColors.Control;
            this.button13.Location = new Point(0x108, 8);
            this.button13.Name = "button13";
            this.button13.TabIndex = 6;
            this.button13.Text = "删除全部";
            this.button13.Click += new EventHandler(this.button13_Click);
            this.button12.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button12.BackColor = SystemColors.Control;
            this.button12.Location = new Point(0xb8, 8);
            this.button12.Name = "button12";
            this.button12.TabIndex = 5;
            this.button12.Text = "删除已下载";
            this.button12.Click += new EventHandler(this.button12_Click);
            this.button11.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button11.BackColor = SystemColors.Control;
            this.button11.Location = new Point(0x68, 8);
            this.button11.Name = "button11";
            this.button11.TabIndex = 3;
            this.button11.Text = "刷新";
            this.button11.Click += new EventHandler(this.button11_Click);
            this.button10.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button10.BackColor = SystemColors.Control;
            this.button10.Location = new Point(0x158, 8);
            this.button10.Name = "button10";
            this.button10.TabIndex = 2;
            this.button10.Text = "发送文件";
            this.button10.Click += new EventHandler(this.button10_Click);
            this.button9.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button9.BackColor = SystemColors.Control;
            this.button9.Location = new Point(0x18, 8);
            this.button9.Name = "button9";
            this.button9.TabIndex = 1;
            this.button9.Text = "删除";
            this.button9.Click += new EventHandler(this.button9_Click);
            this.label14.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label14.Location = new Point(0x1c0, 8);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0xd8, 0x17);
            this.label14.TabIndex = 4;
            this.listView6.AllowColumnReorder = true;
            this.listView6.BorderStyle = BorderStyle.FixedSingle;
            this.listView6.CheckBoxes = true;
            this.listView6.Columns.AddRange(new ColumnHeader[] { this.columnHeader32, this.columnHeader26, this.columnHeader27, this.columnHeader28, this.columnHeader29, this.columnHeader30, this.columnHeader31 });
            this.listView6.ContextMenu = this.contextMenu7;
            this.listView6.Dock = DockStyle.Fill;
            this.listView6.FullRowSelect = true;
            this.listView6.Location = new Point(0, 0);
            this.listView6.Name = "listView6";
            this.listView6.Size = new Size(0x2f0, 0x19f);
            this.listView6.TabIndex = 0;
            this.listView6.View = View.Details;
            this.columnHeader32.Text = "";
            this.columnHeader32.Width = 20;
            this.columnHeader26.Text = "收件公司";
            this.columnHeader26.Width = 150;
            this.columnHeader27.Text = "文件名称";
            this.columnHeader27.Width = 150;
            this.columnHeader28.Text = "文件大小";
            this.columnHeader29.Text = "文件备注";
            this.columnHeader29.Width = 100;
            this.columnHeader30.Text = "发送时间";
            this.columnHeader30.Width = 130;
            this.columnHeader31.Text = "文件状态";
            this.tp3.Controls.Add(this.PnlFunc3);
            this.tp3.Location = new Point(4, 0x15);
            this.tp3.Name = "tp3";
            this.tp3.Size = new Size(0x2f0, 0x19f);
            this.tp3.TabIndex = 0;
            this.PnlFunc3.Controls.Add(this.listView7);
            this.PnlFunc3.Controls.Add(this.toolBar2);
            this.PnlFunc3.Dock = DockStyle.Fill;
            this.PnlFunc3.Location = new Point(0, 0);
            this.PnlFunc3.Name = "PnlFunc3";
            this.PnlFunc3.Size = new Size(0x2f0, 0x19f);
            this.PnlFunc3.TabIndex = 7;
            this.listView7.AllowColumnReorder = true;
            this.listView7.BorderStyle = BorderStyle.FixedSingle;
            this.listView7.Columns.AddRange(new ColumnHeader[] { this.columnHeader33, this.columnHeader34, this.columnHeader35, this.columnHeader36 });
            this.listView7.ContextMenu = this.contextMenu9;
            this.listView7.Dock = DockStyle.Fill;
            this.listView7.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.listView7.LargeImageList = this.imageList8;
            this.listView7.Location = new Point(0, 0x1c);
            this.listView7.Name = "listView7";
            this.listView7.Size = new Size(0x2f0, 0x183);
            this.listView7.SmallImageList = this.imageList7;
            this.listView7.Sorting = SortOrder.Descending;
            this.listView7.TabIndex = 8;
            this.listView7.View = View.Details;
            this.listView7.DoubleClick += new EventHandler(this.listView7_DoubleClick);
            this.columnHeader33.Text = "文件名称";
            this.columnHeader33.Width = 150;
            this.columnHeader34.Text = "文件大小";
            this.columnHeader34.Width = 80;
            this.columnHeader35.Text = "修改时间";
            this.columnHeader35.Width = 180;
            this.columnHeader36.Text = "创建时间";
            this.columnHeader36.Width = 180;
            this.toolBar2.Appearance = ToolBarAppearance.Flat;
            this.toolBar2.Buttons.AddRange(new ToolBarButton[] { this.toolBarButton14, this.toolBarButton16, this.toolBarButton17, this.toolBarButton18 });
            this.toolBar2.ButtonSize = new Size(0x17, 0x16);
            this.toolBar2.DropDownArrows = true;
            this.toolBar2.ImageList = this.imageList6;
            this.toolBar2.Location = new Point(0, 0);
            this.toolBar2.Name = "toolBar2";
            this.toolBar2.ShowToolTips = true;
            this.toolBar2.Size = new Size(0x2f0, 0x1c);
            this.toolBar2.TabIndex = 9;
            this.toolBar2.ButtonClick += new ToolBarButtonClickEventHandler(this.toolBar2_ButtonClick);
            this.toolBarButton14.ImageIndex = 4;
            this.toolBarButton14.ToolTipText = "查看日志";
            this.toolBarButton16.ImageIndex = 5;
            this.toolBarButton16.ToolTipText = "删除日志";
            this.toolBarButton17.Enabled = false;
            this.toolBarButton17.ImageIndex = 2;
            this.toolBarButton17.ToolTipText = "上传日志文件给管理员";
            this.toolBarButton18.DropDownMenu = this.contextMenu8;
            this.toolBarButton18.ImageIndex = 3;
            this.toolBarButton18.Style = ToolBarButtonStyle.DropDownButton;
            this.toolBarButton18.ToolTipText = "查看方式";
            this.tabPage6.Controls.Add(this.panel43);
            this.tabPage6.Location = new Point(4, 0x15);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new Size(0x2f0, 0x19f);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Visible = false;
            this.panel43.Controls.Add(this.PnlFunc5);
            this.panel43.Dock = DockStyle.Fill;
            this.panel43.Location = new Point(0, 0);
            this.panel43.Name = "panel43";
            this.panel43.Size = new Size(0x2f0, 0x19f);
            this.panel43.TabIndex = 15;
            this.PnlFunc5.Controls.Add(this.tabControl1);
            this.PnlFunc5.Dock = DockStyle.Fill;
            this.PnlFunc5.Location = new Point(0, 0);
            this.PnlFunc5.Name = "PnlFunc5";
            this.PnlFunc5.Size = new Size(0x2f0, 0x19f);
            this.PnlFunc5.TabIndex = 0;
            this.tabControl1.Appearance = TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(0x2f0, 0x19f);
            this.tabControl1.TabIndex = 1;
            this.tabPage1.Controls.Add(this.button18);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.button17);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.listView8);
            this.tabPage1.Location = new Point(4, 0x18);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new Size(0x2e8, 0x183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "公司公告";
            this.button18.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button18.Location = new Point(240, 0x167);
            this.button18.Name = "button18";
            this.button18.TabIndex = 8;
            this.button18.Text = "刷新";
            this.button18.Click += new EventHandler(this.button18_Click);
            this.label5.Location = new Point(0, 0xb0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x48, 0x10);
            this.label5.TabIndex = 7;
            this.label5.Text = "公告内容：";
            this.label25.Location = new Point(0, 0x88);
            this.label25.Name = "label25";
            this.label25.Size = new Size(0x48, 0x10);
            this.label25.TabIndex = 6;
            this.label25.Text = "公告标题：";
            this.button17.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button17.Location = new Point(160, 0x167);
            this.button17.Name = "button17";
            this.button17.TabIndex = 5;
            this.button17.Text = "新增";
            this.button17.Click += new EventHandler(this.button17_Click);
            this.textBox6.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.textBox6.Location = new Point(0, 0x98);
            this.textBox6.MaxLength = 200;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(0x2e2, 0x15);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "";
            this.button15.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button15.Location = new Point(80, 0x167);
            this.button15.Name = "button15";
            this.button15.TabIndex = 3;
            this.button15.Text = "删除";
            this.button15.Click += new EventHandler(this.button15_Click);
            this.button14.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button14.Location = new Point(0, 0x167);
            this.button14.Name = "button14";
            this.button14.TabIndex = 2;
            this.button14.Text = "修改";
            this.button14.Click += new EventHandler(this.button14_Click);
            this.textBox4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox4.Location = new Point(0, 0xc0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(0x2e2, 0x9f);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "";
            this.listView8.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.listView8.Columns.AddRange(new ColumnHeader[] { this.columnHeader15, this.columnHeader40, this.columnHeader41 });
            this.listView8.FullRowSelect = true;
            this.listView8.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.listView8.Location = new Point(0, 0);
            this.listView8.MultiSelect = false;
            this.listView8.Name = "listView8";
            this.listView8.Size = new Size(0x2e8, 0x81);
            this.listView8.TabIndex = 0;
            this.listView8.View = View.Details;
            this.listView8.Click += new EventHandler(this.listView8_Click);
            this.listView8.SelectedIndexChanged += new EventHandler(this.listView8_SelectedIndexChanged);
            this.columnHeader15.Text = "公告标题";
            this.columnHeader15.Width = 200;
            this.columnHeader40.Text = "公司内容";
            this.columnHeader40.Width = 280;
            this.columnHeader41.Text = "发布时间";
            this.columnHeader41.Width = 150;
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Location = new Point(4, 0x18);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new Size(0x2e8, 0x183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "公司声明";
            this.tabPage2.Visible = false;
            this.button16.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button16.Location = new Point(0, 0x167);
            this.button16.Name = "button16";
            this.button16.TabIndex = 1;
            this.button16.Text = "修改";
            this.button16.Click += new EventHandler(this.button16_Click);
            this.textBox5.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.textBox5.BorderStyle = BorderStyle.FixedSingle;
            this.textBox5.Location = new Point(0, 0);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(0x2e8, 0x164);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "";
            this.tabPage8.Controls.Add(this.PnlFunc6);
            this.tabPage8.Location = new Point(4, 0x15);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new Size(0x2f0, 0x19f);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Visible = false;
            this.PnlFunc6.BackColor = SystemColors.Control;
            this.PnlFunc6.Controls.Add(this.panel14);
            this.PnlFunc6.Controls.Add(this.splitter4);
            this.PnlFunc6.Controls.Add(this.panel13);
            this.PnlFunc6.Dock = DockStyle.Fill;
            this.PnlFunc6.Location = new Point(0, 0);
            this.PnlFunc6.Name = "PnlFunc6";
            this.PnlFunc6.Size = new Size(0x2f0, 0x19f);
            this.PnlFunc6.TabIndex = 14;
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.splitter5);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = DockStyle.Fill;
            this.panel14.Location = new Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new Size(0x2f0, 260);
            this.panel14.TabIndex = 2;
            this.panel16.Controls.Add(this.statusBar3);
            this.panel16.Controls.Add(this.listView4);
            this.panel16.Controls.Add(this.comboBox2);
            this.panel16.Dock = DockStyle.Fill;
            this.panel16.Location = new Point(0x161, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new Size(0x18f, 260);
            this.panel16.TabIndex = 2;
            this.statusBar3.Location = new Point(0, 0xee);
            this.statusBar3.Name = "statusBar3";
            this.statusBar3.Panels.AddRange(new StatusBarPanel[] { this.statusBarPanel8, this.statusBarPanel9, this.statusBarPanel10 });
            this.statusBar3.ShowPanels = true;
            this.statusBar3.Size = new Size(0x18f, 0x16);
            this.statusBar3.TabIndex = 2;
            this.statusBarPanel8.Alignment = HorizontalAlignment.Center;
            this.statusBarPanel9.Alignment = HorizontalAlignment.Center;
            this.statusBarPanel10.Alignment = HorizontalAlignment.Center;
            this.statusBarPanel10.AutoSize = StatusBarPanelAutoSize.Spring;
            this.statusBarPanel10.Width = 0xb7;
            this.listView4.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.listView4.BorderStyle = BorderStyle.FixedSingle;
            this.listView4.Columns.AddRange(new ColumnHeader[] { this.columnHeader8, this.columnHeader9, this.columnHeader12, this.columnHeader10, this.columnHeader11 });
            this.listView4.Location = new Point(0, 0x18);
            this.listView4.Name = "listView4";
            this.listView4.Size = new Size(0x1cd, 0xd5);
            this.listView4.SmallImageList = this.imageList4;
            this.listView4.TabIndex = 1;
            this.listView4.View = View.Details;
            this.columnHeader8.Text = "文件名称";
            this.columnHeader8.Width = 150;
            this.columnHeader9.Text = "文件大小";
            this.columnHeader12.Text = "工单编号";
            this.columnHeader10.Text = "发件公司";
            this.columnHeader10.Width = 80;
            this.columnHeader11.Text = "发件时间";
            this.columnHeader11.Width = 150;
            this.comboBox2.Dock = DockStyle.Top;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.Location = new Point(0, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new Size(0x18f, 0x15);
            this.comboBox2.TabIndex = 0;
            this.splitter5.Location = new Point(350, 0);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new Size(3, 260);
            this.splitter5.TabIndex = 1;
            this.splitter5.TabStop = false;
            this.panel15.Controls.Add(this.statusBar2);
            this.panel15.Controls.Add(this.listView2);
            this.panel15.Controls.Add(this.comboBox1);
            this.panel15.Dock = DockStyle.Left;
            this.panel15.Location = new Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new Size(350, 260);
            this.panel15.TabIndex = 0;
            this.statusBar2.Location = new Point(0, 0xee);
            this.statusBar2.Name = "statusBar2";
            this.statusBar2.Panels.AddRange(new StatusBarPanel[] { this.statusBarPanel5, this.statusBarPanel6, this.statusBarPanel7 });
            this.statusBar2.ShowPanels = true;
            this.statusBar2.Size = new Size(350, 0x16);
            this.statusBar2.TabIndex = 2;
            this.statusBarPanel5.Alignment = HorizontalAlignment.Center;
            this.statusBarPanel6.Alignment = HorizontalAlignment.Center;
            this.statusBarPanel7.Alignment = HorizontalAlignment.Center;
            this.statusBarPanel7.AutoSize = StatusBarPanelAutoSize.Spring;
            this.statusBarPanel7.Width = 0x86;
            this.listView2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.listView2.AutoArrange = false;
            this.listView2.BorderStyle = BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new ColumnHeader[] { this.columnHeader5, this.columnHeader6, this.columnHeader7 });
            this.listView2.Location = new Point(0, 0x18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new Size(0x158, 0xd5);
            this.listView2.SmallImageList = this.imageList4;
            this.listView2.TabIndex = 1;
            this.listView2.View = View.Details;
            this.columnHeader5.Text = "文件名称";
            this.columnHeader5.Width = 150;
            this.columnHeader6.Text = "大小";
            this.columnHeader7.Text = "日期";
            this.columnHeader7.Width = 200;
            this.comboBox1.Dock = DockStyle.Top;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(350, 0x15);
            this.comboBox1.TabIndex = 0;
            this.splitter4.Dock = DockStyle.Bottom;
            this.splitter4.Location = new Point(0, 260);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new Size(0x2f0, 3);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            this.panel13.Controls.Add(this.glacialList6);
            this.panel13.Dock = DockStyle.Bottom;
            this.panel13.Location = new Point(0, 0x107);
            this.panel13.Name = "panel13";
            this.panel13.Size = new Size(0x2f0, 0x98);
            this.panel13.TabIndex = 0;
            this.glacialList6.BackColor = SystemColors.Window;
            column40.Name = "Column1";
            column40.Text = "文件";
            column40.Width = 300;
            column41.ItemComparerType = ItemComparerTypes.Numeric;
            column41.Name = "Column3";
            column41.Text = "文件大小";
            column42.Name = "Column2";
            column42.Text = "下载进度";
            column42.Width = 150;
            column43.Name = "Column4";
            column43.SortType = SortTypes.None;
            column43.Text = "";
            column43.Width = 300;
            this.glacialList6.Columns.AddRange(new GLColumn[] { column40, column41, column42, column43 });
            this.glacialList6.Dock = DockStyle.Fill;
            this.glacialList6.GridLineStyle = GLGridLineStyles.gridNone;
            this.glacialList6.HotTrackingColor = SystemColors.HotTrack;
            this.glacialList6.ImageList = null;
            this.glacialList6.ItemHeight = 0x13;
            this.glacialList6.Location = new Point(0, 0);
            this.glacialList6.Name = "glacialList6";
            this.glacialList6.SelectedTextColor = SystemColors.HighlightText;
            this.glacialList6.SelectionColor = SystemColors.Highlight;
            this.glacialList6.Size = new Size(0x2f0, 0x98);
            this.glacialList6.TabIndex = 0;
            this.glacialList6.Text = "glacialList6";
            this.glacialList6.UnfocusedSelectionColor = SystemColors.Highlight;
            this.panel9.BackColor = SystemColors.ControlLight;
            this.panel9.BorderStyle = BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.groupBox4);
            this.panel9.Controls.Add(this.button20);
            this.panel9.Controls.Add(this.button19);
            this.panel9.Controls.Add(this.glacialList7);
            this.panel9.Location = new Point(0x138, 0xa8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new Size(0x1d8, 0xc2);
            this.panel9.TabIndex = 14;
            this.panel9.Visible = false;
            this.panel9.MouseUp += new MouseEventHandler(this.panel9_MouseUp);
            this.panel9.MouseDown += new MouseEventHandler(this.panel9_MouseDown);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new Point(0x128, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(160, 0x90);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设置";
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = CheckState.Checked;
            this.checkBox2.Location = new Point(0x58, 0x48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(0x40, 0x18);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "自动";
            this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
            this.label20.Image = (Image) manager.GetObject("label20.Image");
            this.label20.Location = new Point(0x58, 0x20);
            this.label20.Name = "label20";
            this.label20.Size = new Size(0x10, 0x10);
            this.label20.TabIndex = 7;
            this.label20.Click += new EventHandler(this.label20_Click);
            this.label21.Image = (Image) manager.GetObject("label21.Image");
            this.label21.Location = new Point(0x70, 0x20);
            this.label21.Name = "label21";
            this.label21.Size = new Size(0x10, 0x10);
            this.label21.TabIndex = 8;
            this.label21.Click += new EventHandler(this.label21_Click);
            this.label1.Location = new Point(0x10, 0x20);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "订 单 项：";
            this.numericUpDown1.Location = new Point(0x58, 0x60);
            int[] bits = new int[4];
            bits[0] = 0x23;
            this.numericUpDown1.Maximum = new decimal(bits);
            bits = new int[4];
            bits[0] = 11;
            this.numericUpDown1.Minimum = new decimal(bits);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new Size(0x38, 0x15);
            this.numericUpDown1.TabIndex = 12;
            bits = new int[4];
            bits[0] = 0x19;
            this.numericUpDown1.Value = new decimal(bits);
            this.numericUpDown1.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
            this.label18.Location = new Point(0x10, 0x38);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x48, 0x17);
            this.label18.TabIndex = 1;
            this.label18.Text = "订单信息：";
            this.label23.Image = (Image) manager.GetObject("label23.Image");
            this.label23.Location = new Point(0x58, 0x38);
            this.label23.Name = "label23";
            this.label23.Size = new Size(0x10, 0x10);
            this.label23.TabIndex = 9;
            this.label23.Click += new EventHandler(this.label23_Click);
            this.label22.Image = (Image) manager.GetObject("label22.Image");
            this.label22.Location = new Point(0x70, 0x38);
            this.label22.Name = "label22";
            this.label22.Size = new Size(0x10, 0x10);
            this.label22.TabIndex = 10;
            this.label22.Click += new EventHandler(this.label22_Click);
            this.label24.Location = new Point(0x10, 80);
            this.label24.Name = "label24";
            this.label24.Size = new Size(0x48, 0x17);
            this.label24.TabIndex = 11;
            this.label24.Text = "行    高：";
            this.button20.BackColor = SystemColors.Control;
            this.button20.Location = new Point(0x178, 160);
            this.button20.Name = "button20";
            this.button20.TabIndex = 4;
            this.button20.Text = "取消";
            this.button20.Click += new EventHandler(this.button20_Click);
            this.button19.BackColor = SystemColors.Control;
            this.button19.Location = new Point(0x128, 160);
            this.button19.Name = "button19";
            this.button19.TabIndex = 3;
            this.button19.Text = "确定";
            this.button19.Click += new EventHandler(this.button19_Click);
            this.glacialList7.BackColor = SystemColors.Window;
            column44.Name = "Column1";
            column44.Text = "订单项";
            column45.Name = "Column2";
            column45.Text = "订单信息";
            column45.Width = 200;
            this.glacialList7.Columns.AddRange(new GLColumn[] { column44, column45 });
            this.glacialList7.HotTrackingColor = SystemColors.HotTrack;
            this.glacialList7.ImageList = null;
            this.glacialList7.ItemHeight = 0x13;
            item2.Text = "文件名称";
            item3.Text = "File.sit";
            item.SubItems.AddRange(new GLSubItem[] { item2, item3 });
            item.Text = "文件名称";
            item5.Text = "文件格式";
            item6.Text = "Mac";
            item4.SubItems.AddRange(new GLSubItem[] { item5, item6 });
            item4.Text = "文件格式";
            item8.Text = "色版";
            item9.Text = "CMYK";
            item7.SubItems.AddRange(new GLSubItem[] { item8, item9 });
            item7.Text = "色版";
            this.glacialList7.Items.AddRange(new GLItem[] { item, item4, item7 });
            this.glacialList7.Location = new Point(0x10, 0x10);
            this.glacialList7.Name = "glacialList7";
            this.glacialList7.SelectedTextColor = SystemColors.HighlightText;
            this.glacialList7.SelectionColor = SystemColors.Highlight;
            this.glacialList7.Size = new Size(0x110, 0x88);
            this.glacialList7.TabIndex = 2;
            this.glacialList7.Text = "glacialList7";
            this.glacialList7.UnfocusedSelectionColor = SystemColors.Highlight;
            this.Pnldock.Location = new Point(0x98, 120);
            this.Pnldock.Name = "Pnldock";
            this.Pnldock.Size = new Size(0x58, 0x10);
            this.Pnldock.TabIndex = 0x11;
            this.Pnldock.Paint += new PaintEventHandler(this.Pnldock_Paint);
            this.label16.Location = new Point(0, 0x88);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x48, 0x10);
            this.label16.TabIndex = 6;
            this.label17.Location = new Point(0, 0xb0);
            this.label17.Name = "label17";
            this.label17.Size = new Size(0x48, 0x10);
            this.label17.TabIndex = 7;
            this.columnHeader38.Text = "发布时间";
            this.columnHeader38.Width = 150;
            this.columnHeader39.Text = "公司内容";
            this.columnHeader39.Width = 280;
            this.columnHeader37.Text = "公告标题";
            this.columnHeader37.Width = 200;
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x3b8, 0x269);
            base.Controls.Add(this.Pnldock);
            base.Controls.Add(this.panel9);
            base.Controls.Add(this.tabControl2);
            base.Controls.Add(this.label19);
            base.Controls.Add(this.panel11);
            base.Controls.Add(this.splitter1);
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.statusBar1);
            base.Controls.Add(this.toolBar1);
            base.Controls.Add(this.panel1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.IsMdiContainer = true;
            base.Menu = this.mainMenu1;
            base.MinimumSize = new Size(650, 0);
            base.Name = "ePrintMain";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "印易在线服务平台";
            base.WindowState = FormWindowState.Maximized;
            base.Load += new EventHandler(this.ePrintMain_Load);
            this.statusBarPanel1.EndInit();
            this.statusBarPanel2.EndInit();
            this.statusBarPanel3.EndInit();
            this.statusBarPanel4.EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.PnlFunc1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.PnlFunc2.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.PnlFunc4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.tp3.ResumeLayout(false);
            this.PnlFunc3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.panel43.ResumeLayout(false);
            this.PnlFunc5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.PnlFunc6.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.statusBarPanel8.EndInit();
            this.statusBarPanel9.EndInit();
            this.statusBarPanel10.EndInit();
            this.panel15.ResumeLayout(false);
            this.statusBarPanel5.EndInit();
            this.statusBarPanel6.EndInit();
            this.statusBarPanel7.EndInit();
            this.panel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.numericUpDown1.EndInit();
            base.ResumeLayout(false);
        }

        private void initpanels()
        {
            this.PnlFunc1.Parent = this.Pnldock;
            this.PnlFunc2.Parent = this.Pnldock;
            this.PnlFunc3.Parent = this.Pnldock;
            this.PnlFunc4.Parent = this.Pnldock;
            this.PnlFunc5.Parent = this.Pnldock;
            this.PnlFunc6.Parent = this.Pnldock;
            this.panel7.Dock = DockStyle.Fill;
            this.glacialList5.Dock = DockStyle.Fill;
            this.listView1.Dock = DockStyle.Fill;
            this.listView3.Dock = DockStyle.Fill;
            this.panel8.Dock = DockStyle.Fill;
            this.panel17.Height = 40;
            this.Pnldock.Dock = DockStyle.Fill;
        }

        public void insertDate(int type, string[] fileinfo, _fileinfo __myfileinfo)
        {
            string[] listInfo = new string[] { fileinfo[3], fileinfo[1], this.sizeChange(Convert.ToInt64(fileinfo[2])), "0", "0%", "00:00:00", "", "", "0/5", fileinfo[4], fileinfo[9], fileinfo[10] };
            try
            {
                string str;
                if ((type == 1) && this.checkisCheck(fileinfo[11]))
                {
                    __myfileinfo.orderkey = Convert.ToInt32(fileinfo[10]);
                    GLItem item = this.addList(this.glacialList1, __myfileinfo, listInfo);
                    Thread.Sleep(100);
                    int i = this.glacialList1.Items.Count - 1;
                    this.OrderNotice();
                    OleDbConnection connection = new OleDbConnection(strCon);
                    try
                    {
                        str = string.Concat(new object[] { 
                            "insert into DownLoading(dh,State,FilePath,FileName,FileSize,EndSize,OrderCode,CompanyName,CompanyAddress,CompanyTel,CompanyMan,OrderInfo,OrderTime,SaveFilePath,FileId,ZipInfo) values(", __myfileinfo.orderkey, ",0,'", fileinfo[0], "','", fileinfo[1], "','", Convert.ToInt64(fileinfo[2]), "',0,'", fileinfo[3], "','", fileinfo[4], "','", fileinfo[5], "','", fileinfo[6], 
                            "','", fileinfo[7], "','", fileinfo[8], "','", fileinfo[9], "','", __myfileinfo.FileSaveSet, @"\", fileinfo[1], "','", fileinfo[11], "','", fileinfo[12], "')"
                         });
                        connection.Open();
                        new OleDbCommand(str, connection).ExecuteNonQuery();
                        connection.Close();
                        this.waitKey--;
                        if (this.GetFreeRomm(FileSavePath) >= Convert.ToInt64(fileinfo[2]))
                        {
                            FileStream stream = new FileStream(__myfileinfo.FileSaveSet + @"\" + fileinfo[1], FileMode.Create);
                            if (Convert.ToInt64(fileinfo[2]) > 0L)
                            {
                                stream.Seek(Convert.ToInt64(fileinfo[2]) - 1L, SeekOrigin.Current);
                            }
                            byte[] buffer1 = new byte[1];
                            stream.Close();
                            if (this.waitDownload(this.MaxDownNum + 1))
                            {
                                this.OneDown(__myfileinfo.FileSaveSet, fileinfo[1], fileinfo[0], __myfileinfo);
                            }
                            else
                            {
                                item.SubItems[0].ImageIndex = 15;
                            }
                        }
                        else
                        {
                            string str4 = FileSavePath.Substring(0, FileSavePath.IndexOf(@"\"));
                            this.downloadStop2(i, __myfileinfo);
                            MessageBox.Show("空间不足，请删除一部分文件！\n\n下载文件大小：" + this.sizeChange(Convert.ToInt64(fileinfo[2])) + "\n\n剩余空间大小(" + str4 + ")：" + this.sizeChange(this.GetFreeRomm(FileSavePath)), "印易提示");
                        }
                    }
                    catch (OleDbException exception)
                    {
                        this.ePrintLog.WriteLog("下载订单写入数据库时出错(OleDbException错误): " + exception.ToString());
                        if (this.checkisCheck(fileinfo[11]))
                        {
                            connection.Close();
                            str = string.Concat(new object[] { 
                                "insert into DownLoading(dh,State,FilePath,FileName,FileSize,EndSize,OrderCode,CompanyName,CompanyAddress,CompanyTel,CompanyMan,OrderInfo,OrderTime,SaveFilePath,FileId,ZipInfo) values(", __myfileinfo.orderkey + 5, ",0,'", fileinfo[0], "','", fileinfo[1], "','", Convert.ToInt64(fileinfo[2]), "',0,'", fileinfo[3], "','", fileinfo[4], "','", fileinfo[5], "','", fileinfo[6], 
                                "','", fileinfo[7], "','", fileinfo[8], "','", fileinfo[9], "','", __myfileinfo.FileSaveSet, @"\", fileinfo[1], "','", fileinfo[11], "','", fileinfo[12], "')"
                             });
                            connection.Open();
                            new OleDbCommand(str, connection).ExecuteNonQuery();
                            connection.Close();
                            this.waitKey--;
                            if (this.waitDownload(this.MaxDownNum))
                            {
                                __myfileinfo = (_fileinfo) this.glacialList1.Items[i + 1].Tag;
                                this.OneDown(__myfileinfo.FileSaveSet, fileinfo[1], fileinfo[0], __myfileinfo);
                            }
                            else
                            {
                                this.glacialList1.Items[i].SubItems[0].ImageIndex = 15;
                            }
                        }
                    }
                    catch
                    {
                        if (this.waitDownload(this.MaxDownNum))
                        {
                            __myfileinfo = (_fileinfo) this.glacialList1.Items[i + 1].Tag;
                            this.OneDown(__myfileinfo.FileSaveSet, fileinfo[1], fileinfo[0], __myfileinfo);
                        }
                        else
                        {
                            bool flag = false;
                            int num2 = i;
                            while (!flag)
                            {
                                try
                                {
                                    this.glacialList1.Items[num2].SubItems[0].ImageIndex = 15;
                                    flag = true;
                                    continue;
                                }
                                catch (Exception exception2)
                                {
                                    num2--;
                                    this.ePrintLog.WriteLog("改变'正在下载'文件状态图标时出错: " + exception2.ToString());
                                    continue;
                                }
                            }
                        }
                    }
                }
                if ((type == 0) && this.checkisCheck(fileinfo[11]))
                {
                    this.OrderNotice();
                    OleDbConnection connection2 = new OleDbConnection(strCon);
                    if (connection2.State == ConnectionState.Open)
                    {
                        for (int j = 0; j < 0x2710; j++)
                        {
                            if (connection2.State == ConnectionState.Closed)
                            {
                                break;
                            }
                        }
                    }
                    str = string.Concat(new object[] { 
                        "insert into DownLoading(dh,State,FilePath,FileName,FileSize,EndSize,OrderCode,CompanyName,CompanyAddress,CompanyTel,CompanyMan,OrderInfo,OrderTime,SaveFilePath,FileId,ZipInfo) values(", Convert.ToInt64(fileinfo[10]), ",0,'", fileinfo[0], "','", fileinfo[1], "','", Convert.ToInt64(fileinfo[2]), "',0,'", fileinfo[3], "','", fileinfo[4], "','", fileinfo[5], "','", fileinfo[6], 
                        "','", fileinfo[7], "','", fileinfo[8], "','", fileinfo[9], "','", __myfileinfo.FileSaveSet, @"\", fileinfo[1], "','", fileinfo[11], "','", fileinfo[12], "')"
                     });
                    connection2.Open();
                    new OleDbCommand(str, connection2).ExecuteNonQuery();
                    connection2.Close();
                    try
                    {
                        this.ePrintLog.WriteLog("弹出确认： [单号 " + fileinfo[3] + "] [ID号 " + fileinfo[11] + "]");
                    }
                    catch
                    {
                    }
                    if (MessageBox.Show(this, "单号：" + fileinfo[3] + "\n\n文件名称：" + fileinfo[1] + "\n\n文件大小：" + this.sizeChange(Convert.ToInt64(fileinfo[2])) + "\n\n发件公司：" + fileinfo[4] + "\n\n------------------------------------------\n新订单是否下载?", "新订单下载确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        __myfileinfo.orderkey = Convert.ToInt32(fileinfo[10]);
                        this.addList(this.glacialList1, __myfileinfo, listInfo);
                        Thread.Sleep(100);
                        int num4 = this.glacialList1.Items.Count - 1;
                        this.waitKey--;
                        if (this.GetFreeRomm(FileSavePath) >= Convert.ToInt64(fileinfo[2]))
                        {
                            FileStream stream2 = new FileStream(__myfileinfo.FileSaveSet + @"\" + fileinfo[1], FileMode.Create);
                            if (Convert.ToInt64(fileinfo[2]) > 0L)
                            {
                                stream2.Seek(Convert.ToInt64(fileinfo[2]) - 1L, SeekOrigin.Current);
                            }
                            byte[] buffer2 = new byte[1];
                            stream2.Close();
                            if (this.waitDownload(this.MaxDownNum))
                            {
                                this.OneDown(__myfileinfo.FileSaveSet, fileinfo[1], fileinfo[0], __myfileinfo);
                            }
                            else
                            {
                                this.glacialList1.Items[num4].SubItems[0].ImageIndex = 15;
                            }
                        }
                        else
                        {
                            this.downloadStop2(num4, __myfileinfo);
                            MessageBox.Show("空间不足，请删除一部分文件！\n\n下载文件大小：" + this.sizeChange(Convert.ToInt64(fileinfo[2])) + "\n\n剩余空间大小(" + FileSavePath + ")：" + this.sizeChange(this.GetFreeRomm(FileSavePath)), "印易提示");
                        }
                    }
                    else
                    {
                        str = "update DownLoading set isWhich = 3 where dh = " + Convert.ToInt64(fileinfo[10]);
                        OleDbConnection connection3 = new OleDbConnection(strCon);
                        connection3.Open();
                        new OleDbCommand(str, connection3).ExecuteNonQuery();
                        connection3.Close();
                        this.waitKey--;
                        this.getCancelData();
                    }
                }
                if (type == 3)
                {
                    __myfileinfo.orderkey = Convert.ToInt32(fileinfo[10]);
                    this.addList(this.glacialList1, __myfileinfo, listInfo);
                    Thread.Sleep(100);
                    int num5 = this.glacialList1.Items.Count - 1;
                    if (this.waitDownload(this.MaxDownNum + 1))
                    {
                        this.OneDown(__myfileinfo.FileSaveSet, fileinfo[1], fileinfo[0], __myfileinfo);
                    }
                    else
                    {
                        this.glacialList1.Items[num5].SubItems[0].ImageIndex = 15;
                    }
                }
            }
            catch (Exception exception3)
            {
                this.ePrintLog.WriteLog("下载订单写入数据库时出错: " + exception3.ToString());
            }
        }

        private void isDataDown(_fileinfo __myfileinfo, int which)
        {
            try
            {
                if ((__myfileinfo.DownloadedSize_absoluteness == 0L) || (__myfileinfo.DownloadedSize_lastcheck == __myfileinfo.DownloadedSize_absoluteness))
                {
                    __myfileinfo.noDateTime++;
                }
                else
                {
                    __myfileinfo.noDateTime = 0;
                }
            }
            catch (Exception exception)
            {
                Console.Write(string.Concat(new object[] { "\r\n检查有无数据下载时出错: which = ", which, "\n", exception.ToString() }));
            }
        }

        private void isDown(string id)
        {
            try
            {
                int num = Convert.ToInt32(id);
                new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._editOrderState(num);
            }
            catch
            {
            }
        }

        private void isOnlineAdsl()
        {
            if (this.ClientSocket != null)
            {
                if (this.ClientSocket.Connected)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes("isOnline|adsl");
                    Console.Write("\n\n检查是否在线,成功数为: " + this.ClientSocket.Send(bytes).ToString() + "\n\n");
                }
                else
                {
                    Console.Write("\n\nClientSocket不在线(断开连接)\n\n");
                }
            }
        }

        private static bool isOpen()
        {
            bool flag = false;
            try
            {
                int hwnd = FindWindow("WindowsForms10.Window.8.app3", "印易在线服务平台");
                if (hwnd > 0)
                {
                    flag = true;
                    ShowWindow(hwnd, 3);
                    SetForegroundWindow(hwnd);
                    Thread.Sleep(100);
                }
            }
            catch
            {
            }
            return flag;
        }

        private bool isReceive(string id)
        {
            bool flag = false;
            try
            {
                int num = Convert.ToInt32(id);
                ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin login = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx") {
                    Timeout = 0x2710
                };
                flag = login._editOrderCheck(num);
                for (int i = 0; !flag && (i < 5); i++)
                {
                    flag = login._editOrderCheck(num);
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("isReceive失败(ID: " + id.ToString() + ")：" + exception.Message);
            }
            return flag;
        }

        private void KeepAlive()
        {
            try
            {
                new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx").KeepAlive(true);
            }
            catch (Exception exception)
            {
                Console.Write("\r\n" + exception.ToString());
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.panel17.Height = 40;
        }

        private void label20_Click(object sender, EventArgs e)
        {
            this.changeFont();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.changeColor();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.changeColor2();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            this.changeFont2();
        }

        private void ListLogFiles()
        {
            try
            {
                this.listView7.Items.Clear();
                if (!Directory.Exists("ePrintLog"))
                {
                    Directory.CreateDirectory("ePrintLog");
                }
                FileInfo[] files = new DirectoryInfo("ePrintLog").GetFiles();
                ListViewItem[] values = new ListViewItem[files.Length];
                int index = 0;
                foreach (FileInfo info2 in files)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems[0].Text = info2.Name;
                    item.SubItems.Add(this.sizeChange(info2.Length));
                    item.SubItems.Add(info2.LastWriteTime.ToString());
                    item.SubItems.Add(info2.CreationTime.ToString());
                    item.ImageIndex = 0;
                    values[index] = item;
                    index++;
                }
                this.listView7.Items.AddRange(values);
                this.listView7.Refresh();
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("罗列日志文件时出错: " + exception.ToString());
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.listView2.SelectedItems[0].Tag.ToString() != "")
                {
                    string strPath = this.listView2.SelectedItems[0].Tag.ToString();
                    this.OpenPath(strPath);
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("双击listView2时出错: " + exception.ToString());
            }
        }

        private void listView7_DoubleClick(object sender, EventArgs e)
        {
            if ((this.listView7.Items.Count > 0) && (this.listView7.SelectedItems.Count > 0))
            {
                LogFileName = new string[] { this.listView7.SelectedItems[0].SubItems[0].Text };
                isShow = true;
                if (!isShowLogView)
                {
                    this.vlf = new ViewLogFile();
                    this.vlf.Show();
                }
                else
                {
                    this.vlf.BringToFront();
                    this.vlf.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void listView8_Click(object sender, EventArgs e)
        {
            this.viewBulletinInfo();
        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.viewBulletinInfo();
        }

        [STAThread]
        private static void Main()
        {
            if (!isOpen())
            {
                try
                {
                    OutputLogin login = new OutputLogin();
                    login.ShowDialog();
                    if (login.IsOk)
                    {
                        Application.Run(new ePrintMain());
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("运行错误！请与管理员联系！(http://www.print2000.cn)\n\n" + exception.ToString());
                }
            }
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            this.downloadStop();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            this.BeginDownAll();
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            this.allStop();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            this.downloadDel();
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            this.isDelServer = true;
            if (MessageBox.Show("此删除操作将会影响以下项：\n1.本地订单数据。\n2.网上订单数据。\n3.网上该订单所对应的文件。\n\n您确定此操作吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                new Thread(new ThreadStart(this.downedMuDel)) { Name = "downedMuDel" }.Start();
            }
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            this.openFile(0);
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            this.openFile(1);
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.deledMuDel)) { Name = "deledMuDel" }.Start();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            this.openFile2(0);
        }

        private void menuItem19_Click(object sender, EventArgs e)
        {
            this.openFile2(1);
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.ExitSystem();
        }

        private void menuItem24_Click(object sender, EventArgs e)
        {
            if (this.glacialList4.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList4.Items.Count; i++)
                {
                    if (this.glacialList4.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList4.Items[i].Tag;
                        delFile(tag, 2);
                        this.glacialList4.Items.Remove(i);
                        this.glacialList4.Refresh();
                        return;
                    }
                }
            }
        }

        private void menuItem25_Click(object sender, EventArgs e)
        {
            if ((this.glacialList4.Items.Count > 0) && (this.glacialList4.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList4.Items.Count; i++)
                {
                    if (this.glacialList4.Items[i].Selected)
                    {
                        string[] fileinfo = new string[12];
                        string str = null;
                        string path = null;
                        _fileinfo tag = (_fileinfo) this.glacialList4.Items[i].Tag;
                        tag.isContinue = 0;
                        tag.BlockDownloadSize_init = new long[5];
                        tag.BlockDownloadSize_Abs = new long[5];
                        tag.frontSize = new long[5];
                        tag.SplitInfo = new string[5];
                        tag.ns = new Stream[5];
                        tag.fs = new FileStream[5];
                        OleDbConnection connection = new OleDbConnection(strCon);
                        OleDbCommand command = new OleDbCommand("select * from DownLoading where dh=" + tag.orderkey, connection);
                        OleDbDataReader reader = null;
                        connection.Open();
                        reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            fileinfo[0] = reader["FilePath"].ToString();
                            fileinfo[1] = reader["FileName"].ToString();
                            fileinfo[2] = reader["FileSize"].ToString();
                            fileinfo[3] = reader["OrderCode"].ToString();
                            fileinfo[4] = reader["CompanyName"].ToString();
                            fileinfo[5] = reader["CompanyAddress"].ToString();
                            fileinfo[6] = reader["CompanyTel"].ToString();
                            fileinfo[7] = reader["CompanyMan"].ToString();
                            fileinfo[8] = reader["OrderInfo"].ToString();
                            fileinfo[9] = reader["OrderTime"].ToString();
                            fileinfo[10] = tag.orderkey.ToString();
                            fileinfo[11] = reader["FileId"].ToString();
                            str = reader["SaveFilePath"].ToString();
                            path = str.Substring(0, str.LastIndexOf(@"\"));
                            tag.FileName = reader["FileName"].ToString();
                            tag.FilePath = reader["FilePath"].ToString();
                            tag.FileSize = Convert.ToInt64(reader["FileSize"].ToString());
                            tag.FileSaveSet = path;
                        }
                        reader.Close();
                        connection.Close();
                        delFile(tag, 3);
                        this.glacialList4.Items.Remove(i);
                        this.glacialList4.Refresh();
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        this.insertDate(3, fileinfo, tag);
                        return;
                    }
                }
            }
        }

        private void menuItem26_Click(object sender, EventArgs e)
        {
            this.selectUser();
        }

        private void menuItem27_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.getOutputUser)) { Name = "getOutputUser" }.Start();
        }

        private void menuItem29_Click(object sender, EventArgs e)
        {
            this.listView5.Items.Clear();
        }

        private void menuItem31_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listView5.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("请选择需要重置密码的帐号!");
                }
                else
                {
                    DialogResult result;
                    if (this.listView5.SelectedItems.Count == 1)
                    {
                        result = MessageBox.Show("您此次打算重置 " + this.listView5.SelectedItems.Count.ToString() + " 个帐号密码,确定后将进行重置!", "印易提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        result = MessageBox.Show("您此次打算重置 " + this.listView5.SelectedItems.Count.ToString() + " 个帐号密码,确定后将逐个进行重置!", "印易提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    }
                    if (result == DialogResult.Yes)
                    {
                        for (int i = 0; i < this.listView5.SelectedItems.Count; i++)
                        {
                            if (this.listView5.SelectedItems[i].BackColor == Color.Silver)
                            {
                                MessageBox.Show(this.listView5.SelectedItems[i].SubItems[2].Text + " 为公共帐号,不允许重置密码!");
                            }
                            else
                            {
                                new EditUserPassword { OutputKey = Outputkey, UserId = this.listView5.SelectedItems[i].Tag.ToString(), UserCode = this.listView5.SelectedItems[i].SubItems[1].Text, myCompanyName = this.listView5.SelectedItems[i].SubItems[3].Text, UserName = this.listView5.SelectedItems[i].SubItems[2].Text }.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("重置密码时出错: " + exception.ToString());
            }
        }

        private void menuItem32_Click(object sender, EventArgs e)
        {
            this.delUser2();
        }

        private void menuItem34_Click(object sender, EventArgs e)
        {
            this.SendFile();
        }

        private void menuItem36_Click(object sender, EventArgs e)
        {
            new ViewRemark { key = this.ViewRemarkKey2() }.ShowDialog(this);
        }

        private void menuItem38_Click(object sender, EventArgs e)
        {
            new ViewRemark { key = this.ViewRemarkKey() }.ShowDialog(this);
        }

        private void menuItem39_Click(object sender, EventArgs e)
        {
            try
            {
                if (!base.ShowInTaskbar)
                {
                    base.WindowState = FormWindowState.Maximized;
                    base.Show();
                    base.ShowInTaskbar = true;
                    this.treeView1.ExpandAll();
                    base.Activate();
                }
                else
                {
                    base.WindowState = FormWindowState.Minimized;
                    base.ShowInTaskbar = false;
                    base.Hide();
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("右键菜单六：'打开/隐藏'出错: " + exception.ToString());
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            new SystemSet().ShowDialog();
        }

        private void menuItem41_Click(object sender, EventArgs e)
        {
            new SystemSet().ShowDialog();
        }

        private void menuItem43_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在制作中...", "请等待");
        }

        private void menuItem44_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void menuItem46_Click(object sender, EventArgs e)
        {
            this.ExitSystem();
        }

        private void menuItem47_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.print2000.cn");
        }

        private void menuItem48_Click(object sender, EventArgs e)
        {
            this.ChangeUser();
        }

        private void menuItem49_Click(object sender, EventArgs e)
        {
            OutputLogin.whichLogin = 1;
            new OutputLogin().Show();
            base.Close();
        }

        private void menuItem51_Click(object sender, EventArgs e)
        {
            this.delUserFiles(1);
        }

        private void menuItem52_Click(object sender, EventArgs e)
        {
            this.delUserFiles(2);
        }

        private void menuItem53_Click(object sender, EventArgs e)
        {
            this.delUserFiles(3);
        }

        private void menuItem55_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.getUserFiles)) { Name = "getUserFiles" }.Start();
        }

        private void menuItem57_Click(object sender, EventArgs e)
        {
            this.openLogFiles();
        }

        private void menuItem58_Click(object sender, EventArgs e)
        {
            this.listView7.View = View.LargeIcon;
            this.menuItem58.Checked = this.menuItem64.Checked = true;
            this.menuItem59.Checked = this.menuItem60.Checked = this.menuItem65.Checked = this.menuItem66.Checked = false;
        }

        private void menuItem59_Click(object sender, EventArgs e)
        {
            this.listView7.View = View.SmallIcon;
            this.menuItem59.Checked = this.menuItem65.Checked = true;
            this.menuItem58.Checked = this.menuItem60.Checked = this.menuItem64.Checked = this.menuItem66.Checked = false;
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在制作中...", "请等待");
        }

        private void menuItem60_Click(object sender, EventArgs e)
        {
            this.listView7.View = View.Details;
            this.menuItem60.Checked = this.menuItem66.Checked = true;
            this.menuItem58.Checked = this.menuItem59.Checked = this.menuItem64.Checked = this.menuItem65.Checked = false;
        }

        private void menuItem61_Click(object sender, EventArgs e)
        {
            this.delLogFiles();
        }

        private void menuItem64_Click(object sender, EventArgs e)
        {
            this.listView7.View = View.LargeIcon;
            this.menuItem58.Checked = this.menuItem64.Checked = true;
            this.menuItem59.Checked = this.menuItem60.Checked = this.menuItem65.Checked = this.menuItem66.Checked = false;
        }

        private void menuItem65_Click(object sender, EventArgs e)
        {
            this.listView7.View = View.SmallIcon;
            this.menuItem59.Checked = this.menuItem65.Checked = true;
            this.menuItem58.Checked = this.menuItem60.Checked = this.menuItem64.Checked = this.menuItem66.Checked = false;
        }

        private void menuItem66_Click(object sender, EventArgs e)
        {
            this.listView7.View = View.Details;
            this.menuItem60.Checked = this.menuItem66.Checked = true;
            this.menuItem58.Checked = this.menuItem59.Checked = this.menuItem64.Checked = this.menuItem65.Checked = false;
        }

        private void menuItem68_Click(object sender, EventArgs e)
        {
        }

        private void menuItem69_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.ListLogFiles)) { Name = "ListLogFiles" }.Start();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.print2000.cn");
        }

        private void menuItem70_Click(object sender, EventArgs e)
        {
            if ((this.glacialList2.Items.Count > 0) && (this.glacialList2.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList2.Items.Count; i++)
                {
                    if (this.glacialList2.Items[i].Selected)
                    {
                        try
                        {
                            _fileinfo tag = (_fileinfo) this.glacialList2.Items[i].Tag;
                            string[] fileinfo = new string[12];
                            tag.isContinue = 0;
                            tag.BlockDownloadSize_init = new long[5];
                            tag.BlockDownloadSize_Abs = new long[5];
                            tag.frontSize = new long[5];
                            tag.SplitInfo = new string[5];
                            tag.ns = new Stream[5];
                            tag.fs = new FileStream[5];
                            tag.DownloadedSize_absoluteness = 0L;
                            OleDbConnection connection = new OleDbConnection(strCon);
                            OleDbCommand command = new OleDbCommand("select * from DownLoading where dh=" + tag.orderkey, connection);
                            OleDbDataReader reader = null;
                            connection.Open();
                            reader = command.ExecuteReader();
                            if (reader.Read())
                            {
                                fileinfo[0] = reader["FilePath"].ToString();
                                fileinfo[1] = reader["FileName"].ToString();
                                fileinfo[2] = reader["FileSize"].ToString();
                                fileinfo[3] = reader["OrderCode"].ToString();
                                fileinfo[4] = reader["CompanyName"].ToString();
                                fileinfo[5] = reader["CompanyAddress"].ToString();
                                fileinfo[6] = reader["CompanyTel"].ToString();
                                fileinfo[7] = reader["CompanyMan"].ToString();
                                fileinfo[8] = reader["OrderInfo"].ToString();
                                fileinfo[9] = reader["OrderTime"].ToString();
                                fileinfo[10] = tag.orderkey.ToString();
                                fileinfo[11] = reader["FileId"].ToString();
                                tag.FileName = reader["FileName"].ToString();
                                tag.FilePath = reader["FilePath"].ToString();
                                tag.FileSize = Convert.ToInt64(reader["FileSize"].ToString());
                            }
                            reader.Close();
                            connection.Close();
                            this.getFileSavePath(tag, fileinfo[4], Convert.ToInt16(tag.OrderInfo.Substring(0, 1)));
                            string cmdText = "delete from DownLoading2 where ID2=" + tag.orderkey;
                            string str3 = string.Concat(new object[] { "update DownLoading set EndSize=0,SaveFilePath='", tag.FileSaveSet, @"\", fileinfo[1], "' where dh=", tag.orderkey });
                            OleDbCommand command2 = new OleDbCommand(cmdText, connection);
                            OleDbCommand command3 = new OleDbCommand(str3, connection);
                            connection.Open();
                            command2.ExecuteNonQuery();
                            command3.ExecuteNonQuery();
                            connection.Close();
                            delFile(tag, 3);
                            this.glacialList2.Items.Remove(i);
                            this.glacialList2.Refresh();
                            if (File.Exists(tag.FileSaveSet + @"\" + fileinfo[1]))
                            {
                                File.Delete(tag.FileSaveSet + @"\" + fileinfo[1]);
                                Thread.Sleep(100);
                            }
                            this.insertDate(3, fileinfo, tag);
                            break;
                        }
                        catch (Exception exception)
                        {
                            this.ePrintLog.WriteLog(exception.ToString());
                        }
                    }
                }
            }
        }

        private void menuItem72_Click(object sender, EventArgs e)
        {
            this.isDelServer = false;
            if (MessageBox.Show("您确定此删除操作吗？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                new Thread(new ThreadStart(this.downedMuDel)) { Name = "downedMuDel" }.Start();
            }
        }

        private void menuItem74_Click(object sender, EventArgs e)
        {
            this.ChangeUser();
        }

        private void menuItem76_Click(object sender, EventArgs e)
        {
            if (!SendFileIsOpen)
            {
                this._sendFile = new SendFileToUser();
                this._sendFile.Show();
            }
            else
            {
                this._sendFile.BringToFront();
            }
        }

        private void menuItem78_Click(object sender, EventArgs e)
        {
            if ((this.listView7.Items.Count > 0) && (this.listView7.SelectedItems.Count > 0))
            {
                this.saveFileDialog1.FileName = this.listView7.SelectedItems[0].SubItems[0].Text;
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(OutputLogin.SetupPath + @"\ePrintLog\" + this.listView7.SelectedItems[0].SubItems[0].Text, this.saveFileDialog1.FileName, true);
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void menuItem80_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.fileSaveAs)) { Name = "fileSaveAs" }.Start();
        }

        private void menuItem82_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listView5.SelectedItems.Count <= 0)
                {
                    MessageBox.Show("请选择需要修改密码的帐号!");
                }
                else
                {
                    for (int i = 0; i < this.listView5.SelectedItems.Count; i++)
                    {
                        if (this.listView5.SelectedItems[i].BackColor == Color.Silver)
                        {
                            MessageBox.Show(this.listView5.SelectedItems[i].SubItems[2].Text + " 为公共帐号,不允许重置密码!");
                        }
                        else
                        {
                            new EditUserPassword { OutputKey = Outputkey, UserId = this.listView5.SelectedItems[i].Tag.ToString(), UserCode = this.listView5.SelectedItems[i].SubItems[1].Text, myCompanyName = this.listView5.SelectedItems[i].SubItems[3].Text, UserName = this.listView5.SelectedItems[i].SubItems[2].Text, editType = 1 }.ShowDialog();
                            return;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("重置密码时出错: " + exception.ToString());
            }
        }

        private void menuItem84_Click(object sender, EventArgs e)
        {
            new editUserLevel { UserName = this.listView5.SelectedItems[0].SubItems[2].Text, UserLevel = "", UserID = "" }.ShowDialog();
        }

        private void menuItem85_Click(object sender, EventArgs e)
        {
            this.panel9.Location = this.glacialList5.PointToScreen(new Point(50, -15));
            this.panel9.BringToFront();
            this.panel9.Visible = true;
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            this.downloadContinue();
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isLock)
            {
                this.contextMenu6.MenuItems[0].Enabled = true;
                try
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        if (!base.ShowInTaskbar)
                        {
                            base.WindowState = FormWindowState.Maximized;
                            base.Show();
                            base.ShowInTaskbar = true;
                            this.treeView1.ExpandAll();
                            base.Activate();
                        }
                        else
                        {
                            base.WindowState = FormWindowState.Minimized;
                            base.ShowInTaskbar = false;
                            base.Hide();
                        }
                    }
                }
                catch (Exception exception)
                {
                    this.ePrintLog.WriteLog("点击托盘时出错: " + exception.ToString());
                }
            }
            else
            {
                this.contextMenu6.MenuItems[0].Enabled = false;
            }
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                string str = null;
                int count = 0;
                int num2 = 0;
                if (this.glacialList1.Items.Count > 0)
                {
                    count = this.glacialList1.Items.Count;
                    int num3 = 0;
                    for (int i = 0; i < this.glacialList1.Items.Count; i++)
                    {
                        if ((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4))
                        {
                            num3++;
                        }
                    }
                    num2 = num3;
                }
                string str2 = str;
                str = str2 + "印易在线服务平台\r\n----------------\r\n下载队列文件数:" + count.ToString() + "\n正在下载文件数:" + num2.ToString() + "\n";
                if (num2 > 0)
                {
                    str = str + "\n速度:" + this.statusBarPanel3.Text + "\n";
                }
                this.notifyIcon1.Text = str;
            }
            catch
            {
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!this.checkBox2.Checked)
            {
                this._OrderInfoItemheight = this.numericUpDown1.Value.ToString();
                this.glacialList7.AutoHeight = false;
                this.glacialList7.FullRowSelect = false;
                this.glacialList7.ItemHeight = Convert.ToInt16(this.numericUpDown1.Value.ToString());
                this.glacialList7.Refresh();
            }
        }

        private void OneDown(string FileSaveSet, string FileName, string FilePath, _fileinfo __myfileinfo)
        {
            if (__myfileinfo == null)
            {
                this.ePrintLog.WriteLog("准备下载文件" + FileName + "错误：参数__myfileinfo 为空");
            }
            else
            {
                Console.Write("\r\nStart ready OneJetDown...\r\n");
                OneJetDown down = new OneJetDown(this, __myfileinfo) {
                    FileSaveSet = FileSaveSet,
                    FileName = FileName,
                    FilePath = FilePath
                };
                new Thread(new ThreadStart(down.down)) { Name = "_OneJetDown.down" }.Start();
                __myfileinfo.time = 0;
                Console.Write("\r\nEnd ready OneJetDown ok ...\r\n");
            }
        }

        private void openFile(int type)
        {
            if (this.glacialList2.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList2.Items.Count; i++)
                {
                    if (this.glacialList2.Items[i].Selected)
                    {
                        string text = this.glacialList2.Items[i].SubItems[7].Text;
                        try
                        {
                            if (type == 0)
                            {
                                text = text;
                            }
                            if (type == 1)
                            {
                                text = text.Substring(0, text.LastIndexOf(@"\"));
                            }
                            Process.Start(text);
                        }
                        catch (Exception exception)
                        {
                            this.ePrintLog.WriteLog("尝试打开已下载列表目录时出错: " + exception.Message);
                            MessageBox.Show(exception.Message);
                        }
                        break;
                    }
                }
            }
        }

        private void openFile2(int type)
        {
            if (this.glacialList3.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList3.Items.Count; i++)
                {
                    if (this.glacialList3.Items[i].Selected)
                    {
                        string text = this.glacialList3.Items[i].SubItems[7].Text;
                        try
                        {
                            if (type == 0)
                            {
                                text = text;
                            }
                            if (type == 1)
                            {
                                text = text.Substring(0, text.LastIndexOf(@"\"));
                            }
                            Process.Start(text);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                        break;
                    }
                }
            }
        }

        private void openFilePath()
        {
            if (this.glacialList3.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList3.Items.Count; i++)
                {
                    if (this.glacialList3.Items[i].Selected)
                    {
                        string text = this.glacialList3.Items[i].SubItems[7].Text;
                        try
                        {
                            Process.Start(text.Substring(0, text.LastIndexOf(@"\")));
                        }
                        catch (Exception exception)
                        {
                            this.ePrintLog.WriteLog("尝试打开已删除列表文件时出错: " + exception.Message);
                            MessageBox.Show(exception.Message);
                        }
                        break;
                    }
                }
            }
        }

        private void openLogFiles()
        {
            try
            {
                if ((this.listView7.Items.Count > 0) && (this.listView7.SelectedItems.Count > 0))
                {
                    LogFileName = new string[this.listView7.SelectedItems.Count];
                    for (int i = 0; i < this.listView7.SelectedItems.Count; i++)
                    {
                        LogFileName[i] = this.listView7.SelectedItems[i].SubItems[0].Text;
                    }
                    isShow = true;
                    if (!isShowLogView)
                    {
                        this.vlf = new ViewLogFile();
                        this.vlf.Show();
                    }
                    else
                    {
                        this.vlf.BringToFront();
                        this.vlf.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("打开日志文件时出错: " + exception.ToString());
            }
        }

        public void OpenPath(string strPath)
        {
            try
            {
                this.comboBox1.Text = strPath;
                DirectoryInfo info = new DirectoryInfo(strPath);
                this.listView2.Items.Clear();
                DirectoryInfo[] directories = info.GetDirectories();
                try
                {
                    ListViewItem item = new ListViewItem {
                        Tag = info.Parent.FullName,
                        ImageIndex = 2
                    };
                    item.SubItems[0].Text = "..";
                    this.listView2.Items.Add(item);
                }
                catch (Exception exception)
                {
                    this.ePrintLog.WriteLog("给已下载列表增加数据时出错: " + exception.ToString());
                }
                foreach (DirectoryInfo info2 in directories)
                {
                    ListViewItem item2 = new ListViewItem {
                        Tag = strPath + info2.Name + @"\",
                        ImageIndex = 0
                    };
                    item2.SubItems[0].Text = info2.Name;
                    item2.SubItems.Add("");
                    item2.SubItems.Add(info2.LastWriteTime.ToString());
                    this.listView2.Items.Add(item2);
                }
                this.statusBar2.Panels[0].Text = directories.Length.ToString() + " 个文件夹";
                FileInfo[] files = info.GetFiles();
                long fileSize = 0L;
                foreach (FileInfo info3 in files)
                {
                    ListViewItem item3 = new ListViewItem {
                        Tag = "",
                        ImageIndex = 1
                    };
                    item3.SubItems[0].Text = info3.Name;
                    item3.SubItems.Add(this.sizeChange(info3.Length));
                    item3.SubItems.Add(info3.LastWriteTimeUtc.ToString());
                    this.listView2.Items.Add(item3);
                    fileSize += info3.Length;
                }
                this.statusBar2.Panels[1].Text = files.Length.ToString() + " 个文件";
                this.statusBar2.Panels[2].Text = "文件大小: " + this.sizeChange(fileSize);
            }
            catch (Exception exception2)
            {
                this.ePrintLog.WriteLog("尝试打开已下载文件出错: " + exception2.ToString());
                MessageBox.Show(exception2.Message);
            }
        }

        private void OrderNotice()
        {
            try
            {
                Type type = base.GetType();
                Stream manifestResourceStream = type.Assembly.GetManifestResourceStream(type.Namespace + ".sound.wav");
                byte[] buffer = new byte[manifestResourceStream.Length];
                manifestResourceStream.Read(buffer, 0, buffer.Length);
                manifestResourceStream.Close();
                sndPlaySoundA(buffer, 4);
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("订单通知声音播放错误:" + exception.ToString());
            }
        }

        private void OutputRoomInfo()
        {
            string[] strArray = new string[2];
            try
            {
                strArray = new ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._OutputRoomInfo(Convert.ToInt32(Outputkey));
            }
            catch
            {
            }
            try
            {
                this.UsedSize = Convert.ToInt64(strArray[0].ToString());
                this.AllSize = Convert.ToDouble(strArray[1].ToString());
            }
            catch
            {
            }
            this.statusBar1_DrawItem(null, null);
            this.statusBar1.Refresh();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            int num = 0;
            for (int i = 0; i < 0x9c; i++)
            {
                if (this.pointY[i] > 0)
                {
                    num++;
                    break;
                }
            }
            if (num > 0)
            {
                Bitmap image = new Bitmap(0x9d, 0x22);
                Graphics graphics = Graphics.FromImage(image);
                for (int j = 1; j < 0x9c; j++)
                {
                    if (this.pointY[j] > 0)
                    {
                        graphics.DrawLine(new Pen(Brushes.DarkGreen, 1f), new Point(j, 0x24 - this.pointY[j]), new Point(j, 0x24));
                    }
                }
                Graphics graphics2 = this.panel11.CreateGraphics();
                graphics2.Clear(Color.Gainsboro);
                graphics2.DrawImage(image, 0, 0);
                graphics2.Dispose();
                graphics.Dispose();
                image.Dispose();
            }
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            this.t = new Point(e.X, e.Y);
        }

        private void panel9_MouseUp(object sender, MouseEventArgs e)
        {
            this.panel9.Location = new Point((this.panel9.Left + e.X) - this.t.X, (this.panel9.Top + e.Y) - this.t.Y);
        }

        private void pauseget()
        {
            this.ePrintLog.WriteLog("暂停接收订单...");
            this.isStop = 1;
            this.ClientSocket.Close();
            this.ClientSocket = null;
            Icon icon = new Icon(OutputLogin.SetupPath + @"\ico\stop.ico");
            this.statusBarPanel2.Icon = icon;
            this.statusBarPanel2.Text = "暂停接收";
            this.toolBarButton6.Enabled = true;
            this.toolBarButton12.Enabled = false;
        }

        private void Pnldock_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Wait", new Font("宋体", 9f), Brushes.Black, (float) 5f, (float) 5f);
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

        private string replaceChar(string strInfo)
        {
            return strInfo.Replace("'", "＇").Replace(",", "，").Replace(";", "；").Replace("#", "＃").Replace("&", "＆").Replace("+", "＋").Replace("\"", "＂").Replace("?", "？");
        }

        private void ScreenProtect()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
            if ((key != null) && (key.GetValue("ScreenProtectInfo") != null))
            {
                bool flag1 = key.GetValue("ScreenProtectInfo").ToString().Split(new char[] { '|' })[0] == "1";
            }
        }

        private void selectUser()
        {
            if (this.panel17.Height != 160)
            {
                this.panel17.Height = 160;
            }
            else if ((!this.checkBox1.Checked && (this.textBox1.Text.Trim() == "")) && ((this.textBox2.Text.Trim() == "") && (this.textBox3.Text.Trim() == "")))
            {
                MessageBox.Show("请输入查找条件!");
            }
            else if ((this.textBox1.Text.Trim() != "") && (this.textBox1.Text.Trim().Length < 2))
            {
                this.textBox1.Focus();
                this.textBox1.SelectionStart = this.textBox1.Text.Trim().Length;
                MessageBox.Show("帐号名称不能少于2个字符!");
            }
            else if ((this.textBox2.Text.Trim() != "") && (this.textBox2.Text.Trim().Length < 2))
            {
                this.textBox2.Focus();
                this.textBox2.SelectionStart = this.textBox2.Text.Trim().Length;
                MessageBox.Show("公司名称不能少于2个字符!");
            }
            else
            {
                new Thread(new ThreadStart(this.getOutputUser)) { Name = "getOutputUser" }.Start();
            }
        }

        private void SendFile()
        {
            if (this.listView5.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择需要接收文件的帐号!");
            }
            else
            {
                this.ePrintLog.WriteLog("尝试给客户发送文件");
                int num = 0;
                for (int i = 0; i < this.listView5.SelectedItems.Count; i++)
                {
                    if (((this.listView5.SelectedItems[i].BackColor != Color.LightPink) && (this.listView5.SelectedItems[i].BackColor != Color.SteelBlue)) && (this.listView5.SelectedItems[i].BackColor != Color.Silver))
                    {
                        num++;
                    }
                }
                if (num > 0)
                {
                    string[] strArray = new string[num];
                    string[] strArray2 = new string[num];
                    int index = 0;
                    for (int j = 0; j < this.listView5.SelectedItems.Count; j++)
                    {
                        if (((this.listView5.SelectedItems[j].BackColor != Color.LightPink) && (this.listView5.SelectedItems[j].BackColor != Color.SteelBlue)) && (this.listView5.SelectedItems[j].BackColor != Color.Silver))
                        {
                            strArray[index] = this.listView5.SelectedItems[j].SubItems[2].Text;
                            strArray2[index] = this.listView5.SelectedItems[j].SubItems[3].Text;
                            index++;
                        }
                    }
                    if (!SendFileIsOpen)
                    {
                        this._sendFile = new SendFileToUser();
                        this._sendFile.ReceiveUser = strArray;
                        this._sendFile.ReceiveCompanyName = strArray2;
                        this._sendFile.Show();
                    }
                    else
                    {
                        string[] strArray3 = new string[strArray.Length];
                        for (int k = 0; k < strArray.Length; k++)
                        {
                            strArray3[k] = strArray[k] + "|" + strArray2[k];
                        }
                        SendFileToUser.AddNewUser = strArray3;
                        SendFileToUser.timer2.Enabled = true;
                        this._sendFile.BringToFront();
                    }
                }
                else
                {
                    MessageBox.Show("未选择接收文件的用户!(注:只有普通用户才能接收文件)");
                }
            }
        }

        private void SendLogFile()
        {
            if ((this.listView7.Items.Count > 0) && (this.listView7.SelectedItems.Count > 0))
            {
                string[] strArray = new string[this.listView7.SelectedItems.Count];
                for (int i = 0; i < this.listView7.SelectedItems.Count; i++)
                {
                    strArray[i] = this.listView7.SelectedItems[i].SubItems[0].Text;
                }
            }
        }

        [DllImport("user32.dll")]
        public static extern void SetForegroundWindow(int hwnd);
        private void SetLoginInfo(RegistryKey rk)
        {
            rk.SetValue("LoginUserName", "");
            rk.SetValue("LoginPassword", "");
            Process.Start("ePrintOrderManager.exe");
            base.Dispose();
        }

        [DllImport("user32.dll")]
        public static extern int ShowWindow(int hwnd, int nCmdShow);
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

        [DllImport("winmm.dll")]
        private static extern int sndPlaySoundA(byte[] lpszSoundName, int uFlags);
        private void splitUpload(long allsize, string FileSaveSet, string FileName, string FilePath, _fileinfo __myfileinfo)
        {
            try
            {
                int num = 5;
                long num2 = allsize % ((long) num);
                long num3 = (allsize - num2) / ((long) num);
                for (int i = 0; i < num; i++)
                {
                    if (i == (num - 1))
                    {
                        this.beginDown(i * num3, allsize, i, FileSaveSet, FileName, FilePath, __myfileinfo);
                    }
                    else
                    {
                        this.beginDown(i * num3, (i + 1) * num3, i, FileSaveSet, FileName, FilePath, __myfileinfo);
                    }
                    __myfileinfo.BlockDownloadSize_init[i] = i * num3;
                    __myfileinfo.frontSize[i] = i * num3;
                    Thread.Sleep(100);
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("给文件分块时出错: " + exception.ToString());
            }
        }

        private void StartDownAll_IsDisConnected()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (this.glacialList1.Items[i].SubItems[0].ImageIndex == 10)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        this.errorTime = 0;
                        tag.isError = 0;
                        this.downloadContinue2(i, tag);
                    }
                }
            }
        }

        private void statusBar1_DrawItem(object sender, StatusBarDrawItemEventArgs sbdevent)
        {
            try
            {
                Brush red;
                int width = Convert.ToInt16((double) ((Convert.ToDouble(this.UsedSize) / (((this.AllSize * 1024.0) * 1024.0) * 1024.0)) * 148.0));
                if (width >= 120)
                {
                    red = Brushes.Red;
                }
                else
                {
                    red = Brushes.RoyalBlue;
                }
                Graphics graphics = this.statusBar1.CreateGraphics();
                graphics.DrawRectangle(new Pen(Brushes.Black, 1f), 0x22b, 6, 150, 12);
                graphics.FillRectangle(Brushes.Beige, 0x22d, 8, 0x94, 9);
                graphics.FillRectangle(red, 0x22d, 8, width, 9);
                graphics.DrawString("空间情况", new Font("宋体", 9f), Brushes.Black, (float) 502f, (float) 6f);
                graphics.DrawString(this.sizeChange(this.UsedSize) + "/" + this.AllSize.ToString() + "G", new Font("宋体", 9f), Brushes.Black, (float) 705f, (float) 6f);
                graphics.Dispose();
                if (width > 0x94)
                {
                    MessageBox.Show(this, "您的空间已超支,请删除一部分文件以释放空间!", "空间警告", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
            }
        }

        public static void StopDown(_fileinfo __myfileinfo)
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    __myfileinfo.ns[i].Close();
                    __myfileinfo.fs[i].Close();
                }
                catch (NullReferenceException exception)
                {
                    Console.Write("***" + __myfileinfo.orderkey.ToString() + "|" + i.ToString() + "***" + exception.ToString());
                }
                catch (Exception exception2)
                {
                    Console.Write(exception2.ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.changeChecked();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.changeChecked();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.changeChecked();
        }

        private void timer_ToolTip_Tick(object sender, EventArgs e)
        {
            this.toolTip_Element.Active = true;
            _fileinfo tag = (_fileinfo) this._lastItem.Tag;
            int orderkey = tag.orderkey;
            this.toolTip_Element.SetToolTip(this._lastList, this.GlaListViewTip(1, (long) orderkey));
            this.timer_ToolTip.Enabled = false;
            this.timer_ToolTip.Tick -= new EventHandler(this.timer_ToolTip_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if ((this.glacialList1.Items[i].Tag != null) && ((this.glacialList1.Items[i].SubItems[0].ImageIndex == 4) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 0)))
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        if (tag.isfinished == 0)
                        {
                            this.DoChangeDownloadedInfo(tag, i);
                        }
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.RunTime += 1L;
            this.ViewTotalSpeed();
            if ((this.RunTime % 3L) == 0L)
            {
                this.CheckDownState2();
            }
            if (isClose > 0)
            {
                base.Dispose();
            }
            long runTime = this.RunTime;
            if ((this.RunTime % 60L) == 0L)
            {
                try
                {
                    new Thread(new ThreadStart(this.KeepAlive)) { Name = "KeepAlive" }.Start();
                }
                catch (Exception exception)
                {
                    Console.Write(exception.ToString());
                }
            }
            if ((this.RunTime % 0x7080L) == 0L)
            {
                new Thread(new ThreadStart(this.CheckVersion)) { Name = "CheckVersion" }.Start();
            }
            if ((((this.RunTime % 300L) == 0L) && (this.ClientSocket != null)) && this.toolBarButton12.Enabled)
            {
                if (this.ClientSocket.Connected)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes("isOnline|0");
                    if (this.ClientSocket.Send(bytes) <= 0)
                    {
                        this.ePrintLog.WriteLog("***与服务器断开连接,尝试重新连接...***");
                        try
                        {
                            this.ClientSocket.Close();
                            this.ClientSocket = null;
                        }
                        catch (Exception exception2)
                        {
                            this.ePrintLog.WriteLog(exception2.ToString());
                        }
                        this.ePrintConnect();
                    }
                    else
                    {
                        Console.Write("\n\n" + DateTime.Now.ToString() + "在线在线在线\n\n");
                    }
                }
                else
                {
                    Console.Write("\n\n未连接过，现在连接\n\n");
                    this.ePrintConnect();
                }
            }
            if ((this.RunTime % 5L) == 0L)
            {
                if ((this.ClientSocket != null) && (this.isStop == 0))
                {
                    if (!this.ClientSocket.Connected)
                    {
                        this.errorTime++;
                        Icon icon = new Icon(OutputLogin.SetupPath + @"\ico\offline.ico");
                        this.statusBarPanel2.Icon = icon;
                        this.statusBarPanel2.Text = "已断开,正在重新连接......";
                        this.ClientSocket.Close();
                        this.ePrintConnect();
                        this.statusBarPanel2.Text = "连接失败,5秒钟后重试!(" + this.errorTime + "次)";
                    }
                }
                else
                {
                    Socket clientSocket = this.ClientSocket;
                }
                this.StartDownAll_IsDisConnected();
            }
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.Text == "开始")
            {
                this.downloadContinue();
            }
            if (e.Button.Text == "暂停")
            {
                this.downloadStop();
            }
            if (e.Button.Text == "删除")
            {
                this.downloadDel();
            }
            if (e.Button.Text == "打开")
            {
                this.openFile(0);
            }
            if (e.Button.Text == "目录")
            {
                if (this.whichlistView == 1)
                {
                    this.openFile(1);
                }
                if (this.whichlistView == 2)
                {
                    this.openFilePath();
                }
            }
            if (e.Button.Text == "退出")
            {
                this.ExitSystem();
            }
            if (e.Button.Text == "设置")
            {
                this.ePrintLog.WriteLog("进行'设置'操作");
                new SystemSet().ShowDialog();
            }
            if (e.Button.Text == "接收订单")
            {
                this.ePrintLog.WriteLog("尝试接收订单...");
                this.ePrintConnect();
                this.toolBarButton6.Enabled = false;
                this.toolBarButton12.Enabled = true;
            }
            if (e.Button.Text == "暂停接收")
            {
                this.pauseget();
            }
        }

        private void toolBar2_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button == this.toolBarButton14)
            {
                this.openLogFiles();
            }
            else if (e.Button == this.toolBarButton16)
            {
                this.delLogFiles();
            }
            else
            {
                ToolBarButton button1 = this.toolBarButton17;
                ToolBarButton button = e.Button;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "正在下载订单":
                    this.whichlistView = 0;
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.displayer(this.tabControl2, 1);
                    this.glacialList1.BringToFront();
                    return;

                case "已下载订单":
                    this.whichlistView = 1;
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.displayer(this.tabControl2, 1);
                    this.glacialList2.BringToFront();
                    return;

                case "已删除订单":
                    this.whichlistView = 2;
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.displayer(this.tabControl2, 1);
                    this.glacialList3.BringToFront();
                    return;

                case "取消下载订单":
                    this.whichlistView = 3;
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.displayer(this.tabControl2, 1);
                    this.glacialList4.BringToFront();
                    return;

                case "本地用户管理":
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.displayer(this.tabControl2, 2);
                    return;

                case "本地订单管理":
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.panel5.Visible = true;
                    this.splitter2.Visible = true;
                    return;

                case "Ftp服务器":
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.splitter2.Visible = false;
                    return;

                case "客户文件管理":
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.displayer(this.tabControl2, 4);
                    return;

                case "系统日志管理":
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.displayer(this.tabControl2, 3);
                    return;

                case "声明/公告管理":
                    this.toolBarButton1.Enabled = false;
                    this.toolBarButton2.Enabled = false;
                    this.toolBarButton3.Enabled = false;
                    this.toolBarButton4.Enabled = false;
                    this.toolBarButton5.Enabled = false;
                    this.displayer(this.tabControl2, 5);
                    return;
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.treeView1.SelectedNode.Text == "印易网上平台")
            {
                if (!ePrintWebHome)
                {
                    this._ePrintWebHome = new ePrintOrderManager.ePrintWebHome();
                    this._ePrintWebHome.Show();
                    base.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    this._ePrintWebHome.BringToFront();
                    this._ePrintWebHome.WindowState = FormWindowState.Normal;
                    base.WindowState = FormWindowState.Minimized;
                }
            }
            if (this.treeView1.SelectedNode.Text == "发送文件给客户")
            {
                if (!SendFileIsOpen)
                {
                    this._sendFile = new SendFileToUser();
                    this._sendFile.Show();
                }
                else
                {
                    this._sendFile.BringToFront();
                }
            }
        }

        private void treeView1_MouseLeave(object sender, EventArgs e)
        {
            this.label19.Visible = false;
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.treeView1.GetNodeAt(e.X, e.Y) != null)
            {
                if ((this.treeView1.GetNodeAt(e.X, e.Y).Text == "印易网上平台") || (this.treeView1.GetNodeAt(e.X, e.Y).Text == "发送文件给客户"))
                {
                    this.label19.Location = new Point(e.X + 0x10, e.Y + 0x74);
                    this.label19.Visible = true;
                }
                else
                {
                    this.label19.Visible = false;
                }
            }
            else
            {
                this.label19.Visible = false;
            }
        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            this.treeView1.GetNodeAt(e.X, e.Y);
        }

        private void treeView2_Leave(object sender, EventArgs e)
        {
        }

        private void treeView2_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.treeView2.GetNodeAt(e.X, e.Y) != null)
            {
                if (string.Equals("订单信息", this.treeView2.GetNodeAt(e.X, e.Y).Text))
                {
                    this.glacialList5.BringToFront();
                    this.panel9.Visible = false;
                }
                else if (string.Equals(this.treeView2.GetNodeAt(e.X, e.Y).Text, "图表/日志"))
                {
                    this.listView1.Visible = false;
                    this.panel9.Visible = false;
                    this.listView3.Visible = false;
                    this.panel8.Visible = true;
                    this.panel8.BringToFront();
                }
                else if (string.Equals(this.treeView2.GetNodeAt(e.X, e.Y).Text, "设置"))
                {
                    if (!this.panel9.Visible)
                    {
                        this.panel9.Location = this.glacialList5.PointToScreen(new Point(50, -15));
                        this.panel9.BringToFront();
                        this.panel9.Visible = true;
                    }
                    else
                    {
                        this.panel9.Visible = false;
                    }
                }
                else
                {
                    int viewWhich = 0;
                    string text = this.treeView2.GetNodeAt(e.X, e.Y).Text;
                    if (text != null)
                    {
                        text = string.IsInterned(text);
                        if (text == "块1")
                        {
                            viewWhich = 0;
                        }
                        else if (text == "块2")
                        {
                            viewWhich = 1;
                        }
                        else if (text == "块3")
                        {
                            viewWhich = 2;
                        }
                        else if (text == "块4")
                        {
                            viewWhich = 3;
                        }
                        else
                        {
                            if (text != "块5")
                            {
                                return;
                            }
                            viewWhich = 4;
                        }
                        this.panel9.Visible = false;
                        this.listView1.Visible = true;
                        _fileinfo tag = (_fileinfo) this.glacialList1.Tag;
                        if (tag != null)
                        {
                            this.getRequestResponseInfo(tag, viewWhich);
                        }
                    }
                }
            }
        }

        private void unzip(string zipFilePath, string zipType)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
                RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"WinRAR\shell\open\command", true);
                if (((key != null) && (key2 != null)) && ((key.GetValue("AutoZip") != null) && (key2.GetValue("") != null)))
                {
                    string[] strArray = key.GetValue("AutoZip").ToString().Split(new char[] { '|' });
                    if ((strArray[0] == "1") && (strArray[2].IndexOf(zipType) >= 0))
                    {
                        Thread.Sleep(300);
                        new ePrintUnzip { zipFilePath = zipFilePath }.Unzip();
                    }
                }
            }
            catch
            {
            }
        }

        private void UpdateCheck()
        {
            this.checkRegisterInfo();
            try
            {
                if (File.Exists(@"印易安装程序包\" + this.NewVersion + @"\Dart.PowerTCP.Ftp.dll") && !File.Exists("Dart.PowerTCP.Ftp.dll.old"))
                {
                    File.Move("Dart.PowerTCP.Ftp.dll", "Dart.PowerTCP.Ftp.dll.old");
                    File.Move(@"印易安装程序包\" + this.NewVersion + @"\Dart.PowerTCP.Ftp.dll", "Dart.PowerTCP.Ftp.dll");
                }
                Console.WriteLine("正在升级旧的powertcp 组件...");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
        }

        private void viewBulletinInfo()
        {
            if ((this.listView8.Items.Count > 0) && (this.listView8.SelectedItems.Count > 0))
            {
                this.textBox4.ReadOnly = this.textBox6.ReadOnly = true;
                this.textBox6.Text = this.listView8.SelectedItems[0].SubItems[0].Text;
                this.textBox4.Text = this.listView8.SelectedItems[0].SubItems[1].Text.Replace("\n", "\r\n");
            }
        }

        private void viewFont()
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
                if (key != null)
                {
                    if (key.GetValue("OrderInfoSize") != null)
                    {
                        Convert.ToInt16(key.GetValue("OrderInfoSize"));
                    }
                    if (key.GetValue("OrderInfoItemheight") != null)
                    {
                        if (key.GetValue("OrderInfoItemheight").ToString() == "auto")
                        {
                            this.glacialList5.AutoHeight = true;
                        }
                        else
                        {
                            try
                            {
                                this.glacialList5.AutoHeight = false;
                                int num = Convert.ToInt16(key.GetValue("OrderInfoItemheight"));
                                this.glacialList5.ItemHeight = num;
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog(exception.ToString());
            }
        }

        private void vieworder30(string strOrderInfo)
        {
            try
            {
                this.glacialList5.Columns.Clear();
                this.glacialList5.Columns.Add("订单项", 0x9b);
                this.glacialList5.Columns.Add("订单信息", 700);
                string[] strArray = strOrderInfo.Split(new char[] { ',' });
                if (strArray[0] == "0")
                {
                    GLItem[] items = new GLItem[11];
                    for (int i = 0; i < 11; i++)
                    {
                        Console.Write("\n" + strArray[i]);
                        GLItem item = new GLItem();
                        switch (i)
                        {
                            case 0:
                                item.SubItems[0].Text = "  订单类型";
                                item.SubItems[1].Text = "在线输出";
                                item.RowBorderSize = 1;
                                item.ForeColor = item.RowBorderColor = Color.DarkBlue;
                                break;

                            case 1:
                                item.SubItems[0].Text = "  文件格式";
                                item.SubItems[1].Text = strArray[1];
                                break;

                            case 2:
                                item.SubItems[0].Text = "  软件格式(版本)";
                                item.SubItems[1].Text = strArray[10];
                                break;

                            case 3:
                                item.SubItems[0].Text = "  成品尺寸";
                                item.SubItems[1].Text = strArray[2];
                                break;

                            case 4:
                                item.SubItems[0].Text = "  色版";
                                item.SubItems[1].Text = strArray[3] + " " + strArray[4];
                                break;

                            case 5:
                                item.SubItems[0].Text = "  网线";
                                item.SubItems[1].Text = strArray[5];
                                break;

                            case 6:
                                item.SubItems[0].Text = "  药膜方向";
                                item.SubItems[1].Text = strArray[6];
                                break;

                            case 7:
                                item.SubItems[0].Text = "  阴阳片";
                                item.SubItems[1].Text = strArray[7];
                                break;

                            case 8:
                                item.SubItems[0].Text = "  打样";
                                item.SubItems[1].Text = strArray[8];
                                break;

                            case 9:
                                item.SubItems[0].Text = "  打样纸";
                                item.SubItems[1].Text = strArray[9];
                                break;

                            case 10:
                                item.SubItems[0].Text = "  备注";
                                item.SubItems[1].Text = strArray[11];
                                break;
                        }
                        try
                        {
                            item.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        try
                        {
                            item.SubItems[1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item.SubItems[1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                        }
                        catch
                        {
                        }
                        items[i] = item;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(items);
                    this.glacialList5.EndUpdate();
                }
                else if (strArray[0] == "1")
                {
                    GLItem[] itemArray2 = new GLItem[11];
                    for (int j = 0; j < 11; j++)
                    {
                        Console.Write("\n" + strArray[j]);
                        GLItem item2 = new GLItem();
                        string str = null;
                        if (strArray[6] == "√")
                        {
                            str = str + "裱板 ";
                        }
                        if (strArray[7] == "√")
                        {
                            str = str + "封边 ";
                        }
                        if (strArray[8] == "√")
                        {
                            str = str + "挂轴 ";
                        }
                        if (strArray[9] == "√")
                        {
                            str = str + "扣眼 ";
                        }
                        string str2 = "留边:" + strArray[10] + "   面积:" + strArray[11] + "\x00d7" + strArray[12] + "=" + strArray[13];
                        switch (j)
                        {
                            case 0:
                                item2.SubItems[0].Text = "  订单类型";
                                item2.SubItems[1].Text = "在线喷画";
                                item2.RowBorderSize = 1;
                                item2.ForeColor = item2.RowBorderColor = Color.DarkOrange;
                                break;

                            case 1:
                                item2.SubItems[0].Text = "  文件格式";
                                item2.SubItems[1].Text = strArray[1];
                                break;

                            case 2:
                                item2.SubItems[0].Text = "  类型";
                                item2.SubItems[1].Text = strArray[2];
                                break;

                            case 3:
                                item2.SubItems[0].Text = "  喷画介质";
                                item2.SubItems[1].Text = strArray[3];
                                break;

                            case 4:
                                item2.SubItems[0].Text = "  精度";
                                item2.SubItems[1].Text = strArray[4];
                                break;

                            case 5:
                                item2.SubItems[0].Text = "  过膜";
                                item2.SubItems[1].Text = strArray[5];
                                break;

                            case 6:
                                item2.SubItems[0].Text = "  其它";
                                item2.SubItems[1].Text = str;
                                break;

                            case 7:
                                item2.SubItems[0].Text = "  尺寸";
                                item2.SubItems[1].Text = str2;
                                break;

                            case 8:
                                item2.SubItems[0].Text = "  数量";
                                item2.SubItems[1].Text = strArray[14];
                                break;

                            case 9:
                                item2.SubItems[0].Text = "  看小样";
                                item2.SubItems[1].Text = strArray[15];
                                break;

                            case 10:
                                item2.SubItems[0].Text = "  备注";
                                item2.SubItems[1].Text = strArray[0x10];
                                break;
                        }
                        try
                        {
                            item2.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item2.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        try
                        {
                            item2.SubItems[1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item2.SubItems[1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                        }
                        catch
                        {
                        }
                        itemArray2[j] = item2;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(itemArray2);
                    this.glacialList5.EndUpdate();
                }
                else if (strArray[0] == "2")
                {
                    this.glacialList5.Items.Clear();
                    GLItem[] itemArray3 = new GLItem[11];
                    for (int k = 0; k < 11; k++)
                    {
                        Console.Write("\n" + strArray[k]);
                        GLItem item3 = new GLItem();
                        switch (k)
                        {
                            case 0:
                                item3.SubItems[0].Text = "  订单类型";
                                item3.SubItems[1].Text = "传统印刷";
                                item3.RowBorderSize = 1;
                                item3.ForeColor = item3.RowBorderColor = Color.DarkRed;
                                break;

                            case 1:
                                item3.SubItems[0].Text = "  产品类型";
                                item3.SubItems[1].Text = strArray[1];
                                break;

                            case 2:
                                item3.SubItems[0].Text = "  纸张规格";
                                item3.SubItems[1].Text = strArray[2];
                                break;

                            case 3:
                                item3.SubItems[0].Text = "  纸张厚度";
                                item3.SubItems[1].Text = strArray[3];
                                break;

                            case 4:
                                item3.SubItems[0].Text = "  纸张类型";
                                item3.SubItems[1].Text = strArray[4];
                                break;

                            case 5:
                                item3.SubItems[0].Text = "  印色";
                                item3.SubItems[1].Text = strArray[5];
                                break;

                            case 6:
                                item3.SubItems[0].Text = "  印刷面";
                                item3.SubItems[1].Text = strArray[6];
                                break;

                            case 7:
                                item3.SubItems[0].Text = "  印数";
                                item3.SubItems[1].Text = strArray[7];
                                break;

                            case 8:
                                item3.SubItems[0].Text = "  覆膜";
                                item3.SubItems[1].Text = strArray[8];
                                break;

                            case 9:
                                item3.SubItems[0].Text = "  上光与压纹";
                                item3.SubItems[1].Text = strArray[9];
                                break;

                            case 10:
                                item3.SubItems[0].Text = "  备注";
                                item3.SubItems[1].Text = strArray[10];
                                break;
                        }
                        try
                        {
                            item3.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item3.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        try
                        {
                            item3.SubItems[1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item3.SubItems[1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                        }
                        catch
                        {
                        }
                        itemArray3[k] = item3;
                    }
                    this.glacialList5.Items.AddRange(itemArray3);
                    this.glacialList5.Refresh();
                }
                else if (strArray[0] == "3")
                {
                    GLItem[] itemArray4 = new GLItem[11];
                    for (int m = 0; m < 11; m++)
                    {
                        Console.Write("\n" + strArray[m]);
                        GLItem item4 = new GLItem();
                        string str3 = null;
                        if (strArray[7] == "√")
                        {
                            str3 = str3 + "折页 ";
                        }
                        if (strArray[8] == "√")
                        {
                            str3 = str3 + "烫金 ";
                        }
                        if (strArray[9] == "√")
                        {
                            str3 = str3 + "啤 ";
                        }
                        switch (m)
                        {
                            case 0:
                                item4.SubItems[0].Text = "  订单类型";
                                item4.SubItems[1].Text = "数码快印";
                                item4.RowBorderSize = 1;
                                item4.ForeColor = item4.RowBorderColor = Color.DodgerBlue;
                                break;

                            case 1:
                                item4.SubItems[0].Text = "  纸张规格";
                                item4.SubItems[1].Text = strArray[1];
                                break;

                            case 2:
                                item4.SubItems[0].Text = "  纸张类型";
                                item4.SubItems[1].Text = strArray[2];
                                break;

                            case 3:
                                item4.SubItems[0].Text = "  印刷面";
                                item4.SubItems[1].Text = strArray[3];
                                break;

                            case 4:
                                item4.SubItems[0].Text = "  裁切";
                                item4.SubItems[1].Text = strArray[4];
                                break;

                            case 5:
                                item4.SubItems[0].Text = "  过膜";
                                item4.SubItems[1].Text = strArray[5];
                                break;

                            case 6:
                                item4.SubItems[0].Text = "  装订";
                                item4.SubItems[1].Text = strArray[6];
                                break;

                            case 7:
                                item4.SubItems[0].Text = "  其它";
                                item4.SubItems[1].Text = str3;
                                break;

                            case 8:
                                item4.SubItems[0].Text = "  P数";
                                item4.SubItems[1].Text = strArray[10];
                                break;

                            case 9:
                                item4.SubItems[0].Text = "  张数";
                                item4.SubItems[1].Text = strArray[11];
                                break;

                            case 10:
                                item4.SubItems[0].Text = "  备注";
                                item4.SubItems[1].Text = strArray[12];
                                break;
                        }
                        try
                        {
                            item4.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item4.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        try
                        {
                            item4.SubItems[1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item4.SubItems[1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                        }
                        catch
                        {
                        }
                        itemArray4[m] = item4;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(itemArray4);
                    this.glacialList5.EndUpdate();
                }
                else
                {
                    GLItem[] itemArray5 = new GLItem[12];
                    for (int n = 0; n < 12; n++)
                    {
                        Console.Write("\n" + strArray[n]);
                        GLItem item5 = new GLItem();
                        switch (n)
                        {
                            case 0:
                                item5.SubItems[0].Text = "  订单类型";
                                item5.SubItems[1].Text = "打样/制版";
                                item5.RowBorderSize = 1;
                                item5.ForeColor = item5.RowBorderColor = Color.DarkViolet;
                                break;

                            case 1:
                                item5.SubItems[0].Text = "  文件格式";
                                item5.SubItems[1].Text = strArray[1];
                                break;

                            case 2:
                                item5.SubItems[0].Text = "  软件格式(版本号)";
                                item5.SubItems[1].Text = strArray[2];
                                break;

                            case 3:
                                item5.SubItems[0].Text = "  成品尺寸";
                                item5.SubItems[1].Text = strArray[3];
                                break;

                            case 4:
                                item5.SubItems[0].Text = "  色版";
                                item5.SubItems[1].Text = strArray[4] + "  " + strArray[5];
                                break;

                            case 5:
                                item5.SubItems[0].Text = "  网线";
                                item5.SubItems[1].Text = strArray[6];
                                break;

                            case 6:
                                item5.SubItems[0].Text = "  数码打样纸";
                                item5.SubItems[1].Text = strArray[7];
                                break;

                            case 7:
                                item5.SubItems[0].Text = "  总P数";
                                item5.SubItems[1].Text = strArray[8];
                                break;

                            case 8:
                                item5.SubItems[0].Text = "  CTP印刷";
                                item5.SubItems[1].Text = strArray[9];
                                break;

                            case 9:
                                item5.SubItems[0].Text = "  制版规格";
                                item5.SubItems[1].Text = strArray[10];
                                break;

                            case 10:
                                item5.SubItems[0].Text = "  件数";
                                item5.SubItems[1].Text = strArray[11];
                                break;

                            case 11:
                                item5.SubItems[0].Text = "  备注";
                                item5.SubItems[1].Text = strArray[12];
                                break;
                        }
                        try
                        {
                            item5.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item5.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        try
                        {
                            item5.SubItems[1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item5.SubItems[1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                        }
                        catch
                        {
                        }
                        itemArray5[n] = item5;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(itemArray5);
                    this.glacialList5.EndUpdate();
                }
            }
            catch (Exception exception)
            {
                this.glacialList5.Items.Clear();
                this.ePrintLog.WriteLog("显示3.0/3.1发送的订单信息时出错: " + exception.ToString() + "\r\n" + strOrderInfo);
            }
        }

        private void vieworder33(string strOrderInfo)
        {
            try
            {
                string[] strArray = strOrderInfo.Split(new char[] { ',' });
                if (strArray[0] == "0")
                {
                    string[] strArray2 = strArray[1].Split(new char[] { '[' })[1].Replace("文件名，要求]", "").Trim().Split(new char[] { '\n' });
                    int length = strArray2.Length;
                    this.glacialList5.Columns.Add("订单项(包中共有" + length.ToString() + "个文件)", 0x9b);
                    int nColumnWidth = 0;
                    if (length == 1)
                    {
                        nColumnWidth = 700;
                    }
                    else if ((length > 1) && (length <= 7))
                    {
                        nColumnWidth = 700 / length;
                    }
                    else
                    {
                        nColumnWidth = 100;
                    }
                    string[] strArray3 = new string[2];
                    GLItem[] items = new GLItem[13];
                    this.glacialList5.Items.Clear();
                    for (int i = 0; i < 13; i++)
                    {
                        GLItem item = new GLItem();
                        switch (i)
                        {
                            case 0:
                                item.SubItems[0].Text = "  订单类型";
                                break;

                            case 1:
                                item.SubItems[0].Text = "  文件名称";
                                break;

                            case 2:
                                item.SubItems[0].Text = "  文件格式";
                                break;

                            case 3:
                                item.SubItems[0].Text = "  软件格式(版本)";
                                break;

                            case 4:
                                item.SubItems[0].Text = "  成品尺寸";
                                break;

                            case 5:
                                item.SubItems[0].Text = "  色版";
                                break;

                            case 6:
                                item.SubItems[0].Text = "  网线";
                                break;

                            case 7:
                                item.SubItems[0].Text = "  药膜方向";
                                break;

                            case 8:
                                item.SubItems[0].Text = "  阴阳片";
                                break;

                            case 9:
                                item.SubItems[0].Text = "  打样";
                                break;

                            case 10:
                                item.SubItems[0].Text = "  打样纸";
                                break;

                            case 11:
                                item.SubItems[0].Text = "  P数";
                                break;

                            case 12:
                                item.SubItems[0].Text = "  备注";
                                break;
                        }
                        try
                        {
                            item.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        for (int j = 0; j < strArray2.Length; j++)
                        {
                            if (i == 0)
                            {
                                this.glacialList5.Columns.Add("文件" + Convert.ToString((int) (j + 1)) + "信息", nColumnWidth);
                            }
                            strArray3 = strArray2[j].Trim().Split(new char[] { '>' });
                            string[] strArray4 = new string[13];
                            string[] strArray5 = strArray3[1].Split(new char[] { '、' });
                            for (int k = 0; k < (strArray5.Length - 1); k++)
                            {
                                if (strArray5[k].IndexOf("格式:") >= 0)
                                {
                                    strArray4[0] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("软件:") >= 0)
                                {
                                    strArray4[1] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("版本号:") >= 0)
                                {
                                    strArray4[2] = "(" + strArray5[k] + ")";
                                }
                                else if (strArray5[k].IndexOf("成品尺寸:") >= 0)
                                {
                                    strArray4[3] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("色板:") >= 0)
                                {
                                    strArray4[4] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("专色:") >= 0)
                                {
                                    strArray4[5] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("网线:") >= 0)
                                {
                                    strArray4[6] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("药膜方向:") >= 0)
                                {
                                    strArray4[7] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("阴阳片:") >= 0)
                                {
                                    strArray4[8] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("打样:") >= 0)
                                {
                                    strArray4[9] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("打样纸:") >= 0)
                                {
                                    strArray4[10] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("p数:") >= 0)
                                {
                                    strArray4[11] = strArray5[k];
                                }
                                else if (strArray5[k].IndexOf("备注:") >= 0)
                                {
                                    strArray4[12] = strArray5[k];
                                }
                            }
                            for (int m = 0; m < strArray4.Length; m++)
                            {
                                if (strArray4[m] == null)
                                {
                                    strArray4[m] = "";
                                }
                            }
                            if ((j == 0) && (i == 0))
                            {
                                item.SubItems[j + 1].Text = "在线输出";
                                item.RowBorderSize = 1;
                                item.ForeColor = item.RowBorderColor = Color.DarkBlue;
                            }
                            if (i == 1)
                            {
                                item.SubItems[j + 1].Text = strArray3[0].Substring(0, strArray3[0].LastIndexOf("-"));
                            }
                            if (i == 2)
                            {
                                item.SubItems[j + 1].Text = strArray4[0].Replace("格式:", "");
                            }
                            if (i == 3)
                            {
                                item.SubItems[j + 1].Text = strArray4[1].Replace("软件:", "") + strArray4[2].Replace("版本号:", "");
                            }
                            if (i == 4)
                            {
                                item.SubItems[j + 1].Text = strArray4[3].Replace("成品尺寸:", "");
                            }
                            if (i == 5)
                            {
                                item.SubItems[j + 1].Text = strArray4[4].Replace("色板:", "") + " " + strArray4[5];
                            }
                            if (i == 6)
                            {
                                item.SubItems[j + 1].Text = strArray4[6].Replace("网线:", "");
                            }
                            if (i == 7)
                            {
                                item.SubItems[j + 1].Text = strArray4[7].Replace("药膜方向:", "");
                            }
                            if (i == 8)
                            {
                                item.SubItems[j + 1].Text = strArray4[8].Replace("阴阳片:", "");
                            }
                            if (i == 9)
                            {
                                item.SubItems[j + 1].Text = strArray4[9].Replace("打样:", "");
                            }
                            if (i == 10)
                            {
                                item.SubItems[j + 1].Text = strArray4[10].Replace("打样纸:", "");
                            }
                            if (i == 11)
                            {
                                item.SubItems[j + 1].Text = strArray4[11].Replace("p数:", "");
                            }
                            if (i == 12)
                            {
                                item.SubItems[j + 1].Text = strArray4[12].Replace("备注:", "");
                            }
                            try
                            {
                                item.SubItems[j + 1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                                item.SubItems[j + 1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                            }
                            catch
                            {
                            }
                        }
                        items[i] = item;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(items);
                    this.glacialList5.EndUpdate();
                }
                else if (strArray[0] == "1")
                {
                    string[] strArray6 = strArray[1].Split(new char[] { '[' })[1].Replace("文件名，要求]", "").Replace("文件名要求]", "").Trim().Split(new char[] { '\n' });
                    int num7 = strArray6.Length;
                    this.glacialList5.Columns.Add("订单项(包中共有" + num7.ToString() + "个文件)", 0x9b);
                    int num8 = 0;
                    if (num7 == 1)
                    {
                        num8 = 700;
                    }
                    else if ((num7 > 1) && (num7 <= 7))
                    {
                        num8 = 700 / num7;
                    }
                    else
                    {
                        num8 = 100;
                    }
                    string[] strArray7 = new string[2];
                    GLItem[] itemArray2 = new GLItem[12];
                    this.glacialList5.Items.Clear();
                    for (int n = 0; n < 12; n++)
                    {
                        GLItem item2 = new GLItem();
                        switch (n)
                        {
                            case 0:
                                item2.SubItems[0].Text = "  订单类型";
                                break;

                            case 1:
                                item2.SubItems[0].Text = "  文件名称";
                                break;

                            case 2:
                                item2.SubItems[0].Text = "  文件格式";
                                break;

                            case 3:
                                item2.SubItems[0].Text = "  软件格式(版本)";
                                break;

                            case 4:
                                item2.SubItems[0].Text = "  喷画介质";
                                break;

                            case 5:
                                item2.SubItems[0].Text = "  精度";
                                break;

                            case 6:
                                item2.SubItems[0].Text = "  过膜";
                                break;

                            case 7:
                                item2.SubItems[0].Text = "  其他工序";
                                break;

                            case 8:
                                item2.SubItems[0].Text = "  尺寸";
                                break;

                            case 9:
                                item2.SubItems[0].Text = "  数量";
                                break;

                            case 10:
                                item2.SubItems[0].Text = "  看小样";
                                break;

                            case 11:
                                item2.SubItems[0].Text = "  备注";
                                break;
                        }
                        try
                        {
                            item2.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item2.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        for (int num10 = 0; num10 < strArray6.Length; num10++)
                        {
                            if (n == 0)
                            {
                                this.glacialList5.Columns.Add("文件" + Convert.ToString((int) (num10 + 1)) + "信息", num8);
                            }
                            strArray7 = strArray6[num10].Trim().Split(new char[] { '>' });
                            string[] strArray8 = new string[13];
                            string[] strArray9 = strArray7[1].Split(new char[] { '、' });
                            for (int num11 = 0; num11 < (strArray9.Length - 1); num11++)
                            {
                                if (strArray9[num11].IndexOf("格式:") >= 0)
                                {
                                    strArray8[0] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("软件:") >= 0)
                                {
                                    strArray8[1] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("版本号:") >= 0)
                                {
                                    strArray8[2] = "(" + strArray9[num11] + ")";
                                }
                                else if (strArray9[num11].IndexOf("喷画介质:") >= 0)
                                {
                                    strArray8[3] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("精度:") >= 0)
                                {
                                    strArray8[4] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("过膜:") >= 0)
                                {
                                    strArray8[5] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("其他工序:") >= 0)
                                {
                                    strArray8[6] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("留边:") >= 0)
                                {
                                    strArray8[7] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("宽度:") >= 0)
                                {
                                    strArray8[8] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("高度:") >= 0)
                                {
                                    strArray8[9] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("面积:") >= 0)
                                {
                                    strArray8[10] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("数量:") >= 0)
                                {
                                    strArray8[11] = strArray9[num11];
                                }
                                else if (strArray9[num11].IndexOf("备注:") >= 0)
                                {
                                    strArray8[12] = strArray9[num11];
                                }
                            }
                            for (int num12 = 0; num12 < strArray8.Length; num12++)
                            {
                                if (strArray8[num12] == null)
                                {
                                    strArray8[num12] = "";
                                }
                            }
                            if ((num10 == 0) && (n == 0))
                            {
                                item2.SubItems[num10 + 1].Text = "在线喷画";
                                item2.RowBorderSize = 1;
                                item2.ForeColor = item2.RowBorderColor = Color.DarkOrange;
                            }
                            if (n == 1)
                            {
                                item2.SubItems[num10 + 1].Text = strArray7[0].Substring(0, strArray7[0].LastIndexOf("-"));
                            }
                            if (n == 2)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[0].Replace("格式:", "");
                            }
                            if (n == 3)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[1].Replace("软件:", "") + strArray8[2].Replace("版本号:", "");
                            }
                            if (n == 4)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[3].Replace("喷画介质:", "");
                            }
                            if (n == 5)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[4].Replace("精度:", "");
                            }
                            if (n == 6)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[5].Replace("过膜:", "");
                            }
                            if (n == 7)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[6].Replace("其他工序:", "").Replace("看小样", "");
                            }
                            if (n == 8)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[7] + "面积：" + ((strArray8[8].Replace("宽度:", "") == "") ? "0" : strArray8[8].Replace("宽度:", "")) + "\x00d7" + ((strArray8[9].Replace("高度:", "") == "") ? "0" : strArray8[9].Replace("高度:", "")) + "=" + strArray8[10].Replace("面积:", "");
                            }
                            if (n == 9)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[11].Replace("数量:", "");
                            }
                            if (n == 10)
                            {
                                item2.SubItems[num10 + 1].Text = (strArray8[6].IndexOf("看小样") >= 0) ? "√" : "";
                            }
                            if (n == 11)
                            {
                                item2.SubItems[num10 + 1].Text = strArray8[12].Replace("备注:", "");
                            }
                            try
                            {
                                item2.SubItems[num10 + 1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                                item2.SubItems[num10 + 1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                            }
                            catch
                            {
                            }
                        }
                        itemArray2[n] = item2;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(itemArray2);
                    this.glacialList5.EndUpdate();
                }
                else if (strArray[0] == "2")
                {
                    string[] strArray10 = strArray[1].Split(new char[] { '[' })[1].Replace("文件名，要求]", "").Trim().Split(new char[] { '\n' });
                    int num13 = strArray10.Length;
                    this.glacialList5.Columns.Add("订单项(包中共有" + num13.ToString() + "个文件)", 0x9b);
                    int num14 = 0;
                    if (num13 == 1)
                    {
                        num14 = 700;
                    }
                    else if ((num13 > 1) && (num13 <= 7))
                    {
                        num14 = 700 / num13;
                    }
                    else
                    {
                        num14 = 100;
                    }
                    string[] strArray11 = new string[2];
                    GLItem[] itemArray3 = new GLItem[12];
                    this.glacialList5.Items.Clear();
                    for (int num15 = 0; num15 < 12; num15++)
                    {
                        GLItem item3 = new GLItem();
                        switch (num15)
                        {
                            case 0:
                                item3.SubItems[0].Text = "  订单类型";
                                break;

                            case 1:
                                item3.SubItems[0].Text = "  文件名称";
                                break;

                            case 2:
                                item3.SubItems[0].Text = "  产品类型";
                                break;

                            case 3:
                                item3.SubItems[0].Text = "  纸张规格";
                                break;

                            case 4:
                                item3.SubItems[0].Text = "  纸张厚度";
                                break;

                            case 5:
                                item3.SubItems[0].Text = "  纸张类型";
                                break;

                            case 6:
                                item3.SubItems[0].Text = "  印色";
                                break;

                            case 7:
                                item3.SubItems[0].Text = "  印刷面";
                                break;

                            case 8:
                                item3.SubItems[0].Text = "  印数";
                                break;

                            case 9:
                                item3.SubItems[0].Text = "  覆膜";
                                break;

                            case 10:
                                item3.SubItems[0].Text = "  上光/压纹";
                                break;

                            case 11:
                                item3.SubItems[0].Text = "  备注";
                                break;
                        }
                        try
                        {
                            item3.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item3.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        for (int num16 = 0; num16 < strArray10.Length; num16++)
                        {
                            if (num15 == 0)
                            {
                                this.glacialList5.Columns.Add("文件" + Convert.ToString((int) (num16 + 1)) + "信息", num14);
                            }
                            strArray11 = strArray10[num16].Trim().Split(new char[] { '>' });
                            string[] strArray12 = new string[10];
                            string[] strArray13 = strArray11[1].Split(new char[] { '、' });
                            for (int num17 = 0; num17 < (strArray13.Length - 1); num17++)
                            {
                                if (strArray13[num17].IndexOf("产品类型:") >= 0)
                                {
                                    strArray12[0] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("纸张规格:") >= 0)
                                {
                                    strArray12[1] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("纸张厚度:") >= 0)
                                {
                                    strArray12[2] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("纸张类型:") >= 0)
                                {
                                    strArray12[3] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("印色:") >= 0)
                                {
                                    strArray12[4] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("印刷面:") >= 0)
                                {
                                    strArray12[5] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("印数:") >= 0)
                                {
                                    strArray12[6] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("覆膜:") >= 0)
                                {
                                    strArray12[7] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("上光／压纹:") >= 0)
                                {
                                    strArray12[8] = strArray13[num17];
                                }
                                else if (strArray13[num17].IndexOf("备注:") >= 0)
                                {
                                    strArray12[9] = strArray13[num17];
                                }
                            }
                            for (int num18 = 0; num18 < strArray12.Length; num18++)
                            {
                                if (strArray12[num18] == null)
                                {
                                    strArray12[num18] = "";
                                }
                            }
                            if ((num16 == 0) && (num15 == 0))
                            {
                                item3.SubItems[num16 + 1].Text = "传统印刷";
                                item3.RowBorderSize = 1;
                                item3.ForeColor = item3.RowBorderColor = Color.DarkRed;
                            }
                            if (num15 == 1)
                            {
                                item3.SubItems[num16 + 1].Text = strArray11[0].Substring(0, strArray11[0].LastIndexOf("-"));
                            }
                            if (num15 == 2)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[0].Replace("产品类型:", "");
                            }
                            if (num15 == 3)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[1].Replace("纸张规格:", "");
                            }
                            if (num15 == 4)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[2].Replace("纸张厚度:", "");
                            }
                            if (num15 == 5)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[3].Replace("纸张类型:", "");
                            }
                            if (num15 == 6)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[4].Replace("印色:", "");
                            }
                            if (num15 == 7)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[5].Replace("印刷面:", "");
                            }
                            if (num15 == 8)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[6].Replace("印数:", "");
                            }
                            if (num15 == 9)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[7].Replace("覆膜:", "");
                            }
                            if (num15 == 10)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[8].Replace("上光／压纹:", "");
                            }
                            if (num15 == 11)
                            {
                                item3.SubItems[num16 + 1].Text = strArray12[9].Replace("备注:", "");
                            }
                            try
                            {
                                item3.SubItems[num16 + 1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                                item3.SubItems[num16 + 1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                            }
                            catch
                            {
                            }
                        }
                        itemArray3[num15] = item3;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(itemArray3);
                    this.glacialList5.EndUpdate();
                }
                else if (strArray[0] == "3")
                {
                    string[] strArray14 = strArray[1].Split(new char[] { '[' })[1].Replace("文件名，要求]", "").Trim().Split(new char[] { '\n' });
                    int num19 = strArray14.Length;
                    this.glacialList5.Columns.Add("订单项(包中共有" + num19.ToString() + "个文件)", 0x9b);
                    int num20 = 0;
                    if (num19 == 1)
                    {
                        num20 = 700;
                    }
                    else if ((num19 > 1) && (num19 <= 7))
                    {
                        num20 = 700 / num19;
                    }
                    else
                    {
                        num20 = 100;
                    }
                    string[] strArray15 = new string[2];
                    GLItem[] itemArray4 = new GLItem[12];
                    this.glacialList5.Items.Clear();
                    for (int num21 = 0; num21 < 12; num21++)
                    {
                        GLItem item4 = new GLItem();
                        switch (num21)
                        {
                            case 0:
                                item4.SubItems[0].Text = "  订单类型";
                                break;

                            case 1:
                                item4.SubItems[0].Text = "  文件名称";
                                break;

                            case 2:
                                item4.SubItems[0].Text = "  纸张规格";
                                break;

                            case 3:
                                item4.SubItems[0].Text = "  纸张类型";
                                break;

                            case 4:
                                item4.SubItems[0].Text = "  印刷面";
                                break;

                            case 5:
                                item4.SubItems[0].Text = "  裁切";
                                break;

                            case 6:
                                item4.SubItems[0].Text = "  过膜";
                                break;

                            case 7:
                                item4.SubItems[0].Text = "  装订";
                                break;

                            case 8:
                                item4.SubItems[0].Text = "  其它";
                                break;

                            case 9:
                                item4.SubItems[0].Text = "  P数";
                                break;

                            case 10:
                                item4.SubItems[0].Text = "  张数";
                                break;

                            case 11:
                                item4.SubItems[0].Text = "  备注";
                                break;
                        }
                        try
                        {
                            item4.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item4.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        for (int num22 = 0; num22 < strArray14.Length; num22++)
                        {
                            if (num21 == 0)
                            {
                                this.glacialList5.Columns.Add("文件" + Convert.ToString((int) (num22 + 1)) + "信息", num20);
                            }
                            strArray15 = strArray14[num22].Trim().Split(new char[] { '>' });
                            string[] strArray16 = new string[13];
                            string[] strArray17 = strArray15[1].Split(new char[] { '、' });
                            for (int num23 = 0; num23 < (strArray17.Length - 1); num23++)
                            {
                                if (strArray17[num23].IndexOf("纸张规格:") >= 0)
                                {
                                    strArray16[0] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("纸张类型:") >= 0)
                                {
                                    strArray16[1] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("印刷面:") >= 0)
                                {
                                    strArray16[2] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("裁切:") >= 0)
                                {
                                    strArray16[3] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("过膜:") >= 0)
                                {
                                    strArray16[4] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("装订:") >= 0)
                                {
                                    strArray16[5] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("折页:") >= 0)
                                {
                                    strArray16[6] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("烫金:") >= 0)
                                {
                                    strArray16[7] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("碑:") >= 0)
                                {
                                    strArray16[8] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("打孔:") >= 0)
                                {
                                    strArray16[9] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("P数:") >= 0)
                                {
                                    strArray16[10] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("张数:") >= 0)
                                {
                                    strArray16[11] = strArray17[num23];
                                }
                                else if (strArray17[num23].IndexOf("备注:") >= 0)
                                {
                                    strArray16[12] = strArray17[num23];
                                }
                            }
                            for (int num24 = 0; num24 < strArray16.Length; num24++)
                            {
                                if (strArray16[num24] == null)
                                {
                                    strArray16[num24] = "";
                                }
                            }
                            if ((num22 == 0) && (num21 == 0))
                            {
                                item4.SubItems[num22 + 1].Text = "数码快印";
                                item4.RowBorderSize = 1;
                                item4.ForeColor = item4.RowBorderColor = Color.DodgerBlue;
                            }
                            if (num21 == 1)
                            {
                                item4.SubItems[num22 + 1].Text = strArray15[0].Substring(0, strArray15[0].LastIndexOf("-"));
                            }
                            if (num21 == 2)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[0].Replace("纸张规格:", "");
                            }
                            if (num21 == 3)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[1].Replace("纸张类型:", "");
                            }
                            if (num21 == 4)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[2].Replace("印刷面:", "");
                            }
                            if (num21 == 5)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[3].Replace("裁切:", "");
                            }
                            if (num21 == 6)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[4].Replace("过膜:", "");
                            }
                            if (num21 == 7)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[5].Replace("装订:", "");
                            }
                            if (num21 == 8)
                            {
                                item4.SubItems[num22 + 1].Text = ((strArray16[6].Replace("折页:", "") == "是") ? "折页" : "") + "  " + ((strArray16[7].Replace("烫金:", "") == "是") ? "烫金" : "") + "  " + ((strArray16[8].Replace("碑:", "") == "是") ? "碑" : "") + "  " + ((strArray16[9].Replace("打孔:", "") == "是") ? "打孔" : "");
                            }
                            if (num21 == 9)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[10].Replace("P数:", "");
                            }
                            if (num21 == 10)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[11].Replace("张数:", "");
                            }
                            if (num21 == 11)
                            {
                                item4.SubItems[num22 + 1].Text = strArray16[12].Replace("备注:", "");
                            }
                            try
                            {
                                item4.SubItems[num22 + 1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                                item4.SubItems[num22 + 1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                            }
                            catch
                            {
                            }
                        }
                        itemArray4[num21] = item4;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(itemArray4);
                    this.glacialList5.EndUpdate();
                }
                else
                {
                    string[] strArray18 = strArray[1].Split(new char[] { '[' })[1].Replace("文件名，要求]", "").Trim().Split(new char[] { '\n' });
                    int num25 = strArray18.Length;
                    this.glacialList5.Columns.Add("订单项(包中共有" + num25.ToString() + "个文件)", 0x9b);
                    int num26 = 0;
                    if (num25 == 1)
                    {
                        num26 = 700;
                    }
                    else if ((num25 > 1) && (num25 <= 7))
                    {
                        num26 = 700 / num25;
                    }
                    else
                    {
                        num26 = 100;
                    }
                    string[] strArray19 = new string[2];
                    GLItem[] itemArray5 = new GLItem[13];
                    this.glacialList5.Items.Clear();
                    for (int num27 = 0; num27 < 13; num27++)
                    {
                        GLItem item5 = new GLItem();
                        switch (num27)
                        {
                            case 0:
                                item5.SubItems[0].Text = "  订单类型";
                                break;

                            case 1:
                                item5.SubItems[0].Text = "  文件名称";
                                break;

                            case 2:
                                item5.SubItems[0].Text = "  文件格式";
                                break;

                            case 3:
                                item5.SubItems[0].Text = "  软件格式(版本)";
                                break;

                            case 4:
                                item5.SubItems[0].Text = "  成品尺寸";
                                break;

                            case 5:
                                item5.SubItems[0].Text = "  色版";
                                break;

                            case 6:
                                item5.SubItems[0].Text = "  网线";
                                break;

                            case 7:
                                item5.SubItems[0].Text = "  数码打样纸";
                                break;

                            case 8:
                                item5.SubItems[0].Text = "  总P数";
                                break;

                            case 9:
                                item5.SubItems[0].Text = "  CTP印刷";
                                break;

                            case 10:
                                item5.SubItems[0].Text = "  制版规格";
                                break;

                            case 11:
                                item5.SubItems[0].Text = "  件数";
                                break;

                            case 12:
                                item5.SubItems[0].Text = "  备注";
                                break;
                        }
                        try
                        {
                            item5.SubItems[0].Font = new Font(this.__OrderInfoFont1[0], float.Parse(this.__OrderInfoFont1[1]), (this.__OrderInfoFont1[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                            item5.SubItems[0].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor1[0]), Convert.ToInt16(this.__OrderInfoForeColor1[1]), Convert.ToInt16(this.__OrderInfoForeColor1[2]), Convert.ToInt16(this.__OrderInfoForeColor1[3]));
                        }
                        catch
                        {
                        }
                        for (int num28 = 0; num28 < strArray18.Length; num28++)
                        {
                            if (num27 == 0)
                            {
                                this.glacialList5.Columns.Add("文件" + Convert.ToString((int) (num28 + 1)) + "信息", num26);
                            }
                            strArray19 = strArray18[num28].Trim().Split(new char[] { '>' });
                            string[] strArray20 = new string[13];
                            string[] strArray21 = strArray19[1].Split(new char[] { '、' });
                            for (int num29 = 0; num29 < (strArray21.Length - 1); num29++)
                            {
                                if (strArray21[num29].IndexOf("格式:") >= 0)
                                {
                                    strArray20[0] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("软件:") >= 0)
                                {
                                    strArray20[1] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("版本号:") >= 0)
                                {
                                    strArray20[2] = "(" + strArray21[num29] + ")";
                                }
                                else if (strArray21[num29].IndexOf("成品尺寸:") >= 0)
                                {
                                    strArray20[3] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("色板:") >= 0)
                                {
                                    strArray20[4] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("专色:") >= 0)
                                {
                                    strArray20[5] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("网线:") >= 0)
                                {
                                    strArray20[6] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("数码打样纸:") >= 0)
                                {
                                    strArray20[7] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("总P数:") >= 0)
                                {
                                    strArray20[8] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("CTP印刷:") >= 0)
                                {
                                    strArray20[9] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("制版规格:") >= 0)
                                {
                                    strArray20[10] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("件数:") >= 0)
                                {
                                    strArray20[11] = strArray21[num29];
                                }
                                else if (strArray21[num29].IndexOf("备注:") >= 0)
                                {
                                    strArray20[12] = strArray21[num29];
                                }
                            }
                            for (int num30 = 0; num30 < strArray20.Length; num30++)
                            {
                                if (strArray20[num30] == null)
                                {
                                    strArray20[num30] = "";
                                }
                            }
                            if ((num28 == 0) && (num27 == 0))
                            {
                                item5.SubItems[num28 + 1].Text = "打样/制版";
                                item5.RowBorderSize = 1;
                                item5.ForeColor = item5.RowBorderColor = Color.DarkViolet;
                            }
                            if (num27 == 1)
                            {
                                item5.SubItems[num28 + 1].Text = strArray19[0].Substring(0, strArray19[0].LastIndexOf("-"));
                            }
                            if (num27 == 2)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[0].Replace("格式:", "");
                            }
                            if (num27 == 3)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[1].Replace("软件:", "") + strArray20[2].Replace("版本号:", "");
                            }
                            if (num27 == 4)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[3].Replace("成品尺寸:", "");
                            }
                            if (num27 == 5)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[4].Replace("色板:", "") + " " + strArray20[5];
                            }
                            if (num27 == 6)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[6].Replace("网线:", "");
                            }
                            if (num27 == 7)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[7].Replace("数码打样纸:", "");
                            }
                            if (num27 == 8)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[8].Replace("总P数:", "");
                            }
                            if (num27 == 9)
                            {
                                item5.SubItems[num28 + 1].Text = (strArray20[9].Replace("CTP印刷:", "") == "是") ? "√" : "";
                            }
                            if (num27 == 10)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[10].Replace("制版规格:", "");
                            }
                            if (num27 == 11)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[11].Replace("件数:", "");
                            }
                            if (num27 == 12)
                            {
                                item5.SubItems[num28 + 1].Text = strArray20[12].Replace("备注:", "");
                            }
                            try
                            {
                                item5.SubItems[num28 + 1].Font = new Font(this.__OrderInfoFont2[0], float.Parse(this.__OrderInfoFont2[1]), (this.__OrderInfoFont2[2] == "1") ? FontStyle.Bold : FontStyle.Regular);
                                item5.SubItems[num28 + 1].ForeColor = Color.FromArgb(Convert.ToInt16(this.__OrderInfoForeColor2[0]), Convert.ToInt16(this.__OrderInfoForeColor2[1]), Convert.ToInt16(this.__OrderInfoForeColor2[2]), Convert.ToInt16(this.__OrderInfoForeColor2[3]));
                            }
                            catch
                            {
                            }
                        }
                        itemArray5[num27] = item5;
                    }
                    this.glacialList5.BeginUpdate();
                    this.glacialList5.Items.Clear();
                    this.glacialList5.Items.AddRange(itemArray5);
                    this.glacialList5.EndUpdate();
                }
            }
            catch (Exception exception)
            {
                this.glacialList5.Items.Clear();
                this.ePrintLog.WriteLog("显示3.3发的订单信息时出错: " + exception.ToString());
            }
        }

        private void viewOrderInfo(string strOrderInfo)
        {
            this.viewFont();
            this.listView3.BringToFront();
            this.glacialList5.BringToFront();
            if ((strOrderInfo.IndexOf("[文件名，要求]") > 0) || (strOrderInfo.IndexOf("[文件名要求]") > 0))
            {
                this.vieworder33(strOrderInfo);
            }
            else
            {
                this.vieworder30(strOrderInfo);
            }
        }

        private void ViewOutputBulletin(string SearchInfo)
        {
            this.listView8.Items.Clear();
            try
            {
                string[] strArray = SearchInfo.Remove(SearchInfo.Length - 1, 1).Split(new char[] { '|' });
                ListViewItem[] values = new ListViewItem[strArray.Length];
                for (int i = 0; i < strArray.Length; i++)
                {
                    ListViewItem item = new ListViewItem();
                    string[] strArray2 = strArray[i].Remove(strArray[i].Length - 1, 1).Split(new char[] { ',' });
                    for (int j = 0; j < strArray2.Length; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                item.Tag = strArray2[j];
                                break;

                            case 1:
                                item.SubItems[0].Text = strArray2[1];
                                break;

                            default:
                                item.SubItems.Add(strArray2[j]);
                                break;
                        }
                    }
                    values[i] = item;
                }
                this.listView8.Items.AddRange(values);
                this.listView8.Refresh();
            }
            catch
            {
            }
        }

        private long ViewRemarkKey()
        {
            if ((this.glacialList2.Items.Count > 0) && (this.glacialList2.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList2.Items.Count; i++)
                {
                    if (this.glacialList2.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList2.Items[i].Tag;
                        return Convert.ToInt64(tag.orderkey.ToString());
                    }
                }
            }
            return 0L;
        }

        private long ViewRemarkKey2()
        {
            if ((this.glacialList3.Items.Count > 0) && (this.glacialList3.SelectedItems.Count > 0))
            {
                for (int i = 0; i < this.glacialList3.Items.Count; i++)
                {
                    if (this.glacialList3.Items[i].Selected)
                    {
                        _fileinfo tag = (_fileinfo) this.glacialList3.Items[i].Tag;
                        return Convert.ToInt64(tag.orderkey.ToString());
                    }
                }
            }
            return 0L;
        }

        private void viewSplit()
        {
            if (this.glacialList1.Items.Count > 0)
            {
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (this.glacialList1.Items[i].Selected && (this.glacialList1.Items[i].Tag != null))
                    {
                        if (((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4)) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 15))
                        {
                            this.toolBarButton1.Enabled = false;
                            this.toolBarButton2.Enabled = true;
                            if ((OutputLogin.UserLevel != "0000000000000000000000000000000000000000") && (OutputLogin.UserLevel.Substring(3, 1) == "0"))
                            {
                                this.toolBarButton3.Enabled = false;
                            }
                            else
                            {
                                this.toolBarButton3.Enabled = true;
                            }
                        }
                        else
                        {
                            this.toolBarButton1.Enabled = true;
                            this.toolBarButton2.Enabled = false;
                            if ((OutputLogin.UserLevel != "0000000000000000000000000000000000000000") && (OutputLogin.UserLevel.Substring(3, 1) == "0"))
                            {
                                this.toolBarButton3.Enabled = false;
                            }
                            else
                            {
                                this.toolBarButton3.Enabled = true;
                            }
                        }
                        this.toolBarButton5.Enabled = false;
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[i].Tag;
                        _fileinfo _fileinfo2 = tag;
                        this.viewOrderInfo(tag.OrderInfo);
                        if (this.treeView2.Nodes[1].Nodes.Count <= 0)
                        {
                            this.treeView2.Nodes[1].Nodes.Clear();
                            this.treeView2.Tag = tag;
                            if (((_fileinfo2.SplitInfo[0] != null) || (_fileinfo2.SplitInfo[1] != null)) || (((_fileinfo2.SplitInfo[2] != null) || (_fileinfo2.SplitInfo[3] != null)) || (_fileinfo2.SplitInfo[4] != null)))
                            {
                                this.treeView2.Nodes[1].Nodes.Add("块1");
                                this.treeView2.Nodes[1].Nodes.Add("块2");
                                this.treeView2.Nodes[1].Nodes.Add("块3");
                                this.treeView2.Nodes[1].Nodes.Add("块4");
                                this.treeView2.Nodes[1].Nodes.Add("块5");
                                this.treeView2.Nodes[1].Nodes[0].ImageIndex = 11;
                                this.treeView2.Nodes[1].Nodes[1].ImageIndex = 11;
                                this.treeView2.Nodes[1].Nodes[2].ImageIndex = 11;
                                this.treeView2.Nodes[1].Nodes[3].ImageIndex = 11;
                                this.treeView2.Nodes[1].Nodes[4].ImageIndex = 11;
                                this.treeView2.Refresh();
                                this.treeView2.ExpandAll();
                            }
                            else
                            {
                                if (this.treeView2.Nodes[1].Nodes.Count > 0)
                                {
                                    this.treeView2.Nodes[1].Nodes.Clear();
                                }
                                this.treeView2.Refresh();
                            }
                        }
                    }
                }
            }
            else
            {
                this.toolBarButton1.Enabled = false;
                this.toolBarButton2.Enabled = false;
                this.toolBarButton3.Enabled = false;
                this.toolBarButton4.Enabled = false;
                this.toolBarButton5.Enabled = false;
            }
        }

        private void ViewTotalSpeed()
        {
            double num = 0.0;
            if (this.glacialList1.Items.Count > 0)
            {
                int num2 = 0;
                for (int j = 0; j < this.glacialList1.Items.Count; j++)
                {
                    if (this.glacialList1.Items[j].SubItems[0].ImageIndex == 4)
                    {
                        num2++;
                        _fileinfo tag = (_fileinfo) this.glacialList1.Items[j].Tag;
                        num += tag.Speed;
                    }
                    else
                    {
                        num += 0.0;
                    }
                }
                string str = Convert.ToString(Math.Round(num, 2));
                if ((str.IndexOf("无穷") < 0) && (str.IndexOf("非数字") < 0))
                {
                    this.statusBarPanel3.Text = str + " K/S";
                }
            }
            try
            {
                this.pointY[0x9b] = Convert.ToInt16((double) (36.0 * (num / 256.0)));
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("计算状态栏速度时计算格式出错: " + exception.ToString());
            }
            for (int i = 0; i < 0x9b; i++)
            {
                this.pointY[i] = this.pointY[i + 1];
            }
            this.panel11_Paint(null, null);
        }

        private void ViewUserFilesInfo(string SearchInfo)
        {
            this.UserFileSize = 0L;
            this.listView6.Items.Clear();
            try
            {
                string[] strArray = SearchInfo.Remove(SearchInfo.Length - 1, 1).Split(new char[] { '|' });
                ListViewItem[] values = new ListViewItem[strArray.Length];
                for (int i = 0; i < strArray.Length; i++)
                {
                    ListViewItem item = new ListViewItem();
                    string[] strArray2 = strArray[i].Remove(strArray[i].Length - 1, 1).Split(new char[] { ',' });
                    for (int j = 0; j < strArray2.Length; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                item.Tag = strArray2[j];
                                break;

                            case 1:
                                break;

                            case 4:
                                this.UserFileSize += Convert.ToInt64(strArray2[j]);
                                item.SubItems.Add(this.sizeChange(Convert.ToInt64(strArray2[j])));
                                break;

                            case 7:
                                if (Convert.ToInt16(strArray2[j]) == 1)
                                {
                                    item.SubItems.Add("已下载");
                                }
                                else
                                {
                                    item.ForeColor = Color.Red;
                                    item.Font = new Font("宋体", 9f);
                                    item.SubItems.Add("未下载");
                                }
                                break;

                            default:
                                item.SubItems.Add(strArray2[j]);
                                break;
                        }
                    }
                    values[i] = item;
                }
                this.listView6.Items.AddRange(values);
                this.listView6.Refresh();
                this.label14.Text = "文件总数: " + strArray.Length.ToString() + "  总大小: " + this.sizeChange(this.UserFileSize);
                this.button9.Enabled = this.button11.Enabled = this.button12.Enabled = this.button13.Enabled = true;
            }
            catch
            {
                this.button9.Enabled = this.button11.Enabled = this.button12.Enabled = this.button13.Enabled = true;
            }
        }

        private void ViewUserInfo(string SearchInfo)
        {
            this.listView5.Items.Clear();
            try
            {
                string[] strArray = SearchInfo.Remove(SearchInfo.Length - 1, 1).Split(new char[] { '|' });
                PubUserInfo = new string[strArray.Length];
                PubCompanyName = new string[strArray.Length];
                ListViewItem[] values = new ListViewItem[strArray.Length];
                for (int i = 0; i < strArray.Length; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(Convert.ToString((int) (i + 1)));
                    string[] strArray2 = strArray[i].Remove(strArray[i].Length - 1, 1).Split(new char[] { ',' });
                    if (((strArray2[1].IndexOf("PubUser") >= 0) && (strArray2[4].ToString().Trim() == "")) || ((Convert.ToInt16(strArray2[13]) == 2) || (Convert.ToInt16(strArray2[13]) == 1)))
                    {
                        PubUserInfo[i] = "";
                        PubCompanyName[i] = "";
                    }
                    else
                    {
                        PubUserInfo[i] = strArray2[1];
                        PubCompanyName[i] = strArray2[4];
                    }
                    for (int j = 0; j < strArray2.Length; j++)
                    {
                        switch (j)
                        {
                            case 0:
                                item.Tag = strArray2[j];
                                break;

                            case 13:
                                if (Convert.ToInt16(strArray2[j]) == 2)
                                {
                                    item.BackColor = Color.SteelBlue;
                                }
                                else if (Convert.ToInt16(strArray2[j]) == 1)
                                {
                                    item.BackColor = Color.LightPink;
                                }
                                else if ((strArray2[1].IndexOf("PubUser") >= 0) && (strArray2[4].ToString().Trim() == ""))
                                {
                                    item.Tag = "";
                                    item.BackColor = Color.Silver;
                                }
                                else
                                {
                                    item.BackColor = Color.White;
                                }
                                break;

                            default:
                                if ((j != 3) && (j != 2))
                                {
                                    item.SubItems.Add(strArray2[j]);
                                }
                                break;
                        }
                    }
                    values[i] = item;
                }
                this.listView5.Items.AddRange(values);
                this.listView5.Refresh();
                this.button7.Visible = false;
                this.button1.Enabled = this.button2.Enabled = this.button4.Enabled = this.button5.Enabled = this.button6.Enabled = true;
                this.listView5.Cursor = Cursors.Default;
            }
            catch (Exception exception)
            {
                this.ePrintLog.WriteLog("显示用户资料信息时出错: " + exception.ToString());
                this.button7.Visible = false;
                this.button1.Enabled = this.button2.Enabled = this.button4.Enabled = this.button5.Enabled = this.button6.Enabled = true;
            }
        }

        private bool waitDownload(int MaxDownNum)
        {
            bool flag = true;
            if (this.glacialList1.Items.Count >= MaxDownNum)
            {
                int num = 0;
                for (int i = 0; i < this.glacialList1.Items.Count; i++)
                {
                    if (((this.glacialList1.Items[i].SubItems[0].ImageIndex == 0) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 4)) || (this.glacialList1.Items[i].SubItems[0].ImageIndex == 10))
                    {
                        num++;
                        Console.Write("\n\n正在下载的文件数: " + num.ToString() + "|" + i.ToString() + "|" + this.glacialList1.Items[i].SubItems[0].ImageIndex.ToString() + "\n\n");
                    }
                }
                if (num >= MaxDownNum)
                {
                    flag = false;
                }
                Console.Write("\n\n正在下载的文件数: " + num.ToString() + "|" + flag.ToString() + "\n\n");
            }
            return flag;
        }
    }
}

