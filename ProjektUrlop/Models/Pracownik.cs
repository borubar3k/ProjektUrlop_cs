using System.ComponentModel.DataAnnotations;

namespace ProjektUrlop.Models
{
    public class Pracownik
    {
        [Key]
        public int Id { get; set; }
        public string Imie { get; set; } = null!;
        public string Nazwisko { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Haslo { get; set; } = null!;
        public bool IsAdmin { get; set; }
        public bool IsArch { get; set; }
        public int DniUrlopu { get; set; }
        public DateTime DataZatrudnienia { get; set; }
    }
}
