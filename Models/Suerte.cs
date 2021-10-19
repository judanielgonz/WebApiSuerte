﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSuerte.Models
{
    public class Suerte
    {
        [Key]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string FuturoId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Letra { get; set; }

        [Url]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Enlace { get; set; }


    }
}
