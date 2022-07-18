namespace HuertaEcologica_SIDominic
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btncancelar3 = new System.Windows.Forms.Button();
            this.btnrealizarpedido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidadProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncancelar3
            // 
            this.btncancelar3.Location = new System.Drawing.Point(360, 403);
            this.btncancelar3.Name = "btncancelar3";
            this.btncancelar3.Size = new System.Drawing.Size(158, 44);
            this.btncancelar3.TabIndex = 4;
            this.btncancelar3.Text = "Cancelar";
            this.btncancelar3.UseVisualStyleBackColor = true;
            this.btncancelar3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrealizarpedido
            // 
            this.btnrealizarpedido.Location = new System.Drawing.Point(712, 403);
            this.btnrealizarpedido.Name = "btnrealizarpedido";
            this.btnrealizarpedido.Size = new System.Drawing.Size(158, 44);
            this.btnrealizarpedido.TabIndex = 5;
            this.btnrealizarpedido.Text = "Realizar pedido";
            this.btnrealizarpedido.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Realice su pedido";
            // 
            // txtnombreProducto
            // 
            this.txtnombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreProducto.Location = new System.Drawing.Point(417, 118);
            this.txtnombreProducto.Name = "txtnombreProducto";
            this.txtnombreProducto.Size = new System.Drawing.Size(363, 121);
            this.txtnombreProducto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 43);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad de producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcantidadProducto
            // 
            this.txtcantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadProducto.Location = new System.Drawing.Point(417, 288);
            this.txtcantidadProducto.Name = "txtcantidadProducto";
            this.txtcantidadProducto.Size = new System.Drawing.Size(363, 75);
            this.txtcantidadProducto.TabIndex = 11;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1098, 704);
            this.Controls.Add(this.txtcantidadProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnrealizarpedido);
            this.Controls.Add(this.btncancelar3);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar3;
        private System.Windows.Forms.Button btnrealizarpedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidadProducto;
    }
}