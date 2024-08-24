using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaTransferi
{
    public class Havale
    {
        private decimal _komisyonOrani;
        private decimal _bakiye;

        enum GonderimDurumu
        {
            Gonderildi = 67,
            Beklemede,
            OnayBekliyor = 5,
            Reddedildi,
            LimitProblemi
        }

        private GonderimDurumu _gonderimDurumu;

        public Havale()
        {
            _komisyonOrani = 2.5m;
        }

        public Havale(decimal komisyonOrani)
        {
            _komisyonOrani = komisyonOrani;
        }

        ////10,85
        //public void Gonder(decimal tutar)
        //{

        //}

        public void Al(decimal tutar)
        {
            _bakiye += tutar;
        }

        public void Gonder(decimal tutar, decimal komisyonOrani = 3)
        {
            try
            {
                if (LimitKontrolleri(tutar))
                {
                    _bakiye -= tutar + (tutar * 3 / 100);
                    _gonderimDurumu = GonderimDurumu.Gonderildi;
                }
                else
                {
                    _gonderimDurumu = GonderimDurumu.LimitProblemi;
                }
            }
            catch (Exception)
            {
                _gonderimDurumu = GonderimDurumu.Reddedildi;
            }
        }

        //10 85
        public void Gonder(int tutar, int kurus)
        {

        }

        private void IcHesaplamalar()
        {

        }

        private bool LimitKontrolleri(decimal tutar)
        {
            return tutar > 0 && tutar < 500000;
        }
    }
}
