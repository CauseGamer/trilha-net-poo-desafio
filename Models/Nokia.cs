namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia()
        {
        }
        public Nokia(string numero) : base(numero)
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
            Console.WriteLine($"PlayStore Instalando: {nomeApp}");
        }
    }
}