using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MainAplicacion
    {
        static void Main(string[] args)
        {
            try
            {
                long numero = Convert.ToInt64(Console.ReadLine());                
                //int numero = Convert.ToInt32(Console.ReadLine());
                if (validarRangoNumero(numero, 0, 999999999999))
                {
                    Console.WriteLine(Utileria.numeroAletras(numero));
                }
                else
                {
                    throw new System.ArgumentException("El número debe estar dentro un rango de 0 a 999999999999");
                }
                //Console.WriteLine(Utileria.numeroARomano(numero));
            }
            catch (OverflowException)
            {
                throw new System.OverflowException("El número debe estar dentro un rango de 0 a 999999999999");
            }
            catch (FormatException)
            {
                throw new System.FormatException("Solo puede ingresar números");
            }
            Console.ReadLine();
        }

        public static bool validarRangoNumero(long numero, int rangoInicio, long rangoFin)
        {
            bool esNumeroValido = false;
            if (numero >= rangoInicio && numero <= rangoFin)
                esNumeroValido = true;
            return esNumeroValido;
        }
    }
}
