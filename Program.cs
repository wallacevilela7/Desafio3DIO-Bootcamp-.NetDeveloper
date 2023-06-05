

using Desafio3DIO.Models;

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "1234", modelo: "11", imei: "0101222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "78910", modelo: "Tijolao", imei: "77777", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tiktok");

