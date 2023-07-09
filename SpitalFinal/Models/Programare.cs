
using ServiceStack.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SpitalFinal.Models

{
    public class Programare
    {
        [Index(Unique = true)]
        public int ProgramareId { get; set; }
        [Index(Unique =  true)]
        [Display(Name = "Program Lucru")]
        public int ProgramLucruId { get; set; }

        public string? nume { get ; set; }

        public int Varsta { get; set; }
        public string? sex { get; set; }
        [Display(Name = "Medic")]
        public int MedicId { get; set; }

        public  Medic? Medic { get; set; }
        public DateTime? DataProgramari { get; set; }
        public ProgramLucru? ProgramLucru { get; set; }
       
    }


}