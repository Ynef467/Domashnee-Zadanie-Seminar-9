while (true)
{
    Console.Clear();
    Console.WriteLine($"<<<Решение задач с помощью рекурсии>>>\n");
    Console.WriteLine("Задача 1: программа вывода натуральных чисел в промежутке от M до N");
    Console.WriteLine("Задача 2: программа нахождения суммы натуральных чисел в промежутке от M до N");
    Console.WriteLine($"Задача 3: программа вычисления функции Аккермана\n");

    int numTask = EnterPositiveIntNumber("Для выбора нужной задачи введите её номер. Для выхода из программы введите 4.");

    switch (numTask)
    {
        case 4: return;
        case 1:

            /* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
            натуральные числа в промежутке от M до N.
            M = 1; N = 5. -> "1, 2, 3, 4, 5"
            M = 4; N = 8. -> "4, 6, 7, 8" */

            Console.Clear();
            Console.WriteLine($"<<<Задача 1: Программа вывода натуральных чисел в промежутке от M до N>>>\n");

            int minNumber = EnterIntNumber("Введите первое число промежутка");
            int maxNumber = EnterIntNumber("Введите второе число промежутка");

            if (minNumber <= maxNumber)
            {
            Console.WriteLine($"\nЧисла от {minNumber} до {maxNumber}:\n\n{NumberSeries(minNumber, maxNumber)}");
            }

            else
            Console.WriteLine($"\nЧисла от {maxNumber} до {minNumber}:\n\n{NumberSeries(maxNumber, minNumber)}");

            PressAKey();

            break;

        case 2:
        
            /* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
            натуральных элементов в промежутке от M до N.
            M = 1; N = 15 -> 120
            M = 4; N = 8. -> 30 */

            Console.Clear();
            Console.WriteLine($"<<<Задача 2: Программа нахождения суммы натуральных чисел в промежутке от M до N>>>\n");

            int minNumber2 = EnterIntNumber("Введите первое число промежутка");
            int maxNumber2 = EnterIntNumber("Введите второе число промежутка");

            if (minNumber2 <= maxNumber2)
            {
                Console.WriteLine($"\nЧисла от {minNumber2} до {maxNumber2}:\n\n{SumSeries(minNumber2, maxNumber2)}");
            }

            else
            {
                Console.WriteLine($"\nЧисла от {maxNumber2} до {minNumber2}:\n\n{SumSeries(maxNumber2, minNumber2)}");
            }

            PressAKey();

            break;

        case 3:

            /* Задача 68: Напишите программу вычисления функции Аккермана с помощью
            рекурсии. Даны два неотрицательных числа m и n.
            m = 2, n = 3 -> A(m,n) = 29 */

            Console.Clear();
            Console.WriteLine($"<<<Задача 3: программа вычисления функции Аккермана>>>\n");

            double akkermanM = Convert.ToDouble(EnterPositiveIntNumber("Введите первое целое положительное число"));
            double akkermanN = Convert.ToDouble(EnterPositiveIntNumber("Введите второе целое положительное число"));

            Console.WriteLine($"\nФункция Аккермана для пары чисел {akkermanM} и {akkermanN} равна {AkkermanFunction(akkermanM, akkermanN)}");

            PressAKey();

            break;

        default: Console.WriteLine("Такой задачи у нас для вас нет!"); break;
    }
}

void PressAKey() // (запрос нажатия клавиши для продолжения)
{
    Console.WriteLine($"\nНажмите любую клавишу для продолжения...\n");
    Console.ReadKey();
}

int EnterIntNumber(string text) // (ввод и проверка целого числа)
{
    Console.Write($"{text}...\n");

    while (true)
    {
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        catch (FormatException)
        {
            Console.WriteLine($"Некорректный ввод. Введите целое число!\n");
        }
    }
}

int EnterPositiveIntNumber(string text) // (ввод и проверка целого положительного числа)
{
    Console.Write($"{text}...\n");

    while (true)
    {
        try
        {
        link: int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0) return number;
            else
            {
                Console.WriteLine($"Вы ввели отрицательное число. Введите положительное!\n");
                goto link;
            }
        }

        catch (FormatException)
        {
            Console.WriteLine($"Некорректный ввод. Введите целое положительное число!\n");
        }
    }
}

string NumberSeries(int M, int N)
{
    if (M <= N) return $"{M} " + NumberSeries(M + 1, N);
    else return String.Empty;
}

int SumSeries(int M, int N)
{
    if (M < N) return M + SumSeries(M + 1, N);
    else return N;
}

double AkkermanFunction(double M = 2, double N = 3)
{
    if (M == 0 && (N != 0)) return N + 1;
    if ((N == 0) && (M != 0)) return AkkermanFunction(M - 1, 1);
    else return AkkermanFunction(M - 1, AkkermanFunction(M, N - 1));
}