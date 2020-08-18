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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BtnFacil_Click(object sender, EventArgs e)
        {
            FormFacil ModoFacil = new FormFacil();
            ModoFacil.Show();
        }

        private void BtnMedio_Click(object sender, EventArgs e)
        {
            FormMedio ModoMedio = new FormMedio();
            ModoMedio.Show();
        }

        private void BtnDificil_Click(object sender, EventArgs e)
        {
            FormDificil FormDificil = new FormDificil();
            FormDificil.Show();
        }
    }
}
