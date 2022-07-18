using System.Globalization;

namespace ExcPropArquivos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }

        public Product(string name, double precoUnitario, int quantidade)
        {
            Name = name;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        public double valorTotal()
        {
            return PrecoUnitario * Quantidade;
        }
    }
}
/*
 *ler o caminho de um arquivo .csv contendo dados de itens vendidos
 *itens tem: nome, preço unitario, quantidade, separados por virgula
 *gerar novo arquivo chamado "summary.csv" 
 *localizado numa supasta chamada out a partir da pasta original do arq. de origem
 *contendo apenas nome e valor total para aquele item(preço * qtd) 
 *
 *
 */
