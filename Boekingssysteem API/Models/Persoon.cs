using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem.Models
{
    public class Persoon
    {
        [Key]
        [MinLength(8)]
        [MaxLength(8)]
        public string Personeelnummer { get; set; }      
        public string Naam { get; set; }      
        public string Voornaam { get; set; }        
        public bool Admin { get; set; }
        public bool? Aanwezig { get; set; }

        //Navigatieproperties
        public virtual ICollection<Afwezigheid> Afwezigheden { get; set; }
        public virtual ICollection<PersoonRichting> PersoonRichtingen { get; set; }
        public virtual ICollection<PersoonFunctie> PersoonFuncties { get; set; }
    }
}
