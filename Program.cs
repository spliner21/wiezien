/* Program symulatora "Dylematu więźnia"
 * Implementacja algorytmu ewolucyjnego
 * 
 * Projekt z przedmiotu BMMSI 
 * VI semestr SSI na kierunku Informatyka na wyzdiale AEiI Politechniki Śląskiej
 * Grupa GKiO1
 * Autorzy:
 * Anna Kuśnierz
 * Tomasz Szołtysek
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace wiezien
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
            Application.Run(new MainForm());
        }
    }
}
