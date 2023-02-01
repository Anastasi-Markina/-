Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a>99 && a<1000)
{
    System.Console.WriteLine(a/10%10);
}
else
{
    System.Console.WriteLine("число не трехзначное");
}