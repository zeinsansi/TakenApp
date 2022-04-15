namespace TaakverdelingApp
{
    partial class MijnGroepn
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
            this.btnGroepMaken = new System.Windows.Forms.Button();
            this.gbMijnGroepn = new System.Windows.Forms.GroupBox();
            this.lbMijnGroepen = new System.Windows.Forms.ListBox();
            this.lbGroepleden = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnVoegGroeplidToe = new System.Windows.Forms.Button();
            this.tbGebruikerNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMijnGroepn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGroepMaken
            // 
            this.btnGroepMaken.Location = new System.Drawing.Point(347, 498);
            this.btnGroepMaken.Name = "btnGroepMaken";
            this.btnGroepMaken.Size = new System.Drawing.Size(208, 81);
            this.btnGroepMaken.TabIndex = 4;
            this.btnGroepMaken.Text = "Groep Maken";
            this.btnGroepMaken.UseVisualStyleBackColor = true;
            this.btnGroepMaken.Click += new System.EventHandler(this.btnGroepMaken_Click);
            // 
            // gbMijnGroepn
            // 
            this.gbMijnGroepn.Controls.Add(this.lbMijnGroepen);
            this.gbMijnGroepn.Location = new System.Drawing.Point(81, 59);
            this.gbMijnGroepn.Name = "gbMijnGroepn";
            this.gbMijnGroepn.Size = new System.Drawing.Size(474, 421);
            this.gbMijnGroepn.TabIndex = 3;
            this.gbMijnGroepn.TabStop = false;
            this.gbMijnGroepn.Text = "Mijn groepen";
            // 
            // lbMijnGroepen
            // 
            this.lbMijnGroepen.FormattingEnabled = true;
            this.lbMijnGroepen.ItemHeight = 30;
            this.lbMijnGroepen.Location = new System.Drawing.Point(8, 66);
            this.lbMijnGroepen.Name = "lbMijnGroepen";
            this.lbMijnGroepen.Size = new System.Drawing.Size(460, 334);
            this.lbMijnGroepen.TabIndex = 2;
            this.lbMijnGroepen.SelectedIndexChanged += new System.EventHandler(this.lbMijnGroepen_SelectedIndexChanged);
            // 
            // lbGroepleden
            // 
            this.lbGroepleden.FormattingEnabled = true;
            this.lbGroepleden.ItemHeight = 30;
            this.lbGroepleden.Location = new System.Drawing.Point(661, 125);
            this.lbGroepleden.Name = "lbGroepleden";
            this.lbGroepleden.Size = new System.Drawing.Size(210, 334);
            this.lbGroepleden.TabIndex = 5;
            this.lbGroepleden.SelectedIndexChanged += new System.EventHandler(this.lbGroepleden_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Groep leden:";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(81, 498);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(208, 81);
            this.btnVerwijderen.TabIndex = 7;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnVoegGroeplidToe
            // 
            this.btnVoegGroeplidToe.Location = new System.Drawing.Point(663, 532);
            this.btnVoegGroeplidToe.Name = "btnVoegGroeplidToe";
            this.btnVoegGroeplidToe.Size = new System.Drawing.Size(208, 47);
            this.btnVoegGroeplidToe.TabIndex = 8;
            this.btnVoegGroeplidToe.Text = "Voeg aan groep toe";
            this.btnVoegGroeplidToe.UseVisualStyleBackColor = true;
            this.btnVoegGroeplidToe.Click += new System.EventHandler(this.btnVoegGroeplidToe_Click);
            // 
            // tbGebruikerNaam
            // 
            this.tbGebruikerNaam.Location = new System.Drawing.Point(663, 498);
            this.tbGebruikerNaam.Name = "tbGebruikerNaam";
            this.tbGebruikerNaam.Size = new System.Drawing.Size(208, 35);
            this.tbGebruikerNaam.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gebruiker naam:";
            // 
            // MijnGroepn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 727);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGebruikerNaam);
            this.Controls.Add(this.btnVoegGroeplidToe);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGroepleden);
            this.Controls.Add(this.btnGroepMaken);
            this.Controls.Add(this.gbMijnGroepn);
            this.Name = "MijnGroepn";
            this.Text = "Mijn groepen";
            this.Load += new System.EventHandler(this.MijnGroepn_Load);
            this.gbMijnGroepn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGroepMaken;
        private System.Windows.Forms.GroupBox gbMijnGroepn;
        private System.Windows.Forms.ListBox lbGroepleden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.ListBox lbMijnGroepen;
        private System.Windows.Forms.Button btnVoegGroeplidToe;
        private System.Windows.Forms.TextBox tbGebruikerNaam;
        private System.Windows.Forms.Label label2;
    }
}