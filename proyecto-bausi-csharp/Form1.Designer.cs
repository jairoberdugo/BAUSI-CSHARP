namespace proyecto_bausi_csharp
{
    partial class index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.btn_agregar_descuento = new System.Windows.Forms.Button();
            this.btn_ver_existencia_productos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_salir = new System.Windows.Forms.Label();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agregar_descuento
            // 
            this.btn_agregar_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregar_descuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_descuento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_descuento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregar_descuento.Location = new System.Drawing.Point(64, 73);
            this.btn_agregar_descuento.Name = "btn_agregar_descuento";
            this.btn_agregar_descuento.Size = new System.Drawing.Size(223, 38);
            this.btn_agregar_descuento.TabIndex = 0;
            this.btn_agregar_descuento.Text = "APLICAR | ELIMINAR DESCUENTOS";
            this.btn_agregar_descuento.UseVisualStyleBackColor = false;
            this.btn_agregar_descuento.Click += new System.EventHandler(this.btn_agregar_descuento_Click);
            // 
            // btn_ver_existencia_productos
            // 
            this.btn_ver_existencia_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ver_existencia_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver_existencia_productos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_existencia_productos.ForeColor = System.Drawing.Color.Azure;
            this.btn_ver_existencia_productos.Location = new System.Drawing.Point(64, 180);
            this.btn_ver_existencia_productos.Name = "btn_ver_existencia_productos";
            this.btn_ver_existencia_productos.Size = new System.Drawing.Size(223, 37);
            this.btn_ver_existencia_productos.TabIndex = 1;
            this.btn_ver_existencia_productos.Text = "EXISTENCIA DE PRODUCTOS | SURTIR";
            this.btn_ver_existencia_productos.UseVisualStyleBackColor = false;
            this.btn_ver_existencia_productos.Click += new System.EventHandler(this.btn_ver_existencia_productos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(390, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "VENTAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::proyecto_bausi_csharp.Properties.Resources.BAUSI;
            this.pictureBox1.Location = new System.Drawing.Point(657, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_salir
            // 
            this.lbl_salir.AutoSize = true;
            this.lbl_salir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_salir.ForeColor = System.Drawing.Color.White;
            this.lbl_salir.Location = new System.Drawing.Point(389, 525);
            this.lbl_salir.Name = "lbl_salir";
            this.lbl_salir.Size = new System.Drawing.Size(47, 17);
            this.lbl_salir.TabIndex = 5;
            this.lbl_salir.Text = "SALIR";
            this.lbl_salir.Click += new System.EventHandler(this.lbl_salir_Click);
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_agregar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_producto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_agregar_producto.ForeColor = System.Drawing.Color.Azure;
            this.btn_agregar_producto.Location = new System.Drawing.Point(390, 181);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(220, 35);
            this.btn_agregar_producto.TabIndex = 6;
            this.btn_agregar_producto.Text = "AGREGAR PRODUCTOS";
            this.btn_agregar_producto.UseVisualStyleBackColor = false;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_agregar_descuento);
            this.groupBox1.Controls.Add(this.btn_agregar_producto);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_ver_existencia_productos);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(52, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 367);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAUSI | ADMINISTRACION";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(221, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "ELIMINAR PRODUCTOS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.img6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_salir);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "index";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIENDA BAUSI | INICIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar_descuento;
        private System.Windows.Forms.Button btn_ver_existencia_productos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_salir;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}

