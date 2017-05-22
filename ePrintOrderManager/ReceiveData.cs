namespace ePrintOrderManager
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;

    public class ReceiveData
    {
        private string _ReceiveInfo = null;
        private Socket ClientSocket;
        private int isLoginSuccess = 0;
        private byte[] ReceiveBuffer = new byte[0x400];
        private string ReceiveInfo = null;
        public string returnInfo = null;
        private IPEndPoint ServerIPE = new IPEndPoint(IPAddress.Parse("192.168.123.156"), 0x15);
        private string SocketKey;

        private void dowith()
        {
            bool flag1 = this.ReceiveInfo.Split(new char[] { '|' })[0] == "FileInfo";
        }

        public void ePrintConnect()
        {
            try
            {
                this.ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.ClientSocket.BeginConnect(this.ServerIPE, new AsyncCallback(this.ePrintEndConnect), this.ClientSocket);
            }
            catch (Exception exception)
            {
                this.returnInfo = exception.Message;
            }
        }

        private void ePrintEndConnect(IAsyncResult connectState)
        {
            try
            {
                this.ClientSocket = (Socket) connectState.AsyncState;
                this.ClientSocket.EndConnect(connectState);
                if (this.ClientSocket.Connected)
                {
                    this.ePrintReceive();
                }
            }
            catch (Exception exception)
            {
                this.returnInfo = exception.Message;
            }
        }

        private void ePrintReadData(IAsyncResult readState)
        {
            try
            {
                this.ClientSocket = (Socket) readState.AsyncState;
                int count = this.ClientSocket.EndReceive(readState);
                this.ReceiveInfo = Encoding.UTF8.GetString(this.ReceiveBuffer, 0, count);
                this._ReceiveInfo = this.ReceiveInfo;
                new Thread(new ThreadStart(this.dowith)).Start();
                this.ReceiveInfo = null;
                this.ePrintReceive();
            }
            catch (Exception exception)
            {
                this.returnInfo = exception.Message;
            }
        }

        private void ePrintReceive()
        {
            try
            {
                this.ClientSocket.BeginReceive(this.ReceiveBuffer, 0, this.ReceiveBuffer.Length, SocketFlags.None, new AsyncCallback(this.ePrintReadData), this.ClientSocket);
            }
            catch (Exception exception)
            {
                this.returnInfo = exception.Message;
            }
        }

        private void insertData()
        {
        }
    }
}

