using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class GameManager :IGameService
    {
        public void Ekle(Games games)
        {

            Console.WriteLine("{0} oyunu eklendi.Türü {1} ID {2} Fiyatı {3}", games.OyunAdi,games.OyunTürü,games.Id,games.OyunFiyati);
        }

        public void Güncelle(Games games)
        {
            Console.WriteLine("{0} oyunu güncellendi.Türü {1} Fiyatı {2}", games.OyunAdi, games.OyunTürü, games.OyunFiyati);
        }

        public void Kaldır(Games games)
        {
            Console.WriteLine("{0} adlı oyun kaldırıldı.", games.OyunAdi);
        }
    }
}
