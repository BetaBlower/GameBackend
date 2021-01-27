using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Members members = new Members {Adi="Ali",SoyAdi="Kuşku",Id = 1,TcNo="12345678900",DoğumYılı = new DateTime(1970)};
            Games games = new Games { Id = 1, OyunAdi = "Call OF Duty",OyunTürü = "Fps Shooter",OyunFiyati = 20 };
            Games games2 = new Games { Id = 2, OyunAdi = "MineCraft", OyunTürü = "Survival", OyunFiyati = 10 };


            IService kampanya = new KampanyaManager();
            MemberManager memberManager = new MemberManager();
            GameManager gameManager = new GameManager();

            memberManager.Ekle(members);

            gameManager.Ekle(games); 

            kampanya.Ekle();


        }
    }
}
