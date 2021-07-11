namespace series
{
    public class Serie: entidadebase
    {
        //Atributos

        private Genero Genero {get; set; }

        private string Titulo {get; set; }

        private string Descricao {get; set; }

        private int Ano {get; set; }

        private bool Excluido {get; set;}

        //Métodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)

        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;

        }
        
        public override string ToString ()
        {
        
        string retorno = "";
        retorno += "Genero: " + this.Genero;
        retorno += "Titulo: " + this.Titulo;
        retorno += "Descricao: " + this.Descricao;
        retorno += "Ano de inicio: " + this.Ano;
        retorno += "Excluido: " + this.Excluido;
        return retorno;

        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaid()
        {
            return this.id;
        }
         public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir()
        {
            this.Excluido = true;
        }


    }
}