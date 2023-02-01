Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99)
{
    while (a>999)
    {
        a /=10;
    }
    System.Console.WriteLine(a%10);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}