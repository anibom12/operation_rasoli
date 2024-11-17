namespace Operation
{
    public class Palindorome1 : Calculator
    {
        public override bool IsTrue(uint number)
        {
            Console.WriteLine("Palindrome");

            uint tmp_number = number;
            uint reverse = 0;
            while (tmp_number != 0)
            {
                reverse = (reverse * 10) + tmp_number % 10;
                tmp_number /= 10;
            }
            return reverse == number;
        }
    }
}
