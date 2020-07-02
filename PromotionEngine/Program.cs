using System;
using System.Linq;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promotion Engine!");
            Console.WriteLine("\n");
            string SKU = "ABBCDDAAAAB";
            int price = Program.GetSKUsPrice(SKU);
            Console.WriteLine("price is : " + price);
        }

        public static int GetSKUsPrice(string sku)
        {
            int sum = 0, len = 0, rem = 0;
            int PriceOfA = 50;
            int PriceForThreeA = 130;
            int PriceForA = 50;
            int PriceForTwoB = 45;
            int PriceOfB = 30;
            int PriceForCnD = 30;
            int PriceforC = 20;
            int PriceForD = 15;

            if (sku.Length > 0)
            {
                int A = sku.ToLower().ToCharArray().Count(c => c.Equals('a'));
                if (A > 2)
                {
                    len = A / 3;
                    rem = A % 3;
                    if (rem != 0)
                    {
                        sum = sum + (len * PriceForThreeA) + (rem * PriceOfA);
                    }
                    else
                    {
                        sum = sum + len * PriceForThreeA;
                    }
                }
                else
                {
                    sum = sum + A * PriceForA;
                }

                int b = sku.ToLower().ToCharArray().Count(c => c.Equals('b'));
                if (b > 1)
                {
                    len = b / 2;
                    rem = b % 2;
                    if (rem != 0)
                    {
                        sum = sum + (len * PriceForTwoB) + (rem * PriceOfB);
                    }
                    else
                    {
                        sum = sum + (len * PriceForTwoB);
                    }
                }
                else
                {
                    sum = sum + b * PriceOfB;
                }

                int c = sku.ToLower().ToCharArray().Count(c => c.Equals('c'));
                int d = sku.ToLower().ToCharArray().Count(c => c.Equals('d'));
                if (c != 0 && d != 0)
                    if (c == d)
                    {
                        sum = sum + PriceForCnD;
                    }
                    else
                    {
                        sum = sum + (c * PriceforC);
                        sum = sum + (d * PriceForD);
                    }
            }

            return sum;
        }
    }

}
