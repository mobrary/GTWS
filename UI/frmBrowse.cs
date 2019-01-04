﻿

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TLKJ.Utils;
using TLKJ_IVS;

namespace GTWS_TASK.UI
{
    [ComVisibleAttribute(true)]
    public partial class frmIEWeb : frmWeb
    {
        private bool LOAD_LAST_FLAG = false;
        private bool LOAD_TOKEN_FLAG = false;
        private bool IS_HOME = false;
        public frmIEWeb()
        {
            InitializeComponent();
        }
        public void OpenWinUrl(String vUrl)
        {
            OpenUrl(vUrl);
        }
        private void frmWeb_Load(object sender, EventArgs e)
        {
            webBrowser1.Dock = DockStyle.Fill;

            //webBrowser1.reg.AddMessageEventListener("OpenWinUrl", OpenWinUrl);

            String cWeb = Config.GetAppSettings("WEB_URL");
            String cUrl = cWeb + "Admin/login.aspx";
            this.webBrowser1.Navigate(cUrl);
        }

        private void geckoWebBrowser1_DocumentCompleted(object sender )
        {
            String cUrl = webBrowser1.Url.AbsoluteUri;
            if (!LOAD_LAST_FLAG)
            {
                if (cUrl.IndexOf("login") > 0)
                {
                    WebJS js = new WebJS(webBrowser1.Document);
                    js.setFieldValue("user_id", INIConfig.ReadString("System", "UserID"));
                    js.setFieldValue("user_pass", INIConfig.ReadString("System", "UserPass"));
                    LOAD_LAST_FLAG = true;
                }
            }

            if ((LOAD_LAST_FLAG) && (!LOAD_TOKEN_FLAG))
            {
                if (cUrl.IndexOf("index") > 0)
                {
                    WebJS js = new WebJS(webBrowser1.Document);
                    string cUserCode = js.getFieldValue("usercode");
                    ApplicationEvent.setUserCode(cUserCode);
                    // ApplicationEvent.UserInfo.USER_CODE = cUserCode;

                    string cOrgID = js.getFieldValue("orgid");
                    //ApplicationEvent.UserInfo.ORG_ID = cOrgID;

                    string cToken = js.getFieldValue("token");
                    ApplicationEvent.Token = cToken;
                    LOAD_TOKEN_FLAG = true;
                }
            }
        }
    }
}
