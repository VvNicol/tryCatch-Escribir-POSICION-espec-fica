namespace tryCatch__Escribir_POSICION_específica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo = "archivo.txt";
            int posicion = 20; // Posición en la que deseamos escribir en el archivo
            string textoNuevo = "Texto nuevo que queremos insertar en el archivo.";

            try
            {
                // Leer todo el contenido del archivo
                string contenidoOriginal = File.ReadAllText(rutaArchivo);

                // Verificar si la posición deseada está dentro del rango del archivo
                if (posicion >= 0 && posicion <= contenidoOriginal.Length)
                {
                    // Insertar el nuevo texto en la posición deseada
                    string nuevoContenido = contenidoOriginal.Insert(posicion, textoNuevo);

                    // Sobrescribir el archivo con el nuevo contenido
                    File.WriteAllText(rutaArchivo, nuevoContenido);

                    Console.WriteLine("El texto se ha escrito correctamente en la posición especificada.");
                }
                else
                {
                    Console.WriteLine("La posición especificada está fuera del rango del archivo.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer/escribir el archivo: " + e.Message);
            }
        }
    }
}
