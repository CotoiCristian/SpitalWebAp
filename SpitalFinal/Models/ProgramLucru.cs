using Microsoft.EntityFrameworkCore;
using SpitalFinal.Repositories;
using System.ComponentModel.DataAnnotations;

namespace SpitalFinal.Models
{
    public class ProgramLucru
    {

        [Display(Name = "Program de Lucru")]
        public int ProgramLucruId { get; set; }
        
        public string? NumeZi { get; set; }
        public DateTime? DataLibera { get; set; }

       
        public ICollection<Programare>? Programares { get; set; }
        public bool ObiecteAsociate
        {
            get
            {
                if (Programares == null)
                    return false;

               
                return Programares.Any(da => da.ProgramLucruId == ProgramLucruId);
            }
        }
    }
}