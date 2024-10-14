namespace Ex2_TP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_text = new System.Windows.Forms.Button();
            this.lbl_displayText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_text
            // 
            this.btn_text.Location = new System.Drawing.Point(282, 58);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(177, 23);
            this.btn_text.TabIndex = 0;
            this.btn_text.Text = "Show";
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            // 
            // lbl_displayText
            // 
            this.lbl_displayText.AutoSize = true;
            this.lbl_displayText.Location = new System.Drawing.Point(341, 135);
            this.lbl_displayText.Name = "lbl_displayText";
            this.lbl_displayText.Size = new System.Drawing.Size(0, 13);
            this.lbl_displayText.TabIndex = 1;
            this.lbl_displayText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_displayText);
            this.Controls.Add(this.btn_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Label lbl_displayText;
    }
}

