using System.ComponentModel.DataAnnotations;

namespace SpitalFinal.Models
{
    public class Investigatie
    {

        public int InvestigatieId { get; set; }
       
        public string? Rezultat { get; set; }
        [Display(Name = "Data Zilei")]
        public DateTime? datazilei { get ; set; }

        public int FisaMedicId { get; set; }
        [Display(Name = "Nume Fisa")]
        public  FisaMedic? FisaMedic { get; set; }


    }
}
