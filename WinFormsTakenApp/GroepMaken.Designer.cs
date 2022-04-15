namespace TaakverdelingApp
{
    partial class GroepMaken
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
            this.btnTerugGroep = new System.Windows.Forms.Button();
            this.gbGroepMaken = new System.Windows.Forms.GroupBox();
            this.tbProjectBeshrijving = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProjectNaam = new System.Windows.Forms.Label();
            this.lbGroepMaken = new System.Windows.Forms.Label();
            this.tbProjectNaam = new System.Windows.Forms.TextBox();
            this.tbGreopNaam = new System.Windows.Forms.TextBox();
            this.btnGroepMaken = new System.Windows.Forms.Button();
            this.gbGroepMaken.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTerugGroep
            // 
            this.btnTerugGroep.Location = new System.Drawing.Point(65, 673);
            this.btnTerugGroep.Name = "btnTerugGroep";
            this.btnTerugGroep.Size = new System.Drawing.Size(186, 73);
            this.btnTerugGroep.TabIndex = 8;
            this.btnTerugGroep.Text = "Terug";
            this.btnTerugGroep.UseVisualStyleBackColor = true;
            this.btnTerugGroep.Click += new System.EventHandler(this.btnTerugGroep_Click);
            // 
            // gbGroepMaken
            // 
            this.gbGroepMaken.Controls.Add(this.tbProjectBeshrijving);
            this.gbGroepMaken.Controls.Add(this.label1);
            this.gbGroepMaken.Controls.Add(this.lbProjectNaam);
            this.gbGroepMaken.Controls.Add(this.lbGroepMaken);
            this.gbGroepMaken.Controls.Add(this.tbProjectNaam);
            this.gbGroepMaken.Controls.Add(this.tbGreopNaam);
            this.gbGroepMaken.Controls.Add(this.btnGroepMaken);
            this.gbGroepMaken.Location = new System.Drawing.Point(65, 77);
            this.gbGroepMaken.Name = "gbGroepMaken";
            this.gbGroepMaken.Size = new System.Drawing.Size(710, 578);
            this.gbGroepMaken.TabIndex = 7;
            this.gbGroepMaken.TabStop = false;
            this.gbGroepMaken.Text = "Groep Maken";
            // 
            // tbProjectBeshrijving
            // 
            this.tbProjectBeshrijving.Location = new System.Drawing.Point(137, 353);
            this.tbProjectBeshrijving.Multiline = true;
            this.tbProjectBeshrijving.Name = "tbProjectBeshrijving";
            this.tbProjectBeshrijving.Size = new System.Drawing.Size(284, 87);
            this.tbProjectBeshrijving.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project Beshrijving :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProjectNaam
            // 
            this.lbProjectNaam.AutoSize = true;
            this.lbProjectNaam.Location = new System.Drawing.Point(137, 195);
            this.lbProjectNaam.Name = "lbProjectNaam";
            this.lbProjectNaam.Size = new System.Drawing.Size(146, 30);
            this.lbProjectNaam.TabIndex = 5;
            this.lbProjectNaam.Text = "Project naam :";
            // 
            // lbGroepMaken
            // 
            this.lbGroepMaken.AutoSize = true;
            this.lbGroepMaken.Location = new System.Drawing.Point(137, 91);
            this.lbGroepMaken.Name = "lbGroepMaken";
            this.lbGroepMaken.Size = new System.Drawing.Size(132, 30);
            this.lbGroepMaken.TabIndex = 4;
            this.lbGroepMaken.Text = "Groep naam:";
            // 
            // tbProjectNaam
            // 
            this.tbProjectNaam.Location = new System.Drawing.Point(137, 237);
            this.tbProjectNaam.Name = "tbProjectNaam";
            this.tbProjectNaam.Size = new System.Drawing.Size(284, 35);
            this.tbProjectNaam.TabIndex = 3;
            // 
            // tbGreopNaam
            // 
            this.tbGreopNaam.Location = new System.Drawing.Point(137, 137);
            this.tbGreopNaam.Name = "tbGreopNaam";
            this.tbGreopNaam.Size = new System.Drawing.Size(175, 35);
            this.tbGreopNaam.TabIndex = 2;
            // 
            // btnGroepMaken
            // 
            this.btnGroepMaken.Location = new System.Drawing.Point(137, 486);
            this.btnGroepMaken.Name = "btnGroepMaken";
            this.btnGroepMaken.Size = new System.Drawing.Size(309, 73);
            this.btnGroepMaken.TabIndex = 0;
            this.btnGroepMaken.Text = "Groep Maken";
            this.btnGroepMaken.UseVisualStyleBackColor = true;
            this.btnGroepMaken.Click += new System.EventHandler(this.btnGroepMaken_Click);
            // 
            // GroepMaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 827);
            this.Controls.Add(this.btnTerugGroep);
            this.Controls.Add(this.gbGroepMaken);
            this.Name = "GroepMaken";
            this.Text = "GroepMaken";
            this.gbGroepMaken.ResumeLayout(false);
            this.gbGroepMaken.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTerugGroep;
        private System.Windows.Forms.GroupBox gbGroepMaken;
        private System.Windows.Forms.TextBox tbProjectBeshrijving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProjectNaam;
        private System.Windows.Forms.Label lbGroepMaken;
        private System.Windows.Forms.TextBox tbProjectNaam;
        private System.Windows.Forms.TextBox tbGreopNaam;
        private System.Windows.Forms.Button btnGroepMaken;
    }
}