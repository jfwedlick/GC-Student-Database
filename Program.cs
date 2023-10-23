using System.Reflection.Metadata.Ecma335;

namespace Student_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectAStudent();
        }

        static void SelectAStudent()
        {
            string[] students = { "Victor", "Ian", "Jake", "Christopher", "Tyler", "Rob", "Danny", "Scott", "Steve" };
            while (true)
            {
                Console.Write("Enter a number 1-9 to select a student. Enter 0 to display a list of students: ");
                string studentRequest = Console.ReadLine();
                int.TryParse(studentRequest, out int studentNumber);
                int studentSelected = studentNumber - 1;
                if (studentNumber == 0)
                {
                    int i = 1;
                    foreach (string student in students)
                    {
                        Console.WriteLine($"{i}. {student}");
                        i++;
                    }
                    PressAnyKeyToContinue();
                    RunAgain();
                    break;
                }
                if (studentNumber >= 1 && studentNumber <= 9)
                {
                    Console.WriteLine($"The student you selected is {students[studentSelected]}.");
                    FindWhat(students, studentSelected);
                    RunAgain();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            }
        }
        static void FindWhat(string[] students, int studentSelected)
        {
            while (true)
            {
                Console.Write($"What would you like to know about {students[studentSelected]}? Enter [HOMETOWN] or [FAVORITE FOOD]: ");
                string nextSelection = Console.ReadLine().Trim().ToUpper();
                if (nextSelection == "HOMETOWN" || nextSelection == "HOME" || nextSelection == "TOWN" || nextSelection == "H" )
                {
                    FindHometown(studentSelected);
                    break;
                }
                else if (nextSelection == "FAVORITE FOOD" || nextSelection == "FAVORITE" || nextSelection == "FOOD" || nextSelection == "F")
                {
                    FindFavoriteFood(studentSelected);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
                }
            }
        }
        static void FindHometown(int studentSelected)
        {
            string[] hometowns = { "Detroit", "Boston", "Toronto", "New York City", "Philadelphia", "Los Angeles", "Pittsburgh", "Chicago", "Atlanta" };
            Console.WriteLine($"This student's hometown is {hometowns[studentSelected]}.");
            PressAnyKeyToContinue();
        }
        static void FindFavoriteFood(int studentSelected)
        {
            string[] favoriteFoods = { "Burgers", "Tacos", "Pizza", "Chili", "Vegan", "Chinese", "Thai", "Indian", "Mexican" };
            Console.WriteLine($"This student's favorite food is {favoriteFoods[studentSelected]}.");
            PressAnyKeyToContinue();
        }
        static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        static void RunAgain() 
        {
            Console.Write("Would you like to learn about another student? Y/N ");
            while (true)
            {
                string userInput = Console.ReadLine().ToUpper();
                if (userInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    SelectAStudent();
                    break;
                }
                else if (userInput.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
            }

        }
    }
}