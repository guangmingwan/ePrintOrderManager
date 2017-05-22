namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.com.print2000.output;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class AddBulletin : Form
    {
        private Button button1;
        private Button button2;
        private Container components = null;
        private ePrintOrderManager.ePrintLog ePrintLog;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;

        public AddBulletin()
        {
            this.InitializeComponent();
            this.ePrintLog = new ePrintOrderManager.ePrintLog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text.Trim() == "") || (this.textBox2.Text.Trim() == ""))
            {
                MessageBox.Show("标题和内容都不允许为空!");
            }
            else
            {
                this.ePrintLog.WriteLog("新增公告: " + this.replaceChar(this.textBox1.Text.Trim()));
                string[] bulletinInfo = new string[] { this.replaceChar(this.textBox1.Text.Trim()), this.replaceChar(this.textBox2.Text.Trim()) };
                ePrintOutputLogin login = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                if (login._AddBulletin(Convert.ToInt32(ePrintMain.Outputkey), bulletinInfo))
                {
                    this.ePrintLog.WriteLog("新增公告成功");
                    MessageBox.Show("新增成功!");
                }
                else
                {
                    this.ePrintLog.WriteLog("新增公告失败");
                    MessageBox.Show("新增失败!");
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

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            base.SuspendLayout();
            this.label1.Location = new Point(8, 0x10);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x48, 0x17);
            this.label1.TabIndex = 0;
            this.label1.Text = "公告标题：";
            this.label1.Click += new EventHandler(this.label1_Click);
            this.label2.Location = new Point(8, 0x40);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x48, 0x17);
            this.label2.TabIndex = 1;
            this.label2.Text = "公告内容：";
            this.label2.Click += new EventHandler(this.label2_Click);
            this.textBox1.Location = new Point(8, 0x20);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(560, 0x15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
            this.textBox2.Location = new Point(8, 80);
            this.textBox2.MaxLength = 0x7d0;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(560, 0xe0);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "";
            this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
            this.button1.Location = new Point(0x198, 0x138);
            this.button1.Name = "button1";
            this.button1.TabIndex = 4;
            this.button1.Text = "提交";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Location = new Point(0x1e8, 0x138);
            this.button2.Name = "button2";
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(0x242, 0x167);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "AddBulletin";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "新增公告";
            base.ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private string replaceChar(string strInfo)
        {
            return strInfo.Replace("'", "＇").Replace(",", "，").Replace(";", "；").Replace("#", "＃").Replace("&", "＆").Replace("+", "＋").Replace("\"", "＂").Replace("?", "？");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

