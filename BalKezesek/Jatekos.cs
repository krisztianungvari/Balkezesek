using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalKezesek
{
    class Jatekos
    {
        string nev;
        DateTime elso;
        DateTime utolso;
        byte suly;
        byte magassag;

        public string Nev { get => nev; set => nev = value; }
        public DateTime Elso { get => elso; set => elso = value; }
        public DateTime Utolso { get => utolso; set => utolso = value; }
        public byte Suly { get => suly; set => suly = value; }
        public byte Magassag { get => magassag; set => magassag = value; }

        public double MagassagCm {get => magassag* 2.54;}

        public Jatekos (string sor)
        {
            string[] daraboltSor = sor.Split(';');
            Nev = daraboltSor[0];
            Elso = Convert.ToDateTime(daraboltSor[1]);
            Utolso = Convert.ToDateTime(daraboltSor[2]);
            Suly = Convert.ToByte(daraboltSor[3]);
            Magassag = Convert.ToByte(daraboltSor[4]);
        }
    }
}
