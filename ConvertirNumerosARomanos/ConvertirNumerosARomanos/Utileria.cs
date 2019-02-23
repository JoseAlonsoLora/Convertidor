using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirNumerosARomanos
{
    static class Utileria
    {
        public static string convertirNumeroARomano()
        {
            string numeroRomano = "";
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 0 && numero <= 3999)
                {
                    numeroRomano = numeroARomano(numero);
                }
                else
                {
                    throw new System.ArgumentException("El número debe estar dentro un rango de 0 a 3999");
                }
            }
            catch (OverflowException)
            {
                throw new System.OverflowException("El número debe estar dentro un rango de 0 a 3999");
            }
            catch (FormatException)
            {
                throw new System.FormatException("Solo puede ingresar números");
            }
            return numeroRomano;
        }
        private static string numeroARomano(int numero)
        {
            string numeroRomano = "";
            DiccionarioRomano diccionarioRomano = new DiccionarioRomano();
            Dictionary<int, Dictionary<int, string>> diccionarioNumerosRomanos = diccionarioRomano.getDiccionarioNumerosRomanos();
            List<int> numerosDescompuestos = obtenerNumeroDescompuesto(numero);
            int indice = 1;
            foreach (int numeroDescompuesto in numerosDescompuestos)
            {
                string auxiliar = "";
                auxiliar = diccionarioNumerosRomanos[indice][numeroDescompuesto];
                numeroRomano = auxiliar + numeroRomano;
                indice++;
            }
            return numeroRomano;
        }
        private static List<int> obtenerNumeroDescompuesto(int numero)
        {
            List<int> numeroDescompuesto = new List<int>();
            int auxiliar;
            while (numero != 0)
            {
                auxiliar = numero % 10;
                numero /= 10;
                numeroDescompuesto.Add(auxiliar);
            }
            return numeroDescompuesto;
        }
    }
}
