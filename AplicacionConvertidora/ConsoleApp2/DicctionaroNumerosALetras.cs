using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class DicctionaroNumerosALetras
    {
        public Dictionary<long, string> diccionarioUnidades { get; } 
        public Dictionary<long, string> diccionarioDecenas { get; }
        public Dictionary<long, string> diccionarioCentenas { get; }

        public DicctionaroNumerosALetras()
        {
            this.diccionarioUnidades = crearDiccionarioUnidades();
            this.diccionarioDecenas = crearDiccionarioDecenas();
            this.diccionarioCentenas = crearDiccionarioCentenas();
        }
        private Dictionary<long,string> crearDiccionarioUnidades()
        {
            Dictionary<long, string> diccionarioUnidades = new Dictionary<long, string>();
            diccionarioUnidades.Add(0, "cero");
            diccionarioUnidades.Add(1, "uno");
            diccionarioUnidades.Add(2, "dos");
            diccionarioUnidades.Add(3, "tres");
            diccionarioUnidades.Add(4, "cuatro");
            diccionarioUnidades.Add(5, "cinco");
            diccionarioUnidades.Add(6, "seis");
            diccionarioUnidades.Add(7, "siete");
            diccionarioUnidades.Add(8, "ocho");
            diccionarioUnidades.Add(9, "nueve");
            diccionarioUnidades.Add(10, "diez");
            diccionarioUnidades.Add(11, "once");
            diccionarioUnidades.Add(12, "doce");
            diccionarioUnidades.Add(13, "trece");
            diccionarioUnidades.Add(14, "catorce");
            diccionarioUnidades.Add(15, "quince");
            diccionarioUnidades.Add(16, "dieciséis");
            diccionarioUnidades.Add(17, "diecisite");
            diccionarioUnidades.Add(18, "dieciocho");
            diccionarioUnidades.Add(19, "diecinueve");
            diccionarioUnidades.Add(20, "veinte");
            diccionarioUnidades.Add(21, "veintiuno");
            diccionarioUnidades.Add(22, "veintidós");
            diccionarioUnidades.Add(23, "veintitrés");
            diccionarioUnidades.Add(24, "veinticuatro");
            diccionarioUnidades.Add(25, "veinticinco");
            diccionarioUnidades.Add(26, "veintiséis");
            diccionarioUnidades.Add(27, "veintiseite");
            diccionarioUnidades.Add(28, "veintiocho");
            diccionarioUnidades.Add(29, "veintinueve");
            return diccionarioUnidades;
        }

        private Dictionary<long, string> crearDiccionarioDecenas()
        {
            Dictionary<long, string> diccionarioDecenas = new Dictionary<long, string>();
            diccionarioDecenas.Add(0, "");
            diccionarioDecenas.Add(1, "diez");
            diccionarioDecenas.Add(2, "veinte");
            diccionarioDecenas.Add(3, "treinta");
            diccionarioDecenas.Add(4, "cuarenta");
            diccionarioDecenas.Add(5, "cincuenta");
            diccionarioDecenas.Add(6, "sesenta");
            diccionarioDecenas.Add(7, "setenta");
            diccionarioDecenas.Add(8, "ochenta");
            diccionarioDecenas.Add(9, "noventa");
            return diccionarioDecenas;
        }

        private Dictionary<long, string> crearDiccionarioCentenas()
        {
            Dictionary<long, string> diccionarioCentenas = new Dictionary<long, string>();
            diccionarioCentenas.Add(0, "");
            diccionarioCentenas.Add(1, "cien");
            diccionarioCentenas.Add(2, "docientos");
            diccionarioCentenas.Add(3, "trescientos");
            diccionarioCentenas.Add(4, "cuatrocientos");
            diccionarioCentenas.Add(5, "quinientos");
            diccionarioCentenas.Add(6, "seiscientos");
            diccionarioCentenas.Add(7, "setecientos");
            diccionarioCentenas.Add(8, "ochocientos");
            diccionarioCentenas.Add(9, "novecientos");
            return diccionarioCentenas;
        }
    }
}
