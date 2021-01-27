using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public interface IMemberService 
    {
        void Ekle(Members members);
        void Kaldır(Members members);
        void Güncelle(Members members);
    }
}
