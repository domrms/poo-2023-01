# TRABALHO 11

### ORGANIZA��O DAS PASTAS POR C�DIGO DE ACORDO COM AS ATIVIDADES

### t11.01

### Uma casa compreende quartos, banheiros, salas, �reas e garagens.

O diagrama abaixo n�o apresenta as cardinalidades nos extremos das agrega��es, o que pode n�o ser suficientemente preciso em alguns casos. Por exemplo, o diagrama admite uma casa que n�o possui quartos, banheiros e assim por diante. Se o correto � que uma casa possui pelo menos um quarto, por exemplo, ent�o a cardinalidade 1..\* deveria ser empregado do lado da classe Quarto. Ainda conv�m ressaltar que o pr�prio verbo �compreender�, empregado na descri��o do dom�nio, ressalta a rela��o do tipo todo/parte. Para tal tipo de rela��o h� duas op��es: agrega��o ou composi��o. Dado que uma Sala ou Garagem, por exemplo, podem ser interpretados como indissoci�veis de uma Casa, a associa��o abaixo deveria representar uma composi��o (losango hachurado) em vez da agrega��o (losango n�o hachurado).

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-03/mod03ima01/mod03ima01.plantuml)

### t11.02

### Toda cadeira possui um propriet�rio (mulher ou homem).

O modelo abaixo n�o � expl�cito quanto ao sexo da pessoa. Dado o fato de que os atributos foram omitidos, n�o h� porque imaginar que este n�o ser� inclu�do. Tamb�m n�o foi inclu�da a cardinalidade. Os mais rigorosos podem indicar que a associa��o no extremo de Pessoa possui como cardinalidade o valor 1, enquanto para o outro extremo a senten�a n�o fornece nenhuma pista.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-03/mod03ima02/mod03ima02.plantuml)

### t11.03

### H� janelas com vidros, outras sem.

Toda janela com vidro encontra-se dividida em duas �reas: aquela ocupada pelo vidro e a restante. Naturalmente, a �rea total da janela � a soma destas duas �reas.

Uma janela com vidro pode ser interpretada como uma especializa��o de uma janela, digamos, comum, sem vidro, ou vice-versa. Aquela com vidro possui como atributo areaVidro, que informa a �rea da janela ocupada pelo vidro, enquanto a janela sem vidro possui como atributo area. Uma janela com vidro, portanto, possui pelo menos dois atributos suficientes para determinarmos duas informa��es relevantes: a �rea do vidro e aquela �rea da janela que n�o � ocupada por vidro. Uma alternativa � exibida no lado esquerdo da figura abaixo.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-03/mod03ima03/mod03ima03.plantuml)

### t11.04

### Arm�rio

Todo arm�rio possui v�rias prateleiras. Cada uma delas divididas em compartimentos. Em cada compartimento s�o armazenados objetos de dois tipos: livros e CDs. Cada compartimento pode guardar no m�ximo 3 livros, enquanto deve guardar 2, 4, 7, ou mais de 7 CDs.

No modelo acima Arm�rio � uma composi��o de Prateleira, ou seja, n�o existe Prateleira sem que seja parte de um arm�rio. Um racioc�nio similar � v�lido entre Prateleira e Compartimento. Este �ltimo guarda v�rios objetos em seu interior. At� tr�s livros e uma combina��o ex�tica mas bem definida de CDs. Afinal, ou teremos 2, ou teremos 4, ou teremos 7, ou teremos um n�mero superior a 7 CDs.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-03/mod03ima04/mod03ima04.plantuml)

### t11.05

### Toda lanchonete possui pelo menos 2 funcion�rios, � poss�vel que um deles seja gerente.

Um funcion�rio pode desempenhar o papel de gerente de uma lanchonete. Cada funcion�rio, al�m da possibilidade de estar ligado � lanchonete via Ger�ncia, � empregado da lanchonete.

![image](https://user-images.githubusercontent.com/1735792/90349460-534ee780-e010-11ea-9a6a-7fb0713f5c99.png)

### t11.06

### Carn�.

Todo carn� de presta��es refere-se a uma determinada compra, que pode incluir v�rios produtos, em quantidades distintas para cada um deles. Cada presta��o possui um valor correspondente e uma data limite para a quita��o correspondente.

![image](https://user-images.githubusercontent.com/1735792/90349507-7ed1d200-e010-11ea-9315-58c56f4690cc.png)

### t11.07

### Uma frase � uma seq��ncia de palavras. Cada palavra � uma seq��ncia de caracteres.

N�o queremos confus�o com os ling�istas e, dessa forma, podemos estar assumindo que existe frase formada por apenas uma �nica palavra, conforme o modelo abaixo registra. Tirando este cen�rio no m�nimo sui generis, todas as palavras est�o em uma seq��ncia, assim como as letras correspondentes a cada uma delas.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-03/mod03ima07/mod03ima07.plantuml)

### t11.08

### Pre�o � uma combina��o de um valor e uma moeda. Por exemplo, valor 10 e moeda d�lar.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-03/mod03ima08/mod03ima08.plantuml)

### t11.09

### Per�odo � formado por uma data inicial e uma data final.

Abaixo este cen�rio foi modelado com o emprego de associa��es. Tamb�m poder�amos ter empregado atributos na classe Per�odo. A decis�o entre estas op��es � quase sempre uma quest�o do contexto para o qual o modelo est� sendo constru�do. Se uma data � um elemento relevante do modelo, ent�o trate-o como uma classe, doutra forma, um atributo � suficiente.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-03/mod03ima09/mod03ima09.plantuml)

### t11.10

### Florestas

Florestas s�o formadas por �rvores que, por sua vez, s�o formadas por folhas. Cada folha possui sua forma, dentre todo um conjunto de formas poss�veis. Existem �rvores que participam de mais de uma floresta.

Se uma �rvore pode participar de mais de uma floresta, ent�o Floresta n�o � uma composi��o de �rvore, mas uma agrega��o. Por outro lado, n�o � razo�vel imaginar que uma folha possa participar de mais de uma �rvore. Para cada Folha h� um TipoFolha correspondente.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-03/mod03ima10/mod03ima10.plantuml)

