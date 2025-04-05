namespace implementazione_Impiccato
{
    partial class bo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titolo = new Label();
            difficoltà = new TextBox();
            facile = new Button();
            medio = new Button();
            difficile = new Button();
            parolacasuale = new TextBox();
            label1 = new Label();
            label2 = new Label();
            inseriscip = new TextBox();
            inseriscil = new TextBox();
            label3 = new Label();
            tentativi = new TextBox();
            label4 = new Label();
            punteggio = new Label();
            titparolevinte = new Label();
            titparolesbagliate = new Label();
            parolevinte = new TextBox();
            paroleperse = new TextBox();
            bottonepcasuale = new Button();
            SuspendLayout();
            // 
            // titolo
            // 
            titolo.AutoSize = true;
            titolo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titolo.ForeColor = SystemColors.ActiveCaptionText;
            titolo.Location = new Point(271, 22);
            titolo.Name = "titolo";
            titolo.Size = new Size(220, 28);
            titolo.TabIndex = 0;
            titolo.Text = "GIOCO DELL' IMPICCATO";
            titolo.Click += titolo_Click;
            // 
            // difficoltà
            // 
            difficoltà.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            difficoltà.Location = new Point(99, 74);
            difficoltà.Name = "difficoltà";
            difficoltà.Size = new Size(81, 23);
            difficoltà.TabIndex = 1;
            difficoltà.Text = "DIFFICOLTA'";
            // 
            // facile
            // 
            facile.Font = new Font("Open Sans", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            facile.Location = new Point(100, 103);
            facile.Name = "facile";
            facile.Size = new Size(75, 23);
            facile.TabIndex = 2;
            facile.Text = "Facile";
            facile.UseVisualStyleBackColor = true;
            facile.Click += facile_Click;
            // 
            // medio
            // 
            medio.Font = new Font("Open Sans", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            medio.Location = new Point(100, 132);
            medio.Name = "medio";
            medio.Size = new Size(75, 23);
            medio.TabIndex = 3;
            medio.Text = "Medio";
            medio.UseVisualStyleBackColor = true;
            medio.Click += medio_Click_1;
            // 
            // difficile
            // 
            difficile.Font = new Font("Open Sans", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            difficile.Location = new Point(100, 161);
            difficile.Name = "difficile";
            difficile.Size = new Size(75, 23);
            difficile.TabIndex = 4;
            difficile.Text = "Difficile";
            difficile.UseVisualStyleBackColor = true;
            difficile.Click += difficile_Click_1;
            // 
            // parolacasuale
            // 
            parolacasuale.Location = new Point(271, 85);
            parolacasuale.Name = "parolacasuale";
            parolacasuale.Size = new Size(220, 23);
            parolacasuale.TabIndex = 5;
            parolacasuale.TextChanged += parolacasuale_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 64);
            label1.Name = "label1";
            label1.Size = new Size(131, 18);
            label1.TabIndex = 6;
            label1.Text = "Parola da indovinare";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 122);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 7;
            label2.Text = "Inserisci parola";
            label2.Click += label2_Click;
            // 
            // inseriscip
            // 
            inseriscip.Location = new Point(271, 143);
            inseriscip.Name = "inseriscip";
            inseriscip.Size = new Size(220, 23);
            inseriscip.TabIndex = 8;
            // 
            // inseriscil
            // 
            inseriscil.Location = new Point(271, 202);
            inseriscil.Name = "inseriscil";
            inseriscil.Size = new Size(220, 23);
            inseriscil.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 181);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 10;
            label3.Text = "Inserisci lettera";
            label3.Click += label3_Click;
            // 
            // tentativi
            // 
            tentativi.Location = new Point(614, 27);
            tentativi.Name = "tentativi";
            tentativi.Size = new Size(56, 23);
            tentativi.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(536, 29);
            label4.Name = "label4";
            label4.Size = new Size(72, 16);
            label4.TabIndex = 12;
            label4.Text = "TENTATIVI";
            label4.Click += label4_Click;
            // 
            // punteggio
            // 
            punteggio.AutoSize = true;
            punteggio.Font = new Font("Noto Sans", 11.2499981F, FontStyle.Bold);
            punteggio.Location = new Point(311, 258);
            punteggio.Name = "punteggio";
            punteggio.Size = new Size(154, 20);
            punteggio.TabIndex = 13;
            punteggio.Text = "PUNTEGGIO FINALE";
            punteggio.Click += label5_Click;
            // 
            // titparolevinte
            // 
            titparolevinte.AutoSize = true;
            titparolevinte.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titparolevinte.Location = new Point(232, 290);
            titparolevinte.Name = "titparolevinte";
            titparolevinte.Size = new Size(79, 18);
            titparolevinte.TabIndex = 14;
            titparolevinte.Text = "Parole vinte";
            // 
            // titparolesbagliate
            // 
            titparolesbagliate.AutoSize = true;
            titparolesbagliate.Font = new Font("Open Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titparolesbagliate.Location = new Point(232, 322);
            titparolesbagliate.Name = "titparolesbagliate";
            titparolesbagliate.Size = new Size(102, 18);
            titparolesbagliate.TabIndex = 15;
            titparolesbagliate.Text = "Parole sbagliate";
            // 
            // parolevinte
            // 
            parolevinte.Location = new Point(350, 289);
            parolevinte.Name = "parolevinte";
            parolevinte.Size = new Size(100, 23);
            parolevinte.TabIndex = 16;
            // 
            // paroleperse
            // 
            paroleperse.Location = new Point(350, 321);
            paroleperse.Name = "paroleperse";
            paroleperse.Size = new Size(100, 23);
            paroleperse.TabIndex = 17;
            // 
            // bottonepcasuale
            // 
            bottonepcasuale.Location = new Point(277, 59);
            bottonepcasuale.Name = "bottonepcasuale";
            bottonepcasuale.Size = new Size(28, 23);
            bottonepcasuale.TabIndex = 18;
            bottonepcasuale.Text = "✔";
            bottonepcasuale.UseVisualStyleBackColor = true;
            bottonepcasuale.Click += bottonepcasuale_Click;
            // 
            // bo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bottonepcasuale);
            Controls.Add(paroleperse);
            Controls.Add(parolevinte);
            Controls.Add(titparolesbagliate);
            Controls.Add(titparolevinte);
            Controls.Add(punteggio);
            Controls.Add(label4);
            Controls.Add(tentativi);
            Controls.Add(label3);
            Controls.Add(inseriscil);
            Controls.Add(inseriscip);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(parolacasuale);
            Controls.Add(difficile);
            Controls.Add(medio);
            Controls.Add(facile);
            Controls.Add(difficoltà);
            Controls.Add(titolo);
            Name = "bo";
            Text = "Difficile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titolo;
        private TextBox difficoltà;
        private Button facile;
        private Button medio;
        private Button difficile;
        private TextBox parolacasuale;
        private Label label1;
        private Label label2;
        private TextBox inseriscip;
        private TextBox inseriscil;
        private Label label3;
        private TextBox tentativi;
        private Label label4;
        private Label punteggio;
        private Label titparolevinte;
        private Label titparolesbagliate;
        private TextBox parolevinte;
        private TextBox paroleperse;
        private Button bottonepcasuale;
    }
}
