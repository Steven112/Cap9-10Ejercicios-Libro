namespace Cap9_10_12.Capitulo_9
{
    partial class PersonaMascota
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
            this.NombremascotatextBox = new System.Windows.Forms.TextBox();
            this.EdadMacotatextBox = new System.Windows.Forms.TextBox();
            this.RazatextBox = new System.Windows.Forms.TextBox();
            this.NombreDuenotextBox = new System.Windows.Forms.TextBox();
            this.EdadDuenotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(104, 169);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(100, 23);
            this.Guardarbutton.TabIndex = 0;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // NombremascotatextBox
            // 
            this.NombremascotatextBox.Location = new System.Drawing.Point(104, 39);
            this.NombremascotatextBox.Name = "NombremascotatextBox";
            this.NombremascotatextBox.Size = new System.Drawing.Size(100, 20);
            this.NombremascotatextBox.TabIndex = 1;
            // 
            // EdadMacotatextBox
            // 
            this.EdadMacotatextBox.Location = new System.Drawing.Point(104, 65);
            this.EdadMacotatextBox.Name = "EdadMacotatextBox";
            this.EdadMacotatextBox.Size = new System.Drawing.Size(100, 20);
            this.EdadMacotatextBox.TabIndex = 2;
            // 
            // RazatextBox
            // 
            this.RazatextBox.Location = new System.Drawing.Point(104, 91);
            this.RazatextBox.Name = "RazatextBox";
            this.RazatextBox.Size = new System.Drawing.Size(100, 20);
            this.RazatextBox.TabIndex = 3;
            // 
            // NombreDuenotextBox
            // 
            this.NombreDuenotextBox.Location = new System.Drawing.Point(104, 117);
            this.NombreDuenotextBox.Name = "NombreDuenotextBox";
            this.NombreDuenotextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreDuenotextBox.TabIndex = 4;
            this.NombreDuenotextBox.TextChanged += new System.EventHandler(this.NombreDuenotextBox_TextChanged);
            // 
            // EdadDuenotextBox
            // 
            this.EdadDuenotextBox.Location = new System.Drawing.Point(104, 143);
            this.EdadDuenotextBox.Name = "EdadDuenotextBox";
            this.EdadDuenotextBox.Size = new System.Drawing.Size(100, 20);
            this.EdadDuenotextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Raza Mascota";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edad Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre Dueño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Edad Dueño";
            // 
            // PersonaMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 209);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EdadDuenotextBox);
            this.Controls.Add(this.NombreDuenotextBox);
            this.Controls.Add(this.RazatextBox);
            this.Controls.Add(this.EdadMacotatextBox);
            this.Controls.Add(this.NombremascotatextBox);
            this.Controls.Add(this.Guardarbutton);
            this.Name = "PersonaMascota";
            this.Text = "PersonaMascota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.TextBox NombremascotatextBox;
        private System.Windows.Forms.TextBox EdadMacotatextBox;
        private System.Windows.Forms.TextBox RazatextBox;
        private System.Windows.Forms.TextBox NombreDuenotextBox;
        private System.Windows.Forms.TextBox EdadDuenotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}