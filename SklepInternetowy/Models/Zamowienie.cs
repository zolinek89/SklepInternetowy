using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }
        [Required(ErrorMessage = "Wprowdź imie")]
        [StringLength(50)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wprowdź nazwisko")]
        [StringLength(50)]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wprowdź ulicę")]
        [StringLength(100)]
        public string Ulica { get; set; }
        [Required(ErrorMessage = "Wprowdź miasto")]
        [StringLength(100)]
        public string KodPocztowy { get; set; }
        [Required(ErrorMessage = "Wprowdź kod pocztowy")]
        [StringLength(6)]
        public string Miasto { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Komentarz { get; set; }
        public DateTime DataDodania { get; set; }
        public decimal WartoscZamowienia { get; set; }
        public StanZamowienia StanZamowienia { get; set; }

        List<PozycjaZamowienia> PozycjaZamowienia { get; set; }

    }
    public enum StanZamowienia
    {
        Nowe,
        Zrealizowane
    }
}