namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.com.print2000.output;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    public class AllUserInfo : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckedListBox checkedListBox1;
        private int checkNum = 0;
        private Container components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private StatusBar statusBar1;
        private StatusBarPanel statusBarPanel1;
        private StatusBarPanel statusBarPanel2;
        private StatusBarPanel statusBarPanel3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;

        public AllUserInfo()
        {
            this.InitializeComponent();
        }

        private void AllUserInfo_Load(object sender, EventArgs e)
        {
            this.ViewAllUserInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count > 0)
            {
                string[] strArray = new string[this.checkedListBox1.CheckedItems.Count];
                for (int i = 0; i < this.checkedListBox1.CheckedItems.Count; i++)
                {
                    strArray[i] = this.checkedListBox1.CheckedItems[i].ToString();
                }
                SendFileToUser.AddNewUser = strArray;
                SendFileToUser.timer2.Enabled = true;
            }
            Thread.Sleep(100);
            base.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (((this.textBox1.Text.Trim() == "") && (this.textBox2.Text.Trim() == "")) && (this.textBox3.Text.Trim() == ""))
            {
                MessageBox.Show("请至少输入一个查找条件!");
            }
            else
            {
                new Thread(new ThreadStart(this.getOutputUser)).Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = "";
            new Thread(new ThreadStart(this.getOutputUser)).Start();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Checked)
            {
                this.checkNum--;
            }
            else
            {
                this.checkNum++;
            }
            if (this.checkNum > 0)
            {
                this.statusBarPanel2.Text = "已选用户: " + this.checkNum.ToString();
            }
            else
            {
                this.statusBarPanel2.Text = "";
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

        private void getOutputUser()
        {
            try
            {
                string str;
                this.button1.Enabled = this.button2.Enabled = this.button3.Enabled = false;
                string[] strSearch = new string[4];
                strSearch[0] = ePrintMain.Outputkey;
                strSearch[3] = str = "";
                strSearch[1] = strSearch[2] = str;
                if (this.textBox1.Text.Trim() != "")
                {
                    strSearch[1] = ePrintMain.dowithString(this.textBox1.Text.Trim());
                }
                if (this.textBox2.Text.Trim() != "")
                {
                    strSearch[2] = ePrintMain.dowithString(this.textBox2.Text.Trim());
                }
                if (this.textBox3.Text.Trim() != "")
                {
                    strSearch[3] = ePrintMain.dowithString(this.textBox3.Text.Trim());
                }
                ePrintOutputLogin login = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                this.ViewUserInfo(login.SearchUserInfo(strSearch));
                this.button1.Enabled = this.button2.Enabled = this.button3.Enabled = true;
            }
            catch
            {
                this.button1.Enabled = this.button2.Enabled = this.button3.Enabled = true;
            }
        }

        private void InitializeComponent()
        {
            this.checkedListBox1 = new CheckedListBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.statusBar1 = new StatusBar();
            this.statusBarPanel1 = new StatusBarPanel();
            this.statusBarPanel2 = new StatusBarPanel();
            this.statusBarPanel3 = new StatusBarPanel();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.button3 = new Button();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.button4 = new Button();
            this.statusBarPanel1.BeginInit();
            this.statusBarPanel2.BeginInit();
            this.statusBarPanel3.BeginInit();
            base.SuspendLayout();
            this.checkedListBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            this.checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            this.checkedListBox1.Location = new Point(8, 8);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(760, 0x112);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.button1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button1.BackColor = SystemColors.Control;
            this.button1.Location = new Point(0x260, 0x120);
            this.button1.Name = "button1";
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.button2.BackColor = SystemColors.Control;
            this.button2.DialogResult = DialogResult.Cancel;
            this.button2.Location = new Point(0x2b0, 0x120);
            this.button2.Name = "button2";
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.statusBar1.Location = new Point(0, 0x139);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new StatusBarPanel[] { this.statusBarPanel1, this.statusBarPanel2, this.statusBarPanel3 });
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new Size(0x30a, 0x16);
            this.statusBar1.TabIndex = 4;
            this.statusBar1.Text = "statusBar1";
            this.statusBarPanel3.AutoSize = StatusBarPanelAutoSize.Spring;
            this.statusBarPanel3.Width = 0x232;
            this.textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox1.Location = new Point(0x48, 0x120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x48, 0x15);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "";
            this.textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox2.Location = new Point(0xd8, 0x120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(0x58, 0x15);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "";
            this.textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.textBox3.Location = new Point(360, 0x120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(0x48, 0x15);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "";
            this.button3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button3.BackColor = SystemColors.Control;
            this.button3.Location = new Point(440, 0x120);
            this.button3.Name = "button3";
            this.button3.TabIndex = 8;
            this.button3.Text = "查找";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.label1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label1.Location = new Point(8, 0x128);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x40, 0x10);
            this.label1.TabIndex = 9;
            this.label1.Text = "用户帐号:";
            this.label2.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label2.Location = new Point(0x98, 0x128);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x40, 0x10);
            this.label2.TabIndex = 10;
            this.label2.Text = "公司名称:";
            this.label3.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.label3.Location = new Point(0x138, 0x128);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x30, 0x10);
            this.label3.TabIndex = 11;
            this.label3.Text = "联系人:";
            this.button4.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.button4.BackColor = SystemColors.Control;
            this.button4.Location = new Point(520, 0x120);
            this.button4.Name = "button4";
            this.button4.TabIndex = 12;
            this.button4.Text = "罗列全部";
            this.button4.Click += new EventHandler(this.button4_Click);
            base.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.CancelButton = this.button2;
            base.ClientSize = new Size(0x30a, 0x14f);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.statusBar1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.checkedListBox1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MinimizeBox = false;
            base.Name = "AllUserInfo";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "客户列表";
            base.WindowState = FormWindowState.Maximized;
            base.Load += new EventHandler(this.AllUserInfo_Load);
            this.statusBarPanel1.EndInit();
            this.statusBarPanel2.EndInit();
            this.statusBarPanel3.EndInit();
            base.ResumeLayout(false);
        }

        private void ViewAllUserInfo()
        {
            this.checkedListBox1.Items.Clear();
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.ColumnWidth = 300;
            int num = 0;
            for (int i = 0; i < ePrintMain.PubUserInfo.Length; i++)
            {
                if ((ePrintMain.PubUserInfo[i] != "") && (ePrintMain.PubCompanyName[i] != ""))
                {
                    num++;
                }
            }
            string[] items = new string[num];
            int index = 0;
            for (int j = 0; j < ePrintMain.PubUserInfo.Length; j++)
            {
                if ((ePrintMain.PubUserInfo[j] != "") && (ePrintMain.PubCompanyName[j] != ""))
                {
                    items[index] = ePrintMain.PubUserInfo[j] + "|" + ePrintMain.PubCompanyName[j];
                    index++;
                }
            }
            this.checkedListBox1.Items.AddRange(items);
            this.statusBarPanel1.Text = "用户总数: " + num.ToString();
        }

        private void ViewUserInfo(string SearchInfo)
        {
            if ((SearchInfo == "") || (SearchInfo == null))
            {
                this.checkedListBox1.Items.Clear();
                this.statusBarPanel1.Text = "用户总数: 0";
            }
            else
            {
                try
                {
                    string[] strArray = SearchInfo.Remove(SearchInfo.Length - 1, 1).Split(new char[] { '|' });
                    ePrintMain.PubUserInfo = new string[strArray.Length];
                    ePrintMain.PubCompanyName = new string[strArray.Length];
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        string[] strArray2 = strArray[i].Remove(strArray[i].Length - 1, 1).Split(new char[] { ',' });
                        if (((strArray2[1].IndexOf("PubUser") >= 0) && (strArray2[4].ToString().Trim() == "")) || ((Convert.ToInt16(strArray2[13]) == 2) || (Convert.ToInt16(strArray2[13]) == 1)))
                        {
                            ePrintMain.PubUserInfo[i] = "";
                            ePrintMain.PubCompanyName[i] = "";
                        }
                        else
                        {
                            ePrintMain.PubUserInfo[i] = strArray2[1];
                            ePrintMain.PubCompanyName[i] = strArray2[4];
                        }
                    }
                }
                catch
                {
                }
                this.ViewAllUserInfo();
            }
        }
    }
}

