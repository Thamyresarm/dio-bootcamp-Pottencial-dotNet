using System; 

class minhaClasse {

    static void Main(string[] args) { 
        int  x = 0;
        double media = 0;

        while(x < 2){
            var input = double.Parse(Console.ReadLine());

            if(input > 0 && input <= 10){
                media +=input;
                x++;
            } else {
                Console.WriteLine("nota invalida");
            }
        }

        media /=2;
        Console.WriteLine(string.Format("{0:0.00}", media));
    }

}