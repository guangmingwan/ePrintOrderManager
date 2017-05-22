namespace ePrintOrderManager
{
    using ePrintOrderManager.cn.com.print2000.output;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class editBulletin : Form
    {
        private Button button1;
        private Button button2;
        private Container components = null;
        private ePrintOrderManager.ePrintLog ePrintLog;
        public int ID = 0;
        private Label label1;
        private Label label2;
        private string Outputkey;
        public string strContent = null;
        public string strTitle = null;
        private TextBox textBox1;
        private TextBox textBox2;

        public editBulletin()
        {
            this.InitializeComponent();
            this.ePrintLog = new ePrintOrderManager.ePrintLog();
            this.Outputkey = ePrintMain.Outputkey;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text.Trim() == "") || (this.textBox2.Text.Trim() == ""))
            {
                MessageBox.Show("标题和内容都不允许为空!");
            }
            else
            {
                this.ePrintLog.WriteLog("修改公告: " + this.textBox1.Text.Trim());
                string[] newBulletinInfo = new string[] { this.replaceChar(this.textBox1.Text.Trim()), this.replaceChar(this.textBox2.Text.Trim()) };
                ePrintOutputLogin login = new ePrintOutputLogin(OutputLogin.WebsUrl + "/ePrintOutputLogin.asmx");
                if (login._editOutputBulletin(Convert.ToInt32(this.Outputkey), this.ID, newBulletinInfo))
                {
                    this.ePrintLog.WriteLog("修改公告成功");
                    MessageBox.Show("修改成功!");
                }
                else
                {
                    this.ePrintLog.WriteLog("修改公告失败");
                    MessageBox.Show("修改失败!");
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

        private void editBulletin_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.strTitle;
            this.textBox2.Text = this.strContent;
        }

        private void InitializeComponent()
        {
            this.button2 = new Button();
            this.button1 = new Button();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.label2 = new Label();
            this.label1 = new Label();
            base.SuspendLayout();
            this.button2.Location = new Point(0x1e8, 0x13b);
            this.button2.Name = "button2";
            this.button2.TabIndex = 11;
            this.button2.Text = "退出";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.button1.Location = new Point(0x198, 0x13b);
            this.button1.Name = "button1";
            this.button1.TabIndex = 10;
            this.button1.Text = "修改";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBox2.Location = new Point(8, 0x53);
            this.textBox2.MaxLength = 0x7d0;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(560, 0xe0);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "";
            this.textBox1.Location = new Point(8, 0x23);
            this.textBox1.MaxLength = 200;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(560, 0x15);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "";
            this.label2.Location = new Point(8, 0x43);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x48, 0x17);
            this.label2.TabIndex = 7;
            this.label2.Text = "公告内容：";
            this.label1.Location = new Point(8, 0x13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x48, 0x17);
            this.label1.TabIndex = 6;
            this.label1.Text = "公告标题：";
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(0x240, 0x165);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "editBulletin";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "公告修改";
            base.Load += new EventHandler(this.editBulletin_Load);
            base.ResumeLayout(false);
        }

        private string replaceChar(string strInfo)
        {
            return strInfo.Replace("'", "＇").Replace(",", "，").Replace(";", "；").Replace("#", "＃").Replace("&", "＆").Replace("+", "＋").Replace("\"", "＂").Replace("?", "？");
        }
    }
}

