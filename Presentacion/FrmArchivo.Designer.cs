namespace NEBULA_V5.Presentacion
{
    partial class FrmArchivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArchivo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArchivoSeleccionado = new System.Windows.Forms.TextBox();
            this.cmbFormatoDestino = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblEstadoConversion = new System.Windows.Forms.Label();
            this.panelTraduccion = new System.Windows.Forms.Panel();
            this.lblEstadoTraduccion = new System.Windows.Forms.Label();
            this.btnTraducir = new System.Windows.Forms.Button();
            this.cmbIdiomaDestino = new System.Windows.Forms.ComboBox();
            this.lblIdiomaDestino = new System.Windows.Forms.Label();
            this.txtArchivoSeleccionado2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTraduccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador de Archivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(333, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar Archivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(116, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Escribir palabra de búsqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(308, 93);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(182, 20);
            this.txtBusqueda.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(507, 93);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(225, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultados:";
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(308, 122);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(341, 95);
            this.lstResultados.TabIndex = 7;
            this.lstResultados.SelectedIndexChanged += new System.EventHandler(this.lstResultados_SelectedIndexChanged);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArchivo.Location = new System.Drawing.Point(308, 223);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirArchivo.TabIndex = 8;
            this.btnAbrirArchivo.Text = "Abrir";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrirArchivo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Conversión de formatos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(14, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Archivo:";
            // 
            // txtArchivoSeleccionado
            // 
            this.txtArchivoSeleccionado.Location = new System.Drawing.Point(87, 306);
            this.txtArchivoSeleccionado.Name = "txtArchivoSeleccionado";
            this.txtArchivoSeleccionado.ReadOnly = true;
            this.txtArchivoSeleccionado.Size = new System.Drawing.Size(294, 20);
            this.txtArchivoSeleccionado.TabIndex = 11;
            // 
            // cmbFormatoDestino
            // 
            this.cmbFormatoDestino.FormattingEnabled = true;
            this.cmbFormatoDestino.Items.AddRange(new object[] {
            "PNG",
            "JPG",
            "BMP",
            "ICO",
            "DOCX"});
            this.cmbFormatoDestino.Location = new System.Drawing.Point(87, 339);
            this.cmbFormatoDestino.Name = "cmbFormatoDestino";
            this.cmbFormatoDestino.Size = new System.Drawing.Size(204, 21);
            this.cmbFormatoDestino.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Convertir a:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(306, 339);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 14;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblEstadoConversion
            // 
            this.lblEstadoConversion.AutoSize = true;
            this.lblEstadoConversion.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoConversion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConversion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstadoConversion.Location = new System.Drawing.Point(14, 371);
            this.lblEstadoConversion.Name = "lblEstadoConversion";
            this.lblEstadoConversion.Size = new System.Drawing.Size(53, 17);
            this.lblEstadoConversion.TabIndex = 15;
            this.lblEstadoConversion.Text = "Estado:";
            // 
            // panelTraduccion
            // 
            this.panelTraduccion.BackColor = System.Drawing.Color.Transparent;
            this.panelTraduccion.Controls.Add(this.lblEstadoTraduccion);
            this.panelTraduccion.Controls.Add(this.btnTraducir);
            this.panelTraduccion.Controls.Add(this.cmbIdiomaDestino);
            this.panelTraduccion.Controls.Add(this.lblIdiomaDestino);
            this.panelTraduccion.Controls.Add(this.txtArchivoSeleccionado2);
            this.panelTraduccion.Controls.Add(this.label9);
            this.panelTraduccion.Controls.Add(this.label8);
            this.panelTraduccion.Location = new System.Drawing.Point(410, 268);
            this.panelTraduccion.Name = "panelTraduccion";
            this.panelTraduccion.Size = new System.Drawing.Size(378, 154);
            this.panelTraduccion.TabIndex = 16;
            // 
            // lblEstadoTraduccion
            // 
            this.lblEstadoTraduccion.AutoSize = true;
            this.lblEstadoTraduccion.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoTraduccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTraduccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstadoTraduccion.Location = new System.Drawing.Point(5, 102);
            this.lblEstadoTraduccion.Name = "lblEstadoTraduccion";
            this.lblEstadoTraduccion.Size = new System.Drawing.Size(84, 17);
            this.lblEstadoTraduccion.TabIndex = 21;
            this.lblEstadoTraduccion.Text = "Estado: Listo";
            // 
            // btnTraducir
            // 
            this.btnTraducir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraducir.Location = new System.Drawing.Point(220, 66);
            this.btnTraducir.Name = "btnTraducir";
            this.btnTraducir.Size = new System.Drawing.Size(75, 23);
            this.btnTraducir.TabIndex = 20;
            this.btnTraducir.Text = "Traducir";
            this.btnTraducir.UseVisualStyleBackColor = true;
            this.btnTraducir.Click += new System.EventHandler(this.btnTraducir_Click);
            // 
            // cmbIdiomaDestino
            // 
            this.cmbIdiomaDestino.FormattingEnabled = true;
            this.cmbIdiomaDestino.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "Portuguese"});
            this.cmbIdiomaDestino.Location = new System.Drawing.Point(81, 66);
            this.cmbIdiomaDestino.Name = "cmbIdiomaDestino";
            this.cmbIdiomaDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbIdiomaDestino.TabIndex = 19;
            // 
            // lblIdiomaDestino
            // 
            this.lblIdiomaDestino.AutoSize = true;
            this.lblIdiomaDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblIdiomaDestino.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaDestino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIdiomaDestino.Location = new System.Drawing.Point(5, 66);
            this.lblIdiomaDestino.Name = "lblIdiomaDestino";
            this.lblIdiomaDestino.Size = new System.Drawing.Size(70, 17);
            this.lblIdiomaDestino.TabIndex = 17;
            this.lblIdiomaDestino.Text = "Traducir a:";
            // 
            // txtArchivoSeleccionado2
            // 
            this.txtArchivoSeleccionado2.Location = new System.Drawing.Point(150, 34);
            this.txtArchivoSeleccionado2.Name = "txtArchivoSeleccionado2";
            this.txtArchivoSeleccionado2.Size = new System.Drawing.Size(214, 20);
            this.txtArchivoSeleccionado2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(5, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Archivo seleccionado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Traducción de Archivos";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(713, 18);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 40);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panelTraduccion);
            this.Controls.Add(this.lblEstadoConversion);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFormatoDestino);
            this.Controls.Add(this.txtArchivoSeleccionado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAbrirArchivo);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEBULA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTraduccion.ResumeLayout(false);
            this.panelTraduccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArchivoSeleccionado;
        private System.Windows.Forms.ComboBox cmbFormatoDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblEstadoConversion;
        private System.Windows.Forms.Panel panelTraduccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArchivoSeleccionado2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTraducir;
        private System.Windows.Forms.ComboBox cmbIdiomaDestino;
        private System.Windows.Forms.Label lblIdiomaDestino;
        private System.Windows.Forms.Label lblEstadoTraduccion;
        private System.Windows.Forms.Button btnVolver;
    }
}