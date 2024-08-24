using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimDemo.Inheritance
{
    public class EnBeyazYakaliStajer : BeyazYakaliStajer
    {
        public EnBeyazYakaliStajer() : base("Selçuk Cirit")
        {
        }

        public EnBeyazYakaliStajer(string adiSoyadi) : base(adiSoyadi)
        {
            MessageBox.Show($"En Beyaz Yakali Stajer yaratıldı. AdiSoyadi: {adiSoyadi}");
        }

        //public override void PrimHesapla()
        //{
        //    base.PrimHesapla();
        //}
    }
}
