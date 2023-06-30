# TRABALHO 07

### ORGANIZA��O DAS PASTAS POR C�DIGO DE ACORDO COM AS ATIVIDADES

### T08.01

### Toda disciplina possui um nome.

Observe que nome n�o � considerado um conceito que mere�a o tratamento de classe. Um atributo fornece um detalhe intimamente ligado � classe na qual � definido. Infelizmente n�o existe um conjunto de diretrizes que, uma vez seguidas, identificam com clareza, se uma determinada informa��o deve ser tratada como atributo ou como classe. Felizmente, a pr�tica tem mostrado que esta quest�o torna-se cada vez menor com o aumento da experi�ncia do respons�vel pela modelagem.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-01/mod01ima01.plantuml)

### T08.02
### Um projeto de software pode empregar v�rias linguagens de programa��o.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-02/mod01ima02.plantuml)

### T08.03
### Toda escola possui um endere�o.

Embora alguns especulem a defini��o de endere�o como atributo da classe Escola, a proposta abaixo ressalta a distin��o entre os conceitos envolvidos. Enquanto entidade, uma inst�ncia de Escola possui atributos como nome, capacidade de alunos e outros. Endere�os nos dias atuais inclui CEP, logradouro e outros. Tratar estas informa��es como atributos espalhados por v�rias classes � inconveniente �bvio de n�o tratar endere�o como uma classe.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-03/mod01ima03.plantuml)

### T08.04
### Um texto � uma combina��o de par�grafos que, por sua vez, s�o combina��es de senten�as.

Talvez voc� imagine que uma composi��o seja mais apropriada, por ressaltar que a destrui��o do texto significa a destrui��o dos par�grafos e respectivas senten�as e que, em outro sentido, quando se criam as senten�as e os par�grafos o texto est� sendo criado. Por outro lado, apesar de n�o usual, o modelo abaixo permite compartilhar par�grafos e senten�as, possibilidade que desaparece caso seja empregada a composi��o.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-04/mod01ima04.plantuml)

### T08.05
### Em um pa�s h� v�rias cidades.

Dado um pa�s temos zero ou mais cidades correspondentes. Em sentido inverso, dada uma cidade h� um pa�s correspondente (exatamente um). Pode-se modelar esta rela��o conforme ilustrado abaixo. O losango representa uma agrega��o, um tipo de relacionamento todo/parte, como normalmente as pessoas imaginam existir entre um pa�s e as cidades deste pa�s. Esta agrega��o encontra-se rotulada por Cont�m. Um r�tulo � empregado para esclarecer, quando considerado conveniente, o significado da rela��o. Afinal, v�rias outras rela��es podem existir entre um pa�s e uma cidade (vende produtos para, por exemplo). Ainda � poss�vel observar a cardinalidade desta rela��o, do lado esquerdo o numeral 1 e do lado direito o asterisco. O asterisco indica zero ou mais, noutras palavras, o modelo abaixo admite a exist�ncia de um Pa�s que n�o possui nenhuma cidade com a qual est� associado. Por outro lado, se existe uma cidade, ent�o h� um pa�s que a cont�m, necessariamente. Se, em vez do asterisco a cardinalidade fosse 1..\*, ent�o n�o ter�amos um pa�s sem a exist�ncia de pelo menos uma cidade nele contido.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/marcuspadilha/oo/master/imagens/modelos-01/imagem-05/mod01ima05.plantuml)

### T08.06
### Uma das cidades de um pa�s � a capital.

Dado um pa�s necessariamente teremos uma cidade correspondente que � a capital deste pa�s. A figura abaixo ilustra esta informa��o. O relacionamento � rotulado por Capital, a cardinalidade indica que todo pa�s necessariamente possui uma cidade associada (a capital). No sentido inverso, uma cidade pode ou n�o ser uma capital e, portanto, nem todas possuem esta rela��o com pa�s. Desta forma, a cardinalidade � indicada por 0..1. Se a cardinalidade fosse 1, em vez de 0..1, ent�o ter�amos um modelo no qual toda cidade � necessariamente capital de algum pa�s.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-06/mod01ima06.plantuml)

### T08.07
### Em um pa�s h� v�rias cidades e uma delas � a capital.

Esta informa��o � uma combina��o das anteriores, contudo, foi modelado de forma distinta da simples uni�o dos diagramas acima. Existem dois relacionamentos rotulados por Capital e Cont�m. Ambos aparecem dirigidos (ou orientados) de Pa�s para Cidade. Isto significa que � f�cil identificar as cidades contidas em um pa�s, assim como � f�cil identificar a capital de um pa�s., contudo, dada uma cidade, n�o saberemos com tal facilidade se ela � capital ou mesmo a qual pa�s ela pertence. Se tal facilidade � desejada em ambos os sentidos, ent�o o relacionamento deve ser bidirecional, como os anteriores. As cardinalidades e r�tulos se mantiveram. Foi acrescentado o papel capital (lado da entidade Cidade). Este exemplo refor�a que, dado um pa�s e uma cidade relacionados por meio desta associa��o, a cidade desempenha o papel de capital. Naturalmente, neste caso, o emprego pode ser considerado desnecess�rio por muitos.

![image](https://user-images.githubusercontent.com/1735792/90348568-ef76ef80-e00c-11ea-80f7-2222dc5eaac3.png)

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-07/mod01ima07.plantuml)

