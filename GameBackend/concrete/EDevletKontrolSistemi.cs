using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class EDevletKontrolSistemi
    {
        EDevletDB eDevletDB = new EDevletDB { Adi = "Ali", SoyAdi = "Kuşku", Id = 1, TcNo = "12345678900", DoğumYılı = 1970 };
        public bool EDevletKontrol(Members members)
        {
            if (members.Adi == eDevletDB.Adi && members.DoğumYılı == eDevletDB.DoğumYılı && members.SoyAdi == eDevletDB.SoyAdi && members.TcNo == eDevletDB.TcNo)
                return true;
            else return false;

        }
    }
}
