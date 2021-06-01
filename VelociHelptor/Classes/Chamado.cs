using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace VelociHelptor
{
    class Chamado  // Classe com as definiçoes do objeto Chamado.
    {
       private StatusChamado StatusChamado { get; set; }       
       private string Titulo { get; set; }
       private string Descricao { get;set; }
       private Prioridade Prioridade { get; set; }
       public string Usuario; 


        public Chamado (StatusChamado StatusChamado,  string Titulo, string Descricao, Prioridade Prioridade, string Usuario)
        {
            this.StatusChamado = StatusChamado;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Prioridade = Prioridade;
            this.Usuario = Usuario;
        }

        public override string ToString()
        {
            // Environment.NewLine - verificar explicação no site da microsoft
            string retorno = "";
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Status: " + this.StatusChamado + Environment.NewLine;
            retorno += "Usuario: " + this.Usuario + Environment.NewLine;
          

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

       

       

    }
}
