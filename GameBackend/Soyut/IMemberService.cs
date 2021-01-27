using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public interface IMemberService 
    {
        void Ekle(Members members); //soyut olarak interface'e metot tanımı yap
        void Kaldir(Members members);//soyut olarak interface'e metot tanımı yap
        void Guncelle(Members members);//soyut olarak interface'e metot tanımı yap

        //bunu yapmamızın sebebi ilerde yeni metotlar eklemek istersek bunu diğer kodlara dokunmadan halledebilmek için
    }
}
