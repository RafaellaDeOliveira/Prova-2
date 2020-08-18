using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2
{
    public partial class FormDificil : Form
    {
        int[,] matriz = new int[15, 15];
        Random possibilidade = new Random();
        int score = 0;

        public FormDificil()
        {
            InitializeComponent();
        }

        private void FormDificil_Load(object sender, EventArgs e)
        {
            int contador1;
            int contador2;
            int posicao1 = 30;
            int posicao2 = 30;
            lbnScore.Text = "" + score;

            for (contador1 = 0; contador1 < 15; contador1++)
            {

                for (contador2 = 0; contador2 < 15; contador2++)
                {
                    // cria o botão
                    Button campo1 = new Button();
                    campo1.Height = 30;
                    campo1.Width = 30;
                    campo1.BackColor = Color.Gray;
                    campo1.Location = new Point(posicao1 + (contador1 * 30), posicao2 + (contador2 * 30));
                    campo1.Name = "" + contador1 + "" + contador2;

                    campo1.Click += verificaBomba;

                    int rdn = possibilidade.Next(0, 100);

                    if (rdn < 50)
                    {
                        matriz[contador1, contador2] = 1; // é bomba
                    }
                    else
                    {
                        matriz[contador1, contador2] = 0; // não é bomba
                    }

                    Controls.Add(campo1);
                }
            }

        }

        private void verificaBomba(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            String c = btn.Name.Substring(0, 1);
            String l = btn.Name.Substring(1, 1);

            int coluna = Convert.ToInt32(c);
            int linha = Convert.ToInt32(l);

            if (matriz[coluna, linha] == 1)
            {
                btn.BackColor = Color.Red;
                GameOver game = new GameOver();
                game.Show();
                this.Close();

            }
            else
            {
                btn.BackColor = Color.Green;
                score = score + 1000;
                lbnScore.Text = "" + score;
            }

        }
    }
    
}
