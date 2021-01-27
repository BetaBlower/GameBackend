using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class Members 
    {
        public int Id { get; set; } //üyeler sınıfına Id isimli bir özellik ekle
        public string Adi { get; set; }//üyeler sınıfına adi isimli bir özellik ekle
        public string SoyAdi { get; set; }//üyeler sınıfına soyadi isimli bir özellik ekle
        public string TcNo { get; set; }//üyeler sınıfına Tcno isimli bir özellik ekle
        public int DoğumYili { get; set; }//üyeler sınıfına Doğumyili isimli bir özellik ekle
    }
}
