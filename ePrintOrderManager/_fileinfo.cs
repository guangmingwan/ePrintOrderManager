namespace ePrintOrderManager
{
    using System;
    using System.IO;

    public class _fileinfo
    {
        public long[] BlockDownloadSize_Abs;
        public long[] BlockDownloadSize_init;
        public long DownloadedSize_absoluteness;
        public long DownloadedSize_initialize;
        public long DownloadedSize_lastcheck;
        public long DownloadedSize_relatively;
        public string FileId;
        public string FileName;
        public string FilePath;
        public string FileSaveSet;
        public long FileSize;
        public long[] frontSize;
        public FileStream[] fs;
        public FileStream fs2;
        public int isContinue = 0;
        public int isError = 0;
        public int isfinished = 0;
        public int noDateTime = 0;
        public Stream[] ns;
        public Stream ns2;
        public string OrderInfo;
        public int orderkey;
        public double Speed;
        public int splitedNum;
        public string[] SplitInfo;
        public int time;
    }
}

