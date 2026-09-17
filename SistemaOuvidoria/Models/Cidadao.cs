using System;

namespace SistemaOuvidoria.Models
{
    internal class Cidadao
    {
        private string _nome;
        private string _cpf;
        private string _email;

        public Cidadao()
        {
        }

        public Cidadao(string nome, string cpf, string email)
        {
            _nome = nome;
            _cpf = cpf;
            _email = email;
        }

        public bool ValidarCpf(string _cpf)
        {
            string cpfLimpo = _cpf.Replace(".", "").Replace("-", "");

            if (cpfLimpo.Length != 11)
            {
                return false;
            }
            else 
            {
                return true;
            }     
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
            
        }

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
            
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
            
        }
    }
}
