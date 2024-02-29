using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP1.Model
{
    public class ContaPoupanca : Conta
    {
        private double rentabilidade;

        // ---- CONSTRUTORES ---- //

        public ContaPoupanca()
        {

        }

        public override void ExibirConta()
        {
            base.ExibirConta();

            Console.WriteLine($"Rentabilidade: {rentabilidade}");
        }

        public ContaPoupanca(double rentabilidade)
        {
            this.rentabilidade = rentabilidade;
        }

        public double GetRentabilidade()
        {
            return rentabilidade;
        }

        public void SetRentabilidade(double rentabilidade)
        {
            this.rentabilidade = rentabilidade;
        }


    }
}
