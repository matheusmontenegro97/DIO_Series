using System;

namespace DIO.Serie
{
    public class Serie : EntidadeBase
    {
        // Atributos 

        private Genero Genero {get; set; }

        private String Titulo {get; set;}

        private String Descricao {get; set;}

        private int Ano {get; set;}

        private bool Excluido {get; set;}

        //Metódos

        public Serie(int id, genero genero, string titulo, int ano, string descricao, bool excluido ){

            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Ano = ano; 
            this.Descricao = descricao;
            this.Excluido = false;
        }

        public override string ToString() {
            string retorno = "";
            retorno += "Gênero " + this.Genero + Environment.NewLine;
            retorno += "Título " + this.Titulo + Environment.NewLine;
            retorno += "Descrição " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Enviroment.NewLine;
            retorno += "Excluído " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo(){
            return this.Titulo;
        }

        public int retornaId(){
            return this.Id;
        }

        public bool retornaExcluido(){
            return this.Excluido;
        }

        public void Exclui(){
            this.Excluido = true;
        }
    }
}