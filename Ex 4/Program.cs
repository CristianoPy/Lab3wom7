/*4. Scrieti un program care va inversa elementele unui vector
  Lungimea vectorului va fi citita de la tastatura
  Inversarea elementelor va fi facuta in functia Main (fara o functie dedicate)
  Afisarea vectorului se va face printr-o functie de afisare dedicata*/

internal class Program
{
    static void Valoare(int[] v, int num)
    {
        Console.WriteLine("valoare din vector:");
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(v[i] + ",");
        }
        Console.WriteLine("");
    }

    static void ValoareInvers(int[] v, int num)
    {
        int j = 0;
        int i = 0;
        int aux = 0;

        while (i < j)
        {
            aux = v[i];
            v[i] = v[j];
            v[j] = aux;
            j--;
            j++;
        }
    }
    private static void Main(string[] args)
    {
        int[] v = new int[5];
        int num = 5;
        int i;
        int j;
       

        for(i = 0; i < 5; i++)
        {
            v[i] = (i+1)*10;
        }
        Valoare(v, num);
        Valoare(v, num);

        Console.ReadLine();


    }
}