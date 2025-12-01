using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace NEBULA_V5.Presentacion
{
    public partial class FrmRegistro : Form
    {
        // Constructor
        public FrmRegistro()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Suaviza el repintado
        }
        
        //DISEÑO DE INTERFAZ GRÁFICA --------------------------------------------------------------------------------------------------------

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            // Paleta NEBULA
            Color c1 = Color.FromArgb(10, 10, 20);
            Color c2 = Color.FromArgb(15, 45, 120);
            Color c3 = Color.FromArgb(80, 30, 110);

            // Degradado vertical
            using (LinearGradientBrush brush1 =
                   new LinearGradientBrush(rect, c1, c2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush1, rect);
            }

            // Degradado diagonal
            using (LinearGradientBrush brush2 =
                   new LinearGradientBrush(rect, c2, c3, LinearGradientMode.ForwardDiagonal))
            {
                ColorBlend blend = new ColorBlend
                {
                    Colors = new Color[]
                    {
                        Color.FromArgb(0, 0, 0, 0),
                        Color.FromArgb(150, c2),
                        Color.FromArgb(180, c3)
                    },
                    Positions = new float[] { 0f, 0.5f, 1f }
                };

                brush2.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush2, rect);
            }

            base.OnPaint(e);
        }


        //FUNCIONAMIENTO DE REGISTRO ------------------------------------------------------------------------------------------------

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Construcción de la ruta del archivo de usuarios
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                                            .Parent.Parent.FullName;

            string rutaUsuarioTXT = Path.Combine(rutaProyecto, "Datos", "usuario.txt");

            // Crear archivo si no existe
            if (!File.Exists(rutaUsuarioTXT))
            {
                Directory.CreateDirectory(Path.Combine(rutaProyecto, "Datos"));
                File.Create(rutaUsuarioTXT).Close();
            }

            // Línea a guardar
            string linea = $"{usuario}, {contrasena}";

            // Guardar en el archivo
            using (StreamWriter sw = new StreamWriter(rutaUsuarioTXT, true))
            {
                sw.WriteLine(linea);
            }

            MessageBox.Show("Credenciales guardadas correctamente.",
                "NEBULA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Volver al login
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
