using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEBULA_V5.Presentacion
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }


        // --------------------------------------------------------------------
        // DISEÑO DEL FONDO
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
        // CARGAR HISTORIAL AL INICIAR
        // --------------------------------------------------------------------
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            var lista = HistorialManager.CargarHistorial();

            lstHistorialCompleto.Items.Clear();

            foreach (var item in lista)
            {
                lstHistorialCompleto.Items.Add($"{item.Titulo} | {item.Url}");
            }
        }


        // --------------------------------------------------------------------
        // ABRIR ENLACE SELECCIONADO
        // --------------------------------------------------------------------
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (lstHistorialCompleto.SelectedIndex == -1) return;

            string linea = lstHistorialCompleto.SelectedItem.ToString();
            string url = linea.Split('|')[1].Trim();

            System.Diagnostics.Process.Start(url);
        }


        // --------------------------------------------------------------------
        // ELIMINAR ENTRADA SELECCIONADA
        // --------------------------------------------------------------------
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstHistorialCompleto.SelectedIndex == -1) return;

            int index = lstHistorialCompleto.SelectedIndex;

            var lista = HistorialManager.CargarHistorial();
            lista.RemoveAt(index);
            HistorialManager.GuardarHistorial(lista);

            FrmHistorial_Load(null, null); // refrescar lista
        }


        // --------------------------------------------------------------------
        // LIMPIAR TODO EL HISTORIAL
        // --------------------------------------------------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            HistorialManager.GuardarHistorial(new List<EnlaceGuardado>());
            lstHistorialCompleto.Items.Clear();
        }


        // --------------------------------------------------------------------
        // VOLVER A BÚSQUEDA
        // --------------------------------------------------------------------
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBusquedasOnline busqueda = new FrmBusquedasOnline();
            busqueda.Show();
        }
    }
}
