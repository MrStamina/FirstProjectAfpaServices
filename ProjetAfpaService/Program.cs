﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetAfpaService.Dao;
using ProjetAfpaService.Vues;

namespace ProjetAfpaService
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
            DaoProjet.Init();
            Application.Run(new Prevision());
            
        }
    }
}
