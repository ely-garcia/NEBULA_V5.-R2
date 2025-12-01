using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NEBULA_V5
{
    public class EnlaceGuardado
    {
        public string Titulo { get; set; }
        public string Url { get; set; }
        public DateTime Fecha { get; set; }
    }

    public static class HistorialManager
    {
        private static readonly string ruta =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "NEBULA_Historial.json");

        // -------------------------------------------------------------
        // ✔ Cargar historial
        // -------------------------------------------------------------
        public static List<EnlaceGuardado> CargarHistorial()
        {
            if (!File.Exists(ruta))
                return new List<EnlaceGuardado>();

            string json = File.ReadAllText(ruta);
            return JsonConvert.DeserializeObject<List<EnlaceGuardado>>(json);
        }

        // -------------------------------------------------------------
        // ✔ Guardar historial
        // -------------------------------------------------------------
        public static void GuardarHistorial(List<EnlaceGuardado> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(ruta, json);
        }

        // -------------------------------------------------------------
        // ✔ Método PRINCIPAL: guardar con título y URL
        // -------------------------------------------------------------
        public static void AgregarAlHistorial(string titulo, string url)
        {
            var lista = CargarHistorial();

            lista.Add(new EnlaceGuardado
            {
                Titulo = titulo,
                Url = url,
                Fecha = DateTime.Now
            });

            GuardarHistorial(lista);
        }

        // -------------------------------------------------------------
        // ✔ Método más simple: guardar solo la URL
        //   (NEBULA lo usa)
        // -------------------------------------------------------------
        public static void AgregarAlHistorial(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return;

            string titulo = ObtenerTituloDesdeUrl(url);

            AgregarAlHistorial(titulo, url); // 👉 llama al método principal
        }

        // -------------------------------------------------------------
        // ✔ Generar un título automático desde el dominio
        // -------------------------------------------------------------
        private static string ObtenerTituloDesdeUrl(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                return uri.Host.Replace("www.", "").ToUpper();
            }
            catch
            {
                return "Sitio Guardado";
            }
        }
    }
}
