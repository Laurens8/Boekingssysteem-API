﻿using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.Models
{
    public class PersoonRichting
    {
        public int PersoonRichtingID { get; set; }

        [MinLength(8)]
        [MaxLength(8)]
        [Required(ErrorMessage = "Personeelnummer moet ingevuld zijn!")]
        public string Personeelnummer { get; set; }

        [Required(ErrorMessage = "RichtingID moet ingevuld zijn!")]
        public int RichtingID { get; set; }

        //Navigatieproperties
        public virtual Persoon Persoon { get; set; }
        public virtual Richting Richting { get; set; }
    }
}
