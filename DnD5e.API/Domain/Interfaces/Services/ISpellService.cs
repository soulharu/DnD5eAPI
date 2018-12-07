using DnD5e.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5e.API.Domain.Interfaces.Services
{
    public interface ISpellService
    {
        void Add(Spell spell);
        Spell GetById(int id);
    }
}
