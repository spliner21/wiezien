/*
 * Klasa rozgrywki
 */

using System;
using System.Collections;
using System.Linq;
using System.Text;


namespace wiezien
{
    public class gameplay
    {
        // Tablica graczy
        public Prisoner[] gracze;

        //listy do krzyżowania
        ArrayList arrayFor1,arrayFor2;

        /* Konstruktor */
        public gameplay()
        {
        }

        /* Uzupełnienie list graczy do krzyżowania */
        public void getLists()
        {
            arrayFor1 = new ArrayList();    //inicjalizacja list
            arrayFor2 = new ArrayList();
            double mean, deviation;
            mean = countMean();         //średni wynik
            deviation = countDeviation();   //odchylenie standardowe wyniku
            double minimalfor1 = countMean() - countDeviation();  //wynik minimalny dla jednego partnera
            double minimalfor2 = countMean() + countDeviation();  //wynik minimalny dla dwóch partnerów
            for (int i = 0; i < gracze.Length; i++)     //wypełnienie list w zależności od wyniku
            {
                if (gracze[i].getResult() > minimalfor1)
                    if (gracze[i].getResult() > minimalfor2)
                        arrayFor2.Add(i);
                    else
                        arrayFor1.Add(i);
            }
        }

        /* Obliczenie odchylenia standardowego aktualnych wyników
         * @return wartość odchylenia standardowego
         */
        public double countDeviation()
        {
            double sum = 0;    // suma kwadratów
            double mean = countMean();

            for (int i = 0; i < gracze.Length; i++) //obliczenie sumy kwadratów
            {
                sum += Math.Pow(gracze[i].getResult() - mean, 2.0);
            }
            return Math.Sqrt(sum / gracze.Length);  //wynik
        }

        /* Obliczenie średniego wyniku 
         * @return wartość średniego wyniku
         */
        public double countMean()
        {
            double sum = 0;    // suma wyników
            for (int i = 0; i < gracze.Length; i++)
                sum += gracze[i].getResult();
            return sum / gracze.Length; //średni wynik
        }

        /* Mutacja całej populacji */
        public void populationMutate()
        {
            for (int i = 0; i < gracze.Length; i++)
            {
                gracze[i].mutate();
            }
        }

        /* Wyczysczenie wyników populacji */
        public void populationReset()
        {
            for (int i = 0; i < gracze.Length; ++i)
                gracze[i].resetResult();
        }

        /* Krzyżowanie całej populacji
         * @param programLog pole tekstowe loga w oknie programu
         */
        public void populationCross(System.Windows.Forms.TextBox programLog)
        {
            getLists();     //wygenerowanie list graczy do krzyżowania
            programLog.AppendText("Liczba średnich: " + arrayFor1.Count + "; ");
            programLog.AppendText("Liczba lepszych: " + arrayFor2.Count + "; "); // wyświetlenie ilości średnich (krzyżujących się 1 raz) i lepszych (krzyżujących 2 razy) graczy
            Random rand = new Random();
            ShuffleArrayList(arrayFor1);    //mieszanie tablic
            ShuffleArrayList(arrayFor2);
            int[] array1 = (int[])arrayFor1.ToArray(typeof(int));   //konwersja listy do tablicy
            int[] array2 = (int[])arrayFor2.ToArray(typeof(int));
            for (int i = 0; i < array1.Length; i += 2)  //krzyżowanie populacji średnich
            {
                if (i + 1 != array1.Length)
                    cross(gracze[array1[i]], gracze[array1[i+1]]);
                else
                    cross(gracze[array1[i]], gracze[array1[rand.Next(array1.Length - 1)]]);
            }
            for (int i = 0; i < array2.Length; i += 2)  //krzyżowanie populacji najlepszych 
            {
                if (i + 1 != array2.Length)
                    cross(gracze[array2[i]], gracze[array2[i + 1]]);
                else
                    cross(gracze[array2[i]], gracze[array2[rand.Next(array2.Length - 1)]]);
            }
            ShuffleArrayList(arrayFor2);
            int[] array2_2 = (int[])arrayFor2.ToArray(typeof(int));
            for (int i = 0; i < array2_2.Length; i += 2)
            {
                if (i + 1 != array2_2.Length)
                    cross(gracze[array2_2[i]], gracze[array2_2[i + 1]]);
                else
                    cross(gracze[array2_2[i]], gracze[array2_2[rand.Next(array2_2.Length - 1)]]);
            }
        }

        /* mieszanie tablic Arraylist
         * @param src tablica do wymieszania
         */
        public static void ShuffleArrayList(ArrayList src)
        {
            Random rnd = new Random();
            for (int i = src.Count - 1; i > 0; --i)
            {
                int position = rnd.Next(i);
                object temp = src[i];
                src[i] = src[position];
                src[position] = temp;
            }
        }

        /* krzyżowanie uwzględniające klasy
         * @param p1, p2 krzyżowane chromosomy (gracze)
         */
        public void cross(Prisoner p1, Prisoner p2)
        {
            Random rand = new Random();
            bool[] tab1 = new bool[64];
            bool[] tab2 = new bool[64];
            int tempI;
            bool temp;

            tab1 = p1.getStrategies();  // wypełnienie tablic
            tab2 = p2.getStrategies();
            tempI = rand.Next(64);
            for (int i = 0; i < tempI; ++i) // do losowego momentu (nie cała tablica)
            {
                temp = tab1[i];
                tab1[i] = tab2[i];
                tab2[i] = temp;     // zamiana wartości
            }
            p1.setStrategies(tab1);     // zapisanie zmienionych strategii
            p2.setStrategies(tab2);
        }

        /* Pojedyncza gra
         * @param p1, p2 grający gracze
         */
        public void playOnce(Prisoner p1, Prisoner p2)
        {
            bool strat1, strat2; // strategie graczy

            strat1 = p1.getCurrentStrategy();
            strat2 = p2.getCurrentStrategy();

            if (strat1 && strat2)   // obaj zdradzają
            {
                p1.saveResult(1);
                p2.saveResult(1);
            }
            else if (strat1 && !strat2) // drugi współpracuje
            {
                p1.saveResult(5);
                p2.saveResult(0);
            }
            else if (!strat1 && strat2) // pierwszy współpracuje
            {
                p1.saveResult(0);
                p2.saveResult(5);
            }
            else // obaj współpracują
            {
                p1.saveResult(3);
                p2.saveResult(3);
            }
        }

        /*  Pełna gra - kazdy gra z każdym
         * @param players - tablica graczy
         * @param myId - numer gracza, z którym ma zagrać cała reszta
         * Gracz o numerze myId gra z każdym o wyższym numerze.
         */
        public void playWithAllNext(int roundsCount, int myId = 0)
        {
            if (gracze.Length == myId + 1)
                return;
            else
            {
                for (int i = myId + 1; i < gracze.Length; i++)
                    playOnce(gracze[myId], gracze[i]);
                playWithAllNext(roundsCount, myId + 1);
                return;
            }
        }

        /* Obliczenie średnich wyników graczy
         */
        public void calculateResults()
        {
            for (int i = 0; i < gracze.Length; ++i)
                gracze[i].calculateMean();
        }
    }
}
