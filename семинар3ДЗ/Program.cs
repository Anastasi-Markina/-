// Console.WriteLine("введите число");
// string a = Convert.ToString(Console.ReadLine());
// int b = b.Length;
// // if (a>9999 && a<100000)
// // {}
//  if (a[0]==a[4] && a[1] == a[3])
//     {
//         System.Console.WriteLine("да");
//     }
// else 
//     System.Console.WriteLine("нет");

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number [0] == number [4] && number [1] == number [3])
    {
        Console.WriteLine($"Число {number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"Число {number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"Число {number} - не является пятизначным");
}