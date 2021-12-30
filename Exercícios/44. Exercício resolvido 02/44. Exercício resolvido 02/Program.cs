using System.Globalization;

double idade, total, media;

idade = int.Parse(s: Console.ReadLine());
total = idade;
int i = 1;

if (idade < 0) Console.WriteLine("impossivel calcular");
else
{
    while (idade > 0)
    {
        idade = int.Parse(s: Console.ReadLine());
        if (idade > 0)
        {
            total += idade;
            i++;
        }
    }
}
media = total / i;
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
