# TRABALHO 07

### ORGANIZA��O DAS PASTAS POR C�DIGO DE ACORDO COM AS ATIVIDADES

### Classe

### t07.01
A classe _Pessoa_, nenhum atributo, nenhum m�todo em uma representa��o na
UML onde tais elementos n�o foram considerados relevantes para o interesse em quest�o.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-pessoa-3.png" width="100px">

### t07.02
A rela��o entre esta classe e o c�digo Java correspondente.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-pessoa.png" width="350px">

### t07.03
Outro exemplo de rela��o entre c�digo em Java e classe na UML.

<img src="https://github.com/kyriosdata/oo/blob/master/media/java-livro.png" width="400px">


### Classe com atributos

### t07.04
Os membros de dados _dia_, _mes_ e _ano_, todos do tipo _short_, todos privados (_private_) em Java e a correspondente vers�o na UML.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-association-4.png" width="350px">

### t07.05
Membros de dados, em geral, quando referenciam "tipos" cl�ssicos, conforme
ilustrados abaixo, s�o representados sem a indica��o expl�cita das associa��es.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-pds.png" width="400px">

### t07.06
Ainda � poss�vel a op��o abaixo. N�o � esperada, em geral,
a representa��o de depend�ncia conforme ilustrada, mas em outros
cen�rios para ressaltar que, de alguma forma, uma classe faz uso de outra.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-dependencia.png" width="400px">

### Classe com atributo e m�todos

### t07.07
_Prova_ com um �nico atributo, _numQuestoes_. Naturalmente, insuficiente para
caracterizar uma prova, de qualquer forma, aqui o foco n�o � na modelagem,
mas no mapeamento entre modelos e Java. Adicionalmente, esta classe faz uso dos
famosos m�todos _get_ e _set_, por meio dos quais, respectivamente, pode-se obter
o valor e definir um valor para _numQuestoes_. Observe que n�o � poss�vel definir um
valor para o total de quest�es de uma prova menor que 1.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-association-5.png" width="400px">

### t07.08
Uma considera��o adicional � feita abaixo para os m�todos _get_ e _set_. Observe a assinatura dos m�todos, ou seja o tipo de retorno, par�metros e nome do m�todo.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-association-6.png" width="350px">

### Classe com membros

### t07.09
A classe _Pessoa_ com dois membros de dados, tamb�m chamados de propriedades, ou ainda atributos, al�m de duas associa��es com ela pr�pria. As associa��es d�o origem a dois membros de dados, _pai_ e _mae_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-association-8.png" width="350px">

### Classe _Object_

### t07.10
A classe _Object_ � a classe base de toda e qualquer classe em Java. Noutras
palavras, todo e qualquer objeto em Java possui os m�todos citados abaixo.

<img src="https://github.com/kyriosdata/oo/blob/master/media/java-object.png" width="350px">

### t07.11
Em consequ�ncia, apesar de correto, n�o � usual nem o c�digo nem o
diagrama abaixo, embora ambos estejam corretos.

<img src="https://github.com/kyriosdata/oo/blob/master/media/java-livro-objeto.png" width="300px">

### Objeto

### t07.12
Uma aplica��o trivial que cria uma inst�ncia da classe _Prova_. Nem a aplica��o nem a classe _Prova_ s�o exibidas no modelo. Nenhum uso � feito desta classe, apenas o construtor � executado. O objeto criado n�o � an�nimo. Ao contr�rio, � referenciado por _pf_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-objeto.png" width="350px">

### Como se cria um objeto?

### t07.13
Observe a classe _Casa_ e seu construtor. Em tempo, construtor � a
opera��o executada quando se cria uma inst�ncia da classe.

<img src="https://github.com/kyriosdata/oo/blob/master/media/java-casa.png" width="450px">

### t07.14
Abaixo a classe _Casa_ � estendida com o m�todo _main_, o que a torna
"execut�vel". Em geral classes n�o s�o "execut�veis" no sentido em
d�o origem a programas. Em geral, um programa ou aplica��o cria classe
espec�fica para tal e que usa outras classes. De qualquer forma, veja
abaixo como uma inst�ncia da pr�pria classe � criada por meio do
operador _new_, que dispara a execu��o do construtor.

<img src="https://github.com/kyriosdata/oo/blob/master/media/java-construtor.png" width="450px">

Na figura abaixo, para que n�o persista d�vida, antes do uso do
operador _new_ n�o h� inst�ncia da classe _Casa_. Ap�s a execu��o
satisfat�ria do construtor, por outro lado, uma inst�ncia � criada, o
objeto correspondente � referenciado por _c_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/java-casa-nascimento.png" width="400px">

### Classe abstrata

### t07.15
A classe _Pessoa_, contudo, agora abstrata. Ou seja, uma classe da qual n�o � poss�vel criar uma inst�ncia. Este tipo de classe � criada para ser estendida. Em tempo, extens�o aqui tem o mesmo significado que heran�a (vista adiante).

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-abstract-pessoa.png" width="343px">

### Agrega��o

### t07.16
Uma _Festa_ possui pelo menos um _Convidado_ que, por sua vez, pode ser convidado de v�rias festas.

<img src="https://github.com/kyriosdata/oo/blob/master/media/festa-convidado.png" width="400px">

### Agrega��o e associa��o

### t07.17
A classe _Uniao_ est� associada a duas inst�ncias de _Pessoa_ pela associa��o rotulada por _Casamento_. Ou seja, admite casamento exatamente entre duas pessoas. Adicionalmente, desta uni�o podem derivar filhoes, zero ou mais.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-aggregation.png" width="400px">

