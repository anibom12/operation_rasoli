using System;

namespace Operation
{
    public class DT
    {
        public void Decision()
        {
            string qa = "";
            bool isContinue = true;

            do
            {
                switch (qa)
                {
                    case "":
                        Console.WriteLine("Do you like coffee? (y/n)");
                        qa = GetYesOrNo();
                        break;
                    case "y":
                        Console.WriteLine("Do you prefer it black? (y/n)");
                        qa += "_" + GetYesOrNo();
                        break;
                    case "n":
                        Console.WriteLine("Do you like tea? (y/n)");
                        qa += "_" + GetYesOrNo();
                        break;
                    case "n_y":
                        Console.WriteLine("Do you prefer green tea? (y/n)");
                        qa += "_" + GetYesOrNo();
                        break;
                    case "y_y":
                        Console.WriteLine("You like black coffee.");
                        isContinue = false;
                        break;
                    case "y_n":
                        Console.WriteLine("You like coffee with additives.");
                        isContinue = false;
                        break;
                    case "n_y_y":
                        Console.WriteLine("You like green tea.");
                        isContinue = false;
                        break;
                    case "n_y_n":
                        Console.WriteLine("You like other types of tea.");
                        isContinue = false;
                        break;
                    case "n_n":
                        Console.WriteLine("You don't like coffee or tea.");
                        isContinue = false;
                        break;
                    default:
                        isContinue = false;
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (isContinue);

            Console.WriteLine("The End");
        }

        private static string GetYesOrNo()
        {
            char key;
            do
            {
                key = Console.ReadKey(true).KeyChar;
                key = char.ToLower(key);
            } while (key != 'y' && key != 'n');

            Console.WriteLine(key);
            return key.ToString();
        }
    }
}
