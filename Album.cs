﻿class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public int DuracaoTotal => musicas.Sum(item => item.Duracao);

    public void AdcionarMusica(Musica teste)
    {
        musicas.Add( teste );

    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        Console.WriteLine($"Para ouvir este álbum inteiro você precisa de {DuracaoTotal}\n");
        foreach (var musica in musicas) 
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
    }
}