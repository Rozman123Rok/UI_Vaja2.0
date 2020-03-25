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

                ai_move(); /// na vrsti ai
                //MessageBox.Show("Tabela: " + tabela[0, 0] + " max_globina: " + MAX_globina);
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

                ai_move(); /// na vrsti ai
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

                ai_move(); /// na vrsti ai
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

                ai_move(); /// na vrsti ai
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

                ai_move(); /// na vrsti ai
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

                ai_move(); /// na vrsti aiai_move(); /// na vrsti ai
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

                ai_move(); /// na vrsti ai
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

                ai_move(); /// na vrsti ai
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

                ai_move(); /// na vrsti ai
                //MessageBox.Show("Tabela: " + tabela[2, 2] + " max_globina: " + MAX_globina);
            }
        }

        private void izpis_polja(int[,]a) {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    MessageBox.Show(" " + a[i, j]);
                }
            }
        }

        private void ai_move() {
            Check();
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

            Check();
            
        }

        private void preveri_zmaga(int[,] polje) { 
            
        }

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
        private void Check()
        {
            /// preverjamo ce je kdo zmagal
            /// najprej za igralca
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                // igralec je zmagal
                //AImoves.Stop(); /// MORES POL ZBRISAT
                MessageBox.Show("Zmaga igralca"); /// napisemo kdo je zmagal
                Igralec_Zmage++; /// povecamo stevilo zmag
                label1.Text = "Igralec - " + Igralec_Zmage; // spremenimo napis
                zmaga_igralca = true;
                resetGame(); ///  znova zazenemo igro
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                /// zmaga AI
                //AImoves.Stop(); /// MORES POL ZBRISAT
                MessageBox.Show("Zmaga AI");
                AI_Zmage++;
                label2.Text = "AI - " + AI_Zmage;
                resetGame();
            }
        }

    }
}
