# TRABALHO 18

### Xadrez

Xadrez � um jogo de tabuleiro, 8x8, onde cada um dos jogadores inicia a partida com 16 pe�as. Detalhes em http://en.wikipedia.org/wiki/Chess. Neste exerc�cio, modele o jogo empregando a UML.

Algumas classes candidatas facilmente podem ser identificadas. Tabuleiro, para representar o tabuleiro em determinado instante de tempo. Ou seja, dado um instante de tempo de uma partida (jogo), h� uma configura��o do tabuleiro que ser� representada por Tabuleiro. Ou seja, uma partida ou jogo ser� definida por uma sequ�ncia de inst�ncias de Tabuleiro, conforme abaixo.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-06/mod06ima01/mod06ima01.plantuml)

Esta n�o parece uma modelagem apropriada, afinal, muitos interpretam uma Partida como uma sequ�ncia de lances, onde cada lance define uma pe�a que se desloca de uma posi��o de origem para uma posi��o de destino, al�m de ser realizado por um jogador, conforme abaixo.


![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-06/mod06ima02/mod06ima02.plantuml)

A posi��o pode ser definida por um esquema de coordenadas x e y. Neste modelo falta ressaltar que a composi��o de lances forma uma sequ�ncia. Nesta modelagem observe que n�o se faz necess�rio a entidade que represente um tabuleiro (recurso apenas visual empregado pela interface gr�fica).

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-06/mod06ima03/mod06ima03.plantuml)
