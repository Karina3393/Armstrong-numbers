namespace Armstrong_numbers
{
    internal class Program
    {
        public static bool IsArmstrongNumber(int number)
        {
            
            string numberStr = number.ToString();
            int numberOfDigits = numberStr.Length;

            int sum = 0;

           
            foreach (char digitChar in numberStr)
            {
               
                int digit = (int)char.GetNumericValue(digitChar);

               
                sum += (int)Math.Pow(digit, numberOfDigits);
            }

            
            return sum == number;
        }

        static void Main()
        {
            
            int[] numbersToCheck = { 9, 10, 153, 154 };

            foreach (int number in numbersToCheck)
            {
                bool result = IsArmstrongNumber(number);
                Console.WriteLine($"{number} є числом Армстронга: {result}");
            }
        }
    }
}