namespace Prog3HomeWork.View
{
    partial class Rendelés
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            OrderButton = new Button();
            OrderSumLabel = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(737, 399);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 420);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 1;
            label1.Text = "Rendelés összege:";
            // 
            // OrderButton
            // 
            OrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OrderButton.FlatStyle = FlatStyle.Flat;
            OrderButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            OrderButton.Location = new Point(598, 413);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(98, 35);
            OrderButton.TabIndex = 2;
            OrderButton.Text = "Rendelés";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // OrderSumLabel
            // 
            OrderSumLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OrderSumLabel.AutoSize = true;
            OrderSumLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OrderSumLabel.ForeColor = Color.Green;
            OrderSumLabel.Location = new Point(165, 417);
            OrderSumLabel.Name = "OrderSumLabel";
            OrderSumLabel.Size = new Size(61, 25);
            OrderSumLabel.TabIndex = 3;
            OrderSumLabel.Text = "$0.00";
            // 
            // Rendelés
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 460);
            Controls.Add(OrderSumLabel);
            Controls.Add(OrderButton);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Rendelés";
            Text = "Rendelések";
            Load += Rendelések_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button OrderButton;
        private Label OrderSumLabel;
    }
}