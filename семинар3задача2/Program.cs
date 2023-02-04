Console.WriteLine("введите координату x1");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату y1");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату z1");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату x2");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату y2");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату z2");
int c2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Sqrt(Math.Pow((a2-a1),2)+ Math.Pow((b2-b1),2) + Math.Pow((c2-c1),2)));