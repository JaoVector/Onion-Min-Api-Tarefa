# API Mínima com Arquitetura Cebola
## Descrição do Projeto
Foi feita uma API Mínima para gerenciar tarefas, utilizando a Arquitetura Cebola. Essa API fornece um CRUD simples como
Criar uma tarefa, consultar, editar e excluir. O intuito do projeto é apresentar uma forma diferente de se construir uma API Mínima
sem aplicar todas as configurações dentro do arquivo Program.cs, aproveitando para apresentar o conceito da Arquitetura Cebola.

#
### Rotas da API:
+ POST https://localhost:7069/api/AddTarefas
+ GET https://localhost:7069/api/BuscaTarefas?skip=0&take=5
+ GET https://localhost:7069/api/BuscaPorId/{id}
+ PUT https://localhost:7069/api/AtualizaTarefa/{id}
+ DELETE https://localhost:7069/api/DeletaTarefa/{id}

#
### Rotas de Consultas e Atualização Personalizada
+ GET https://localhost:7069/api/BuscaTarefasAbertas?skip=0&take=5
+ GET https://localhost:7069/api/BuscaTarefasConcluidas?skip=0&take=5
+ GET https://localhost:7069/api/BuscaTarefasExcluidas?skip=0&take=5
+ GET https://localhost:7069/api/BuscaTarefasAtrasadas?skip=0&take=5
+ PUT https://localhost:7069/api/AtualizaStatus/{id}?status={status}

#
### Modelo de Dados
A Entidade tarefa possuí os seguintes campos:
+ __IdTarefa__ É o identificador único para cada ação.
+ __Nome__ É o título da Tarefa.
+ __Descricao__ É o descritivo do que deve ser feito na tarefa.
+ __DataAbertura__ Define a Data em Que foi Aberta a Tarefa.
+ __DataFechamento__ Define a data limite para fechar a Tarefa.
+ __Status__ É uma propriedade do tipo Enum para definir em qual Status se encontra a tarefa.
### OBS: Se a DataFechamento for menor que a data de Abertura o Status será "Atrasada".
#
### Modelo de Status
```C#
public enum TarefaEnum
{
    Aberta,
    Concluida,
    Excluida
}
```
#
### Corpo Requisição POST
```json
{
    "nome": "string",
    "descricao": "string"
}
```
### Corpo Requisição PUT
```json
{
    "nome": "string",
    "descricao": "string",
    "status": "string"
}
```

#
## Definição de APIs Mínimas
APIs mínimas são arquitetadas para criar APIs HTTP com dependências mínimas. 
Elas são ideais para microsserviços e aplicativos que desejam incluir apenas os arquivos, recursos e dependências mínimos no ASP.NET Core.

#
## Definição da Arquitetura Cebola
Em arquiteturas construídas utilizando 3 camadas ou n camadas, ocorre o problema de alto acoplamento pois as camadas dependem rigidamente uma da outra.
O objetivo da arquitetura cebola é utilizar a inversão de controle para tornar as camadas mais concêntricas, partindo da ideia que uma camada interna não pode saber
nada de um círculo externo, obtendo maior indepêndencia entre as camadas atribuindo a cada uma delas suas responsabilidades.

#
## Princípios da Arquitetura Cebola.

1. A aplicação é construída em torno de um sistema de modelo de objeto independente.
2. As camadas internas definem interfaces, camadas externas implementam interfaces.
3. A direção do acoplamento é em direção ao centro.
4. Todo o código principal do aplicativo pode ser compilado e executado separadamente da
infraestrutura.

#
### Referências
https://www.macoratti.net/20/05/net_onion1.htm

https://code-maze.com/onion-architecture-in-aspnetcore/

https://learn.microsoft.com/pt-br/aspnet/core/tutorials/min-web-api?view=aspnetcore-7.0&tabs=visual-studio
