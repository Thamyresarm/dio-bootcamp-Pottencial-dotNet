using System;
//TODO: Complete os espaços em branco com uma solução possível para o problema.
namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            var dias = int.Parse(Console.ReadLine());
            var anos = dias / 365;
            dias = dias % 365;
            var meses = dias / 30;
            dias = dias % 30;
            
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}