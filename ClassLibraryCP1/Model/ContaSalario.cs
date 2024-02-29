using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP1.Model
{
    public class ContaSalario : Conta
    {
        private string EmpresaPagante;

        // ---- CONSTRUTORES ---- //

        public ContaSalario()
        {

        }

        public override void ExibirConta()
        {
            base.ExibirConta();

            Console.WriteLine($"Empresa pagante: {EmpresaPagante}");
        }

        public ContaSalario(string EmpresaPagante)
        {
            this.EmpresaPagante = EmpresaPagante;
        }

        public string GetEmpresaPagante()
        {
            return EmpresaPagante;
        }

        public void SetEmpresaPagante(string EmpresaPagante)
        {
            this.EmpresaPagante = EmpresaPagante;
        }
    }
}
