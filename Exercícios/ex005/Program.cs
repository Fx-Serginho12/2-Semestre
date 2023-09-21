class ex005
{
    public static void Main()
 {
    ListaDoChurrasco(); 
    SonhosDeConsumo();  
 }

 public static void ListaDoChurrasco()
    {
     string[] ListaProdutos= new string[6];

     ListaProdutos[0] = "Carne 3kg";
     ListaProdutos[1] = "Coca-Cola";
     ListaProdutos[2] = "Pão de Alho";
     ListaProdutos[3] = "linguiça";
     ListaProdutos[4] = "Cupin 3kg";
     ListaProdutos[5] = "Molho";

     for (int i = 0; i < ListaProdutos.Length; i++)
        {
         Console.WriteLine("Informe o produto:");
            string produto = Console.ReadLine();
            ListaProdutos[i] = produto;
        }
        Array.Sort(ListaProdutos);

        foreach (string item in ListaProdutos)
        {
            Console.WriteLine($"Item {item}");
        }
    }
  public static void SonhosDeConsumo(){
    string[] ListaSonho= new string[3];
    int[] valorSonho = new int[3];
    int soma = 0;

    for (int i = 0; i < ListaSonho.Length; i++)
    {
     Console.WriteLine("Informe o sonho:");
        string sonho = Console.ReadLine();
        ListaSonho[i] = sonho;   
    }
        

   foreach (string item in ListaSonho)
   {
     soma =+ item.Length;
   }
   

    Console.WriteLine ($"Seus sonhos custarão R$ {soma}");
  }
 }
