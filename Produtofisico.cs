using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


[System.Serializable] //diz ao c# que esse tipo de dado pode ser salvo em arquivos
class Produtofisico : Produto, IEstoque
{
    public float frete;
    private int estoque;

    public Produtofisico(string nome, float preco, float frete)
    {
        this.nome = nome;
        this.preco = preco;
        this.frete = frete;
    }

    public void AdicionarEntrada()
    {
        Console.WriteLine($"Adicionar entrada no estoque do produto {nome}");
        Console.WriteLine("Digite a quantidade que você quer dar entrada: ");
        int entrada = int.Parse(Console.ReadLine());
        estoque += entrada;
        Console.WriteLine("Entrada registrada");
        Console.ReadLine();
    }
    public void AdicionarSaida()
    {
        Console.WriteLine($"Adicionar saida no estoque do produto {nome}");
        Console.WriteLine("Digite a quantidade que você quer dar baixa: ");
        int saida = int.Parse(Console.ReadLine());
        estoque -= saida;
        Console.WriteLine("Saida registrada");
        Console.ReadLine();
    }
    public void Exibir()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Frete: {frete}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Estoque: {estoque}");
        Console.WriteLine("==========================");
    }
}
