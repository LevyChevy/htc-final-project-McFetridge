using System;

namespace htc_final_project_McFetridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello kids, welcome to this fortune teller thing. I will predict what career you will presue in the future.");
            Console.WriteLine("");
            Question1();    
        }
        public static void Question1(){
            Console.WriteLine("Question 1: Do u consider yourself an, A: introvert, or an B: extrovert?");
            string QuOne = Console.ReadLine();
            if(QuOne == "A")
            {
                Console.WriteLine("");
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
            Console.WriteLine("Question 2: ");
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
            Console.WriteLine("Question 3: ");
            string QuThreeA = Console.ReadLine();

            if(QuThreeA == "A")
            {
                Console.WriteLine("Next Question");
                Question4();
            }
            else if(QuThreeA == "B")
            {
                Console.WriteLine("Next Question");
                Question4();
            }
        }
        public static void Question3B()
        {
            Console.WriteLine("Question 3: ");
            string QuThreeB = Console.ReadLine();

            if(QuThreeB == "A")
            {
                Console.WriteLine("Next Question");
                Question4();
            }
            else if(QuThreeB == "B")
            {
                Console.WriteLine("Next Question");
                Question4();
            }
        }
        public static void Question3C()
        {
            Console.WriteLine("Question 3: Truthfully, do you consider yourself a caring person even to people you don't know? A: Yes B: No  ");
            string QuThreeC = Console.ReadLine();

            if(QuThreeC == "A")
            {
                Console.WriteLine("Next Question");
                Question4();
            }
            else if(QuThreeC == "B")
            {
                Console.WriteLine("Next Question");
                Question4();
            }
        }
        public static void Question3D()
        {
            Console.WriteLine("Question 3: Do you like animals? A: Yes, B: No ");
            string QuThreeD = Console.ReadLine();

            if(QuThreeD == "A")
            {
                Console.WriteLine("Next Question");
                Question4();
            }
            else if(QuThreeD == "B")
            {
                Console.WriteLine("Next Question");
                Question4();
            }

        }
        public static void Question4()
        {

        }
    }
}
