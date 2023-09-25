using System.IO;

public class Program
{
    public static string caminhoArquivo = "Arquivo/arquivo2.txt";

    public static void Main()
    {
        //Chamando o método GravarArquivo
        GravarArquivo();
        //Chamando o método LerArquivo
        LerArquivo();
    }

    public static void LerArquivo()
    {
        try
        {
            //Verificar se o arquivo existe
            if (File.Exists(caminhoArquivo) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando
                //a verificação no if é falsa ou seja o arquivo não existe
                File.Create(caminhoArquivo);
            }

            //Instanciando um objeto da Classe StreamReader para ler o arquivo
            using (StreamReader arquivo = new StreamReader(caminhoArquivo))
            {
                string linha;
                //Fazendo o while para ler linha por linha que contêm no arquivo
                while ((linha = arquivo.ReadLine()) != null)
                {
                    //Escrevendo no console o conteúdo da linha
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
        }
    }

    public static void GravarArquivo()
    {
        try
        {
            //Instanciando um objeto da classe StreamWriter para gravar em arquivo
            using (StreamWriter arquivo = new StreamWriter(caminhoArquivo, true))
            {
                Console.WriteLine("Digite um texto para salvar no arquivo");
                string texto = Console.ReadLine();
                arquivo.WriteLine(texto);
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}