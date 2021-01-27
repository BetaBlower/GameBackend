using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IGameService
    {
        void Ekle(Games games);//soyut olarak interface'e metot tanımı yap
        void Kaldir(Games games);//soyut olarak interface'e metot tanımı yap
        void Guncelle(Games games);//soyut olarak interface'e metot tanımı yap

        //bunu yapmamızın sebebi ilerde yeni metotlar eklemek istersek bunu diğer kodlara dokunmadan halledebilmek için
    }
}
