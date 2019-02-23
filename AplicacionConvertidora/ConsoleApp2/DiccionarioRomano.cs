using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class DiccionarioRomano
    {
        private Dictionary<int, string> unidades = null;
        private Dictionary<int, string> decenas = null;
        private Dictionary<int, string> centenas = null;
        private Dictionary<int, string> millares = null;
        private Dictionary<int, Dictionary<int, string>> diccionarioNumerosRomanos;

        public DiccionarioRomano()
        {
            this.unidades = crearDiccionarioUnidades();
            this.decenas = crearDiccionarioDecenas();
            this.centenas = crearDiccionarioCentenas();
            this.millares = crearDiccionarioMillares();
            crearDiccionarioNumerosRomanos();
        }

        public Dictionary<int, Dictionary<int, string>> getDiccionarioNumerosRomanos()
        {
            return this.diccionarioNumerosRomanos;
        }

        private void crearDiccionarioNumerosRomanos()
        {
            Dictionary<int, Dictionary<int, string>> diccionarioNumerosRomanos = new Dictionary<int, Dictionary<int, string>>();
            diccionarioNumerosRomanos.Add(1, this.unidades);
            diccionarioNumerosRomanos.Add(2, this.decenas);
            diccionarioNumerosRomanos.Add(3, this.centenas);
            diccionarioNumerosRomanos.Add(4, this.millares);
            this.diccionarioNumerosRomanos = diccionarioNumerosRomanos;
        }

        private Dictionary<int, string> crearDiccionarioUnidades()
        {
            Dictionary<int, string> unidades = new Dictionary<int, string>();
            unidades.Add(0, "");
            unidades.Add(1,"I");
            unidades.Add(2, "II");
            unidades.Add(3, "III");
            unidades.Add(4, "IV");
            unidades.Add(5, "V");
            unidades.Add(6, "VI");
            unidades.Add(7, "VII");
            unidades.Add(8, "VIII");
            unidades.Add(9, "IX");
            return unidades;
        }

        private Dictionary<int, string> crearDiccionarioDecenas()
        {
            Dictionary<int, string> decenas = new Dictionary<int, string>();
            decenas.Add(0, "");
            decenas.Add(1, "X");
            decenas.Add(2, "XX");
            decenas.Add(3, "XXX");
            decenas.Add(4, "XL");
            decenas.Add(5, "L");
            decenas.Add(6, "LX");
            decenas.Add(7, "LXX");
            decenas.Add(8, "LXXX");
            decenas.Add(9, "XC");
            return decenas;
        }

        private Dictionary<int, string> crearDiccionarioCentenas()
        {
            Dictionary<int, string> centenas = new Dictionary<int, string>();
            centenas.Add(0, "");
            centenas.Add(1, "C");
            centenas.Add(2, "CC");
            centenas.Add(3, "CCC");
            centenas.Add(4, "CD");
            centenas.Add(5, "D");
            centenas.Add(6, "DC");
            centenas.Add(7, "DCC");
            centenas.Add(8, "DCCC");
            centenas.Add(9, "CM");
            return centenas;
        }

        private Dictionary<int, string> crearDiccionarioMillares()
        {
            Dictionary<int, string> millares = new Dictionary<int, string>();
            millares.Add(0, "");
            millares.Add(1, "M");
            millares.Add(2, "MM");
            millares.Add(3, "MMM");
            return millares;
        }
    }
}
