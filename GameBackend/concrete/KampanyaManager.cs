using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class KampanyaManager : IKampanyaService //inheritance(miras) vererek Ikampnaya özelliklerinin KampanyaManager'a vererek somutlaştırmayı sağladık   
    {
        public void Ekle(Kampanya kampanya)//dışarıdan kampanya değişkeni alan ekle isimli bir metot oluşturduk
        {
            Console.WriteLine("{0} kampanyası eklendi = {1} ",kampanya.KampanyaAdi,kampanya.KampanyaAciklama);//ekrana "{kampanyaadi} kampanyasi eklendi = {kampanyaaçıklama}" yazdır
            
                                                                                                               
        }

        public void Guncelle(Kampanya kampanya)//dışarıdan kampanya değişkeni alan güncelle isimli bir metot oluşturduk
        {
            Console.WriteLine("{0} kampanyası güncellendi",kampanya.KampanyaAdi);//ekrana "{kampanyaadi} kampanyasi güncellendi " yazdır

        }

        public void Kaldir(Kampanya kampanya)//dışarıdan kampanya değişkeni alan kaldır isimli bir metot oluşturduk
        {
            Console.WriteLine("{0} kampanyası kaldırıldı",kampanya.KampanyaAdi);//ekrana "{kampanyaadi} kampanyasi kaldırıldı " yazdır
        }
    }
}
