using System.ComponentModel.DataAnnotations;

namespace LAB3.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string Imie { get; set; }
        [MinLength(2, ErrorMessage = "Imię musi składać się z minimum 2 znaków."), MaxLength(50)]

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        public string Nazwisko { get; set; }
        [MinLength(2), MaxLength(50)]

        [Required(ErrorMessage = "Proszę podać hasło.")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$", ErrorMessage = "Hasło musi zawierać minimum 8 znaków, co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę.")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło.")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasło i Potwierdź Hasło muszą być takie same.")]
        public string PotwierdzHaslo { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Proszę podać poprawny numer telefonu.")]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Prosze podaj Wiek")]
        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80.")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Prosze podaj Miasto")]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string Temat { get; set; }
        [Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string Tresc { get; set; }
    }
}
