namespace ePrintOrderManager
{
    using System;
    using System.IO;
    using System.Net;

    public class UpdateDown
    {
        public string StrFileName = null;
        public string StrUrl = null;
        public int WhichUpdate = 0;

        public void down()
        {
            FileStream stream2;
            long offset = 0L;
            if (File.Exists(this.StrFileName))
            {
                stream2 = File.OpenWrite(this.StrFileName);
                offset = stream2.Length;
                stream2.Seek(offset, SeekOrigin.Current);
            }
            else
            {
                stream2 = new FileStream(this.StrFileName, FileMode.Create);
                offset = 0L;
            }
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(this.StrUrl);
                request.ServicePoint.ConnectionLimit = 50;
                if (offset > 0L)
                {
                    request.AddRange((int) offset);
                }
                Stream responseStream = request.GetResponse().GetResponseStream();
                byte[] buffer = new byte[0x400];
                int count = 0;
                for (count = responseStream.Read(buffer, 0, 0x400); count > 0; count = responseStream.Read(buffer, 0, 0x400))
                {
                    ePrintUpdate.loadingEndSize = stream2.Length;
                    stream2.Write(buffer, 0, count);
                }
                stream2.Close();
                responseStream.Close();
                Console.WriteLine("下载完成");
                ePrintUpdate.WhichUpdate = this.WhichUpdate + 1;
                if (this.WhichUpdate < ePrintUpdate.FileNum)
                {
                    ePrintUpdate.DownFile();
                }
            }
            catch (Exception exception)
            {
                if (exception.ToString().IndexOf("416") >= 0)
                {
                    ePrintUpdate.loadingEndSize = stream2.Length;
                }
                stream2.Close();
                ePrintUpdate.WhichUpdate = this.WhichUpdate + 1;
                if (this.WhichUpdate < ePrintUpdate.FileNum)
                {
                    ePrintUpdate.DownFile();
                }
            }
        }
    }
}

