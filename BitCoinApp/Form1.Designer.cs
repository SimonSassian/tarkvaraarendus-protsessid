namespace BitCoinApp
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
            this.CurrencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.bitcoinLabel = new System.Windows.Forms.Label();
            this.bitcoinTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrencyCombo
            // 
            this.CurrencyCombo.FormattingEnabled = true;
            this.CurrencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.CurrencyCombo.Location = new System.Drawing.Point(40, 33);
            this.CurrencyCombo.Name = "CurrencyCombo";
            this.CurrencyCombo.Size = new System.Drawing.Size(121, 21);
            this.CurrencyCombo.TabIndex = 0;
            this.CurrencyCombo.Text = "Select Currency";
            // 
            // btnGetRates
            // 
            this.btnGetRates.Location = new System.Drawing.Point(40, 129);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(75, 23);
            this.btnGetRates.TabIndex = 1;
            this.btnGetRates.Text = "Get Rates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            this.btnGetRates.Click += new System.EventHandler(this.btnGetRates_Click);
            // 
            // bitcoinLabel
            // 
            this.bitcoinLabel.AutoSize = true;
            this.bitcoinLabel.Location = new System.Drawing.Point(37, 71);
            this.bitcoinLabel.Name = "bitcoinLabel";
            this.bitcoinLabel.Size = new System.Drawing.Size(90, 13);
            this.bitcoinLabel.TabIndex = 3;
            this.bitcoinLabel.Text = "Amount of Bitcoin";
            // 
            // bitcoinTextBox
            // 
            this.bitcoinTextBox.Location = new System.Drawing.Point(40, 87);
            this.bitcoinTextBox.Name = "bitcoinTextBox";
            this.bitcoinTextBox.Size = new System.Drawing.Size(100, 20);
            this.bitcoinTextBox.TabIndex = 4;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(37, 177);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Result";
            this.resultLabel.Visible = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(40, 193);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.bitcoinTextBox);
            this.Controls.Add(this.bitcoinLabel);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.CurrencyCombo);
            this.Name = "Form1";
            this.Text = "BitcoinCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyCombo;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.Label bitcoinLabel;
        private System.Windows.Forms.TextBox bitcoinTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

