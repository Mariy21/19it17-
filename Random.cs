using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random chislo = new Random(); 
            int[] mas = new int[1000];
            for (int i = 0; i < 1000; i++) 
            {
                mas[i] = chislo.Next(0, 10000);
                Console.WriteLine(mas[i]);
            }
            int R = mas[0];
            Console.WriteLine("Минимальное число: ");
            for (int i = 0; i < mas.Length; i++) //Минимальное значение массива
            {
                if (mas[i] < R) { R = mas[i]; }

            }
            Console.WriteLine(R);

            /* Проверка условия*/
            if ((R % 21 == 0) && (R == ((mas[new Random().Next(0, mas.Length)]) * (mas[new Random().Next(0, mas.Length)]))))
            {
                Console.WriteLine(R);
            }

            else { Console.WriteLine("-1"); } //Если условие не подходит, то выводится -1
            Console.Read();
        }
    }
}
        
    

