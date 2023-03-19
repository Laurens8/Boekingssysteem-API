using Boekingssysteem.Models;

namespace Boekingssysteem_API.Interfaces
{
    public interface IPersoonRepository
    {
        ICollection<Persoon> Getpersoonen();
        Persoon GetPersoon(string id);
        bool PersoonExists(string id);
        bool UpdatePersoon(Persoon persoon);
    }
}
