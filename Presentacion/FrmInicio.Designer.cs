namespace NEBULA_V5.Presentacion
{
    partial class FrmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.timerEscritura = new System.Windows.Forms.Timer(this.components);
            this.btnArchivos = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenida.Location = new System.Drawing.Point(257, 149);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(277, 21);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "¡Hola! ¿Cómo puedo ayudarte hoy?";
            // 
            // timerEscritura
            // 
            this.timerEscritura.Interval = 50;
            this.timerEscritura.Tick += new System.EventHandler(this.timerEscritura_Tick);
            // 
            // btnArchivos
            // 
            this.btnArchivos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnArchivos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnArchivos.Location = new System.Drawing.Point(77, 384);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(142, 45);
            this.btnArchivos.TabIndex = 2;
            this.btnArchivos.Text = "Administración de Archivos";
            this.btnArchivos.UseVisualStyleBackColor = false;
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.IndianRed;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBusqueda.Location = new System.Drawing.Point(327, 384);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(142, 45);
            this.btnBusqueda.TabIndex = 3;
            this.btnBusqueda.Text = "Búsquedas Online";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(570, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Administración de tareas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.SystemColors.Info;
            this.txtMensaje.Location = new System.Drawing.Point(77, 348);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(554, 16);
            this.txtMensaje.TabIndex = 5;
            this.txtMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMensaje_KeyDown);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(637, 344);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panelChat
            // 
            this.panelChat.AutoScroll = true;
            this.panelChat.BackColor = System.Drawing.Color.Transparent;
            this.panelChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelChat.Location = new System.Drawing.Point(77, 182);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(635, 160);
            this.panelChat.TabIndex = 7;
            this.panelChat.WrapContents = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(713, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnArchivos);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEBULA";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Timer timerEscritura;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.FlowLayoutPanel panelChat;
        private System.Windows.Forms.Button btnSalir;
    }
}