# 🚗 Lokar

Projeto desenvolvido com o objetivo de estudar e praticar o desenvolvimento de APIs utilizando **C#**, **ASP.NET Core**, **Entity Framework Core** e **SQL Server**.

O sistema simula uma plataforma de aluguel de veículos, permitindo o gerenciamento de carros e, futuramente, usuários, locações e regras de negócio relacionadas ao processo de aluguel.

## 📚 Objetivos do Projeto

Este projeto foi criado para fins de estudo e aprendizado, com foco em:

- Aprender os fundamentos da linguagem C#
- Entender a estrutura de aplicações ASP.NET Core
- Trabalhar com APIs REST
- Utilizar o Entity Framework Core para acesso a dados
- Aplicar conceitos de migrations e modelagem de banco de dados
- Utilizar SQL Server com Docker
- Praticar boas práticas de desenvolvimento backend
- Explorar conceitos de arquitetura e organização de projetos .NET

## 🛠️ Tecnologias Utilizadas

- C#
- .NET 10
- ASP.NET Core
- Entity Framework Core
- SQL Server
- Docker
- Scalar/OpenAPI

## 🚀 Funcionalidades Implementadas

### Carros

- Listar carros
- Buscar carro por ID
- Cadastrar carro
- Atualizar carro
- Remover carro

### Em desenvolvimento

- Cadastro de usuários
- Sistema de locação de veículos
- Controle de disponibilidade dos carros
- Histórico de locações
- Autenticação e autorização
- Validações e tratamento de erros

## 📂 Estrutura do Projeto

```text
Lokar/
├── Controllers/
├── Data/
├── Models/
├── Migrations/
├── Properties/
├── Program.cs
├── appsettings.json
└── docker-compose.yml
```

## 🐳 Executando o Banco de Dados

O projeto utiliza SQL Server executando via Docker.

Subir o container:

```bash
docker compose up -d
```

Verificar se o container está rodando:

```bash
docker ps
```

## 🗄️ Migrations

Criar uma migration:

```bash
dotnet ef migrations add NomeDaMigration
```

Aplicar migrations ao banco:

```bash
dotnet ef database update
```

## ▶️ Executando a Aplicação

Restaurar dependências:

```bash
dotnet restore
```

Executar o projeto:

```bash
dotnet run
```

## 🧠 O que estou aprendendo

Durante o desenvolvimento deste projeto estou estudando conceitos como:

- Tipagem forte em C#
- Classes e interfaces
- Dependency Injection
- Controllers e Minimal APIs
- Entity Framework Core
- Migrations
- SQL Server
- Relacionamentos entre entidades
- DTOs
- Arquitetura de APIs REST

## ⚠️ Aviso

Este projeto tem finalidade exclusivamente educacional e está sendo utilizado como ambiente de aprendizado para aprofundar conhecimentos no ecossistema .NET.

Portanto, algumas implementações podem ser simplificadas e serão refatoradas conforme novos conceitos forem sendo estudados.

---

Desenvolvido por Guilherme Rocha como parte da jornada de aprendizado em C# e ASP.NET Core.
