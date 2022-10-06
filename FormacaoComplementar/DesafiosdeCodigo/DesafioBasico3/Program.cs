// Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;

    raio = double.Parse(Console.ReadLine());
    volume = pi * (4.0/3) * Math.Pow( raio , 3 );
    
    Console.WriteLine("VOLUME = " + string.Format("{0:0.000}", volume));
  }

}