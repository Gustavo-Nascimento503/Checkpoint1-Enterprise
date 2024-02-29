namespace ClassLibraryCP1.Model
{
    public class Conta
    {
        private string titular;
        private string numero;
        private double saldo;
        private string agencia;

        // --------- CONSTRUTORES DA CLASSE CONTA --------- //

        public Conta(string titular, string numero, double saldo, string agencia)
        {
            this.titular = titular;
            this.numero = numero;
            this.saldo = saldo;
            this.agencia = agencia;
        }

        public Conta() : this("", "0001", 0.0, "0001")
        {

        }

        // ------------ MÉTODOS DA CLASSE CONTA ------------ //

        public virtual void ExibirConta()
        {
            Console.WriteLine($"\nTitular: {titular}");
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Agência: {agencia}");
        }

        public virtual double CalcularRendimento()
        {
            return 0;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
        }

        // Método privado


        private double CalcularImposto(double taxaImposto)
        {
            return saldo * taxaImposto;
        }

        // Método para aplicar o imposto sem alterar o saldo
        public void AplicarImposto(double taxaImposto)
        {
            double imposto = CalcularImposto(taxaImposto);
            Console.WriteLine($"Imposto calculado: {imposto:C}");
        }

        // Método protected
        protected void AplicarJuros(double taxa)
        {
            saldo *= (1 - taxa);
        }

        public void juros(double taxa)
        {
            
            AplicarJuros(taxa);
        }

        // Método internal
        internal void SacarComVerificacao(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
        }

        // ----------------- GETTERS AND SETTERS ----------------- //

        public string GetTitular()
        {
            return titular;
        }

        public void SetTitular(string titular)
        {
            this.titular = titular;
        }

        public string GetNumero()
        {
            return numero;
        }

        public void SetNumero(string numero)
        {
            this.numero = numero;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public string GetAgencia()
        {
            return agencia;
        }

        public void SetAgencia(string agencia)
        {
            this.agencia = agencia;
        }

    }
}
