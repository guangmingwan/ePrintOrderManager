namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.com.print2000.output;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Resources;
    using System.Threading;
    using System.Windows.Forms;

    public class AddUser : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckedListBox checkedListBox1;
        private Container components = null;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private TextBox textBox10;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;

        public AddUser()
        {
            this.InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            this.checkedListBox1.SetItemChecked(0, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CheckInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CheckInfo2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if ((e.Index == 0) && (e.CurrentValue == CheckState.Checked))
            {
                this.checkedListBox1.SetItemChecked(1, false);
            }
        }

        private void CheckInfo()
        {
            if ((((this.textBox1.Text.Trim() == "") || (this.textBox2.Text.Trim() == "")) || ((this.textBox3.Text.Trim() == "") || (this.textBox4.Text.Trim() == ""))) || (((this.textBox5.Text.Trim() == "") || (this.textBox6.Text.Trim() == "")) || (this.textBox7.Text.Trim() == "")))
            {
                MessageBox.Show("以上各项均不允许为空!", "印易提示");
            }
            else if (((this.textBox1.Text.Trim().Length < 3) || (this.textBox2.Text.Trim().Length < 3)) || (this.textBox3.Text.Trim().Length < 3))
            {
                MessageBox.Show("会员帐号和会员密码不允许少于3个字符!", "印易提示");
            }
            else if ((((this.textBox1.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0) || (this.textBox2.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0)) || ((this.textBox3.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0) || (this.textBox4.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0))) || (((this.textBox5.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0) || (this.textBox6.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0)) || (this.textBox7.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0)))
            {
                MessageBox.Show("以上各项不允许使用“+,&,%,',\",空格”等特殊字符!", "印易提示");
            }
            else if (this.textBox2.Text.Trim() != this.textBox3.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不同!", "印易提示");
            }
            else
            {
                this.button1.Enabled = this.textBox1.Enabled = this.textBox2.Enabled = this.textBox3.Enabled = this.textBox4.Enabled = this.textBox5.Enabled = this.textBox6.Enabled = this.textBox7.Enabled = false;
                new Thread(new ThreadStart(this.SubmitUserInfo)).Start();
            }
        }

        private void CheckInfo2()
        {
            if (((this.textBox8.Text.Trim() == "") || (this.textBox9.Text.Trim() == "")) || (this.textBox10.Text.Trim() == ""))
            {
                MessageBox.Show("以上各项均不允许为空!", "印易提示");
            }
            else if ((this.textBox8.Text.Trim().Length < 3) || (this.textBox9.Text.Trim().Length < 3))
            {
                MessageBox.Show("会员帐号和会员密码不允许少于3个字符!", "印易提示");
            }
            else if ((this.textBox8.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0) || (this.textBox9.Text.Trim().IndexOfAny(new char[] { '+', '&', '%', ' ', '\'', '"' }) >= 0))
            {
                MessageBox.Show("会员帐号和会员密码不允许使用“+,&,%,',\",空格”等特殊字符!", "印易提示");
            }
            else if (this.textBox9.Text.Trim() != this.textBox10.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不同!", "印易提示");
            }
            else if (this.checkedListBox1.CheckedItems.Count <= 0)
            {
                MessageBox.Show("请赋予该前台帐号至少一个权限!", "印易提示");
            }
            else
            {
                this.button3.Enabled = this.textBox8.Enabled = this.textBox9.Enabled = this.textBox10.Enabled = false;
                new Thread(new ThreadStart(this.SubmitUserInfo2)).Start();
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

        private void InitializeComponent()
        {
            ResourceManager manager = new ResourceManager(typeof(AddUser));
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.groupBox2 = new GroupBox();
            this.label14 = new Label();
            this.label13 = new Label();
            this.label12 = new Label();
            this.label11 = new Label();
            this.textBox7 = new TextBox();
            this.textBox6 = new TextBox();
            this.textBox5 = new TextBox();
            this.textBox4 = new TextBox();
            this.label6 = new Label();
            this.label8 = new Label();
            this.label7 = new Label();
            this.label5 = new Label();
            this.groupBox1 = new GroupBox();
            this.label10 = new Label();
            this.label9 = new Label();
            this.textBox3 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.label3 = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.groupBox3 = new GroupBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.tabPage2 = new TabPage();
            this.button3 = new Button();
            this.button4 = new Button();
            this.groupBox5 = new GroupBox();
            this.checkedListBox1 = new CheckedListBox();
            this.groupBox4 = new GroupBox();
            this.label18 = new Label();
            this.label17 = new Label();
            this.textBox10 = new TextBox();
            this.textBox8 = new TextBox();
            this.label4 = new Label();
            this.textBox9 = new TextBox();
            this.label15 = new Label();
            this.label16 = new Label();
            this.groupBox6 = new GroupBox();
            this.groupBox7 = new GroupBox();
            this.label19 = new Label();
            this.label20 = new Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            base.SuspendLayout();
            this.tabControl1.Appearance = TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(0x220, 0x198);
            this.tabControl1.TabIndex = 0;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new Point(4, 0x18);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new Size(0x218, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "普通帐号";
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new Point(0x18, 0xa8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(0x1e8, 0x90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基本资料信息";
            this.label14.ForeColor = Color.Red;
            this.label14.Location = new Point(0x130, 0x60);
            this.label14.Name = "label14";
            this.label14.Size = new Size(8, 0x10);
            this.label14.TabIndex = 0x17;
            this.label14.Text = "*";
            this.label13.ForeColor = Color.Red;
            this.label13.Location = new Point(0x130, 0x4c);
            this.label13.Name = "label13";
            this.label13.Size = new Size(8, 0x10);
            this.label13.TabIndex = 0x16;
            this.label13.Text = "*";
            this.label12.ForeColor = Color.Red;
            this.label12.Location = new Point(0x1b0, 0x30);
            this.label12.Name = "label12";
            this.label12.Size = new Size(8, 0x10);
            this.label12.TabIndex = 0x15;
            this.label12.Text = "*";
            this.label11.ForeColor = Color.Red;
            this.label11.Location = new Point(0x1b0, 0x18);
            this.label11.Name = "label11";
            this.label11.Size = new Size(8, 0x10);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            this.textBox7.Location = new Point(0x60, 0x60);
            this.textBox7.MaxLength = 100;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Size(200, 0x15);
            this.textBox7.TabIndex = 0x13;
            this.textBox7.Text = "";
            this.textBox6.Location = new Point(0x60, 0x48);
            this.textBox6.MaxLength = 100;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(200, 0x15);
            this.textBox6.TabIndex = 0x12;
            this.textBox6.Text = "";
            this.textBox5.Location = new Point(0x60, 0x30);
            this.textBox5.MaxLength = 200;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(0x148, 0x15);
            this.textBox5.TabIndex = 0x11;
            this.textBox5.Text = "";
            this.textBox4.Location = new Point(0x60, 0x18);
            this.textBox4.MaxLength = 200;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(0x148, 0x15);
            this.textBox4.TabIndex = 0x10;
            this.textBox4.Text = "";
            this.label6.Location = new Point(0x18, 0x38);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x48, 0x17);
            this.label6.TabIndex = 13;
            this.label6.Text = "公司地址：";
            this.label8.Location = new Point(0x18, 0x68);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x48, 0x17);
            this.label8.TabIndex = 15;
            this.label8.Text = "联系电话：";
            this.label7.Location = new Point(0x18, 80);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x48, 0x17);
            this.label7.TabIndex = 14;
            this.label7.Text = "联 系 人：";
            this.label5.Location = new Point(0x18, 0x20);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x48, 0x17);
            this.label5.TabIndex = 12;
            this.label5.Text = "公司名称：";
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new Point(0x18, 0x20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x1e8, 0x70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会员帐号信息";
            this.label10.ForeColor = Color.Red;
            this.label10.Location = new Point(280, 0x18);
            this.label10.Name = "label10";
            this.label10.Size = new Size(8, 0x10);
            this.label10.TabIndex = 15;
            this.label10.Text = "*";
            this.label9.ForeColor = Color.Blue;
            this.label9.Location = new Point(0x120, 0x18);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0xb8, 0x38);
            this.label9.TabIndex = 14;
            this.label9.Text = "不允许使用“+,＆,%,',\",空格”等特殊字符,最多13个字符,最少3个字符。";
            this.textBox3.Location = new Point(0x60, 0x48);
            this.textBox3.MaxLength = 13;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new Size(0xb0, 0x15);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "";
            this.textBox2.Location = new Point(0x60, 0x30);
            this.textBox2.MaxLength = 13;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new Size(0xb0, 0x15);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "";
            this.textBox1.Location = new Point(0x60, 0x18);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0xb0, 0x15);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "";
            this.label3.Location = new Point(0x18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x48, 0x17);
            this.label3.TabIndex = 10;
            this.label3.Text = "确认密码：";
            this.label1.Location = new Point(0x18, 0x20);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x48, 0x17);
            this.label1.TabIndex = 8;
            this.label1.Text = "会员账号：";
            this.label2.Location = new Point(0x18, 0x38);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x48, 0x17);
            this.label2.TabIndex = 9;
            this.label2.Text = "会员密码：";
            this.groupBox3.Location = new Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(0x220, 3);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.button1.BackColor = SystemColors.Control;
            this.button1.Location = new Point(360, 0x148);
            this.button1.Name = "button1";
            this.button1.TabIndex = 1;
            this.button1.Text = "提交";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.BackColor = SystemColors.Control;
            this.button2.Location = new Point(440, 0x148);
            this.button2.Name = "button2";
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new Point(4, 0x18);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new Size(0x218, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "前台";
            this.button3.BackColor = SystemColors.Control;
            this.button3.Location = new Point(360, 0x148);
            this.button3.Name = "button3";
            this.button3.TabIndex = 7;
            this.button3.Text = "提交";
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button4.BackColor = SystemColors.Control;
            this.button4.Location = new Point(440, 0x148);
            this.button4.Name = "button4";
            this.button4.TabIndex = 8;
            this.button4.Text = "取消";
            this.button4.Click += new EventHandler(this.button4_Click);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.checkedListBox1);
            this.groupBox5.Location = new Point(0xf8, 0x20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(0x108, 280);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "前台操作权限";
            this.checkedListBox1.BackColor = SystemColors.ControlLight;
            this.checkedListBox1.BorderStyle = BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Items.AddRange(new object[] { "接收订单", "删除订单", "用户管理", "客户文件发送", "客户文件管理", "声明/公告管理", "平台设置", "系统日志管理" });
            this.checkedListBox1.Location = new Point(0x18, 0x18);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(0x68, 0x90);
            this.checkedListBox1.TabIndex = 0;
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new Point(0x18, 0x20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(0xd8, 280);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "前台帐号信息";
            this.label18.ForeColor = Color.Red;
            this.label18.Location = new Point(0x10, 120);
            this.label18.Name = "label18";
            this.label18.Size = new Size(8, 0x10);
            this.label18.TabIndex = 0x10;
            this.label18.Text = "*";
            this.label17.ForeColor = Color.Blue;
            this.label17.Location = new Point(0x18, 120);
            this.label17.Name = "label17";
            this.label17.Size = new Size(0xb8, 0x38);
            this.label17.TabIndex = 15;
            this.label17.Text = "不允许使用“+,＆,%,',\",空格”等特殊字符,最多13个字符,最少3个字符。";
            this.textBox10.Location = new Point(0x60, 0x48);
            this.textBox10.MaxLength = 13;
            this.textBox10.Name = "textBox10";
            this.textBox10.PasswordChar = '*';
            this.textBox10.TabIndex = 5;
            this.textBox10.Text = "";
            this.textBox8.Location = new Point(0x60, 0x18);
            this.textBox8.MaxLength = 13;
            this.textBox8.Name = "textBox8";
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = "";
            this.label4.Location = new Point(0x18, 0x20);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x48, 0x17);
            this.label4.TabIndex = 0;
            this.label4.Text = "前台帐号：";
            this.textBox9.Location = new Point(0x60, 0x30);
            this.textBox9.MaxLength = 13;
            this.textBox9.Name = "textBox9";
            this.textBox9.PasswordChar = '*';
            this.textBox9.TabIndex = 4;
            this.textBox9.Text = "";
            this.label15.Location = new Point(0x18, 0x38);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x48, 0x17);
            this.label15.TabIndex = 1;
            this.label15.Text = "帐号密码：";
            this.label16.Location = new Point(0x18, 80);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x48, 0x17);
            this.label16.TabIndex = 2;
            this.label16.Text = "密码确认：";
            this.groupBox6.Location = new Point(0, 0x18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(560, 3);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox7.BackColor = SystemColors.ControlLight;
            this.groupBox7.Location = new Point(0, 0x158);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new Size(560, 3);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.label19.ForeColor = Color.Blue;
            this.label19.Location = new Point(0x30, 0xb0);
            this.label19.Name = "label19";
            this.label19.Size = new Size(200, 0x20);
            this.label19.TabIndex = 1;
            this.label19.Text = "此权限只应用于与此软件,不能用于网上平台!";
            this.label20.ForeColor = Color.Blue;
            this.label20.Location = new Point(0x18, 0xb0);
            this.label20.Name = "label20";
            this.label20.Size = new Size(0x18, 0x17);
            this.label20.TabIndex = 2;
            this.label20.Text = "注:";
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x220, 0x197);
            base.Controls.Add(this.groupBox7);
            base.Controls.Add(this.groupBox6);
            base.Controls.Add(this.tabControl1);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "AddUser";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "增加客户";
            base.Load += new EventHandler(this.AddUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void SubmitUserInfo()
        {
            string[] userInfo = new string[] { this.textBox1.Text.Trim(), this.textBox2.Text.Trim(), this.textBox4.Text.Trim(), this.textBox5.Text.Trim(), this.textBox6.Text.Trim(), this.textBox7.Text.Trim() };
            ePrintOutputLogin login = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
            switch (login._AddUser(0, Convert.ToInt16(ePrintMain.Outputkey), userInfo))
            {
                case "1":
                    MessageBox.Show("新增成功！");
                    break;

                case "-1":
                    MessageBox.Show("此帐号已经存在，请另选一个帐号！");
                    break;

                case "0":
                    MessageBox.Show("新增失败！");
                    break;
            }
            this.button1.Enabled = this.textBox1.Enabled = this.textBox2.Enabled = this.textBox3.Enabled = this.textBox4.Enabled = this.textBox5.Enabled = this.textBox6.Enabled = this.textBox7.Enabled = true;
        }

        private void SubmitUserInfo2()
        {
            string str2 = "00";
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < this.checkedListBox1.CheckedIndices.Count; j++)
                {
                    if (this.checkedListBox1.CheckedIndices[j] == i)
                    {
                        flag = true;
                        str2 = str2 + "1";
                        break;
                    }
                }
                if (!flag)
                {
                    str2 = str2 + "0";
                }
            }
            str2 = str2 + "000000000000000000000000000000";
            string[] userInfo = new string[] { this.textBox8.Text.Trim(), this.textBox9.Text.Trim(), str2 };
            ePrintOutputLogin login = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
            switch (login._AddUser(1, Convert.ToInt16(ePrintMain.Outputkey), userInfo))
            {
                case "1":
                    MessageBox.Show("新增成功！");
                    break;

                case "-1":
                    MessageBox.Show("此帐号已经存在，请另选一个帐号！");
                    break;

                case "0":
                    MessageBox.Show("新增失败！");
                    break;
            }
            this.button3.Enabled = this.textBox8.Enabled = this.textBox9.Enabled = this.textBox10.Enabled = true;
        }
    }
}

