namespace DesafioPOO.Models
{    
    public class Nokia : Smartphone
    {        
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando aplicativo {nomeApp} no smartphone Nokia");
        }
    }
}