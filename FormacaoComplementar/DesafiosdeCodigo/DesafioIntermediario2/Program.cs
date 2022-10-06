using System;

    class MinhaClasse {
        static void Main(string[] args) {
            var timeInSeconds = int.Parse(Console.ReadLine());

            var hours = timeInSeconds /3600;
           timeInSeconds = timeInSeconds % (3600);

            var minutes = timeInSeconds /60;
            var seconds = timeInSeconds % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }