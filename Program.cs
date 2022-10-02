//Задача №2  Написать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
{
int a, b; 

Console.WriteLine(" Ввод числа: "); 
 a = Convert.ToInt32(Console.ReadLine());

 b = Convert.ToInt32(Console.ReadLine()); 

 if (a > b)
 {
    Console.WriteLine("{0} наибольшее число" , a);
 }
 else 
 {
    Console.WriteLine("{0} наибольшее число" , b);
 }
 
}
*/
// Задача №4 Написать программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Ввод 3х чисел");

int num_1 = Convert.ToInt32(Console.ReadLine());
            
int num_2 = Convert.ToInt32(Console.ReadLine());
           
int num_3 = Convert.ToInt32(Console.ReadLine()); 

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}
 if (num_3 > max)
 { 
    max = num_3;
 }
  Console.WriteLine("Наибольшее из введённых чисел -> " + max);
*/
//Задача 8: Напиcать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Ввод числа:");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

while(current<= n)
{
    Console.WriteLine(current + " ");
    current++;
}
*/
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            
Console.WriteLine("Ввод числа:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
 Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
}
else
{
Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
}
