﻿using System;
using System.Windows.Forms;

namespace RGR
{
    static class Register_controller
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Autorisation page = new Autorisation();
            Application.Run(page);
        }
    }
}
