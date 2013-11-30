using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace wiezien
{
    public partial class MainForm : Form
    {

        //ilość graczy, gier i rund
        int playersCount, gamesCount, roundsCount;
        // instancja klasy rozgrywki
        gameplay gra = new gameplay();
        //licznik rozgrywek
        int gamesCounter = 1;

        /*
         * Konstruktor głównego okna
         */
        public MainForm()
        {
            InitializeComponent();
        }

        /*
         * opcja Zakończ w menu
         */
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * przycisk Start - rozpoczęcie gry
         */
        private void startButton_Click(object sender, EventArgs e)
        {
            // POBRANIE DANYCH
            try
            {
                playersCount = Convert.ToInt32(playersTextBox.Text);     // pobranie ilosci chromosomow
            }
            catch (FormatException)
            {
                MessageBox.Show("Wpisz poprawną liczbę.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                playersTextBox.Select();
                playersTextBox.SelectAll();
                return;
            }

            if (playersCount < 2)
            {
                MessageBox.Show("Liczba graczy musi być większa niż 1.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                playersTextBox.Select();
                playersTextBox.SelectAll();
                return;
            }

            try
            {
                gamesCount = Convert.ToInt32(gamesTextBox.Text);     // pobranie ilosci rund
            }
            catch (FormatException)
            {
                MessageBox.Show("Wpisz poprawną liczbę.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gamesTextBox.Select();
                gamesTextBox.SelectAll();
                return;
            }

            if (gamesCount < 1)
            {
                MessageBox.Show("Liczba rund musi być większa od zera.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gamesTextBox.Select();
                gamesTextBox.SelectAll();
                return;
            }

            try
            {
                roundsCount = Convert.ToInt32(roundsTextBox.Text);   // pobranie ilosci chromosomow
            }
            catch (FormatException)
            {
                MessageBox.Show("Wpisz poprawną liczbę.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roundsTextBox.Select();
                roundsTextBox.SelectAll();
                return;
            }

            if (roundsCount < 1)
            {
                MessageBox.Show("Liczba rund musi być większa lub równa 1.",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roundsTextBox.Select();
                roundsTextBox.SelectAll();
                return;
            }

            // TWORZENIE GRACZY
            gra.gracze = new Prisoner[playersCount];    //tworzenie graczy
            programLog.AppendText("Generowanie graczy... ");
            for (int i = 0; i < playersCount; i++)            
            {
                gra.gracze[i] = new Prisoner(i);
                programLog.AppendText("#");
            }
            programLog.AppendText(Environment.NewLine + "Wygenerowano " + playersCount + " graczy." + Environment.NewLine);

            // można rozpocząć grę
            // ustawienie odpowiednich kontrolek

            continueButton.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            commitButton.Enabled = true;

            startButton.Enabled = false;
            playersTextBox.Enabled = false;
            gamesTextBox.Enabled = false;
            roundsTextBox.Enabled = false;

            switch (radioButton1.Checked)
            {
                case true:
                    betterWorseComboBox.Enabled = true;
                    pointsBox.Enabled = true;
                    bestWorstComboBox.Enabled = false;
                    playersToShowBox.Enabled = false;
                    break;
                case false:
                    bestWorstComboBox.Enabled = true;
                    playersToShowBox.Enabled = true;
                    betterWorseComboBox.Enabled = false;
                    pointsBox.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        /*
         * przycisk Kontynuuj - kolejne gry między graczami
         */
        private void continueButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (automaticCheckBox.Checked)  // automatyczna rozgrywka
            {
                while (i < Convert.ToInt32(automaticTextBox.Text) && playGame())
                    i++;
            }
            else
                playGame();
        }

        /*
         * Funkcja pomocnicza, obsługująca rozgrywkę
         */
        private bool playGame()
        {
            programLog.AppendText("Rozgrywka nr " + gamesCounter + ": Trwa gra... ");
            gra.populationReset();              // wyzerowanie statystyk graczy
            gra.playWithAllNext(roundsCount);   // rozgrywka - każdy gra z każdym
            programLog.AppendText("OK. Trwa krzyżowanie... ");
            gra.populationCross(programLog);    //krzyżowanie
            programLog.AppendText("OK. Trwa mutowanie... ");
            gra.populationMutate();             //mutowanie
            programLog.AppendText("OK." + Environment.NewLine);
            gamesCounter++;
            if (gamesCount == gamesCounter - 1) // jeśli wykonano odpowiednią liczbę rozgrywek
            {
                continueButton.Enabled = false; // ustawienie odpowiednich kontrolek
                startButton.Enabled = true;
                commitButton.Enabled = true;
                playersTextBox.Enabled = true;
                gamesTextBox.Enabled = true;
                roundsTextBox.Enabled = true;

                gamesCounter = 1;
                return false;
            }
            return true;
        }

        /* 
         * Obsługa przycisku radio1
         */
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pointsBox.Enabled = true;
            betterWorseComboBox.Enabled = true;
            playersToShowBox.Enabled = false;
            bestWorstComboBox.Enabled = false;
        }

        /* 
         * Obsługa przycisku radio2
         */
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pointsBox.Enabled = false;
            betterWorseComboBox.Enabled = false;
            playersToShowBox.Enabled = true;
            bestWorstComboBox.Enabled = true;
        }

        /*
         * Obsługa przycisku Wykonaj - pokazanie wybranych statystyk
         */
        private void commitButton_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            gra.calculateResults();

            // wypełnianie listy graczy
            if (radioButton1.Checked)   // pokazanie graczy lepszych/gorszych niż dany wynik
            {
                try
                {
                    for (int i = 0; i < gra.gracze.Length; ++i)
                    {
                        if (betterWorseComboBox.Text.Equals("zbliżonym do"))
                        {
                            if (gra.gracze[i].getMean() > (Convert.ToDouble(pointsBox.Text) - 0.1) && gra.gracze[i].getMean() < (Convert.ToDouble(pointsBox.Text) + 0.1))
                                statistics.addPlayer(gra.gracze[i]);
                        }
                        if (betterWorseComboBox.Text.Equals("lepszym niż"))
                        {
                            if (gra.gracze[i].getMean() > Convert.ToDouble(pointsBox.Text))
                                statistics.addPlayer(gra.gracze[i]);
                        }
                        else if (betterWorseComboBox.Text.Equals("gorszym niż"))
                        {
                            if (gra.gracze[i].getMean() < Convert.ToDouble(pointsBox.Text))
                                statistics.addPlayer(gra.gracze[i]);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Niepoprawna liczba.",
                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pointsBox.Select();
                    pointsBox.SelectAll();
                    return;
                }
            }
            else if (radioButton2.Checked)  // wybranie najlepszych/najgorszych graczy
            {
                ArrayList list = new ArrayList();
                
                //dodanie wszystkich graczy do listy
                for (int i = 0; i < gra.gracze.Length; ++i)
                {
                    list.Add(gra.gracze[i]);
                }

                //sortowanie listy
                IComparer comparer = new prisonerComparer();
                list.Sort(comparer);    // sortowanie względem średniego wyniku
                Prisoner[] prisonerArray = (Prisoner[])list.ToArray(typeof(Prisoner)); // tablica uporządkowanych graczy

                //pobranie ilości graczy, którzy mają być wyświetleni
                int temp = 0;
                try
                {
                    temp = Convert.ToInt32(playersToShowBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Niepoprawna liczba.",
                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    playersToShowBox.Select();
                    playersToShowBox.SelectAll();
                    return;
                }

                // wyświetlanie - zależnie od warunku
                if (bestWorstComboBox.Text.Equals("najlepszym"))
                {
                    for (int i = 0; i < temp; ++i)
                        statistics.addPlayer(prisonerArray[prisonerArray.Length - i - 1]);
                }
                else if (bestWorstComboBox.Text.Equals("najgorszym"))
                {
                    for (int i = 0; i < temp; ++i)
                        statistics.addPlayer(prisonerArray[i]);
                }
            }
            statistics.ShowDialog(); //wyświetlenie okna
        }

        /*
         * Funkcja "Zapisz log" w menu - otwiera okienko zapisu pliku
         */
        private void zapiszLogDoPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        /*
         * Funkcja zapisywania pliku
         */
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.Stream file = saveFileDialog1.OpenFile(); 
            System.Text.UnicodeEncoding encoding = new System.Text.UnicodeEncoding();   // dekoder łańcucha charów do tablicy byte
            Byte[] bytes = encoding.GetBytes(programLog.Text.ToCharArray());
            file.Write(bytes, 0, programLog.Text.Length); // zapis loga do pliku file.

            file.Close();
            saveFileDialog1.Dispose();
        }
    }
}
