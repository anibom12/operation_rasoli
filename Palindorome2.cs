namespace Operation
{
    public class Palindorome2 : Calculator
    {
        public override bool IsTrue(uint number)
        {
            string num = number.ToString();
            bool Check = true;
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    Check = false;
                    break;
                }
            }
            return Check;
        }
    }
}
