using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IKampanyaService
    {
        void Ekle(Kampanya kampanya);//soyut olarak interface'e metot tanımı yap
        void Kaldir(Kampanya kampanya);//soyut olarak interface'e metot tanımı yap
        void Guncelle(Kampanya kampanya);//soyut olarak interface'e metot tanımı yap

        //bunu yapmamızın sebebi ilerde yeni metotlar eklemek istersek bunu diğer kodlara dokunmadan halledebilmek için
    }
}
