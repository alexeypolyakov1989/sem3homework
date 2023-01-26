// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
// (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
//14212 -> нет
//12821 -> да
//23432 -> да

int number;
int number2; // для хранения копии ввеленного числа
int rebmun;  // для переписанного в обратном порядке числа
int digit;   // для вычисления rebnum

Console.WriteLine("Введите число : ");
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("ошибка ввода");
}

number2 = number;
rebmun = 0;
digit = 0;

while(number > 0)
{ 
digit = number % 10;  
rebmun = rebmun * 10 + digit;
number /= 10;
}

if (number2 == rebmun)
    Console.WriteLine("Введенное число является палиндромом");
else
    Console.WriteLine("Введенное число не является палиндромом");


