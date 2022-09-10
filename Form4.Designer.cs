namespace HuertaEcologica_SIDominic
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontraseña0 = new System.Windows.Forms.TextBox();
            this.txtusuario0 = new System.Windows.Forms.TextBox();
            this.btnvolver1 = new System.Windows.Forms.Button();
            this.btniniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(495, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(495, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // txtcontraseña0
            // 
            this.txtcontraseña0.Location = new System.Drawing.Point(626, 378);
            this.txtcontraseña0.Name = "txtcontraseña0";
            this.txtcontraseña0.Size = new System.Drawing.Size(166, 26);
            this.txtcontraseña0.TabIndex = 3;
            // 
            // txtusuario0
            // 
            this.txtusuario0.Location = new System.Drawing.Point(626, 256);
            this.txtusuario0.Name = "txtusuario0";
            this.txtusuario0.Size = new System.Drawing.Size(166, 26);
            this.txtusuario0.TabIndex = 4;
            // 
            // btnvolver1
            // 
            this.btnvolver1.Location = new System.Drawing.Point(571, 493);
            this.btnvolver1.Name = "btnvolver1";
            this.btnvolver1.Size = new System.Drawing.Size(114, 38);
            this.btnvolver1.TabIndex = 5;
            this.btnvolver1.Text = "Volver";
            this.btnvolver1.UseVisualStyleBackColor = true;
            this.btnvolver1.Click += new System.EventHandler(this.btnvolver1_Click);
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(717, 493);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(114, 38);
            this.btniniciar.TabIndex = 6;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cliente terminal";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.btnvolver1);
            this.Controls.Add(this.txtusuario0);
            this.Controls.Add(this.txtcontraseña0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Cliente terminal";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontraseña0;
        private System.Windows.Forms.TextBox txtusuario0;
        private System.Windows.Forms.Button btnvolver1;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Label label1;
    }
}