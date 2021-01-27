using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class MemberManager : IMemberService //inheritance(miras) vererek Imembers özelliklerinin MemberManager vererek somutlaştırmayı sağladık                                        
    {
        public void Ekle(Members members) //dışardan members değişkeni alan ekle isimli bir metot
        {
            CheckRealMemberManager checkRealMemberManager = new CheckRealMemberManager(); // members yani üyenin edevlet verisiyle uyuşup uyuşmadığını kontrol et

            if (checkRealMemberManager.Check(members))//kontrol ettikten sonra eğer true ise bu satırı çalıştır
            {
                Console.WriteLine("{0} sisteme eklendi", members.Adi);//ekrana {üyeadi} sisteme eklendi yazdir
            }
            else //değil ise bu satırı çalıştır
            {
                Console.WriteLine("Hesap  uyuşmadı");//ekrana hesap uyuşmadı yazdır
            }

        }

        public void Guncelle(Members members)//dışarıdan members alan güncelle isimli bir metot
        {
            Console.WriteLine("{0} sistemde güncellendi", members.Adi);//ekrana {üyeadi} sistemde güncellendi yazdir
        }

        public void Kaldir(Members members)//dışarıdan members alan kaldır isimli bir metot
        {
            Console.WriteLine("{0} sistemden silindi", members.Adi);//ekrana {üyeadi} sistemden silindi yazdir
        }
    }
}
