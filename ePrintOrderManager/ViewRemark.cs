namespace ePrintOrderManager
{
    using System;
    using System.ComponentModel;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Windows.Forms;

    public class ViewRemark : Form
    {
        private Button button1;
        private Container components = null;
        public long key;
        private TextBox textBox1;

        public ViewRemark()
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
            this.textBox1 = new TextBox();
            base.SuspendLayout();
            this.button1.Dock = DockStyle.Bottom;
            this.button1.FlatStyle = FlatStyle.Flat;
            this.button1.Location = new Point(0, 0xf5);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x1c0, 0x18);
            this.button1.TabIndex = 1;
            this.button1.Text = "关闭";
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBox1.BackColor = Color.LightSteelBlue;
            this.textBox1.BorderStyle = BorderStyle.FixedSingle;
            this.textBox1.Dock = DockStyle.Top;
            this.textBox1.Location = new Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(0x1c0, 0xf4);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(0x1c0, 0x10d);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.textBox1);
            base.FormBorderStyle = FormBorderStyle.None;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ViewRemark";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.Load += new EventHandler(this.ViewRemark_Load);
            base.ResumeLayout(false);
        }

        private void ViewRemark_Load(object sender, EventArgs e)
        {
            string str = null;
            OleDbConnection connection = new OleDbConnection(ePrintMain.strCon);
            connection.Open();
            OleDbCommand command = new OleDbCommand("select CompanyName,CompanyAddress,CompanyTel,CompanyMan,OrderCode,FileName,OrderInfo,ZipInfo from DownLoading where dh=" + this.key, connection);
            OleDbDataReader reader = null;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                string[] strArray = reader["OrderInfo"].ToString().Split(new char[] { ',' });
                str = strArray[strArray.Length - 3];
                str = "\r\n 工单编号：" + reader["OrderCode"].ToString() + "\r\n 文件名称：" + reader["FileName"].ToString() + "\r\n__________________________________________________________________________\r\n\r\n 公司名称：" + reader["CompanyName"].ToString() + "\r\n 公司地址：" + reader["CompanyAddress"].ToString() + "\r\n 联 系 人：" + reader["CompanyMan"].ToString() + "\r\n 联系电话：" + reader["CompanyTel"].ToString() + "\r\n 要求送货时间：" + strArray[strArray.Length - 2] + "\r\n 要求送货地点：" + strArray[strArray.Length - 1] + "\r\n__________________________________________________________________________\r\n\r\n 附    言：\r\n " + str + "\r\n";
            }
            reader.Close();
            connection.Close();
            this.textBox1.Text = str;
            this.textBox1.SelectionStart = this.textBox1.Text.Length;
        }
    }
}

