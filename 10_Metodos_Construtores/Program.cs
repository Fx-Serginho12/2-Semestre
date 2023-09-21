using Models;

public class Program
{
    public static void Main()
    {
        //Criar um objeto da classe Pessoa
        /*
        Instanciando objeto sem método construtor
        var pessoa1 = new Pessoa();
        pessoa1.nome = "Adalberto";
        pessoa1.idade = 16;

        //Alternativa de um objeto instanciado sem construtor
        Pessoa pessoa1 = new Pessoa {
            nome = "Douglas",
            idade = 28
        }
        */
        
        //Instanciando um objeto com método construtor
        Pessoa pessoa1 = new Pessoa("Alberto Robeto", 16);
        Pessoa pessoa2 = new Pessoa("Ricardo", 17);
        Pessoa pessoa3 = new Pessoa("Alice", 9);

       //Chamando o método Cantar da classe Pessoa
        pessoa1.Cantar();
        pessoa2.Cantar();
        pessoa3.Cantar();
    }
}