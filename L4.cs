/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

void Zadacha25()
{
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int power = Convert.ToInt32(Console.ReadLine());
int number_1 = 1;
double PowOfNumber(int number, int power)
{
        for (int i = 0; i < power; i++)
        {   
            number_1 = number_1 * number; 
        }
    return number_1;
}
Console.WriteLine("Число "+ number+ " в степени "+ power+ " = "+ PowOfNumber(number, power));
}
Zadacha25();

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
void Zadacha27()
{
    int size = int.Parse(Console.ReadLine());
    Random random = new Random();
    int[] array = new int[size] ;
    int sum = 0;
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = random.Next(0,10);
        Console.Write(array[i]);
    }
    for (int i = 0; i<array.Length; i++)
    {
        sum += array[i];
    }
    Console.Write("     Сумма ");
    Console.Write(sum);
}

//Zadacha27();


void Zadacha27_1()
{
    string number = Console.ReadLine();
    int number1 = int.Parse(number);
    int size = number.Length;
    int[] array = new int[size];
    int sum = 0;
    for (int i = 0; i<array.Length; i++)
    {
        Console.WriteLine("");
        array[i] = Convert.ToInt32(Convert.ToString(number[i]));
        Console.Write(array[i]);
    }
    for (int i = 0; i<array.Length; i++)
    {
        sum += array[i];
    }
    Console.Write("     Сумма ");
    Console.Write(sum);
}

//Zadacha27_1();

void Zadacha27_2()
{
    int number = int.Parse(Console.ReadLine());
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.Write("     Сумма ");
    Console.Write(sum);
}

//Zadacha27_2();

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [1, 6, 33]*/

void Zadacha29()
{
    // создание массива
    int size = 8;
    Random random = new Random();
    int[] array = new int[size] ;
    int sum = 0;
    Console.WriteLine("Ввод массива");
    for (int i = 0; i<array.Length - 1; i++)
    {
        array[i] = random.Next(-10,10);
        Console.Write(array[i] + " ");
    }
    
    // сортировка
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[j]))
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    
    // вывод
    Console.WriteLine(" ");
    Console.WriteLine("Вывод отсортированного по модулю массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
//Zadacha29();