
namespace SinekApp
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
            this.buton_oyunabasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buton_oyunabasla
            // 
            this.buton_oyunabasla.Location = new System.Drawing.Point(483, 264);
            this.buton_oyunabasla.Name = "buton_oyunabasla";
            this.buton_oyunabasla.Size = new System.Drawing.Size(188, 61);
            this.buton_oyunabasla.TabIndex = 0;
            this.buton_oyunabasla.Text = "Oyuna Başla";
            this.buton_oyunabasla.UseVisualStyleBackColor = true;
            this.buton_oyunabasla.Click += new System.EventHandler(this.buton_oyunabasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.buton_oyunabasla);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buton_oyunabasla;
    }
}

