using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Hesapla
    {
        public Single vize = 0;
        public Single final = 0;
        public Single vizeYuzde = 0;
        public Single sonuc;

        public Single BasariAl()
        {
            sonuc = ((vize * vizeYuzde) / 100) + ((final * (100 - vizeYuzde)) / 100);
            return sonuc;
        }
    }
}
