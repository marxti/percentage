﻿using System;
using System.Windows.Forms;

namespace percentage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new TrayIcon();

            Application.Run();
        }
    }
}
