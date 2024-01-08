using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "13988447711", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "13988442211", modelo: "Modelo 2", imei: "2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");