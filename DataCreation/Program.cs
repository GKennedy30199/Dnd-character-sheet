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
            using (db)
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
                #region Fighter Feats
                Feat F1 = new Feat()
                {
                    Name = "Fighting style",
                    FeatID = 1,
                    ClassID = 1,
                    Level = 1,
                    Description = "You adopt a particular style of fighting as your specialty. " +
                    "Choose one of the following options. " +
                    "You can’t take a Fighting Style option more than once, even if you later get to choose again." +
                    "Archery: You gain a +2 bonus to attack rolls you make with ranged weapons." +
                    "Defense:While you are wearing armor, you gain a +1 bonus to AC." +
                    "Dueling:When you are wielding a melee weapon in one hand and no other weapons, you gain a +2 bonus to damage rolls with that weapon." +
                    "Great Weapon Fighting:When you roll a 1 or 2 on a damage die for an attack you make with a melee weapon that you are wielding with two hands, " +
                    "you can reroll the die and must use the new roll, even if the new roll is a 1 or a 2. " +
                    "The weapon must have the two-handed or versatile property for you to gain this benefit." +
                    "Protection:When a creature you can see attacks a target other than you that is within 5 feet of you, you can use your reaction to impose disadvantage on the attack roll." +
                    " You must be wielding a shield." +
                    "Two-Weapon Fighting:When you engage in two-weapon fighting, you can add your ability modifier to the damage of the second attack."

                };
                Feat F2 = new Feat()
                {
                    Name = "Second Wind",
                    FeatID = 2,
                    ClassID = 1,
                    Level = 1,
                    Description = "You have a limited well of stamina that you can draw on to protect yourself from harm. On your turn, you can use a bonus action to regain hit points equal to 1d10 + your fighter level. Once you use this feature, you must finish a short or long rest before you can use it again"
                };
                Feat F3 = new Feat()
                {
                    Name = "Action Surge",
                    FeatID = 3,
                    ClassID = 1,
                    Level = 2,
                    Description = "Starting at 2nd level, you can push yourself beyond your normal limits for a moment. On your turn, you can take one additional action." +
                    "Once you use this feature, you must finish a short or long rest before you can use it again. Starting at 17th level, you can use it twice before a rest, but only once on the same turn."
                };
                Feat F4 = new Feat()
                {
                    Name = "Martial Archetype",
                    FeatID = 4,
                    ClassID = 1,
                    Level = 3,
                    Description = "At 3rd level, you choose an archetype that you strive to emulate in your combat styles and techniques. Choose Champion, Battle Master, or Eldritch Knight"
                };
                Feat F5 = new Feat()
                {
                    Name = "Ability Scores",
                    FeatID = 5,
                    ClassID = 1,
                    Level = 4,
                    Description = "When you reach 4th level, and again at 6th, 8th, 12th, 14th, 16th, and 19th level, " +
                    "you can increase one ability score of your choice by 2, or you can increase two ability scores of your choice by 1. " +
                    "As normal, you can’t increase an ability score above 20 using this feature."
                };
                Feat F6 = new Feat()
                {
                    Name = "Extra Attack",
                    FeatID = 6,
                    ClassID = 1,
                    Level = 5,
                    Description = "Beginning at 5th level, you can attack twice, instead of once, whenever you take the Attack action on your turn." +
                    "The number of attacks increases to three when you reach 11th level in this class and to four when you reach 20th level in this class."

                };
                Feat F7 = new Feat()
                {
                    Name = "Indomitable",
                    FeatID = 7,
                    ClassID = 1,
                    Level = 9,
                    Description = "Beginning at 9th level, you can reroll a saving throw that you fail. If you do so, you must use the new roll, and you can’t use this feature again until you finish a long rest." +
                    "You can use this feature twice between long rests starting at 13th level and three times between long rests starting at 17th level."
                };

                #endregion
                #region Bard Feats     
                Feat F8 = new Feat()
                {
                    Name = "SpellCasting",
                    FeatID = 8,
                    ClassID = 2,
                    Level = 1,
                    Description = "You have learned to untangle and reshape the fabric of reality in harmony with your wishes and music." +
                     " Your spells are part of your vast repertoire, magic that you can tune to different situations. See Spells Rules for " +
                     "the general rules of spellcasting and the Spells Listing for the bard spell list."
                };
                Feat F9 = new Feat()
                {
                    Name = "Bardic inspiration",
                    FeatID = 9,
                    ClassID = 2,
                    Level = 2,
                    Description = "You can inspire others through stirring words or music. " +
                    "To do so, you use a bonus action on your turn to choose one creature other than yourself within 60 feet of you who can hear you." +
                    " That creature gains one Bardic Inspiration die, a d6" +
                    "Once within the next 10 minutes, the creature can roll the die and add the number rolled to one ability check, " +
                    "attack roll, or saving throw it makes. The creature can wait until after it rolls the d20 before deciding to use the Bardic Inspiration die, " +
                    "but must decide before the DM says whether the roll succeeds or fails. Once the Bardic Inspiration die is rolled, it is lost. A creature can have only one Bardic Inspiration die at a time." +
                    "You can use this feature a number of times equal to your Charisma modifier (a minimum of once). You regain any expended uses when you finish a long rest" +
                    "Your Bardic Inspiration die changes when you reach certain levels in this class. The die becomes a d8 at 5th level, a d10 at 10th level, and a d12 at 15th level"
                };
                Feat F10 = new Feat()
                {
                    Name = "Bard College",
                    FeatID = 10,
                    ClassID = 2,
                    Level = 3,
                    Description = "At 3rd level, you delve into the advanced techniques of a bard college of your choice: " +
                    "the College of Lore detailed at the end of the class description or another from the Player's Handbook or other sources. " +
                    "Your choice grants you features at 3rd level and again at 6th and 14th level."
                };
                Feat F11 = new Feat()
                {
                    Name = "Expertise",
                    FeatID = 11,
                    ClassID = 2,
                    Level = 3,
                    Description = "At 3rd level, choose two of your skill proficiencies. " +
                    "Your proficiency bonus is doubled for any ability check you make that uses either of the chosen proficiencies." +
                    "This Feat also happens at Level 10."
                };
                Feat F12 = new Feat()
                {
                    Name = "Ability Score Improvement",
                    FeatID = 12,
                    ClassID = 2,
                    Level = 4,
                    Description = "When you reach 4th level, and again at 8th, 12th, 16th, and 19th level, you can increase one ability score " +
                    "of your choice by 2, or you can increase two ability scores of your choice by 1. As normal, you can’t increase an ability score " +
                    "above 20 using this feature"
                };
                Feat F13 = new Feat()
                {
                    Name = "Font of Inspiration",
                    FeatID = 13,
                    ClassID = 2,
                    Level = 5,
                    Description = "Beginning when you reach 5th level, you regain all of your expended uses of Bardic Inspiration when you finish a short or long rest"
                };
                Feat F14 = new Feat()
                {
                    Name = "Countercharm",
                    FeatID = 14,
                    ClassID = 2,
                    Level = 6,
                    Description = "At 6th level, you gain the ability to use musical notes or words of power to disrupt mind-influencing effects. " +
                    "As an action, you can start a performance that lasts until the end of your next turn. During that time, you and any friendly creatures within 30 feet of you have advantage on saving throws against being frightened " +
                    "or charmed. A creature must be able to hear you to gain this benefit. The performance ends early if you are incapacitated or silenced or if you voluntarily end it (no action required)."
                };
                Feat F15 = new Feat()
                {
                    Name = "Magical Secrets",
                    FeatID = 15,
                    ClassID = 2,
                    Level = 10,
                    Description = "By 10th level, you have plundered magical knowledge from a wide spectrum of disciplines. Choose two spells from any classes, including this one. A spell you choose must be of a level you can cast, as shown on the Bard table, or a cantrip." +
                    "The chosen spells count as bard spells for you and are included in the number in the Spells Known column of the Bard table" +
                    "You learn two additional spells from any classes at 14th level and again at 18th level."
                };
                Feat F16 = new Feat()
                {
                    Name = "Superior Inspiration",
                    FeatID = 16,
                    ClassID = 2,
                    Level = 20,
                    Description = "At 20th level, when you roll initiative and have no uses of Bardic Inspiration left, you regain one use."
                };
                #endregion
                #region Rogue Feats
                Feat F17 = new Feat()
                {
                    Name = "Expertise",
                    FeatID = 17,
                    ClassID = 3,
                    Level = 1,
                    Description = "At 1st level, choose two of your skill proficiencies, or one of your skill proficiencies and your proficiency with thieves’ tools." +
                    " Your proficiency bonus is doubled for any ability check you make that uses either of the chosen proficiencies." +
                    "This feat takes effect in 6th level also."
                };
                Feat F18 = new Feat()
                {
                    Name = "Sneak Attack",
                    FeatID = 18,
                    ClassID = 3,
                    Level = 1,
                    Description =
                    "Beginning at 1st level, you know how to strike subtly and exploit a foe’s distraction. " +
                    "Once per turn, you can deal an extra 1d6 damage to one creature you hit with an attack if you have advantage on the attack roll." +
                    " The attack must use a finesse or a ranged weapon." +
                    "You don’t need advantage on the attack roll if another enemy of the target is within 5 feet of it, " +
                    "that enemy isn’t incapacitated, and you don’t have disadvantage on the attack roll." +
                    "The amount of the extra damage increases as you gain levels in this class, as shown in the Sneak Attack column of the Rogue table."
                };
                Feat F19 = new Feat()
                {
                    Name = "Roguish Archetype",
                    FeatID = 19,
                    ClassID = 3,
                    Level = 3,
                    Description =
                    "At 3rd level, you choose an archetype that you emulate in the exercise of your rogue abilities: " +
                    "Thief, detailed at the end of the class description, or one from another source. Your archetype choice " +
                    "grants you features at 3rd level and then again at 9th, 13th, and 17th level."
                };
                Feat F20 = new Feat()
                {
                    Name = "Ability Score Improvement",
                    FeatID = 20,
                    ClassID = 3,
                    Level = 4,
                    Description =
                    "When you reach 4th level, and again at 8th, 10th, 12th, 16th, and 19th level, you can increase one ability score of your choice by 2, or you can increase " +
                    "two ability scores of your choice by 1. As normal, you can’t increase an ability score above 20 using this feature."

                };
                Feat F21 = new Feat()
                {
                    Name = "Uncanny Dodge",
                    FeatID = 21,
                    ClassID = 3,
                    Level = 5,
                    Description =
                    "Starting at 5th level, when an attacker that you can see hits you with an attack, you can use your reaction to halve the attack’s damage against you."
                };
                Feat F22 = new Feat()
                {
                    Name = "Evasion",
                    FeatID = 22,
                    ClassID = 3,
                    Level = 7,
                    Description =
                    "Beginning at 7th level, you can nimbly dodge out of the way of certain area effects," +
                    " such as an ancient red dragon’s fiery breath or an ice storm spell. When you are subjected to an " +
                    "effect that allows you to make a Dexterity saving throw to take only half damage, you instead take no damage if you succeed on the saving throw," +
                    " and only half damage if you fail."
                };
                Feat F23 = new Feat()
                {
                    Name = "Reliable Talent",
                    FeatID = 23,
                    ClassID = 3,
                    Level = 11,
                    Description =
                    "By 11th level, you have refined your chosen skills until they approach perfection. Whenever you make an ability check that lets you add your proficiency bonus, " +
                    "you can treat a d20 roll of 9 or lower " +
                    "as a 10"
                };
                Feat F24 = new Feat()
                {
                    Name = "Blindsense",
                    FeatID = 24,
                    ClassID = 3,
                    Level = 14,
                    Description =
                    "Starting at 14th level, if you are able to hear, you are aware of the location of any hidden or invisible creature within 10 feet of you."
                };
                Feat F25 = new Feat()
                {
                    Name = "Slippery Mind",
                    FeatID = 25,
                    ClassID = 3,
                    Level = 15,
                    Description =
                    "By 15th level, you have acquired greater mental strength. You gain proficiency in Wisdom saving throws"
                };
                Feat F26 = new Feat()
                {
                    Name = "Elusive",
                    FeatID = 26,
                    ClassID = 3,
                    Level = 18,
                    Description =
                    "Beginning at 18th level, you are so evasive that attackers rarely gain the upper hand against you. No attack roll has advantage against you while you aren’t incapacitated."
                };
                Feat F27 = new Feat()
                {
                    Name = "Stroke Of Luck",
                    FeatID = 27,
                    ClassID = 3,
                    Level = 20,
                    Description =
                    "At 20th level, you have an uncanny knack for succeeding when you need to. If your attack misses a target within range, you can turn the miss into a hit. " +
                    "Alternatively, if you fail an ability check, you can treat the d20 roll as a 20." +
                    "Once you use this feature, you can’t use it again until you finish a short or long rest."
                };





                #endregion
            }
        }
    }
}
