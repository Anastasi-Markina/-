System.Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
for (int b = 1; b <= a; b++) 
{
    System.Console.WriteLine(Math.Pow(b,3));
}
