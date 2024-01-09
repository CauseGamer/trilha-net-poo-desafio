namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone()
        {
        }
        public Iphone(string numero) : base(numero)
        {
        }

        public override void InserirIMEI(string imei)
        {
            IMEI = imei;
        }

        public override void InserirMemoria(int memoria)
        {
            Memoria = memoria;
        }

        public override void InserirModelo(string modelo)
        {
            Modelo = modelo;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"AppleStore Instalando: {nomeApp}");
        }
    }
}