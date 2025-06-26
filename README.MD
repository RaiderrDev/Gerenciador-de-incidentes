# API de Gerenciamento de Incidentes

Este projeto é a minha **primeira API**, desenvolvida como parte do meu aprendizado em desenvolvimento de APIs com **ASP.NET Core** e **Entity Framework Core**. A API permite gerenciar incidentes por meio de operações CRUD, com uma arquitetura organizada utilizando o padrão Repository e injeção de dependência.

## Sobre o Projeto

A API foi feita para registrar e gerenciar incidentes, com atributos como descrição, prioridade (Baixa, Média, Alta), status (Aberto, Encerrado, Concluído) e data de abertura. O projeto é estruturado em camadas (controller, serviço, repositório e modelo) para facilitar manutenções

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework para desenvolvimento da API
- **Entity Framework Core**: Para acesso e manipulação do banco de dados
- **SQLite**: Banco de dados leve e bom para estudos
- **C#**: Linguagem principal

## Endpoints da api
METODO | ENDPOINT | DESCRIÇÂO | EXEMPLO NO BODY
GET | api/incidente/retornar | Retorna todos incidentes 
GET | /api/Incidente/buscar/{id} | Busca um incidente por id
POST | /api/Incidente/salvar | Cria um novo incidente | { "Descricao": "Erro no servidor", "Prioridade": 2, "Status": 0 }
PUT | /api/Incidente/atualizar/{id} | Atualiza o status de um incidente | { "Status": 1 }
DELETE | /api/Incidente/deletar/{id} | Deleta um incidente por id











