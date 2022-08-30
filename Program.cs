//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.  БЕЗ POW!


/*

            void ManualMathPow(int chislo, int stepen){
                int result = 1;
                int count = 1;
                for (int curr = chislo; count <= stepen; count++){
                result = result * curr;
                }
                Console.WriteLine($"Число '{chislo}' в степени '{stepen}' равно: '{result}'");
                }

            Console.Write("Введите число, которое нужно возвести в степень: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            ManualMathPow(a, b);


*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

void SumOfDigit(int num){
    int sum = 0;
    int n = num;
    for (int ostat = n; ostat > 0; ostat /= 10){
    sum = sum + ostat % 10;
    }

    Console.WriteLine($"Сумма всех цифр в числе '{num}' равна: '{sum}'");
}

         
Console.WriteLine("Введите число, что бы узнать сумму его знаков:");
int number = Convert.ToInt32(Console.ReadLine());
SumOfDigit(number);

*/



//Задача 29: Напишите программу, которая задаёт массив из 
//произвольного количества элементов и выводит их на экран.


/*

int[] CreateManualArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        Console.Write($"Введите значение {i} элемента массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array){
    Console.WriteLine();
    Console.WriteLine("Array created and look like:");
    Console.WriteLine();
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
    }

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateManualArray(size));

*/