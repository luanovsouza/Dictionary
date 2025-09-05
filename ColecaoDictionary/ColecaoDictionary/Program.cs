namespace ColecaoDictionary;

public class Program
{
    static void Main(string[] args)
    {
        //Criando um Dictionary, sintaxe

        Dictionary<string, string> cadastro = new Dictionary<string, string>(); //Aqui temos a chave e o valor
        
        //Adicionando itens 
        
        //O "nome" é a chave onde poderei acessar
        cadastro.Add("Luan Oliveira", "167.959.502.81");
        cadastro.Add("Felipe Souza", "983.331.551-09");
        cadastro.Add("Anderson Morias", "551.867.981-57");
        cadastro.Add("Luis Augsuto", "157.157.123.60");
        cadastro.Add("Rafael", "887.554.112-91");
        
    }
}