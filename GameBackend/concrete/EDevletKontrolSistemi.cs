using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class EDevletKontrolSistemi
    {
        EDevletDB eDevletDB = new EDevletDB { Adi = "Ali", SoyAdi = "Kuşku", Id = 1, TcNo = "12345678900", DoğumYili = 1970 };//Kimliğe yeni bir adres tanımla
        public bool EDevletKontrol(Members members)//bool türünde bir geriye dönüşlü metot oluştur (geriye dönüş void yerine bir veritipi yazarsanız string veya bool gibi geriye o tipte bir veri dönüşümü yapar)(bu bize bir değer verecektir)
        {
            if (members.Adi == eDevletDB.Adi && members.DoğumYili == eDevletDB.DoğumYili && members.SoyAdi == eDevletDB.SoyAdi && members.TcNo == eDevletDB.TcNo)//üyenin bilgileri kimlik ile yanı mı kontrol et
                return true;//eğer doğru ise dışarı true değeri ver
            else return false;//değil ise dışarı false değeri ver
            //(if kullanırken kodun tek satırsa süslü parantez kullanmana gerek yoktur)
        }
    }
}
