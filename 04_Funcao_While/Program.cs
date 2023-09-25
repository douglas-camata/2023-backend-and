//Função em JavaScript
//function nomeFuncao (nome) {
//}

//Função / Método em C#
//public static string NomeFuncao(string nome) {
//}
class Sesi
{
    public static void Main()
    {
        //Chamando métodos sem retorno
        MostrarMensagem("Seja bem vindo");
        MostrarMensagem(" SESI / SENAI ");
        ImprimeDataHora(); 
        //Chamando o método Potenciacao com o parâmetro 4 e recebendo o retorno
        double potencia = Potenciacao(4);
        Console.WriteLine($"Potenciação {potencia} "); 

        ContagemRegressiva(10);
    }

    //Método com parâmetro e com retorno
    public static double Potenciacao(int num){
        double resultado = Math.Pow(num, 2);
        return resultado;
    }

    //Método sem parâmetro e sem retorno
    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }

    //Método com parâmetro e sem retorno
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;    //n = n - 1
            System.Threading.Thread.Sleep(1000);   //500 ms
        }
        Console.WriteLine("BOOOOOOM");
    }

    public static void JogoQueNrSouEu()
    {
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("             Bem vindo ao Jogo             ");
        Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine(""); //Linha em branco

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do {
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
                Console.WriteLine("O número digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
                Console.WriteLine("O número digitado é MENOR que o sorteado");
        } while (nrDigitado != nrSorteado);
        
        Console.WriteLine("Parabéns você acertou");
    }

}