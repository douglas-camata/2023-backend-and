public class Program 
{
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos ");
        Console.WriteLine($"A pessoa2 é {pessoa2.nome} e tem o email {pessoa2.email}  ");

        //pessoa1.nome = "Douglas";

        //Criar 2 objetos de classe anonima de Carro
        var carro1 = new {
            marca = "VW",
            modelo = "Gol",
            ano = 2020
        };
        Console.WriteLine($"O carro é da marca {carro1.marca}, modelo {carro1.modelo} e ano {carro1.ano}");

        var carro2 = new {
            marca = "VW",
            modelo = "Gol",
            ano = 2020
        };


    }
}