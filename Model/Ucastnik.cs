using System;

namespace Model
{
    public class Ucastnik
    {
        public int Id {get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime Narozen { get; set; }
        public DateTime Created { get; set; }
        public int Vek
        {
            get
            { 
                return (DateTime.Now - Narozen).Days;            
            }
        }

        public Ucastnik()
        {
            Narozen = DateTime.Now;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}, ", Jmeno, Prijmeni, Vek);
        }
    }
}
