
namespace C_sharp_leren_form
{
    partial class frmArrays
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
            this.btnZoek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWisSelectie = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDefaultLijst = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txbIngrediënt = new System.Windows.Forms.TextBox();
            this.livIngrediënten = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(12, 35);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(83, 23);
            this.btnZoek.TabIndex = 0;
            this.btnZoek.Text = "Zoek in de lijst";
            this.btnZoek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrediënt :";
            // 
            // btnWisSelectie
            // 
            this.btnWisSelectie.Location = new System.Drawing.Point(12, 64);
            this.btnWisSelectie.Name = "btnWisSelectie";
            this.btnWisSelectie.Size = new System.Drawing.Size(83, 48);
            this.btnWisSelectie.TabIndex = 2;
            this.btnWisSelectie.Text = "Selectie ongedaan maken";
            this.btnWisSelectie.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Einde";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDefaultLijst
            // 
            this.btnDefaultLijst.Location = new System.Drawing.Point(12, 161);
            this.btnDefaultLijst.Name = "btnDefaultLijst";
            this.btnDefaultLijst.Size = new System.Drawing.Size(83, 23);
            this.btnDefaultLijst.TabIndex = 4;
            this.btnDefaultLijst.Text = "Default lijst";
            this.btnDefaultLijst.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Wis ingredriënt";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txbIngrediënt
            // 
            this.txbIngrediënt.Location = new System.Drawing.Point(101, 6);
            this.txbIngrediënt.Name = "txbIngrediënt";
            this.txbIngrediënt.Size = new System.Drawing.Size(121, 20);
            this.txbIngrediënt.TabIndex = 6;
            // 
            // livIngrediënten
            // 
            this.livIngrediënten.HideSelection = false;
            this.livIngrediënten.Location = new System.Drawing.Point(101, 35);
            this.livIngrediënten.Name = "livIngrediënten";
            this.livIngrediënten.Size = new System.Drawing.Size(121, 178);
            this.livIngrediënten.TabIndex = 7;
            this.livIngrediënten.UseCompatibleStateImageBehavior = false;
            // 
            // frmArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 217);
            this.Controls.Add(this.livIngrediënten);
            this.Controls.Add(this.txbIngrediënt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDefaultLijst);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWisSelectie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZoek);
            this.Name = "frmArrays";
            this.Text = "Arrays";
            this.Load += new System.EventHandler(this.frmArrays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWisSelectie;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDefaultLijst;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txbIngrediënt;
        private System.Windows.Forms.ListView livIngrediënten;
    }
}