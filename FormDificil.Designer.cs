namespace Prova2
{
    partial class FormDificil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbnScore = new System.Windows.Forms.Label();
            this.lbnPntuacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbnScore
            // 
            this.lbnScore.BackColor = System.Drawing.Color.Black;
            this.lbnScore.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnScore.ForeColor = System.Drawing.Color.White;
            this.lbnScore.Location = new System.Drawing.Point(128, 485);
            this.lbnScore.Name = "lbnScore";
            this.lbnScore.Size = new System.Drawing.Size(155, 23);
            this.lbnScore.TabIndex = 8;
            // 
            // lbnPntuacao
            // 
            this.lbnPntuacao.AutoSize = true;
            this.lbnPntuacao.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnPntuacao.ForeColor = System.Drawing.Color.White;
            this.lbnPntuacao.Location = new System.Drawing.Point(11, 487);
            this.lbnPntuacao.Name = "lbnPntuacao";
            this.lbnPntuacao.Size = new System.Drawing.Size(111, 21);
            this.lbnPntuacao.TabIndex = 7;
            this.lbnPntuacao.Text = "Pontuação";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 524);
            this.label1.TabIndex = 9;
            // 
            // FormDificil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(617, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnScore);
            this.Controls.Add(this.lbnPntuacao);
            this.Name = "FormDificil";
            this.Text = "FormDificil";
            this.Load += new System.EventHandler(this.FormDificil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnScore;
        private System.Windows.Forms.Label lbnPntuacao;
        private System.Windows.Forms.Label label1;
    }
}