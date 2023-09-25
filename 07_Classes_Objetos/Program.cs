//Sempre que formos utilizar bibliotecas ou classes já criadas
//importamos ela com o using
using Sesi.Model;

class Program 
{
    public static void Main()
    {
        //Criando uma variável aluno1 e instanciando da classe Aluno
        //Ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Douglas";
        aluno1.idade = 35;
        aluno1.turma = "2º EM";
        //Chamando o método da classe Aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();

        var aluno2 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno1
        aluno2.nome = "Ricardo";
        aluno2.idade = 34;
        aluno2.turma = "1º EM";
        //Chamando o método da classe Aluno
        aluno2.Apresentar();




    }
}