namespace u1_UrunlerProje
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.urunlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dörtgenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silindirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // urunlerToolStripMenuItem
            // 
            this.urunlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.küpToolStripMenuItem,
            this.dörtgenToolStripMenuItem,
            this.silindirToolStripMenuItem});
            this.urunlerToolStripMenuItem.Name = "urunlerToolStripMenuItem";
            this.urunlerToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.urunlerToolStripMenuItem.Text = "Urunler";
            // 
            // küpToolStripMenuItem
            // 
            this.küpToolStripMenuItem.Name = "küpToolStripMenuItem";
            this.küpToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.küpToolStripMenuItem.Text = "Küp";
            this.küpToolStripMenuItem.Click += new System.EventHandler(this.küpToolStripMenuItem_Click);
            // 
            // dörtgenToolStripMenuItem
            // 
            this.dörtgenToolStripMenuItem.Name = "dörtgenToolStripMenuItem";
            this.dörtgenToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.dörtgenToolStripMenuItem.Text = "Dörtgen";
            this.dörtgenToolStripMenuItem.Click += new System.EventHandler(this.dörtgenToolStripMenuItem_Click);
            // 
            // silindirToolStripMenuItem
            // 
            this.silindirToolStripMenuItem.Name = "silindirToolStripMenuItem";
            this.silindirToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.silindirToolStripMenuItem.Text = "Silindir";
            this.silindirToolStripMenuItem.Click += new System.EventHandler(this.silindirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 347);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dörtgenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silindirToolStripMenuItem;
    }
}

