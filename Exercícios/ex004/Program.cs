class Matematica
{
    public static void Main()
    {
        int dobro = Dobro(5);
        Console.WriteLine(dobro);

        int metade = Metade(8);
        Console.WriteLine(metade);
        Tabuada(2);
        Soma();
    }

     public static int Dobro(int n1)
    {
        int resultado = n1 * 2;
        return resultado;
    }
    
    public static int Metade(int n1)
    {
        int resultado = n1 / 2;
        return resultado;
    }

     public static void Tabuada(int n)
    {
        int num = 5;
        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine($"{contador}º execução: {num} x {contador} = {num * contador}");
            contador++;
        }
    }
     public static void Soma()
    {
        int contador = 0;
        int maior = 0;
        int menor = 0;
        int soma = 0;

        do{
            //ler um valor, digitado pelo usuario e atribui em uma variavel
         Console.WriteLine("Digite um nº");
         contador = int.Parse(Console.ReadLine());
            //Se o numero digitado for maior que "maior" o maior vai receber o valor do numero digitado
            if (contador > maior)
            Console.WriteLine(maior = contador);

            if(contador < menor && contador > 0)
            menor = contador;

            if (contador > 0)
            soma = soma + contador;

            


         } while (contador > 0);
         Console.WriteLine($" Maior  Nº {maior} e  Menor Nº {menor} e a Soma Nº {soma}");
            //mostrar maior
            //mostrar menor
    }
}
