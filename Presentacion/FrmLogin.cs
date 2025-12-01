using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NEBULA_V5.Presentacion
{
    public partial class FrmLogin : Form
    {
        // Constructor
        public FrmLogin()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Evita parpadeos al dibujar el degradado
        }

        //  DISEÑO DE INTERFAZ (FONDO DEGRADAOD) ------------------------------------------------------------------------------------------

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            // Paleta tipo NEBULA
            Color c1 = Color.FromArgb(10, 10, 20);   // Negro profundo
            Color c2 = Color.FromArgb(15, 45, 120);  // Azul espacial
            Color c3 = Color.FromArgb(80, 30, 110);  // Morado oscuro

            // Degradado vertical
            using (LinearGradientBrush brush1 =
                new LinearGradientBrush(rect, c1, c2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush1, rect);
            }

            // Degradado diagonal encimA
            using (LinearGradientBrush brush2 =
                new LinearGradientBrush(rect, c2, c3, LinearGradientMode.ForwardDiagonal))
            {
                ColorBlend blend = new ColorBlend
                {
                    Colors = new Color[]
                    {
                        Color.FromArgb(0, 0, 0, 0),   // Transparente
                        Color.FromArgb(150, c2),      // Azul con opacidad
                        Color.FromArgb(180, c3)       // Morado más fuerte
                    },
                    Positions = new float[] { 0f, 0.5f, 1f }
                };

                brush2.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush2, rect);
            }

            base.OnPaint(e);
        }


        //FUNCIONAMIENTO DE BOTONES ------------------------------------------------------

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
            this.Hide();
        }


        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, ingresa tus credenciales para acceder.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construcción de ruta del archivo de usuarios
            string rutaProyecto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                                    .Parent.Parent.FullName;
            string rutaUsuarioTXT = Path.Combine(rutaProyecto, "Datos", "usuario.txt");

            // Validar existencia del archivo
            if (!File.Exists(rutaUsuarioTXT))
            {
                MessageBox.Show("No existen usuarios registrados todavía. Regístrate para continuar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Línea exacta a buscar en el txt
            string lineaBuscada = $"{usuario}, {contrasena}";

            // Lectura de líneas del archivo
            bool cuentaEncontrada = File.ReadAllLines(rutaUsuarioTXT)
                                        .Any(linea => linea.Trim() == lineaBuscada);

            if (!cuentaEncontrada)
            {
                MessageBox.Show("Las credenciales no coinciden con ningún usuario registrado.",
                    "Cuenta no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Credenciales correctas → abrir FrmInicio
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
            this.Hide();
        }
    }
}
