namespace ePrintOrderManager
{
    using System;
    using System.IO;
    using System.Net;
    using System.Threading;

    public class ePrintDown
    {
        private long downedPos;
        private ePrintOrderManager.ePrintLog ePrintLog = new ePrintOrderManager.ePrintLog();
        public string FileName = null;
        public string FileSaveSet = null;
        public long lEndPos = 0L;
        public long lStartPos = 0L;
        public _fileinfo myfileinfo;
        private ePrintMain myMain;
        private byte[] nbytes = new byte[0x400];
        private HttpWebRequest request;
        public string StrDownPath;
        private string strResponse = null;
        public string StrSavePath;
        public int which;

        public void down()
        {
            _fileinfo myfileinfo = this.myfileinfo;
            try
            {
                myfileinfo.SplitInfo[this.which] = null;
            }
            catch
            {
                myfileinfo.splitedNum = 0;
                ePrintMain.StopDown(myfileinfo);
                myfileinfo.isError = 2;
                Thread.CurrentThread.Abort();
            }
            this.StrSavePath = this.FileSaveSet + @"\" + this.FileName;
            if (File.Exists(this.StrSavePath))
            {
                myfileinfo.fs[this.which] = File.Open(this.StrSavePath, FileMode.Open, FileAccess.Write, FileShare.Write);
                myfileinfo.fs[this.which].Seek(this.lStartPos, SeekOrigin.Current);
            }
            else
            {
                myfileinfo.fs[this.which] = new FileStream(this.StrSavePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
                this.lStartPos = 0L;
            }
            try
            {
                string[] strArray;
                IntPtr ptr;
                this.request = (HttpWebRequest) WebRequest.Create(this.StrDownPath);
                this.request.AllowAutoRedirect = true;
                this.request.Timeout = 0x1388;
                this.request.Accept = "*/*";
                this.request.Headers.Add("Pragma:no-cache");
                this.request.Headers.Add("Cache-Control:no-cache");
                this.request.Headers.Add("UserAgent:Mozilla/4.0 (compatible; MSIE 5.00; Windows 98)");
                this.request.ServicePoint.ConnectionLimit = 50;
                if (this.lStartPos > 0L)
                {
                    this.request.AddRange((int) this.lStartPos);
                }
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "up,";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + DateTime.Now.ToString() + ",";
                string str = strArray[(int) ptr];
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = str + this.request.Method + " " + this.request.Address.LocalPath + " HTTP/" + this.request.ProtocolVersion.ToString() + "|";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "up,";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + DateTime.Now.ToString() + ",";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "Host : " + this.request.Address.Host + "|";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "up,";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + DateTime.Now.ToString() + ",";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "RequestUri : " + this.request.RequestUri.ToString() + "|";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "up,";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + DateTime.Now.ToString() + ",";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "IdleSince : " + this.request.ServicePoint.IdleSince.ToString() + "|";
                for (int i = 0; i < this.request.Headers.Count; i++)
                {
                    (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "up,";
                    (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + DateTime.Now.ToString() + ",";
                    str = strArray[(int) ptr];
                    (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = str + this.request.Headers.GetKey(i).ToString() + " : " + this.request.Headers[i].ToString().Replace(",", " ") + "|";
                }
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "｜";
                this.request.BeginGetResponse(new AsyncCallback(this.ResponseCallBack), this.request);
            }
            catch (Exception exception)
            {
                Console.Write(string.Concat(new object[] { "\n", this.which, "块下载过程中出现错误:", exception.ToString(), "\n" }));
                try
                {
                    myfileinfo.fs[this.which].Close();
                }
                catch (Exception exception2)
                {
                    Console.Write("\n\ndown1222实例化ePrintMain出错" + exception2.ToString() + "\n\n");
                }
            }
        }

        private void ReadCallBack(IAsyncResult backState)
        {
            int count = 0;
            _fileinfo myfileinfo = this.myfileinfo;
            myfileinfo.ns[this.which] = (Stream) backState.AsyncState;
            count = myfileinfo.ns[this.which].EndRead(backState);
            if ((count > 0) && (this.downedPos < this.lEndPos))
            {
                myfileinfo.fs[this.which].Write(this.nbytes, 0, count);
                this.downedPos += count;
                myfileinfo.BlockDownloadSize_Abs[this.which] = this.downedPos;
                ePrintMain.viewdownedSize[this.which] = this.downedPos;
                myfileinfo.ns[this.which].BeginRead(this.nbytes, 0, this.nbytes.Length, new AsyncCallback(this.ReadCallBack), myfileinfo.ns[this.which]);
            }
            else
            {
                myfileinfo.ns[this.which].Close();
                Console.Write(string.Concat(new object[] { DateTime.Now.ToString(), "：", this.which, "块完成\r\n" }));
                myfileinfo.splitedNum--;
                myfileinfo.fs[this.which].Close();
                this.myMain.addInfo(2, myfileinfo, this.which, "该块完成数据接收，已关闭!");
            }
        }

        private void ResponseCallBack(IAsyncResult backState)
        {
            this.downedPos = this.lStartPos;
            _fileinfo myfileinfo = this.myfileinfo;
            try
            {
                string[] strArray;
                IntPtr ptr;
                this.request = (HttpWebRequest) backState.AsyncState;
                WebResponse response = this.request.EndGetResponse(backState);
                for (int i = 0; i < response.Headers.Count; i++)
                {
                    (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "down,";
                    (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + DateTime.Now.ToString() + ",";
                    string str = strArray[(int) ptr];
                    (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = str + response.Headers.GetKey(i) + " : " + response.Headers[i].Replace(",", " ") + "|";
                }
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "｜";
                myfileinfo.ns[this.which] = response.GetResponseStream();
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "ok,";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + DateTime.Now.ToString() + ",";
                (strArray = myfileinfo.SplitInfo)[(int) (ptr = (IntPtr) this.which)] = strArray[(int) ptr] + "开始接受数据!|｜";
                if (ePrintMain.ActionWhich >= 0)
                {
                    this.myMain.getRequestResponseInfo(myfileinfo, ePrintMain.ActionWhich);
                }
                myfileinfo.splitedNum++;
                Console.Write(myfileinfo.splitedNum.ToString());
                myfileinfo.ns[this.which].BeginRead(this.nbytes, 0, this.nbytes.Length, new AsyncCallback(this.ReadCallBack), myfileinfo.ns[this.which]);
            }
            catch (WebException exception)
            {
                Console.WriteLine(this.which.ToString() + "块1WebException raised!!!");
                Console.WriteLine("\n{0}", exception.Message);
                Console.WriteLine("\n{0}", exception.Status);
                try
                {
                    this.myMain.addInfo(3, myfileinfo, this.which, "错误：" + exception.Message);
                    if (((exception.Message.IndexOf("未找到") >= 0) || (exception.Message.IndexOf("错误的请求") >= 0)) || (exception.Message.IndexOf("Not Found") >= 0))
                    {
                        ePrintMain.StopDown(myfileinfo);
                        ePrintMain.delFile(myfileinfo, 4);
                        myfileinfo.isError = 1;
                    }
                    else if ((((exception.Message.IndexOf("基础连接已经关闭") >= 0) || (exception.Message.IndexOf("无法访问已关闭的文件") >= 0)) || ((exception.Message.IndexOf("does not support concurrent") >= 0) || (exception.Message.IndexOf("connection was closed") >= 0))) || ((exception.Message.IndexOf("access a closed file") >= 0) || (exception.Message.IndexOf("Requested Range Not Satisfiable") >= 0)))
                    {
                        myfileinfo.splitedNum = 0;
                        ePrintMain.StopDown(myfileinfo);
                        myfileinfo.isError = 2;
                        Thread.CurrentThread.Abort();
                    }
                    else if (exception.Message.IndexOf("已关闭的文件") >= 0)
                    {
                        Thread.CurrentThread.Abort();
                    }
                    else
                    {
                        this.ePrintLog.WriteLog("WebException(ePrintDown)第 " + this.which.ToString() + " 块重新下载" + exception.ToString());
                        ePrintMain.StopDown(myfileinfo);
                        myfileinfo.isError = 2;
                        Thread.CurrentThread.Abort();
                    }
                }
                catch (Exception exception2)
                {
                    Console.Write("\n\ndown1333实例化ePrintMain出错" + exception2.ToString() + "\n\n");
                }
            }
            catch (Exception exception3)
            {
                Console.WriteLine("Exception raised!");
                Console.WriteLine("Source : " + exception3.Source);
                Console.WriteLine("Message : " + exception3.Message);
                try
                {
                    if (((exception3.Message.IndexOf("无法访问已关闭的文件") >= 0) || (exception3.Message.IndexOf("access a closed file") >= 0)) || (exception3.Message.IndexOf("not set to an instance of an object") >= 0))
                    {
                        myfileinfo.splitedNum = 0;
                        ePrintMain.StopDown(myfileinfo);
                        myfileinfo.isError = 2;
                        Thread.CurrentThread.Abort();
                    }
                    else
                    {
                        this.ePrintLog.WriteLog("Exception(ePrintDown)第 " + this.which.ToString() + " 块重新下载" + exception3.ToString());
                        ePrintMain.StopDown(myfileinfo);
                        myfileinfo.isError = 2;
                        Thread.CurrentThread.Abort();
                    }
                }
                catch (Exception exception4)
                {
                    Console.Write("\n\ndown1444实例化ePrintMain出错" + exception4.ToString() + "\n\n");
                }
            }
        }
    }
}

