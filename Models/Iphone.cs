using System;

namespace DesafioPOO.Models
{
    // A classe Iphone é uma subclasse da classe Smartphone, herdando suas propriedades e métodos.
    public class Iphone : Smartphone
    {
        // O construtor da classe Iphone chama o construtor da classe base (Smartphone) usando a palavra-chave 'base'.
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // O corpo do construtor está vazio, pois não há necessidade de realizar operações adicionais neste momento.
        }

        // Override do método InstalarAplicativo da classe base (Smartphone).
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone");
        }
    }
}
