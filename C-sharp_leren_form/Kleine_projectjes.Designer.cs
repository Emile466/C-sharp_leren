
namespace C_sharp_leren_form
{
    partial class Form_oefenen
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.txbLengteRechthoek = new System.Windows.Forms.TextBox();
            this.txbBreedteRechthoek = new System.Windows.Forms.TextBox();
            this.txbOmtrekRechthoek = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLettersTellen = new System.Windows.Forms.TextBox();
            this.lblAantalKlinkers = new System.Windows.Forms.Label();
            this.lblAantalSpaties = new System.Windows.Forms.Label();
            this.lblAantalMedeklinkers = new System.Windows.Forms.Label();
            this.btnBerekenOmtrek = new System.Windows.Forms.Button();
            this.btnTelLetters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 33);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(12, 74);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(100, 364);
            this.txbOutput.TabIndex = 2;
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(12, 49);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(100, 20);
            this.txbInput.TabIndex = 1;
            this.txbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbInput_KeyPress);
            // 
            // txbLengteRechthoek
            // 
            this.txbLengteRechthoek.Location = new System.Drawing.Point(255, 6);
            this.txbLengteRechthoek.Name = "txbLengteRechthoek";
            this.txbLengteRechthoek.Size = new System.Drawing.Size(100, 20);
            this.txbLengteRechthoek.TabIndex = 3;
            // 
            // txbBreedteRechthoek
            // 
            this.txbBreedteRechthoek.Location = new System.Drawing.Point(255, 30);
            this.txbBreedteRechthoek.Name = "txbBreedteRechthoek";
            this.txbBreedteRechthoek.Size = new System.Drawing.Size(100, 20);
            this.txbBreedteRechthoek.TabIndex = 4;
            // 
            // txbOmtrekRechthoek
            // 
            this.txbOmtrekRechthoek.Location = new System.Drawing.Point(255, 54);
            this.txbOmtrekRechthoek.Name = "txbOmtrekRechthoek";
            this.txbOmtrekRechthoek.Size = new System.Drawing.Size(100, 20);
            this.txbOmtrekRechthoek.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lengte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Breedte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Omtrek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Text";
            // 
            // txbLettersTellen
            // 
            this.txbLettersTellen.Location = new System.Drawing.Point(255, 115);
            this.txbLettersTellen.Multiline = true;
            this.txbLettersTellen.Name = "txbLettersTellen";
            this.txbLettersTellen.Size = new System.Drawing.Size(131, 118);
            this.txbLettersTellen.TabIndex = 10;
            // 
            // lblAantalKlinkers
            // 
            this.lblAantalKlinkers.AutoSize = true;
            this.lblAantalKlinkers.Location = new System.Drawing.Point(391, 131);
            this.lblAantalKlinkers.Name = "lblAantalKlinkers";
            this.lblAantalKlinkers.Size = new System.Drawing.Size(53, 13);
            this.lblAantalKlinkers.TabIndex = 14;
            this.lblAantalKlinkers.Text = "# klinkers";
            // 
            // lblAantalSpaties
            // 
            this.lblAantalSpaties.AutoSize = true;
            this.lblAantalSpaties.Location = new System.Drawing.Point(392, 118);
            this.lblAantalSpaties.Name = "lblAantalSpaties";
            this.lblAantalSpaties.Size = new System.Drawing.Size(50, 13);
            this.lblAantalSpaties.TabIndex = 15;
            this.lblAantalSpaties.Text = "# spaties";
            // 
            // lblAantalMedeklinkers
            // 
            this.lblAantalMedeklinkers.AutoSize = true;
            this.lblAantalMedeklinkers.Location = new System.Drawing.Point(392, 144);
            this.lblAantalMedeklinkers.Name = "lblAantalMedeklinkers";
            this.lblAantalMedeklinkers.Size = new System.Drawing.Size(79, 13);
            this.lblAantalMedeklinkers.TabIndex = 16;
            this.lblAantalMedeklinkers.Text = "# medeklinkers";
            // 
            // btnBerekenOmtrek
            // 
            this.btnBerekenOmtrek.Location = new System.Drawing.Point(267, 80);
            this.btnBerekenOmtrek.Name = "btnBerekenOmtrek";
            this.btnBerekenOmtrek.Size = new System.Drawing.Size(75, 23);
            this.btnBerekenOmtrek.TabIndex = 5;
            this.btnBerekenOmtrek.Text = "Bereken omtrek!";
            this.btnBerekenOmtrek.UseVisualStyleBackColor = true;
            this.btnBerekenOmtrek.Click += new System.EventHandler(this.btnBerekenOmtrek_Click);
            // 
            // btnTelLetters
            // 
            this.btnTelLetters.Location = new System.Drawing.Point(267, 239);
            this.btnTelLetters.Name = "btnTelLetters";
            this.btnTelLetters.Size = new System.Drawing.Size(106, 23);
            this.btnTelLetters.TabIndex = 17;
            this.btnTelLetters.Text = "Tel de letters!";
            this.btnTelLetters.UseVisualStyleBackColor = true;
            this.btnTelLetters.Click += new System.EventHandler(this.btnTelLetters_Click);
            // 
            // Form_oefenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTelLetters);
            this.Controls.Add(this.lblAantalMedeklinkers);
            this.Controls.Add(this.lblAantalSpaties);
            this.Controls.Add(this.lblAantalKlinkers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbLettersTellen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbOmtrekRechthoek);
            this.Controls.Add(this.btnBerekenOmtrek);
            this.Controls.Add(this.txbBreedteRechthoek);
            this.Controls.Add(this.txbLengteRechthoek);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form_oefenen";
            this.Text = "Oefenen";
            this.Load += new System.EventHandler(this.Form_oefenen_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormOefenen_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.TextBox txbLengteRechthoek;
        private System.Windows.Forms.TextBox txbBreedteRechthoek;
        private System.Windows.Forms.TextBox txbOmtrekRechthoek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbLettersTellen;
        private System.Windows.Forms.Label lblAantalKlinkers;
        private System.Windows.Forms.Label lblAantalSpaties;
        private System.Windows.Forms.Label lblAantalMedeklinkers;
        private System.Windows.Forms.Button btnBerekenOmtrek;
        private System.Windows.Forms.Button btnTelLetters;
    }
}

