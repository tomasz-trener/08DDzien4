
namespace P01AplikacjaOkienkowa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKomuniakt = new System.Windows.Forms.Button();
            this.txtKomuniakt = new System.Windows.Forms.TextBox();
            this.lblKomunikat = new System.Windows.Forms.Label();
            this.btnWyswietlTekst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKomuniakt
            // 
            this.btnKomuniakt.Location = new System.Drawing.Point(22, 22);
            this.btnKomuniakt.Name = "btnKomuniakt";
            this.btnKomuniakt.Size = new System.Drawing.Size(122, 56);
            this.btnKomuniakt.TabIndex = 0;
            this.btnKomuniakt.Text = "Przycisk startowy";
            this.btnKomuniakt.UseVisualStyleBackColor = true;
            this.btnKomuniakt.Click += new System.EventHandler(this.btnKomunikat_Click);
            // 
            // txtKomuniakt
            // 
            this.txtKomuniakt.Location = new System.Drawing.Point(22, 107);
            this.txtKomuniakt.Name = "txtKomuniakt";
            this.txtKomuniakt.Size = new System.Drawing.Size(122, 20);
            this.txtKomuniakt.TabIndex = 1;
            // 
            // lblKomunikat
            // 
            this.lblKomunikat.AutoSize = true;
            this.lblKomunikat.Location = new System.Drawing.Point(194, 110);
            this.lblKomunikat.Name = "lblKomunikat";
            this.lblKomunikat.Size = new System.Drawing.Size(35, 13);
            this.lblKomunikat.TabIndex = 2;
            this.lblKomunikat.Text = "label1";
            // 
            // btnWyswietlTekst
            // 
            this.btnWyswietlTekst.Location = new System.Drawing.Point(22, 142);
            this.btnWyswietlTekst.Name = "btnWyswietlTekst";
            this.btnWyswietlTekst.Size = new System.Drawing.Size(122, 25);
            this.btnWyswietlTekst.TabIndex = 3;
            this.btnWyswietlTekst.Text = "Wyświetl";
            this.btnWyswietlTekst.UseVisualStyleBackColor = true;
            this.btnWyswietlTekst.Click += new System.EventHandler(this.btnWyswietlTekst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 375);
            this.Controls.Add(this.btnWyswietlTekst);
            this.Controls.Add(this.lblKomunikat);
            this.Controls.Add(this.txtKomuniakt);
            this.Controls.Add(this.btnKomuniakt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKomuniakt;
        private System.Windows.Forms.TextBox txtKomuniakt;
        private System.Windows.Forms.Label lblKomunikat;
        private System.Windows.Forms.Button btnWyswietlTekst;
    }
}

