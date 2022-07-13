// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        int x = 0;
        int y = 0;
        int z = 0;

        /*TestParams(ref x, y, out z);
        Console.WriteLine("x, y, z = {0},{1},{2}", x, y, z);
        Console.ReadLine();
        int[][] jag = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9, 10 } };
        Console.WriteLine(jag[1, 1]);
        */
        CalculateCoins(100);
    }

    public static void TestParams(ref int x, int y, out int z)
    {
        x = 111;
        y = 222;
        z = 333;

    }
    public static void CalculateCoins(int amount)
    {

        int c100 = 0;
        int c20 = 0;
        int c5 = 0;
        int mod = amount % 5;
        if (mod > 0 || amount == 0)
        {
            Console.WriteLine("Invalid Amount {0}", amount);
        }
        else
        {
            int amountbkp = amount;
            /*
            //do
            //{
            //if (amountbkp == 100)
            //{
                c100 = amountbkp/100;
                if (c100>0) amountbkp = 0;
                //break;
            //}
                int mod20 = amountbkp / 20;

            //    if (mod20 > 0)
            //    {
                    c20 = mod20;
                    amountbkp = amountbkp % 20;
            //    }
                int mod5 = amountbkp / 5;
                c5 = mod5;
            //    amountbkp = amountbkp % 5;
            //} while (amountbkp > 0);
            */

            c100 = amountbkp / 100;
            //if (c100 > 0) amountbkp = 0;
            amountbkp = amountbkp % 100;

            c20 = amountbkp / 20;            
            amountbkp = amountbkp % 20;
            
            c5  = amountbkp / 5;      
            
            Console.WriteLine("Coins for Amount {0} : 100 = {1}, 20 = {2}, 5 = {3}", amount, c100, c20, c5);
            Int32 DiviNum = Int32.Parse(Console.ReadLine());
            if (DiviNum > 0)
            {
                CalculateCoins(DiviNum);
            }
        }
    }
}