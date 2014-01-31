namespace Model
{
    public class  Ciselnik
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nazev { get; set; }
        public string ComboName
        {
            get { return Kod + " – " + Nazev; }
        }

        public override string ToString()
        {
            return ComboName;
        }
    }
}
