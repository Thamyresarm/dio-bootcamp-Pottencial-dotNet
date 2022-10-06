using System;

class DIO {
        
static void Main(string[] args){
        //Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
         while (n > 0){
             int l = n % 10;
             if (n >= 1 && n <= Math.Pow(10,5)){
                p *= l;
                s += l;
                n /= 10;
             }
           }
           //Console.WriteLine("Diferença entre " + p + " e " + s + ": ");
           Console.WriteLine(p-s);
        } 
    }