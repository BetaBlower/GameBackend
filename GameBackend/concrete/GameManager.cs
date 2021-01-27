using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class GameManager : IGameService //inheritance(miras) vererek Igame özelliklerinin GameManager'a vererek somutlaştırmayı sağladık  
    {
        public void Ekle(Games games)//dışarıdan games adlı değişken alan ekle isimli bir metot oluşturduk
        {

            Console.WriteLine("{0} oyunu eklendi.\nTürü : {1} \nID : {2} \nFiyatı : {3}", games.OyunAdi,games.OyunTürü,games.Id,games.OyunFiyati);
            //{oyunadi} oyunu eklendi.(\n = bir alt satıra geç) Türü : {oyuntürü}  Id : {oyunID} \n fiyati : {oyunfiyati}

            // \n sözcük satırlarında bir alt satıra geçirir ama dikkat edilmesi gerekn bir husus vardır bu sola eğik çizgi ile yazılır = \n 
        }

        public void Guncelle(Games games)//dışarıdan games adlı değişken alan güncelle isimli bir metot oluşturduk
        {
            Console.WriteLine("{0} oyunu güncellendi.\nTürü : {1}\nID : {3}\nFiyatı :{2}", games.OyunAdi, games.OyunTürü, games.OyunFiyati,games.Id);
            //{oyunadi} oyunu güncellendi.
            //Türü : {oyuntürü}  
            //Id : {oyunID} 
            //fiyati : {oyunfiyati}
        }

        public void Kaldir(Games games)//dışarıdan games adlı değişken alan Kaldır isimli bir metot oluşturduk
        {
            Console.WriteLine("{0} adlı oyun kaldırıldı.", games.OyunAdi);//yazdır "{oyunadi} adli oyun kaldırıldı"
        }
    }
}
