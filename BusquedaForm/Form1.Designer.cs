﻿namespace BusquedaForm
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
            this.richtexBusca = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richtexBusca
            // 
            this.richtexBusca.Location = new System.Drawing.Point(24, 35);
            this.richtexBusca.Name = "richtexBusca";
            this.richtexBusca.Size = new System.Drawing.Size(371, 252);
            this.richtexBusca.TabIndex = 0;
            this.richtexBusca.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 316);
            this.Controls.Add(this.richtexBusca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtexBusca;
    }
}

