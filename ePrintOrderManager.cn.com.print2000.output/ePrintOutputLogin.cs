namespace ePrintOrderManager.cn.com.print2000.output
{
    using System;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Web.Services;
    using System.Web.Services.Description;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;

    [WebServiceBinding(Name="ePrintOutputLoginSoap", Namespace="http://output.print2000.com.cn/ePrintOutputlogin"), DebuggerStepThrough, DesignerCategory("code")]
    public class ePrintOutputLogin : SoapHttpClientProtocol
    {
        public ePrintOutputLogin()
        {
            string str = ConfigurationSettings.AppSettings["ePrintOrderManager.cn.com.print2000.output.ePrintOutputLogin"];
            if (str != null)
            {
                base.Url = str + "";
            }
            else
            {
                base.Url = "http://www.c2yy.com/ePrintServer_dynamic/ePrintOutputLogin.asmx";
            }
        }

        public ePrintOutputLogin(string url)
        {
            base.Url = url;
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_AddBulletin", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _AddBulletin(int OutputKey, string[] BulletinInfo)
        {
            return (bool) base.Invoke("_AddBulletin", new object[] { OutputKey, BulletinInfo })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_AddUser", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string _AddUser(int AddWhich, int OutputKey, string[] UserInfo)
        {
            return (string) base.Invoke("_AddUser", new object[] { AddWhich, OutputKey, UserInfo })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_BeginInfo", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] _BeginInfo(string OutputHttp)
        {
            return (string[]) base.Invoke("_BeginInfo", new object[] { OutputHttp })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_CheckSoftVersion", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string _CheckSoftVersion()
        {
            return (string) base.Invoke("_CheckSoftVersion", new object[0])[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_delOrder", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public void _delOrder(int OutputKey, int[] OrderId, string[] FileName)
        {
            base.Invoke("_delOrder", new object[] { OutputKey, OrderId, FileName });
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_delOutputBulletin", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _delOutputBulletin(int OutputKey, int ID)
        {
            return (bool) base.Invoke("_delOutputBulletin", new object[] { OutputKey, ID })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_delUserFiles", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _delUserFiles(int OutputKey, string FileId)
        {
            return (bool) base.Invoke("_delUserFiles", new object[] { OutputKey, FileId })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_delUserFiles2", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _delUserFiles2(int OutputKey, string FileId, string FileName)
        {
            return (bool) base.Invoke("_delUserFiles2", new object[] { OutputKey, FileId, FileName })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_delUserInfo", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _delUserInfo(int[] UserId, int OutputKey)
        {
            return (bool) base.Invoke("_delUserInfo", new object[] { UserId, OutputKey })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_editOrderCheck", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _editOrderCheck(int id)
        {
            return (bool) base.Invoke("_editOrderCheck", new object[] { id })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_editOrderState", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _editOrderState(int id)
        {
            return (bool) base.Invoke("_editOrderState", new object[] { id })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_editOutputBulletin", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _editOutputBulletin(int OutputKey, int ID, string[] newBulletinInfo)
        {
            return (bool) base.Invoke("_editOutputBulletin", new object[] { OutputKey, ID, newBulletinInfo })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_editOutputStatement", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _editOutputStatement(int OutputKey, string newOutputStatement)
        {
            return (bool) base.Invoke("_editOutputStatement", new object[] { OutputKey, newOutputStatement })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_editUserPassword", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _editUserPassword(string NewPassword, int UserId, int OutputKey)
        {
            return (bool) base.Invoke("_editUserPassword", new object[] { NewPassword, UserId, OutputKey })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_GetFile", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string _GetFile()
        {
            return (string) base.Invoke("_GetFile", new object[0])[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_getOutputBulletin", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string _getOutputBulletin(int OutputKey)
        {
            return (string) base.Invoke("_getOutputBulletin", new object[] { OutputKey })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_getOutputSetInfo", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] _getOutputSetInfo(int OutputKey)
        {
            return (string[]) base.Invoke("_getOutputSetInfo", new object[] { OutputKey })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_GetUpdateFiles", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string _GetUpdateFiles()
        {
            return (string) base.Invoke("_GetUpdateFiles", new object[0])[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_getUserFiles", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string _getUserFiles(int OutputKey)
        {
            return (string) base.Invoke("_getUserFiles", new object[] { OutputKey })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_InsertNetInfo", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public void _InsertNetInfo(string[] strInfo)
        {
            base.Invoke("_InsertNetInfo", new object[] { strInfo });
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_OutputRoomInfo", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] _OutputRoomInfo(int OutputKey)
        {
            return (string[]) base.Invoke("_OutputRoomInfo", new object[] { OutputKey })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_OutputSendFileToUser", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _OutputSendFileToUser(string[] FileInfo)
        {
            return (bool) base.Invoke("_OutputSendFileToUser", new object[] { FileInfo })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_OutputSet", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool _OutputSet(int OutputKey, int isClose, int EnterWhich)
        {
            return (bool) base.Invoke("_OutputSet", new object[] { OutputKey, isClose, EnterWhich })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_OutputStatement", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string _OutputStatement(int OutputKey)
        {
            return (string) base.Invoke("_OutputStatement", new object[] { OutputKey })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/_UpdateInfo", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string[] _UpdateInfo()
        {
            return (string[]) base.Invoke("_UpdateInfo", new object[0])[0];
        }

        public IAsyncResult Begin_AddBulletin(int OutputKey, string[] BulletinInfo, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_AddBulletin", new object[] { OutputKey, BulletinInfo }, callback, asyncState);
        }

        public IAsyncResult Begin_AddUser(int AddWhich, int OutputKey, string[] UserInfo, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_AddUser", new object[] { AddWhich, OutputKey, UserInfo }, callback, asyncState);
        }

        public IAsyncResult Begin_BeginInfo(string OutputHttp, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_BeginInfo", new object[] { OutputHttp }, callback, asyncState);
        }

        public IAsyncResult Begin_CheckSoftVersion(AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_CheckSoftVersion", new object[0], callback, asyncState);
        }

        public IAsyncResult Begin_delOrder(int OutputKey, int[] OrderId, string[] FileName, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_delOrder", new object[] { OutputKey, OrderId, FileName }, callback, asyncState);
        }

        public IAsyncResult Begin_delOutputBulletin(int OutputKey, int ID, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_delOutputBulletin", new object[] { OutputKey, ID }, callback, asyncState);
        }

        public IAsyncResult Begin_delUserFiles(int OutputKey, string FileId, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_delUserFiles", new object[] { OutputKey, FileId }, callback, asyncState);
        }

        public IAsyncResult Begin_delUserFiles2(int OutputKey, string FileId, string FileName, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_delUserFiles2", new object[] { OutputKey, FileId, FileName }, callback, asyncState);
        }

        public IAsyncResult Begin_delUserInfo(int[] UserId, int OutputKey, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_delUserInfo", new object[] { UserId, OutputKey }, callback, asyncState);
        }

        public IAsyncResult Begin_editOrderCheck(int id, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_editOrderCheck", new object[] { id }, callback, asyncState);
        }

        public IAsyncResult Begin_editOrderState(int id, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_editOrderState", new object[] { id }, callback, asyncState);
        }

        public IAsyncResult Begin_editOutputBulletin(int OutputKey, int ID, string[] newBulletinInfo, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_editOutputBulletin", new object[] { OutputKey, ID, newBulletinInfo }, callback, asyncState);
        }

        public IAsyncResult Begin_editOutputStatement(int OutputKey, string newOutputStatement, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_editOutputStatement", new object[] { OutputKey, newOutputStatement }, callback, asyncState);
        }

        public IAsyncResult Begin_editUserPassword(string NewPassword, int UserId, int OutputKey, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_editUserPassword", new object[] { NewPassword, UserId, OutputKey }, callback, asyncState);
        }

        public IAsyncResult Begin_GetFile(AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_GetFile", new object[0], callback, asyncState);
        }

        public IAsyncResult Begin_getOutputBulletin(int OutputKey, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_getOutputBulletin", new object[] { OutputKey }, callback, asyncState);
        }

        public IAsyncResult Begin_getOutputSetInfo(int OutputKey, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_getOutputSetInfo", new object[] { OutputKey }, callback, asyncState);
        }

        public IAsyncResult Begin_GetUpdateFiles(AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_GetUpdateFiles", new object[0], callback, asyncState);
        }

        public IAsyncResult Begin_getUserFiles(int OutputKey, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_getUserFiles", new object[] { OutputKey }, callback, asyncState);
        }

        public IAsyncResult Begin_InsertNetInfo(string[] strInfo, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_InsertNetInfo", new object[] { strInfo }, callback, asyncState);
        }

        public IAsyncResult Begin_OutputRoomInfo(int OutputKey, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_OutputRoomInfo", new object[] { OutputKey }, callback, asyncState);
        }

        public IAsyncResult Begin_OutputSendFileToUser(string[] FileInfo, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_OutputSendFileToUser", new object[] { FileInfo }, callback, asyncState);
        }

        public IAsyncResult Begin_OutputSet(int OutputKey, int isClose, int EnterWhich, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_OutputSet", new object[] { OutputKey, isClose, EnterWhich }, callback, asyncState);
        }

        public IAsyncResult Begin_OutputStatement(int OutputKey, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_OutputStatement", new object[] { OutputKey }, callback, asyncState);
        }

        public IAsyncResult Begin_UpdateInfo(AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("_UpdateInfo", new object[0], callback, asyncState);
        }

        public IAsyncResult BeginDelFile(string Outputkey, string FileName, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("DelFile", new object[] { Outputkey, FileName }, callback, asyncState);
        }

        public IAsyncResult BeginKeepAlive(bool isOnline, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("KeepAlive", new object[] { isOnline }, callback, asyncState);
        }

        public IAsyncResult BeginSearchUserInfo(string[] strSearch, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("SearchUserInfo", new object[] { strSearch }, callback, asyncState);
        }

        public IAsyncResult BeginUserLogin(string strUserName, byte[] _strPassword, int OutputKey, AsyncCallback callback, object asyncState)
        {
            return base.BeginInvoke("UserLogin", new object[] { strUserName, _strPassword, OutputKey }, callback, asyncState);
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/DelFile", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool DelFile(string Outputkey, string FileName)
        {
            return (bool) base.Invoke("DelFile", new object[] { Outputkey, FileName })[0];
        }

        public bool End_AddBulletin(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public string End_AddUser(IAsyncResult asyncResult)
        {
            return (string) base.EndInvoke(asyncResult)[0];
        }

        public string[] End_BeginInfo(IAsyncResult asyncResult)
        {
            return (string[]) base.EndInvoke(asyncResult)[0];
        }

        public string End_CheckSoftVersion(IAsyncResult asyncResult)
        {
            return (string) base.EndInvoke(asyncResult)[0];
        }

        public void End_delOrder(IAsyncResult asyncResult)
        {
            base.EndInvoke(asyncResult);
        }

        public bool End_delOutputBulletin(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_delUserFiles(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_delUserFiles2(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_delUserInfo(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_editOrderCheck(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_editOrderState(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_editOutputBulletin(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_editOutputStatement(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_editUserPassword(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public string End_GetFile(IAsyncResult asyncResult)
        {
            return (string) base.EndInvoke(asyncResult)[0];
        }

        public string End_getOutputBulletin(IAsyncResult asyncResult)
        {
            return (string) base.EndInvoke(asyncResult)[0];
        }

        public string[] End_getOutputSetInfo(IAsyncResult asyncResult)
        {
            return (string[]) base.EndInvoke(asyncResult)[0];
        }

        public string End_GetUpdateFiles(IAsyncResult asyncResult)
        {
            return (string) base.EndInvoke(asyncResult)[0];
        }

        public string End_getUserFiles(IAsyncResult asyncResult)
        {
            return (string) base.EndInvoke(asyncResult)[0];
        }

        public void End_InsertNetInfo(IAsyncResult asyncResult)
        {
            base.EndInvoke(asyncResult);
        }

        public string[] End_OutputRoomInfo(IAsyncResult asyncResult)
        {
            return (string[]) base.EndInvoke(asyncResult)[0];
        }

        public bool End_OutputSendFileToUser(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool End_OutputSet(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public string End_OutputStatement(IAsyncResult asyncResult)
        {
            return (string) base.EndInvoke(asyncResult)[0];
        }

        public string[] End_UpdateInfo(IAsyncResult asyncResult)
        {
            return (string[]) base.EndInvoke(asyncResult)[0];
        }

        public bool EndDelFile(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public bool EndKeepAlive(IAsyncResult asyncResult)
        {
            return (bool) base.EndInvoke(asyncResult)[0];
        }

        public string EndSearchUserInfo(IAsyncResult asyncResult)
        {
            return (string) base.EndInvoke(asyncResult)[0];
        }

        public bool EndUserLogin(IAsyncResult asyncResult, out string[] strUserInfo)
        {
            object[] objArray = base.EndInvoke(asyncResult);
            strUserInfo = (string[]) objArray[1];
            return (bool) objArray[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/KeepAlive", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool KeepAlive(bool isOnline)
        {
            return (bool) base.Invoke("KeepAlive", new object[] { isOnline })[0];
        }

        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/SearchUserInfo", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public string SearchUserInfo(string[] strSearch)
        {
            return (string) base.Invoke("SearchUserInfo", new object[] { strSearch })[0];
        }

        [return: XmlElement("isPass")]
        [SoapDocumentMethod("http://output.print2000.com.cn/ePrintOutputlogin/UserLogin", RequestNamespace="http://output.print2000.com.cn/ePrintOutputlogin", ResponseNamespace="http://output.print2000.com.cn/ePrintOutputlogin", Use=SoapBindingUse.Literal, ParameterStyle=SoapParameterStyle.Wrapped)]
        public bool UserLogin(string strUserName, [XmlElement(DataType="base64Binary")] byte[] _strPassword, int OutputKey, out string[] strUserInfo)
        {
            object[] objArray = base.Invoke("UserLogin", new object[] { strUserName, _strPassword, OutputKey });
            strUserInfo = (string[]) objArray[1];
            return (bool) objArray[0];
        }
    }
}