### Associa��o n:n

### t07.18
Um aluno pode estar matriculado em v�rios cursos e, naturalmente, cada curso pode ter v�rios alunos matriculados.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-association.png" width="370px">

### Algoritmo para Java

### t07.19
Tradu��o do algoritmo da esquerda para a vers�o correspondente em Java.
Embora a correspond�ncia esteja correta, em Java n�o � usual m�todos possu�rem inicial mai�scula, como ocorre com C#. Estas conven��es devem ser observadas visando melhor intera��o entre membros de uma equipe.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-association-1.png" width="350px">

### Aplica��o Java

### t07.20
Aplica��o que exibe todas poss�veis da cadeia de caracteres fornecida na entrada.
Observe que uma inst�ncia an�nima de _String_ e o par�metro fornecido via linha de comandos s�o fornecidos para o m�todo _Permutacao_ no m�todo _main_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/java-permuta.png" width="350px">

### Composi��o

### t07.21
A classe _Religiao_ e seu conjunto de devotos. A implementa��o em Java, contudo,
faz uso de uma lista. Conv�m ressaltar que conjunto n�o admite duplicidade,
o que talvez seja mais natural, contudo, uma lista em Java admite duplicidade.
Adicionalmente, nesta implementa��o, a _Religiao_ conhece cada _Devoto_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-composicao.png" width="350px">

### Composi��o (associa��o bidirecional)

### t07.22
_Religiao_ possui devotos (_Devoto_), contudo, cada _Devoto_ sabe qual
a _Religicao_ correspondente, e cada _Religia_ conhece seus devotos.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-composition.png" width="350px">

### Heran�a

### t07.23
Neste caso, diz-que _Aluno_ estende _Pessoa_. Noutras palavras, _Aluno_ **�** uma _Pessoa_. Esta heran�a, contudo, talvez possa ser melhor expressa como "aluno � uma atribui��o de uma pessoa", ou ainda "uma pessoa, ao longo da vida, desempenha v�rias atividades, inclusive de ensino".

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-heranca.png" width="300px">

### Heran�a (termos)

### t07.24
A classe que herda � dita _derivada_. A classe herdada � dita _base_. Tamb�m
� usual e correto o uso de _ancestral_ para a classe _base_ e _derivada_ para a classe _derivada_. Adicionalmente, observe que h� uma _especializa��o_ da classe _base_ para a classe _derivada_. No sentido oposto, ocorre a _generaliza��o_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-heranca-simples.png" width="300px">

### _Revista_ herda de _Refer�ncia_

### t07.25
<img src="https://github.com/kyriosdata/oo/blob/master/media/java-revista-referencia.png" width="350px">

### Heran�a de classe abstrata

### t07.26
Uma classe abstrata herdada pelas classes _PessoaF�sica_ e _PessoaJur�dica_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-abstract-pessoa-pfj.png" width="300px">

### Heran�a (pessoa)

### t07.27
A classe abstrata _Pessoa_ modela o cen�rio onde existe inst�ncia de _PessoaF�sica_ ou de _PessoaJur�dica_ que, conforme ilustrado, acrescenta informa��es espec�ficas �quelas herdadas de _Pessoa_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-abstract.png" width="300px">

### Implementa��o de interface

### t07.28
N�o se confunde com heran�a. Quando uma classe implementa uma interface, ent�o esta classe possui m�todos que permitem se comportar conforme definido na interface. Heran�a, por outro lado, � o tipo "mais forte" de relacionamento entre duas classes.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-implements.png" width="450px">

### Interface

A interface _Identificacao_ para indicar que, qualquer classe que a implementa,
pode receber a mensagem _getNome_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-interface.png" width="350px">

### Interface _Comparable_

### t07.29
Em Java, pode-se ordenar inst�ncias de objetos via [Collections](<https://docs.oracle.com/javase/7/docs/api/java/util/Collections.html#sort(java.util.List)>). Como � poss�vel estar implementada a ordena��o de objetos
de uma dada classe que nem era conhecida quando a ordena��o foi implementada? H� alternativas em Java, a cl�ssica � implementar a interface
[Comparable](https://docs.oracle.com/javase/7/docs/api/java/lang/Comparable.html), conforme ilustrado abaixo.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-interface-nota-comparable.png" width="300px">

### t07.30
Abaixo segue uma representa��o alternativa �quela acima.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-interface-nota-comparable2.png" width="200px">

### Package

### t07.31
A orienta��o a objetos oferece o conceito de classe para decompor software.
Alguns dom�nios, contudo, s�o extensos e v�rias classes podem ser necess�rias para registrar parte do dom�nio em quest�o. Em Java, v�rias
classes "coesas" podem ser agrupadas usando a no��o de _package_. Abaixo segue a ilustra��o de um _package_.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-package.png" width="300px">

No dom�nio acad�mico, por exemplo, v�rias classes pertinentes ao ensino, em geral, podem estar no _package_ denominado _ensino_, conforme abaixo. Em tal _package_ s�o esperadas classes como _Aluno_, _Avalia��o_ e outras. No _package_ denominado _escola_, por outro lado, que depende de _ensino_, ou seja, faz uso de classes deste _package_, s�o esperadas classes como
_Colaborador_, _Diretoria_ e outras.

<img src="https://github.com/kyriosdata/oo/blob/master/media/uml-java-package2.png" width="400px">