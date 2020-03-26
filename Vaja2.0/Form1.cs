using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaja2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random(); /// random
        int MAX_globina = 1; /// do katere globine gremo
        int st_praznih = 9; // koliko mest je se praznih
        public enum Igralec
        {
            /// znaki za igralce
            X, O
        }

        Igralec trenutniIgralec;

        int[,] tabela = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }; /// moje polje kjer bomo devali X O
        // X =1; O=2;

        int Igralec_Zmage = 0, AI_Zmage = 0;
        bool zmaga_igralca = false; // ce je igralec zmagal

        /// GUMBI ZA IZBIRP TEZAVNOSTI OZ GLOBINE
        private void radioButton1_Click(object sender, EventArgs e)
        {
            MAX_globina = 1;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            MAX_globina = 2;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            MAX_globina = 3;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            MAX_globina = 4;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            MAX_globina = 5;
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            MAX_globina = 6;
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            MAX_globina = 7;
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            MAX_globina = 8;
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            MAX_globina = 9;
        }
    
        /// GUMBI KO IZBEREM POLJE KAMOR BOM STISNO OZ DAL KRIZEC
        private void button1_Click(object sender, EventArgs e)
        {
            if (tabela[0, 0] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button1.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button1.Enabled = false; /// da ga nemores ponovno stisnet
                button1.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[0, 0] = 1;
                st_praznih--;

                ai_z_minimax();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabela[0, 1] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button2.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button2.Enabled = false; /// da ga nemores ponovno stisnet
                button2.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[0, 1] = 1;
                st_praznih--;

                ai_z_minimax();
                //MessageBox.Show("Tabela: " + tabela[0, 1] + " max_globina: " + MAX_globina);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabela[0, 2] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button3.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button3.Enabled = false; /// da ga nemores ponovno stisnet
                button3.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[0, 2] = 1;
                st_praznih--;

                ai_z_minimax();
                //MessageBox.Show("Tabela: " + tabela[0, 2] + " max_globina: " + MAX_globina);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabela[1, 0] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button4.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button4.Enabled = false; /// da ga nemores ponovno stisnet
                button4.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[1, 0] = 1;
                st_praznih--;

                ai_z_minimax();
                //MessageBox.Show("Tabela: " + tabela[1, 0] + " max_globina: " + MAX_globina);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tabela[1, 1] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button5.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button5.Enabled = false; /// da ga nemores ponovno stisnet
                button5.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[1, 1] = 1;
                st_praznih--;

                ai_z_minimax();
                //MessageBox.Show("Tabela: " + tabela[1, 1] + " max_globina: " + MAX_globina);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabela[1, 2] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button6.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button6.Enabled = false; /// da ga nemores ponovno stisnet
                button6.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[1, 2] = 1;
                st_praznih--;

                ai_z_minimax();
                //MessageBox.Show("Tabela: " + tabela[1, 2] + " max_globina: " + MAX_globina);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tabela[2, 0] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button7.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button7.Enabled = false; /// da ga nemores ponovno stisnet
                button7.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[2, 0] = 1;
                st_praznih--;
                //MessageBox.Show("Izracun: " + izracun_ocene(tabela));
                ai_z_minimax();
                //MessageBox.Show("Tabela: " + tabela[2, 0] + " max_globina: " + MAX_globina);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tabela[2, 1] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button8.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button8.Enabled = false; /// da ga nemores ponovno stisnet
                button8.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[2, 1] = 1;
                st_praznih--;

                ai_z_minimax();
                //izpis_polja(tabela);
                //MessageBox.Show("Tabela: " + tabela[2, 1] + " max_globina: " + MAX_globina);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tabela[2, 2] == 0)
            {
                trenutniIgralec = Igralec.X; /// nastavi igralca na X
                button9.Text = trenutniIgralec.ToString(); // spremenim text gumba na X
                button9.Enabled = false; /// da ga nemores ponovno stisnet
                button9.BackColor = System.Drawing.Color.Cyan; /// spremenim barvo gumba
                tabela[2, 2] = 1;
                st_praznih--;

                ai_z_minimax();
                //MessageBox.Show("Tabela: " + tabela[2, 2] + " max_globina: " + MAX_globina);
            }
        }

        /// funkcija ki izpisuje polje
        private void izpis_polja(int[,]a) {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    MessageBox.Show(" " + a[i, j]);
                }
            }
        }

        // funkcija ki na random izbira polja
        /*
        private void ai_move() {
            //preveri_zmaga();
            preveri_zmaga(tabela);
            if (zmaga_igralca) { zmaga_igralca = false; return; }
            bool pogoj = false; /// da se vrti v loop dokler nima prave cifre
            if (st_praznih == 0) { resetGame(); return; }
            do
            {
                int x = rnd.Next(3);
                int y = rnd.Next(3);
                if (tabela[x, y] == 0)
                {
                    trenutniIgralec = Igralec.O; /// nastavi igralca na O
                    if (x == 0 && y == 0)
                    {
                        button1.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button1.Enabled = false; /// da ga nemores ponovno stisnet
                        button1.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[0, 0] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                    else if (x == 0 && y == 1)
                    {
                        button2.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button2.Enabled = false; /// da ga nemores ponovno stisnet
                        button2.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[0, 1] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                    else if (x == 0 && y == 2)
                    {
                        button3.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button3.Enabled = false; /// da ga nemores ponovno stisnet
                        button3.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[0, 2] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                    else if (x == 1 && y == 0)
                    {
                        button4.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button4.Enabled = false; /// da ga nemores ponovno stisnet
                        button4.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[1, 0] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                    else if (x == 1 && y == 1)
                    {
                        button5.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button5.Enabled = false; /// da ga nemores ponovno stisnet
                        button5.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[1, 1] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                    else if (x == 1 && y == 2)
                    {
                        button6.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button6.Enabled = false; /// da ga nemores ponovno stisnet
                        button6.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[1, 2] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                    else if (x == 2 && y == 0)
                    {
                        button7.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button7.Enabled = false; /// da ga nemores ponovno stisnet
                        button7.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[2, 0] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                    else if (x == 2 && y == 1)
                    {
                        button8.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button8.Enabled = false; /// da ga nemores ponovno stisnet
                        button8.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[2, 1] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                    else if (x == 2 && y == 2)
                    {
                        button9.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                        button9.Enabled = false; /// da ga nemores ponovno stisnet
                        button9.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                        tabela[2, 2] = 2;
                        st_praznih--;
                        pogoj = true;
                    }
                }
            } while (!pogoj);

            //preveri_zmaga();
            preveri_zmaga(tabela);

        }
        */

        // funkcija ki vrne gumbe v prvotno stanje ko se zakluci igra
        private void resetGame()
        {
            /// vse gumbe v prvotno stanje
            button1.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button1.Text = ""; /// nastavim text nazaj na vprasaj
            button1.BackColor = default(Color); /// Barvo nazaj na default
            tabela[0, 0] = 0; // tabelo spraznimo

            button2.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button2.Text = ""; /// nastavim text nazaj na vprasaj
            button2.BackColor = default(Color); /// Barvo nazaj na default
            tabela[0, 1] = 0; // tabelo spraznimo

            button3.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button3.Text = ""; /// nastavim text nazaj na vprasaj
            button3.BackColor = default(Color); /// Barvo nazaj na default
            tabela[0, 2] = 0; // tabelo spraznimo

            button4.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button4.Text = ""; /// nastavim text nazaj na vprasaj
            button4.BackColor = default(Color); /// Barvo nazaj na default
            tabela[1, 0] = 0; // tabelo spraznimo

            button5.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button5.Text = ""; /// nastavim text nazaj na vprasaj
            button5.BackColor = default(Color); /// Barvo nazaj na default
            tabela[1, 1] = 0; // tabelo spraznimo

            button6.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button6.Text = ""; /// nastavim text nazaj na vprasaj
            button6.BackColor = default(Color); /// Barvo nazaj na default
            tabela[1, 2] = 0; // tabelo spraznimo
            
            button7.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button7.Text = ""; /// nastavim text nazaj na vprasaj
            button7.BackColor = default(Color); /// Barvo nazaj na default
            tabela[2, 0] = 0; // tabelo spraznimo

            button8.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button8.Text = ""; /// nastavim text nazaj na vprasaj
            button8.BackColor = default(Color); /// Barvo nazaj na default
            tabela[2, 1] = 0; // tabelo spraznimo

            button9.Enabled = true; /// spremenim nazaj da jih lahko stisnem
            button9.Text = ""; /// nastavim text nazaj na vprasaj
            button9.BackColor = default(Color); /// Barvo nazaj na default
            tabela[2, 2] = 0; // tabelo spraznimo

            st_praznih = 9; // damo nazaj na 9

        }
        private void preveri_zmaga(int[,] tabela)
        {
            /// preverjamo ce je kdo zmagal
            /// najprej za igralca

            if(tabela[0,0] ==1 && tabela[0,1] == 1 && tabela[0,2] == 1 
                || tabela[1, 0] == 1 && tabela[1, 1] == 1 && tabela[1, 2] == 1
                || tabela[2, 0] == 1 && tabela[2, 1] == 1 && tabela[2, 2] == 1
                || tabela[0, 0] == 1 && tabela[1, 0] == 1 && tabela[2, 0] == 1 
                || tabela[0, 1] == 1 && tabela[1, 1] == 1 && tabela[2, 1] == 1
                || tabela[0, 2] == 1 && tabela[1, 2] == 1 && tabela[2, 2] == 1
                || tabela[0, 0] == 1 && tabela[1, 1] == 1 && tabela[2, 2] == 1
                || tabela[0, 2] == 1 && tabela[1, 1] == 1 && tabela[2, 0] == 1)
            {
                // igralec je zmagal
                MessageBox.Show("Zmaga igralca"); /// napisemo kdo je zmagal
                Igralec_Zmage++; /// povecamo stevilo zmag
                label1.Text = "Igralec - " + Igralec_Zmage; // spremenimo napis
                zmaga_igralca = true;
                resetGame(); ///  znova zazenemo igro
            }
            if (tabela[0, 0] == 2 && tabela[0, 1] == 2 && tabela[0, 2] == 2
                || tabela[1, 0] == 2 && tabela[1, 1] == 2 && tabela[1, 2] == 2
                || tabela[2, 0] == 2 && tabela[2, 1] == 2 && tabela[2, 2] == 2
                || tabela[0, 0] == 2 && tabela[1, 0] == 2 && tabela[2, 0] == 2
                || tabela[0, 1] == 2 && tabela[1, 1] == 2 && tabela[2, 1] == 2
                || tabela[0, 2] == 2 && tabela[1, 2] == 2 && tabela[2, 2] == 2
                || tabela[0, 0] == 2 && tabela[1, 1] == 2 && tabela[2, 2] == 2
                || tabela[0, 2] == 2 && tabela[1, 1] == 2 && tabela[2, 0] == 2)
            {
                /// zmaga AI
                MessageBox.Show("Zmaga AI");
                AI_Zmage++;
                label2.Text = "AI - " + AI_Zmage;
                resetGame();
            }
        }

        /*
            ugotovit mores kak bos naredil premik
            lahko bi ga mel kot eno stevilko med 0 in 8 mogoce da pol ves kateri gumb stisnet
            ker ce si polje posilas pol tezko ugotovis kateri gumb rabis
         */

        // minimax
        /*
         private (int, int?) minimax(int[,]polje, int igralec_poteza, int preostala_globina)
        {
            //var rezultat;
            int[,] kopija = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            //polje.CopyTo(kopija, 0);
            //int[,] kopija = polje.Clone() as int[,];
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    kopija[i, j] = polje[i, j];
                }
            }
            int ocena, r_ocena;
            int temp, m_poteza = 0;
            int? poteza;
            int? r_poteza; /// med 0 in 9 ... ce je null je nespremenjeno ostale stevilke so gumbi
            if (preostala_globina <= 0 || je_list(kopija)) { return (izracun_ocene(kopija), null); }
            if (igralec_poteza == 2) { ocena = int.MinValue; temp = 1; } /// pomeni da je max
            else { ocena = int.MaxValue; temp = 2; } // na potezi min igralec

            //poteza = 0;
            poteza = null;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    /// ce je polje prosto
                    if (kopija[i, j] == 0) {
                        if (i == 0 && j == 0) { m_poteza = 0; }
                        else if (i == 0 && j == 1) { m_poteza = 1; }
                        else if (i == 0 && j == 2) { m_poteza = 2; }
                        else if (i == 1 && j == 0) { m_poteza = 3; }
                        else if (i == 1 && j == 1) { m_poteza = 4; }
                        else if (i == 1 && j == 2) { m_poteza = 5; }
                        else if (i == 2 && j == 0) { m_poteza = 6; }
                        else if (i == 2 && j == 1) { m_poteza = 7; }
                        else if (i == 2 && j == 2) { m_poteza = 8; }
                        kopija[i, j] = igralec_poteza;
                        var rezultat = minimax(kopija, temp, preostala_globina - 1); 
                        r_ocena = rezultat.Item1; 
                        r_poteza = rezultat.Item2; 
                        kopija[i, j] = 0;

                        if (r_ocena > ocena && igralec_poteza == 2 || r_ocena < ocena && igralec_poteza == 1) {
                            ocena = r_ocena;

                            poteza = m_poteza;

                        }
                    }
                }
            }
            
            return (ocena, poteza);

        }
        */
        struct poteza {
            public int x, y;
        }

        /// zamenjat mores BESTMOVE BESTSCORE SCORE
        private int Bestmove() {
            // AI na potezi
            int bestScore = int.MinValue; /// najboljsa poteza je trenutno najmanjsa (iscemo najvecjo)
            int m_poteza = 0;
            poteza poteza; // si shranimo koordinate kam smo dali O
            poteza.x = 0;
            poteza.y = 0;
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    // Ali je polje sploh na voljo
                    if (tabela[i,j] == 0)
                    {
                        // je na voljo
                        tabela[i,j] = 2; // damo na 2 to je vrednost racunalnika
                        int score = moj_minimax(tabela, 0, false); // ponovno poklicemo minimax algoritem
                        tabela[i,j] = 0; // nastavimo nazaj na 0 da popravimo na originalno postavitev
                        if (score > bestScore)
                        {   
                            // ce je trenutna vrednost boljsa od najboljse vrednosti si shranimo
                            bestScore = score;
                            poteza.x = i;
                            poteza.y = j;
                        }
                    }
                }
            }

            i = poteza.x;
            j = poteza.y;
            // pogledamo katera poteza je bla da vemo kaj more AI stisnet
            if (i == 0 && j == 0) { m_poteza = 0; }
            else if (i == 0 && j == 1) { m_poteza = 1; }
            else if (i == 0 && j == 2) { m_poteza = 2; }
            else if (i == 1 && j == 0) { m_poteza = 3; }
            else if (i == 1 && j == 1) { m_poteza = 4; }
            else if (i == 1 && j == 2) { m_poteza = 5; }
            else if (i == 2 && j == 0) { m_poteza = 6; }
            else if (i == 2 && j == 1) { m_poteza = 7; }
            else if (i == 2 && j == 2) { m_poteza = 8; }

            return m_poteza; // vrnemo
        }

        private int moj_minimax(int[,]polje, int globina, bool Je_Max) {
            
            int test = zmaga(polje); // pogledamo ce je kdo zmagal
            if (test != 2) {
                // ce ni 2 je zmagal ali rac ali AI
                return test;
                //preveri_zmaga(polje);
            }
            // ne pomaga
            if (globina == MAX_globina-1 || je_list(polje)) {
                return izracun_ocene(polje); // ce smo presegli globino ali pa smo list
            }

            if (Je_Max)
            { 
                // ce smo MAX smo rac
                int bestScore = int.MinValue;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Je na voljo
                        if (polje[i, j] == 0)
                        {
                            polje[i, j] = 2;
                            int score = moj_minimax(polje, globina + 1, false);
                            polje[i, j] = 0;
                            
                            if (score > bestScore) { bestScore = score; }
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                /// smo oseba iscemo min vrednost
                int bestScore = int.MaxValue; // nastavimo na najvecjo mozno
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        // Je na voljo
                        if (polje[i, j] == 0)
                        {
                            polje[i, j] = 1;
                            int score = moj_minimax(polje, globina + 1, true);
                            polje[i, j] = 0;
                            if (score < bestScore) { bestScore = score; }
                        }
                    }
                }
                return bestScore;
            }
        }

        private int zmaga(int[,] tabela) {
            if (tabela[0, 0] == 1 && tabela[0, 1] == 1 && tabela[0, 2] == 1
                || tabela[1, 0] == 1 && tabela[1, 1] == 1 && tabela[1, 2] == 1
                || tabela[2, 0] == 1 && tabela[2, 1] == 1 && tabela[2, 2] == 1
                || tabela[0, 0] == 1 && tabela[1, 0] == 1 && tabela[2, 0] == 1
                || tabela[0, 1] == 1 && tabela[1, 1] == 1 && tabela[2, 1] == 1
                || tabela[0, 2] == 1 && tabela[1, 2] == 1 && tabela[2, 2] == 1
                || tabela[0, 0] == 1 && tabela[1, 1] == 1 && tabela[2, 2] == 1
                || tabela[0, 2] == 1 && tabela[1, 1] == 1 && tabela[2, 0] == 1)

            {
                // igralec je zmagal
                return -10;
            }

            else if (tabela[0, 0] == 2 && tabela[0, 1] == 2 && tabela[0, 2] == 2
                || tabela[1, 0] == 2 && tabela[1, 1] == 2 && tabela[1, 2] == 2
                || tabela[2, 0] == 2 && tabela[2, 1] == 2 && tabela[2, 2] == 2
                || tabela[0, 0] == 2 && tabela[1, 0] == 2 && tabela[2, 0] == 2
                || tabela[0, 1] == 2 && tabela[1, 1] == 2 && tabela[2, 1] == 2
                || tabela[0, 2] == 2 && tabela[1, 2] == 2 && tabela[2, 2] == 2
                || tabela[0, 0] == 2 && tabela[1, 1] == 2 && tabela[2, 2] == 2
                || tabela[0, 2] == 2 && tabela[1, 1] == 2 && tabela[2, 0] == 2)
            {
                // ai zmaga
                return 10;
            }
            else if (st_praznih == 0) { 
                /// ni zmagovalca in ni praznih
                return 0; // neodloceno
            }

            return 2; /// nepomembno
        }


        /*
        struct koordinate_premika{
            public int? x, y;
        }
        private (int, koordinate_premika?) MiniMax(int[,] polje, int igralec_poteza, int preostala_globina) {
            /// preverimo globino in ce je slucajno konec
            if (preostala_globina <= 0 || je_list(polje)) { return (izracun_ocene(polje), null); }
            /// ai=2, igralec=1
            int ocena;
            int temp;
            koordinate_premika premik;
            if (igralec_poteza == 1) { ocena = int.MaxValue; temp = 2; }
            else { ocena = int.MinValue; temp = 1; }
            premik.x = null;
            premik.y = null;
            /// pogledamo vsa mozna prosta mesta
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (polje[i, j] == 0) {
                        polje[i, j] = igralec_poteza; /// ai=2, igralec=1
                                                      /// poklicem minimax
                        var rezultat = MiniMax(polje, temp, preostala_globina - 1);
                        polje[i, j] = 0;
                        if (rezultat.Item1 > ocena && igralec_poteza == 2 || rezultat.Item1 < ocena && igralec_poteza == 1)
                        {
                            premik.x = i;
                            premik.y = j;
                        }
                    }
                }
            }

            return (ocena, premik);
        }
        */
        // GLEDAMO CE JE LIST
        private bool je_list(int[,] polje) {
            /// preverimo ce je konec oz vse polno
            
            bool polno = true;
            bool zmagovalec = false;
            /// preverimo ce je polno 
            for(int i=0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    if (polje[i, j] == 0) { polno = false; }
                }

            }
            // ce je zmagal AI ali oseba
            if (polje[0, 0] == 1 && polje[0, 1] == 1 && polje[0, 2] == 1
                || polje[1, 0] == 1 && polje[1, 1] == 1 && polje[1, 2] == 1
                || polje[2, 0] == 1 && polje[2, 1] == 1 && polje[2, 2] == 1
                || polje[0, 0] == 1 && polje[1, 0] == 1 && polje[2, 0] == 1
                || polje[0, 1] == 1 && polje[1, 1] == 1 && polje[2, 1] == 1
                || polje[0, 2] == 1 && polje[1, 2] == 1 && polje[2, 2] == 1
                || polje[0, 0] == 1 && polje[1, 1] == 1 && polje[2, 2] == 1
                || polje[0, 2] == 1 && polje[1, 1] == 1 && polje[2, 0] == 1)

            {
                zmagovalec = true;
            }

            else if (polje[0, 0] == 2 && polje[0, 1] == 2 && polje[0, 2] == 2
                || polje[1, 0] == 2 && polje[1, 1] == 2 && polje[1, 2] == 2
                || polje[2, 0] == 2 && polje[2, 1] == 2 && polje[2, 2] == 2
                || polje[0, 0] == 2 && polje[1, 0] == 2 && polje[2, 0] == 2
                || polje[0, 1] == 2 && polje[1, 1] == 2 && polje[2, 1] == 2
                || polje[0, 2] == 2 && polje[1, 2] == 2 && polje[2, 2] == 2
                || polje[0, 0] == 2 && polje[1, 1] == 2 && polje[2, 2] == 2
                || polje[0, 2] == 2 && polje[1, 1] == 2 && polje[2, 0] == 2)
            {
                zmagovalec = true;
            }
            return (polno || zmagovalec); // vrnemo ali je polno ali pa je zmagal kdo
        }


        private int izracun_ocene(int[,] polje) {
            /// pogledamo prazne vrstice oz odprte
            /// preveri ce je vse vredu!!!
            int za_max = 0, za_min = 0;
            int zmagovalec = 0; /// ce je 0 je tie, 1 = 1, 2 = 2
            if (polje[0, 0] == 1 && polje[0, 1] == 1 && polje[0, 2] == 1
                || polje[1, 0] == 1 && polje[1, 1] == 1 && polje[1, 2] == 1
                || polje[2, 0] == 1 && polje[2, 1] == 1 && polje[2, 2] == 1
                || polje[0, 0] == 1 && polje[1, 0] == 1 && polje[2, 0] == 1
                || polje[0, 1] == 1 && polje[1, 1] == 1 && polje[2, 1] == 1
                || polje[0, 2] == 1 && polje[1, 2] == 1 && polje[2, 2] == 1
                || polje[0, 0] == 1 && polje[1, 1] == 1 && polje[2, 2] == 1
                || polje[0, 2] == 1 && polje[1, 1] == 1 && polje[2, 0] == 1)

            {
                ///zmagovalec = 1;
                /// zmagovalec clovek za min
                return int.MinValue; // zmagal clovek
            }

            else if (polje[0, 0] == 2 && polje[0, 1] == 2 && polje[0, 2] == 2
                || polje[1, 0] == 2 && polje[1, 1] == 2 && polje[1, 2] == 2
                || polje[2, 0] == 2 && polje[2, 1] == 2 && polje[2, 2] == 2
                || polje[0, 0] == 2 && polje[1, 0] == 2 && polje[2, 0] == 2
                || polje[0, 1] == 2 && polje[1, 1] == 2 && polje[2, 1] == 2
                || polje[0, 2] == 2 && polje[1, 2] == 2 && polje[2, 2] == 2
                || polje[0, 0] == 2 && polje[1, 1] == 2 && polje[2, 2] == 2
                || polje[0, 2] == 2 && polje[1, 1] == 2 && polje[2, 0] == 2)
            {
                //zmagovalec = 2;
                /// zmaga ai in je to max
                return int.MaxValue; // zmagal rac
            }

            ///pogledamo prosta mesta
            else {
                /*for (int i = 0; i < 3; i++) {
                    //for (int j = 0; j < 3; j++) { 
                    if (polje[i, 0] != 1 && polje[i, 1] != 1 && polje[i, 2] != 1) { za_max++; } /// v vrstici ni clovek stisnil
                    if (polje[0,i] != 1 && polje[1, i] != 1 && polje[2, i] != 1) { za_max++; } /// v stolpcu ni clovek stisnil
                    if (polje[0, i] != 2 && polje[1, i] != 2 && polje[2, i] != 2) { za_min++; } /// v vrstici ni AI stisnil
                    if (polje[0, i] != 2 && polje[1, i] != 2 && polje[2, i] != 2) { za_min++; } /// v stolpcu ni AI stisnil

                }*/
                if (polje[0, 0] != 1 && polje[0, 1] != 1 && polje[0, 2] != 1) { za_max++; } /// v vrstici ni clovek stisnil
                if (polje[1, 0] != 1 && polje[1, 1] != 1 && polje[1, 2] != 1) { za_max++; } /// v vrstici ni clovek stisnil
                if (polje[2, 0] != 1 && polje[2, 1] != 1 && polje[2, 2] != 1) { za_max++; } /// v vrstici ni clovek stisnil
                if (polje[0, 0] != 1 && polje[1, 0] != 1 && polje[2, 0] != 1) { za_max++; } /// v stolpcu ni clovek stisnil
                if (polje[0, 1] != 1 && polje[1, 1] != 1 && polje[2, 1] != 1) { za_max++; } /// v stolpcu ni clovek stisnil
                if (polje[0, 2] != 1 && polje[1, 2] != 1 && polje[2, 2] != 1) { za_max++; } /// v stolpcu ni clovek stisnil
                if (polje[0, 0] != 1 && polje[1, 1] != 1 && polje[2, 2] != 1) { za_max++; } /// v dia ni clovek stisnil
                if (polje[2, 0] != 1 && polje[1, 1] != 1 && polje[0, 2] != 1) { za_max++; } /// v dia ni clovek stisnil

                if (polje[0, 0] != 2 && polje[0, 1] != 2 && polje[0, 2] != 2) { za_min++; } /// v vrstici ni AI stisnil
                if (polje[1, 0] != 2 && polje[1, 1] != 2 && polje[1, 2] != 2) { za_min++; } /// v vrstici ni AI stisnil
                if (polje[2, 0] != 2 && polje[2, 1] != 2 && polje[2, 2] != 2) { za_min++; } /// v vrstici ni AI stisnil
                if (polje[0, 0] != 2 && polje[1, 0] != 2 && polje[2, 0] != 2) { za_min++; } /// v stolpcu ni AI stisnil
                if (polje[0, 1] != 2 && polje[1, 1] != 2 && polje[2, 1] != 2) { za_min++; } /// v stolpcu ni AI stisnil
                if (polje[0, 2] != 2 && polje[1, 2] != 2 && polje[2, 2] != 2) { za_min++; } /// v stolpcu ni AI stisnil
                if (polje[0, 0] != 2 && polje[1, 1] != 2 && polje[2, 2] != 2) { za_min++; } /// v dia ni AI stisnil
                if (polje[2, 0] != 2 && polje[1, 1] != 2 && polje[0, 2] != 2) { za_min++; } /// v dia ni AI stisnil


            }
            // MessageBox.Show("max: " + za_max + " min: " + za_min + " razlika: " + (za_max-za_min));
            return (za_max - za_min); // vrnemo razliko
        }

        private void ai_z_minimax() {
            //int s = tabela[0,0];
            //var rezultat = minimax(tabela, 2, MAX_globina);
            int rezultat = Bestmove(); // dobimo kateri gumb je treba stisnet
            trenutniIgralec = Igralec.O; /// nastavi igralca na O
            preveri_zmaga(tabela); // se preverimo ce je kdo zmagal
            if (zmaga_igralca) { zmaga_igralca = false; return; }
            //bool pogoj = false; /// da se vrti v loop dokler nima prave cifre
            if (st_praznih == 0) { resetGame(); return; } // ce ni vec prostora nova igra
            if (rezultat == 0) {
                /// ce je rezultat 0 pritisnemo gumb 1
                button1.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button1.Enabled = false; /// da ga nemores ponovno stisnet
                button1.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[0, 0] = 2;
                st_praznih--;
            }
            else if (rezultat == 1)
            {
                button2.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button2.Enabled = false; /// da ga nemores ponovno stisnet
                button2.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[0, 1] = 2;
                st_praznih--;
            }
            else if (rezultat == 2)
            {
                button3.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button3.Enabled = false; /// da ga nemores ponovno stisnet
                button3.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[0, 2] = 2;
                st_praznih--;
            }
            else if (rezultat == 3)
            {
                button4.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button4.Enabled = false; /// da ga nemores ponovno stisnet
                button4.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[1, 0] = 2;
                st_praznih--;
            }
            else if (rezultat == 4)
            {
                button5.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button5.Enabled = false; /// da ga nemores ponovno stisnet
                button5.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[1, 1] = 2;
                st_praznih--;
            }
            else if (rezultat == 5)
            {
                button6.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button6.Enabled = false; /// da ga nemores ponovno stisnet
                button6.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[1, 2] = 2;
                st_praznih--;
            }
            else if (rezultat == 6)
            {
                button7.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button7.Enabled = false; /// da ga nemores ponovno stisnet
                button7.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[2, 0] = 2;
                st_praznih--;

            }
            else if (rezultat == 7)
            {
                button8.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button8.Enabled = false; /// da ga nemores ponovno stisnet
                button8.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[2, 1] = 2;
                st_praznih--;
            }
            else if (rezultat == 8)
            {
                button9.Text = trenutniIgralec.ToString(); // spremenim text gumba na O
                button9.Enabled = false; /// da ga nemores ponovno stisnet
                button9.BackColor = System.Drawing.Color.DarkBlue; /// spremenim barvo gumba
                tabela[2, 2] = 2;
                st_praznih--;
            }
            preveri_zmaga(tabela); // ponovno preberi ce je kdo zmagovalec
        }








    }
}
