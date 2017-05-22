namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.com.print2000.output;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class EditUserPassword : Form
    {
        private Button button1;
        private Button button2;
        private Container components = null;
        public int editType = 0;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        public string myCompanyName;
        public string OldUserPassword;
        public string OutputKey;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        public string UserCode;
        public string UserId;
        public string UserName;

        public EditUserPassword()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text.Trim() == "")
            {
                this.textBox4.Focus();
                MessageBox.Show("请输入新密码!");
            }
            else if (this.textBox5.Text.Trim() == "")
            {
                this.textBox5.Focus();
                MessageBox.Show("请输入确认密码!");
            }
            else if (this.textBox4.Text.Trim().Length < 3)
            {
                this.textBox4.Focus();
                this.textBox4.SelectionStart = this.textBox4.Text.Trim().Length;
                MessageBox.Show("新密码不能少于3位!");
            }
            else if ((((this.textBox4.Text.Trim().IndexOf("'") >= 0) || (this.textBox4.Text.Trim().IndexOf("&") >= 0)) || ((this.textBox4.Text.Trim().IndexOf("#") >= 0) || (this.textBox4.Text.Trim().IndexOf("%") >= 0))) || (((this.textBox4.Text.Trim().IndexOf("+") >= 0) || (this.textBox4.Text.Trim().IndexOf(",") >= 0)) || (((this.textBox4.Text.Trim().IndexOf(" ") >= 0) || (this.textBox4.Text.Trim().IndexOf(";") >= 0)) || (this.textBox4.Text.Trim().IndexOf("?") >= 0))))
            {
                MessageBox.Show("密码中不能含有 \"单引号,空格,逗号,&,+,#,%,;,?\" 等特殊字符!");
            }
            else if (this.textBox5.Text.Trim() != this.textBox4.Text.Trim())
            {
                MessageBox.Show("确认密码和新密码不一致!");
            }
            else
            {
                ePrintOutputLogin login = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                if (login._editUserPassword(this.dowithString(this.textBox4.Text.Trim()), Convert.ToInt32(this.UserId), Convert.ToInt32(this.OutputKey)))
                {
                    MessageBox.Show("操作成功!");
                    base.Close();
                }
                else
                {
                    MessageBox.Show("操作失败!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private string dowithString(string strString)
        {
            return strString.Trim().Replace("'", "").Replace("&", "").Replace("#", "").Replace("%", "").Replace("+", "").Replace(",", "").Replace(" ", "");
        }

        private void EditUserPassword_Load(object sender, EventArgs e)
        {
            if (this.editType == 1)
            {
                this.label5.Visible = this.textBox5.Visible = true;
                this.textBox4.ReadOnly = false;
                this.Text = "密码修改";
                this.label4.Text = "修改密码:";
                this.button1.Text = "修改";
                this.textBox4.Text = this.textBox5.Text = "";
            }
            else
            {
                this.label5.Visible = this.textBox5.Visible = false;
                this.textBox4.ReadOnly = true;
                this.Text = "密码重置";
                this.label4.Text = "重置密码:";
                this.button1.Text = "重置";
                this.textBox4.Text = this.textBox5.Text = "123456";
            }
            this.textBox6.Text = this.UserCode;
            this.textBox1.Text = this.myCompanyName;
            this.textBox2.Text = this.UserName;
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.tabControl1 = new TabControl();
            this.tabPage1 = new TabPage();
            this.groupBox1 = new GroupBox();
            this.textBox6 = new TextBox();
            this.label6 = new Label();
            this.textBox5 = new TextBox();
            this.textBox4 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            base.SuspendLayout();
            this.label1.Location = new Point(0x10, 0x30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x40, 0x17);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司名称:";
            this.label2.Location = new Point(0x10, 0x48);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x40, 0x17);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户帐号:";
            this.label4.Location = new Point(0x10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x40, 0x17);
            this.label4.TabIndex = 3;
            this.label4.Text = "重置密码:";
            this.label5.Location = new Point(0x10, 0x90);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x40, 0x17);
            this.label5.TabIndex = 4;
            this.label5.Text = "密码确认:";
            this.label5.Visible = false;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new Point(0, -24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(0x120, 0xc0);
            this.tabControl1.TabIndex = 5;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new Point(4, 0x15);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new Size(280, 0xa7);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.groupBox1.BackColor = SystemColors.Control;
            this.groupBox1.Location = new Point(0x10, 0x60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0xf2, 3);
            this.groupBox1.TabIndex = 0x10;
            this.groupBox1.TabStop = false;
            this.textBox6.Location = new Point(80, 0x10);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new Size(0x38, 0x15);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "";
            this.label6.Location = new Point(0x10, 0x18);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x40, 0x17);
            this.label6.TabIndex = 14;
            this.label6.Text = "编　　号:";
            this.textBox5.Location = new Point(80, 0x88);
            this.textBox5.MaxLength = 13;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(0xb0, 0x15);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "123456";
            this.textBox5.Visible = false;
            this.textBox4.Location = new Point(80, 0x70);
            this.textBox4.MaxLength = 13;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(0xb0, 0x15);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "123456";
            this.textBox2.Location = new Point(80, 0x40);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(0xb0, 0x15);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "";
            this.textBox1.Location = new Point(80, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(0xb0, 0x15);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "";
            this.button1.BackColor = SystemColors.Control;
            this.button1.Location = new Point(0x80, 0xb0);
            this.button1.Name = "button1";
            this.button1.TabIndex = 7;
            this.button1.Text = "重置";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.BackColor = SystemColors.Control;
            this.button2.Location = new Point(0xd0, 0xb0);
            this.button2.Name = "button2";
            this.button2.TabIndex = 8;
            this.button2.Text = "取消";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x120, 0xcf);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.tabControl1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "EditUserPassword";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "密码重置";
            base.Load += new EventHandler(this.EditUserPassword_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            base.ResumeLayout(false);
        }
    }
}

