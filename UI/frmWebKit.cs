using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TLKJ.Utils;
using TLKJ_GTWS.UI;
using TLKJ_IVS;

namespace GTWS_TASK.UI
{
    public partial class frmWebKit : Form
    {
        public ChromiumWebBrowser browser;
        private bool LOAD_LAST_FLAG = false;
        private bool LOAD_TOKEN_FLAG = false;
        private bool IS_HOME = false;
        private WebJS js = null;
        Sunisoft.IrisSkin.SkinEngine iskin = new Sunisoft.IrisSkin.SkinEngine();

        public void InitBrowser()
        {
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            CefSettings cfg = new CefSettings();
            Cef.Initialize(cfg);
            browser = new ChromiumWebBrowser();
            js = new WebJS(browser);
            //交互数据                                           
            browser.RegisterJsObject("WinForm", js, new CefSharp.BindingOptions() { CamelCaseJavascriptNames = false });
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            iskin.SkinFile = "skins/PageColor2.ssk";
        }

        public frmWebKit()
        {
            InitializeComponent();
            InitBrowser();
        }
        public void OpenUrl(String vUrl)
        {
            String cWeb = Config.GetAppSettings("WEB_URL");
            String cUrl = cWeb + vUrl;
            if (cUrl.IndexOf("?") == -1)
            {
                cUrl = cUrl + "?TOKEN=" + ApplicationEvent.Token;
            }
            else
            {
                cUrl = cUrl + "&TOKEN=" + ApplicationEvent.Token;
            }
            NameValueCollection QueryString = AppManager.ParseUrl(cUrl);
            int iTYPEID = StringEx.getInt(QueryString.Get("TYPEID"));
            String cCameraCode = StringEx.getString(QueryString.Get("CAMERACODE"));
            Form vDialog = null;
            if (iTYPEID == 1)
            {
                frmWebKit vItem = new frmWebKit();
                vItem.browser.Load(cUrl);
                vDialog = vItem;
            }
            else if (iTYPEID == 11)
            {
                frmIEWeb vItem = new frmIEWeb();
                vItem.Browser.Navigate(cUrl);
                vDialog = vItem;
            }
            else if (iTYPEID == 3)
            {
                frmViewer vItem = new frmViewer();
                vItem.ActiveCameraCode = cCameraCode;
                vDialog = vItem;
            }
            if (vDialog != null)
            {
                log4net.WriteLogFile(cUrl);
                vDialog.ShowInTaskbar = false;
                vDialog.ShowDialog();
            }
        }

        private void frmWebKit_Load(object sender, EventArgs e)
        {  
            String cWeb = Config.GetAppSettings("WEB_URL");
            String cUrl = cWeb + "Admin/login.aspx";
            String cORG_ID = INIConfig.ReadString("Config", "ORG_ID");
            if (cUrl.IndexOf("?") > -1)
            {
                cUrl = cUrl + "&ORG_ID=" + cORG_ID;
            }
            else
            {
                cUrl = cUrl + "?ORG_ID=" + cORG_ID;
            }
            this.browser.Load(cUrl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            js.setFieldValue("user_id", "cggt");
        }
    }
}
