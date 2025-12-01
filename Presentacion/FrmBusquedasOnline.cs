using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NEBULA_V5.Presentacion
{
    public partial class FrmBusquedasOnline : Form
    {
        public FrmBusquedasOnline()
        {
            SetWebBrowserMode();   // Forzar WebBrowser a IE11
            InitializeComponent();

            webNavegador.NewWindow += WebNavegador_NewWindow;
        }


        // --------------------------------------------------------------------
        // BLOQUE: CONTROLAR APERTURA DE NUEVAS VENTANAS
        // --------------------------------------------------------------------
        private void WebNavegador_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true; // Evitar que abra una ventana nueva

            if (webNavegador.Document != null && webNavegador.Document.ActiveElement != null)
            {
                string url = webNavegador.Document.ActiveElement.GetAttribute("href");

                if (!string.IsNullOrWhiteSpace(url))
                {
                    webNavegador.Navigate(url); // Abrir el enlace en el mismo WebBrowser
                }
            }
        }


        // --------------------------------------------------------------------
        // BLOQUE: FORZAR WebBrowser A MODO IE11
        // --------------------------------------------------------------------
        public static void SetWebBrowserMode()
        {
            try
            {
                string exeName = System.IO.Path.GetFileName(
                    System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

                int IE11_MODE = 11001;

                RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                    true);

                if (key == null)
                {
                    key = Registry.CurrentUser.CreateSubKey(
                        @"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                        true);
                }

                key.SetValue(exeName, IE11_MODE, RegistryValueKind.DWord);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo activar el modo IE11.\n" + ex.Message);
            }
        }


        // --------------------------------------------------------------------
        // BLOQUE: DISEÑO DEL FONDO
        // --------------------------------------------------------------------
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            if (rect.Width == 0 || rect.Height == 0)
            {
                base.OnPaint(e);
                return;
            }

            Color c1 = Color.FromArgb(10, 10, 20);
            Color c2 = Color.FromArgb(15, 45, 120);
            Color c3 = Color.FromArgb(80, 30, 110);

            using (LinearGradientBrush b1 =
                new LinearGradientBrush(rect, c1, c2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(b1, rect);
            }

            using (LinearGradientBrush b2 =
                new LinearGradientBrush(rect, c2, c3, LinearGradientMode.ForwardDiagonal))
            {
                var blend = new ColorBlend
                {
                    Colors = new Color[]
                    {
                        Color.FromArgb(0,0,0,0),
                        Color.FromArgb(150,c2),
                        Color.FromArgb(180,c3)
                    },
                    Positions = new float[] { 0f, 0.5f, 1f }
                };

                b2.InterpolationColors = blend;
                e.Graphics.FillRectangle(b2, rect);
            }

            base.OnPaint(e);
        }


        // --------------------------------------------------------------------
        // BLOQUE: CARGAR BING AL INICIAR
        // --------------------------------------------------------------------
        private void FrmBusquedasOnline_Load(object sender, EventArgs e)
        {
            webNavegador.ScriptErrorsSuppressed = true;
            webNavegador.Navigate("https://www.bing.com");
        }


        // --------------------------------------------------------------------
        // BLOQUE: BOTÓN BUSCAR
        // --------------------------------------------------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = txtBuscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(query)) return;

            string url = $"https://www.bing.com/search?q={Uri.EscapeDataString(query)}";

            try
            {
                webNavegador.Navigate(url);
            }
            catch
            {
                MessageBox.Show("Hubo un problema al cargar los resultados.");
            }
        }


        // --------------------------------------------------------------------
        // BLOQUE: BOTONES NAVEGACIÓN (ATRÁS / ADELANTE / RECARGAR / INICIO)
        // --------------------------------------------------------------------
        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (webNavegador.CanGoBack)
                webNavegador.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            if (webNavegador.CanGoForward)
                webNavegador.GoForward();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            webNavegador.Refresh();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            webNavegador.Navigate("https://www.bing.com");
        }


        // --------------------------------------------------------------------
        // BLOQUE: DETECTAR SITIOS NO COMPATIBLES (YouTube, Canva, Drive...)
        // --------------------------------------------------------------------
        private void webNavegador_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = webNavegador.Url.ToString();

            string[] sitiosExternos =
            {
                "youtube.com",
                "canva.com",
                "classroom.google.com",
                "drive.google.com"
            };

            foreach (var sitio in sitiosExternos)
            {
                if (url.Contains(sitio))
                {
                    System.Diagnostics.Process.Start(url);
                    webNavegador.GoBack();

                    MessageBox.Show(
                        "Este sitio funciona mejor en tu navegador. Se abrió automáticamente.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }
            }
        }


        // --------------------------------------------------------------------
        // BLOQUE: BOTÓN GUARDAR ENLACE ACTUAL EN HISTORIAL
        // --------------------------------------------------------------------
        private void btnGuardarActual_Click(object sender, EventArgs e)
        {
            string url = null;

            // Intentar obtener la URL real del navegador
            if (webNavegador.Document != null && webNavegador.Document.Url != null)
            {
                url = webNavegador.Document.Url.ToString();
            }

            if (string.IsNullOrWhiteSpace(url) && webNavegador.Url != null)
            {
                url = webNavegador.Url.ToString();
            }

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("No se pudo obtener la URL de esta página.");
                return;
            }

            HistorialManager.AgregarAlHistorial(url);

            MessageBox.Show(
                "Enlace guardado en el historial.",
                "NEBULA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        // --------------------------------------------------------------------
        // BLOQUE: BOTÓN VER HISTORIAL
        // --------------------------------------------------------------------
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHistorial historial = new FrmHistorial();
            historial.Show();
        }


        // --------------------------------------------------------------------
        // BLOQUE: BOTÓN VOLVER
        // --------------------------------------------------------------------
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }
    }
}
