using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace SpitalFinal.Models
{
    public class FisaMedic
    {
        public int FisaMedicId { get; set; }
        [Display(Name = "Nume Fisa")]
        public string? Name { get; set; }
        [Display(Name = "Data Internari")]
        public DateTime? DataInternare { get; set; }
        [Required(ErrorMessage = "da")]
        [Display(Name = "Data Externari")]
        public DateTime? DataExternare { get; set; }
        [Display(Name = "Medic")]
        public int? MedicId { get; set; }
        [Display(Name = "Pacient")]
        public int PacientId { get; set; }
        [Display(Name = "Reteta Medicala")]
        public int RetetaMedicalaId { get; set; }
        public  Pacient? Pacient { get; set; }
        public  Medic? Medic { get; set; }
        public  RetetaMedicala? RetetaMedicala { get; set; }
        public ICollection<Investigatie>? Investigaties { get; set; }
    }
}