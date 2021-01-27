using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class MemberManager 
    {
        public void Ekle(Members members)
        {
            CheckRealMemberManager checkRealMemberManager = new CheckRealMemberManager();

            if (checkRealMemberManager.Check(members))
            {
                Console.WriteLine("{0} sisteme eklendi", members.Adi);
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
