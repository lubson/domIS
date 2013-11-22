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
    }
}
