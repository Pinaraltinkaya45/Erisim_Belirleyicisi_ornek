using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyicisi_ornek
{
    public class Papatya :Bitki // subclass alt class : papatya alt class
    {
        public void papatyaBilgileri()
        {
            bitkiID = 1;
            bitki_isim = "Papatya";
            bitki_rengi = "Sari";

            Console.WriteLine("Bitki İd: " + bitkiID);
            Console.WriteLine("Bitki ismi: " + bitki_isim);
            Console.WriteLine("Bitkinin rengi: " + bitki_rengi);

        }
    }
}
