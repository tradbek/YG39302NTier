using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTire.Dto
{
    public class Ogrenci
    {
        public string Ad { get; set; }

        public int Yas { get; set; }

        public string No { get; set; }

        public string Sinif { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
