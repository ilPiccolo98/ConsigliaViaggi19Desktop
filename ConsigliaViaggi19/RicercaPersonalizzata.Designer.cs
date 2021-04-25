namespace ConsigliaViaggi19
{
    partial class RicercaPersonalizzata
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
            this.valutazioneMinimaLabel = new System.Windows.Forms.Label();
            this.valutazioneMassimaLabel = new System.Windows.Forms.Label();
            this.valutazioneMinimaComboBox = new System.Windows.Forms.ComboBox();
            this.valutazioneMassimaComboBox = new System.Windows.Forms.ComboBox();
            this.cittaLabel = new System.Windows.Forms.Label();
            this.cittaComboBox = new System.Windows.Forms.ComboBox();
            this.applicaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valutazioneMinimaLabel
            // 
            this.valutazioneMinimaLabel.AutoSize = true;
            this.valutazioneMinimaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valutazioneMinimaLabel.Location = new System.Drawing.Point(59, 25);
            this.valutazioneMinimaLabel.Name = "valutazioneMinimaLabel";
            this.valutazioneMinimaLabel.Size = new System.Drawing.Size(166, 16);
            this.valutazioneMinimaLabel.TabIndex = 0;
            this.valutazioneMinimaLabel.Text = "Media valutazione minima:";
            // 
            // valutazioneMassimaLabel
            // 
            this.valutazioneMassimaLabel.AutoSize = true;
            this.valutazioneMassimaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valutazioneMassimaLabel.Location = new System.Drawing.Point(47, 69);
            this.valutazioneMassimaLabel.Name = "valutazioneMassimaLabel";
            this.valutazioneMassimaLabel.Size = new System.Drawing.Size(178, 16);
            this.valutazioneMassimaLabel.TabIndex = 1;
            this.valutazioneMassimaLabel.Text = "Media valutazione massima:";
            // 
            // valutazioneMinimaComboBox
            // 
            this.valutazioneMinimaComboBox.FormattingEnabled = true;
            this.valutazioneMinimaComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.valutazioneMinimaComboBox.Location = new System.Drawing.Point(240, 25);
            this.valutazioneMinimaComboBox.Name = "valutazioneMinimaComboBox";
            this.valutazioneMinimaComboBox.Size = new System.Drawing.Size(47, 21);
            this.valutazioneMinimaComboBox.TabIndex = 2;
            this.valutazioneMinimaComboBox.Text = "0";
            // 
            // valutazioneMassimaComboBox
            // 
            this.valutazioneMassimaComboBox.FormattingEnabled = true;
            this.valutazioneMassimaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.valutazioneMassimaComboBox.Location = new System.Drawing.Point(240, 69);
            this.valutazioneMassimaComboBox.Name = "valutazioneMassimaComboBox";
            this.valutazioneMassimaComboBox.Size = new System.Drawing.Size(47, 21);
            this.valutazioneMassimaComboBox.TabIndex = 3;
            this.valutazioneMassimaComboBox.Text = "5";
            // 
            // cittaLabel
            // 
            this.cittaLabel.AutoSize = true;
            this.cittaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cittaLabel.Location = new System.Drawing.Point(112, 113);
            this.cittaLabel.Name = "cittaLabel";
            this.cittaLabel.Size = new System.Drawing.Size(37, 16);
            this.cittaLabel.TabIndex = 4;
            this.cittaLabel.Text = "Città:";
            // 
            // cittaComboBox
            // 
            this.cittaComboBox.FormattingEnabled = true;
            this.cittaComboBox.Location = new System.Drawing.Point(170, 112);
            this.cittaComboBox.Name = "cittaComboBox";
            this.cittaComboBox.Size = new System.Drawing.Size(121, 21);
            this.cittaComboBox.TabIndex = 7;
            // 
            // applicaButton
            // 
            this.applicaButton.Location = new System.Drawing.Point(216, 162);
            this.applicaButton.Name = "applicaButton";
            this.applicaButton.Size = new System.Drawing.Size(75, 23);
            this.applicaButton.TabIndex = 8;
            this.applicaButton.Text = "Applica";
            this.applicaButton.UseVisualStyleBackColor = true;
            this.applicaButton.Click += new System.EventHandler(this.applicaButton_Click);
            // 
            // RicercaPersonalizzata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 221);
            this.Controls.Add(this.applicaButton);
            this.Controls.Add(this.cittaComboBox);
            this.Controls.Add(this.cittaLabel);
            this.Controls.Add(this.valutazioneMassimaComboBox);
            this.Controls.Add(this.valutazioneMinimaComboBox);
            this.Controls.Add(this.valutazioneMassimaLabel);
            this.Controls.Add(this.valutazioneMinimaLabel);
            this.MaximizeBox = false;
            this.Name = "RicercaPersonalizzata";
            this.Text = "RicercaPersonalizzata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valutazioneMinimaLabel;
        private System.Windows.Forms.Label valutazioneMassimaLabel;
        private System.Windows.Forms.ComboBox valutazioneMinimaComboBox;
        private System.Windows.Forms.ComboBox valutazioneMassimaComboBox;
        private System.Windows.Forms.Label cittaLabel;
        private System.Windows.Forms.ComboBox cittaComboBox;
        private System.Windows.Forms.Button applicaButton;
    }
}