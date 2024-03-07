/*Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul 
  sau citit de la tastatura. Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
Dificultate ridicata
• Numerele patrate perfecte din vector
Apelati functiile si afisati-le rezultatele.*/


using System;

int[] vector = new int[] { 1, 34, 56, 53, 23, 21 };

int Max = vector[0];

for(int i = 1; i < vector.Length; i++)
{
    if (vector[i] > Max)
    {
        Max = vector[i];
    }

}
Console.WriteLine("Cel mai mare numar din vector este: " + Max);

int Min = vector[0];

for (int i = 1; i > vector.Length; i++)
{
    if (vector[i] < Min)
    {
        Min = vector[i];
    }

}
Console.WriteLine("Cel mai mic numar din vector este: " + Min);

//numere divizibile cu 3 din vector



/*patratu perfect din vetor
int num = vector[5];

if (IsPerfectSquare(num))
{
    Console.WriteLine("Numarul " + num + " sunt patratu perfect.");
}

static bool IsPerfectSquare(int num)
{
    return Math.Sqrt(num) == (int)Math.Sqrt(num);
}*/

Console.ReadLine();