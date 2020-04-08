using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dnd_character_sheet;

namespace DataCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            DndCharacterData db = new DndCharacterData();
            using(db)
            {
                #region Races
                Race R1 = new Race()
                {
                    RaceId = 1,
                    Name = "Humans",
                    AbilityScore = 1,
                    Alignment = "Neutral",
                    Size = "5'5-6'0(medium)",
                    Speed = 30,
                    Languages = "English",

                };
                Race R2 = new Race()
                {
                    RaceId = 2,
                    Name = "Dwarves",
                    AbilityScore = 2,
                    Alignment = "Lawful Good",
                    Size = "5'0 or lower(small)",
                    Speed = 25,
                    Languages = "Dwarvish"
                };
                Race R3 = new Race()
                {
                    RaceId = 3,
                    Name = "Elves",
                    AbilityScore = 2,
                    Alignment = "Chaotic Evil",
                    Size = "6'1+(Large)",
                    Speed = 35,
                    Languages = "Elvish",
                };
                #endregion
                #region Classes
                Classes C1 = new Classes()
                {
                    Name = "Fighter",
                    ClassID = 1,
                    HitDice = 10,
                    FirstLevelHP = 10,
                    SavingThrow1 = "Strength",
                    SavingThrow2 = "Constitution",
                    Skill1 = "Acrobatics",
                    Skill2 = "Animal Handeling",
                    Skill3 = "Athletics",
                    Skill4 = "History",
                    Skill5 = "Perception",
                    Skill6 = "Intimidation",
                };
                Classes C2 = new Classes()
                {
                    Name = "Bard",
                    ClassID = 2,
                    HitDice = 8,
                    FirstLevelHP = 8 + 1,
                    SavingThrow1 = "Dexterity",
                    SavingThrow2 = "Charisma",
                    Skill1 = "Any",
                    Skill2 = "Any",
                    Skill3 = "Any",
                    Skill4 = "n/a",
                    Skill5 = "n/a",
                    Skill6 = "n/a",
                    

                };
                Classes C3 = new Classes()
                {
                    Name = "Rogue",
                    ClassID = 3,
                    HitDice = 8,
                    FirstLevelHP = 8 + 2,
                    SavingThrow1 = "Dexterity",
                    SavingThrow2 = "Intelligence",
                    Skill1 = "Stealth",
                    Skill2 = "Sleight Of Hand",
                    Skill3 = "Acrobatics",
                    Skill4 = "Athletics",
                    Skill5 = "Deception",
                    Skill6 = "Perception",
                };
                #endregion

            }


        }
    }
}
