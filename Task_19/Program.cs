// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool CheckPalindrome (int numberInt)
{
    if( numberInt / 10000 == numberInt % 10 && numberInt / 1000 - ((numberInt / 10000)*10) == (numberInt % 100) / 10 )
    {
        return true;
    }
    else
    {
        return false;
    }
    }

System.Console.WriteLine("Введите пятизначное число для проверки его на полиндром: ");
int numberInt = Convert.ToInt32(Console.ReadLine());

while (numberInt < 10000 || numberInt > 100000)
{
    System.Console.WriteLine("Ошибка ввода данных. Введите пятизначное число для проверки его на полиндром: ");
    numberInt = Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine(CheckPalindrome(numberInt));
