namespace Libros_basededatos
{
    partial class Basededatos_libro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datoFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bntIngresar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboLibro = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.VerDatoFecha = new System.Windows.Forms.DateTimePicker();
            this.textMirarNombre = new System.Windows.Forms.TextBox();
            this.textMirarCodigo = new System.Windows.Forms.TextBox();
            this.textMirarPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datoFecha);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.bntIngresar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AÑADIR LIBROS";
            // 
            // datoFecha
            // 
            this.datoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datoFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datoFecha.Location = new System.Drawing.Point(302, 158);
            this.datoFecha.MaxDate = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            this.datoFecha.Name = "datoFecha";
            this.datoFecha.Size = new System.Drawing.Size(94, 20);
            this.datoFecha.TabIndex = 7;
            this.datoFecha.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(236, 82);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // bntIngresar
            // 
            this.bntIngresar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntIngresar.Location = new System.Drawing.Point(134, 212);
            this.bntIngresar.Name = "bntIngresar";
            this.bntIngresar.Size = new System.Drawing.Size(116, 38);
            this.bntIngresar.TabIndex = 10;
            this.bntIngresar.Text = "INGRESAR";
            this.bntIngresar.UseVisualStyleBackColor = true;
            this.bntIngresar.Click += new System.EventHandler(this.bntIngresar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(236, 36);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(236, 120);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "INGRESE LA FECHA DE COMPRA DEL LIBRO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESE EL PRECIO DEL LIBRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE EL NOMBRE DEL LIBRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE EL CODIGO DEL LIBRO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "BUSQUEDA DE LIBROS";
            // 
            // comboLibro
            // 
            this.comboLibro.FormattingEnabled = true;
            this.comboLibro.Location = new System.Drawing.Point(165, 32);
            this.comboLibro.Name = "comboLibro";
            this.comboLibro.Size = new System.Drawing.Size(160, 23);
            this.comboLibro.TabIndex = 9;
            this.comboLibro.SelectedIndexChanged += new System.EventHandler(this.Mostrar);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.VerDatoFecha);
            this.groupBox2.Controls.Add(this.textMirarNombre);
            this.groupBox2.Controls.Add(this.comboLibro);
            this.groupBox2.Controls.Add(this.textMirarCodigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textMirarPrecio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(460, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 415);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libros";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(195, 311);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 38);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(28, 311);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 38);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // VerDatoFecha
            // 
            this.VerDatoFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerDatoFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VerDatoFecha.Location = new System.Drawing.Point(231, 267);
            this.VerDatoFecha.MaxDate = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            this.VerDatoFecha.Name = "VerDatoFecha";
            this.VerDatoFecha.Size = new System.Drawing.Size(94, 20);
            this.VerDatoFecha.TabIndex = 7;
            this.VerDatoFecha.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // textMirarNombre
            // 
            this.textMirarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMirarNombre.Location = new System.Drawing.Point(165, 159);
            this.textMirarNombre.MaxLength = 50;
            this.textMirarNombre.Name = "textMirarNombre";
            this.textMirarNombre.Size = new System.Drawing.Size(160, 20);
            this.textMirarNombre.TabIndex = 6;
            // 
            // textMirarCodigo
            // 
            this.textMirarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMirarCodigo.Location = new System.Drawing.Point(165, 105);
            this.textMirarCodigo.MaxLength = 10;
            this.textMirarCodigo.Name = "textMirarCodigo";
            this.textMirarCodigo.ReadOnly = true;
            this.textMirarCodigo.Size = new System.Drawing.Size(160, 20);
            this.textMirarCodigo.TabIndex = 5;
            // 
            // textMirarPrecio
            // 
            this.textMirarPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMirarPrecio.Location = new System.Drawing.Point(165, 215);
            this.textMirarPrecio.MaxLength = 10;
            this.textMirarPrecio.Name = "textMirarPrecio";
            this.textMirarPrecio.Size = new System.Drawing.Size(160, 20);
            this.textMirarPrecio.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "FECHA-COMPRA DEL LIBRO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "PRECIO DEL LIBRO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "NOMBRE DEL LIBRO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "CODIGO DEL LIBRO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Libros_basededatos.Properties.Resources.thumb_1920_26102;
            this.pictureBox1.Location = new System.Drawing.Point(12, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 134);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Basededatos_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Basededatos_libro";
            this.Text = "LIBROS-BASE DE DATOS";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Base_de_datos_libro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datoFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboLibro;
        private System.Windows.Forms.Button bntIngresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker VerDatoFecha;
        private System.Windows.Forms.TextBox textMirarNombre;
        private System.Windows.Forms.TextBox textMirarCodigo;
        private System.Windows.Forms.TextBox textMirarPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

