using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimDemo.Inheritance
{
    public class Yonetici : Calisan<int>
    {
        public override void PrimHesapla()
        {
            MessageBox.Show("Yönetici primi hesaplandı.");
            //base.PrimHesapla();
        }
    }
}
