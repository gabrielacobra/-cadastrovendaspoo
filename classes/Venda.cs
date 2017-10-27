using System;

namespace CadastroVendaPoo.classes{

    /// <summary>
    /// Esta classe fornece dados da venda
    /// </summary>
    public class Venda{
        private string cpf;
        private int id;
        private DateTime datavenda;
    
    /// <summary>
    /// Esta classe constroi o objeto venda
    /// </summary>
    public Venda() {}

    /// <summary>
    /// Esta classe constroi o objeto venda e é necessário imputar como parâmetros
    /// </summary>
    /// <param name="cpf">CPF como número</param>
    /// <param name="id">Id  como número</param>
    /// <param name="datavenda">data como data</param>
    public Venda(string cpf, int id, DateTime datavenda){
        this.cpf=cpf;
        this.id=id;
        this.datavenda=datavenda;        
    }
    public string Cpf { get{return cpf;} set{cpf=value;} }
    public int Id { get{return id;} set{id=value;} }
    public DateTime DataVenda { get{return datavenda;} set{datavenda=value;} }
    }
}