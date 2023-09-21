public class Program
{
    public static void Main()
    {
        var pessoa1 = new {nome = "João", idade = 20};
        var pessoa2 = new {nome = "Maria", idade = 17};
         
         Console.WriteLine($"A Pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");
        
        var carro1 = new {
            marca = Console.ReadLine(),
            modelo = Console.ReadLine(),
            ano = Console.ReadLine()   
        };
        var carro2 = new {
            marca = Console.ReadLine(),
            modelo = Console.ReadLine(),
            ano = Console.ReadLine()   
        };
        Console.WriteLine($"O carro 1 tem a marca {carro1.marca} modelo {carro1.modelo} e o ano {carro1.ano}  e o carro 2 tem a marca {carro2.marca}  modelo {carro2.modelo} e o ano {carro2.ano}");
    }
}