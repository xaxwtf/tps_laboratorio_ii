using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using ExepcionesPropias;


namespace TP_3_Ventas
{
    public class Archivos
    {
        /// <summary>
        /// Guarda en un archivo cualquier tipo de informacion(solo acepta extenciones .json o .xml)
        /// </summary>
        /// <typeparam name="T"> es el tipo de dato que sera guardado</typeparam>
        /// <param name="path">es el nombre del archivo donde se guardara la informacion</param>
        /// <param name="dato">es la informacion a ser guardada</param>
        /// <returns> true si pudo gurdar false en caso contrario</returns>
        public static bool Save<T>(string path, T dato)
        {
            bool r = false;
            string rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ArchivosDeProyecto";
            try
            {
                if (!Directory.Exists(rutaArchivo))
                {
                    Directory.CreateDirectory(rutaArchivo);
                }
                rutaArchivo = Path.Combine(rutaArchivo, path);
                if (Path.GetExtension(rutaArchivo) == ".xml")
                {
                    using (XmlTextWriter writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8))
                    {
                        writer.Formatting = Formatting.Indented;
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        
                        ser.Serialize(writer, dato);
                        r = true;

                    }
                }
                else
                {
                    if (Path.GetExtension(rutaArchivo) == ".json")
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions();
                        options.WriteIndented = true;
                        using (StreamWriter writer= new StreamWriter(rutaArchivo)) {
                            string cadenaJson = JsonSerializer.Serialize<T>(dato,options);
                            
                            writer.Write(cadenaJson);
                        }
                    }
                    else
                    {
                        throw new ExtencionNoValidaExepcion("la extencion no es valida!");
                    }
                }
            }
            catch(InvalidOperationException )
            {
                throw;
            }
            return r;
        }

        /// <summary>
        /// lee Archivos desde un archivo json o xml
        /// </summary>
        /// <typeparam name="T">indique el tipo de dato que desea leer</typeparam>
        /// <param name="path">es el nombre del arhivo</param>
        /// <returns>toda la informacion recuperada</returns>
        public static T Leer<T>(string path) where T:class 
        {
            string rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ArchivosDeProyecto";
            try
            {
                if (!Directory.Exists(rutaArchivo))
                {
                    Directory.CreateDirectory(rutaArchivo);
                }
                rutaArchivo = Path.Combine(rutaArchivo, path);
                if (Path.GetExtension(rutaArchivo) == ".xml")
                {
                    using (XmlTextReader reader = new XmlTextReader(rutaArchivo))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        return (T)ser.Deserialize(reader);
                    }
                }
                else
                {
                    if (Path.GetExtension(rutaArchivo) == ".json")
                    {
                        return JsonSerializer.Deserialize<T>( File.ReadAllText(rutaArchivo));
                    }
                }
                    
            }
            catch(Exception)
            {

            }
            return null;
        }
            
    }
}
