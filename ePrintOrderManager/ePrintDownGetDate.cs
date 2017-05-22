namespace ePrintOrderManager
{
    using System;
    using System.IO;
    using System.Net;

    public class ePrintDownGetDate
    {
        public string FileName;
        public string FilePath;
        public string FileSaveSet;
        public long FileSize;

        public void beginGetDate(string strUri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create(strUri);
                request.Pipelined = true;
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                WebHeaderCollection headers = response.Headers;
                this.FilePath = request.Address.ToString();
                this.FileSize = Convert.ToInt64(headers["Content-Length"]);
                response.Close();
                this.FileName = this.FilePath.Substring(this.FilePath.LastIndexOf("/") + 1);
                FileStream stream = new FileStream(this.FileSaveSet + @"\" + this.FileName, FileMode.Create);
                stream.Seek(this.FileSize - 1L, SeekOrigin.Current);
                byte[] buffer = new byte[1];
                stream.Write(buffer, 0, 1);
                stream.Close();
            }
            catch
            {
                try
                {
                    new ePrintMain().downFile();
                }
                catch (Exception exception)
                {
                    Console.Write("\n\ndown1111实例化ePrintMain出错" + exception.ToString() + "\n\n");
                }
            }
        }
    }
}

