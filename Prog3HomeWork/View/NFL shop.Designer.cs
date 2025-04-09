namespace Prog3HomeWork
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fájlBetöltésToolStripMenuItem = new ToolStripMenuItem();
            rendelésToolStripMenuItem = new ToolStripMenuItem();
            könyvelésToolStripMenuItem = new ToolStripMenuItem();
            névjegyToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fájlBetöltésToolStripMenuItem, rendelésToolStripMenuItem, könyvelésToolStripMenuItem, névjegyToolStripMenuItem, kilépésToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(872, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fájlBetöltésToolStripMenuItem
            // 
            fájlBetöltésToolStripMenuItem.Name = "fájlBetöltésToolStripMenuItem";
            fájlBetöltésToolStripMenuItem.Size = new Size(91, 20);
            fájlBetöltésToolStripMenuItem.Text = "Fájl betöltés...";
            fájlBetöltésToolStripMenuItem.Click += fájlBetöltésToolStripMenuItem_Click;
            // 
            // rendelésToolStripMenuItem
            // 
            rendelésToolStripMenuItem.Name = "rendelésToolStripMenuItem";
            rendelésToolStripMenuItem.Size = new Size(75, 20);
            rendelésToolStripMenuItem.Text = "Rendelés...";
            rendelésToolStripMenuItem.Click += rendelésToolStripMenuItem_Click_1;
            // 
            // könyvelésToolStripMenuItem
            // 
            könyvelésToolStripMenuItem.Name = "könyvelésToolStripMenuItem";
            könyvelésToolStripMenuItem.Size = new Size(81, 20);
            könyvelésToolStripMenuItem.Text = "Könyvelés...";
            könyvelésToolStripMenuItem.Click += könyvelésToolStripMenuItem_Click;
            // 
            // névjegyToolStripMenuItem
            // 
            névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            névjegyToolStripMenuItem.Size = new Size(71, 20);
            névjegyToolStripMenuItem.Text = "Névjegy...";
            névjegyToolStripMenuItem.Click += névjegyToolStripMenuItem_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(56, 20);
            kilépésToolStripMenuItem.Text = "Kilépés";
            kilépésToolStripMenuItem.Click += kilépésToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.shield;
            pictureBox1.Location = new Point(0, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(872, 494);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 518);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fájlBetöltésToolStripMenuItem;
        private ToolStripMenuItem rendelésToolStripMenuItem;
        private ToolStripMenuItem könyvelésToolStripMenuItem;
        private ToolStripMenuItem névjegyToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
