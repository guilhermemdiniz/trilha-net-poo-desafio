using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Intanciando objeto da classe Smartphone (não deve permitir, pois é uma classe abstrata)
// Smartphone s = new Smartphone(numero: "989824323", modelo: "J7 Prime", imei: "23923834234", memoria: 8);

// Instanciando objeto da classe Iphone
Iphone i = new Iphone(numero: "983747434", modelo: "6s", imei: "873546734353", memoria: 3);
// Executando método InstalarAplicativo no Iphone
i.InstalarAplicativo(nomeApp: "Instagram");

// Instanciando objeto da classe Nokia
Nokia n = new Nokia(numero: "987645533", modelo: "Tijolão", imei: "32875832752", memoria: 1);
n.InstalarAplicativo("Jogo da cobrinha");
