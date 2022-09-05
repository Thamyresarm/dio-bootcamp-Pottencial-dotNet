using System;

class Desafio {
  public static void Main() {
    int quantidadeEntradas = 3;
      
    while (quantidadeEntradas > 0) {
           //Console.WriteLine("Digite a quantidade de tartarugas: ");
      var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
      if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
        //Console.WriteLine("Digite as velocidades separadas por espaço: ");
        string[] tartarugas = Console.ReadLine().Split(" ");
        var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
        for (int i = 0; i < tartarugas.Length; i++) {
          var tartaruga = Int32.Parse(tartarugas[i]);
            
          if (maiorVelocidade < tartaruga) {
            maiorVelocidade = tartaruga;
          }
        }
        //Console.WriteLine("Nível da tartaruga mais rápida: ");
        if(maiorVelocidade < 10) {
          Console.WriteLine(1);
        } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
          Console.WriteLine(2);
        } else if (maiorVelocidade >= 20) {
          Console.WriteLine(3);
        }
        quantidadeEntradas--;
      } else {
        Console.WriteLine("Insira um número entre 1 e 500");
      }
    }
  }
}