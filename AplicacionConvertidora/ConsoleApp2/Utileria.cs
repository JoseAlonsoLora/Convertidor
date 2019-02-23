using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    static class Utileria
    {
        private static DicctionaroNumerosALetras diccionario = new DicctionaroNumerosALetras();
        public static string numeroARomano(int numero)
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

        public static string numeroAletras(long numero)
        {
            if (numero == 0)
                return "cero";           

            string letras = "";

            if ((numero / 1000000) > 0)
            {
                long numeroMillones = numero / 1000000;
                letras +=  (numeroMillones == 1 ? "un millón " 
                    : numeroAletras(numero / 1000000) + "millones ");
                numero %= 1000000;
            }

            if ((numero / 1000) > 0)
            {
                letras += (numero >= 1000 && numero <= 1999 ? "mil " :
                    numeroAletras(numero / 1000) + "mil ");
                numero %= 1000;
            }

            if ((numero / 100) > 0)
            {
                letras += (numero >= 101 && numero <= 199 ? "ciento " :
                    diccionario.diccionarioCentenas[numero / 100] + " ");
                numero %= 100;
            }

            if (numero > 0)
            {                
                if (numero < 29)
                    letras += diccionario.diccionarioUnidades[numero] + " ";
                else
                {
                    letras += diccionario.diccionarioDecenas[numero / 10];
                    if ((numero % 10) > 0)
                        letras += " y " + diccionario.diccionarioUnidades[numero % 10] + " ";
                }
            }
            return letras;
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