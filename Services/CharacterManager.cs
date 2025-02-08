using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_assignment_template.Services
{
    internal class CharacterManager
    {
        public static void DisplayCharacter()
        {
            var lines = File.ReadAllLines("Files/input.csv");

            // Skip the header row
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string name;
                int commaIndex;

                // Check if the name is quoted
                if (line.StartsWith("\""))
                {
                    // TODO: Find the closing quote and the comma right after it
                    commaIndex = line.IndexOf("\",");
                    // TODO: Remove quotes from the name if present and parse the name
                    // name = ...
                    name = line.Substring(1, commaIndex - 1);
                    name = name.Trim('"');
                    lines[i] = line.Substring(commaIndex + 2);
                }
                else
                {
                    // TODO: Name is not quoted, so store the name up to the first comma
                    // name =
                    name = line.Substring(0, line.IndexOf(","));
                    commaIndex = line.IndexOf(",");
                    lines[i] = line.Substring(commaIndex + 1);

                }

                // TODO: Parse characterClass, level, hitPoints, and equipment
                // string characterClass = ...
                // int level = ...
                // int hitPoints = ...

                var cols = lines[i].Split(",");

                var profession = cols[0];
                var level = cols[1];
                var hitPoints = cols[2];
                var equipment = cols[3];

                // TODO: Parse equipment noting that it contains multiple items separated by '|'
                // string[] equipment = ...
                var items = equipment.Split("|");
                var firstItem = items[0];
                var secondItem = items[1];
                var thirdItem = items[2];

                // Display character information
                // Console.WriteLine($"Name: {name}, Class: {characterClass}, Level: {level}, HP: {hitPoints}, Equipment: {string.Join(", ", equipment)}");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Job: {profession}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"Hit Points: {hitPoints}");
                Console.WriteLine($"Equipment: {firstItem}, {secondItem}, {thirdItem}\n");


            }

            
        }

        public static void AddCharacter()
        {
            var lines = File.ReadAllLines("Files/input.csv");

            Console.WriteLine("Enter the name of the character: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the job of the character: ");
            var job = Console.ReadLine();
            Console.WriteLine("Enter the level of the character: ");
            var level = Console.ReadLine();
            Console.WriteLine("Enter the hitPoints of the character: ");
            var hitPoints = Console.ReadLine();
            Console.WriteLine("\nEnter First Equipment Item: ");
            var firstItem = Console.ReadLine();
            Console.WriteLine("\nEnter Second Equipment Item: ");
            var secondItem = Console.ReadLine();
            Console.WriteLine("\nEnter Third Equipment Item: ");
            var thirdItem = Console.ReadLine();
            var newCharacter = $"{name},{job},{level},{hitPoints},{firstItem}|{secondItem}|{thirdItem}";
            var newLines = new string[lines.Length + 1];

            for (int i = 0; i < lines.Length; i++)
            {
                newLines[i] = lines[i];
            }
            newLines[lines.Length] = newCharacter;
            lines = newLines;
            using (StreamWriter writer = new StreamWriter("input.csv", true))
            {
                writer.WriteLine($"{name},{job},{level},{hitPoints},{firstItem}|{secondItem}|{thirdItem}");
            }
        }

        public static void LevelUpCharacter()
        {
            var lines = File.ReadAllLines("Files/input.csv");

            Console.Write("Enter the name of the character to level up: ");
            string nameToLevelUp = Console.ReadLine();

            // Loop through characters to find the one to level up
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                // TODO: Check if the name matches the one to level up
                // Do not worry about case sensitivity at this point
                if (line.Contains(nameToLevelUp))
                {

                    // TODO: Split the rest of the fields locating the level field
                    // string[] fields = ...
                    // int level = ...
                    string name;
                    int commaIndex;

                    // Check if the name is quoted
                    if (line.StartsWith("\""))
                    {
                        // TODO: Find the closing quote and the comma right after it
                        commaIndex = line.IndexOf("\",");
                        // TODO: Remove quotes from the name if present and parse the name
                        // name = ...
                        name = line.Substring(1, commaIndex - 1);
                        name = name.Trim('"');
                        lines[i] = line.Substring(commaIndex + 2);
                    }
                    else
                    {
                        // TODO: Name is not quoted, so store the name up to the first comma
                        // name =
                        name = line.Substring(0, line.IndexOf(","));
                        commaIndex = line.IndexOf(",");
                        lines[i] = line.Substring(commaIndex + 1);

                    }

                    // TODO: Parse characterClass, level, hitPoints, and equipment
                    // string characterClass = ...
                    // int level = ...
                    // int hitPoints = ...

                    var cols = lines[i].Split(",");

                    var profession = cols[0];
                    var level = cols[1];
                    var hitPoints = cols[2];
                    var equipment = cols[3];

                    // TODO: Level up the character
                    // level++;
                    int newLevel = Int32.Parse(level) + 1;
                    Console.WriteLine($"Character {name} leveled up to level {newLevel}!");

                    // TODO: Update the line with the new level
                    // lines[i] = ...

                    break;
                }
            }
        }
    }
}
