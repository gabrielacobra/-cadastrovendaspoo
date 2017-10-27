using System;
using CadastroVendaPoo.classes;

namespace CadastroVendaPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*                                   *");
            Console.WriteLine("*       Programa de Vendas          *");
            Console.WriteLine("*                                   *");
            Console.WriteLine("*************************************");

            int opcao=0;
            while(opcao!=9){ //opcao é o que o cliente irá digitar, para sabermos o que ele digitou. Deve começar com alguma coisa para iniciar o laço
                
                Console.WriteLine("Digite: \n1-Cadastro de Cliente\n2-Cadastro de Produto\n3-Cadastro de Venda\n4-Extrato do Cliente\n9-Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao){
                    case 1:
                    Console.WriteLine("Digite o nome do cliente:");
                    string nome = Console.ReadLine();
                    
                    Console.WriteLine("Digite o email do cliente");
                    string email = Console.ReadLine();

                    Console.WriteLine("Digite o cpf do cliente:");
                    string cpf = Console.ReadLine();

                    Cliente cl = new Cliente(nome,email,cpf,DateTime.Now.Date);
                    SalvarCliente sc = new SalvarCliente(); //ou Console.WriteLine(new SalvarCliente().Salvar(cl));   Instanciando
                    Console.WriteLine(sc.Salvar(cl));
                    break;

                    case 2:
                    Console.WriteLine("Digite o id do produto:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do produto:");
                    string nomeproduto = Console.ReadLine();

                    Console.WriteLine("Digite a descrição do produto:");
                    string descricao = Console.ReadLine();

                    Console.WriteLine("Digite o preço do produto:");
                    double preco = double.Parse(Console.ReadLine());

                    Produto pr = new Produto (id,nomeproduto,descricao,preco);
                    SalvarProduto sp = new SalvarProduto();
                    Console.WriteLine(sp.Salvar(pr));
                    break;
                  



                }
            }
        }
    }
}
