using System;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EX1
            Console.WriteLine($"EXCERCISE 1\nI am going to output numbers 1000 through -1000, sorry!");
            OneThroughThousand();

            NextExcercise();

            //EX2
            Console.WriteLine($"EXCERCISE 2\nI will now output numbers 3 through 999 but only by 3s!");
            ThreeThroughNineNines();

            NextExcercise();

            //EX3 IS LIKE EX 4 BUT TERNARY OPERATOR
            Console.WriteLine($"EXCERCISE 3\nI am going to ask for 2 numbers and i'll check if they're the same or not!");
            var resultEqualOrNot = (EqualOrNotEqual()) ? "They are the same number!" : "They are not the same number"; 
            Console.WriteLine(resultEqualOrNot);

            NextExcercise();

            //EX4 WILL CHANGE METHOD FROM VOID TO BOOLEAN TO TEST
            //I could also create a bool and turn this to a ternary. This is only for note purposes
            Console.WriteLine("EXCERCISE 4\nPHEW! What a workout... Give me a number and i'll tell you if its even or odd!");
            if (EvenOrOdd())
            {
                Console.WriteLine("That is an even number!");
            }
            else
            {
                Console.WriteLine("That is an odd number!");
            }

            NextExcercise();

            //EX5
            Console.WriteLine("EXCERCISE 5\nGive me a number and I will tell you if it positive or negative.");
            PosOrNeg();

            NextExcercise();

            //EX6
            Console.WriteLine("EXCERCISE 6\nWhat's your age?");
            CanYouVote();

            NextExcercise();

            //EX 7
            Console.WriteLine("EXCERCISE 7\nNow it's heating up! give me a number and i'll check if its between -10 to 10");
            NegTenToTen();

            NextExcercise();

            //EX 8
            Console.WriteLine("EXCERCISE 8\nFinally, give a number and i'll show you the multiplication table from 1 to 12");
            MultTable();
        }
        public static void NextExcercise()
        {
            Console.WriteLine("Enter any key to go to next excercise...");
            Console.ReadLine();
            Console.Clear();
        }//Extra Method simply to clear console and continue

        public static void OneThroughThousand() //I could do a simple loop where it will output i everytime, but for excercise sake I will put every number into a string array and output that string array back
        {
            //initialize the int num to 1000
            int controlNumberOTT = 1000;
            var readNumberListOTT = new List<int>();

            //do-while loop to add numbers into array. foreach to output all numbers within the array
            do
            {
                readNumberListOTT.Add(controlNumberOTT);
                controlNumberOTT--;
            }
            while (controlNumberOTT >= -1000);

            foreach (int oneThroughThousandRes in readNumberListOTT)
            {
                Console.WriteLine(oneThroughThousandRes);
            }
        }

        public static void ThreeThroughNineNines() //Wont be using array for excercise
        {
            var simpleNineNinesTTT = 333; //picked 333 because it is the divedend of the max output from excercise 999
            for (var i = 1; i <= simpleNineNinesTTT; i++)
            {
                Console.WriteLine(i * 3);
            }
        }

        public static bool EqualOrNotEqual()
        {
            Console.WriteLine("Alright! give me a number");
            var firstInp = int.Parse(Console.ReadLine());

            Console.WriteLine($"You gave me {firstInp}. Now give me a second number");
            var secondInp = int.Parse(Console.ReadLine());
            bool areTheyEqual = (firstInp == secondInp) ? true : false;
            return areTheyEqual;
        }//Simple if else statement to say if they are the same or not

        public static bool EvenOrOdd()
        {
            int evenOrOddNum = int.Parse(Console.ReadLine());
            bool evenOrOddRes = (evenOrOddNum == 0) ? false : true;
            return evenOrOddRes;
        }//Ternary Operator as a return method

        public static void PosOrNeg()
        {
            int posOrNegNum = int.Parse(Console.ReadLine());
            if (posOrNegNum < 0)
            {
                Console.WriteLine("You gave me a negative number!");
            }
            else if (posOrNegNum == 0)
            {
                Console.WriteLine("You gave me zero. Which is a poisitve number!");
            }
            else
            {
                Console.WriteLine("You gave me a positive number!");
            }
        }//It's the same as EvenOrOdd but instead made the method void and let the console output within the method

        public static void CanYouVote()
        {
            int votingAge = int.Parse(Console.ReadLine());
            var ageToVote = 18;
            int ageLeft = 0;
            ageLeft = ageToVote - votingAge;
            if (votingAge < ageToVote)
            {
                if (votingAge == 0)
                {
                    Console.WriteLine("You're not even alive!");
                }
                Console.WriteLine($"Sorry bud, come back in {ageLeft} years!");
            }
            else
            {
                Console.WriteLine("Go grab a ballot!");
            }
        }//Another if else statement but will output how many years they can come back to vote

        public static void NegTenToTen()
        {
            var negTentoTen = int.Parse(Console.ReadLine());
            if (negTentoTen <= 10 && negTentoTen >= -10)
            {
                Console.WriteLine("It is in range!");
                if (negTentoTen <= 10 && negTentoTen >= 0)
                {
                    Console.WriteLine("This is a positive number");
                }
                else if (negTentoTen >= -10 && negTentoTen < 0)
                {
                    Console.WriteLine("This is a negative number");
                }

            }
            else
            {
                Console.WriteLine("It is not in range!");
            }
        }//If else nested in if else

        public static void MultTable()//Will use array as example so have to add System.Collections.Generic
        {
            var userWantsMult = int.Parse(Console.ReadLine());
            var oneThroughTwelve = new List<int>();
            int controlNum = 0;

            do
            {
                controlNum++;
                oneThroughTwelve.Add(controlNum);
            }
            while (controlNum < userWantsMult);

            foreach (int eachNumInArray in oneThroughTwelve)
            {
                var multResult = eachNumInArray * 12;
                Console.WriteLine($"{eachNumInArray} x 12 = {multResult}");
            }
        }
    }
}
