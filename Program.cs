/*Console.WriteLine("Введите трехзначное число: ");
int tr = int.Parse(Console.ReadLine()!);
string trstring = tr.ToString();
if(trstring.Length == 3){
    Console.WriteLine(trstring[1]);
}
else Console.WriteLine("Число не корректно.");*/

/*Console.Write("Введите номер дня недели: ");
int week = int.Parse(Console.ReadLine()!);
if (week > 0 && week <8){
    string result = (week == 6 ||week == 7 ? "Выходной" : "Рабочий день");
    Console.WriteLine(result);
}
else Console.WriteLine("День недели введен не корректно. ");*/

/*Console.WriteLine("Введите трехзначное число: ");
int tr = int.Parse(Console.ReadLine()!);
string trstring = tr.ToString();
Console.WriteLine(trstring[1]);*/

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// 7 -> 28

// 4 -> 10

// 8 -> 36

/*Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSum(A)}");


// Методы
int GetSum(int A){
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum += i;
    }
    return sum;
}*/

// Задача 1: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

/*Console.Write("Введите Ваше число: ");
int omega = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведения чисел от 1 до {omega} равна {MyMethod(omega)}");

//method
int MyMethod(int omega) {
    int sum = 1;
    for(int i = 1; i <= omega; i++){
        sum *= i;
    }
    return sum;
}*/


// Задача 2: Определить, является ли заданное шестизначное число счастливым. 
// (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его 
// последних трех цифр, порядок чисел в сумме не важен). Решить самым оптимальным способом.

/*Console.WriteLine("Введите шестизначное число: ");
int N = int.Parse(Console.ReadLine()!);
if(N >= 100000 && N <= 999999){
    if (LuckyNumber(N) == true) Console.WriteLine($"Число {N} - счастливое");
    else Console.WriteLine($"Число {N} - не счастливое");
}
else Console.WriteLine("Некорректный ввод");

bool LuckyNumber(int num){
    string number = num.ToString();
    int first = (Convert.ToInt32(number[0]) + Convert.ToInt32(number[1]) + Convert.ToInt32(number[2]));
    int second = (Convert.ToInt32(number[3]) + Convert.ToInt32(number[4]) + Convert.ToInt32(number[5]));

    if (first == second){
        return true;
    }
    return false;
}*/

/*
Задача 2: Определить, является ли заданное шестизначное число счастливым. 
(Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его 
последних трех цифр, порядок чисел в сумме не важен). Решить самым оптимальным способом.
*/

//Метод, который запрашивает шестизначное число
/*string PutNumber()
{
    Console.Write("Введите шестизначное число: ");
    string result = Console.ReadLine();
    return result;
}

//Проверка числа
bool Check(string num)
{
    if (num.Length == 6) return true;
    else return false;
}


//Happy method

void FindHappy(string num)
{

    if (num[0]+num[1]+num[2] == num[3]+num[4]+num[5])
    {
        Console.WriteLine("Число счастливое!");
    }
    else 
    {
        Console.WriteLine("Число не счастливое!");
    }
}

//Программа

string number = PutNumber();

if (Check(number)) FindHappy(number);
else Console.WriteLine("Число не шестизначное!");*/


// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

/*int[] array = GetRange(8);
Console.WriteLine($"[{String.Join(",", array)}]");

//method
int[] GetRange(int size){
    int[] massive = new int[size];
    for(int i = 0; i < massive.Length; i++){
        massive[i] = new Random().Next(2);
    }
    return massive;
}*/

/*01.08

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}

Console.WriteLine($"Позитивная сумма = {positiveSum}, сумма отрицательных = {negativeSum}");

// Общий метод для создания одномерного массива
int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/

// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет

// 3; массив [6, 7, 19, 345, 3] -> да


/*int[] array = GetArray(5, 1, 33);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);
string result = "";

foreach (int el in array){
    result = el == number ? "Да" : "Нет";
}

Console.WriteLine(result);

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/



/*Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2] -> 0

[10, 11, 12, 13, 14] -> 5*/


/*int[] arr = array_random(11, -1000, 1000);

Console.WriteLine($"[{String.Join(",", arr)}]");

int sum = 0;

for (int i = 0; i < arr.Length; i++){
    sum += (arr[i] >= 10 && arr[i] <= 99) ? 1 : 0;
}
Console.WriteLine(sum);


int[] array_random(int size, int minValue, int maxValue) {
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/

/*Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21*/


/*static void Main()
        {
            int[] array = GenerateRandomArray(8, 1, 100); 

            int[] productArray = new int[array.Length / 2];

            for (int i = 0; i < array.Length / 2; i++)
            {
                productArray[i] = array[i] * array[array.Length - 1 - i];
            }

            Console.WriteLine("Произведения пар чисел в массиве:");
            PrintArray(productArray);
        }

        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
        }*/



/* int[] haha = GetArray(6, 1, 10);
int[] hoho = new int[haha.Length / 2];
Console.Write($"[{String.Join(",", haha)}]");
for(int i = 0; i < (haha.Length / 2); i++){
    hoho[i] = haha[i] * haha[haha.Length - 1 - i];
}
Console.Write($"[{String.Join(",", hoho)}]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/

// Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

/*int[] haha = GetArray(7, 1, 10);
int size = haha.Length / 2;
if(haha.Length % 2 != 0) size++;
int[] hoho = new int[size];

Console.Write($"[{String.Join(",", haha)}]");
for(int i = 0; i < size; i++){
    hoho[i] = haha[i] * haha[haha.Length - 1 - i];
}
if(haha.Length % 2 != 0){
    hoho[size - 1] = haha[haha.Length / 2];
}
Console.Write($"[{String.Join(",", hoho)}]");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for(int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}*/

