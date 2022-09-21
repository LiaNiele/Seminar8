// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){    //Метод создания массива и заполнения его случайными значениями по заданным параметрам
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

void Show2dArray(int[,] array){                              // Метод вывода массива
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}


//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// int[,] ArrangeRow(int[,] array){
//     int temp = 0;
//     for(int i=0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1)-1; j++){
//             for(int n=0; n<array.GetLength(1)-1; n++){
//                 if(array[i,n] < array[i,n+1]){
//                     temp = array[i,n];
//                     array[i,n] = array[i,n+1];
//                     array[i,n+1] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();

// int[,] array2 = ArrangeRow(array);
// Show2dArray(array2);




//  Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int count = 0;
// int minsum = Int32.MaxValue;                             // Задаем переменной максимальное значение
//     for(int i=0; i<array.GetLength(0); i++){
//         int sum = 0;
//         for(int j=0; j<array.GetLength(1)-1; j++){
//             sum += array[i,j];
//         }
//         if(sum < minsum){
//             minsum = sum;
//             count++;
//         }
//     }

// Console.Write($"Строка с наименьшей суммой элементов: {count} ");

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();



// Напишите программу, которая заполнит спирально массив 4 на 4.

int size = 4;
int[,] array = new int[size,size];
int n = 1;
int i = 0;
int j = 0;

while (n <= size * size)
{
    array[i, j] = n;
    if (i <= j + 1 && i + j < size - 1)        // заполняем значениями первую строку
        ++j;
    else if (i < j && i + j >= size - 1)       // заполняем последний столбец
        ++i;
    else if (i >= j && i + j > size - 1)       // заполнение последней строки справа-налево
        --j;
    else
        --i;
    ++n;
}

Show2dArray(array);

