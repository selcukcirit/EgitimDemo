using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimDemo
{
    static class ExtensionMethods
    {
        internal static int Yaslandir(this Ogrenci ogrenci, int eklenecekYas)
        {
            ogrenci.yasi += eklenecekYas;
            return ogrenci.yasi;
        }

        internal static int Arttir(this int rakam)
        {
            return ++rakam;
        }

    }
}
