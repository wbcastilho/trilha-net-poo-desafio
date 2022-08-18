using DesafioPOO.Models;

Nokia nokia = new Nokia("99999-8888", "A32", "I858FGG", "256GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Iphone iphone = new Iphone("99999-7777", "Iphone 10", "AAAAA", "512GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");