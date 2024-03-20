//Banda queen = new Banda("Queen");

//Album albumDoQueen = new Album("a night at the opera");

//Musica musica1 = new Musica(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

// albumDoQueen.AdcionarMusica(musica1);
// albumDoQueen.AdcionarMusica(musica2);
// albumDoQueen.ExibirMusicasDoAlbum();


// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();

// queen.AdcionarAlbum(albumDoQueen);
// queen.ExibirDiscografia();



Episodio ep1 = new Episodio(2, "Tecnica", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Mario");


Episodio ep2 = new Episodio(1, "Eva", 67);
ep2.AdicionarConvidados("soneka");
ep2.AdicionarConvidados("Rei");

Episodio ep3 = new Episodio(3, "Evangelion", 67);
ep3.AdicionarConvidados("Asuka");
ep3.AdicionarConvidados("ayanami");


Podcast podcast = new Podcast("Henrique", "Estudos");

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);

podcast.ExibirDetalhes();
