// Abaixo segue um exemplo de código que você pode ou não utilizar
using System; 

class TESTE {

    static void Main(string[] args) { 
//TODO: Complete os espaços em branco com uma possível solução para o desafio
            int n;
            int maior = 0;
            int posicao = 0;
            for(int i = 1; i <= 100 ; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if(n > maior)
                {
                    maior = n;
                    posicao = i;     
                } 
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
    }
}