using System;

namespace DIO {
    class Program {
        static void Main(string[] args) {
           
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                if (i != N - 1) {
                    Console.Write("Ho ");                  //Complete o código no espaço em branco
                }
                else{
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}