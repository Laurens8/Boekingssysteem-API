using Boekingssysteem.Data;
using Boekingssysteem.Models;
using Boekingssysteem_API.Interfaces;

namespace Boekingssysteem_API.Repository
{
    public class PersoonRepository : IPersoonRepository
    {
        private readonly BoekingssysteemContext _context;

        public PersoonRepository(BoekingssysteemContext context)
        {
            _context = context;
        }

        public Persoon GetPersoon(string id)
        {
            return _context.Personen.Where(p => p.Personeelnummer == id).FirstOrDefault();
        }

        public ICollection<Persoon> Getpersoonen()
        {
           return _context.Personen.OrderBy(p => p.Personeelnummer).ToList();
        }

        public bool PersoonExists(string id)
        {
            return _context.Personen.Any(p => p.Personeelnummer == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false; 
        }

        public bool UpdatePersoon(Persoon persoon)
        {
            _context.Update(persoon);
            return Save();
        }
    }
}
