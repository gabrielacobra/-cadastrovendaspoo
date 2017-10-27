namespace CadastroVendaPoo.classes{
    /// <summary>
    /// Esta classe fornece informações sobre os dados do produto
    /// </summary>
    public class Produto{
        private int id;
        private string nomeproduto;
        private string descricao;
        private double preco;

        /// <summary>
        /// Esta classe constroi o objeto produto
        /// </summary>
        
        public Produto(){}
                 
        /// <summary>
        /// Esta classe constroi o objeto e é necessário imputar os dados como parâmetros
        /// </summary>
        /// <param name="id">Informe o Id como número (int)</param>
        /// <param name="nomeproduto">Informe o nome do produto como texto</param>
        /// <param name="descricao">Informe a descrição como texto</param>
        /// <param name="preco">Informe o texto como número (double)</param>
        public Produto (int id, string nomeproduto, string descricao, double preco)
        {
            this.id=id;
            this.nomeproduto=nomeproduto;
            this.descricao=descricao;
            this.preco=preco;            
        }

        public int Id { get{return id;} set{id=value;} }
        public string NomeProduto { get{return nomeproduto;} set{nomeproduto=value;} }
        public string Descricao { get{return descricao;} set{descricao=value;} }
        public double Preco { get{return preco;} set{preco=value;} }
    }
}