using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
             //Conditional_Statements cs = new Conditional_Statements();
             //cs.RunExercise();

            // Comparison_Operators co = new Comparison_Operators();
            // co.RunExercise();

            // IO_Operators ioo = new IO_Operators();
            // ioo.RunExercise();
            
            // Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            // ivrd.RunExercise();

            // Clearly, you will need to uncomment these to test them...
            // Modulus_Operator mo = new Modulus_Operator();
            // mo.RunExercise();

            // Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            // ftc.RunExercise();
         }
    }

    class Conditional_Statements
    {
        public void RunExercise()
        {
            

            Console.WriteLine("About to do the \"Conditional Statements\" exercise");
            Conditional_Methods cm = new Conditional_Methods();
            //int userChoice;
            //Int32.TryParse(Console.ReadLine(), out userChoice);
            int userChoice =11;

            cm.UsingIf();
            if(userChoice > 10 || userChoice <0){
                Console.WriteLine("please enter a number between 0 and 10");
            }
            if(userChoice == 0){
                Console.WriteLine("You need to talk to the professor immediately!");
            }
			if (userChoice == 1)
			{
				Console.WriteLine("You need to study a lot more!");
			}
			if (userChoice == 2)
			{
				Console.WriteLine("If you keep working at this, you'll do better!");
			}
			if (userChoice == 3)
			{
				Console.WriteLine("If you keep working at this, you'll do better!");
			}
			if (userChoice == 4)
			{
				Console.WriteLine("If you keep working at this, you'll do better!");
			}
			if (userChoice == 5)
			{
				Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
			}
			if (userChoice == 6)
			{
				Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
			}
			if (userChoice == 7)
			{
				Console.WriteLine("Nice job, but don't let yourself slack!");
			}
			if (userChoice == 8)
			{
				Console.WriteLine("Nice job, but don't let yourself slack!");
			}
			if (userChoice == 9)
			{
				Console.WriteLine("Very nice job – keep up the good work!");
			}
			if (userChoice == 10)
			{
				Console.WriteLine("Perfect!");
			}

            cm.UsingIfElse();
			if (userChoice == 0)
			{
				Console.WriteLine("You need to talk to the professor immediately!");
			}
			else if (userChoice == 1)
			{
				Console.WriteLine("You need to study a lot more!");
			}
			else if (userChoice == 2)
			{
				Console.WriteLine("If you keep working at this, you'll do better!");
			}
			else if (userChoice == 3)
			{
				Console.WriteLine("If you keep working at this, you'll do better!");
			}
			else if (userChoice == 4)
			{
				Console.WriteLine("If you keep working at this, you'll do better!");
			}
			else if (userChoice == 5)
			{
				Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
			}
			else if (userChoice == 6)
			{
				Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
			}
			else if (userChoice == 7)
			{
				Console.WriteLine("Nice job, but don't let yourself slack!");
			}
			else if (userChoice == 8)
			{
				Console.WriteLine("Nice job, but don't let yourself slack!");
			}
			else if (userChoice == 9)
			{
				Console.WriteLine("Very nice job – keep up the good work!");
			}
			else if (userChoice == 10)
			{
				Console.WriteLine("Perfect!");
			}
            else{
                Console.WriteLine("please enter a number between 0 and 10");
            }

            cm.UsingSwitch();
            switch(userChoice){
                case 0:
                    Console.WriteLine("You need to talk to the professor immediately!");
                    break;
				case 1:
					Console.WriteLine("You need to study a lot more!");
					break;
				case 2:
                case 3:
                case 4:
                    Console.WriteLine("If you keep working at this, you'll do better!");
                    break;
                case 5: 
                case 6:
                    Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
                    break;
                case 7: 
                case 8:
                    Console.WriteLine("Nice job, but don't let yourself slack!");
                    break;
                case 9:
                    Console.WriteLine("Very nice job – keep up the good work!");
                    break;
                case 10:
                    Console.WriteLine("Perfect!");
                    break;
                default: 
                    Console.WriteLine("please enter a number between 0 and 10");
                    break;
                    
            }

        }
    }


	class IO_Operators
	{
		public void RunExercise()
		{
			Console.WriteLine("Enter Whole First Number: ");
			string input1 = Console.ReadLine();
			int firstNumber;
			Int32.TryParse(input1, out firstNumber);

			Console.WriteLine("Enter Whole Second Number: ");
			string input2 = Console.ReadLine();
			int secNumber;
			Int32.TryParse(input2, out secNumber);

            if (firstNumber - secNumber <= 5){
                Console.WriteLine(firstNumber + " and" + secNumber + " are within 5 integers of each other.");
            }
            else{
				Console.WriteLine(firstNumber + " and" + secNumber + " are NOT within 5 integers of each other.");
			}
            
            
        }
    }


    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
			int a = 6;
			int b = 3;
			int c = 7;

            Console.WriteLine(c/b); //return 2 because integer division drops the decimal
            Console.WriteLine(c / (double)b);  //return 2.33333 because int is convertied into double returning real division value
            
        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
			Console.WriteLine("Enter Whole First Number: ");
			string input1 = Console.ReadLine();
			int firstNumber;
			Int32.TryParse(input1, out firstNumber);

			Console.WriteLine("Enter Whole Second Number: ");
			string input2 = Console.ReadLine();
			int secNumber;
			Int32.TryParse(input2, out secNumber);

			Console.WriteLine("Integer division result: " + firstNumber / secNumber);
			Console.WriteLine("Modulus operator result: " + firstNumber % secNumber);
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
			Console.WriteLine("Enter the Fahrenheit number you wish to convert: ");
			string input = Console.ReadLine();
			int fahrenheit;
			Int32.TryParse(input, out fahrenheit);

			int z = 5;
			int x = 9;
			int y = fahrenheit - 32;

			Console.WriteLine((z / (double)x) * y + " degrees");
        }
    }

    class Logical_Operators
    {
        // Your answer goes here,in a comment like this one

        //int x = 5;
        //int y = 2;
        //int z = 10;


        // y< 1 || y> 1
        //true 

        //y< 2 || x> 4
        //true

        //z > 8 || y< 3
        //true

        //!(z > 8)
        //false

        //!(z > 8 || y< 3)
        //false

        //!(z > 4 && y == 2) || (z ==10 && y <= 3)
        //true

        //y<z ^ z<x
        //true

        //z<x ^ y<z
        //true

        //10 < 20 ^ 20 < 30
        //false

        //20 == 10 ^ 20 < 10
        //false
		// Side-Note: Notice that this class has NO methods, and that it still compiles :)
	}
}