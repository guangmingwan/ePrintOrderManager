namespace ePrintOrderManager
{
    using System;
    using System.IO;
    using System.Text;

    public class ePrintLog
    {
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

        public void WriteLog(string strLogInfo)
        {
            Console.WriteLine(strLogInfo);
            if (!Directory.Exists("ePrintLog"))
            {
                Directory.CreateDirectory("ePrintLog");
            }
            string str = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + ".ePrintLog";
            FileStream stream = new FileStream(@"ePrintLog\" + str, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(stream, Encoding.Default);
            string str2 = "【" + DateTime.Now.ToString() + " : 】 " + strLogInfo + "\r\n";
            writer.Write(str2);
            writer.Close();
            stream.Close();
        }
    }
}

