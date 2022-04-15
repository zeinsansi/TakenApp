
namespace TaakverdelingApp
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
            this.btnMijnGreop = new System.Windows.Forms.Button();
            this.gbTaken.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTaken
            // 
            this.gbTaken.Controls.Add(this.lbxTaken);
            this.gbTaken.Location = new System.Drawing.Point(188, 169);
            this.gbTaken.Name = "gbTaken";
            this.gbTaken.Size = new System.Drawing.Size(474, 318);
            this.gbTaken.TabIndex = 0;
            this.gbTaken.TabStop = false;
            this.gbTaken.Text = "Taken";
            // 
            // lbxTaken
            // 
            this.lbxTaken.FormattingEnabled = true;
            this.lbxTaken.Location = new System.Drawing.Point(0, 31);
            this.lbxTaken.Name = "lbxTaken";
            this.lbxTaken.Size = new System.Drawing.Size(474, 260);
            this.lbxTaken.TabIndex = 1;
            this.lbxTaken.SelectedIndexChanged += new System.EventHandler(this.lbxTaken_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Taken Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMijnGreop
            // 
            this.btnMijnGreop.Location = new System.Drawing.Point(716, 43);
            this.btnMijnGreop.Name = "btnMijnGreop";
            this.btnMijnGreop.Size = new System.Drawing.Size(208, 59);
            this.btnMijnGreop.TabIndex = 3;
            this.btnMijnGreop.Text = "Mijn Groepen";
            this.btnMijnGreop.UseVisualStyleBackColor = true;
            this.btnMijnGreop.Click += new System.EventHandler(this.btnGreopForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 699);
            this.Controls.Add(this.btnMijnGreop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbTaken);
            this.Name = "Form1";
            this.Text = "Taken";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTaken.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTaken;
        private System.Windows.Forms.CheckedListBox lbxTaken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMijnGreop;
    }
}

