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

            var header = lines[0];

            for (int i = 0; i < lines.Length; i++) {

                string name = "";
                string job = "";
                string level = "";
                string hitPoints = "";
                string equipment = "";

                // does the line start with a " ?
                var firstQuoteLocation = lines[i].IndexOf('"');

                // if " is not found
                if (firstQuoteLocation < 0)
                {
                    var cols = lines[i].Split(",");

                    name = cols[0];
                    job = cols[1];
                    level = cols[2];
                    hitPoints = cols[3];
                    equipment = cols[4];
                    //var items = equipment.split("|")

                }
                else
                {
                    lines[i] = lines[i].TrimStart('"');
                    var parts = lines[i].Split('"');
                    var firstPart = parts[0];
                    var secondPart = parts[1];

                    var cols = secondPart.Split(",");
                    name = firstPart;
                    job = cols[0];
                    level = cols[1];
                    hitPoints = cols[2];
                    equipment = cols[3];
                }

                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Job: {job}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"hitPoints: {hitPoints}");
                Console.WriteLine($"Equipment: {equipment}");
            }
    }
}
