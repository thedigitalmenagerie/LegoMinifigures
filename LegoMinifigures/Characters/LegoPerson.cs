using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Characters
{
    class LegoPerson
    {
        public string PlayerName { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Constitution { get; set; } = 0;
        public int Intelligence { get; set; } = 0;
        public int Wisdom { get; set; } = 0;
        public int Charisma { get; set; } = 0;
        public bool CharacterComplete { get; set; } = false;

        public LegoPerson(string playerName, string name)
        {
            PlayerName = playerName;
            Name = name;
        }

        public void RollForStrength()
        {
            for (int i = 0; i < 1; i++)
            {
                Strength = (new Random()).Next(1, 16);
                Console.WriteLine($"{Name} is beginning with a strength score of {Strength}");
                
            }
        }

        public void RollForDexterity()
        {
            for (int i = 0; i < 1; i++)
            {
                Dexterity = (new Random()).Next(1, 16);
                Console.WriteLine($"{Name} is beginning with a strength score of {Dexterity}");

            }
        }

        public void RollForConstitution()
        {
            for (int i = 0; i < 1; i++)
            {
                Constitution = (new Random()).Next(1, 16);
                Console.WriteLine($"{Name} is beginning with a strength score of {Constitution}");

            }
        }

        public void RollForIntelligence()
        {
            for (int i = 0; i < 1; i++)
            {
                Intelligence = (new Random()).Next(1, 16);
                Console.WriteLine($"{Name} is beginning with a strength score of {Intelligence}");

            }
        }

        public void RollForWisdom()
        {
            for (int i = 0; i < 1; i++)
            {
                Wisdom = (new Random()).Next(1, 16);
                Console.WriteLine($"{Name} is beginning with a strength score of {Wisdom}");

            }
        }

        public void RollForCharisma()
        {
            for (int i = 0; i < 1; i++)
            {
                Charisma = (new Random()).Next(1, 16);
                Console.WriteLine($"{Name} is beginning with a strength score of {Charisma}");

            }
        }

        public void CheckCharacterCompletion()
        {
            if(Strength != 0
                && Dexterity != 0
                && Constitution != 0
                && Intelligence != 0
                && Wisdom != 0
                && Charisma != 0)
            {
                CharacterComplete = true;
                Console.WriteLine($"{PlayerName} has created a character named {Name} . " +
                    $"Strength: {Strength} " +
                    $"Dexterity: {Dexterity} " +
                    $"Constitution: {Constitution} " +
                    $"Intelligence: {Intelligence} " +
                    $"Wisdom: {Wisdom} " +
                    $"Charisma: {Charisma} ");
            }
    }

    }
}
