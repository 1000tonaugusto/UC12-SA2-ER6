using System.Text.RegularExpressions;
using er6.Interfaces;

namespace er6.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        // Atributos
        public string ?cnpj {get; set;}

        public string ?razaoSocial {get; set;}

        // Metodos
        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000) {
                return (rendimento / 100) * 3;
            } else if (rendimento<=6000) {
                return (rendimento / 100) * 5;
            } else if (rendimento <= 10000) {
                return (rendimento / 100) * 7;
            } else {
                return (rendimento / 100) * 9;
            }
        }

        public bool validarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}/.\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11,4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Substring(8,4) == "0001")
                {
                    if (cnpj.Substring(8,4) == "0001")
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        public bool ValidarCnpj2(string cnpj)
        {
           string cnpjTratado =  cnpj.Replace(".","").Replace("/","").Replace("-","");

           if (cnpjTratado.Substring(8,4) == "0001")
           {
               return true;
           }
           return false;
        }
    }
}