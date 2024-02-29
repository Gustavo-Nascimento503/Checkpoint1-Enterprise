using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP1.Model
{
    public class ContaConjunta : Conta
    {
        private string titularSecundario;

        // ---- CONSTRUTORES ---- //

        public ContaConjunta()
        {

        }

        public void Exemplo(double taxa)
        {

            AplicarJuros(taxa);
        }

        public override void ExibirConta()
        {
            base.ExibirConta();

            Console.WriteLine($"Titular secundario: {titularSecundario}");
        }

        public ContaConjunta(string titularSecundario)
        {
            this.titularSecundario = titularSecundario;
        }

        public string GetTitularSecundario()
        {
            return titularSecundario;
        }

        public void SetTitularSecundario(string titularSecundario)
        {
            this.titularSecundario = titularSecundario;
        }
    }


}
