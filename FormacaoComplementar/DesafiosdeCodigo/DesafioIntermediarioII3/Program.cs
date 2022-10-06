using System;

//TODO: Complete os espaços em branco com uma possível solução para o problema.
class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if ( Y == 0  ) {
                 Console.WriteLine("divisao impossivel");
            } else {
                Console.WriteLine(string.Format("media = {0:0.0}", X/Y));
            }
        }
    }
}