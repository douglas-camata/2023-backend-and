namespace Models 
{
    public class Pantera
    {
        public decimal tamanho { get; set; }
        public int peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }

        public void Correr(){
            Console.WriteLine("A pantera está correndo");
        }

        public void Cacar(){
            Console.WriteLine("A pantera está caçando");
        }

        public void Reproduzir(){
            Console.WriteLine("A pantera está reproduzindo");
        }

    }
}