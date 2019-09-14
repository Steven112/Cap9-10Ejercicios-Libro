namespace Cap9_10_12.Capitulo_10
{
    partial class Poligono
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
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.LongitudtextBox = new System.Windows.Forms.TextBox();
            this.PerimetrotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(119, 156);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 0;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad Lado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitud Lado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Perimetro";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(103, 38);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadtextBox.TabIndex = 4;
            // 
            // LongitudtextBox
            // 
            this.LongitudtextBox.Location = new System.Drawing.Point(103, 64);
            this.LongitudtextBox.Name = "LongitudtextBox";
            this.LongitudtextBox.Size = new System.Drawing.Size(100, 20);
            this.LongitudtextBox.TabIndex = 5;
            // 
            // PerimetrotextBox
            // 
            this.PerimetrotextBox.Location = new System.Drawing.Point(103, 90);
            this.PerimetrotextBox.Name = "PerimetrotextBox";
            this.PerimetrotextBox.Size = new System.Drawing.Size(100, 20);
            this.PerimetrotextBox.TabIndex = 6;
            // 
            // Poligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 272);
            this.Controls.Add(this.PerimetrotextBox);
            this.Controls.Add(this.LongitudtextBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcularbutton);
            this.Name = "Poligono";
            this.Text = "Poligono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.TextBox LongitudtextBox;
        private System.Windows.Forms.TextBox PerimetrotextBox;
    }
}