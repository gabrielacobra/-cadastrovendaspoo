using System;

namespace CadastroVendaPoo.classes{
    /// <summary>
    /// A classe Cliente possui informações sobre os dados do cliente
    /// </summary>
    public class Cliente{
        private string nome;
        private string email;
        private string cpf;
        private DateTime datacadastro;
        
        /// <summary>
        /// Constroi o objeto cliente
        /// </summary>

        public Cliente()
        {
            
        }

        /// <summary>
        /// Constroi o objeto cliente e você precisa passar os dados como parâmetros
        /// </summary>
        /// <param name="nome">Informe o nome como texto (String)</param>
        /// <param name="email">Informe o email como texto (String)</param>
        /// <param name="cpf">Informe o cpf como texto (String)</param>
        /// <param name="datacadastro">Informe o nome como DateTime</param>
        public Cliente(string nome, string email, string cpf, DateTime datacadastro)
        {
            this.nome=nome;
            this.email=email;
            this.cpf=cpf;
            this.datacadastro=datacadastro;            
        }
        public string Nome { get{return nome;} set{nome=value;} }
        public string Email { get{return email;} set{email=value;} }
        public string Cpf { get{return cpf;} set{cpf=value;} }
        public DateTime DataCadastro {get{return datacadastro;} set{datacadastro=value;}}
        
    }
}