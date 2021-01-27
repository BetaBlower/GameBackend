using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class MemberManager : IMemberService
    {
        public void Ekle(Members members)
        {
            CheckRealMemberManager checkRealMemberManager = new CheckRealMemberManager();

            if (checkRealMemberManager.Check(members))
            {
                Console.WriteLine("{0} sisteme eklendi", members.Adi);
            }
            else
            {
                Console.WriteLine("Hesap  uyuşmadı");
            }

        }

        public void Güncelle(Members members)
        {
            Console.WriteLine("{0} sistemden silindi", members.Adi);
        }

        public void Kaldır(Members members)
        {
            Console.WriteLine("{0} sistemde güncellendi", members.Adi);
        }
    }
}
