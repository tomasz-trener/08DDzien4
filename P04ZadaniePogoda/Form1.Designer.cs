
namespace P04ZadaniePogoda
{
    partial class Form1
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
            this.txtNazwaMiasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNazwaMiasta
            // 
            this.txtNazwaMiasta.Location = new System.Drawing.Point(12, 40);
            this.txtNazwaMiasta.Name = "txtNazwaMiasta";
            this.txtNazwaMiasta.Size = new System.Drawing.Size(165, 20);
            this.txtNazwaMiasta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj nazwę miasta";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(102, 66);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 2;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(142, 102);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(35, 13);
            this.lblWynik.TabIndex = 3;
            this.lblWynik.Text = "label2";
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(183, 40);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(172, 21);
            this.cbMiasta.TabIndex = 4;
            this.cbMiasta.SelectedIndexChanged += new System.EventHandler(this.cbMiasta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "lub wybierz z historii zapisów";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMiasta);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaMiasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazwaMiasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.Label label2;
    }
}

