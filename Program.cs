using System;

namespace htc_final_project_McFetridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello kids, welcome to this fortune teller, buzzfeed thing. I will attempt to predict what career you will presue in the future.");
            Console.WriteLine("");
            Console.WriteLine("Pick Three of these traits that discribe yourself");
            Console.WriteLine("Creative, Organized, Compassionate, Optimist, Confident, Exuberant, Persistent, Witty, Adventurous, Courteous");
            for(int j = 0; j < 3; j++ ){
                if(j == 0)
                {
                    Console.WriteLine("1.");
                    string perOne = Console.ReadLine(); 
                }
                else if(j == 1)
                {
                    Console.WriteLine("2.");
                    string perTwo = Console.ReadLine();
                }
                else if(j == 2)
                {
                    Console.WriteLine("3.");
                    string perThree = Console.ReadLine();
                }
            }
            Question1();
        }
        public static void Question1(){
            Console.WriteLine("Question 1: Do u consider yourself an, A: introvert, or an B: extrovert?");
            string QuOne = Console.ReadLine();
            if(QuOne == "A")
            {
                Console.WriteLine("Next Question");
                Question2A();
            }
            else if(QuOne == "B")  
            {
                Console.WriteLine("Next Question");
                Question2B();
            }
        }
        public static void Question2A()
        {
            Console.WriteLine("Question 2: Do you Spend the majority of your time by technology? A: Yes B: No");
            string QuTwoA = Console.ReadLine();

            if(QuTwoA == "A")
            {
                 Console.WriteLine("Next Question");
                Question3A();
            }
            else if(QuTwoA == "B")
            {
                Console.WriteLine("Next Question");
                Question3B();
            }
        }
        public static void Question2B()
        {
            Console.WriteLine("Question 2: Do you like the outdoors? A: Yes, B: No ");
            string QuTwoB = Console.ReadLine();

            if(QuTwoB == "A")
            {
                Console.WriteLine("Next Question");
                Question3D();
            }
            else if(QuTwoB == "B")
            {
                Console.WriteLine("Next Question");
                Question3C();
            }
        }
        public static void Question3A()
        {
            Console.WriteLine("Question 3: Are you more of a thinker or a doer? A: Thinker B: Doer");
            string QuThreeA = Console.ReadLine();

            if(QuThreeA == "A")
            {
                Console.WriteLine("You will be a Software Enngineer!");
                
            }
            else if(QuThreeA == "B")
            {
                Console.WriteLine("You will be an Editor!");
                
            }
        }
        public static void Question3B()
        {
            Console.WriteLine("Question 3: Do you prefer a more contolled environment? A: Yes B: No ");
            string QuThreeB = Console.ReadLine();

            if(QuThreeB == "A")
            {
                Console.WriteLine("You wil be a Research Scientist!");
               
            }
            else if(QuThreeB == "B")
            {
                Console.WriteLine("You will be a Mechanic!");
                
            }
        }
        public static void Question3C()
        {
            Console.WriteLine("Question 3: Truthfully, do you consider yourself a caring person even to people you don't know? A: Yes B: No  ");
            string QuThreeC = Console.ReadLine();

            if(QuThreeC == "A")
            {
                Console.WriteLine("You will be a Phychiatrist!");
                
            }
            else if(QuThreeC == "B")
            {
                Console.WriteLine("You will be a Loyer!");
                
            }
        }
        public static void Question3D()
        {
            Console.WriteLine("Question 3: Do you like animals? A: Yes, B: No ");
            string QuThreeD = Console.ReadLine();

            if(QuThreeD == "A")
            {
                Console.WriteLine("You will be a Landscape Architect!");
               
            }
            else if(QuThreeD == "B")
            {
                Console.WriteLine("You will be a Zoologist!");
               
            }
        }
    }
}
