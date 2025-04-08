namespace Prog3HomeWork.View
{
    partial class ProductsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PriceLabel = new Label();
            label5 = new Label();
            quantityTextBox = new TextBox();
            checkBox1 = new CheckBox();
            ShirtSizeLabel = new Label();
            ShirtNumberLabel = new Label();
            NameLabel = new Label();
            TeamLabel = new Label();
            ShirtPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ShirtPictureBox).BeginInit();
            SuspendLayout();
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(514, 36);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(38, 15);
            PriceLabel.TabIndex = 17;
            PriceLabel.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(669, 33);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 16;
            label5.Text = "db";
            // 
            // quantityTextBox
            // 
            quantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            quantityTextBox.Location = new Point(616, 33);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(47, 23);
            quantityTextBox.TabIndex = 15;
            quantityTextBox.TextChanged += textBox1_TextChanged;
            quantityTextBox.KeyPress += textBox1_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.BackgroundImageLayout = ImageLayout.Center;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            checkBox1.Location = new Point(587, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(12, 12);
            checkBox1.TabIndex = 14;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ShirtSizeLabel
            // 
            ShirtSizeLabel.AutoSize = true;
            ShirtSizeLabel.Location = new Point(419, 36);
            ShirtSizeLabel.Name = "ShirtSizeLabel";
            ShirtSizeLabel.Size = new Size(38, 15);
            ShirtSizeLabel.TabIndex = 13;
            ShirtSizeLabel.Text = "label4";
            // 
            // ShirtNumberLabel
            // 
            ShirtNumberLabel.AutoSize = true;
            ShirtNumberLabel.Location = new Point(320, 36);
            ShirtNumberLabel.Name = "ShirtNumberLabel";
            ShirtNumberLabel.Size = new Size(38, 15);
            ShirtNumberLabel.TabIndex = 12;
            ShirtNumberLabel.Text = "label3";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(208, 36);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(38, 15);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "label2";
            // 
            // TeamLabel
            // 
            TeamLabel.AutoSize = true;
            TeamLabel.Location = new Point(98, 36);
            TeamLabel.Name = "TeamLabel";
            TeamLabel.Size = new Size(38, 15);
            TeamLabel.TabIndex = 10;
            TeamLabel.Text = "label1";
            // 
            // ShirtPictureBox
            // 
            ShirtPictureBox.Location = new Point(14, 14);
            ShirtPictureBox.Name = "ShirtPictureBox";
            ShirtPictureBox.Size = new Size(68, 67);
            ShirtPictureBox.TabIndex = 9;
            ShirtPictureBox.TabStop = false;
            // 
            // ProductsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PriceLabel);
            Controls.Add(label5);
            Controls.Add(quantityTextBox);
            Controls.Add(checkBox1);
            Controls.Add(ShirtSizeLabel);
            Controls.Add(ShirtNumberLabel);
            Controls.Add(NameLabel);
            Controls.Add(TeamLabel);
            Controls.Add(ShirtPictureBox);
            Name = "ProductsControl";
            Size = new Size(709, 97);
            ((System.ComponentModel.ISupportInitialize)ShirtPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PriceLabel;
        private Label label5;
        private TextBox quantityTextBox;
        private CheckBox checkBox1;
        private Label ShirtSizeLabel;
        private Label ShirtNumberLabel;
        private Label NameLabel;
        private Label TeamLabel;
        private PictureBox ShirtPictureBox;
    }
}
