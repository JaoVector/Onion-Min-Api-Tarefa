# API Minima com Arquitetura Cebola
Foi feita uma API Mínima para gerenciar tarefas, utilizando a Arquitetura Cebola. Essa API fornece um CRUD simples como
Criar uma tarefa, consultar, editar e excluir. O intuito do projeto é apresentar uma forma diferente de se construir uma API Mínima
sem aplicar todas as configurações dentro do arquivo Program.cs, aproveitando para apresentar o conceito da Arquitetura Cebola.


## Definição de APIs Mínimas
APIs mínimas são arquitetadas para criar APIs HTTP com dependências mínimas. 
Elas são ideais para microsserviços e aplicativos que desejam incluir apenas os arquivos, recursos e dependências mínimos no ASP.NET Core.

## Definição da Arquitetura Cebola
Em arquiteturas construídas utilizando 3 camadas ou n camadas, ocorre o problema de alto acoplamento pois as camadas dependem rigidamente uma da outra.
O objetivo da arquitetura cebola é utilizar a inversão de controle para tornar as camadas mais concêntricas, partindo da ideia que uma camada interna não pode saber
nada se um círculo externo, obtendo maior indepêndencia entre as camadas atribuindo a cada uma delas suas responsabilidades.

## Principais Principios da Arquitetura Cebola.


### Rotas da API:
```
https://localhost:7069/api/AddTarefas
https://localhost:7069/api/BuscaTarefas?skip=0&take=5
https://localhost:7069/api/BuscaPorId/{id}
https://localhost:7069/api/BuscaTarefasAbertas?skip=0&take=5
https://localhost:7069/api/BuscaTarefasConcluidas?skip=0&take=5
https://localhost:7069/api/BuscaTarefasExcluidas?skip=0&take=5
https://localhost:7069/api/AtualizaStatus/{id}?status={status}
https://localhost:7069/api/AtualizaTarefa/{id}
https://localhost:7069/api/DeletaTarefa/{id}
```

### Corpo Requisição POST
```json
{
    "nome": "string",
    "descricao": "string"
}
```
### Corpo Requisição PUT
```
{
    "nome": "string",
    "descricao": "string",
    "status": "string"
}
```
