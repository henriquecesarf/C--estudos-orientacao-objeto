﻿class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }


    public int Ordem { get;  }
    public string Titulo { get; }
    public int Duracao { get; set; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(",", convidados)}";




    public void AdicionarConvidados(string item)
    {
        convidados.Add(item);
    }




}