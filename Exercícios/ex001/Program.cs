Console.WriteLine("Informe o nome do aluno: ");
string aluno = Console.ReadLine();

Console.WriteLine("Digite a Nota1:");
int Nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a Nota2:");
int Nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a Nota3:");
int Nota3 = int.Parse(Console.ReadLine());
int media = (Nota1 + Nota2 + Nota3) / 3;

if (media >= 7){
    Console.WriteLine("Foi aprovado");
}else {
    Console.WriteLine("Não foi aprovado");
}

string aprovado = (media >= 7) ? "Aprovado" : "Reprovado";