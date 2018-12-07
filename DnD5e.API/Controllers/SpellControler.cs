using DnD5e.API.Domain.Interfaces.Services;
using DnD5e.API.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DnD5e.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpellController : ControllerBase
    {
        private ISpellService _spellservice;

        public SpellController(ISpellService spellservice)
        {
            _spellservice = spellservice;
        }

        // GET api/spell/5
        [HttpGet("{id}")]
        public ActionResult<Spell> Get(int id)
        {
            return _spellservice.GetById(id); ;
        }

        // POST api/spell/addrange
        [HttpPost]
        [Route("addrange")]
        public void AddRange([FromBody] IEnumerable<Spell> spells)
        {
        }

        // POST api/spell/add
        [HttpPost]
        [Route("add")]
        public void Add([FromBody] Spell spell)
        {
            _spellservice.Add(spell);
        }

        // PUT api/spell/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
