namespace Prova2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFacil = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnDificil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFacil
            // 
            this.btnFacil.BackColor = System.Drawing.Color.LawnGreen;
            this.btnFacil.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacil.Location = new System.Drawing.Point(12, 12);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(234, 61);
            this.btnFacil.TabIndex = 0;
            this.btnFacil.Text = "Fácil";
            this.btnFacil.UseVisualStyleBackColor = false;
            this.btnFacil.Click += new System.EventHandler(this.BtnFacil_Click);
            // 
            // btnMedio
            // 
            this.btnMedio.BackColor = System.Drawing.Color.Yellow;
            this.btnMedio.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.Location = new System.Drawing.Point(12, 153);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(234, 61);
            this.btnMedio.TabIndex = 1;
            this.btnMedio.Text = "Médio";
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.Click += new System.EventHandler(this.BtnMedio_Click);
            // 
            // btnDificil
            // 
            this.btnDificil.BackColor = System.Drawing.Color.Red;
            this.btnDificil.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDificil.Location = new System.Drawing.Point(12, 281);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(234, 61);
            this.btnDificil.TabIndex = 2;
            this.btnDificil.Text = "Difícil";
            this.btnDificil.UseVisualStyleBackColor = false;
            this.btnDificil.Click += new System.EventHandler(this.BtnDificil_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Possui 10% de bombas";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Possui 30% de bombas";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Possui 50% de bombas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(262, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDificil);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.btnFacil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnDificil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

