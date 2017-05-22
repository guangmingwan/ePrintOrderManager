namespace ePrintOrderManager
{
    using Microsoft.Win32;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Resources;
    using System.Text;
    using System.Windows.Forms;

    public class ScreenProtectLogin2 : Form
    {
        private Button button1;
        private Button button2;
        private Container components = null;
        private Label label1;
        private Label label4;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox2;

        public ScreenProtectLogin2()
        {
            this.InitializeComponent();
            ePrintMain.isLock = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            this.button1.Enabled = true;
            if (this.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("请输入解锁密码！");
            }
            else
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
                if (key != null)
                {
                    if (key.GetValue("ScreenProtectInfo") != null)
                    {
                        if (key.GetValue("ScreenProtectInfo").ToString().Split(new char[] { '|' })[2] == this.ePrintSecurity(this.textBox2.Text.Trim()))
                        {
                            base.Close();
                            base.ParentForm.Close();
                        }
                        else
                        {
                            MessageBox.Show("解锁密码错误，请重试！");
                        }
                    }
                    else
                    {
                        key.SetValue("ScreenProtectInfo", "");
                    }
                }
            }
            this.button2.Enabled = true;
            this.button1.Enabled = false;
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
            catch
            {
            }
            return str;
        }

        private void InitializeComponent()
        {
            ResourceManager manager = new ResourceManager(typeof(ScreenProtectLogin2));
            this.panel1 = new Panel();
            this.label1 = new Label();
            this.label4 = new Label();
            this.textBox2 = new TextBox();
            this.button2 = new Button();
            this.pictureBox1 = new PictureBox();
            this.button1 = new Button();
            base.SuspendLayout();
            this.panel1.BackColor = Color.SlateGray;
            this.panel1.Dock = DockStyle.Top;
            this.panel1.Location = new Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x17a, 40);
            this.panel1.TabIndex = 0;
            this.label1.Location = new Point(0x30, 0x30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x130, 0x17);
            this.label1.TabIndex = 1;
            this.label1.Text = "此程序正在使用，并被锁定。需平台管理员解除锁定！";
            this.label4.Location = new Point(0x38, 0x58);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x48, 0x17);
            this.label4.TabIndex = 4;
            this.label4.Text = "解锁密码：";
            this.textBox2.Location = new Point(120, 80);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new Size(0xc0, 0x15);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "";
            this.button2.Location = new Point(0xd8, 120);
            this.button2.Name = "button2";
            this.button2.TabIndex = 8;
            this.button2.Text = "确定";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.pictureBox1.Image = (Image) manager.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(0x18, 0x30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x10, 0x10);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.button1.Enabled = false;
            this.button1.Location = new Point(0x128, 120);
            this.button1.Name = "button1";
            this.button1.TabIndex = 10;
            this.button1.Text = "取消";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(0x17a, 0x97);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.panel1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ScreenProtectLogin2";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "解除锁定";
            base.Closing += new CancelEventHandler(this.ScreenProtectLogin2_Closing);
            base.Load += new EventHandler(this.ScreenProtectLogin2_Load);
            base.ResumeLayout(false);
        }

        private void ScreenProtectLogin2_Closing(object sender, CancelEventArgs e)
        {
            ePrintMain.isLock = false;
            e.Cancel = true;
        }

        private void ScreenProtectLogin2_Load(object sender, EventArgs e)
        {
        }
    }
}

