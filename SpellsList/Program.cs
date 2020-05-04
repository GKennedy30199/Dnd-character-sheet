using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dnd_character_sheet;

namespace SpellsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsList Sp = new SpellsList();
            using(Sp)
            {
                #region Spells
                Spells S1 = new Spells()
                {
                    SpellsID = 1,
                    Name="Eldritch Blast",
                    Level=0,// what level you need to have the spell
                    CastTime="1A",//how long the spell takes to cast(1A=1 action(can only be done once a turn) 1ba=1 bonus action(can be done on multiple turns) 1min=takes up the entire turn)
                    Range=120,
                    Description= "A beam of crackling energy streaks toward a creature within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 force damage.",
                };
                Spells S2 = new Spells()
                {
                    SpellsID = 2,
                    Name="Fire Bolt",
                    Level=0,
                    CastTime="1A",
                    Range=120,
                    Description= "You hurl a mote of fire at a creature or object within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 fire damage. A flammable object hit by this spell ignites if it isn’t being worn or carried"
                };
                Spells S3 = new Spells()
                {
                    SpellsID=3,
                    Name="Chill Touch",
                    Level=0,
                    CastTime="1A",
                    Range=120,
                    Description= "You create a ghostly, skeletal hand in the space of a creature within range." +
                    "Make a ranged spell attack against the creature to assail it with the chill of the grave. On a hit, the target takes 1d8 necrotic damage, and it can’t regain hit points until the start of your next turn."
                };
                Spells S4 = new Spells()
                {
                    SpellsID = 4,
                    Name = "Light",
                    Level = 0,
                    CastTime = "1A",
                    Range = 0,
                    Description = "You touch one object that is no larger than 10 feet in any dimension. " +
                    " Until the spell ends, the object sheds bright light in a 20-foot radius and dim light for an additional 20 feet. ",
                };
                Spells S5 = new Spells()
                {
                    SpellsID=5,
                    Name="Mage Hand",
                    Level=0,
                    CastTime="1A",
                    Range=30,
                    Description= "A spectral, floating hand appears at a point you choose within range." +
                    "The hand lasts for the duration or until you dismiss it as an action."
                };
                Spells S6 = new Spells()
                {
                    SpellsID=6,
                    Name="Mending",
                    Level=0,
                    CastTime="1min",
                    Range=0,
                    Description= "This spell repairs a single break or tear in an object you touch, such as broken chain link, two halves of a broken key, a torn cloack, or a leaking wineskin."
                };
                Spells S7 = new Spells()
                {
                    SpellsID=7,
                    Name="Blade Ward",
                    Level=0,
                    CastTime="1A",
                    Range=0,
                    Description= "You extend your hand and trace a sigil of warding in the air. Until the end of your next turn, you have resistance against bludgeoning, piercing, and slashing damage dealt by weapon attacks."
                };
                Spells S8 = new Spells()
                {
                    SpellsID=8,
                    Name="True Strike",
                    Level=0,
                    CastTime="1A",
                    Range=30,
                    Description= "You extend your hand and point a finger at a target in range. Your magic grants you a brief insight into the target’s defenses. On your next turn, you gain advantage on your first attack roll against the target, provided that this spell hasn’t ended."
                };
                Spells S9 = new Spells()
                {
                    SpellsID = 9,
                    Name = "Vicious Mockery",
                    Level = 0,
                    CastTime = "1A",
                    Range=60,
                    Description= "You unleash a string of insults laced with subtle enchantments at a creature you can see within range." +
                    "If the target can hear you (thought it need not understand you), it must succeed on a Wisdom saving throw or take 1d4" +
                    "psychic damage and have disadvantage on the next attack roll it makes before the end of its next turn"
                };
                Spells S10 = new Spells()
                {
                    SpellsID=10,
                    Name="Spare the dying",
                    Level=0,
                    CastTime="1A",
                    Range=0,
                    Description= "You touch a living creature that has 0 hit points. The creature becomes stable. This spell has no effect on undead or constructs",
                };
                Spells S11 = new Spells()
                {
                    SpellsID=11,
                    Name="Burning Hand",
                    Level=1,
                    CastTime="1A",
                    Range=15,
                    Description= "As you hold your hands with thumbs touching and fingers spread, a thin sheet of flames shoots forth from your outstretched fingertips. Each creature in a 15-foot cone must make a Dexterity saving throw." +
                    "A creature takes 3d6 fire damage on a failed save, or half as much damage on a successful one."
                };
                Spells S12 = new Spells()
                {
                    SpellsID=12,
                    Name="Charm Person",
                    Level=1,
                    CastTime="1A",
                    Range=30,
                    Description= "You attempt to charm a humanoid you can see within range." +
                    "It must make a Wisdom saving throw, and does so with advantage if you or your companions are fighting it." +
                    "If it fails the saving throw, it is charmed by you until the spell ends or until you or your companions do anything harmful to it."
                };
                Spells S13 = new Spells()
                {
                    SpellsID=13,
                    Name="Bless",
                    Level=1,
                    CastTime="1A",
                    Range=30,
                    Description= "You bless up to three creatures of your choice within range. " +
                    "Whenever a target makes an attack roll or a saving throw before the spell ends, " +
                    "the target can roll a d4 and add the number rolled to the attack roll or saving throw."
                };
                Spells S14 = new Spells()
                {
                    SpellsID=14,
                    Name="Chromatic Orb",
                    Level=1,
                    CastTime="1A",
                    Range=90,
                    Description= "You hurl a 4-inch-diameter sphere of energy at a creature that you can see within range. " +
                    "You choose acid, cold, fire, lightning, poison, or thunder for the type of orb you create, and then make a ranged spell attack against the target. " +
                    "If the attack hits, the creature takes 3d8 damage of the type you chose."
                };
                Spells S15 = new Spells()
                {
                    SpellsID=15,
                    Name="Detect Magic",
                    Level=1,
                    CastTime="1A",
                    Range=0,
                    Description= "For the duration, you sense the presence of magic within 30 feet of you. If you sense magic in this way, you can use your action to see a faint aura around any visible creature or object in the area that bears magic, and you learn its school of magic, if any."

                };
                Spells S16 = new Spells()
                {
                    SpellsID=16,
                    Name="Aid",
                    Level=2,
                    CastTime="1A",
                    Range=30,
                    Description= "Your spell bolsters your allies with toughness and resolve." +
                    "Choose up to three creatures within range. Each target’s hit point maximum and current hit points increase by 5 for the duration"

                };
                Spells S17 = new Spells()
                {
                    SpellsID=17,
                    Name="Flame Blade",
                    Level=2,
                    CastTime="1BA",
                    Range=0,
                    Description= "You evoke a fiery blade in your free hand." +
                    "The blade is similar in size and shape to a scimitar, and it lasts for the duration. If you let go of the blade, it disappears, but you can evoke the blade again as a bonus action."
                };
                Spells S18 = new Spells()
                {
                    SpellsID=18,
                    Name="Magic Mouth",
                    Level=2,
                    CastTime="1 Minute",
                    Range=30,
                    Description= "You implant a message within an object in range, a message that is uttered when a trigger condition is met."+
                    "Choose an object that you can see and that isn’t being worn or carried by another creature.Then speak the message,"+
                    "which must be 25 words or less,"+
                    "though it can be delivered over as long as 10 minutes.Finally,"+
                    "determine the circumstance that will trigger the spell to deliver your message"
                };
                Spells S19 = new Spells()
                {
                    SpellsID=19,
                    Name="Darkvision",
                    Level=2,
                    CastTime="1A",
                    Range=0,
                    Description= "You touch a willing creature to grant it the ability to see in the dark" +
                    "For the duration, that creature has darkvision out to a range of 60 feet"
                };
                Spells S20= new Spells()
                {
                    SpellsID=20,
                    Name="Crown of madness",
                    Level=2,
                    CastTime="1A",
                    Range=120,
                    Description= "One humanoid of your choice that you can see within range must succeed on a Wisdom saving throw or become charmed" +
                    "by you for the duration" +
                    "While the target is charmed in this way, a twisted crown of jagged iron appears on its head, and a madness glows in its eyes."
                };
                Spells S21 = new Spells()
                {
                    SpellsID=21,
                    Name="Blinding Smite",
                    Level=3,
                    CastTime="1BA",
                    Range=0,
                    Description= "The next time you hit a creature with a melee weapon attack during this spell’s duration, you weapon flares with a bright" +
                    "light, and the attack deals an extra 3d8 radiant damage to the target. Additionally, the target must succeed on a" +
                    "Constitution saving throw or be blinded until the spell ends."
                };
                Spells S22 = new Spells()
                {
                    SpellsID=22,
                    Name="Fly",
                    Level=3,
                    CastTime="1A",
                    Range=0,
                    Description= "You touch a willing creature. The target gains a flying speed of 60 feet for the duration. When the spell ends, the target falls if it is still aloft, unless it can stop the fall."
                };
                Spells S23 = new Spells()
                {
                    SpellsID=23,
                    Name="Leomund's Tiny Hut",
                    Level=3,
                    CastTime="1min",
                    Range=1,
                    Description= "A 10-foot-radius immobile dome of force springs into existence around and above you and remains stationary for the duration. The spell ends if you leave its area."
                };
                Spells S24 = new Spells()
                {
                    SpellsID=24,
                    Name="Lightning bolt",
                    Level=3,
                    CastTime="1A",
                    Range=1,
                    Description= "A stroke of lightning forming a line of 100 feet long and 5 feet wide blasts out from you in a direction you choose. Each creature in the line must make a Dexterity saving throw. A creature takes 8d6 lightning damage on a failed save, or half as much damage on a successful one"
                };
                Spells S25 = new Spells()
                {
                    SpellsID=25,
                    Name="Beacon of hope",
                    Level=3,
                    CastTime="1A",
                    Range=30,
                    Description= "This spell bestows hope and vitality. Choose any number of creatures within range. For the duration, each target has advantage on Wisdom saving throws and death saving throws, and regains the maximum number of hit points possible from any healing"
                };
                Spells S26 = new Spells()
                {
                    SpellsID=26,
                    Name="Arcane Eye",
                    Level=4,
                    CastTime="1A",
                    Range=30,
                    Description= "You create an invisible, magical eye within range that hovers in the air for the duration."+
                     "You mentally receive visual information from the eye,"+
                    "which has normal vision and darkvision out to 30 feet.The eye can look in every direction"
                };
                Spells S27 = new Spells()
                {
                    SpellsID=27,
                    Name="Death Ward",
                    Level=4,
                    CastTime="1A",
                    Range=0,
                    Description= "You touch a creature and grant it a measure of protection from death."+
                    "The first time the target would drop to 0 hit points as a result of taking damage,"+
                    "the target instead drops to 1 hit point,"+
                    "and the spell ends.If the spell is still in effect when the target is subjected to an effect that would kill it instantaneously without dealing damage,"+
                    "that effect is instead negated against the target,"+
                    "and the spells ends."
                };
                Spells S28 = new Spells()
                {
                    SpellsID=28,
                    Name="FireShield",
                    Level=4,
                    CastTime="1A",
                    Range=0,
                    Description="Thin and wispy flames wreathe your body for the duration, shedding bright light in a 10-foot radius and dim light for an additional 10 feet, You can end the spell early by using an action to dismiss it"
                };
                Spells S29 = new Spells()
                {
                    SpellsID=29,
                    Name="Polymorph",
                    Level=4,
                    CastTime="1A",
                    Range=60,
                    Description= "This spell transforms a creature that you can see within range into a new form. An unwilling creature must make a Wisdom saving throw to avoid the effect. A shapechanger automatically succeeds on this saving throw"
                };
                Spells S30 = new Spells()
                {
                    SpellsID=30,
                    Name="Stoneskin",
                    Level=4,
                    CastTime="1A",
                    Range=0,
                    Description= "This spell turns the flesh of a willing creature you touch as hard as stone. Until the spell ends, the target has resistance to nonmagical bludgeoning, piercing, and slashing damage"
                };
                #endregion
                Sp.Spells.Add(S1);
                Sp.Spells.Add(S2);
                Sp.Spells.Add(S3);
                Sp.Spells.Add(S4);
                Sp.Spells.Add(S5);
                Sp.Spells.Add(S6);
                Sp.Spells.Add(S7);
                Sp.Spells.Add(S8);
                Sp.Spells.Add(S9);
                Sp.Spells.Add(S10);
                Sp.Spells.Add(S11);
                Sp.Spells.Add(S12);
                Sp.Spells.Add(S13);
                Sp.Spells.Add(S14);
                Sp.Spells.Add(S15);
                Sp.Spells.Add(S16);
                Sp.Spells.Add(S17);
                Sp.Spells.Add(S18);
                Sp.Spells.Add(S19);
                Sp.Spells.Add(S20);
                Sp.Spells.Add(S21);
                Sp.Spells.Add(S22);
                Sp.Spells.Add(S23);
                Sp.Spells.Add(S24);
                Sp.Spells.Add(S25);
                Sp.Spells.Add(S26);
                Sp.Spells.Add(S27);
                Sp.Spells.Add(S28);
                Sp.Spells.Add(S29);
                Sp.Spells.Add(S30);
                Console.WriteLine("Spells added");
                Sp.SaveChanges();
                Console.WriteLine("Saved spells");
            }
        }
    }
}
