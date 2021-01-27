using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IKampanyaService
    {
        void Ekle(Kampanya kampanya);
        void Kaldır(Kampanya kampanya);
        void Güncelle(Kampanya kampanya);
    }
}
