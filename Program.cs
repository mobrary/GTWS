﻿using GTWS_TASK.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLKJ.Utils;

namespace TLKJ_GTWS
{
    static class Program
    {
        static System.Threading.Mutex mux;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        { //是否可以打开新进程
            bool runOne = false;

            //获取程序集Guid作为唯一标识
            Attribute AttGuid = Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(GuidAttribute));
            string cKeyGuid = ((GuidAttribute)AttGuid).Value;
            mux = new System.Threading.Mutex(true, cKeyGuid, out runOne);
            if (!runOne)
            {
                Environment.Exit(1);
            }
            else
            {
                INIConfig.setConfigFile(Application.StartupPath + @"\Config.ini");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmWebKit());
                mux.ReleaseMutex();
            }
        }
    }
}