using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class KampanyaManager : IService
    {
        public void Ekle()
        {
            Console.WriteLine("kampanya eklendi");
        }

        public void Güncelle()
        {
            Console.WriteLine("kampanya güncellendi");
        }

        public void Kaldır()
        {
            Console.WriteLine("kampanya kaldırıldı");
        }
    }
}
