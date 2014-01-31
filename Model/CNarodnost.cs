using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CNarodnost : Ciselnik
    {
        public virtual ICollection<Ucastnik> Ucastnici { get; set; }
        
        public CNarodnost()
        {
            Ucastnici = new List<Ucastnik>();
        }
    }
}
