using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    static class Utileria
    {
        private static DicctionaroNumerosALetras diccionario = new DicctionaroNumerosALetras();        

        public static string convertirNumeroALetras()
        {
            string numeroLetras = "";
            try
            {
                long numero = Convert.ToInt64(Console.ReadLine());
                if (numero >= 0 && numero <= 999999999999)
                {
                    numeroLetras = numeroAletras(numero);
                }
                else
                {
                    throw new System.ArgumentException("El número debe estar dentro un rango de 0 a 999999999999");
                }
            }
            catch (OverflowException)
            {
                throw new System.OverflowException("El número debe estar dentro un rango de 0 a 999999999999");
            }
            catch (FormatException)
            {
                throw new System.FormatException("Solo puede ingresar números");
            }
            return numeroLetras;
        }

        private static string numeroAletras(long numero)
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
    }
}