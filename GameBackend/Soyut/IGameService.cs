using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IGameService
    {
        void Ekle(Games games);
        void Kaldır(Games games);
        void Güncelle(Games games);
    }
}
