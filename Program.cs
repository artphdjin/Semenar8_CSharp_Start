using System;

namespace Semenar8_CSharp_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Задача 54: Задайте двумерный массив. Напишите программу, которая
            упорядочит по убыванию элементы каждой строки двумерного массива.
            *
            Задача 56: Задайте прямоугольный двумерный массив. Напишите
            программу, которая будет находить строку с наименьшей суммой элементов.
            *
            Задача 58: Задайте две матрицы. Напишите программу, которая будет
            находить произведение двух матриц.
            *
            Задача 60: Сформируйте трёхмерный массив из неповторяющихся
            двузначных чисел. Напишите программу, которая будет построчно выводить
            массив, добавляя индексы каждого элемента.
            *
            Задача 62: Заполните спирально массив 4 на 4.
            */
            /*

            // Задача 54: 

            Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

            Console.WriteLine("Введите длину массива:");

            bool numberCheck = int.TryParse(Console.ReadLine(), out int task54_w);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task54_w);
            }

            // считано число элементов по длине массива

            Console.WriteLine("Введите высоту массива:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task54_h);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task54_h);
            }

            // считано число элементов по высоте массива


            int[,] arr54 = new int[task54_h, task54_w];
            Random rnd = new Random();
            int swap = 0;

            for (int i = 0; i < task54_h; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < task54_w; j++)
                {
                    arr54[i, j] = rnd.Next(-100, 100);
                    Console.Write("{0,4}", arr54[i, j]);

                    // "for"s for swap

                    for (int g = 0; g < j; g++)
                    {
                        if (arr54[i, g] < arr54[i, j])
                        {
                            // swap
                            swap = arr54[i, j];
                            arr54[i, j] = arr54[i, g];
                            arr54[i, g] = swap;
                        }
                    }

                }

            }

            Console.WriteLine("\n");

            for (int i = 0; i < task54_h; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < task54_w; j++)
                {
                    Console.Write("{0,4}", arr54[i, j]);
                }
            }

            Console.WriteLine("\n");



            // Задача 56: 

            Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

            Console.WriteLine("Введите длину массива:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task56_w);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task56_w);
            }

            // считано число элементов по длине массива

            Console.WriteLine("Введите высоту массива:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task56_h);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task56_h);
            }

            // считано число элементов по высоте массива

            int[,] arr56 = new int[task56_h, task56_w];

            int task56_sum = 0;
            int task56_sum_max = 0;
            int task56_indx_max = 0;


            for (int i = 0; i < task56_h; i++)
            {
                Console.WriteLine("\n");
                task56_sum = 0;
                for (int j = 0; j < task56_w; j++)
                {
                    arr56[i, j] = rnd.Next(-100, 100);
                    Console.Write("{0,4}", arr56[i, j]);

                    task56_sum += arr56[i, j];

                }

                if (i == 0)
                    task56_sum_max = task56_sum;

                if (task56_sum_max > task56_sum)
                {
                    task56_sum_max = task56_sum;
                    task56_indx_max = i;
                }

            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Индекс строки с наименьшей суммой элементов - " + task56_indx_max + ". Сумма элементов строки: " + task56_sum_max);

            Console.WriteLine("\n");



            // Задача 58: 

            Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

            Console.WriteLine("Введите количество элементов согласующей грани 2мерных массивов:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task58_wS);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task58_wS);
            }

            // считано число элементов согласующей грани массивов для умножения матриц

            Console.WriteLine("Введите количество элементов уникальной грани 2мерного массива A:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task58_wA);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task58_wA);
            }

            // считано число элементов уникальной грани 1го массива

            Console.WriteLine("Введите количество элементов уникальной грани 2мерного массива B:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task58_wB);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task58_wB);
            }

            // считано число элементов уникальной грани 2го массива


            int[,] arr58A = new int[task58_wS, task58_wA];
            int[,] arr58B = new int[task58_wB, task58_wS];
            int[,] arr58S = new int[task58_wB, task58_wA];


            for (int iB = 0; iB < task58_wB; iB++)
                for (int jA = 0; jA < task58_wA; jA++)
                    arr58S[iB, jA] = 0;
            // for обнулил массив S

            Console.WriteLine("\n");

            Console.WriteLine("Массив А (задан случайно):");

            Console.WriteLine("\n");

            for (int iS = 0; iS < task58_wS; iS++)
            {
                Console.WriteLine("\n");
                for (int jA = 0; jA < task58_wA; jA++)
                {
                    arr58A[iS, jA] = rnd.Next(0, 10);
                    Console.Write("{0,4}", arr58A[iS, jA]);

                }
                // for присвоил рандомные значения (0,10) и вывеk на экран матрицу A

                for (int jB = 0; jB < task58_wB; jB++)
                    arr58B[jB, iS] = rnd.Next(0, 10);
                // for присвоил рандомные значения (0,10) матрице B. Без вывода

                for (int iB = 0; iB < task58_wB; iB++)
                    for (int jA = 0; jA < task58_wA; jA++)
                        arr58S[iB, jA] += (arr58A[iS, jA] * arr58B[iB, iS]);
                // одновременно для всей матрицы (произведение) произведено увеличение значений матрицы на попарное произведение
                // ..всех новых значений в матрицах А и B
            }

            Console.WriteLine("\n");

            Console.WriteLine("Массив B (задан случайно):");

            Console.WriteLine("\n");

            for (int iB = 0; iB < task58_wB; iB++)
            {
                Console.WriteLine("\n");
                for (int jS = 0; jS < task58_wS; jS++)
                    Console.Write("{0,4}", arr58B[iB, jS]);
            }
            // for вывел на экран значения матрицы B

            Console.WriteLine("\n");

            Console.WriteLine("Массив S (произведение A * B):");

            Console.WriteLine("\n");

            for (int iB = 0; iB < task58_wB; iB++)
            {
                Console.WriteLine("\n");
                for (int jA = 0; jA < task58_wA; jA++)
                    Console.Write("{0,4}", arr58S[iB, jA]);
            }
            // for вывел на экран значения матрицы произведения

            Console.WriteLine("\n");



            // Задача 60: 

            Console.WriteLine("Задача 60: Сформируйте трёхмерный массив из неповторяющихся " +
                "двузначных чисел. Напишите программу, которая будет построчно выводить " +
                "массив, добавляя индексы каждого элемента.");

            const int task60_s = 3;
            const int task60_h = 3;
            int task60_w = 0;
            int SomeNumber = 0; // to save Randoms
            bool[] twoSignNumbers = new bool[90];
            for (int i = 0; i < 90; i++)
                twoSignNumbers[i] = true; // array of availible unique 10-99

            Console.WriteLine("Введите ширину массива (длина массива - " + task60_s + ", высота массива - " + task60_h + "): от 1 до 10");


            numberCheck = int.TryParse(Console.ReadLine(), out task60_w);
            if (numberCheck)
                if ((task60_w < 1) || (task60_w > 10))
                {
                    numberCheck = false;
                    Console.WriteLine("Число больше допустимого.");
                }

            while (!numberCheck)
            {
                Console.WriteLine("Некорректно. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task60_w);
                if (numberCheck)
                    if ((task60_w < 1) || (task60_w > 10)) {
                        numberCheck = false;
                        Console.WriteLine("Число больше допустимого.");
                    }
            }

            // все размерности 3го массива введены

            int[,,] arr60 = new int[task60_w, task60_s, task60_h];


            for (int i = 0; i < task60_h; i++) {

                Console.WriteLine("\n");
                for (int j = 0; j < task60_s; j++) {

                    Console.WriteLine("\n");
                    for (int g = 0; g < task60_w; g++) {

                        SomeNumber = rnd.Next(10, 99);
                        while (!twoSignNumbers[SomeNumber - 10])
                            SomeNumber = rnd.Next(10, 99);

                        twoSignNumbers[SomeNumber - 10] = false;
                        arr60[g, j, i] = SomeNumber;
                        Console.Write("{0,7}", "" + arr60[g, j, i] + g + j + i);
                    }
                }
            }

            Console.WriteLine("\n\n");

            

            // Задача 62: 

            Console.WriteLine("Задача 62: Заполните спирально массив 4 на 4.");

            int task62_x_end = 3;
            int task62_x_start = 0;

            int task62_y_end = 3;
            int task62_y_start = 0;

            int start = 0;
            int limit = 0;
            int stable = 0;
            int period = 1;

            bool x_Left = true;
            bool y_Down = true;
            bool queue_x = true;
            bool NotEnd = true;

            int[,] arr62 = new int[task62_x_end+1, task62_y_end+1];

            int threadFollowing = 1;


            while (NotEnd)
            {
                NotEnd = false;
                if (queue_x)
                {
                    if (x_Left)
                    {
                        period = 1;
                        start = task62_x_start;
                        limit = task62_x_end;
                        stable = y_Down ? task62_y_start : task62_y_end;

                        for (int i = start; i <= limit; i += period)
                        {
                            //Console.WriteLine(i + " - " + stable);
                            NotEnd = true;
                            arr62[stable, i] = threadFollowing;
                            threadFollowing++;
                        }

                        if (y_Down)
                            task62_y_start++;
                        else
                            task62_y_end--;

                    }
                    else
                    {
                        period = -1;
                        start = task62_x_end;
                        limit = task62_x_start;
                        stable = y_Down ? task62_y_start : task62_y_end;

                        for (int i = start; i >= limit; i += period)
                        {
                            // Console.WriteLine(i + " - " + stable);
                            NotEnd = true;
                            arr62[stable, i] = threadFollowing;
                            threadFollowing++;
                        }

                        if (y_Down)
                            task62_y_start++;
                        else
                            task62_y_end--;

                    }

                    queue_x = !queue_x;
                    x_Left = !x_Left;

                }
                else
                {
                    if (y_Down)
                    {
                        period = 1;
                        start = task62_y_start;
                        limit = task62_y_end;
                        stable = x_Left ? task62_x_start : task62_x_end;

                        for (int i = start; i <= limit; i += period)
                        {
                            // Console.WriteLine(stable + " - " + i);
                            NotEnd = true;
                            arr62[i, stable] = threadFollowing;
                            threadFollowing++;
                        }

                        if (x_Left)
                            task62_x_start++;
                        else
                            task62_x_end--;

                    }
                    else
                    {
                        period = -1;
                        start = task62_y_end;
                        limit = task62_y_start;
                        stable = x_Left ? task62_x_start : task62_x_end;

                        for (int i = start; i >= limit; i += period)
                        {
                            // Console.WriteLine(stable + " - " + i);
                            NotEnd = true;
                            arr62[i, stable] = threadFollowing;
                            threadFollowing++;
                        }

                        if (x_Left)
                            task62_x_start++;
                        else
                            task62_x_end--;

                    }

                    queue_x = !queue_x;
                    y_Down = !y_Down;

                }

                
            }

            for(int i = 0; i < 4; i++) {
                Console.WriteLine("\n");
                for (int j = 0; j < 4; j++) {
                    Console.Write("{0,3}", arr62[i, j]);
                }
            }

            Console.WriteLine("\n");


        }
    }
}
