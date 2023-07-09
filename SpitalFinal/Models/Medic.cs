namespace SpitalFinal.Models
{
    public class Medic
    {
        public int MedicId { get; set; }
        public string? Nume { get; set; }
        public string? Specializare { get; set; }
        public DateTime DataNastere { get; set; }
        public String? Telefon { get; set; }
        public int Varsta { get; set; }

        public int SectieId { get; set; }
        public  Sectie? Sectie { get; set; }

  
        public ICollection<FisaMedic>? FisaMedics { get; set; }
        public ICollection<Programare>? Programares { get; set; }

    }
}