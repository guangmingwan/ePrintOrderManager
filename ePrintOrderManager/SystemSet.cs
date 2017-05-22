namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.com.print2000.output;
    using Microsoft.Win32;
    using System;
    using System.ComponentModel;
    using System.Data.OleDb;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Resources;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class SystemSet : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private ComboBox comboBox1;
        private IContainer components;
        private DomainUpDown domainUpDown1;
        private DomainUpDown domainUpDown2;
        private DomainUpDown domainUpDown3;
        private DomainUpDown domainUpDown4;
        private DomainUpDown domainUpDown5;
        private DomainUpDown domainUpDown6;
        private DomainUpDown domainUpDown7;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox groupBox1;
        private GroupBox groupBox10;
        private GroupBox groupBox11;
        private GroupBox groupBox12;
        private GroupBox groupBox13;
        private GroupBox groupBox14;
        private GroupBox groupBox15;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
        private ImageList imageList1;
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
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label3;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label4;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label5;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label6;
        private Label label60;
        private Label label61;
        private Label label62;
        private Label label63;
        private Label label64;
        private Label label7;
        private Label label8;
        private Label label9;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox2;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox3;
        private PictureBox pictureBox30;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private RadioButton radioButton1;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;

        public SystemSet()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("输出文件路径不能为空！", "文件路径设置", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.textBox1.Focus();
            }
            else if (this.checkBox3.Checked && (this.checkedListBox1.CheckedItems.Count <= 0))
            {
                MessageBox.Show("至少选择一种解压文件类型!", "解压缩设置", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (!Directory.Exists(this.textBox1.Text.Trim()) && (MessageBox.Show("所选输出文件路径不存在，是否自动创建该路径?", "文件路径设置", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    try
                    {
                        Directory.CreateDirectory(this.textBox1.Text.Trim());
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                if (Directory.Exists(this.textBox1.Text.Trim()))
                {
                    int num = 0;
                    int num2 = 0;
                    if (this.radioButton3.Checked)
                    {
                        num = 0;
                    }
                    if (this.radioButton4.Checked)
                    {
                        num = 1;
                    }
                    if (this.radioButton5.Checked)
                    {
                        num = 2;
                    }
                    if (this.radioButton1.Checked)
                    {
                        num2 = 0;
                    }
                    if (this.radioButton2.Checked)
                    {
                        num2 = 1;
                    }
                    OleDbConnection connection = new OleDbConnection(ePrintMain.strCon);
                    connection.Open();
                    int num3 = new OleDbCommand(string.Concat(new object[] { "update SystemInfo set SaveFilePath = '", this.textBox1.Text.Trim(), "',SaveFileType=", num, ",isAutoDown=", num2 }), connection).ExecuteNonQuery();
                    connection.Close();
                    if (num3 > 0)
                    {
                        ePrintMain.FileSavePath = this.textBox1.Text.Trim();
                        ePrintMain.SaveFileType = num;
                        ePrintMain.isAutoDown = num2;
                        new Thread(new ThreadStart(this.editOutputSet)).Start();
                        base.Close();
                    }
                }
                try
                {
                    string str3 = null;
                    string str4 = null;
                    if (this.radioButton10.Checked)
                    {
                        str3 = "0|0";
                    }
                    else if (this.radioButton6.Checked)
                    {
                        str3 = "1|" + this.domainUpDown1.Text.ToString();
                    }
                    else if (this.radioButton7.Checked)
                    {
                        str3 = "2|" + this.domainUpDown2.Text.ToString();
                    }
                    if (this.radioButton11.Checked)
                    {
                        str4 = "0|0";
                    }
                    else if (this.radioButton9.Checked)
                    {
                        str4 = "1|" + this.domainUpDown4.Text.ToString();
                    }
                    else if (this.radioButton8.Checked)
                    {
                        str4 = "2|" + this.domainUpDown3.Text.ToString();
                    }
                    string str5 = null;
                    if (this.checkBox1.Checked)
                    {
                        str5 = "1";
                    }
                    else
                    {
                        str5 = "0";
                    }
                    string str6 = null;
                    if (this.checkBox2.Checked)
                    {
                        str6 = str6 + "1|";
                    }
                    else
                    {
                        str6 = str6 + "0|";
                    }
                    str6 = (str6 + this.domainUpDown7.Text + "|") + this.ePrintSecurity(this.textBox3.Text.Trim());
                    string str7 = null;
                    if (this.checkBox3.Checked)
                    {
                        str7 = str7 + "1|";
                        if (this.checkBox4.Checked)
                        {
                            str7 = str7 + "1|";
                        }
                        else
                        {
                            str7 = str7 + "0|";
                        }
                        for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                        {
                            if (this.checkedListBox1.GetItemChecked(i))
                            {
                                str7 = str7 + ((string) this.checkedListBox1.Items[i]) + ",";
                            }
                        }
                        if (this.checkBox6.Checked)
                        {
                            str7 = str7 + "|1";
                        }
                        else
                        {
                            str7 = str7 + "|0";
                        }
                    }
                    else
                    {
                        str7 = str7 + "0|0||";
                    }
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
                    if (key != null)
                    {
                        key.SetValue("DeletedList", str3);
                        key.SetValue("DownLoadedList", str4);
                        key.SetValue("OrderInfoSize", this.domainUpDown5.Text);
                        key.SetValue("OrderInfoItemheight", this.domainUpDown6.Text);
                        key.SetValue("ViewOrderCode", str5);
                        key.SetValue("ScreenProtectInfo", str6);
                        key.SetValue("AutoZip", str7);
                        key.SetValue("MutliSystem", this.checkBox9.Checked ? "1" : "0");
                    }
                }
                catch (Exception exception2)
                {
                    MessageBox.Show(exception2.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (!this.checkBox3.Checked)
            {
                this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = this.checkBox6.Enabled = false;
            }
            else
            {
                this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = this.checkBox6.Enabled = true;
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

        private void editOutputSet()
        {
            try
            {
                int isClose = 0;
                int enterWhich = 0;
                if (this.radioButton13.Checked)
                {
                    isClose = 1;
                }
                if (this.radioButton15.Checked)
                {
                    enterWhich = 1;
                }
                new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._OutputSet(Convert.ToInt16(ePrintMain.Outputkey), isClose, enterWhich);
            }
            catch
            {
            }
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
            catch
            {
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
            catch
            {
            }
            return str;
        }

        private void getAutoDelInfo()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
            if (key != null)
            {
                if (key.GetValue("DeletedList") != null)
                {
                    string[] strArray = key.GetValue("DeletedList").ToString().Split(new char[] { '|' });
                    if (strArray[0] == "0")
                    {
                        this.radioButton10.Checked = true;
                        this.domainUpDown1.SelectedItem = "100";
                        this.domainUpDown2.SelectedItem = "10";
                    }
                    else if (strArray[0] == "1")
                    {
                        this.radioButton6.Checked = true;
                        this.domainUpDown2.SelectedItem = "10";
                        this.domainUpDown1.SelectedItem = strArray[1];
                    }
                    else if (strArray[0] == "2")
                    {
                        this.radioButton7.Checked = true;
                        this.domainUpDown1.SelectedItem = "100";
                        this.domainUpDown2.SelectedItem = strArray[1];
                    }
                }
                else
                {
                    this.radioButton10.Checked = true;
                }
                if (key.GetValue("DownLoadedList") != null)
                {
                    string[] strArray2 = key.GetValue("DownLoadedList").ToString().Split(new char[] { '|' });
                    if (strArray2[0] == "0")
                    {
                        this.radioButton11.Checked = true;
                        this.domainUpDown4.SelectedItem = "100";
                        this.domainUpDown3.SelectedItem = "10";
                    }
                    else if (strArray2[0] == "1")
                    {
                        this.radioButton9.Checked = true;
                        this.domainUpDown3.SelectedItem = "10";
                        this.domainUpDown4.SelectedItem = strArray2[1];
                    }
                    else if (strArray2[0] == "2")
                    {
                        this.radioButton8.Checked = true;
                        this.domainUpDown4.SelectedItem = "100";
                        this.domainUpDown3.SelectedItem = strArray2[1];
                    }
                }
                else
                {
                    this.radioButton11.Checked = true;
                }
                if (key.GetValue("OrderInfoSize") != null)
                {
                    this.domainUpDown5.SelectedItem = key.GetValue("OrderInfoSize").ToString();
                }
                else
                {
                    key.SetValue("OrderInfoSize", "9");
                    this.domainUpDown5.SelectedItem = "9";
                }
                if (key.GetValue("OrderInfoItemheight") != null)
                {
                    this.domainUpDown6.SelectedItem = key.GetValue("OrderInfoItemheight").ToString();
                }
                else
                {
                    key.SetValue("OrderInfoItemheight", "17");
                    this.domainUpDown6.SelectedItem = "17";
                }
                if (key.GetValue("ViewOrderCode") != null)
                {
                    if (key.GetValue("ViewOrderCode").ToString() == "1")
                    {
                        this.checkBox1.Checked = true;
                    }
                    else
                    {
                        this.checkBox1.Checked = false;
                    }
                }
                else
                {
                    key.SetValue("ViewOrderCode", "0");
                }
                if (key.GetValue("ScreenProtectInfo") != null)
                {
                    string[] strArray3 = key.GetValue("ScreenProtectInfo").ToString().Split(new char[] { '|' });
                    if (strArray3[0] == "1")
                    {
                        this.checkBox2.Checked = true;
                    }
                    else
                    {
                        this.checkBox2.Checked = false;
                    }
                    this.domainUpDown7.SelectedItem = strArray3[1];
                    this.textBox3.Text = this.ePrintSecurity2(strArray3[2]);
                }
                else
                {
                    key.SetValue("ScreenProtectInfo", "0|30|0");
                }
                if (key.GetValue("MutliSystem") != null)
                {
                    if (key.GetValue("MutliSystem").ToString() == "0")
                    {
                        this.checkBox9.Checked = false;
                    }
                    else
                    {
                        this.checkBox9.Checked = true;
                    }
                }
                else
                {
                    key.SetValue("MutliSystem", "0");
                }
                RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"WinRAR\shell\open\command", true);
                if (key2 != null)
                {
                    if (key2.GetValue("") != null)
                    {
                        int index = key2.GetValue("").ToString().IndexOf("WinRAR.exe");
                        if (File.Exists(key2.GetValue("").ToString().Substring(1, index + 9)))
                        {
                            this.checkBox3.Enabled = this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = this.checkBox6.Enabled = true;
                            this.label60.Visible = this.linkLabel1.Visible = false;
                            if (key.GetValue("AutoZip") != null)
                            {
                                string[] strArray4 = key.GetValue("AutoZip").ToString().Split(new char[] { '|' });
                                if (strArray4[0] == "1")
                                {
                                    this.checkBox3.Checked = true;
                                    this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = true;
                                    if (strArray4[1] == "1")
                                    {
                                        this.checkBox4.Checked = true;
                                    }
                                    else
                                    {
                                        this.checkBox4.Checked = false;
                                    }
                                    for (int j = 0; j < this.checkedListBox1.Items.Count; j++)
                                    {
                                        if (strArray4[2].IndexOf((string) this.checkedListBox1.Items[j]) >= 0)
                                        {
                                            this.checkedListBox1.SetItemChecked(j, true);
                                        }
                                        else
                                        {
                                            this.checkedListBox1.SetItemChecked(j, false);
                                        }
                                    }
                                    try
                                    {
                                        if (strArray4[3] == "1")
                                        {
                                            this.checkBox6.Checked = true;
                                        }
                                        else
                                        {
                                            this.checkBox6.Checked = false;
                                        }
                                    }
                                    catch
                                    {
                                    }
                                }
                                else
                                {
                                    this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = this.checkBox6.Enabled = false;
                                }
                            }
                            else
                            {
                                key.SetValue("AutoZip", "0|0||");
                                this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = this.checkBox6.Enabled = false;
                            }
                        }
                        else
                        {
                            this.checkBox3.Enabled = this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = this.checkBox6.Enabled = false;
                            this.label60.Visible = this.linkLabel1.Visible = true;
                        }
                    }
                    else
                    {
                        this.checkBox3.Enabled = this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = this.checkBox6.Enabled = false;
                        this.label60.Visible = this.linkLabel1.Visible = true;
                    }
                }
                else
                {
                    this.checkBox3.Enabled = this.checkBox4.Enabled = this.label59.Enabled = this.checkedListBox1.Enabled = this.checkBox6.Enabled = false;
                    this.label60.Visible = this.linkLabel1.Visible = true;
                }
                for (int i = 0; i < this.checkedListBox2.Items.Count; i++)
                {
                    this.checkedListBox2.SetItemChecked(i, true);
                }
            }
        }

        private void GetOutputSetInfo()
        {
            try
            {
                string[] strArray = new string[2];
                strArray = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx")._getOutputSetInfo(Convert.ToInt16(ePrintMain.Outputkey));
                if (strArray[0] != "True")
                {
                    this.radioButton12.Checked = true;
                }
                else
                {
                    this.radioButton13.Checked = true;
                }
                if (strArray[1] != "1")
                {
                    this.radioButton14.Checked = true;
                }
                else
                {
                    this.radioButton15.Checked = true;
                }
            }
            catch
            {
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ResourceManager manager = new ResourceManager(typeof(SystemSet));
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.groupBox2 = new GroupBox();
            this.button4 = new Button();
            this.textBox2 = new TextBox();
            this.groupBox1 = new GroupBox();
            this.textBox1 = new TextBox();
            this.button3 = new Button();
            this.tabPage3 = new TabPage();
            this.groupBox6 = new GroupBox();
            this.label40 = new Label();
            this.groupBox7 = new GroupBox();
            this.label41 = new Label();
            this.radioButton2 = new RadioButton();
            this.radioButton1 = new RadioButton();
            this.tabPage2 = new TabPage();
            this.checkBox1 = new CheckBox();
            this.radioButton5 = new RadioButton();
            this.radioButton4 = new RadioButton();
            this.groupBox5 = new GroupBox();
            this.label39 = new Label();
            this.label42 = new Label();
            this.label43 = new Label();
            this.label44 = new Label();
            this.label45 = new Label();
            this.label46 = new Label();
            this.pictureBox21 = new PictureBox();
            this.pictureBox22 = new PictureBox();
            this.pictureBox23 = new PictureBox();
            this.label47 = new Label();
            this.label48 = new Label();
            this.pictureBox24 = new PictureBox();
            this.pictureBox30 = new PictureBox();
            this.groupBox4 = new GroupBox();
            this.label20 = new Label();
            this.label21 = new Label();
            this.label22 = new Label();
            this.label23 = new Label();
            this.label24 = new Label();
            this.label25 = new Label();
            this.label26 = new Label();
            this.label27 = new Label();
            this.pictureBox11 = new PictureBox();
            this.pictureBox12 = new PictureBox();
            this.pictureBox13 = new PictureBox();
            this.label28 = new Label();
            this.label29 = new Label();
            this.pictureBox14 = new PictureBox();
            this.label30 = new Label();
            this.label31 = new Label();
            this.label32 = new Label();
            this.label33 = new Label();
            this.pictureBox15 = new PictureBox();
            this.label34 = new Label();
            this.label35 = new Label();
            this.label36 = new Label();
            this.label37 = new Label();
            this.label38 = new Label();
            this.pictureBox16 = new PictureBox();
            this.pictureBox17 = new PictureBox();
            this.pictureBox18 = new PictureBox();
            this.pictureBox19 = new PictureBox();
            this.pictureBox20 = new PictureBox();
            this.groupBox3 = new GroupBox();
            this.label19 = new Label();
            this.label18 = new Label();
            this.label17 = new Label();
            this.label16 = new Label();
            this.label15 = new Label();
            this.label14 = new Label();
            this.label13 = new Label();
            this.label12 = new Label();
            this.pictureBox10 = new PictureBox();
            this.pictureBox9 = new PictureBox();
            this.pictureBox8 = new PictureBox();
            this.label11 = new Label();
            this.label10 = new Label();
            this.pictureBox7 = new PictureBox();
            this.label9 = new Label();
            this.label8 = new Label();
            this.label7 = new Label();
            this.label6 = new Label();
            this.pictureBox6 = new PictureBox();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.pictureBox5 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.pictureBox4 = new PictureBox();
            this.pictureBox3 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.radioButton3 = new RadioButton();
            this.tabPage4 = new TabPage();
            this.pictureBox26 = new PictureBox();
            this.pictureBox25 = new PictureBox();
            this.groupBox9 = new GroupBox();
            this.radioButton11 = new RadioButton();
            this.label51 = new Label();
            this.domainUpDown3 = new DomainUpDown();
            this.label52 = new Label();
            this.domainUpDown4 = new DomainUpDown();
            this.radioButton8 = new RadioButton();
            this.radioButton9 = new RadioButton();
            this.groupBox8 = new GroupBox();
            this.radioButton10 = new RadioButton();
            this.label50 = new Label();
            this.domainUpDown2 = new DomainUpDown();
            this.label49 = new Label();
            this.domainUpDown1 = new DomainUpDown();
            this.radioButton7 = new RadioButton();
            this.radioButton6 = new RadioButton();
            this.label53 = new Label();
            this.tabPage6 = new TabPage();
            this.groupBox15 = new GroupBox();
            this.checkedListBox2 = new CheckedListBox();
            this.label63 = new Label();
            this.checkBox8 = new CheckBox();
            this.checkBox7 = new CheckBox();
            this.label62 = new Label();
            this.comboBox1 = new ComboBox();
            this.radioButton17 = new RadioButton();
            this.radioButton16 = new RadioButton();
            this.label61 = new Label();
            this.checkBox5 = new CheckBox();
            this.groupBox14 = new GroupBox();
            this.checkBox6 = new CheckBox();
            this.linkLabel1 = new LinkLabel();
            this.label60 = new Label();
            this.checkedListBox1 = new CheckedListBox();
            this.label59 = new Label();
            this.checkBox4 = new CheckBox();
            this.checkBox3 = new CheckBox();
            this.tabPage5 = new TabPage();
            this.groupBox13 = new GroupBox();
            this.domainUpDown7 = new DomainUpDown();
            this.label58 = new Label();
            this.label57 = new Label();
            this.textBox3 = new TextBox();
            this.label54 = new Label();
            this.checkBox2 = new CheckBox();
            this.groupBox12 = new GroupBox();
            this.domainUpDown6 = new DomainUpDown();
            this.domainUpDown5 = new DomainUpDown();
            this.label56 = new Label();
            this.label55 = new Label();
            this.groupBox11 = new GroupBox();
            this.radioButton15 = new RadioButton();
            this.radioButton14 = new RadioButton();
            this.groupBox10 = new GroupBox();
            this.radioButton13 = new RadioButton();
            this.radioButton12 = new RadioButton();
            this.button1 = new Button();
            this.button2 = new Button();
            this.folderBrowserDialog1 = new FolderBrowserDialog();
            this.imageList1 = new ImageList(this.components);
            this.checkBox9 = new CheckBox();
            this.label64 = new Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            base.SuspendLayout();
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(560, 0x128);
            this.tabControl1.TabIndex = 0;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new Point(4, 0x15);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new Size(0x228, 0x107);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "文件路径设置";
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new Point(0x10, 0x80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(520, 0x60);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其它文件路径";
            this.button4.Enabled = false;
            this.button4.Location = new Point(0x1b0, 40);
            this.button4.Name = "button4";
            this.button4.TabIndex = 1;
            this.button4.Text = "选择";
            this.textBox2.Enabled = false;
            this.textBox2.Location = new Point(0x10, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(0x198, 0x15);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "";
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new Point(0x10, 0x10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(520, 0x60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出文件路径";
            this.textBox1.Location = new Point(0x10, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x198, 0x15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            this.button3.Location = new Point(0x1b0, 40);
            this.button3.Name = "button3";
            this.button3.TabIndex = 1;
            this.button3.Text = "选择";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Location = new Point(4, 0x15);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new Size(0x228, 0x107);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "下载方式设置";
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Location = new Point(0x10, 0x18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(520, 80);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.label40.Location = new Point(0x10, 0x20);
            this.label40.Name = "label40";
            this.label40.Size = new Size(0x1c8, 0x18);
            this.label40.TabIndex = 0;
            this.label40.Text = "有新订单时，系统会发出通知，经过确认后才进行下载操作。";
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Location = new Point(0x10, 0x90);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new Size(520, 80);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.label41.Location = new Point(0x10, 0x20);
            this.label41.Name = "label41";
            this.label41.Size = new Size(440, 0x18);
            this.label41.TabIndex = 1;
            this.label41.Text = "有新订单时，系统会自动进行下载操作，无需人工参与。";
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new Point(0x10, 0x80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "自动下载";
            this.radioButton1.Location = new Point(0x10, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "确认下载";
            this.tabPage2.Controls.Add(this.label64);
            this.tabPage2.Controls.Add(this.checkBox9);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.radioButton5);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Location = new Point(4, 0x15);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new Size(0x228, 0x10f);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "保存方式设置";
            this.checkBox1.Location = new Point(8, 0xe0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new Size(520, 0x18);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "保存文件时在“客户文件夹”前加单号(适用于方式一/方式二)";
            this.radioButton5.Location = new Point(0x180, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new Size(0x40, 0x12);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "方式三";
            this.radioButton4.Location = new Point(200, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new Size(0x40, 0x12);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "方式二";
            this.groupBox5.Controls.Add(this.label39);
            this.groupBox5.Controls.Add(this.label42);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.label46);
            this.groupBox5.Controls.Add(this.pictureBox21);
            this.groupBox5.Controls.Add(this.pictureBox22);
            this.groupBox5.Controls.Add(this.pictureBox23);
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.pictureBox24);
            this.groupBox5.Controls.Add(this.pictureBox30);
            this.groupBox5.Location = new Point(0x178, 0x18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(0xa8, 200);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.label39.Location = new Point(8, 0x48);
            this.label39.Name = "label39";
            this.label39.Size = new Size(0x20, 0x10);
            this.label39.TabIndex = 0x57;
            this.label39.Text = "文件";
            this.label42.Location = new Point(8, 0x20);
            this.label42.Name = "label42";
            this.label42.Size = new Size(0x20, 0x10);
            this.label42.TabIndex = 0x54;
            this.label42.Text = "目录";
            this.label43.BackColor = SystemColors.WindowText;
            this.label43.Location = new Point(0x98, 0x38);
            this.label43.Name = "label43";
            this.label43.Size = new Size(1, 15);
            this.label43.TabIndex = 0x53;
            this.label44.BackColor = SystemColors.WindowText;
            this.label44.Location = new Point(120, 0x38);
            this.label44.Name = "label44";
            this.label44.Size = new Size(1, 15);
            this.label44.TabIndex = 0x52;
            this.label45.BackColor = SystemColors.WindowText;
            this.label45.Location = new Point(0x58, 0x38);
            this.label45.Name = "label45";
            this.label45.Size = new Size(1, 15);
            this.label45.TabIndex = 0x51;
            this.label46.BackColor = SystemColors.WindowText;
            this.label46.Location = new Point(0x38, 0x38);
            this.label46.Name = "label46";
            this.label46.Size = new Size(1, 15);
            this.label46.TabIndex = 80;
            this.pictureBox21.Image = (Image) manager.GetObject("pictureBox21.Image");
            this.pictureBox21.Location = new Point(0x90, 0x48);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new Size(0x10, 0x10);
            this.pictureBox21.TabIndex = 0x4f;
            this.pictureBox21.TabStop = false;
            this.pictureBox22.Image = (Image) manager.GetObject("pictureBox22.Image");
            this.pictureBox22.Location = new Point(0x70, 0x48);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new Size(0x10, 0x10);
            this.pictureBox22.TabIndex = 0x4e;
            this.pictureBox22.TabStop = false;
            this.pictureBox23.Image = (Image) manager.GetObject("pictureBox23.Image");
            this.pictureBox23.Location = new Point(80, 0x48);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new Size(0x10, 0x10);
            this.pictureBox23.TabIndex = 0x4d;
            this.pictureBox23.TabStop = false;
            this.label47.BackColor = SystemColors.WindowText;
            this.label47.Location = new Point(0x68, 40);
            this.label47.Name = "label47";
            this.label47.Size = new Size(1, 15);
            this.label47.TabIndex = 0x4c;
            this.label48.BackColor = SystemColors.WindowText;
            this.label48.Location = new Point(0x38, 0x38);
            this.label48.Name = "label48";
            this.label48.Size = new Size(0x61, 1);
            this.label48.TabIndex = 0x4b;
            this.pictureBox24.Image = (Image) manager.GetObject("pictureBox24.Image");
            this.pictureBox24.Location = new Point(0x30, 0x48);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new Size(0x10, 0x10);
            this.pictureBox24.TabIndex = 0x4a;
            this.pictureBox24.TabStop = false;
            this.pictureBox30.Image = (Image) manager.GetObject("pictureBox30.Image");
            this.pictureBox30.Location = new Point(0x60, 0x18);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new Size(0x10, 0x10);
            this.pictureBox30.TabIndex = 0x3b;
            this.pictureBox30.TabStop = false;
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.pictureBox11);
            this.groupBox4.Controls.Add(this.pictureBox12);
            this.groupBox4.Controls.Add(this.pictureBox13);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.pictureBox14);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.pictureBox15);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.pictureBox16);
            this.groupBox4.Controls.Add(this.pictureBox17);
            this.groupBox4.Controls.Add(this.pictureBox18);
            this.groupBox4.Controls.Add(this.pictureBox19);
            this.groupBox4.Controls.Add(this.pictureBox20);
            this.groupBox4.Location = new Point(0xc0, 0x18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(0xa8, 200);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.label20.Location = new Point(8, 0xa8);
            this.label20.Name = "label20";
            this.label20.Size = new Size(0x20, 0x10);
            this.label20.TabIndex = 0x3a;
            this.label20.Text = "文件";
            this.label21.ForeColor = SystemColors.Highlight;
            this.label21.Location = new Point(8, 120);
            this.label21.Name = "label21";
            this.label21.Size = new Size(0x20, 0x10);
            this.label21.TabIndex = 0x39;
            this.label21.Text = "日期";
            this.label22.ForeColor = Color.DarkRed;
            this.label22.Location = new Point(8, 0x48);
            this.label22.Name = "label22";
            this.label22.Size = new Size(0x20, 0x10);
            this.label22.TabIndex = 0x38;
            this.label22.Text = "客户";
            this.label23.Location = new Point(8, 0x20);
            this.label23.Name = "label23";
            this.label23.Size = new Size(0x20, 0x10);
            this.label23.TabIndex = 0x37;
            this.label23.Text = "目录";
            this.label24.BackColor = SystemColors.WindowText;
            this.label24.Location = new Point(0x98, 0x98);
            this.label24.Name = "label24";
            this.label24.Size = new Size(1, 15);
            this.label24.TabIndex = 0x36;
            this.label25.BackColor = SystemColors.WindowText;
            this.label25.Location = new Point(120, 0x98);
            this.label25.Name = "label25";
            this.label25.Size = new Size(1, 15);
            this.label25.TabIndex = 0x35;
            this.label26.BackColor = SystemColors.WindowText;
            this.label26.Location = new Point(0x58, 0x98);
            this.label26.Name = "label26";
            this.label26.Size = new Size(1, 15);
            this.label26.TabIndex = 0x34;
            this.label27.BackColor = SystemColors.WindowText;
            this.label27.Location = new Point(0x38, 0x98);
            this.label27.Name = "label27";
            this.label27.Size = new Size(1, 15);
            this.label27.TabIndex = 0x33;
            this.pictureBox11.Image = (Image) manager.GetObject("pictureBox11.Image");
            this.pictureBox11.Location = new Point(0x90, 0xa8);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new Size(0x10, 0x10);
            this.pictureBox11.TabIndex = 50;
            this.pictureBox11.TabStop = false;
            this.pictureBox12.Image = (Image) manager.GetObject("pictureBox12.Image");
            this.pictureBox12.Location = new Point(0x70, 0xa8);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new Size(0x10, 0x10);
            this.pictureBox12.TabIndex = 0x31;
            this.pictureBox12.TabStop = false;
            this.pictureBox13.Image = (Image) manager.GetObject("pictureBox13.Image");
            this.pictureBox13.Location = new Point(80, 0xa8);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new Size(0x10, 0x10);
            this.pictureBox13.TabIndex = 0x30;
            this.pictureBox13.TabStop = false;
            this.label28.BackColor = SystemColors.WindowText;
            this.label28.Location = new Point(0x68, 0x88);
            this.label28.Name = "label28";
            this.label28.Size = new Size(1, 15);
            this.label28.TabIndex = 0x2f;
            this.label29.BackColor = SystemColors.WindowText;
            this.label29.Location = new Point(0x38, 0x98);
            this.label29.Name = "label29";
            this.label29.Size = new Size(0x61, 1);
            this.label29.TabIndex = 0x2e;
            this.pictureBox14.Image = (Image) manager.GetObject("pictureBox14.Image");
            this.pictureBox14.Location = new Point(0x30, 0xa8);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new Size(0x10, 0x10);
            this.pictureBox14.TabIndex = 0x2d;
            this.pictureBox14.TabStop = false;
            this.label30.BackColor = SystemColors.WindowText;
            this.label30.Location = new Point(0x48, 0x58);
            this.label30.Name = "label30";
            this.label30.Size = new Size(1, 15);
            this.label30.TabIndex = 0x2c;
            this.label31.BackColor = SystemColors.WindowText;
            this.label31.Location = new Point(0x98, 0x68);
            this.label31.Name = "label31";
            this.label31.Size = new Size(1, 15);
            this.label31.TabIndex = 0x2b;
            this.label32.BackColor = SystemColors.WindowText;
            this.label32.Location = new Point(0x68, 0x68);
            this.label32.Name = "label32";
            this.label32.Size = new Size(1, 15);
            this.label32.TabIndex = 0x2a;
            this.label33.BackColor = SystemColors.WindowText;
            this.label33.Location = new Point(0x38, 0x68);
            this.label33.Name = "label33";
            this.label33.Size = new Size(1, 15);
            this.label33.TabIndex = 0x29;
            this.pictureBox15.Image = (Image) manager.GetObject("pictureBox15.Image");
            this.pictureBox15.Location = new Point(0x90, 120);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new Size(0x10, 0x10);
            this.pictureBox15.TabIndex = 40;
            this.pictureBox15.TabStop = false;
            this.label34.BackColor = SystemColors.WindowText;
            this.label34.Location = new Point(0x38, 0x68);
            this.label34.Name = "label34";
            this.label34.Size = new Size(0x61, 1);
            this.label34.TabIndex = 0x27;
            this.label35.BackColor = SystemColors.WindowText;
            this.label35.Location = new Point(0x88, 0x38);
            this.label35.Name = "label35";
            this.label35.Size = new Size(1, 15);
            this.label35.TabIndex = 0x26;
            this.label36.BackColor = SystemColors.WindowText;
            this.label36.Location = new Point(0x48, 0x38);
            this.label36.Name = "label36";
            this.label36.Size = new Size(1, 15);
            this.label36.TabIndex = 0x25;
            this.label37.BackColor = SystemColors.WindowText;
            this.label37.Location = new Point(0x68, 40);
            this.label37.Name = "label37";
            this.label37.Size = new Size(1, 15);
            this.label37.TabIndex = 0x24;
            this.label38.BackColor = SystemColors.WindowText;
            this.label38.Location = new Point(0x48, 0x38);
            this.label38.Name = "label38";
            this.label38.Size = new Size(0x40, 1);
            this.label38.TabIndex = 0x23;
            this.pictureBox16.Image = (Image) manager.GetObject("pictureBox16.Image");
            this.pictureBox16.Location = new Point(0x30, 120);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new Size(0x10, 0x10);
            this.pictureBox16.TabIndex = 0x22;
            this.pictureBox16.TabStop = false;
            this.pictureBox17.Image = (Image) manager.GetObject("pictureBox17.Image");
            this.pictureBox17.Location = new Point(0x60, 120);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new Size(0x10, 0x10);
            this.pictureBox17.TabIndex = 0x21;
            this.pictureBox17.TabStop = false;
            this.pictureBox18.Image = (Image) manager.GetObject("pictureBox18.Image");
            this.pictureBox18.Location = new Point(0x40, 0x48);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new Size(0x10, 0x10);
            this.pictureBox18.TabIndex = 0x20;
            this.pictureBox18.TabStop = false;
            this.pictureBox19.Image = (Image) manager.GetObject("pictureBox19.Image");
            this.pictureBox19.Location = new Point(0x80, 0x48);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new Size(0x10, 0x10);
            this.pictureBox19.TabIndex = 0x1f;
            this.pictureBox19.TabStop = false;
            this.pictureBox20.Image = (Image) manager.GetObject("pictureBox20.Image");
            this.pictureBox20.Location = new Point(0x60, 0x18);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new Size(0x10, 0x10);
            this.pictureBox20.TabIndex = 30;
            this.pictureBox20.TabStop = false;
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.pictureBox10);
            this.groupBox3.Controls.Add(this.pictureBox9);
            this.groupBox3.Controls.Add(this.pictureBox8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new Point(8, 0x18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0xa8, 200);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.label19.Location = new Point(8, 0xa8);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x20, 0x10);
            this.label19.TabIndex = 0x1d;
            this.label19.Text = "文件";
            this.label18.ForeColor = Color.DarkRed;
            this.label18.Location = new Point(8, 120);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x20, 0x10);
            this.label18.TabIndex = 0x1c;
            this.label18.Text = "客户";
            this.label17.ForeColor = SystemColors.Highlight;
            this.label17.Location = new Point(8, 0x48);
            this.label17.Name = "label17";
            this.label17.Size = new Size(0x20, 0x10);
            this.label17.TabIndex = 0x1b;
            this.label17.Text = "日期";
            this.label16.Location = new Point(8, 0x20);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x20, 0x10);
            this.label16.TabIndex = 0x1a;
            this.label16.Text = "目录";
            this.label15.BackColor = SystemColors.WindowText;
            this.label15.Location = new Point(0x98, 0x98);
            this.label15.Name = "label15";
            this.label15.Size = new Size(1, 15);
            this.label15.TabIndex = 0x19;
            this.label14.BackColor = SystemColors.WindowText;
            this.label14.Location = new Point(120, 0x98);
            this.label14.Name = "label14";
            this.label14.Size = new Size(1, 15);
            this.label14.TabIndex = 0x18;
            this.label13.BackColor = SystemColors.WindowText;
            this.label13.Location = new Point(0x58, 0x98);
            this.label13.Name = "label13";
            this.label13.Size = new Size(1, 15);
            this.label13.TabIndex = 0x17;
            this.label12.BackColor = SystemColors.WindowText;
            this.label12.Location = new Point(0x38, 0x98);
            this.label12.Name = "label12";
            this.label12.Size = new Size(1, 15);
            this.label12.TabIndex = 0x16;
            this.pictureBox10.Image = (Image) manager.GetObject("pictureBox10.Image");
            this.pictureBox10.Location = new Point(0x90, 0xa8);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new Size(0x10, 0x10);
            this.pictureBox10.TabIndex = 0x15;
            this.pictureBox10.TabStop = false;
            this.pictureBox9.Image = (Image) manager.GetObject("pictureBox9.Image");
            this.pictureBox9.Location = new Point(0x70, 0xa8);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new Size(0x10, 0x10);
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            this.pictureBox8.Image = (Image) manager.GetObject("pictureBox8.Image");
            this.pictureBox8.Location = new Point(80, 0xa8);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new Size(0x10, 0x10);
            this.pictureBox8.TabIndex = 0x13;
            this.pictureBox8.TabStop = false;
            this.label11.BackColor = SystemColors.WindowText;
            this.label11.Location = new Point(0x68, 0x88);
            this.label11.Name = "label11";
            this.label11.Size = new Size(1, 15);
            this.label11.TabIndex = 0x12;
            this.label10.BackColor = SystemColors.WindowText;
            this.label10.Location = new Point(0x38, 0x98);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x61, 1);
            this.label10.TabIndex = 0x11;
            this.pictureBox7.Image = (Image) manager.GetObject("pictureBox7.Image");
            this.pictureBox7.Location = new Point(0x30, 0xa8);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new Size(0x10, 0x10);
            this.pictureBox7.TabIndex = 0x10;
            this.pictureBox7.TabStop = false;
            this.label9.BackColor = SystemColors.WindowText;
            this.label9.Location = new Point(0x48, 0x58);
            this.label9.Name = "label9";
            this.label9.Size = new Size(1, 15);
            this.label9.TabIndex = 15;
            this.label8.BackColor = SystemColors.WindowText;
            this.label8.Location = new Point(0x98, 0x68);
            this.label8.Name = "label8";
            this.label8.Size = new Size(1, 15);
            this.label8.TabIndex = 14;
            this.label7.BackColor = SystemColors.WindowText;
            this.label7.Location = new Point(0x68, 0x68);
            this.label7.Name = "label7";
            this.label7.Size = new Size(1, 15);
            this.label7.TabIndex = 13;
            this.label6.BackColor = SystemColors.WindowText;
            this.label6.Location = new Point(0x38, 0x68);
            this.label6.Name = "label6";
            this.label6.Size = new Size(1, 15);
            this.label6.TabIndex = 12;
            this.pictureBox6.Image = (Image) manager.GetObject("pictureBox6.Image");
            this.pictureBox6.Location = new Point(0x90, 120);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(0x10, 0x10);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.label5.BackColor = SystemColors.WindowText;
            this.label5.Location = new Point(0x38, 0x68);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x61, 1);
            this.label5.TabIndex = 10;
            this.label4.BackColor = SystemColors.WindowText;
            this.label4.Location = new Point(0x88, 0x38);
            this.label4.Name = "label4";
            this.label4.Size = new Size(1, 15);
            this.label4.TabIndex = 9;
            this.label3.BackColor = SystemColors.WindowText;
            this.label3.Location = new Point(0x48, 0x38);
            this.label3.Name = "label3";
            this.label3.Size = new Size(1, 15);
            this.label3.TabIndex = 8;
            this.label2.BackColor = SystemColors.WindowText;
            this.label2.Location = new Point(0x68, 40);
            this.label2.Name = "label2";
            this.label2.Size = new Size(1, 15);
            this.label2.TabIndex = 7;
            this.label1.BackColor = SystemColors.WindowText;
            this.label1.Location = new Point(0x48, 0x38);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x40, 1);
            this.label1.TabIndex = 6;
            this.pictureBox5.Image = (Image) manager.GetObject("pictureBox5.Image");
            this.pictureBox5.Location = new Point(0x30, 120);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(0x10, 0x10);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox2.Image = (Image) manager.GetObject("pictureBox2.Image");
            this.pictureBox2.Location = new Point(0x60, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(0x10, 0x10);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox4.Image = (Image) manager.GetObject("pictureBox4.Image");
            this.pictureBox4.Location = new Point(0x40, 0x48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(0x10, 0x10);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox3.Image = (Image) manager.GetObject("pictureBox3.Image");
            this.pictureBox3.Location = new Point(0x80, 0x48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(0x10, 0x10);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox1.Image = (Image) manager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(0x60, 0x18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x10, 0x10);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new Point(0x10, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new Size(0x40, 0x12);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "方式一";
            this.tabPage4.Controls.Add(this.pictureBox26);
            this.tabPage4.Controls.Add(this.pictureBox25);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.Location = new Point(4, 0x15);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new Size(0x228, 0x10f);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "定期删除设置";
            this.pictureBox26.Image = (Image) manager.GetObject("pictureBox26.Image");
            this.pictureBox26.Location = new Point(30, 0x80);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new Size(0x10, 0x10);
            this.pictureBox26.TabIndex = 5;
            this.pictureBox26.TabStop = false;
            this.pictureBox25.Image = (Image) manager.GetObject("pictureBox25.Image");
            this.pictureBox25.Location = new Point(0x20, 0x10);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new Size(0x10, 0x10);
            this.pictureBox25.TabIndex = 2;
            this.pictureBox25.TabStop = false;
            this.groupBox9.Controls.Add(this.radioButton11);
            this.groupBox9.Controls.Add(this.label51);
            this.groupBox9.Controls.Add(this.domainUpDown3);
            this.groupBox9.Controls.Add(this.label52);
            this.groupBox9.Controls.Add(this.domainUpDown4);
            this.groupBox9.Controls.Add(this.radioButton8);
            this.groupBox9.Controls.Add(this.radioButton9);
            this.groupBox9.Location = new Point(0x10, 0x10);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new Size(520, 0x60);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "　　[已下载订单]列表";
            this.radioButton11.Checked = true;
            this.radioButton11.Location = new Point(40, 0x10);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new Size(0x48, 0x18);
            this.radioButton11.TabIndex = 12;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "手动删除";
            this.label51.Enabled = false;
            this.label51.Location = new Point(160, 0x44);
            this.label51.Name = "label51";
            this.label51.Size = new Size(0x88, 0x10);
            this.label51.TabIndex = 11;
            this.label51.Text = "天的文件记录,其它删除";
            this.domainUpDown3.Items.Add("30");
            this.domainUpDown3.Items.Add("20");
            this.domainUpDown3.Items.Add("15");
            this.domainUpDown3.Items.Add("10");
            this.domainUpDown3.Items.Add("5");
            this.domainUpDown3.Items.Add("3");
            this.domainUpDown3.Items.Add("2");
            this.domainUpDown3.Items.Add("1");
            this.domainUpDown3.Location = new Point(0x70, 0x40);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.ReadOnly = true;
            this.domainUpDown3.Size = new Size(0x30, 0x15);
            this.domainUpDown3.TabIndex = 10;
            this.label52.Location = new Point(160, 0x2c);
            this.label52.Name = "label52";
            this.label52.Size = new Size(0x80, 0x10);
            this.label52.TabIndex = 9;
            this.label52.Text = "个文件记录,其它删除";
            this.domainUpDown4.Items.Add("500");
            this.domainUpDown4.Items.Add("400");
            this.domainUpDown4.Items.Add("300");
            this.domainUpDown4.Items.Add("200");
            this.domainUpDown4.Items.Add("100");
            this.domainUpDown4.Items.Add("50");
            this.domainUpDown4.Items.Add("40");
            this.domainUpDown4.Items.Add("30");
            this.domainUpDown4.Items.Add("20");
            this.domainUpDown4.Items.Add("10");
            this.domainUpDown4.Location = new Point(0x70, 40);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.ReadOnly = true;
            this.domainUpDown4.Size = new Size(0x30, 0x15);
            this.domainUpDown4.TabIndex = 8;
            this.radioButton8.Enabled = false;
            this.radioButton8.Location = new Point(40, 0x40);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new Size(0x48, 0x18);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.Text = "保留最近";
            this.radioButton9.Location = new Point(40, 40);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new Size(0x48, 0x18);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.Text = "保留最近";
            this.groupBox8.Controls.Add(this.radioButton10);
            this.groupBox8.Controls.Add(this.label50);
            this.groupBox8.Controls.Add(this.domainUpDown2);
            this.groupBox8.Controls.Add(this.label49);
            this.groupBox8.Controls.Add(this.domainUpDown1);
            this.groupBox8.Controls.Add(this.radioButton7);
            this.groupBox8.Controls.Add(this.radioButton6);
            this.groupBox8.Controls.Add(this.label53);
            this.groupBox8.Location = new Point(0x10, 0x80);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new Size(520, 0x60);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "　　[已删除订单]列表";
            this.groupBox8.Enter += new EventHandler(this.groupBox8_Enter);
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new Point(40, 0x10);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new Size(0x48, 0x18);
            this.radioButton10.TabIndex = 6;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "手动删除";
            this.label50.Enabled = false;
            this.label50.Location = new Point(160, 0x44);
            this.label50.Name = "label50";
            this.label50.Size = new Size(0x88, 0x10);
            this.label50.TabIndex = 5;
            this.label50.Text = "天的文件记录,其它删除";
            this.domainUpDown2.Items.Add("30");
            this.domainUpDown2.Items.Add("20");
            this.domainUpDown2.Items.Add("15");
            this.domainUpDown2.Items.Add("10");
            this.domainUpDown2.Items.Add("5");
            this.domainUpDown2.Items.Add("3");
            this.domainUpDown2.Items.Add("2");
            this.domainUpDown2.Items.Add("1");
            this.domainUpDown2.Location = new Point(0x70, 0x40);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.ReadOnly = true;
            this.domainUpDown2.Size = new Size(0x30, 0x15);
            this.domainUpDown2.TabIndex = 4;
            this.label49.Location = new Point(160, 0x2c);
            this.label49.Name = "label49";
            this.label49.Size = new Size(0x80, 0x10);
            this.label49.TabIndex = 3;
            this.label49.Text = "个文件记录,其它删除";
            this.domainUpDown1.Items.Add("500");
            this.domainUpDown1.Items.Add("400");
            this.domainUpDown1.Items.Add("300");
            this.domainUpDown1.Items.Add("200");
            this.domainUpDown1.Items.Add("100");
            this.domainUpDown1.Items.Add("50");
            this.domainUpDown1.Items.Add("40");
            this.domainUpDown1.Items.Add("30");
            this.domainUpDown1.Items.Add("20");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Location = new Point(0x70, 40);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new Size(0x30, 0x15);
            this.domainUpDown1.TabIndex = 2;
            this.radioButton7.Enabled = false;
            this.radioButton7.Location = new Point(40, 0x40);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new Size(0x48, 0x18);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "保留最近";
            this.radioButton6.Location = new Point(40, 40);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new Size(0x48, 0x18);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "保留最近";
            this.label53.ForeColor = Color.Blue;
            this.label53.Location = new Point(0x130, 0x18);
            this.label53.Name = "label53";
            this.label53.Size = new Size(200, 40);
            this.label53.TabIndex = 13;
            this.label53.Text = "注:当删除此列表文件时,服务器上相对应的文件和数据也会一并删除!";
            this.tabPage6.Controls.Add(this.groupBox15);
            this.tabPage6.Controls.Add(this.groupBox14);
            this.tabPage6.Location = new Point(4, 0x15);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new Size(0x228, 0x107);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "解压缩设置";
            this.groupBox15.Controls.Add(this.checkedListBox2);
            this.groupBox15.Controls.Add(this.label63);
            this.groupBox15.Controls.Add(this.checkBox8);
            this.groupBox15.Controls.Add(this.checkBox7);
            this.groupBox15.Controls.Add(this.label62);
            this.groupBox15.Controls.Add(this.comboBox1);
            this.groupBox15.Controls.Add(this.radioButton17);
            this.groupBox15.Controls.Add(this.radioButton16);
            this.groupBox15.Controls.Add(this.label61);
            this.groupBox15.Controls.Add(this.checkBox5);
            this.groupBox15.Enabled = false;
            this.groupBox15.Location = new Point(0x10, 120);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new Size(520, 0x80);
            this.groupBox15.TabIndex = 1;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "自动压缩(用于发送文件)";
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.ColumnWidth = 0x2d;
            this.checkedListBox2.Items.AddRange(new object[] { "rar", "zip", "cdr", "cab", "iso", "tar", "bz2", "gzip", "uue", "jar", "ace", "lzh", "arj" });
            this.checkedListBox2.Location = new Point(0x58, 0x58);
            this.checkedListBox2.MultiColumn = true;
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new Size(0x1a8, 0x24);
            this.checkedListBox2.TabIndex = 9;
            this.label63.Location = new Point(0x18, 0x60);
            this.label63.Name = "label63";
            this.label63.Size = new Size(0x48, 0x10);
            this.label63.TabIndex = 8;
            this.label63.Text = "排除文件：";
            this.checkBox8.Location = new Point(0xa8, 0x40);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new Size(80, 0x18);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "文件压缩";
            this.checkBox7.Location = new Point(0x58, 0x40);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new Size(80, 0x18);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "目录压缩";
            this.label62.Location = new Point(0x18, 0x48);
            this.label62.Name = "label62";
            this.label62.Size = new Size(0x48, 0x10);
            this.label62.TabIndex = 5;
            this.label62.Text = "压缩类型：";
            this.comboBox1.Items.AddRange(new object[] { "最快", "较快", "标准", "较好", "最好" });
            this.comboBox1.Location = new Point(0x80, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(0x38, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "标准";
            this.radioButton17.Location = new Point(0xc0, 40);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new Size(0x30, 0x18);
            this.radioButton17.TabIndex = 3;
            this.radioButton17.Text = "Rar";
            this.radioButton16.Location = new Point(0x58, 40);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new Size(0x38, 0x18);
            this.radioButton16.TabIndex = 2;
            this.radioButton16.Text = "Zip";
            this.label61.Location = new Point(0x18, 0x30);
            this.label61.Name = "label61";
            this.label61.Size = new Size(0x48, 0x17);
            this.label61.TabIndex = 1;
            this.label61.Text = "压缩格式：";
            this.checkBox5.Location = new Point(0x18, 0x10);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new Size(0x40, 0x18);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "启用";
            this.groupBox14.Controls.Add(this.checkBox6);
            this.groupBox14.Controls.Add(this.linkLabel1);
            this.groupBox14.Controls.Add(this.label60);
            this.groupBox14.Controls.Add(this.checkedListBox1);
            this.groupBox14.Controls.Add(this.label59);
            this.groupBox14.Controls.Add(this.checkBox4);
            this.groupBox14.Controls.Add(this.checkBox3);
            this.groupBox14.Location = new Point(0x10, 8);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new Size(520, 0x60);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "自动解压(用于下载文件)";
            this.checkBox6.Location = new Point(0xd0, 0x18);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new Size(80, 0x18);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "显示进度";
            this.linkLabel1.Location = new Point(0x180, 0x20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new Size(0x48, 0x10);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "下载WinRar";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.label60.ForeColor = Color.Red;
            this.label60.Location = new Point(0x128, 0x10);
            this.label60.Name = "label60";
            this.label60.Size = new Size(0xd0, 0x20);
            this.label60.TabIndex = 4;
            this.label60.Text = "您尚未安装WinRar,如要开通此功能需先安装WinRar!";
            this.label60.Visible = false;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 0x2d;
            this.checkedListBox1.Items.AddRange(new object[] { "rar", "zip", "cab", "iso", "tar", "bz2", "gzip", "uue", "jar", "ace", "lzh", "arj" });
            this.checkedListBox1.Location = new Point(0x70, 0x30);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(400, 0x24);
            this.checkedListBox1.TabIndex = 3;
            this.label59.Location = new Point(0x18, 0x38);
            this.label59.Name = "label59";
            this.label59.TabIndex = 2;
            this.label59.Text = "解压文件类型：";
            this.checkBox4.Location = new Point(80, 0x18);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new Size(0x80, 0x18);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "覆盖已存在的文件";
            this.checkBox3.Location = new Point(0x18, 0x18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new Size(0x30, 0x18);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "启用";
            this.checkBox3.CheckStateChanged += new EventHandler(this.checkBox3_CheckStateChanged);
            this.tabPage5.Controls.Add(this.groupBox13);
            this.tabPage5.Controls.Add(this.groupBox12);
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Location = new Point(4, 0x15);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new Size(0x228, 0x107);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "其它设置";
            this.groupBox13.Controls.Add(this.domainUpDown7);
            this.groupBox13.Controls.Add(this.label58);
            this.groupBox13.Controls.Add(this.label57);
            this.groupBox13.Controls.Add(this.textBox3);
            this.groupBox13.Controls.Add(this.label54);
            this.groupBox13.Controls.Add(this.checkBox2);
            this.groupBox13.Enabled = false;
            this.groupBox13.Location = new Point(0x10, 0x68);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new Size(520, 0x70);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "程序屏保";
            this.domainUpDown7.Items.Add("120");
            this.domainUpDown7.Items.Add("90");
            this.domainUpDown7.Items.Add("60");
            this.domainUpDown7.Items.Add("50");
            this.domainUpDown7.Items.Add("40");
            this.domainUpDown7.Items.Add("30");
            this.domainUpDown7.Items.Add("20");
            this.domainUpDown7.Items.Add("10");
            this.domainUpDown7.Location = new Point(80, 0x30);
            this.domainUpDown7.Name = "domainUpDown7";
            this.domainUpDown7.ReadOnly = true;
            this.domainUpDown7.SelectedIndex = 1;
            this.domainUpDown7.Size = new Size(0x30, 0x15);
            this.domainUpDown7.TabIndex = 6;
            this.domainUpDown7.Text = "90";
            this.label58.Location = new Point(0x80, 0x38);
            this.label58.Name = "label58";
            this.label58.Size = new Size(0x18, 0x10);
            this.label58.TabIndex = 5;
            this.label58.Text = "分";
            this.label57.Location = new Point(0x10, 0x38);
            this.label57.Name = "label57";
            this.label57.Size = new Size(0x48, 0x10);
            this.label57.TabIndex = 3;
            this.label57.Text = "空闲时间：";
            this.textBox3.Location = new Point(80, 0x48);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new Size(0xd8, 0x15);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "";
            this.label54.Location = new Point(0x10, 80);
            this.label54.Name = "label54";
            this.label54.Size = new Size(0x48, 0x10);
            this.label54.TabIndex = 1;
            this.label54.Text = "解锁密码：";
            this.checkBox2.Location = new Point(0x10, 0x18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new Size(0x40, 0x18);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "启用";
            this.groupBox12.Controls.Add(this.domainUpDown6);
            this.groupBox12.Controls.Add(this.domainUpDown5);
            this.groupBox12.Controls.Add(this.label56);
            this.groupBox12.Controls.Add(this.label55);
            this.groupBox12.Location = new Point(0x170, 0x10);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new Size(170, 80);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "订单信息相关设置";
            this.domainUpDown6.Items.Add("25");
            this.domainUpDown6.Items.Add("24");
            this.domainUpDown6.Items.Add("23");
            this.domainUpDown6.Items.Add("22");
            this.domainUpDown6.Items.Add("21");
            this.domainUpDown6.Items.Add("20");
            this.domainUpDown6.Items.Add("19");
            this.domainUpDown6.Items.Add("18");
            this.domainUpDown6.Items.Add("17");
            this.domainUpDown6.Items.Add("16");
            this.domainUpDown6.Items.Add("15");
            this.domainUpDown6.Items.Add("14");
            this.domainUpDown6.Items.Add("13");
            this.domainUpDown6.Items.Add("12");
            this.domainUpDown6.Items.Add("11");
            this.domainUpDown6.Location = new Point(0x60, 0x30);
            this.domainUpDown6.Name = "domainUpDown6";
            this.domainUpDown6.ReadOnly = true;
            this.domainUpDown6.Size = new Size(0x30, 0x15);
            this.domainUpDown6.TabIndex = 3;
            this.domainUpDown5.Items.Add("20");
            this.domainUpDown5.Items.Add("19");
            this.domainUpDown5.Items.Add("18");
            this.domainUpDown5.Items.Add("17");
            this.domainUpDown5.Items.Add("16");
            this.domainUpDown5.Items.Add("15");
            this.domainUpDown5.Items.Add("14");
            this.domainUpDown5.Items.Add("13");
            this.domainUpDown5.Items.Add("12");
            this.domainUpDown5.Items.Add("11");
            this.domainUpDown5.Items.Add("10");
            this.domainUpDown5.Items.Add("9");
            this.domainUpDown5.Items.Add("8");
            this.domainUpDown5.Items.Add("7");
            this.domainUpDown5.Items.Add("6");
            this.domainUpDown5.Items.Add("5");
            this.domainUpDown5.Location = new Point(0x60, 0x18);
            this.domainUpDown5.Name = "domainUpDown5";
            this.domainUpDown5.ReadOnly = true;
            this.domainUpDown5.Size = new Size(0x30, 0x15);
            this.domainUpDown5.TabIndex = 2;
            this.label56.Location = new Point(0x38, 0x30);
            this.label56.Name = "label56";
            this.label56.Size = new Size(40, 0x17);
            this.label56.TabIndex = 1;
            this.label56.Text = "行高:";
            this.label55.Location = new Point(0x20, 0x18);
            this.label55.Name = "label55";
            this.label55.TabIndex = 0;
            this.label55.Text = "字体大小:";
            this.groupBox11.Controls.Add(this.radioButton15);
            this.groupBox11.Controls.Add(this.radioButton14);
            this.groupBox11.Location = new Point(0xc0, 0x10);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new Size(170, 80);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "登录初始页设置";
            this.radioButton15.Location = new Point(0x38, 0x30);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new Size(0x48, 0x18);
            this.radioButton15.TabIndex = 1;
            this.radioButton15.Text = "公告页面";
            this.radioButton14.Checked = true;
            this.radioButton14.Location = new Point(0x38, 0x18);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new Size(0x48, 0x18);
            this.radioButton14.TabIndex = 0;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "下单页面";
            this.groupBox10.Controls.Add(this.radioButton13);
            this.groupBox10.Controls.Add(this.radioButton12);
            this.groupBox10.Location = new Point(0x10, 0x10);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new Size(170, 80);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "注册新用户设置";
            this.radioButton13.Location = new Point(0x40, 0x30);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new Size(0x30, 0x18);
            this.radioButton13.TabIndex = 1;
            this.radioButton13.Text = "关闭";
            this.radioButton12.Checked = true;
            this.radioButton12.Location = new Point(0x40, 0x18);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new Size(0x38, 0x18);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "开通";
            this.button1.Location = new Point(0x198, 0x138);
            this.button1.Name = "button1";
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.DialogResult = DialogResult.Cancel;
            this.button2.Location = new Point(0x1e8, 0x138);
            this.button2.Name = "button2";
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.imageList1.ImageSize = new Size(0x10, 0x10);
            this.imageList1.ImageStream = (ImageListStreamer) manager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.checkBox9.Location = new Point(8, 0xf8);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.TabIndex = 7;
            this.checkBox9.Text = "多种订单类型";
            this.label64.ForeColor = Color.Blue;
            this.label64.Location = new Point(0x68, 0x100);
            this.label64.Name = "label64";
            this.label64.Size = new Size(440, 0x10);
            this.label64.TabIndex = 8;
            this.label64.Text = "(注：此项选中后，不同类型的订单将放在不同的目录。如“输出”、“喷画”)";
            this.AutoScaleBaseSize = new Size(6, 14);
            base.CancelButton = this.button2;
            base.ClientSize = new Size(0x240, 0x15f);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.tabControl1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SystemSet";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "设置";
            base.Load += new EventHandler(this.SystemSet_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://www.print2000.cn/down/wrar34b6sc.exe");
            }
            catch
            {
            }
        }

        private void SystemSet_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(ePrintMain.strCon);
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
                this.textBox1.Text = reader["SaveFilePath"].ToString();
                if (reader["SaveFileType"].ToString() == "0")
                {
                    this.radioButton3.Checked = true;
                }
                if (reader["SaveFileType"].ToString() == "1")
                {
                    this.radioButton4.Checked = true;
                }
                if (reader["SaveFileType"].ToString() == "2")
                {
                    this.radioButton5.Checked = true;
                }
                if (reader["isAutoDown"].ToString() == "0")
                {
                    this.radioButton1.Checked = true;
                }
                if (reader["isAutoDown"].ToString() == "1")
                {
                    this.radioButton2.Checked = true;
                }
                reader.Close();
                connection.Close();
            }
            else
            {
                reader.Close();
                string str2 = "insert into SystemInfo (SaveFilePath) values ('')";
                new OleDbCommand { Connection = connection, CommandText = str2 }.ExecuteNonQuery();
                connection.Close();
            }
            this.getAutoDelInfo();
            new Thread(new ThreadStart(this.GetOutputSetInfo)).Start();
        }
    }
}

