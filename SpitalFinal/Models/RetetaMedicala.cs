namespace SpitalFinal.Models
{
    public class RetetaMedicala
    {
        public int RetetaMedicalaId { get; set; }
        public string? Denumire { get; set; }
        public string? Prospect { get; set; }
        public DateTime? DataExpirare { get; set; }

        public ICollection<FisaMedic>? FisaMedics { get; set; }

        //internal object Include(Func<object, object> value)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
