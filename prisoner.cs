/* Klasa więźnia (gracza)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace wiezien
{
    public class Prisoner
    {
        // nr ID gracza
        int id;
        // tablica decyzji dla kazdej ze strategii
        bool[] strategies;
        // tablice stosowane przy doborze genu do mutowania
        double[] stratpoints;
        int[] strattimes;
        // pole przechowujace poprzednie ruchy
        int history;
        // suma wynikow gracza w rozgrywkach
        int result;
        // średni wynik gracza
        double mean;
        // licznik przeprowadzonych gier
        int counter;

        /* Konstruktor
         * @param id - id gracza
         */
        public Prisoner(int id)
        {
            Random rand = new Random();

            this.id = id;
            strategies = new bool[64];      //inicjalizacja tablic
            stratpoints = new double[64];
            strattimes = new int[64];
            for(int i=0; i<strategies.Length; ++i)
            {
                strategies[i] = (rand.Next(2).Equals(1)?true:false);    // losowo przypisuje true lub false
                stratpoints[i] = 0;
                strattimes[i] = 0;
            }
            history = rand.Next(64);    // historia jest liczbą mniejszą od 64
            result = 0;
            counter = 0;
            mean = 0.0;
        }

        /* @return ID gracza
         */
        public int getID()
        {
            return id;
        }

        /* @return wynik gracza
         */
        public int getResult()
        {
            return result;
        }


        /* resetowanie wyników gracza
         */
        public void resetResult()
        {
            result = 0;
            counter = 0;
            for (int i = 0; i < stratpoints.Length; ++i)
            {
                stratpoints[i] = 0;
                strattimes[i] = 0;
            }
        }


        /* Obliczenie sredniego wyniku gracza
         */
        public void calculateMean()
        {
            if (counter > 0)
                mean = (double)result / (double)counter;  // średni wynik rogrywek
            else
                mean = 0;
        }


        /* @return średni wynik gracza
         */
        public double getMean()
        {
            return mean;
        }


        /* @return aktualna strategia gracza
         */
        public bool getCurrentStrategy()
        {
            return strategies[history];
        }


        /* @return tablicę wszystkich strategii gracza
         */
        public bool[] getStrategies()
        {
            return strategies;
        }


        /* Ustawienie nowych strategii gracza
         * @param tablica z nowymi strategiami gracza
         */
        public void setStrategies(bool[] newSt)
        {
            if (newSt.Length >= strategies.Length)
                for (int i = 0; i < strategies.Length; ++i)
                    strategies[i] = newSt[i];
        }

        /* Zapis ruchu - aktualizacja historii (3 ostatnich ruchów)
         * res - wynik rozgrywki
         *
         * Reprezentacja historii - poszczególne bity:
         * |00|GP|GP|GP| (G - gracz, P - przeciwnik)
         * | -| 1| 2| 3| - nr ruchu (3 - ostatni ruch)
         * Ruch: 1 - zdrada, 0 - współpraca
         * 
         * Macierz wypłat: zob. wikipedia
         */
        public void saveResult(int res)
        {
            bool currStrategy = strategies[history]; //podjęta decyzja
            bool opponentStrategy = false;  //strategia przeciwnika

            if (currStrategy == true)   // gracz zdradził
            {
                if (res == 5)
                    opponentStrategy = false;
                else if (res == 1)
                    opponentStrategy = true;
            }
            else // (currStrategy == false) // gracz wspolpracuje
            {
                if (res == 3)
                    opponentStrategy = false;
                else if (res == 0)
                    opponentStrategy = true;
            }
            stratpoints[history] += res;    // dodanie ruchu do statystyk ruchów
            ++strattimes[history];
            history = history << 2;   // 2 najmlodsze bity beda przechowywac nowy ruch
            history = history & 0x3C; // wyzerowanie najstarszych i 2 najmlodszych bitow (na wszelki wypadek) (0x3C = 111100)
            int temp = 0;
            if (currStrategy)   // ustawienie swojej strategii
                temp += 0x01;
            if (opponentStrategy)   // ustawienie strategii przeciwnika
                temp += 0x02;
            history += temp;

            result += res;  // dodanie wyniku gry do ogólnego wyniku gracza
            ++counter;  // aktualizacja licznika (ilości przeprowadzonych gier)
        }

        // Funkcja mutująca chromosom
        public void mutate()
        {
            int index;
            if (getMean() > 2.5) return;    //mutujemy jedynie graczy, których średni wynik jest gorszy od 2,5
            Random rand = new Random(2);
            for (int i = 0; i < stratpoints.Length; ++i)    //obliczenie średnich wyników dla wszystkich genów
            {
                if (strattimes[i] > 0)     // zabezpieczenie przed dzieleniem przez 0
                    stratpoints[i] /= strattimes[i];
                else                       // dla nieużywanego genu ustawiamy pewność, że nie będzie mutowany (domniemanie poprawności)
                    stratpoints[i] = 6.0;
            }
            index = Array.IndexOf(stratpoints, stratpoints.Min());  // wyszukanie indeksu genu o najniższym wyniku
            strategies[index] = rand.Next().Equals(1) ? true : false;   //mutowanie z 50% prawdopodobieństwem
        }
    }
}
