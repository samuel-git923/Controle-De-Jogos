using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeJogos
{
    public enum TipoGenero { Acao, Aventura, Casual, Puzzle, Estrategia, Outro }
    public enum TipoConsole { PS4, PS5, Switch, Xbox_360, Xbox_One, PC, Outro }
    
    public class Jogo
    {

        public Jogo()
        {
            this.Id = 1;
            this.Nome = "";
            this.Descricao = "";
            this.Genero = TipoGenero.Outro;
            this.Console = TipoConsole.Outro;
        }

        public Jogo(int id, String nome, String descricao, TipoGenero genero, TipoConsole console)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Genero = genero;
            this.Console = console;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set 
            {
                if (value > 0) id = value;
                else
                {
                    throw new Exception("Permitido apenas número positivos!");
                }
            }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        private String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value.ToUpper(); }
        }

        public TipoConsole Console { get; set; }
        public TipoGenero Genero { get; set; }
    }
}
