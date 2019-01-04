using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TLKJ.Utils;
using System.Data;
using System.Windows.Forms;
using CefSharp.WinForms;
using System.Threading.Tasks;

namespace TLKJ_IVS
{
    public class WebJS
    {
        private HtmlDocument vHtml;
        private ChromiumWebBrowser vChrome;
        public WebJS(ChromiumWebBrowser vDoc)
        {
            vChrome = vDoc;
            vHtml = null;
        }

        public WebJS(HtmlDocument vDoc)
        {
            vHtml = vDoc;
            vChrome = null;
        }

        private HtmlElement getHtmlElement(String cKeyID)
        {
            if (vHtml != null)
            {
                return vHtml.GetElementById(cKeyID);
            }
            else
            {
                return null;
            }
        }

        ///// <summary>
        ///// 根据ID获取数据信息。
        ///// </summary>
        ///// <param name="cKeyID"></param>
        ///// <returns></returns>
        public String getFieldValue(String cField)
        {
            //vChrome.GetBrowser().MainFrame.
            //    GeckoElement voGecko = getGeckoElement(cField);
            //    if (voGecko != null)
            //    {
            //        if (voGecko.Attributes["value"] != null)
            //        {
            //            return StringEx.getString(voGecko.Attributes["value"].TextContent);
            //        }
            //    }

            HtmlElement voHtml = getHtmlElement(cField);
            if (voHtml != null)
            {
                return StringEx.getString(voHtml.GetAttribute("value"));
            }

            return null;
        }

        public bool setFieldValue(String cField, String cKeyValue)
        {
            try
            {
                runJS("setFormValue('" + cField + "','" + cKeyValue + "')");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void runJS(String cScript)
        {
            if (vChrome != null)
            {
                vChrome.GetBrowser().MainFrame.ExecuteJavaScriptAsync(cScript);              
            }

            if (vHtml != null)
            {
                vHtml.InvokeScript(cScript);
            }
        }

        public String getJSValue(String cScript)
        {
            if (vChrome != null)
            {
                Task<CefSharp.JavascriptResponse> t = vChrome.GetBrowser().MainFrame.EvaluateScriptAsync(cScript);
                t.Wait();
                if (t.Result.Result != null)
                {
                    return StringEx.getString(t.Result);
                }
            }

            if (vChrome == null)
            {
                Object objRet = vHtml.InvokeScript(cScript);
                if (objRet != null)
                {
                    return StringEx.getString(objRet);
                }
            }

            return null;
        }
    }
}
