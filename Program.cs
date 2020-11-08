using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace EjemploAccesoFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero; //Clase que representa un fichero
            fichero = File.CreateText("c:\\temp\\prueba.txt"); //Creamos un fichero
            fichero.WriteLine("Hola"); // Lo mismo que cuando escribimos por consola
            fichero.WriteLine("Adios");
            fichero.Close(); // Al cerrar el fichero nos aseguramos que no queda ningún dato por guardar

            ArrayList contenido = new ArrayList();
            String linea_leida;
            StreamReader fichero_lectura;
            fichero_lectura = File.OpenText("c:\\temp\\prueba.txt");
            do {
                linea_leida = fichero_lectura.ReadLine();
                contenido.Add(linea_leida);
            } while (linea_leida != null);
            foreach (String cadena in contenido)
                Console.WriteLine(cadena);
            fichero_lectura.Close();

            StreamWriter fichero_a_ampliar;
            fichero_a_ampliar = File.AppendText("c:\\temp\\prueba.txt");
            fichero_a_ampliar.WriteLine("Hasta luego");
            fichero_a_ampliar.Close();

            ArrayList contenido_ampliado = new ArrayList();
            StreamReader fichero_lectura_ampliado;
            fichero_lectura_ampliado = File.OpenText("c:\\temp\\prueba.txt");
            do
            {
                linea_leida = fichero_lectura_ampliado.ReadLine();
                contenido_ampliado.Add(linea_leida);
            } while (linea_leida != null);
            foreach (String cadena in contenido_ampliado)
                Console.WriteLine(cadena);
            fichero_lectura_ampliado.Close();

            StreamWriter fichero_a_modificar;
            StreamReader fichero_lectura_a_modificar;
            ArrayList contenido_a_modificar = new ArrayList();
            fichero_lectura_a_modificar = File.OpenText("c:\\temp\\prueba.txt");
            do
            {
                linea_leida = fichero_lectura_a_modificar.ReadLine();
                contenido_a_modificar.Add(linea_leida);
            } while (linea_leida != null);
            fichero_lectura_a_modificar.Close();
            contenido_a_modificar[1] = "Hasta pronto";
            fichero_a_modificar = File.CreateText("c:\\temp\\prueba.txt");
            foreach(String cadena in contenido_a_modificar){
                fichero_a_modificar.WriteLine(cadena);
            }
            fichero_a_modificar.Close();

            ArrayList contenido_cambiado = new ArrayList();
            StreamReader fichero_lectura_cambiado;
            fichero_lectura_cambiado = File.OpenText("c:\\temp\\prueba.txt");
            do
            {
                linea_leida = fichero_lectura_cambiado.ReadLine();
                contenido_cambiado.Add(linea_leida);
            } while (linea_leida != null);
            foreach (String cadena in contenido_cambiado)
                Console.WriteLine(cadena);
            fichero_lectura_cambiado.Close();



            Console.ReadKey();
        }
    }
}
