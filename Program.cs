using System;
using System.Threading;
using System.Windows.Forms;

namespace NEBULA_V5
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear el formulario Splash
            Presentacion.FrmSplash splash = new Presentacion.FrmSplash();

            // Mostrar el splash
            splash.Show();
            splash.Refresh();

            // Tiempo que permanecerá visible el Splash Screen
            Thread.Sleep(2500);

            // Ocultar la pantalla de carga
            splash.Visible = false;

            // Abrir formulario de Login
            Application.Run(new Presentacion.FrmLogin());
        }
    }
}
