﻿namespace PokemonTestAPI
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
            this.btn_Generate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_Species = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Evolve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(12, 12);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(117, 23);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate Pokemon";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 381);
            this.listBox1.TabIndex = 1;
            // 
            // txt_Species
            // 
            this.txt_Species.Location = new System.Drawing.Point(176, 14);
            this.txt_Species.Name = "txt_Species";
            this.txt_Species.Size = new System.Drawing.Size(100, 20);
            this.txt_Species.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // btn_Evolve
            // 
            this.btn_Evolve.Location = new System.Drawing.Point(290, 41);
            this.btn_Evolve.Name = "btn_Evolve";
            this.btn_Evolve.Size = new System.Drawing.Size(91, 23);
            this.btn_Evolve.TabIndex = 4;
            this.btn_Evolve.Text = "Evolve";
            this.btn_Evolve.UseVisualStyleBackColor = true;
            this.btn_Evolve.Click += new System.EventHandler(this.btn_Evolve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Evolve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Species);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_Species;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Evolve;
    }
}

