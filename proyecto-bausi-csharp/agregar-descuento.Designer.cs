namespace proyecto_bausi_csharp
{
    partial class agregar_descuento
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor_descuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_para_descuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eliminard_a_id = new System.Windows.Forms.Button();
            this.btn_descuento_atodos = new System.Windows.Forms.Button();
            this.btn_eliminard_playeras = new System.Windows.Forms.Button();
            this.btn_eliminard_combos = new System.Windows.Forms.Button();
            this.btn_eliminard_tshirts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_eliminar_todos_descuentos = new System.Windows.Forms.Button();
            this.btn_descuento_id = new System.Windows.Forms.Button();
            this.btn_descuento_todos_tshirts = new System.Windows.Forms.Button();
            this.btn_descuento_todas_playeras = new System.Windows.Forms.Button();
            this.btn_descuento_todos_combos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "  DESCUENTO: ";
            // 
            // txt_valor_descuento
            // 
            this.txt_valor_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_valor_descuento.Location = new System.Drawing.Point(143, 90);
            this.txt_valor_descuento.Name = "txt_valor_descuento";
            this.txt_valor_descuento.Size = new System.Drawing.Size(57, 23);
            this.txt_valor_descuento.TabIndex = 1;
            this.txt_valor_descuento.TextChanged += new System.EventHandler(this.txt_valor_descuento_TextChanged);
            this.txt_valor_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_descuento_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿DESEA APLICARLO A UNA REFERENCIA EN ESPECIFICO?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "DIGITE EL ID DEL PRODUCTO: ";
            // 
            // id_para_descuento
            // 
            this.id_para_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.id_para_descuento.Location = new System.Drawing.Point(265, 238);
            this.id_para_descuento.Name = "id_para_descuento";
            this.id_para_descuento.Size = new System.Drawing.Size(91, 23);
            this.id_para_descuento.TabIndex = 9;
            this.id_para_descuento.TextChanged += new System.EventHandler(this.id_para_descuento_TextChanged);
            this.id_para_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_para_descuento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(29, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(725, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "NOTA: Si ya existe un descuento para el (los) producto (s) su valor sera REEMPLAZ" +
    "ADO.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(197, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(469, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "¿DESEA ELIMINAR TODOS LOS DESCUENTOS?";
            // 
            // eliminard_a_id
            // 
            this.eliminard_a_id.BackColor = System.Drawing.Color.Transparent;
            this.eliminard_a_id.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.eliminard_a_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminard_a_id.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.eliminard_a_id.ForeColor = System.Drawing.Color.DarkRed;
            this.eliminard_a_id.Location = new System.Drawing.Point(631, 353);
            this.eliminard_a_id.Name = "eliminard_a_id";
            this.eliminard_a_id.Size = new System.Drawing.Size(150, 54);
            this.eliminard_a_id.TabIndex = 20;
            this.eliminard_a_id.Text = "ELIMINAR DESCUENTO A LA ID DIGITADA.";
            this.eliminard_a_id.UseVisualStyleBackColor = false;
            this.eliminard_a_id.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_descuento_atodos
            // 
            this.btn_descuento_atodos.BackColor = System.Drawing.Color.Transparent;
            this.btn_descuento_atodos.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_descuento_atodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_descuento_atodos.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_descuento_atodos.Location = new System.Drawing.Point(610, 187);
            this.btn_descuento_atodos.Name = "btn_descuento_atodos";
            this.btn_descuento_atodos.Size = new System.Drawing.Size(153, 48);
            this.btn_descuento_atodos.TabIndex = 19;
            this.btn_descuento_atodos.Text = "APLICAR A TODOS LOS PRODUCTOS";
            this.btn_descuento_atodos.UseVisualStyleBackColor = false;
            this.btn_descuento_atodos.Click += new System.EventHandler(this.btn_descuento_atodos_Click);
            // 
            // btn_eliminard_playeras
            // 
            this.btn_eliminard_playeras.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminard_playeras.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_eliminard_playeras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminard_playeras.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_eliminard_playeras.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_eliminard_playeras.Location = new System.Drawing.Point(435, 353);
            this.btn_eliminard_playeras.Name = "btn_eliminard_playeras";
            this.btn_eliminard_playeras.Size = new System.Drawing.Size(192, 54);
            this.btn_eliminard_playeras.TabIndex = 16;
            this.btn_eliminard_playeras.Text = "ELIMINAR DESCUENTOS DE LAS PLAYERAS.";
            this.btn_eliminard_playeras.UseVisualStyleBackColor = false;
            this.btn_eliminard_playeras.Click += new System.EventHandler(this.btn_eliminard_playeras_Click);
            // 
            // btn_eliminard_combos
            // 
            this.btn_eliminard_combos.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminard_combos.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_eliminard_combos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminard_combos.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_eliminard_combos.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_eliminard_combos.Location = new System.Drawing.Point(224, 353);
            this.btn_eliminard_combos.Name = "btn_eliminard_combos";
            this.btn_eliminard_combos.Size = new System.Drawing.Size(192, 54);
            this.btn_eliminard_combos.TabIndex = 15;
            this.btn_eliminard_combos.Text = "ELIMINAR DESCUENTOS DE LOS COMBOS BAUSI.";
            this.btn_eliminard_combos.UseVisualStyleBackColor = false;
            this.btn_eliminard_combos.Click += new System.EventHandler(this.btn_eliminard_combos_Click);
            // 
            // btn_eliminard_tshirts
            // 
            this.btn_eliminard_tshirts.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminard_tshirts.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_eliminard_tshirts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminard_tshirts.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_eliminard_tshirts.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_eliminard_tshirts.Location = new System.Drawing.Point(17, 353);
            this.btn_eliminard_tshirts.Name = "btn_eliminard_tshirts";
            this.btn_eliminard_tshirts.Size = new System.Drawing.Size(192, 54);
            this.btn_eliminard_tshirts.TabIndex = 14;
            this.btn_eliminard_tshirts.Text = "ELIMINAR DESCUENTOS DE LOS T-SHIRTS.";
            this.btn_eliminard_tshirts.UseVisualStyleBackColor = false;
            this.btn_eliminard_tshirts.Click += new System.EventHandler(this.btn_eliminard_tshirts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::proyecto_bausi_csharp.Properties.Resources.BAUSI;
            this.pictureBox1.Location = new System.Drawing.Point(241, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_eliminar_todos_descuentos
            // 
            this.btn_eliminar_todos_descuentos.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminar_todos_descuentos.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_eliminar_todos_descuentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_todos_descuentos.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_eliminar_todos_descuentos.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_eliminar_todos_descuentos.Location = new System.Drawing.Point(16, 425);
            this.btn_eliminar_todos_descuentos.Name = "btn_eliminar_todos_descuentos";
            this.btn_eliminar_todos_descuentos.Size = new System.Drawing.Size(761, 37);
            this.btn_eliminar_todos_descuentos.TabIndex = 12;
            this.btn_eliminar_todos_descuentos.Text = "ELIMINAR TODOS LOS DESCUENTOS.";
            this.btn_eliminar_todos_descuentos.UseVisualStyleBackColor = false;
            this.btn_eliminar_todos_descuentos.Click += new System.EventHandler(this.btn_eliminar_todos_descuentos_Click);
            // 
            // btn_descuento_id
            // 
            this.btn_descuento_id.BackColor = System.Drawing.Color.Transparent;
            this.btn_descuento_id.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_descuento_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_descuento_id.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_descuento_id.Location = new System.Drawing.Point(610, 253);
            this.btn_descuento_id.Name = "btn_descuento_id";
            this.btn_descuento_id.Size = new System.Drawing.Size(153, 48);
            this.btn_descuento_id.TabIndex = 10;
            this.btn_descuento_id.Text = "APLICAR A LA ID DIGITADA";
            this.btn_descuento_id.UseVisualStyleBackColor = false;
            this.btn_descuento_id.Click += new System.EventHandler(this.btn_descuento_id_Click);
            // 
            // btn_descuento_todos_tshirts
            // 
            this.btn_descuento_todos_tshirts.BackColor = System.Drawing.Color.Transparent;
            this.btn_descuento_todos_tshirts.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_descuento_todos_tshirts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_descuento_todos_tshirts.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_descuento_todos_tshirts.Location = new System.Drawing.Point(610, 126);
            this.btn_descuento_todos_tshirts.Name = "btn_descuento_todos_tshirts";
            this.btn_descuento_todos_tshirts.Size = new System.Drawing.Size(153, 49);
            this.btn_descuento_todos_tshirts.TabIndex = 6;
            this.btn_descuento_todos_tshirts.Text = "APLICAR A TODOS LOS T-SHIRTS";
            this.btn_descuento_todos_tshirts.UseVisualStyleBackColor = false;
            this.btn_descuento_todos_tshirts.Click += new System.EventHandler(this.btn_descuento_todos_tshirts_Click);
            // 
            // btn_descuento_todas_playeras
            // 
            this.btn_descuento_todas_playeras.BackColor = System.Drawing.Color.Transparent;
            this.btn_descuento_todas_playeras.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_descuento_todas_playeras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_descuento_todas_playeras.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descuento_todas_playeras.Location = new System.Drawing.Point(610, 12);
            this.btn_descuento_todas_playeras.Name = "btn_descuento_todas_playeras";
            this.btn_descuento_todas_playeras.Size = new System.Drawing.Size(153, 46);
            this.btn_descuento_todas_playeras.TabIndex = 3;
            this.btn_descuento_todas_playeras.Text = "APLICAR A TODAS LAS PLAYERAS";
            this.btn_descuento_todas_playeras.UseVisualStyleBackColor = false;
            this.btn_descuento_todas_playeras.Click += new System.EventHandler(this.btn_descuento_todas_playeras_Click);
            // 
            // btn_descuento_todos_combos
            // 
            this.btn_descuento_todos_combos.BackColor = System.Drawing.Color.Transparent;
            this.btn_descuento_todos_combos.BackgroundImage = global::proyecto_bausi_csharp.Properties.Resources.slide1img2;
            this.btn_descuento_todos_combos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_descuento_todos_combos.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_descuento_todos_combos.Location = new System.Drawing.Point(610, 70);
            this.btn_descuento_todos_combos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_descuento_todos_combos.Name = "btn_descuento_todos_combos";
            this.btn_descuento_todos_combos.Size = new System.Drawing.Size(153, 44);
            this.btn_descuento_todos_combos.TabIndex = 2;
            this.btn_descuento_todos_combos.Text = "APLICAR A TODOS LOS COMBOS-BAUSI";
            this.btn_descuento_todos_combos.UseVisualStyleBackColor = false;
            this.btn_descuento_todos_combos.Click += new System.EventHandler(this.btn_descuento_todos_combos_Click);
            // 
            // agregar_descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 531);
            this.Controls.Add(this.eliminard_a_id);
            this.Controls.Add(this.btn_descuento_atodos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_eliminard_playeras);
            this.Controls.Add(this.btn_eliminard_combos);
            this.Controls.Add(this.btn_eliminard_tshirts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_eliminar_todos_descuentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_descuento_id);
            this.Controls.Add(this.id_para_descuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_descuento_todos_tshirts);
            this.Controls.Add(this.btn_descuento_todas_playeras);
            this.Controls.Add(this.btn_descuento_todos_combos);
            this.Controls.Add(this.txt_valor_descuento);
            this.Controls.Add(this.label1);
            this.Name = "agregar_descuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAUSI | AGREGAR UN DESCUENTO";
            this.Load += new System.EventHandler(this.agregar_descuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor_descuento;
        private System.Windows.Forms.Button btn_descuento_todos_combos;
        private System.Windows.Forms.Button btn_descuento_todas_playeras;
        private System.Windows.Forms.Button btn_descuento_todos_tshirts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_para_descuento;
        private System.Windows.Forms.Button btn_descuento_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_eliminar_todos_descuentos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_eliminard_tshirts;
        private System.Windows.Forms.Button btn_eliminard_combos;
        private System.Windows.Forms.Button btn_eliminard_playeras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_descuento_atodos;
        private System.Windows.Forms.Button eliminard_a_id;
    }
}