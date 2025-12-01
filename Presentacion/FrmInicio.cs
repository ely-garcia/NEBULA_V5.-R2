using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NEBULA_V5.Presentacion
{
    public partial class FrmInicio : Form
    {

        //CAMPOS GLOBALES
        

        // Efecto de escritura de bienvenida
        string textoCompleto;
        int indice = 0;

        // Diccionario de respuestas del mini-chat
        Dictionary<string, string> respuestas = new Dictionary<string, string>()
        {
            // SALUDOS
            { "hola", "¡Hola! ¿En qué puedo ayudarte hoy?" },
            { "hi", "Hello! How can I help you today?" },
            { "hello", "Hello! Nice to see you." },
            { "buenas", "¡Hola! Espero que estés teniendo un buen día." },

            // ESTADO
            { "como estas", "Estoy funcionando perfectamente." },
            { "cómo estás", "Estoy funcionando perfectamente." },
            { "que tal", "Todo bien por aquí. ¿Y tú?" },

            // FUNCIONES
            { "que puedes hacer", "Puedo ayudarte a organizar archivos, buscar información, gestionar tareas y acompañarte mientras trabajas." },
            { "que haces", "Estoy aquí para ayudarte con lo que necesites." },
            { "ayuda", "Claro, ¿qué necesitas?" },

            // FECHA Y HORA
            { "hora", "La hora actual es " + DateTime.Now.ToString("hh:mm tt") },
            { "día", "Hoy es " + DateTime.Now.ToString("dddd dd 'de' MMMM yyyy") },
            { "dia", "Hoy es " + DateTime.Now.ToString("dddd dd 'de' MMMM yyyy") },
            { "fecha", "Hoy es " + DateTime.Now.ToString("dddd dd 'de' MMMM yyyy") },

            // AGRADECIMIENTOS
            { "gracias", "¡Con gusto! Estoy aquí para ayudarte cuando quieras ✨" },

            // DESPEDIDAS
            { "adios", "Hasta luego. Estaré aquí si me necesitas." },
            { "bye", "Goodbye! Take care." },
            { "nos vemos", "Nos vemos, cuídate." },

            // EXPRESIONES
            { "te quiero", "Aprecio muchísimo tu mensaje 💜" },

            // IDENTIDAD
            { "quien eres", "Soy NEBULA, tu asistente inteligente." },
            { "quien te creo", "Fui creada como parte de un proyecto. ¡Y estoy feliz de existir!" },
            { "quien te creó", "Fui creada como parte de un proyecto. ¡Y estoy feliz de existir!" },

            // ESTADOS EMOCIONALES
            { "estoy cansado", "Te entiendo. A veces descansar un poco es lo mejor." },
            { "estoy triste", "Lamento escucharlo. Estoy aquí si necesitás hablar." },
            { "me siento mal", "Es válido sentirse así. ¿Querés que te acompañe un rato?" },
        };


        // CONSTRUCTOR

        public FrmInicio()
        {
            InitializeComponent();
        }


        // DISEÑO DE INTERFAZ ----------------------------------------

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            Color c1 = Color.FromArgb(10, 10, 20);
            Color c2 = Color.FromArgb(15, 45, 120);
            Color c3 = Color.FromArgb(80, 30, 110);

            // Degradado 1
            using (LinearGradientBrush brush1 =
                   new LinearGradientBrush(rect, c1, c2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush1, rect);
            }

            // Degradado 2
            using (LinearGradientBrush brush2 =
                   new LinearGradientBrush(rect, c2, c3, LinearGradientMode.ForwardDiagonal))
            {
                ColorBlend blend = new ColorBlend
                {
                    Colors = new Color[]
                    {
                        Color.FromArgb(0,0,0,0),
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


        //EFECTO DE ESCRITURA

        private void timerEscritura_Tick(object sender, EventArgs e)
        {
            if (indice < textoCompleto.Length)
            {
                lblBienvenida.Text += textoCompleto[indice];
                indice++;
            }
            else
            {
                timerEscritura.Stop();
            }
        }


        // LOAD DEL FORM -------------------------------------------------------------------------------------------------

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            textoCompleto = lblBienvenida.Text;
            lblBienvenida.Text = "";
            indice = 0;
            timerEscritura.Start();

            AgregarBurbuja(
                "¡Hola! 💜✨\n" +
                "Soy NEBULA, tu asistente inteligente.\n" +
                "Puedo ayudarte a organizar archivos, buscar información y apoyarte mientras trabajas.\n" +
                "¿Qué deseas hacer hoy?",
                false
            );
        }


        // BOTONES --------------------------------------------------------------------------------------------------------------

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmArchivo().Show();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmBusquedasOnline().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmTareas().Show();
        }


        // ENVÍO DE MENSAJES ---------------------------------------------------------------------------------------------------------

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text.Trim() == "") return;

            string mensaje = txtMensaje.Text.Trim();

            AgregarBurbuja(mensaje, true);
            string respuesta = ObtenerRespuesta(mensaje);
            AgregarBurbuja(respuesta, false);

            txtMensaje.Clear();
        }

        private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnviar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }


        // CLASE: MENSAJE BURBUJA ---------------------------------------------------------------------------------------------------------------------

        public class MensajeBurbuja : UserControl
        {
            private string _texto;
            private bool _esUsuario;
            private Size _textoSize;

            public MensajeBurbuja(string texto, bool esUsuario)
            {
                _texto = texto;
                _esUsuario = esUsuario;

                this.BackColor = Color.Transparent;
                this.Font = new Font("Segoe UI", 10);
                this.MaximumSize = new Size(350, 0);

                _textoSize = TextRenderer.MeasureText(
                    _texto,
                    this.Font,
                    new Size(330, 3000),
                    TextFormatFlags.WordBreak
                );

                this.Size = new Size(_textoSize.Width + 30, _textoSize.Height + 30);
                this.Margin = new Padding(10);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Color colorBurbuja = _esUsuario
                    ? Color.FromArgb(200, 70, 120, 250)
                    : Color.FromArgb(200, 40, 100, 180);

                Color colorTexto = Color.White;

                Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                int r = 18;
                var path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(rect.X, rect.Y, r, r, 180, 90);
                path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
                path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
                path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(colorBurbuja))
                    e.Graphics.FillPath(brush, path);

                TextRenderer.DrawText(
                    e.Graphics,
                    _texto,
                    this.Font,
                    new Rectangle(15, 15, _textoSize.Width, _textoSize.Height),
                    colorTexto,
                    TextFormatFlags.WordBreak
                );
            }
        }


        // CHAT DEL SISTEMA --------------------------------------------------------------------------------------------------------------------------

        private void AgregarBurbuja(string texto, bool esUsuario)
        {
            MensajeBurbuja b = new MensajeBurbuja(texto, esUsuario);

            if (esUsuario)
                b.Margin = new Padding(panelChat.Width - b.Width - 30, 10, 10, 10);
            else
                b.Margin = new Padding(10, 10, panelChat.Width - b.Width - 30, 10);

            panelChat.Controls.Add(b);
            panelChat.ScrollControlIntoView(b);
        }

        private string ObtenerRespuesta(string mensaje)
        {
            if (string.IsNullOrWhiteSpace(mensaje))
                return "No logré entender ese mensaje… ¿podrías repetirlo?";

            mensaje = mensaje.ToLower().Trim();

            foreach (var clave in respuestas.Keys)
            {
                if (mensaje.Contains(clave))
                    return respuestas[clave];
            }

            if (mensaje.Contains("?") && mensaje.Length < 20)
                return "Interesante pregunta, pero aún no tengo una respuesta clara.";

            return "No estoy completamente seguro de cómo responder. Pero aprenderé en el futuro.";
        }


        // SALIR -----------------------------------------------------------------------------------------------------------------------------

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(
                "¿Seguro que querés cerrar NEBULA?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
