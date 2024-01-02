namespace Calculator
{

    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Type a calculation you would like to do");
                Console.WriteLine("Or type > exit < to leave the program");

                string input = Console.ReadLine();
                if (input == "exit")
                {
                    Environment.Exit(0);
                }
                else if (input.Length >= 5)
                {
                    string[] SplittedInput = input.Split(" ");

                    var input1 = int.Parse(SplittedInput[0]);
                    var operator1 = SplittedInput[1];
                    var input2 = int.Parse(SplittedInput[2]);

                    int result = Calculations(input1, operator1, input2);
                    Console.WriteLine(result);
                    Console.WriteLine("Click any key to return");
                    Console.ReadLine();
                }
                else if (input.Length < 5)
                {
                    Console.WriteLine(" error, put spaces between the inputs. \nExample (5 + 5)");
                    Console.WriteLine("Click any key to return");
                    Console.ReadLine();
                }

                Console.Clear();
            }

        }

        public static int Calculations(int Value1, string operator1, int value2)
        {
            if (operator1.Contains("+"))
            {
                int value = Value1 + value2;
                return value;
            }
            else if (operator1.Contains("*"))
            {
                int value = Value1 * value2;
                return value;
            }
            else if (operator1.Contains("-"))
            {
                int value = Value1 - value2;
                return value;
            }
            else if (operator1.Contains("/"))
            {
                int value = Value1 / value2;
                return value;
            }
            int Value = Value1 + value2;

            return Value;

        }
    }
}