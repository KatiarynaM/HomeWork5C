// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
int[] array1 = GetArray(7, 100, 999);
Console.WriteLine($"[{String.Join(",", array1)}]");
Console.WriteLine($"В этом массиве количество четных чисел равно {GetCountPosElement(array1)} ");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных индексах.[3, 7, 23, 12] -> 19//[-4, -6, 89, 6] -> 0
int[] array2 = GetArray(6, 1, 20);
Console.WriteLine($"[{String.Join(",", array2)}]");
Console.WriteLine($"Сумма нечётных элементов ровна {GetSumEl(array2)}");

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
//элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.[1 2 3 4 5] -> 5 8 3;[6 7 3 6] -> 36 21
int[] array3 = GetArray(5, 1, 10);
Console.WriteLine($"[{String.Join(",", array3)}]");
int[] array32 = GetNewArray(array3);
Console.WriteLine($"Новый массив [{String.Join(",", array32)}]");


//-----Methods---------------
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetCountPosElement(int[] array){  //считаем число положительных эл-тов  
    int count = 0;
    foreach(int el in array)
    {
        if(el % 2 == 0)
        {
            count++;
        }
    } 
    return count;
}

int GetSumEl (int[] array){ //сумма нечетных эл-тов
      int Sum = 0;
      for(int i = 0; i < array.Length; i++){
            if(i % 2 != 0 ){
                  Sum += array[i];
                  }
       }
       return Sum;
}

 int[] GetNewArray (int[] array){
    int N = array.Length;
    int a = N/2;
    int[] arr = new int [N];
    int [] res = new int [N-a]; 
    for(int i = 0; i <  N; i++){
        arr [i]  = array [N-1-i]; //разворот массива
    }
    if ( N % 2 != 0){
        for(int i = 0; i <  a ; i++){
        res [i]  = array [i] * arr[i];
        
        }
        res [a] = array[a];
    }
    else for(int i = 0; i < a; i++){
        res [i]  = array [i] * arr[i];
        }
    return res;
 }