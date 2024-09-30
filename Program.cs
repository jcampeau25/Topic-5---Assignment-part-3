namespace Topic_5___Assignment_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guess;
            int score = 0;
            Double finalScore;
            Console.WriteLine("Welcome to Josh's Quiz!");

            // Question 1
            Console.WriteLine("Question 1 - Sports: How tall was the shortest person to ever play in the NBA?");
            Console.WriteLine("A. 4'11  B. 5'3  C. 5'5  D. 5'8");
            guess = Console.ReadLine();
            if (guess.ToLower() == "b" || guess == "5'3" || guess == "5' 3" || guess == "5 3")
            {
                score += 1;
                Console.WriteLine("Correct! The shortest NBA player ever was Muggsy Bogues who was 5'3.");

            }

            else if (guess.ToLower() == "a" || guess == "4'11" || guess == "4' 11" || guess == "4 11")
                Console.WriteLine("Incorrect! It would take an insane amount of skill to make the NBA at 4'11. The correct answer was B. 5'3");
            else
                Console.WriteLine("That is incorrect. The correct answer was B. 5'3");

            // Question 2
            Console.WriteLine();
            Console.WriteLine("Question 2 - Geography: Which of the following countries is NOT located in Africa?");
            Console.WriteLine("A. Ethiopia  B. Lesotho  C. Sierra Leon D. Estonia");
            guess = Console.ReadLine();

            if (guess.ToLower() == "d" || guess.ToLower() == "estonia")
            {
                score += 1;
                Console.WriteLine("Correct! Estonia is located in Europe, not Africa");
            }

            else
                Console.WriteLine("Incorrect! The correct answers is D. Estonia");

            // Question 3
            Console.WriteLine();
            Console.WriteLine("Question 3 - History: Who was the first prime minister of Canada?");
            Console.WriteLine("A. John A MacDonald  B. Wilfred Laurier  C. George Washington  D. Terry Fox");
            guess = Console.ReadLine();
            if (guess.ToLower() == "a" || guess.ToLower() == "john a macdonald" || guess.ToLower() == "john" || guess.ToLower() == "macdonald")
            {
                score += 1;
                Console.WriteLine("Correct! John A MacDonald was the first Canadian Prime minister");
            }
            else if (guess.ToLower() == "c" || guess.ToLower() == "George Washington" || guess.ToLower() == "george" || guess.ToLower() == "Washington")
                Console.WriteLine("That is incorrect. George Washington was the first president of the United States");
            else if (guess.ToLower() == "d" || guess.ToLower() == "terry fox" || guess.ToLower() == "terry" || guess.ToLower() == "fox")
                Console.WriteLine("That is incorrect. Terry Fox was a cancer pantient who ran across the country to raise money for cancer research.");
            else Console.WriteLine("Incorrect! The first prime minister of Canada was A. John A Macdonald");

            // Question 4
            Console.WriteLine();
            Console.WriteLine("Question 4 - Science: What is the first element on the periodic table?");
            Console.WriteLine("A. Oxygen  B. Helium  C. Carbon  D. Hydrogen");
            guess = Console.ReadLine();
            if (guess.ToLower() == "d" || guess.ToLower() == "hydrogen")
            {
                score += 1;
                Console.WriteLine("Correct! The first element on the periodic table is hydrogen!");
            }
            else if (guess.ToLower() == "a" || guess.ToLower() == "oxygen")
                Console.WriteLine("That is incorrect, oxygen is eighth on the periodic table. The correct answer is D. Hydrogen");
            else if (guess.ToLower() == "b" || guess.ToLower() == "helium")
                Console.WriteLine("That is incorrect, helium is second on the periodic table. The correct answer is D. Hydrogen");
            else if (guess.ToLower() == "c" || guess.ToLower() == "carbon")
                Console.WriteLine("That is incorrect, carbon is sixth on the periodic table. The correct answer is D. Hydrogen");

            else
                Console.WriteLine("That is incorrect. The correct answer is D. Hydrogen");

            //Score
            finalScore = (score * 100) / 4;
            Console.WriteLine();
            Console.WriteLine("Your final score was " + score + "/4 or " + finalScore + "%");
            if (score == 0)
                Console.WriteLine("You didn't get any right! Better luck next time.");
            else if (score == 4)
                Console.WriteLine("Wow you got perfect! Good job");
        }
    }
}

    
