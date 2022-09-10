namespace HuertaEcologica_SIDominic
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnclienteterminal = new System.Windows.Forms.Button();
            this.btnclienteempresa = new System.Windows.Forms.Button();
            this.btnvolver0 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclienteterminal
            // 
            this.btnclienteterminal.Location = new System.Drawing.Point(578, 350);
            this.btnclienteterminal.Name = "btnclienteterminal";
            this.btnclienteterminal.Size = new System.Drawing.Size(195, 66);
            this.btnclienteterminal.TabIndex = 1;
            this.btnclienteterminal.Text = "Cliente terminal";
            this.btnclienteterminal.UseVisualStyleBackColor = true;
            this.btnclienteterminal.Click += new System.EventHandler(this.btnclienteterminal_Click);
            // 
            // btnclienteempresa
            // 
            this.btnclienteempresa.Location = new System.Drawing.Point(909, 350);
            this.btnclienteempresa.Name = "btnclienteempresa";
            this.btnclienteempresa.Size = new System.Drawing.Size(195, 66);
            this.btnclienteempresa.TabIndex = 2;
            this.btnclienteempresa.Text = "Cliente empresa";
            this.btnclienteempresa.UseVisualStyleBackColor = true;
            this.btnclienteempresa.Click += new System.EventHandler(this.btnclienteempresa_Click);
            // 
            // btnvolver0
            // 
            this.btnvolver0.Location = new System.Drawing.Point(756, 550);
            this.btnvolver0.Name = "btnvolver0";
            this.btnvolver0.Size = new System.Drawing.Size(186, 46);
            this.btnvolver0.TabIndex = 3;
            this.btnvolver0.Text = "Volver";
            this.btnvolver0.UseVisualStyleBackColor = true;
            this.btnvolver0.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 67);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione tipo de cliente";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1242, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvolver0);
            this.Controls.Add(this.btnclienteempresa);
            this.Controls.Add(this.btnclienteterminal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Seleccion de cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnclienteterminal;
        private System.Windows.Forms.Button btnclienteempresa;
        private System.Windows.Forms.Button btnvolver0;
        private System.Windows.Forms.Label label2;
    }
}