using System;
using System.IO;

namespace CadastroVendaPoo.classes{
    public class SalvarProduto{
        public string Salvar(Produto produto){
            string msg="";
            StreamWriter arquivo =null;
            try{
                arquivo=new StreamWriter("cadProduto.csv",true);
                arquivo.WriteLine(produto.Id+";"+produto.NomeProduto+";"+produto.Descricao+";"+produto.Preco);
                msg="Produto salvo com sucesso :)";
            }
            catch(Exception ex){
                msg="Erro ao cadastrar produto :( "+ex.Message;
            }
            finally{
                arquivo.Close();
            }

            return msg;

            
        }
    }
}