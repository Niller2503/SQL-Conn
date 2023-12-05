namespace Models
{
    public class Vare
    {
        public int ID {  get; set; }
        public string Varenavn { get; set; }
        public string VareBeskrivelse { get; set; }
        public int Antal { get; set; }
        public decimal Indkøbspris { get; set; }
        public decimal Fortjeneste { get; set; }
        public decimal Udsalgspris { get; set; }
    }
}