using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartfone Nokia...");
Smartphone nokia = new Nokia(numero: "34988298258", modelo: "Modelo nokia", imei: "11111111", memoria: 124);
nokia.Ligar();
nokia.InstalarAplicativo("ZAPNELSON");

Console.WriteLine("\n");

Console.WriteLine("Smartfone Iphone...");
Smartphone iphone = new Iphone(numero: "34988252585", modelo: "Modelo iphone", imei: "22222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("INSTANAGRAM");