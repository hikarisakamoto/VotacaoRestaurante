# VotacaoRestaurante

### Requisitos para compilar o sistema
O código foi desenvolvido em .NET Core 2.1, necessitando do Visual Studio 2017 para executar com o SDK do .NET Core 2.1 instalado

### Instruções para rodar o sistema
Os testes foram desenvolvidos usando MSTests e para executar-los é necessario apenas rodar os testes na classe de testes **FacilitadorTests.cs**

### Destaque no código
Foi inicialmente desenvolvido com uma classe de **Restaurante, Funcionario e Facilitador** em mente, 
mas durante o desenvolvimento verifiquei que esse nível de abstrçao não era necessário.
Então foi depois removidas as classes de **Restaurante e Funcionario** e feito o desenvolvimento apenas com um Dictionary
de string com o nome dos restaurantes e do funcionário, que se mostrou mais simples e suficiente para resolver os problemas.

### Melhorar o sistema
Poderia ser implementado um melhor retorno para os erros, deixando mais claro o que aconteceu para o usuário, ou ainda 
a remoção das exceções, e tratando os possíveis erros com retorno de mensagens, avisos de outra forma, evitando dar um 
throw exception, pelo tamanho do custo do mesmo para o sistema. Ainda poderia ser feita a implementaçao de um controlador
de horário para possibilitar votção somente até o meio dia e fechar automaticamente a votação no dia e na semana, removendo a 
necessidade de um facilitador.


### Outros comentários
Seria interessante talvez implementar esse processo através do WebApi assim deixando a api aberta para uma utilizacao externa como um 
site, app que poderia implementar essa votação. Talvez fosse necessário fazer um sistema de login para garantir que somente os funcionario
autorizados podessem votar, mas isso ficaria para uma outra implementação.