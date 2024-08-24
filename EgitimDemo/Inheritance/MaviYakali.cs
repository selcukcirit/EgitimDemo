using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimDemo.Inheritance
{
    public class MaviYakali : Calisan<int>
    {
        public new string TelefonNo;

        public new void MasrafFormuDoldur()
        {
            MessageBox.Show("Mavi Yakalı masraf formu dolduruldu.");
        }

        public override void PrimHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
