using System;
using System.IO;

namespace CadastroVendaPoo.classes{
    public class SalvarCliente{
        public string Salvar(Cliente cliente){
            string msg =""; //variável criada para auxiliar no retorno da mensagem do try catch
            StreamWriter arquivo=null;
            try{
              if(cpfValido(cliente.Cpf)){     //se o CPF for válido, abre o arquivo de texto ou cria um com os dados do clietne e msg de criado com sucesso
                arquivo=new StreamWriter("cadClientes.csv",true);
                arquivo.WriteLine(cliente.Nome+";"+cliente.Email+";"+cliente.Cpf+";"+cliente.DataCadastro);
                msg="Cliente salvo com sucesso :)";
            }

            else{
                msg="CPF inválido :(";
            }
        }
        catch(Exception ex){ //caso não der certo em salvar o arquivo, cai no exception
            msg="Erro ao tentar gravar o arquivo"+ex.Message;
        }
        finally{
            arquivo.Close();
        }
        return msg;

        }

        private bool cpfValido(string cpfUsuario){
           bool retorno = true;
           
           string cpfCalculo = "";

           int[] v1 = {10,9,8,7,6,5,4,3,2};
           int[] v2 = {11,10,9,8,7,6,5,4,3,2};

           int resultado = 0;
           int resto = 0;

          
           cpfCalculo = cpfUsuario.Substring(0,9);

           for(int i = 0; i < cpfCalculo.Length; i++){
               resultado+= Int16.Parse(cpfCalculo[i].ToString())*v1[i];
           }

           resto = resultado % 11;
           if(resto < 2)
            cpfCalculo+="0";
            else
            cpfCalculo+=(11-resto).ToString();

            resultado = 0;
            
            for(int i = 0; i < cpfCalculo.Length; i++){
               resultado+= Int16.Parse(cpfCalculo[i].ToString())*v2[i];
           }

           resto = resultado % 11;
           if(resto < 2)
            cpfCalculo+="0";
            else
            cpfCalculo+=(11-resto).ToString();

            if(cpfUsuario!=cpfCalculo)
                retorno = false;
            
            return retorno;

        }
    }
}