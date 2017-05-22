namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class About : Form
    {
        private Button button1;
        private Container components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        public About()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            this.button1 = new Button();
            this.groupBox1 = new GroupBox();
            this.label6 = new Label();
            this.label5 = new Label();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.label1 = new Label();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.button1.BackColor = SystemColors.Control;
            this.button1.Location = new Point(0x70, 240);
            this.button1.Name = "button1";
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x110, 0xe0);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.label6.Location = new Point(40, 0xa8);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0xc0, 0x17);
            this.label6.TabIndex = 11;
            this.label6.Text = "http://www.print2000.cn";
            this.label5.Location = new Point(40, 0x90);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0xb8, 0x10);
            this.label5.TabIndex = 10;
            this.label5.Text = "Copyright(C) 2004-2006";
            this.label4.Location = new Point(40, 120);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x70, 0x10);
            this.label4.TabIndex = 9;
            this.label4.Text = "Version:3.3.9.10";
            this.label3.BackColor = SystemColors.Control;
            this.label3.Location = new Point(0x24, 0x58);
            this.label3.Name = "label3";
            this.label3.Size = new Size(200, 0x17);
            this.label3.TabIndex = 8;
            this.label3.Text = "版权所有:广州印网科技有限公司";
            this.label2.Location = new Point(0x24, 0x40);
            this.label2.Name = "label2";
            this.label2.TabIndex = 7;
            this.label2.Text = "版本:3.3.9.10";
            this.label1.Font = new Font("宋体", 9f, FontStyle.Bold, GraphicsUnit.Point, 0x86);
            this.label1.Location = new Point(0x24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x88, 0x17);
            this.label1.TabIndex = 6;
            this.label1.Text = "印易在线服务平台";
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = SystemColors.ControlLight;
            base.ClientSize = new Size(0x124, 0x111);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.button1);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "About";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "关于印易在线服务平台";
            this.groupBox1.ResumeLayout(false);
            base.ResumeLayout(false);
        }
    }
}

