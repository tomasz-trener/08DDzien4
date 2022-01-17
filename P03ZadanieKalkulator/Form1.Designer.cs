
namespace P03ZadanieKalkulator
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
            this.txtWyswietlacz = new System.Windows.Forms.TextBox();
            this.btnSiedem = new System.Windows.Forms.Button();
            this.btnOsiem = new System.Windows.Forms.Button();
            this.btnDziewiec = new System.Windows.Forms.Button();
            this.btnSzesc = new System.Windows.Forms.Button();
            this.btnPiec = new System.Windows.Forms.Button();
            this.btnCZtery = new System.Windows.Forms.Button();
            this.btnTrzy = new System.Windows.Forms.Button();
            this.btnDwa = new System.Windows.Forms.Button();
            this.bnJeden = new System.Windows.Forms.Button();
            this.btnDZielenie = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMnozenie = new System.Windows.Forms.Button();
            this.btnRownaSie = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnCZysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWyswietlacz
            // 
            this.txtWyswietlacz.Location = new System.Drawing.Point(12, 23);
            this.txtWyswietlacz.Name = "txtWyswietlacz";
            this.txtWyswietlacz.Size = new System.Drawing.Size(230, 20);
            this.txtWyswietlacz.TabIndex = 0;
            // 
            // btnSiedem
            // 
            this.btnSiedem.Location = new System.Drawing.Point(12, 49);
            this.btnSiedem.Name = "btnSiedem";
            this.btnSiedem.Size = new System.Drawing.Size(53, 47);
            this.btnSiedem.TabIndex = 1;
            this.btnSiedem.Text = "7";
            this.btnSiedem.UseVisualStyleBackColor = true;
            this.btnSiedem.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnOsiem
            // 
            this.btnOsiem.Location = new System.Drawing.Point(71, 49);
            this.btnOsiem.Name = "btnOsiem";
            this.btnOsiem.Size = new System.Drawing.Size(53, 47);
            this.btnOsiem.TabIndex = 2;
            this.btnOsiem.Text = "8";
            this.btnOsiem.UseVisualStyleBackColor = true;
            this.btnOsiem.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnDziewiec
            // 
            this.btnDziewiec.Location = new System.Drawing.Point(130, 49);
            this.btnDziewiec.Name = "btnDziewiec";
            this.btnDziewiec.Size = new System.Drawing.Size(53, 47);
            this.btnDziewiec.TabIndex = 3;
            this.btnDziewiec.Text = "9";
            this.btnDziewiec.UseVisualStyleBackColor = true;
            this.btnDziewiec.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnSzesc
            // 
            this.btnSzesc.Location = new System.Drawing.Point(130, 102);
            this.btnSzesc.Name = "btnSzesc";
            this.btnSzesc.Size = new System.Drawing.Size(53, 47);
            this.btnSzesc.TabIndex = 6;
            this.btnSzesc.Text = "6";
            this.btnSzesc.UseVisualStyleBackColor = true;
            this.btnSzesc.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnPiec
            // 
            this.btnPiec.Location = new System.Drawing.Point(71, 102);
            this.btnPiec.Name = "btnPiec";
            this.btnPiec.Size = new System.Drawing.Size(53, 47);
            this.btnPiec.TabIndex = 5;
            this.btnPiec.Text = "5";
            this.btnPiec.UseVisualStyleBackColor = true;
            this.btnPiec.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnCZtery
            // 
            this.btnCZtery.Location = new System.Drawing.Point(12, 102);
            this.btnCZtery.Name = "btnCZtery";
            this.btnCZtery.Size = new System.Drawing.Size(53, 47);
            this.btnCZtery.TabIndex = 4;
            this.btnCZtery.Text = "4";
            this.btnCZtery.UseVisualStyleBackColor = true;
            this.btnCZtery.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnTrzy
            // 
            this.btnTrzy.Location = new System.Drawing.Point(130, 155);
            this.btnTrzy.Name = "btnTrzy";
            this.btnTrzy.Size = new System.Drawing.Size(53, 47);
            this.btnTrzy.TabIndex = 9;
            this.btnTrzy.Text = "3";
            this.btnTrzy.UseVisualStyleBackColor = true;
            this.btnTrzy.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnDwa
            // 
            this.btnDwa.Location = new System.Drawing.Point(71, 155);
            this.btnDwa.Name = "btnDwa";
            this.btnDwa.Size = new System.Drawing.Size(53, 47);
            this.btnDwa.TabIndex = 8;
            this.btnDwa.Text = "2";
            this.btnDwa.UseVisualStyleBackColor = true;
            this.btnDwa.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // bnJeden
            // 
            this.bnJeden.Location = new System.Drawing.Point(12, 155);
            this.bnJeden.Name = "bnJeden";
            this.bnJeden.Size = new System.Drawing.Size(53, 47);
            this.bnJeden.TabIndex = 7;
            this.bnJeden.Text = "1";
            this.bnJeden.UseVisualStyleBackColor = true;
            this.bnJeden.Click += new System.EventHandler(this.bnJeden_Click);
            // 
            // btnDZielenie
            // 
            this.btnDZielenie.Location = new System.Drawing.Point(189, 155);
            this.btnDZielenie.Name = "btnDZielenie";
            this.btnDZielenie.Size = new System.Drawing.Size(53, 47);
            this.btnDZielenie.TabIndex = 12;
            this.btnDZielenie.Text = "/";
            this.btnDZielenie.UseVisualStyleBackColor = true;
            this.btnDZielenie.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(189, 102);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(53, 47);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(189, 49);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(53, 47);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnMnozenie
            // 
            this.btnMnozenie.Location = new System.Drawing.Point(189, 208);
            this.btnMnozenie.Name = "btnMnozenie";
            this.btnMnozenie.Size = new System.Drawing.Size(53, 47);
            this.btnMnozenie.TabIndex = 16;
            this.btnMnozenie.Text = "*";
            this.btnMnozenie.UseVisualStyleBackColor = true;
            this.btnMnozenie.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnRownaSie
            // 
            this.btnRownaSie.Location = new System.Drawing.Point(130, 208);
            this.btnRownaSie.Name = "btnRownaSie";
            this.btnRownaSie.Size = new System.Drawing.Size(53, 47);
            this.btnRownaSie.TabIndex = 15;
            this.btnRownaSie.Text = "=";
            this.btnRownaSie.UseVisualStyleBackColor = true;
            this.btnRownaSie.Click += new System.EventHandler(this.btnRownaSie_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(71, 208);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(53, 47);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnCZysc
            // 
            this.btnCZysc.Location = new System.Drawing.Point(12, 208);
            this.btnCZysc.Name = "btnCZysc";
            this.btnCZysc.Size = new System.Drawing.Size(53, 47);
            this.btnCZysc.TabIndex = 13;
            this.btnCZysc.Text = "C";
            this.btnCZysc.UseVisualStyleBackColor = true;
            this.btnCZysc.Click += new System.EventHandler(this.btnCZysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 270);
            this.Controls.Add(this.btnMnozenie);
            this.Controls.Add(this.btnRownaSie);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnCZysc);
            this.Controls.Add(this.btnDZielenie);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnTrzy);
            this.Controls.Add(this.btnDwa);
            this.Controls.Add(this.bnJeden);
            this.Controls.Add(this.btnSzesc);
            this.Controls.Add(this.btnPiec);
            this.Controls.Add(this.btnCZtery);
            this.Controls.Add(this.btnDziewiec);
            this.Controls.Add(this.btnOsiem);
            this.Controls.Add(this.btnSiedem);
            this.Controls.Add(this.txtWyswietlacz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWyswietlacz;
        private System.Windows.Forms.Button btnSiedem;
        private System.Windows.Forms.Button btnOsiem;
        private System.Windows.Forms.Button btnDziewiec;
        private System.Windows.Forms.Button btnSzesc;
        private System.Windows.Forms.Button btnPiec;
        private System.Windows.Forms.Button btnCZtery;
        private System.Windows.Forms.Button btnTrzy;
        private System.Windows.Forms.Button btnDwa;
        private System.Windows.Forms.Button bnJeden;
        private System.Windows.Forms.Button btnDZielenie;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMnozenie;
        private System.Windows.Forms.Button btnRownaSie;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnCZysc;
    }
}

