namespace Operation
{
    public static class CalcFactoryy
    {
        public static DT Factory(string key, string cal)
        {
            DT dt = null;
            switch (cal.ToLower())
            {
                case "decisiontree":
                    dt = new DT();
                    break;
                default:
                    throw new ArgumentException("Unknown calculator type");
            }
            return dt;
        }
    }
}
