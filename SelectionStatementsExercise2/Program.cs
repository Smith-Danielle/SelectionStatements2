using System;

namespace SelectionStatementsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Job Type Generator */
            Console.WriteLine("Lets determine what jobs you might be interested in based off of the subjects you enjoy.");
            Console.WriteLine("Please enter your favorite subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("You may enjoy postions as a : Accountant, Investor, Financial Advisor ");
                    break;
                case "english":
                    Console.WriteLine("You may enjoy postions as a : Journalist, Teacher, Author ");
                    break;
                case "art":
                    Console.WriteLine("You may enjoy postions as a : Illustrator, Photographer, Fashion Designer ");
                    break;
                case "science":
                    Console.WriteLine("You may enjoy postions as a : Biologist, Chemist, Engineer ");
                    break;
                case "history":
                    Console.WriteLine("You may enjoy postions as a : Librarian, Lawyer, Historian ");
                    break;
               default:
                    Console.WriteLine("Only responses avaiable are for math, english. art, science, history. Please select a new subject.");
                    break;
                       
            }
        }
    }
}
