using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimDemo.Inheritance
{
    public abstract class Calisan<T>
    {
        public T SicilNo;

        public int AdiSoyadi;

        public string Adres;

        public string TelefonNo;

        public void MasrafFormuDoldur()
        {
            MessageBox.Show("Çalışan masraf formu dolduruldu.");
        }

        //public virtual void PrimHesapla()
        //{
        //    MessageBox.Show("Çalışan primi hesaplandı.");
        //}

        public abstract void PrimHesapla();
    }
}
