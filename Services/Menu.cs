using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2_assignment_template.Services
{
    internal class Menu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Characters");
            Console.WriteLine("2. Add Character");
            Console.WriteLine("3. Level Up Character");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine("--------------");
            Console.WriteLine();

            
            switch (choice)
            {
                case "1":
                    CharacterManager.DisplayCharacter();
                    break;
                case "2":
                    CharacterManager.AddCharacter();
                    break;
                case "3":
                    CharacterManager.LevelUpCharacter();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }            
            

        }
    }   
}
