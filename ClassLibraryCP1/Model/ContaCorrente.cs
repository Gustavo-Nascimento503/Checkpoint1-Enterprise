using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP1.Model
{
    public class ContaCorrente : Conta
    {
        private double checkEspecial;

        // ---- CONSTRUTOR ---- //

        public ContaCorrente()
        {

        }

        public override void ExibirConta()
        {
            base.ExibirConta(); 

            Console.WriteLine($"Cheque Especial: {checkEspecial}");
        }

        public ContaCorrente(double checkEspecial)
        {
            this.checkEspecial = checkEspecial;
        }

        public double GetCheckEspecial()
        {
            return checkEspecial;
        }

        public void SetCheckEspecial(double checkEspecial)
        {
            this.checkEspecial = checkEspecial;
        }

    }
}
