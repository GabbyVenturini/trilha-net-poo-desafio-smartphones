using trilha_net_poo_desafio_smartphones.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo2", imei: "22222222", memoria: 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");