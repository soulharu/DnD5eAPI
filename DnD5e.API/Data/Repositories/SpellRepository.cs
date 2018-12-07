using DnD5e.API.Data.Context;
using DnD5e.API.Data.Repositories.Base;
using DnD5e.API.Domain.Interfaces.Repositories;
using DnD5e.API.Domain.Models;

namespace DnD5e.API.Data.Repositories
{
    public class SpellRepository : BaseRepository<Spell> , ISpellRepository
    {
        public SpellRepository(APIContext context)
            :base(context)
        {
        }
    }
}
