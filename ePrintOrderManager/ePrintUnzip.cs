namespace ePrintOrderManager
{
    using Microsoft.Win32;
    using System;
    using System.Diagnostics;
    using System.IO;

    public class ePrintUnzip
    {
        public string zipFilePath = null;

        public void Unzip()
        {
            string path = this.zipFilePath.Substring(0, this.zipFilePath.Length - 3);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\ePrint\OutputManager", true);
            if ((key != null) && (key.GetValue("AutoZip") != null))
            {
                string str2 = "x ";
                string[] strArray = key.GetValue("AutoZip").ToString().Split(new char[] { '|' });
                if (strArray[1] == "1")
                {
                    str2 = str2 + "-o+ ";
                }
                RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(@"WinRAR\shell\open\command", true);
                if ((key2 != null) && (key2.GetValue("") != null))
                {
                    int index = key2.GetValue("").ToString().IndexOf("WinRAR.exe");
                    string str3 = key2.GetValue("").ToString().Substring(1, index + 9);
                    if (File.Exists(str3))
                    {
                        Console.Write("\n\n\n" + str3 + " " + str2 + " " + this.zipFilePath + "\\\n\n\n");
                        ProcessStartInfo startInfo = new ProcessStartInfo(str3, str2 + " \"" + this.zipFilePath + "\" \"" + path + "\\\"");
                        if (strArray[3] == "1")
                        {
                            startInfo.WindowStyle = ProcessWindowStyle.Normal;
                        }
                        else
                        {
                            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        }
                        Process.Start(startInfo);
                    }
                }
            }
        }
    }
}

