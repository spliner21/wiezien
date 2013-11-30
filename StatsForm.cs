using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace wiezien
{
    public partial class Statistics : Form
    {
        ArrayList list;     // lista graczy, których należy wyświetlić

        /*
         * Konstruktor
         */
        public Statistics()
        {
            InitializeComponent();
            list = new ArrayList();
        }

        /*
         * Dodaje gracza do wyświetlanej listy.
         * p - dodawany gracz
         * i - indeks gracza
         * 
         */
        public void addPlayer(Prisoner p)
        {
            players.Items.Add("Gracz nr " + p.getID() + " (" + p.getMean() + " punktów)"); // dodanie pozycji w oknie
            list.Add(p);    // dodanie gracza do listy
        }

        /*
         * Funkcja wyświetlająca w prawym oknie strategię wybranego gracza
         * (uruchamiana przy kliknięciu na dowolnego gracza w lewym oknie)
         */
        private void players_SelectedIndexChanged(object sender, EventArgs e)
        {
            strategies.Items.Clear();   // wyczyszczenie okna po poprzednim graczu

            Prisoner[] tab = (Prisoner[])list.ToArray(typeof(Prisoner));    // zrzutowanie listy na tablicę graczy
            bool[] strat = tab[players.SelectedIndex].getStrategies();      // strategia wyświetlanego gracza

            // wyświetlanie strategii
            for (int i = 0; i < strat.Length-1; ++i)
            {
                String strategy = "";   // będzie zawierać historię (poprzednie ruchy) gracza
                strategy += ((i & 32) == 0) ? "W" : "Z";
                strategy += ((i & 16) == 0) ? "W " : "Z ";
                strategy += ((i & 8) == 0) ? "W" : "Z";
                strategy += ((i & 4) == 0) ? "W " : "Z ";
                strategy += ((i & 2) == 0) ? "W" : "Z";
                strategy += ((i & 1) == 0) ? "W " : "Z ";
                strategies.Items.Add("Poprzednie ruchy: " + strategy + "\t| Strategia: " + ((strat[i] == true)?"Z":"W"));
            }
            strategies.Items.Add("Poprzednie ruchy: " + "ZZ ZZ ZZ " + "\t\t| Strategia: " + ((strat[strat.Length-1] == true) ? "Z" : "W")); // żeby było równo ;)
        }

    }
}
