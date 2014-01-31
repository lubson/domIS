using System;

namespace Model
{
    public class Ucastnik
    {
        public int Id {get; set; }

        public int NarodnostId { get; set; }
        
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime Narozen { get; set; }
        public DateTime DateCreated { get; set; }
        public EPohlavi Pohlavi { get; set; }

        public virtual CNarodnost Narodnost { get; set; }

        public Ucastnik()
        {
            Pohlavi = EPohlavi.Neznamo;
        }
        
        public int Vek
        {
            get
            { 
                return (DateTime.Now - Narozen).Days;            
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}, ", Jmeno, Prijmeni, Vek);
        }
    }
}
