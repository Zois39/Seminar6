//задача 2 напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
//a<b+c
/*
bool PossibleTriangle (int a, int b, int c)
{
    bool result = false;
    if (a < b + c)
        if (b < a + c)
            if (c < a + b)
                result = true;
    return result;
}

int ReadNumbers (string str)
{
    //запрашивает значение и возвращает в целочисленном виде
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int sideA = ReadNumbers("Input side A: ");
int sideB = ReadNumbers("Input side B: ");
int sideC = ReadNumbers("Input side C: ");
Console.WriteLine(PossibleTriangle(sideA, sideB, sideC));
*/
//задача 3 не используя рекурсию выведите первые N чисел фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] ArrayFibonacci (int a, int b, int n)
{
    int[] result = new int[n];
    result[0] = a;
    result[1] = b;
    for (int i = 2; i < n; i++)
        result[i] = result[i - 1] + result[i - 2];
    return result;
}
int ReadNumbers (string str)
{
    //запрашивает значение и возвращает в целочисленном виде
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int firstNumber = ReadNumbers("Input first number: ");
int secondNumber = ReadNumbers("Input second number: ");
int count = ReadNumbers("Input count: ");
int[] array = ArrayFibonacci(firstNumber, secondNumber, count);
for (int j = 0; j < array.Length; j++)
    Console.Write(array[j] + " ");
*/

//задача 4 напишите программу, которая будет преобразовывать десятичное число в двоичное

string DecimalToBinary (string a)
{
    string result = string.Empty;
    for (int b = Convert.ToInt32(a); b > 0; b /= 2)
        result = Convert.ToString(b % 2) + result;
    return result;
}
string ReadNumbers (string str)
{
    //запрашивает значение и возвращает в целочисленном виде
    Console.Write(str);
    return Console.ReadLine();
}
string number = ReadNumbers("Input number: ");
Console.WriteLine(DecimalToBinary(number));