using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BabenkoIV.Sprint4.Task6.V27.Lib
{
    public class DataService : ISprint4Task6V27
    {
        public int Calculate(string[] array)
        {
            // Используем статический метод Array.FindAll, 
            // чтобы найти все элементы, длина которых меньше 7
            string[] foundElements = Array.FindAll(array, element => element.Length < 7);

            // Возвращаем количество найденных элементов
            return foundElements.Length;
        }
    }
}
