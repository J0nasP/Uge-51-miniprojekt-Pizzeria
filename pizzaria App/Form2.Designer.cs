namespace pizzaria_App
{
    partial class Tilbehør
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.afbryd_button = new System.Windows.Forms.Button();
            this.tilfoej_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Fuldkornsdej",
            "Bacon",
            "Skinke",
            "Oksekød",
            "Salat",
            "Kebab",
            "Peperoni",
            "Dressing"});
            this.checkedListBox1.Location = new System.Drawing.Point(120, 37);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(286, 157);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // afbryd_button
            // 
            this.afbryd_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.afbryd_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afbryd_button.Location = new System.Drawing.Point(278, 212);
            this.afbryd_button.Name = "afbryd_button";
            this.afbryd_button.Size = new System.Drawing.Size(128, 37);
            this.afbryd_button.TabIndex = 1;
            this.afbryd_button.Text = "Afbryd";
            this.afbryd_button.UseVisualStyleBackColor = false;
            this.afbryd_button.Click += new System.EventHandler(this.afbryd_button_Click);
            // 
            // tilfoej_button
            // 
            this.tilfoej_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tilfoej_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tilfoej_button.Location = new System.Drawing.Point(120, 212);
            this.tilfoej_button.Name = "tilfoej_button";
            this.tilfoej_button.Size = new System.Drawing.Size(128, 37);
            this.tilfoej_button.TabIndex = 2;
            this.tilfoej_button.Text = "Tilføj";
            this.tilfoej_button.UseVisualStyleBackColor = false;
            // 
            // Tilbehør
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 268);
            this.Controls.Add(this.tilfoej_button);
            this.Controls.Add(this.afbryd_button);
            this.Controls.Add(this.checkedListBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Tilbehør";
            this.Text = "Tilbehør";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button afbryd_button;
        private System.Windows.Forms.Button tilfoej_button;
    }
}