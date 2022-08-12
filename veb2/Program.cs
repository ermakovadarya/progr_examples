/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int num= new Random().Next(100,1000);
int a1=num/100;
int a2=num%10;
/*string s1=a1.ToString();
string s2=a2.ToString();
String result=s1+s2;*/
int result=(a1*10)+a2;

Console.WriteLine($"удаление 2 числа из {num} даст -> {result}");