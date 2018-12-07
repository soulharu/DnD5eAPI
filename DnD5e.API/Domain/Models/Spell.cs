namespace DnD5e.API.Domain.Models
{
    public class Spell
    {
        public int spellId { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public string school { get; set; }
        public string castingTime { get; set; }
        public string range { get; set; }
        public string components { get; set; }
        public string materialComponentDescription { get; set; }
        public string duration { get; set; }
        public bool isConcentration { get; set; }
        public bool isRitual { get; set; }
        public string description { get; set; }
        public string damage { get; set; }
        public string damageType { get; set; }
        public bool hasHigherLevels { get; set; }
        public string higherLevelDescription { get; set; }
        public string book { get; set; }
        public int page { get; set; }
    }
}
