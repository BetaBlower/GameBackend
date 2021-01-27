using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class EDevletDB
    {
        public int Id { get; set; } //EdevletDataBase sınıfına Id isimli bir özellik ekle
        public string Adi { get; set; }//EdevletDataBase sınıfına adi isimli bir özellik ekle
        public string SoyAdi { get; set; }//EdevletDataBase sınıfına soyadi isimli bir özellik ekle
        public string TcNo { get; set; }//EdevletDataBase sınıfına TcNo isimli bir özellik ekle
        public int DoğumYili { get; set; }//EdevletDataBase sınıfına DoğumYili isimli bir özellik ekle
    }
}