### T08.08
### Um projeto envolve v�rias pessoas.

A agrega��o (losango) indica que pessoas fazem parte de projetos. Neste exemplo a multiplicidade n�o � fornecida. H� pelo menos dois casos para serem analisados. Em um deles a multiplicidade n�o � fornecida por n�o ser relevante no contexto. Em muitos casos � natural identificar as entidades e associa��es entre estas, e deixar para momento posterior a identifica��o precisa de quantas entidades se relacionam com quantas entidades no outro extremo da rela��o. No outro caso a ser analisado, a multiplicidade n�o foi fornecida porque est� sendo adotada a multiplicidade padr�o da UML, ou seja, \*, zero ou mais entidades (ou inst�ncias). Neste caso a interpreta��o seria que um projeto pode estar associado a zero ou mais pessoas assim como uma pessoa pode estar associada a zero ou mais projetos.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-08/mod01ima08.plantuml)

### T08.09
### Uma curva pode ser definida como uma cole��o de pontos ordenados.

O modelo informa que toda curva est� associada a pelo menos dois pontos ordenados. Podem existir bem mais de 2 pontos, mas todos eles est�o ordenados, o que assegura a possibilidade de reconstru��o da curva em quest�o. O modelo indica que as inst�ncias da classe Ponto associadas a uma inst�ncia da classe Curva est�o ordenados pela restri��o {ordered} associada ao extremo direito da associa��o apresentada.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-09/mod01ima09.plantuml)

### T08.10
### Uma janela gr�fica (interface com o usu�rio) compreende v�rios elementos de intera��o.

Por exemplo, bot�es, menus e barras de rolagem. Embora uma inst�ncia de Janela possa ser interpretada como uma agrega��o de inst�ncias de Elemento de intera��o, conv�m ressaltar um relacionamento �mais forte� entre inst�ncias desta classe. Quando uma inst�ncia de Janela � criada, as inst�ncias correspondentes da classe Elemento de intera��o tamb�m s�o criadas. Quando uma inst�ncia de Janela � destru�da, naturalmente as inst�ncias da classe Elemento de intera��o associadas tamb�m s�o destru�das. Quando objetos apresentam este relacionamento todo/parte com sem�ntica mais rigorosa que aquela da agrega��o, empregamos uma composi��o, conforme ilustrado no diagrama. Em tempo, os elementos de intera��o de uma janela considerados no modelo abaixo incluem bot�es, menus e barras de rolagem, conforme as classes exibidas.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-10/mod01ima10.plantuml)

### T08.11
### Um arquivo possui permiss�es de acesso.

Cada permiss�o est� associada a um grupo (de usu�rios). Conforme o diagrama, toda Permiss�o est� associada necessariamente a um Grupo e a um Arquivo. Naturalmente, dada uma inst�ncia de Arquivo, podem existir v�rias inst�ncias de Permiss�o, cada uma delas conforme a inst�ncia de Grupo associada. Observe que pode n�o existir nenhuma permiss�o correspondente para um dado arquivo. No outro sentido a interpreta��o � a mesma, ou seja, um Grupo possui uma inst�ncia de Permiss�o para cada Arquivo. Por �ltimo, um Grupo define um conjunto de inst�ncias de Usu�rio, cada uma delas representa um usu�rio que � membro do grupo em quest�o, da� o emprego da agrega��o.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-11/mod01ima11.plantuml)

### T08.12
### Pessoas trabalham para empresas por um determinado sal�rio e intervalo de tempo.

Conforme o modelo, uma empresa oferece v�rios empregos, cada um deles ocupado exclusivamente por um empregado. No sentido inverso, uma pessoa pode ocupar v�rios empregos, cada um deles oferecido por um empregador. Cada inst�ncia de Emprego possui informa��es pertinentes � vaga em quest�o.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-12/mod01ima12.plantuml)

### T08.13
### Uma pessoa (empregado) trabalha para uma empresa (empregador).

No modelo abaixo, ao lado do papel empregado e empregador h� o s�mbolo +. Isto significa que os empregados de uma determinada empresa podem ser obtidos al�m das fronteiras da classe Empresa, ou seja, n�o se trata de informa��o privada de uma inst�ncia desta classe. Analogamente, dada uma inst�ncia de Pessoa, podemos saber quais as empresas pelas quais o ser humano em quest�o ofereceu os seus servi�os al�m das fronteiras da classe. Em geral este modificador de acesso associado aos pap�is n�o � fornecido. S�o elementos espec�ficos de implementa��o e, portanto, em geral, podem ser decididos pelos respons�veis pela constru��o propriamente dita do software em quest�o.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-13/mod01ima13.plantuml)

### T08.14
### Um usu�rio � o �dono� de um diret�rio. Cada diret�rio pode ser consultado por usu�rios autorizados.

Dada uma inst�ncia de Usu�rio temos inst�ncias de Diret�rio que s�o propriedades do usu�rio em quest�o. Dado um Diret�rio, aqueles autorizados (inst�ncias de Usu�rio) devem estar ligados pela associa��o Autorizado-a-usar.

![modelo](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/kyriosdata/oo/master/imagens/modelos-01/imagem-14/mod01ima14.plantuml)
