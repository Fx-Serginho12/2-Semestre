namespace Models
{
     public class ContaCorrente
    {
         private string titular { get; set; }
        private decimal saldo { get; set; }
    
         public ContaCorrente (string titular, int saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"{saldo} está cantando");
        }

        public void Depositar(decimal valor)
        {
          saldo = saldo + valor;
        }
        public void Sacar( decimal valor){
            saldo = saldo - valor;
        }
    
    }
    
       
}