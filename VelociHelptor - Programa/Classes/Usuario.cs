using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace VelociHelptor
{
    class Usuario // Classe com as definiçoes do objeto Usuário.
    {
        
        private Tipo Tipo { get; set; } //Opção por tipo de usuário
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Senha { get; set; }


        public Usuario (Tipo Tipo,  string Nome, string Email, string Senha) 
        {
            this.Tipo = Tipo;
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
            
        }

        public override string ToString()   // Criado para sobscrever o ToString da classe mãe, para ser possível a leitura no console.
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Email: " + this.Email + " | ";
            retorno += "Tipo: " + this.Tipo + " | ";
            return retorno;
        }



    }
}
