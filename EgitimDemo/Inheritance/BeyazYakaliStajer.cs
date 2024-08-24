using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimDemo.Inheritance
{
    public class BeyazYakaliStajer : BeyazYakali<int>
    {
        public BeyazYakaliStajer(string adiSoyadi) : base(adiSoyadi)
        {
            MessageBox.Show($"Beyaz Yakali Stajer yaratıldı. AdiSoyadi: {adiSoyadi}");
        }

        public sealed override void PrimHesapla()
        {
            base.PrimHesapla();
        }
    }
}
