using Models;

public class Program
{
    public static void Main()
    {
        ContaCorrente conta = new ContaCorrente("sergio", 0);
        
        string opcao = "";

        do {
            Console.WriteLine("1- Consultar saldo ");
            Console.WriteLine("2- Depositar");
            Console.WriteLine("3- Sacar");
            Console.WriteLine("0- Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao){
                case "0":
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    conta.ConsultarSaldo();
                    break;
                case "2":
                    //Depositar();
                    Console.WriteLine("Qual valor vc quer colocar");
                    decimal valorDep = decimal.Parse(Console.ReadLine());
                    conta.Depositar(valorDep);
                    break;
                case "3":
                    //Sacar();
                    decimal valorSaque = decimal.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;
            }
        }  while (opcao != "0");

    }
}