using Models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da classe Pessoa
        //Instanciando sem um método construtor
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Douglas";
        pessoa1.idade = 25;
        pessoa1.Cantar();

        //Alternativa para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            nome = "Ricardo", 
            idade = 22
        };
        pessoa2.Cantar();
        */
        Pessoa pessoa1 = new Pessoa("Douglas" , 35, "douglas.camata@docente.senai.br");
        pessoa1.Cantar();
        pessoa1.Informacoes();
        
        Pessoa pessoa2 = new Pessoa("Ricardo" , 34, "ricardodias@docente.senai.br");
        pessoa2.Cantar();
        pessoa2.Informacoes();



    }

}