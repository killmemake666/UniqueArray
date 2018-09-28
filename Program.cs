using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "гусь", "гусь", "корова", "корова", "8", "34" };

            string[] NewArray = UniqueArray(array);
            //UniqueArray(arr);//возвращаем 8 и 34

            for (int i = 0; i < NewArray.Length; i++)
            {
                Console.WriteLine(NewArray[i]);
            }
         
            Console.ReadKey();
        }

        static string[] UniqueArray(string[] array)
        {

            //[] NewArray = array.Distinct().ToArray();
            //Array newArray = Array.CreateInstance(typeof(string),array.Length); объявляем массив, на всякий случай
            //List<string> ListString = new List<string>(array.Length); коллекция, тоже на всякий случай
            //чтобы не забыть, как объявляется

            string[] EndArray = new string[array.Length];         

            bool UniqueElement;//переменная флаг

            for (int i = 0; i < array.Length; i++)
            {
                UniqueElement = true;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        UniqueElement = false;
                        break;
                    }
                }
                if (UniqueElement == true)
                {
                    EndArray[i] = array[i];
                }
            }

            string[] NewArray = NotNullArray(EndArray);//возвращает массив с действительными элементами

            return NewArray;
        }

        static string[] NotNullArray(string[] NullArray)//возвращает массив с действительными элементами
        {

            int NotNullElements = 0;//счетчик непустых элементов

            for(int i = 0; i < NullArray.Length; i++)
            {
                if(NullArray[i] != null)
                {
                    NotNullElements++;
                }
            }

            string[] NewArray = new string[NotNullElements];//создаем массив на оставшиеся непустые эелементы

            int RealElement = 0;

            for (int i = 0; i < NullArray.Length; i++)
            {
                if(NullArray[i] == null)
                {
                    continue;
                }
                else if(NullArray[i] != null)
                {
                    NewArray[RealElement] = NullArray[i];
                    RealElement++;
                }
            }

            return NewArray;
        }
    }
}
САНЯ КОТ НЕ РОБОТАИТ!!1!!!

