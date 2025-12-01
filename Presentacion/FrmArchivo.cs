// Librerías necesarias
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace NEBULA_V5.Presentacion
{
    public partial class FrmArchivo : Form
    {
        public FrmArchivo()
        {
            InitializeComponent();
        }


        //  MÉTODO PARA BUSCAR ARCHIVOS ----------------------------------------------------
        public List<string> BuscarArchivos(string termino)
        {
            List<string> resultados = new List<string>();

            List<string> carpetasObjetivo = new List<string>()
            {
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads",
                Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
            };

            foreach (string carpeta in carpetasObjetivo)
            {
                if (Directory.Exists(carpeta))
                {
                    try
                    {
                        resultados.AddRange(
                            Directory.GetFiles(carpeta, "*" + termino + "*", SearchOption.TopDirectoryOnly));

                        foreach (var sub in Directory.GetDirectories(carpeta))
                        {
                            try
                            {
                                resultados.AddRange(
                                    Directory.GetFiles(sub, "*" + termino + "*", SearchOption.AllDirectories));
                            }
                            catch { }
                        }
                    }
                    catch { }
                }
            }

            return resultados;
        }


        //  DISEÑO DEL FONDO CON DEGRADADO -------------------------------------------------
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            // Evitar error cuando el formulario aún no tiene tamaño válido
            if (rect.Width == 0 || rect.Height == 0)
            {
                base.OnPaint(e);
                return;
            }

            System.Drawing.Color c1 = System.Drawing.Color.FromArgb(10, 10, 20);
            System.Drawing.Color c2 = System.Drawing.Color.FromArgb(15, 45, 120);
            System.Drawing.Color c3 = System.Drawing.Color.FromArgb(80, 30, 110);

            using (LinearGradientBrush brush1 =
                new LinearGradientBrush(rect, c1, c2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush1, rect);
            }

            using (LinearGradientBrush brush2 =
                new LinearGradientBrush(rect, c2, c3, LinearGradientMode.ForwardDiagonal))
            {
                var blend = new ColorBlend
                {
                    Colors = new System.Drawing.Color[]
                    {
                        System.Drawing.Color.FromArgb(0, 0, 0, 0),
                        System.Drawing.Color.FromArgb(150, c2),
                        System.Drawing.Color.FromArgb(180, c3)
                    },
                    Positions = new float[] { 0f, 0.5f, 1f }
                };

                brush2.InterpolationColors = blend;
                e.Graphics.FillRectangle(brush2, rect);
            }

            base.OnPaint(e);
        }


        //  BOTÓN BUSCAR ARCHIVOS ----------------------------------------------------------
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string palabra = txtBusqueda.Text.Trim();

            if (palabra == "")
            {
                MessageBox.Show("Escribe una palabra para buscar archivos.", "Aviso");
                return;
            }

            lstResultados.Items.Clear();
            var encontrados = BuscarArchivos(palabra);

            if (encontrados.Count == 0)
            {
                lstResultados.Items.Add("No se encontraron archivos.");
                return;
            }

            foreach (var archivo in encontrados)
                lstResultados.Items.Add(archivo);
        }


        //  BOTÓN ABRIR ARCHIVO ------------------------------------------------------------
        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            if (lstResultados.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un archivo primero.");
                return;
            }

            string ruta = lstResultados.SelectedItem.ToString();

            if (File.Exists(ruta))
                System.Diagnostics.Process.Start(ruta);
            else
                MessageBox.Show("El archivo ya no existe.");
        }


        //  CUANDO SELECCIONAS UN ARCHIVO --------------------------------------------------
        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResultados.SelectedItem == null) return;

            string ruta = lstResultados.SelectedItem.ToString();

            if (File.Exists(ruta))
            {
                txtArchivoSeleccionado.Text = ruta;
                txtArchivoSeleccionado2.Text = ruta;
                lblEstadoConversion.Text = "Archivo listo para convertir.";
            }
            else
            {
                txtArchivoSeleccionado.Text = "";
                txtArchivoSeleccionado2.Text = "";
                lblEstadoConversion.Text = "El archivo ya no existe.";
            }
        }


        //  BOTÓN CONVERTIR ARCHIVO --------------------------------------------------------
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string ruta = txtArchivoSeleccionado.Text;

            if (!File.Exists(ruta))
            {
                MessageBox.Show("Selecciona un archivo válido.");
                return;
            }

            if (cmbFormatoDestino.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un formato de destino.");
                return;
            }

            string formato = cmbFormatoDestino.SelectedItem.ToString();
            string carpetaSalida = Path.Combine(Path.GetDirectoryName(ruta), "NEBULA_Convertidos");

            Directory.CreateDirectory(carpetaSalida);

            try
            {
                string extensionNueva = formato.ToLower();
                string nombreNuevoArchivo =
                    Path.GetFileNameWithoutExtension(ruta) + "_convertido." + extensionNueva;

                string rutaSalida = Path.Combine(carpetaSalida, nombreNuevoArchivo);

                switch (formato)
                {
                    case "PNG":
                        ConvertirImagen(ruta, rutaSalida, ImageFormat.Png);
                        break;

                    case "JPG":
                        ConvertirImagen(ruta, rutaSalida, ImageFormat.Jpeg);
                        break;

                    case "BMP":
                        ConvertirImagen(ruta, rutaSalida, ImageFormat.Bmp);
                        break;

                    case "ICO":
                        ConvertirAIcono(ruta, rutaSalida);
                        break;

                    case "DOCX":
                        if (Path.GetExtension(ruta).ToLower() != ".pdf")
                        {
                            MessageBox.Show("Solo se pueden convertir PDF a Word (.docx).",
                                            "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        ConvertirPdfADocx(ruta, rutaSalida);
                        break;

                    default:
                        MessageBox.Show("Formato no reconocido.");
                        return;
                }

                lblEstadoConversion.Text = "Archivo convertido correctamente.";
                MessageBox.Show("Guardado en:\n" + rutaSalida);
            }
            catch (Exception ex)
            {
                lblEstadoConversion.Text = "Error en la conversión.";
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // MÉTODOS DE CONVERSIÓN ------------------------------------------------------------
        private void ConvertirImagen(string rutaOriginal, string rutaSalida, ImageFormat formato)
        {
            using (System.Drawing.Image img = System.Drawing.Image.FromFile(rutaOriginal))
            {
                img.Save(rutaSalida, formato);
            }
        }

        private void ConvertirAIcono(string rutaOriginal, string rutaSalida)
        {
            using (Bitmap bmp = new Bitmap(rutaOriginal))
            {
                Icon icono = Icon.FromHandle(bmp.GetHicon());
                using (FileStream fs = new FileStream(rutaSalida, FileMode.Create))
                {
                    icono.Save(fs);
                }
            }
        }


        //  CONVERTIR PDF → DOCX -----------------------------------------------------------
        private void ConvertirPdfADocx(string rutaPdf, string rutaSalidaDocx)
        {
            try
            {
                using (var doc = WordprocessingDocument.Create(
                    rutaSalidaDocx,
                    DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    var mainPart = doc.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    var body = mainPart.Document.AppendChild(new Body());

                    using (var pdf = PdfDocument.Open(rutaPdf))
                    {
                        foreach (var page in pdf.GetPages())
                        {
                            string texto = page.Text;

                            var parrafo = new Paragraph(new Run(new Text(texto)));
                            body.Append(parrafo);
                            body.Append(new Paragraph(new Run(new Break())));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir PDF a Word:\n" + ex.Message,
                                "Error en conversión",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        //  BOTÓN TRADUCIR ARCHIVO ---------------------------------------------------------
        private void btnTraducir_Click(object sender, EventArgs e)
        {
            string ruta = txtArchivoSeleccionado2.Text;

            if (!File.Exists(ruta))
            {
                MessageBox.Show("Selecciona un archivo válido.");
                return;
            }

            lblEstadoTraduccion.Text = "Extrayendo texto...";

            string texto = ExtraerTexto(ruta);

            if (string.IsNullOrWhiteSpace(texto))
            {
                lblEstadoTraduccion.Text = "Error al extraer texto.";
                MessageBox.Show("No se pudo extraer texto.");
                return;
            }

            int limiteCaracteres = 20000;

            if (texto.Length > limiteCaracteres)
            {
                int paginasAprox = texto.Length / 1500;

                MessageBox.Show(
                    $"El documento es demasiado grande.\n" +
                    $"Páginas aproximadas: {paginasAprox}\n\n" +
                    "Límite permitido: ~12 páginas.",
                    "Traducción no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                lblEstadoTraduccion.Text = "Documento demasiado grande. Traducción cancelada.";
                return;
            }

            lblEstadoTraduccion.Text = "Abriendo Google Translate...";

            string destino = "en";

            if (cmbIdiomaDestino.SelectedItem != null)
            {
                switch (cmbIdiomaDestino.SelectedItem.ToString())
                {
                    case "English": destino = "en"; break;
                    case "Spanish": destino = "es"; break;
                    case "French": destino = "fr"; break;
                    case "Portuguese": destino = "pt"; break;
                }
            }

            TraducirTextoEnGoogle(texto, destino);
            lblEstadoTraduccion.Text = "Traducción abierta en el navegador.";
        }


        //  IDENTIFICAR TIPO DE ARCHIVO ----------------------------------------------------
        private string ExtraerTexto(string ruta)
        {
            string ext = Path.GetExtension(ruta).ToLower();

            switch (ext)
            {
                case ".txt":
                    return File.ReadAllText(ruta);

                case ".docx":
                    return ExtraerTextoDocx(ruta);

                case ".pdf":
                    return ExtraerTextoPdf(ruta);

                default:
                    MessageBox.Show("Formato no compatible.");
                    return null;
            }
        }

        private string ExtraerTextoDocx(string ruta)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Open(ruta, false))
                {
                    var body = doc.MainDocumentPart.Document.Body;

                    foreach (var text in body.Descendants<Text>())
                    {
                        sb.Append(text.Text + " ");
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "No se puede leer el archivo porque está en uso.",
                    "Archivo en uso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al leer el archivo DOCX.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return null;
            }

            return sb.ToString();
        }

        private string ExtraerTextoPdf(string ruta)
        {
            StringBuilder sb = new StringBuilder();

            using (PdfDocument pdf = PdfDocument.Open(ruta))
            {
                foreach (var page in pdf.GetPages())
                {
                    string texto = page.Text;
                    sb.Append(texto + " ");
                }
            }

            return sb.ToString();
        }

        private void TraducirTextoEnGoogle(string texto, string idiomaDestino)
        {
            string url =
                "https://translate.google.com/?sl=auto&tl=" +
                idiomaDestino +
                "&text=" +
                Uri.EscapeDataString(texto);

            System.Diagnostics.Process.Start(url);
        }


        //  BOTÓN VOLVER -------------------------------------------------------------------
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }
    }
}
