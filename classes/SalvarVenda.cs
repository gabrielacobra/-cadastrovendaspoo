using System;
using System.IO;

namespace CadastroVendaPoo.classes{
    public class SalvarVenda{
        
        public string Salvar(Venda venda){
            string msg="";
            StreamWriter arquivo=null;
            try{
                arquivo = new StreamWriter("cadVenda.csv",true);
                arquivo.WriteLine(venda.Cpf+";"+venda.Id+";"+venda.DataVenda);
                msg = "Cadastro de Venda salvo :)";                
            }
            catch(Exception ex){
                msg = "Erro ao cadastrar a venda :( "+ex.Message;
            }
            finally{
                arquivo.Close();
            }
            return msg;
            
        }
    }
}