﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Kurs
    {
        public int KursId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage="Wprowdź nazwe kursy")]
        [StringLength(100)]
        public string TytulKursu { get; set; }
        [Required(ErrorMessage = "Wprowdź nazwe autora")]
        [StringLength(100)]
        public string AutorKursu { get; set; }
        public DateTime  DataDodania { get; set; }
        [StringLength(100)]
        public string NazwaPlikuObrazka { get; set; }
        public string OpisKursu{ get; set; }
        public decimal CenaKursu { get; set; }
        public bool Ukryty { get; set; }

        public virtual Kategoria Kategoria { get; set}

    }
}