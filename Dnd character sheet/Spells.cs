using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Dnd_character_sheet
{
    
    public class Spells
    {
        public int SpellsID { get; set; }
        public int Level { get; set; }
        public String CastTime { get; set; }
        public String Name { get; set; }
        public int Range { get; set; }
        public string Description { get; set; }

    }
    public class SpellsList:DbContext
    {
        public SpellsList() : base("Spellslist") { }
        public DbSet<Spells> Spells { get; set; }
    }
}
