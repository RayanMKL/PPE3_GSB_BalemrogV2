﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace PPE3_GSB_BalemrogV2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ControlleurM1.init();
            ControlleurM2.init();
            ControlleurM3.init();

            Application.Run(new FConnex());
        }
    }
}
