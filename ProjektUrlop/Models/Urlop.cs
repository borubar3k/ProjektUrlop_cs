using System.ComponentModel.DataAnnotations;

namespace ProjektUrlop.Models
{
    public class Urlop
    {
        [Key]
        public int Id { get; set; }
        public int Id_pracownika { get; set; }
        public DateTime DataOD { get; set; }
        public DateTime DataDO { get; set; }
        public int LiczbaDni { get; set; }
        public bool IsAppr {  get; set; }
    }
}
