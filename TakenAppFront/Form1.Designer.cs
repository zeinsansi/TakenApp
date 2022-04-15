
namespace TakenAppFront
{
    partial class Form1
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
            this.gbTaken = new System.Windows.Forms.GroupBox();
            this.lbxTaken = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NaamLabel = new System.Windows.Forms.Label();
            this.beschrijvingLabel = new System.Windows.Forms.Label();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTaakVerwijderen = new System.Windows.Forms.Button();
            this.gbTaken.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaken
            // 
            this.gbTaken.Controls.Add(this.lbxTaken);
            this.gbTaken.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTaken.Location = new System.Drawing.Point(12, 35);
            this.gbTaken.Name = "gbTaken";
            this.gbTaken.Size = new System.Drawing.Size(474, 501);
            this.gbTaken.TabIndex = 0;
            this.gbTaken.TabStop = false;
            this.gbTaken.Text = "Taken";
            // 
            // lbxTaken
            // 
            this.lbxTaken.FormattingEnabled = true;
            this.lbxTaken.Location = new System.Drawing.Point(17, 34);
            this.lbxTaken.Name = "lbxTaken";
            this.lbxTaken.Size = new System.Drawing.Size(442, 452);
            this.lbxTaken.TabIndex = 1;
            this.lbxTaken.SelectedIndexChanged += new System.EventHandler(this.lbxTaken_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Taken Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(29, 578);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(208, 59);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnGreopForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(539, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Beschrijving:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(539, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naam:";
            // 
            // NaamLabel
            // 
            this.NaamLabel.AutoSize = true;
            this.NaamLabel.Location = new System.Drawing.Point(539, 99);
            this.NaamLabel.Name = "NaamLabel";
            this.NaamLabel.Size = new System.Drawing.Size(0, 30);
            this.NaamLabel.TabIndex = 6;
            // 
            // beschrijvingLabel
            // 
            this.beschrijvingLabel.AutoSize = true;
            this.beschrijvingLabel.Location = new System.Drawing.Point(539, 200);
            this.beschrijvingLabel.Name = "beschrijvingLabel";
            this.beschrijvingLabel.Size = new System.Drawing.Size(0, 30);
            this.beschrijvingLabel.TabIndex = 7;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Location = new System.Drawing.Point(539, 384);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(0, 30);
            this.deadlineLabel.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(539, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Deadline:";
            // 
            // btnTaakVerwijderen
            // 
            this.btnTaakVerwijderen.Location = new System.Drawing.Point(539, 477);
            this.btnTaakVerwijderen.Name = "btnTaakVerwijderen";
            this.btnTaakVerwijderen.Size = new System.Drawing.Size(181, 59);
            this.btnTaakVerwijderen.TabIndex = 10;
            this.btnTaakVerwijderen.Text = "Taak verwijderen";
            this.btnTaakVerwijderen.UseVisualStyleBackColor = true;
            this.btnTaakVerwijderen.Click += new System.EventHandler(this.btnTaakVerwijderen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 699);
            this.Controls.Add(this.btnTaakVerwijderen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deadlineLabel);
            this.Controls.Add(this.beschrijvingLabel);
            this.Controls.Add(this.NaamLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbTaken);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taken";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTaken.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaken;
        private System.Windows.Forms.CheckedListBox lbxTaken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTerug;
        private Label label1;
        private Label label2;
        private Label NaamLabel;
        private Label beschrijvingLabel;
        private Label deadlineLabel;
        private Label label6;
        private Button btnTaakVerwijderen;
    }
}

