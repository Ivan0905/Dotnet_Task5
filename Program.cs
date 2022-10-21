// Задача №34 Задайте массив заполненный случайным трехзначными числами
//Напишите программу, которая покажет колличество четных чисел в массиве
/*Console.WriteLine("Введите размер массива");
int len = int.Parse(Console.ReadLine()!);
int[] array=GetArray(len);
int count=0;

for (int j=0; j<array.Length;j++){
    if (array[j]%2==0){
        count++;
    }
}

Console.WriteLine(String.Join("|",array));
Console.WriteLine($"Колличество четных чисел в массиве равняется {count}");
*/
int[] GetArray(int size)
{

    int[] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {

        res[i] = new Random().Next(100, 1000);
    }

    return res;
}

//Задача №36 Задайте одномерный массив, заполенный случайными числами,
//Найдите сумму элементов, стоящих на нечетных позициях
Console.WriteLine("Введите размер массива");
int len = int.Parse(Console.ReadLine()!);
int []array = GetArray(len);
Console.WriteLine("Сумма чисел нечетных индексов массива "+ String.Join("|",array)+$" равняется {Val(array)}");


int Val(int []arr)
{int sum = 0;
for (int j=1;j<arr.Length;j=j+2){
sum = sum+arr[j];
Console.WriteLine(sum);
}
return sum;
}

//Задача №38 Задайте массив вещественных чисел (просто от минус бесконечности, до плюс бесконечности,
//с дробнымми не работаем) Найдите разницу между максимальным и минимальным элементов массива.
