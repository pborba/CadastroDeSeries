using CadastroDeSeries.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroDeSeries.Classes
{
    public class Serie : EntidadeBase
    {

        public Genero Genero{ get; set; }

        public string Titulo  { get; set; }

        public string Descricao { get; set; }

        public int Ano  { get; set; }
        public bool Excluido;

        public Serie(int Id, string Titulo, Genero Genero, string Descricao, int Ano)
        {
            this.Id = Id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            Excluido = false;
        }

        override
        public string ToString()
        {
            StringBuilder strb = new StringBuilder();
            strb.Append($"Id: {Id}");
            strb.Append(" | ");
            strb.Append($"Titulo: {Titulo}");
            strb.Append(" | ");
            var enumGenero = (string)System.Enum.GetName(typeof(Genero), Genero);
            strb.Append($"Gênero: {enumGenero}");
            strb.Append(" | ");
            strb.Append($"Descrição: {Descricao}");
            strb.Append(" | ");
            strb.Append($"Ano: {Ano}");
            strb.Append(" | ");


            return strb.ToString();
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}
