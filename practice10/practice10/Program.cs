using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice10
{
    class Program
    {
        public static int ReadNatural()
        //ввод числа для красивых лаб
        {
            bool check = false;
            int intNum = 0;
            do
            {
                // Попытка перевести строку в число
                check = Int32.TryParse(Console.ReadLine(), out intNum);
                // Если попытка неудачная:
                if (!(check) || (intNum < 0))
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
            } while (!(check) || (intNum < 0));
            // Если попытка удачная:
            return intNum;
        }
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            DoublyLinkedList<int> circleList = new DoublyLinkedList<int>();
            Console.WriteLine("Введите количество элементов которые необходимо добавить в список");
            int n = ReadNatural();
            for (int i = 0; i < n; i++)
            {
                circleList.Add(rnd.Next(-100, 101));
            }
            int sum = 1;
            Console.WriteLine("Текущий список:");
            DoublyNode<int> point = circleList.GetHead();
            DoublyNode<int> tail = circleList.GetTail();
            for (int i = 0; i < circleList.Count; i++)
            {
                Console.Write(point.Data + " ");
                sum = sum*(point.Data + tail.Data);
                point = point.Next;
                tail = tail.Previous;
            }
            Console.WriteLine("Итоговый результат={0}", sum);
        }
    }
}
