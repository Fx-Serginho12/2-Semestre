//O namespace é um nome em que usaremos para fazer referência quando usarmos
namespace Sesi.Model
{
    //Declarando a classe Aluno
    public class Aluno
    {
        //Declarando os atributos (propriedades) de classe Aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }
        
        //Declarando um atrinuto privado
        private int nrFaltas { get; set; }

        //Criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos, estudo na turma {turma} e tenho {nrFaltas} faltas");
        }
        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"Olá, meu nome é {nome} faltou hoje e somou {nrFaltas}");
            nrFaltas = nrFaltas +  nr;
        }

        //Método ResumoFaltas
        public void ResumoFaltas()
        {
            Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas");
        }

    }
}