using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class KampanyaManager : IKampanyaService
    {
        public void Ekle(Kampanya kampanya)
        {
            Console.WriteLine("{0} kampanyası eklendi = {1} ",kampanya.KampanyaAdi,kampanya.KampanyaAciklama);
        }

        public void Güncelle(Kampanya kampanya)
        {
            Console.WriteLine("{0} kampanyası güncellendi",kampanya.KampanyaAdi);
        }

        public void Kaldır(Kampanya kampanya)
        {
            Console.WriteLine("{0} kampanyası kaldırıldı",kampanya.KampanyaAdi);
        }
    }
}
