using System.IO;
using System.Text;

namespace buffer_bytes_y_esas_madres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase de FileStream
            using (FileStream fileStream = new FileStream("archivo.txt", FileMode.Open))
            {
                // Crear un buffer para almacenar los datos leídos
                byte[] buffer = new byte[1024]; // 1 KB de buffer
                int bytesRead;

                // Leer el archivo en bloques de 1 KB
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // Procesar los datos leídos (convertir a string en este caso)
                    string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine(text);
                }
            }

            //Clase de MemoryStream
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Escribir datos en el MemoryStream
                string message = "Hola, MemoryStream!";
                byte[] data = Encoding.UTF8.GetBytes(message);
                memoryStream.Write(data, 0, data.Length);

                // Leer datos del MemoryStream
                memoryStream.Position = 0;
                byte[] readData = new byte[memoryStream.Length];
                memoryStream.Read(readData, 0, readData.Length);

                // Convertir los datos a texto y mostrarlos en la consola
                string result = Encoding.UTF8.GetString(readData);
                Console.WriteLine(result);
            }



            //ESCRIBIR LOS DIAS DE LA SEMANA EN BINARIO!!
            byte[][] diasDeLaSemanaBytesV2 = new byte[][]
            {
                new byte[] { 0b01001100, 0b01110101, 0b01101110, 0b01100101, 0b01110011 },  // Lunes
                new byte[] { 0b01001101, 0b01100001, 0b01110010, 0b01110100, 0b01100101, 0b01110011 },  // Martes
                new byte[] { 0b01001101, 0b01101001, 0b11000011, 0b10101001, 0b01110010, 0b01100011, 0b01101111, 0b01101100, 0b01100101, 0b01110011 }, // Miércoles
                new byte[] { 0b01001010, 0b01110101, 0b01100101, 0b01110110, 0b01100101, 0b01110011 },  // Jueves
                new byte[] { 0b01010110, 0b01101001, 0b01100101, 0b01110010, 0b01101110, 0b01100101, 0b01110011 },  // Viernes
                new byte[] { 0b01010011, 0b11000011, 0b10100001, 0b01100010, 0b01100001, 0b01100100, 0b01101111 },  // Sábado
                new byte[] { 0b01000100, 0b01101111, 0b01101101, 0b01101001, 0b01101110, 0b01100111, 0b01101111 }  // Domingo
            };

            foreach (var diaBytes in diasDeLaSemanaBytesV2)
            {
                string dia = Encoding.UTF8.GetString(diaBytes);
                Console.WriteLine(dia);
            }

            //ESCRIBIR LOS DIAS DE LA SEMANA EN HEXADECIMAL
            byte[][] diasDeLaSemanaBytes = new byte[][]
            {
                new byte[] { 0x4C, 0x75, 0x6E, 0x65, 0x73 },          // Lunes
                new byte[] { 0x4D, 0x61, 0x72, 0x74, 0x65, 0x73 },    // Martes
                new byte[] { 0x4D, 0x69, 0xC3, 0xA9, 0x72, 0x63, 0x6F, 0x6C, 0x65, 0x73 }, // Miércoles
                new byte[] { 0x4A, 0x75, 0x65, 0x76, 0x65, 0x73 },    // Jueves
                new byte[] { 0x56, 0x69, 0x65, 0x72, 0x6E, 0x65, 0x73 }, // Viernes
                new byte[] { 0x53, 0xC3, 0xA1, 0x62, 0x61, 0x64, 0x6F }, // Sábado
                new byte[] { 0x44, 0x6F, 0x6D, 0x69, 0x6E, 0x67, 0x6F }  // Domingo
            };

            // Convertimos los bytes a cadenas de texto y las mostramos en la consola
            foreach (var diaBytes in diasDeLaSemanaBytes)
            {
                string dia = Encoding.UTF8.GetString(diaBytes);
                Console.WriteLine(dia);
            }


            // Convertimos los bytes a cadenas de texto y las mostramos en la consola


        }
    }

}
