# TRABALHO 09

### ORGANIZA��O DAS PASTAS POR C�DIGO DE ACORDO COM AS ATIVIDADES

### T09.01

### Uma pessoa possui pode possuir zero ou mais h�bitos.

Talvez nenhum h�bito. Todo h�bito est� associado a uma pessoa, ou seja, conforme modelado abaixo, h�bitos n�o s�o compartilhados, cada um possui os seus.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima01/mod02ima01.plantuml)

### T09.02

### Uma pessoa possui um nome, idade e h�bitos. Um h�bito possui uma descri��o.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima02/mod02ima02.plantuml)

### T09.03

### Um c�rculo � descrito por uma posi��o (x,y), correspondente ao centro e um valor para o raio, al�m da possibilidade de ser transladado de um deslocamento em x e outro em y.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima03/mod02ima03.plantuml)

### T09.04

### Um c�rculo � descrito por um ponto, correspondente ao centro, e um valor para o raio. O c�rculo � transladado de um deslocamento em x e outro em y. (Alternativa para o modelo acima.)

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima04/mod02ima04.plantuml)

### T09.05

### Um usu�rio de um sistema computacional � uma pessoa.

Embora o modelo abaixo permita que uma inst�ncia de Usu�rio seja tratada como uma inst�ncia de Pessoa, o que decorre da heran�a, conv�m ressaltar que um modelo alternativo, talvez melhor seja uma simples associa��o entre Usu�rio e Pessoa. Nesta associa��o, a inst�ncia de Usu�rio ressaltaria uma atividade, um papel que a inst�ncia de Pessoa correspondente desempenharia.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima05/mod02.ima05.plantuml)

### T09.06

### Um elefante � um mam�fero.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima06/mod02ima06.plantuml)

### T09.10

### Um cont�iner cont�m cont�ineres e objetos.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima07/mod02ima07.plantuml)

Observe que um cont�iner agrega v�rios elementos. Ou seja, uma inst�ncia de Cont�iner est� associada, possivelmente, a v�rios objetos da classe Elemento. Estes objetos "fazem parte" (agrega��o) do cont�iner em quest�o. Adicionalmente, o que � um Elemento? Um Elemento � herdado por Objeto e por Cont�iner. Ou seja, quando se fala em um Elemento estamos falando ou de um Objeto ou de um Cont�iner. Quando s�o reunidos v�rios objetos Elemento em um Cont�iner, portanto, o que se tem "l� dentro" s�o inst�ncias de Objeto e/ou inst�ncias de Cont�iner. 

### T09.11

### Caixeiro-viajante.

Um caixeiro-viajante faz uso de uma lista de cidades pelas quais ter� que percorrer em uma viagem, na ordem fornecida e, para cada uma das cidades, colhe pedidos de armaz�ns l� localizados. A lista de cidades corresponde a uma viagem do caixeiro-viajante. Espera-se uma lista de cidades para cada viagem. Ou seja, um caixeiro-viajante est� associado a v�rias viagens, cada uma delas � descrita por uma lista de cidades, conforme ilustrado abaixo. Observe que as cidades est�o ordenadas (ordered).

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima08/mod02ima08.plantuml)

### T09.12

### Caixeiro-viajante e lista de pedidos.

Falta ao modelo acima informa��o pertinente aos pedidos colhidos em cada armaz�m. Naturalmente ser� preciso associar a lista de pedido ao armaz�m do qual esta foi gerada. Esta informa��o, contudo, n�o � suficiente, pois tamb�m ser� preciso identificar a viagem na qual esta foi definida. Uma alternativa � estabelecer uma associa��o de cada lista de pedido para o armaz�m do qual esta originou-se e outra com a viagem em quest�o, conforme modelado abaixo.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima09/mod02ima09.plantuml)

### T09.13

### Cliente e fornecedor envolvem-se em transa��es econ�micas.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-02/mod02ima10/mod02ima10.plantuml)
