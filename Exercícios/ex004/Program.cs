class Program {

    public static void Main()
    {
        //Chamar e Receber valor do método Dobro
        int valorDigitado = int.Parse(Console.ReadLine());
        int resultadoDobro = Dobro(valorDigitado);
        //Exibir o valor da variavel
        Console.WriteLine($"O dobro de {valorDigitado} é {resultadoDobro}" );

        int resultadoMetade = Metade(valorDigitado);
        //Exibir o valor da variavel
        Console.WriteLine($"A metade de {valorDigitado} é {resultadoMetade}" );


        //Chamando método tabuada
        Tabuada(valorDigitado);

        ResumoSalarios();
    }

    public static int Dobro( int valor )
    {
        //Criar variável para calcular o dobro
        int resultado = valor * 2;
        //Retornar o valor da função
        return resultado;
    }
    public static int Metade( int valor )
    {
        //Criar variável para calcular o metade
        int resultado = valor / 2;
        //Retornar o valor da função
        return resultado;
    }

    public static void Tabuada(int valor)
    {
        int contador = 1;

        while(contador <= 1000)
        {
            Console.WriteLine($"{valor} x {contador} = {valor * contador}");
            contador++;
        }
    }

    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;
        do {
            Console.WriteLine("Digite o salário do empregado:");
            salarioEmpregado = int.Parse(Console.ReadLine());
            
            if (salarioEmpregado > 0)
                somaSalarios = somaSalarios + salarioEmpregado;

            //somaSalarios += salarioEmpregado;
            if (salarioEmpregado > maiorSalario){
                maiorSalario = salarioEmpregado;
            }
            if(salarioEmpregado < menorSalario && salarioEmpregado > 0){
                menorSalario = salarioEmpregado;
            }                               
        } while (salarioEmpregado > 0);
        Console.WriteLine($"A soma dos salários é {somaSalarios} o maior salário é {maiorSalario} e o menor salário é {menorSalario}");
    }

}