using System;

class Program
{

    static void Main(string[] args)
    {
        int tipos = 1;
        int tot = 0;
        int i = 0;
        string[] joias = new string[106];

        while (tot < 106)
        {
            var input = Console.ReadLine();
            tot += input.Length;
            joias[i] = input;

            for (int j = 0; j < i; j++)
            {
                if (input.Equals(joias[j]))
                {
                    j = i;
                }
                else {
                    if((j + 1) == i ){
                        tipos++;
                    }
                }
            }
            i++;
        }
        for (int j = 0; j < joias.Length; j++)
        {
            Console.Write(joias[j] + " ");
        }
        Console.WriteLine(tipos);
    }

}