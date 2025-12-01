namespace NEBULA_V5.Presentacion
{
    partial class FrmTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTareas));
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.FlowTareas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(72, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(251, 30);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Administrador de Tareas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.PanelSuperior.Controls.Add(this.btnVolver);
            this.PanelSuperior.Controls.Add(this.btnCrear);
            this.PanelSuperior.Controls.Add(this.pictureBox1);
            this.PanelSuperior.Controls.Add(this.Label1);
            this.PanelSuperior.Location = new System.Drawing.Point(1, 12);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(797, 88);
            this.PanelSuperior.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(77, 46);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(97, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Nueva Tarea";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FlowTareas
            // 
            this.FlowTareas.AutoScroll = true;
            this.FlowTareas.BackColor = System.Drawing.Color.Transparent;
            this.FlowTareas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowTareas.Location = new System.Drawing.Point(13, 130);
            this.FlowTareas.Name = "FlowTareas";
            this.FlowTareas.Size = new System.Drawing.Size(775, 308);
            this.FlowTareas.TabIndex = 3;
            this.FlowTareas.WrapContents = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.IndianRed;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(712, 8);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 33);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlowTareas);
            this.Controls.Add(this.PanelSuperior);
            this.Name = "FrmTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEBULA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.FlowLayoutPanel FlowTareas;
        private System.Windows.Forms.Button btnVolver;
    }
}