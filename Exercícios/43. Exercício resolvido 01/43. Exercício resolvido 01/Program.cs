string[] vect = Console.ReadLine().Split(' ');
int x = int.Parse(vect[0]);
int y = int.Parse(vect[1]);

if (x > y) Console.WriteLine("Decrescente");
else if (x < y) Console.WriteLine("Crescente");

while (x != y)
{
    vect = Console.ReadLine().Split(' ');
    x = int.Parse(vect[0]);
    y = int.Parse(vect[1]);

    if (x > y) Console.WriteLine("Decrescente");
    else if (x < y) Console.WriteLine("Crescente");
}
