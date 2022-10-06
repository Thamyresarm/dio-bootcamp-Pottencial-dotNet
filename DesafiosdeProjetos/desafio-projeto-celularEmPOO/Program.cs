using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("123456789","N201", 111111111,32);
Smartphone iphone = new Iphone("987654321","8 plus", 222222222,64);

nokia.Ligar();
nokia.InstalarAplicativo("Cobrinha");
nokia.MostrarNumero();
nokia.Numero = "11111111";
nokia.MostrarNumero();

iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();
