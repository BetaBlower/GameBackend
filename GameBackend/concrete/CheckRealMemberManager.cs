using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class CheckRealMemberManager 
    {
        EDevletDB eDevletDB = new EDevletDB { Adi = "Ali", SoyAdi = "Kuşku", Id = 1, TcNo = "12345678900", DoğumYılı = new DateTime(1970) };
        public bool Check(Members members)
        {
            
            if (members.Adi == eDevletDB.Adi && members.DoğumYılı == eDevletDB.DoğumYılı && members.SoyAdi == eDevletDB.SoyAdi && members.TcNo == eDevletDB.TcNo)
            {
                return true;
            }
            else return false;
        }
    }
}
