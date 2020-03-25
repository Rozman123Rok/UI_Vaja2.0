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
            /*
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    MessageBox.Show(" test: " + tabela[i, j]);
                }
            }
            */
        }
        
        
        int MAX_globina = 1; /// do katere globine gremo
        public enum Igralec
        {
            /// znaki za igralce
            X, O
        }

        Igralec trenutniIgralec;

        int[,] tabela = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }; /// moje polje kjer bomo devali X O
        // X =1; O=2;





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
                //MessageBox.Show("Tabela: " + tabela[2, 2] + " max_globina: " + MAX_globina);
            }
        }
    }
}
