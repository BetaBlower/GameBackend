using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Members members = new Members {Adi="Ali",SoyAdi="Kuşku",Id = 1,TcNo="12345678900",DoğumYılı = 1970};

            Games games = new Games { Id = 1, OyunAdi = "Call OF Duty",OyunTürü = "Fps Shooter",OyunFiyati = 20 };
            Games games2 = new Games { Id = 2, OyunAdi = "MineCraft", OyunTürü = "Survival", OyunFiyati = 10 };

            Kampanya kampanya = new Kampanya { KampanyaId = 1,KampanyaAdi="sana özel 10",KampanyaIndirimi = 10,KampanyaAciklama= "sana özel %10 indirim" };
            Kampanya kampanya2 = new Kampanya { KampanyaId = 2, KampanyaAdi = "hoşgeldin 20", KampanyaIndirimi = 20,KampanyaAciklama= "yeni gelenlere özel % 20 indirim" };


            IKampanyaService kampanyaService = new KampanyaManager();
            IMemberService memberManager = new MemberManager();
            IGameService gameManager = new GameManager();

            memberManager.Ekle(members);
            Console.WriteLine();
            gameManager.Ekle(games2);
            Console.WriteLine();
            kampanyaService.Ekle(kampanya2);
            

        }
    }
}
