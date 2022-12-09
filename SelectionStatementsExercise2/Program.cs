namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math can be tough.");
                    break;
                case "English":
                    Console.WriteLine("English is a great subject!");
                    break;
                case "History":
                    Console.WriteLine("History is interesting.");
                    break;
                case "Science":
                    Console.WriteLine("Science can be fun.");
                    break;
                case "Spanish":
                    Console.WriteLine("Spanish is muy bueno!");
                    break;
                default:
                    Console.WriteLine($"That's interesting. I'm not familiar with that subject. {subject} seems like fun.");
                    break;
                    
                 
            }

        }
    }
}