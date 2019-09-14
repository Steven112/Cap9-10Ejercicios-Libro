namespace Cap9_10_12
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
            this.cap9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructuraEnlazadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enumeracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cap10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cap9ToolStripMenuItem,
            this.cap10ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cap9ToolStripMenuItem
            // 
            this.cap9ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructuraProductosToolStripMenuItem,
            this.estructuraEnlazadaToolStripMenuItem,
            this.enumeracionToolStripMenuItem});
            this.cap9ToolStripMenuItem.Name = "cap9ToolStripMenuItem";
            this.cap9ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.cap9ToolStripMenuItem.Text = "Cap 9";
            // 
            // estructuraProductosToolStripMenuItem
            // 
            this.estructuraProductosToolStripMenuItem.Name = "estructuraProductosToolStripMenuItem";
            this.estructuraProductosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.estructuraProductosToolStripMenuItem.Text = "Estructura productos";
            this.estructuraProductosToolStripMenuItem.Click += new System.EventHandler(this.EstructuraProductosToolStripMenuItem_Click);
            // 
            // estructuraEnlazadaToolStripMenuItem
            // 
            this.estructuraEnlazadaToolStripMenuItem.Name = "estructuraEnlazadaToolStripMenuItem";
            this.estructuraEnlazadaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.estructuraEnlazadaToolStripMenuItem.Text = "Estructura Enlazada";
            this.estructuraEnlazadaToolStripMenuItem.Click += new System.EventHandler(this.EstructuraEnlazadaToolStripMenuItem_Click);
            // 
            // enumeracionToolStripMenuItem
            // 
            this.enumeracionToolStripMenuItem.Name = "enumeracionToolStripMenuItem";
            this.enumeracionToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.enumeracionToolStripMenuItem.Text = "Enumeracion";
            this.enumeracionToolStripMenuItem.Click += new System.EventHandler(this.EnumeracionToolStripMenuItem_Click);
            // 
            // cap10ToolStripMenuItem
            // 
            this.cap10ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policogoToolStripMenuItem});
            this.cap10ToolStripMenuItem.Name = "cap10ToolStripMenuItem";
            this.cap10ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cap10ToolStripMenuItem.Text = "Cap 10";
            // 
            // policogoToolStripMenuItem
            // 
            this.policogoToolStripMenuItem.Name = "policogoToolStripMenuItem";
            this.policogoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.policogoToolStripMenuItem.Text = "Policogo";
            this.policogoToolStripMenuItem.Click += new System.EventHandler(this.PolicogoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem cap9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraEnlazadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enumeracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cap10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policogoToolStripMenuItem;
    }
}

