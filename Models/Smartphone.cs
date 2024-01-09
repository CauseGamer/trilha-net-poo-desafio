namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone()
        {
        }
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public abstract void InserirModelo(string modelo);
        public abstract void InserirIMEI(string imei);
        public abstract void InserirMemoria(int memoria);

        public void ListarInformacao()
        {
            Console.WriteLine($"O modelo do seu Smartphone é: {Modelo}");
            Console.WriteLine($"O IMEI do seu Smartphone é: {IMEI}");
            Console.WriteLine($"A memoria do seu Smartphone é: {Memoria}");
        }
        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}