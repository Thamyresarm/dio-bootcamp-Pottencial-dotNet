using System;

namespace Start {
  class Program {
    static void Main(string[] args) {
      double A, B, C;
      
      A = double.Parse(Console.ReadLine());
      B = double.Parse(Console.ReadLine());
      C = double.Parse(Console.ReadLine());
      
      Console.WriteLine("MEDIA = " + String.Format("{0:0.0}", ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5)));
      Console.ReadKey();
    }
  }
}