Select Nome, Ano from Filmes

Select Nome, Ano, Duracao from Filmes order by Ano 

Select Nome, Ano, Duracao from Filmes where Nome = 'De Volta para o Futuro'

Select Nome, Ano, Duracao from Filmes where Ano = 1997

Select Nome, Ano, Duracao from Filmes where Ano > 2000

Select Nome, Ano, Duracao from Filmes where Duracao > 100 
and Duracao < 150 order by Duracao

Select Ano, count(*) as Quantidade from Filmes group by Ano order by Quantidade desc

Select * from Atores where Genero = 'M'

Select * from Atores where Genero = 'F' order by PrimeiroNome

Select f.Nome, g.Genero from Filmes f INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON g.Id = fg.IdGenero

Select f.Nome, g.Genero from Filmes f INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON g.Id = fg.IdGenero AND g.Genero ='Mistério'

Select f.Nome, a.PrimeiroNome, a.UltimoNome, ef.Papel 
from Filmes f INNER JOIN ElencoFilme ef ON f.Id = ef.IdFilme
INNER JOIN Atores a ON a.Id = ef.IdAtor 