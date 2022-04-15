
namespace TakenAppFront
{
    partial class TaakToevoegen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBeschrijving = new System.Windows.Forms.Label();
            this.lbNaamTaak = new System.Windows.Forms.Label();
            this.tbBeschrijving = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.dpDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbBeschrijving);
            this.groupBox1.Controls.Add(this.lbNaamTaak);
            this.groupBox1.Controls.Add(this.tbBeschrijving);
            this.groupBox1.Controls.Add(this.tbNaam);
            this.groupBox1.Controls.Add(this.dpDeadline);
            this.groupBox1.Controls.Add(this.btnToevoegen);
            this.groupBox1.Location = new System.Drawing.Point(69, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 578);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taak toevoegen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Deadline :";
            // 
            // lbBeschrijving
            // 
            this.lbBeschrijving.AutoSize = true;
            this.lbBeschrijving.Location = new System.Drawing.Point(137, 195);
            this.lbBeschrijving.Name = "lbBeschrijving";
            this.lbBeschrijving.Size = new System.Drawing.Size(134, 30);
            this.lbBeschrijving.TabIndex = 5;
            this.lbBeschrijving.Text = "Beschrijving :";
            // 
            // lbNaamTaak
            // 
            this.lbNaamTaak.AutoSize = true;
            this.lbNaamTaak.Location = new System.Drawing.Point(137, 91);
            this.lbNaamTaak.Name = "lbNaamTaak";
            this.lbNaamTaak.Size = new System.Drawing.Size(119, 30);
            this.lbNaamTaak.TabIndex = 4;
            this.lbNaamTaak.Text = "Naam taak:";
            // 
            // tbBeschrijving
            // 
            this.tbBeschrijving.Location = new System.Drawing.Point(137, 237);
            this.tbBeschrijving.Multiline = true;
            this.tbBeschrijving.Name = "tbBeschrijving";
            this.tbBeschrijving.Size = new System.Drawing.Size(284, 91);
            this.tbBeschrijving.TabIndex = 3;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(137, 137);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(175, 35);
            this.tbNaam.TabIndex = 2;
            // 
            // dpDeadline
            // 
            this.dpDeadline.Location = new System.Drawing.Point(137, 392);
            this.dpDeadline.Name = "dpDeadline";
            this.dpDeadline.Size = new System.Drawing.Size(350, 35);
            this.dpDeadline.TabIndex = 1;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(137, 486);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(309, 73);
            this.btnToevoegen.TabIndex = 0;
            this.btnToevoegen.Text = "Voeg taak toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(69, 676);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(186, 73);
            this.btnTerug.TabIndex = 6;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // TaakToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 761);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaakToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaakToevoegen";
            this.Load += new System.EventHandler(this.TaakToevoegen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbBeschrijving;
        private System.Windows.Forms.Label lbNaamTaak;
        private System.Windows.Forms.TextBox tbBeschrijving;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.DateTimePicker dpDeadline;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label label1;
    }
}