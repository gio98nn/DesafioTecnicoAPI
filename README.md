# ProdutosApi

API RESTful desenvolvida com ASP.NET Core para gerenciamento de produtos. Este projeto permite realizar operações CRUD (Create, Read, Update, Delete) em uma entidade `Produto`, armazenada com Entity Framework Core utilizando SQLite.

## 🚀 Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- Swagger para documentação da API

## 📦 Como Rodar o Projeto

1. **Clonar o repositório**
   ```bash
   git clone <url-do-repositorio>
   cd ProdutosApi/ProdutosApi
   ```

2. **Restaurar os pacotes NuGet**
   ```bash
   dotnet restore
   ```

3. **Aplicar as migrações e criar o banco de dados**
   ```bash
   dotnet ef database update
   ```

4. **Rodar o projeto**
   ```bash
   dotnet run
   ```

5. **Acessar no navegador**
   ```
   https://localhost:port/swagger
   ```
   O Swagger estará disponível para testar os endpoints da API.

## 📌 Endpoints Disponíveis

| Método | Rota                  | Descrição                        |
|--------|-----------------------|----------------------------------|
| GET    | /api/Produtos         | Retorna todos os produtos        |
| GET    | /api/Produtos/{id}    | Retorna um produto pelo ID       |
| POST   | /api/Produtos         | Cria um novo produto             |
| PUT    | /api/Produtos/{id}    | Atualiza um produto existente    |
| DELETE | /api/Produtos/{id}    | Deleta um produto pelo ID        |

## 🧪 Exemplo de Objeto Produto

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "nome": "Teclado Gamer",
  "descricao": "Teclado mecânico com RGB",
  "preco": 199.90
}
```

## 🗃️ Estrutura do Projeto

```
ProdutosApi/
├── Controllers/
│   └── ProdutosController.cs
├── Models/
│   └── Produto.cs
├── Data/
│   └── AppDbContext.cs
├── Migrations/
├── appsettings.json
└── Program.cs
```

## ⚙️ Observações

- O banco de dados utilizado é SQLite e o arquivo `.db` será criado automaticamente na primeira execução.
- Certifique-se de que você possui o .NET 8 SDK instalado.
