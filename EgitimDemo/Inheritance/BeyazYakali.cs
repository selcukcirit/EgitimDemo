using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimDemo.Inheritance
{
    public class BeyazYakali<T> : Calisan<T>
    {
        public BeyazYakali()
        {
                
        }
        public BeyazYakali(string adiSoyadi)
        {
            MessageBox.Show($"BeyazYakali yaratıldı. AdiSoyadi: {adiSoyadi}");
        }

        public override void PrimHesapla()
        {
            MessageBox.Show("Beyaz yakalı primi hesaplandı.");
        }
    }
}
