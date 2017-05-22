namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    public class editUserLevel : Form
    {
        private Button button1;
        private Button button2;
        private CheckedListBox checkedListBox1;
        private Container components = null;
        private GroupBox groupBox5;
        private Label label1;
        private Label label19;
        private Label label20;
        private TextBox textBox1;
        public string UserID = null;
        public string UserLevel = null;
        public string UserName = null;

        public editUserLevel()
        {
            this.InitializeComponent();
        }

        private void _editUserLevel()
        {
            string str = null;
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
            switch (str)
            {
                case "1":
                    MessageBox.Show("修改成功！");
                    break;

                case "-1":
                    MessageBox.Show("此帐号已经存在，请另选一个帐号！");
                    break;

                case "0":
                    MessageBox.Show("新增失败！");
                    break;
            }
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkedListBox1.CheckedItems.Count <= 0)
            {
                MessageBox.Show("请赋予该前台帐号至少一个权限!", "印易提示");
            }
            else
            {
                this.button1.Enabled = false;
                new Thread(new ThreadStart(this._editUserLevel)).Start();
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

        private void editUserLevel_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.UserName;
            try
            {
                string str = this.UserLevel.Substring(3, 8);
                for (int i = 0; i < 8; i++)
                {
                    if (str.Substring(i, 1) == "1")
                    {
                        this.checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
            catch
            {
            }
        }

        private void InitializeComponent()
        {
            this.groupBox5 = new GroupBox();
            this.label20 = new Label();
            this.label19 = new Label();
            this.checkedListBox1 = new CheckedListBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.textBox1 = new TextBox();
            this.label1 = new Label();
            this.groupBox5.SuspendLayout();
            base.SuspendLayout();
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.checkedListBox1);
            this.groupBox5.Location = new Point(0x18, 0x38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new Size(0x100, 0xd0);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "操作权限";
            this.label20.ForeColor = Color.Blue;
            this.label20.Location = new Point(0x18, 0xa8);
            this.label20.Name = "label20";
            this.label20.Size = new Size(0x18, 0x17);
            this.label20.TabIndex = 2;
            this.label20.Text = "注:";
            this.label19.ForeColor = Color.Blue;
            this.label19.Location = new Point(0x30, 0xa8);
            this.label19.Name = "label19";
            this.label19.Size = new Size(200, 0x20);
            this.label19.TabIndex = 1;
            this.label19.Text = "此权限只应用于与此软件,不能用于网上平台!";
            this.checkedListBox1.BackColor = SystemColors.ControlLight;
            this.checkedListBox1.BorderStyle = BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Items.AddRange(new object[] { "接收订单", "删除订单", "用户管理", "客户文件发送", "客户文件管理", "声明/公告管理", "平台设置", "系统日志管理" });
            this.checkedListBox1.Location = new Point(0x18, 0x18);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(0x70, 0x80);
            this.checkedListBox1.TabIndex = 0;
            this.button1.BackColor = SystemColors.Control;
            this.button1.Location = new Point(0x80, 280);
            this.button1.Name = "button1";
            this.button1.TabIndex = 8;
            this.button1.Text = "修改";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.BackColor = SystemColors.Control;
            this.button2.Location = new Point(0xd0, 280);
            this.button2.Name = "button2";
            this.button2.TabIndex = 9;
            this.button2.Text = "退出";
            this.button2.Click += new EventHandler(this.button2_Click);
            this.textBox1.Location = new Point(0x58, 0x10);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(0x80, 0x15);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "";
            this.label1.BackColor = SystemColors.ControlLight;
            this.label1.Location = new Point(0x18, 0x18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x48, 0x17);
            this.label1.TabIndex = 10;
            this.label1.Text = "帐号名称：";
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x132, 0x13f);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.groupBox5);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "editUserLevel";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "用户权限";
            base.Load += new EventHandler(this.editUserLevel_Load);
            this.groupBox5.ResumeLayout(false);
            base.ResumeLayout(false);
        }
    }
}

