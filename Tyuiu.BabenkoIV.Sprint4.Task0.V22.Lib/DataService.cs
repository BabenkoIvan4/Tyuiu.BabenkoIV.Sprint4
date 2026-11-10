using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabenkoIV.Sprint4.Task0.V22.Lib
{
    public class DataService : ISprint4Task0V22
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0; // Переменная для накопления суммы

            for (int i = 0; i < array.Length; i++) // Проходим по всем элементам массива
            {
                if (array[i] % 2 != 0) // Проверяем, является ли элемент нечетным (остаток от деления на 2 не равен 0)
                {
                    sum += array[i]; // Если элемент нечетный, добавляем его к общей сумме
                }
            }

            return sum; // Возвращаем итоговый результат
        }
    }
}
