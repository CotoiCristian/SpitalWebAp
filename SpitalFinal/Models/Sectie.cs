namespace SpitalFinal.Models
{
    public class Sectie
    {
        public int SectieId { get; set; }
        public string? NumeSectie { get  ; set; }
        public int Etaj { get; set; }

        List<Sectie> listaSectie = new List<Sectie>();
        public ICollection<Medic>? Medics { get; set; }

        
      
    }

}
