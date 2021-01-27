using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class CheckRealMemberManager 
    {
        EDevletKontrolSistemi eDevletKontrolSistemi = new EDevletKontrolSistemi();// Kimlik kontrol sistemine eDevletKontrolSistemi adına yeni bir adres tanımla
        public bool Check(Members members)=>eDevletKontrolSistemi.EDevletKontrol(members);//kimlik kontrol sistemine üye bilgileri gönder ve ordaki değeri al
        //eğer tek satırlık bir kod yazacaksanız burda olduğu gibi yapabilirsiniz arasında hiçbir fark yoktur ikiside çalışır
        //{
        //   return eDevletKontrolSistemi.EDevletKontrol(members);
        //}
            
        
       
    }
}
