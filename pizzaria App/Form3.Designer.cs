namespace pizzaria_App
{
    partial class godkendt_bestilling
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
            this.godkent_label = new System.Windows.Forms.Label();
            this.luk_vinduet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // godkent_label
            // 
            this.godkent_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.godkent_label.AutoSize = true;
            this.godkent_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godkent_label.Location = new System.Drawing.Point(132, 104);
            this.godkent_label.Name = "godkent_label";
            this.godkent_label.Size = new System.Drawing.Size(326, 52);
            this.godkent_label.TabIndex = 0;
            this.godkent_label.Text = "Tak for din bestilling\r\nOrdren sendes hurtigst muligt";
            this.godkent_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // luk_vinduet
            // 
            this.luk_vinduet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.luk_vinduet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luk_vinduet.Location = new System.Drawing.Point(165, 184);
            this.luk_vinduet.Name = "luk_vinduet";
            this.luk_vinduet.Size = new System.Drawing.Size(232, 60);
            this.luk_vinduet.TabIndex = 1;
            this.luk_vinduet.Text = "Luk vinduet";
            this.luk_vinduet.UseVisualStyleBackColor = false;
            this.luk_vinduet.Click += new System.EventHandler(this.luk_vinduet_Click);
            // 
            // godkendt_bestilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 303);
            this.Controls.Add(this.luk_vinduet);
            this.Controls.Add(this.godkent_label);
            this.Name = "godkendt_bestilling";
            this.Text = "Bestilling modtaget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label godkent_label;
        private System.Windows.Forms.Button luk_vinduet;
    }
}