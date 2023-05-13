using System.ComponentModel.DataAnnotations;

namespace Boekingssysteem_API.Data.Dto
{
    public class PersoonDto
    {
        public string Personeelnummer { get; set; }
        public string Naam { get; set; }  
        public string Voornaam { get; set; }
        public bool Admin { get; set; }
        public bool? Aanwezig { get; set; }
        public string Wachtwoord { get; set; }
    }
}
