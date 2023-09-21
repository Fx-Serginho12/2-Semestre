//Classe Pai que será herdada - SuperClasse
abstract class Animal
{
    public string cor { get; set; }
    public virtual void EmitirSom();
}

//Classe filha que herdará da classe Animal
class  Cachorro : Animal
{
    //Sobre escrevendo o mètodo EmitirSom
    public override void EmitirSom()
    {
        Console.Write($"Cachorro da cor {cor} está latindo! Au au au");
    }
}

class Gato : Animal
{
     //Sobre escrevendo o mètodo EmitirSom
    public override void EmitirSom()
    {
        Console.Write($"Gato da cor {cor} está  Miando! Miau miau");
    }

    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando!");
    }
}

class Program
{
    public static void Main()
    {
        /*
        //Não é permitido criar um objeto de uma classe abstrata
        //Só conseguimos criar de sua classe derivada
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        */
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        //meuCachorro.Ronronar(); //Não posso chamar este método poi não existe nessa classe
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}