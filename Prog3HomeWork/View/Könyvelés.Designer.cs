namespace Prog3HomeWork.View
{
    partial class Könyvelés
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            QuantityLabel = new Label();
            PurchaseLabel = new Label();
            SellingLabel = new Label();
            ProfitLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 0;
            label1.Text = "Rendelések száma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 1;
            label2.Text = "Beszerzési ár:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 2;
            label3.Text = "Eladási ár:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 3;
            label4.Text = "Nyereség:";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            QuantityLabel.ForeColor = Color.FromArgb(255, 128, 0);
            QuantityLabel.Location = new Point(158, 30);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(0, 21);
            QuantityLabel.TabIndex = 4;
            // 
            // PurchaseLabel
            // 
            PurchaseLabel.AutoSize = true;
            PurchaseLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PurchaseLabel.ForeColor = Color.Green;
            PurchaseLabel.Location = new Point(158, 74);
            PurchaseLabel.Name = "PurchaseLabel";
            PurchaseLabel.Size = new Size(0, 21);
            PurchaseLabel.TabIndex = 5;
            // 
            // SellingLabel
            // 
            SellingLabel.AutoSize = true;
            SellingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            SellingLabel.ForeColor = Color.Red;
            SellingLabel.Location = new Point(158, 114);
            SellingLabel.Name = "SellingLabel";
            SellingLabel.Size = new Size(0, 21);
            SellingLabel.TabIndex = 6;
            // 
            // ProfitLabel
            // 
            ProfitLabel.AutoSize = true;
            ProfitLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            ProfitLabel.ForeColor = Color.FromArgb(128, 128, 255);
            ProfitLabel.Location = new Point(158, 152);
            ProfitLabel.Name = "ProfitLabel";
            ProfitLabel.Size = new Size(0, 21);
            ProfitLabel.TabIndex = 7;
            // 
            // Könyvelés
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 206);
            Controls.Add(ProfitLabel);
            Controls.Add(SellingLabel);
            Controls.Add(PurchaseLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Könyvelés";
            Text = "Könyvelés";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label QuantityLabel;
        private Label PurchaseLabel;
        private Label SellingLabel;
        private Label ProfitLabel;
    }
}