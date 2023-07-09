namespace SpitalFinal.Models
{
    public class Pacient
    {
        public int PacientId { get; set; }
        public string? NumePacient { get; set; }
        public string? Adresa { get; set; }
        public string? Telefon { get; set; }
        public int Varsta { get; set; }

       public ICollection<FisaMedic>? FisaMedics { get; set; }
    }
}
