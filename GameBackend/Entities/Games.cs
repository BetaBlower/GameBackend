using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class Games
    {
        public int Id { get; set; }//games sınıfına Id isimli bir özellik ekle
        public string OyunAdi { get; set; }//games sınıfına adı isimli bir özellik ekle
        public double OyunFiyati { get; set; }//games sınıfına fiyati isimli bir özellik ekle
        public string OyunTürü { get; set; }//games sınıfına türü isimli bir özellik ekle

    }
}
