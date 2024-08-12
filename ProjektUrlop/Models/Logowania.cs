using System.ComponentModel.DataAnnotations;

namespace ProjektUrlop.Models
{
    public class Logowania
    {
        [Key]
        public int Id { get; set; }
        public int Id_pracownika { get; set; }
        public DateTime DataLogowania { get; set; }
    }
}