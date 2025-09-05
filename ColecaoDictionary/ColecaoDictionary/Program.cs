namespace ColecaoDictionary;


public class Produto
{
    public string NomeProduto { get; set; }
    public int Id { get; set; }
    public double Preco { get; set; }
}


public class Program
{
    static void Main(string[] args)
    {
        //Criando um Dictionary, sintaxe

        Dictionary<string, string> cadastro = new Dictionary<string, string>(); //Aqui temos a chave e o valor
        
        //Adicionando itens 
        
        //O "nome" é a chave onde poderei acessar
        cadastro.Add("Luan Oliveira", "167.959.502-81");
        cadastro.Add("Felipe Souza", "983.331.551-09");
        cadastro.Add("Anderson Morias", "551.867.981-57");
        cadastro.Add("Luis Augsuto", "157.157.123.60");
        cadastro.Add("Rafael", "887.554.112-91");
        
        
        //Mostrando todos os dados
        Console.WriteLine("=====================PESSOAS CADASTRADAS NO SISTEMA=====================");
        foreach (var pessoas in cadastro)
        {
            Console.WriteLine($"Nome: {pessoas.Key}, CPF: {pessoas.Value}");
        }
        
        
        //----------Usando dictionary com outra classe, tipo o Produto----------//

        Dictionary<int, Produto> catalogoProdutos = new Dictionary<int, Produto>();
        
        catalogoProdutos.Add(101, new Produto { Id = 101, NomeProduto = "Lâmpada LED", Preco = 15.50 });
        catalogoProdutos.Add(102, new Produto{ Id = 102, NomeProduto = "Mouse guamer", Preco = 250.00});
    }
}