namespace ePrintOrderManager
{
    using System;
    using System.IO;
    using System.Net;

    public class OneJetDown
    {
        private _fileinfo __myfileinfo;
        private ePrintOrderManager.ePrintLog ePrintLog;
        public string FileName;
        public string FilePath;
        public string FileSaveSet;
        public long FileSize;
        private ePrintMain myMain;

        public OneJetDown(ePrintMain Sender, _fileinfo fileinfo)
        {
            this.__myfileinfo = fileinfo;
            this.myMain = Sender;
            this.ePrintLog = new ePrintOrderManager.ePrintLog();
        }

        public void down()
        {
            Console.Write("\r\n3331\r\n");
            string path = this.FileSaveSet + @"\" + this.FileName;
            long offset = 0L;
            Console.Write("\r\n444 " + path.ToString() + "\r\n");
            if (File.Exists(path))
            {
                Console.Write("\r\n555 \r\n");
                try
                {
                    this.__myfileinfo.fs2 = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                    if (this.__myfileinfo.fs2.Length > 0x1000L)
                    {
                        offset = this.__myfileinfo.fs2.Length - 0x1000L;
                    }
                    else if (this.__myfileinfo.fs2.Length > 0x800L)
                    {
                        offset = this.__myfileinfo.fs2.Length - 0x800L;
                    }
                    else if (this.__myfileinfo.fs2.Length >= 0x400L)
                    {
                        offset = this.__myfileinfo.fs2.Length - 0x400L;
                    }
                    else
                    {
                        offset = this.__myfileinfo.fs2.Length;
                    }
                    Console.Write("\r\n666初始位置 " + offset.ToString() + "\r\n");
                    this.__myfileinfo.fs2.Seek(offset, SeekOrigin.Current);
                }
                catch (Exception exception)
                {
                    Console.Write("\r\n777 " + exception.ToString() + "\r\n");
                    this.ePrintLog.WriteLog("文件下载信息提示:" + exception.ToString());
                    this.__myfileinfo.ns2.Close();
                    this.__myfileinfo.fs2.Close();
                }
            }
            else
            {
                Console.Write("\r\n888\r\n");
                this.__myfileinfo.fs2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                offset = 0L;
            }
            try
            {
                string[] strArray;
                Console.Write("\r\n999\r\n");
                Console.Write("\r\n161616下载url：" + this.FilePath + "\r\n");
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(this.FilePath);
                request.AllowAutoRedirect = true;
                request.Timeout = 0x1388;
                request.Accept = "*/*";
                request.Headers.Add("Pragma:no-cache");
                request.Headers.Add("Cache-Control:no-cache");
                request.Headers.Add("UserAgent:Mozilla/4.0 (compatible; MSIE 5.00; Windows 98)");
                request.ServicePoint.ConnectionLimit = 50;
                Console.Write("\r\n10101010\r\n");
                request.ServicePoint.ConnectionLimit = 50;
                if (offset > 0L)
                {
                    Console.Write("\r\n111111\r\n");
                    request.AddRange((int) offset);
                }
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "up,";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + DateTime.Now.ToString() + ",";
                string str2 = strArray[0];
                (strArray = this.__myfileinfo.SplitInfo)[0] = str2 + request.Method + " " + request.Address.LocalPath + " HTTP/" + request.ProtocolVersion.ToString() + "|";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "up,";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + DateTime.Now.ToString() + ",";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "Host : " + request.Address.Host + "|";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "up,";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + DateTime.Now.ToString() + ",";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "RequestUri : " + request.RequestUri.ToString() + "|";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "up,";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + DateTime.Now.ToString() + ",";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "IdleSince : " + request.ServicePoint.IdleSince.ToString() + "|";
                Console.Write("\r\n121212\r\n");
                for (int i = 0; i < request.Headers.Count; i++)
                {
                    (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "up,";
                    (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + DateTime.Now.ToString() + ",";
                    str2 = strArray[0];
                    (strArray = this.__myfileinfo.SplitInfo)[0] = str2 + request.Headers.GetKey(i).ToString() + " : " + request.Headers[i].ToString().Replace(",", " ") + "|";
                }
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "｜";
                Console.Write("\r\n131313\r\n");
                this.__myfileinfo.ns2 = request.GetResponse().GetResponseStream();
                WebResponse response = request.GetResponse();
                for (int j = 0; j < response.Headers.Count; j++)
                {
                    (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "down,";
                    (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + DateTime.Now.ToString() + ",";
                    str2 = strArray[0];
                    (strArray = this.__myfileinfo.SplitInfo)[0] = str2 + response.Headers.GetKey(j) + " : " + response.Headers[j].Replace(",", " ") + "|";
                }
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "｜";
                this.__myfileinfo.ns[0] = response.GetResponseStream();
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "ok,";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + DateTime.Now.ToString() + ",";
                (strArray = this.__myfileinfo.SplitInfo)[0] = strArray[0] + "开始接受数据!|｜";
                Console.Write("\r\n141414\r\n");
                byte[] buffer = new byte[0x400];
                int count = 0;
                count = this.__myfileinfo.ns2.Read(buffer, 0, 0x400);
                this.__myfileinfo.splitedNum++;
                while (count > 0)
                {
                    this.__myfileinfo.fs2.Write(buffer, 0, count);
                    this.__myfileinfo.ns2.Flush();
                    count = this.__myfileinfo.ns2.Read(buffer, 0, 0x400);
                }
                this.__myfileinfo.ns2.Close();
                this.__myfileinfo.splitedNum--;
                Console.WriteLine("下载完成");
            }
            catch (Exception exception2)
            {
                Console.Write("\r\n161616下载错误：" + exception2.ToString() + "\r\n");
                this.__myfileinfo.splitedNum++;
                this.__myfileinfo.fs2.Close();
                if (exception2.ToString().IndexOf("404") >= 0)
                {
                    ePrintMain.delFile(this.__myfileinfo, 4);
                    this.__myfileinfo.isError = 1;
                }
                this.myMain.addInfo(3, this.__myfileinfo, 0, "错误：" + exception2.Message);
            }
        }
    }
}

