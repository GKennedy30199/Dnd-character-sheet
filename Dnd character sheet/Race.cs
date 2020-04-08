
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnd_character_sheet
{
    public class Race
    {
        public int RaceId { get; set; }
        public string Name { get; set; }
        public int AbilityScore { get; set; }
        public string Alignment { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public string Languages { get; set; }
        

    }
    public class Classes
    {
        public string Name { get; set; }
        public int ClassID { get; set; }
        public int HitDice { get; set; }
        public int FirstLevelHP { get; set; }
        public string SavingThrow1 { get; set; }
        public string SavingThrow2 { get; set; }
        public string Skill1 { get; set; }
        public string Skill2 { get; set; }
        public string Skill3 { get; set; }
        public string Skill4 { get; set; }
        public string Skill5 { get; set; }
        public string Skill6 { get; set; }
        
        public virtual List<Feat> feats { get; set; }
        
    }
    public class Feat
    {
        public int FeatID { get; set; }
        public int ClassID { get; set; }
        public string Description { get; set; }
    }
    public class DndCharacterData : DbContext
    {
        public DndCharacterData() : base("DnDdata") { }
        public DbSet<Race> Races { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Feat> Feats { get; set; }
    }
}
