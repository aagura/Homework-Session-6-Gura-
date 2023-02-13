//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

int GetNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода, вы ввели не число. Повторите ввод:");
        }
    }
    return result;
}

int [] InputArray(int Lenght)
{
    int[] array = new int [Lenght];
   
    for (int i = 0; i < array.Length; i++)
    {
        
        array[i] = GetNumber($"Введите элемент массива {i}");
            }
return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
       Console.Write($"{array[i]}, "); 
    }
    Console.Write(array[array.Length-1]);
    Console.WriteLine();
}


int CountPos (int [] arr)
{
    int result= 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) result++;
    }
return result;
}

int lengthArray = GetNumber("Введите количество элементов массива: ");
int [] arrayM = InputArray (lengthArray) ;
PrintArray (arrayM);
Console.WriteLine ($"Количество положительных элементов {CountPos (arrayM)}");