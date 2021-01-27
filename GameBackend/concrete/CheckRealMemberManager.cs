using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class CheckRealMemberManager 
    {
        EDevletKontrolSistemi eDevletKontrolSistemi = new EDevletKontrolSistemi();
        public bool Check(Members members)=>eDevletKontrolSistemi.EDevletKontrol(members);
        
            
        
       
    }
}
