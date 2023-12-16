using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone(numero:"1198781-1234", modelo:"Iphone 8", imei:"12344321", memoria:128);
Console.WriteLine($"Número: {iphone.Numero}");
iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("\n \n");



Smartphone nokia = new Nokia(numero:"1198781-5678", modelo:"Nokia tijolão", imei:"43211234", memoria: 8);
Console.WriteLine($"Número: {nokia.Numero}");
nokia.InstalarAplicativo("Jogo da Cobrinha");
nokia.Ligar();
nokia.ReceberLigacao();
