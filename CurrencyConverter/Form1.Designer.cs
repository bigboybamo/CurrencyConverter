namespace CurrencyConverter
{
    partial class CurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyConverter));
            AmountLabel = new Label();
            AmountTextBox = new TextBox();
            FromLabel = new Label();
            ToLabel = new Label();
            FromComboBox = new ComboBox();
            ToComboBox = new ComboBox();
            ConvertButton = new Button();
            ConvertedLabel = new Label();
            SuspendLayout();
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(314, 63);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(126, 25);
            AmountLabel.TabIndex = 0;
            AmountLabel.Text = "Enter Amount:";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(200, 110);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(336, 31);
            AmountTextBox.TabIndex = 1;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(200, 188);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(58, 25);
            FromLabel.TabIndex = 2;
            FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(463, 188);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(34, 25);
            ToLabel.TabIndex = 3;
            ToLabel.Text = "To:";
            // 
            // FromComboBox
            // 
            FromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FromComboBox.FormattingEnabled = true;
            FromComboBox.Location = new Point(200, 230);
            FromComboBox.Name = "FromComboBox";
            FromComboBox.Size = new Size(78, 33);
            FromComboBox.TabIndex = 4;
            // 
            // ToComboBox
            // 
            ToComboBox.FormattingEnabled = true;
            ToComboBox.Location = new Point(463, 230);
            ToComboBox.Name = "ToComboBox";
            ToComboBox.Size = new Size(73, 33);
            ToComboBox.TabIndex = 5;
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(314, 288);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(112, 34);
            ConvertButton.TabIndex = 6;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // ConvertedLabel
            // 
            ConvertedLabel.AutoSize = true;
            ConvertedLabel.Location = new Point(279, 372);
            ConvertedLabel.Name = "ConvertedLabel";
            ConvertedLabel.Size = new Size(116, 25);
            ConvertedLabel.TabIndex = 7;
            ConvertedLabel.Text = "Convert label";
            ConvertedLabel.Visible = false;
            // 
            // CurrencyConverter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConvertedLabel);
            Controls.Add(ConvertButton);
            Controls.Add(ToComboBox);
            Controls.Add(FromComboBox);
            Controls.Add(ToLabel);
            Controls.Add(FromLabel);
            Controls.Add(AmountTextBox);
            Controls.Add(AmountLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CurrencyConverter";
            Text = "Currency Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AmountLabel;
        private TextBox AmountTextBox;
        private Label FromLabel;
        private Label ToLabel;
        private ComboBox FromComboBox;
        private ComboBox ToComboBox;
        private Button ConvertButton;
        private Label ConvertedLabel;
    }
}
