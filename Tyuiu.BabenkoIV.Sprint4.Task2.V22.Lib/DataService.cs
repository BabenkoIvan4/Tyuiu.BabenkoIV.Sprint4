using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabenkoIV.Sprint4.Task2.V22.Lib
{
    public class DataService : ISprint4Task2V22
    {
        public int Calculate(int[] array)
        {
            int product = 1; // Важно: инициализируем единицей, а не нулем!

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) // Проверяем, что элемент нечетный
                {
                    product *= array[i]; // Умножаем нечетные элементы
                }
            }

            return product;
        }
    }
}
