# TRABALHO 17

### ORGANIZA��O DAS PASTAS POR C�DIGO DE ACORDO COM AS ATIVIDADES

### T17.01

### Um computador compreende mouse, teclado, monitor e placa-m�e. A placa-m�e compreende mem�ria e CPU. A CPU faz acesso � mem�ria.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima01/mod05ima01.plantuml)

O modelo acima pode ser �trabalhado�, resultando naquele abaixo onde podemos acrescentar outros dispositivos � medida que se fizer necess�rio. No modelo abaixo optamos por n�o representar outros compartimentos de uma classe, ou seja, aquele dos atributos e das opera��es (m�todos). S�o formas alternativas, que devem ser empregadas conforme a necessidade. Para este caso, por exemplo, nem atributos nem opera��es fazem falta.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima02/mod05ima02.plantuml)

### T17.02

### Aeroporto

Em um aeroporto tem-se a ocorr�ncia de v�os. Alguns decolam outros aterrissam. Para cada v�o h� um avi�o, contendo v�rios lugares, cada um deles possivelmente ocupado por um passageiro. Para cada v�o tamb�m est� associada toda a tripula��o que inclui, necessariamente, um piloto, um co-piloto e uma ou mais aeromo�as.
Para o caso acima � f�cil observar alguns elementos principais a serem considerados. A simples identifica��o dos substantivos empregados nos revela os conceitos v�o, aeroporto, avi�o, lugar, passageiro, tripula��o, piloto, co-piloto e aeromo�a. Este conjunto candidado de classes � refinado � medida que modelamos e acrescentamos outros elementos. Neste caso est�o faltando os relacionamentos entre estas classes. Por exemplo, deve ser destacado o fato de que um aeroporto decolam e aterrisam v�os. Avi�o cont�m lugares e assim por diante. Um modelo poss�vel � fornecido abaixo.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima03/mod05ima03.plantuml)

### T17.03

### Lanchonete

Em lanchonetes s�o servidos v�rios tipos de sandu�che, alguns com v�rios tipos de acompanhamento como, por exemplo, ovo, salada, queijo e outros. O acompanhamento � opcional, n�o faz parte do sandu�che. Cada pedido recebido pelas gar�onetes tamb�m inclui, em geral, bebidas.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima04/mod05ima04.plantuml)

### T17.04

### Festa

Em uma festa convencional homens dan�am com mulheres. Cada dan�a est� associada a uma m�sica. Cada convidado da festa pode ou n�o ir acompanhado.

![image](https://user-images.githubusercontent.com/1735792/90352565-26073700-e01a-11ea-9f6b-8911d5b22008.png)

### T17.05

### Um trabalhador pode ser um a�ougueiro, um padeiro, um professor e um advogado.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima06/mod05ima06.plantuml)

### T17.06

### Pagamento

Uma determinada tarefa desempenhada por um trabalhador pode ser paga por hora, por um sal�rio mensal ou por contrato. V�rios pagamentos de formas distintas podem ser efetuados para uma mesma tarefa.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima07/mod05ima07.plantuml)

### T17.07

### Pessoas dirigem autom�veis, cada um deles de uma determinada marca, modelo e ano.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima08/mod05ima08.plantuml)

### T17.08

### Empregados

Uma empresa possui empregados organizados hierarquicamente onde gerentes gerenciam funcion�rios que, por sua vez, podem gerenciar outros funcion�rios. Todo empregado possui um gerente, exceto aquele do topo da hierarquia. Este �ltimo n�o � gerenciado por ningu�m.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima09/mod05ima09.plantuml)

### T17.09

### Presid�ncia de comit�

Pessoas podem ser membros de comit�s. Cada comit� necessariamente possui dois ou tr�s presidentes.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima10/mod05ima10.plantuml)

### T17.10

### Nota fiscal

Uma nota fiscal cont�m v�rios itens, cada um descreve um produto, a quantidade correspondente e o pre�o unit�rio.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima11/mod05ima11.plantuml)

### T17.11

### Avalia��o

Em um dado sistema acad�mico, avalia��o � o nome que se d� a um conjunto de quest�es, elaborada com determinada finalidade e aplicada em uma determinada data. Neste sistema prova � o nome que se d� �s respostas fornecidas por um aluno. Ou seja, alunos s�o submetidos a avalia��es e, para cada uma delas, cada prova correspondente tem o o aluno tem a correspondente prova.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-05/mod05ima12/mod05ima12.plantuml)

