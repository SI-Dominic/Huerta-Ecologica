namespace HuertaEcologica_SIDominic
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btnvolver2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario1 = new System.Windows.Forms.TextBox();
            this.txtcontraseña1 = new System.Windows.Forms.TextBox();
            this.btnaceptar1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvolver2
            // 
            this.btnvolver2.Location = new System.Drawing.Point(574, 430);
            this.btnvolver2.Name = "btnvolver2";
            this.btnvolver2.Size = new System.Drawing.Size(128, 42);
            this.btnvolver2.TabIndex = 3;
            this.btnvolver2.Text = "Volver";
            this.btnvolver2.UseVisualStyleBackColor = true;
            this.btnvolver2.Click += new System.EventHandler(this.btncancelar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // txtusuario1
            // 
            this.txtusuario1.Location = new System.Drawing.Point(594, 212);
            this.txtusuario1.Name = "txtusuario1";
            this.txtusuario1.Size = new System.Drawing.Size(210, 26);
            this.txtusuario1.TabIndex = 6;
            // 
            // txtcontraseña1
            // 
            this.txtcontraseña1.Location = new System.Drawing.Point(594, 279);
            this.txtcontraseña1.Name = "txtcontraseña1";
            this.txtcontraseña1.Size = new System.Drawing.Size(210, 26);
            this.txtcontraseña1.TabIndex = 7;
            // 
            // btnaceptar1
            // 
            this.btnaceptar1.Location = new System.Drawing.Point(745, 430);
            this.btnaceptar1.Name = "btnaceptar1";
            this.btnaceptar1.Size = new System.Drawing.Size(128, 42);
            this.btnaceptar1.TabIndex = 8;
            this.btnaceptar1.Text = "Aceptar";
            this.btnaceptar1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 71);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1253, 778);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnaceptar1);
            this.Controls.Add(this.txtcontraseña1);
            this.Controls.Add(this.txtusuario1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnvolver2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Cliente empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnvolver2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario1;
        private System.Windows.Forms.TextBox txtcontraseña1;
        private System.Windows.Forms.Button btnaceptar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}