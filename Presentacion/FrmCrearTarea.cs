using System;
using System.Windows.Forms;

namespace NEBULA_V5.Presentacion
{
    public partial class FrmCrearTarea : Form
    {
        public FrmCrearTarea()
        {
            InitializeComponent();

            // MUY IMPORTANTE → el botón Guardar debe cerrar el popup con OK
            btsGuardar.DialogResult = DialogResult.OK;

            // Opciones del ComboBox
            cboPrioridad.Items.Add("Alta");
            cboPrioridad.Items.Add("Media");
            cboPrioridad.Items.Add("Baja");

            // Para que inicie en Media
            cboPrioridad.SelectedIndex = 1;

            // Asegurar que la hora pueda cambiarse
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;
        }

        // Propiedades para devolver la información
        public string Titulo => txtTitulo.Text;

        public string Descripcion => txtDescripcion.Text;

        public DateTime FechaLimite
        {
            get
            {
                return dtpFecha.Value.Date + dtpHora.Value.TimeOfDay;
            }
        }

        public string Prioridad => cboPrioridad.SelectedItem?.ToString() ?? "Media";

        // OPCIONAL: Validación mínima
        private void btsGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.");
                this.DialogResult = DialogResult.None; // Evita cerrar
            }
        }
    }
}
