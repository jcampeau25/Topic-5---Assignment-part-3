namespace Topic_5___Assignment_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guess;
            int score = 0;

            Console.WriteLine("Welcome to Josh's Quiz!");

            // Question 1
            Console.WriteLine("Question 1: How tall was the shortest person to ever play in the NBA?");
            Console.WriteLine("A. 4'11  B. 5'3  C. 5'5  D. 5'8");
            guess = Console.ReadLine();
            if (guess.ToLower() == "b" || guess == "5'3" || guess == "5' 3")
            {
                score += 1;
                Console.WriteLine("Correct! The shortest NBA player ever was Muggsy Bogues who was 5'3.");

            }

            else if (guess.ToLower() == "a" || guess == "4'11" || guess == "4' 11")
                Console.WriteLine("Incorrect! It would take an insane amount of skill to make the NBA at 4'11. The correct answer was B. 5'3");
            else
                Console.WriteLine("That is incorrect. The correct answer was B. 5'3");

            // Question 2
            Console.WriteLine("Question 2: Which of the following countries is NOT located in Africa?");
            Console.WriteLine("A. Ethiopia  B. Lesotho  C. Sierra Leon D. Estonia");
            guess = Console.ReadLine();



        }
    }
}
