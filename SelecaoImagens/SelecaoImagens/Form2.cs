using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelecaoImagens
{
    public partial class Form2 : Form
    {
        public int cont = 0;
        public int qntItens = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            cont++;
            lblProdutos.ImageIndex = cont;
            if(cont >= 5)
            {
                cont = 0;
                lblProdutos.ImageIndex = cont;
                cont++;
            }
            if(cont == 0)
            {
                lblDescricao.Text = "Golden Goose";
                lblNome.Text = "Staland";
            }
            if (cont == 1)
            {
                lblDescricao.Text = "Dolce & Gabbana";
                lblNome.Text = "Sorrento high-top trekking";
            }
            if (cont == 2)
            {
                lblDescricao.Text = "Adidas";
                lblNome.Text = "Drop Step";
            }
            if (cont == 3)
            {
                lblDescricao.Text = "Balenciaga";
                lblNome.Text = "Triple S";
            }
            if (cont == 4)
            {
                lblDescricao.Text = "Gucci";
                lblNome.Text = "Ace GG Supreme";
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            cont--;
            lblProdutos.ImageIndex = cont;
            if (cont < 0)
            {
                cont = 5;
                lblProdutos.ImageIndex = cont;
                cont--;
            }
            if (cont == 0)
            {
                lblDescricao.Text = "Golden Goose";
                lblNome.Text = "Staland";
            }
            if (cont == 1)
            {
                lblDescricao.Text = "Dolce & Gabbana";
                lblNome.Text = "Sorrento high-top trekking";
            }
            if (cont == 2)
            {
                lblDescricao.Text = "Adidas";
                lblNome.Text = "Drop Step";
            }
            if (cont == 3)
            {
                lblDescricao.Text = "Balenciaga";
                lblNome.Text = "Triple S";
            }
            if (cont == 4)
            {
                lblDescricao.Text = "Gucci";
                lblNome.Text = "Ace GG Supreme";
            }
        }

        private void LblProdutos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Descrição: " + lblDescricao.Text + " modelo: " + lblNome.Text + "\nDeseja colocar item no carrinho?",
                "Mensagem de alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                qntItens++;
                label2.Text = qntItens.ToString();
                MessageBox.Show("enviado para o carrinho", "Aviso de compra");
            }
        }
    }
    }

