class Podcast
{

    private List<Episodio> episodioList = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get;  }
    public int TotalEpisodios => episodioList.Count;


    public void AdicionarEpisodio(Episodio item)
    {
        episodioList.Add(item);
    }

    public void ExibirDetalhes()  
    {
        Console.WriteLine($"Podcast {Nome} com o Host ${Host}\n");
        Console.WriteLine($"Com total de {TotalEpisodios} episodios\n");
        Console.WriteLine("Lista de episodios abaixo \n");
        foreach(Episodio item in episodioList.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"{item.Resumo} \n");

        }
    
    }
}