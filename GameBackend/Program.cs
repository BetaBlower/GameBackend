using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Members members = new Members {Adi="Ali",SoyAdi="Kuşku",Id = 1,TcNo="12345678900",DoğumYili = 1970}; //Üyelere yeni bir adres tanımla

            Games games = new Games { Id = 1, OyunAdi = "Call OF Duty",OyunTürü = "Fps Shooter",OyunFiyati = 20 };//Oyunlara yeni bir adres tanımla
            Games games2 = new Games { Id = 2, OyunAdi = "MineCraft", OyunTürü = "Survival", OyunFiyati = 10 };//Oyunlara yeni bir adres tanımla

            Kampanya kampanya = new Kampanya { KampanyaId = 1,KampanyaAdi="sana özel 10",KampanyaIndirimi = 10,KampanyaAciklama= "sana özel %10 indirim" };//Kampanyalara yeni bir adres tanımla
            Kampanya kampanya2 = new Kampanya { KampanyaId = 2, KampanyaAdi = "hoşgeldin 20", KampanyaIndirimi = 20,KampanyaAciklama= "yeni gelenlere özel % 20 indirim" };//kampanyalara yeni bir adres tanımla


            IKampanyaService kampanyaService = new KampanyaManager(); // KampanyaManageri kampanyaManager adresine tanımla
            IMemberService memberManager = new MemberManager();       // MemberManager memberManager adresine tanımla
            IGameService gameManager = new GameManager();             // GameManager gameManager adresine tanımla

            memberManager.Ekle(members); //Membermanager içinden Ekle Metotduna members değerini vererek çalıştır
            Console.WriteLine();
            gameManager.Ekle(games2);   //GameManager içinden Ekle Metotduna games2 değerini vererek çalıştır
            Console.WriteLine();
            kampanyaService.Ekle(kampanya2);//KampanyaManager içinden Ekle Metotduna Kampanya2 değerini vererek çalıştır


        }
    }
}
