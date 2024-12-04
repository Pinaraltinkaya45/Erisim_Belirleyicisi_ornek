using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim_Belirleyicisi_ornek
{
    public class Bitki // bitki superclass
    {
        public int bitkiID {  get; set; }
        protected string bitki_isim { get; set; }
        public string bitki_rengi { get; set; }

    }
}
