/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 

является ли оно палиндромом.
14212 -> нет       12821 -> да       23432 -> да 

Console.WriteLine("Введите пятизначное число:  ");
int num = Convert.ToInt32 (Console.ReadLine ());
int res1 = num / 10000; // 34543 /10000= 3 (1)
int res5= num % 10;     // 34543 % 10 = 3 (5)
int res2 = (num / 1000) % 10; //34543 /1000 =34 % 10 = 4(2)
int res4 = (num % 100) / 10; // 34543 %100 = 43 /10=4 (4)

if (num >9999 && num > 100000){
Console.WriteLine ($"число {num} не является  пятизначным");
}
else if (res1==res5 && res2==res4){
Console.WriteLine ($"число {num} является  палиндромом");
}
else Console.WriteLine ($"число {num} не является  палиндромом");


Задача 

Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 2D пространстве.
 A (3,6); B (2,1), -> 15.84
A (7,-5); B (1,-1) -> 11.53  

//Math.Sqrt (num)   // математическая формула для нахождения квадрата

double LongLine (int x1, int y1, int x2, int y2)
{
int x= x2-x1;
int y = y2-y1;
double lengthAB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
return lengthAB;
}
Console.WriteLine("Введите координаты x для точки А :  ");
int xa= Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Введите координаты y для точки A :  ");
int ya= Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Введите координаты x для точки B :  ");
int xb= Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Введите координаты y для точки B :  ");
int yb = Convert.ToInt32 (Console.ReadLine ());

double dist = LongLine (xa,ya,xb,yb);
Console.WriteLine($"Расстояние между точками АВ = {dist:f2}"); // :f2-округлить до 2 цифр после запятой


Задача : Программа принимает координаты точки (x,Y)
и выдает номер четверти, в которой находится.
void Funct(int x, int y)
{
if (x>0 && y >0 )
    Console.WriteLine ("Ваша точка в первой четверти");
    else if (x < 0 && y > 0)
Console.WriteLine ("Ваша точка во второй четверти");

else if (x < 0 && y < 0)
Console.WriteLine ("Ваша точка в третей четверти");

else if (x >0 && y < 0)
Console.WriteLine ("Ваша точка в четвертой четверти");
}
Console.WriteLine("Введите цифру для координаты x:  ");
int xa= Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите цифру для координаты y   ");
int ya= Convert.ToInt32 (Console.ReadLine ());

Funct( xa,  ya); 

Задача 23

Напишите программу, которая принимает на вход
 число (N) и выдаёт таблицу квадратов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Cub(int num)
{
 int numb =1;
 while (numb <= num)
  {
   int res = numb * numb ;
   Console.Write ($"{res}, ");
   numb++;
  }
 Console.WriteLine($"\b\b.");
}
Console.WriteLine("Введите число N: ");
int num_user = Convert.ToInt32 (Console.ReadLine ());

if (num_user >=1){
   Console.Write($"{num_user}->");
   Cub (num_user);
}
else Console.WriteLine ($"число {num_user} не допустимо.");

