using DnD5e.API.Domain.Interfaces.Repositories;
using DnD5e.API.Domain.Interfaces.Services;
using DnD5e.API.Domain.Models;

namespace DnD5e.API.Domain.Services
{
    public class SpellService : ISpellService
    {
        private ISpellRepository _spellrepository;

        public SpellService(ISpellRepository spellrepository)
        {
            _spellrepository = spellrepository;
        }

        public void Add(Spell spell)
        {
            _spellrepository.Add(spell);
        }

        public Spell GetById(int id)
        {
            return _spellrepository.GetById(id);
        }
    }
}
