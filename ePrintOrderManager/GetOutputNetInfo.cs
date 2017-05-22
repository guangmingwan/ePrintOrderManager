namespace ePrintOrderManager
{
    using System;
    using System.Management;

    public class GetOutputNetInfo
    {
        public string NetInfo()
        {
            string str = null;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration ");
            foreach (ManagementObject obj2 in searcher.Get())
            {
                str = str + obj2.GetText(TextFormat.Mof);
            }
            return str;
        }
    }
}

