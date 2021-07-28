using LegoMinifigures.Characters;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in player's name. Then, type in your character name and press enter.");
            var Character = new LegoPerson(Console.ReadLine(), Console.ReadLine());
            Character.RollForStrength();
            Character.RollForDexterity();
            Character.RollForConstitution();
            Character.RollForIntelligence();
            Character.RollForWisdom();
            Character.RollForCharisma();
            Character.CheckCharacterCompletion();

        }
    }
}
