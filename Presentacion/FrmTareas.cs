using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NEBULA_V5.Presentacion
{
    public partial class FrmTareas : Form
    {
        public FrmTareas()
        {
            InitializeComponent();

            // Ajustar tarjetas cuando cambia el tamaño del formulario
            this.Resize += (s, e) =>
            {
                foreach (Control ctrl in FlowTareas.Controls)
                {
                    ctrl.Width = FlowTareas.ClientSize.Width - 40;
                }
            };
        }


        // --------------------------------------------------------------------
        // DISEÑO DEL FONDO
        // --------------------------------------------------------------------
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            Color c1 = Color.FromArgb(10, 10, 20);
            Color c2 = Color.FromArgb(15, 45, 120);
            Color c3 = Color.FromArgb(80, 30, 110);

            using (LinearGradientBrush brush1 =
                   new LinearGradientBrush(rect, c1, c2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush1, rect);
            }

            using (LinearGradientBrush brush2 =
                   new LinearGradientBrush(rect, c2, c3, LinearGradientMode.ForwardDiagonal))
            {
                ColorBlend blend = new ColorBlend
                {
                    Colors = new Color[]
                    {
                        Color.FromArgb(0,0,0,0),
                        Color.FromArgb(150,c2),
                        Color.FromArgb(180,c3)
                    },
                    Positions = new float[] { 0f, 0.5f, 1f }
                };

                brush2.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush2, rect);
            }

            base.OnPaint(e);
        }


        // --------------------------------------------------------------------
        // BOTÓN CREAR TAREA
        // --------------------------------------------------------------------
        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (FrmCrearTarea frm = new FrmCrearTarea())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CrearTarjeta(
                        frm.Titulo,
                        frm.Descripcion,
                        frm.FechaLimite,
                        frm.Prioridad
                    );
                }
            }
        }


        // --------------------------------------------------------------------
        // CREAR TARJETA DE TAREA
        // --------------------------------------------------------------------
        private void CrearTarjeta(string titulo, string descripcion, DateTime fecha, string prioridad)
        {
            Panel card = new Panel();
            card.Width = FlowTareas.ClientSize.Width - 40;
            card.Height = 160;
            card.BackColor = Color.FromArgb(50, 50, 70);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);
            card.Padding = new Padding(10, 10, 10, 20);

            // Título
            Label lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(15, 15);

            // Prioridad
            Label lblPrioridad = new Label();
            lblPrioridad.Text = prioridad;
            lblPrioridad.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblPrioridad.AutoSize = true;
            lblPrioridad.Padding = new Padding(4);
            lblPrioridad.Location = new Point(15, 45);

            // Descripción
            Label lblDescripcion = new Label();
            lblDescripcion.Text = descripcion.Length > 80
                                  ? descripcion.Substring(0, 80) + "..."
                                  : descripcion;
            lblDescripcion.ForeColor = Color.LightGray;
            lblDescripcion.AutoSize = true;
            lblDescripcion.MaximumSize = new Size(card.Width - 40, 0);
            lblDescripcion.Location = new Point(15, 75);

            // Fecha límite
            Label lblFecha = new Label();
            lblFecha.Text = "Vence: " + fecha.ToString("dd/MM/yyyy HH:mm");
            lblFecha.ForeColor = Color.FromArgb(180, 200, 255);
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(15, 110);

            // Botón eliminar
            Button btnEliminar = new Button();
            btnEliminar.Text = "Eliminar";
            btnEliminar.Width = 80;
            btnEliminar.Height = 28;
            btnEliminar.BackColor = Color.FromArgb(200, 80, 80);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(card.Width - 100, 110);

            btnEliminar.Click += (s, e) =>
            {
                FlowTareas.Controls.Remove(card);
                card.Dispose();
            };

            // Sombra estética
            card.Paint += (s, e) =>
            {
                using (Pen p = new Pen(Color.FromArgb(40, 0, 0, 0), 10))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(0, 0, card.Width, card.Height));
                }
            };

            // Agregar elementos al panel
            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblPrioridad);
            card.Controls.Add(lblDescripcion);
            card.Controls.Add(lblFecha);
            card.Controls.Add(btnEliminar);

            // Agregar tarjeta al FlowLayout
            FlowTareas.Controls.Add(card);
        }


        // --------------------------------------------------------------------
        // BOTÓN VOLVER
        // --------------------------------------------------------------------
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }
    }
}
