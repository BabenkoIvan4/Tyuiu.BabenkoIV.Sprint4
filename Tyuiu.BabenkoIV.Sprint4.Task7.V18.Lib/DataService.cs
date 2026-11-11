using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabenkoIV.Sprint4.Task7.V18.Lib
{
    public class DataService : ISprint4Task7V18
    {
        public int Calculate(int n, int m, string value)
        {
            int product = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    int index = i * m + j;

                    
                    if (index < value.Length)
                    {
                        
                        int digit = value[index] - '0';

                        if (digit % 2 == 0)
                        {
                            product *= digit;
                        }
                    }
                }
            }

            return product;
        }
    }
}
