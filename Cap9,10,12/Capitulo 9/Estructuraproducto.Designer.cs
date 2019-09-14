namespace Cap9_10_12.Capitulo_9
{
    partial class Estructuraproducto
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
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Codigolabel = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(104, 101);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(100, 23);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Codigolabel
            // 
            this.Codigolabel.AutoSize = true;
            this.Codigolabel.Location = new System.Drawing.Point(12, 23);
            this.Codigolabel.Name = "Codigolabel";
            this.Codigolabel.Size = new System.Drawing.Size(86, 13);
            this.Codigolabel.TabIndex = 1;
            this.Codigolabel.Text = "Codigo Producto";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(12, 49);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Nombre";
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(12, 75);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(37, 13);
            this.Preciolabel.TabIndex = 3;
            this.Preciolabel.Text = "Precio";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(104, 23);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigotextBox.TabIndex = 4;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(104, 49);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(100, 20);
            this.NombretextBox.TabIndex = 5;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(104, 75);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 6;
            // 
            // Estructuraproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 138);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.Codigolabel);
            this.Controls.Add(this.Guardarbutton);
            this.Name = "Estructuraproducto";
            this.Text = "Estructuraproducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label Codigolabel;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
    }
}