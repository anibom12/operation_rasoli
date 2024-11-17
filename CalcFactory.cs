namespace Operation
{
    public static class CalcFactory
    {
        public static Calculator Factory(uint number, string cal)
        {
            Calculator calc = null;
            switch (cal)
            {
                case "prime":
                    if (number <= 1000)
                    {
                        calc = new SimplePrime();
                    }
                    else
                    {
                        calc = new ProPrime();
                    }
                    break;
                case "palindorome 1":
                    calc = new Palindorome1();
                    break;
                case "palindorome2":
                    calc = new Palindorome2();
                    break;
                default:
                    throw new ArgumentException("Unknown calculator type");
            }
            return calc;
        }
    }
}
