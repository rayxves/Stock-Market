# 📈 StockMarket API
Bem-vindo à StockMarket API! 

## 🚀 Funcionalidades

### Autenticação:
*Crie uma nova conta de usuário e acesse a sua conta existente.*
Login: POST /api/account/login
Registro: POST /api/account/register

### Ações:
*Adicione novas ações ao sistema, especificando informações como nome, símbolo e valor de mercado.*
Obter Ações: GET /api/stock
Adicionar Ação: POST /api/stock
Obter Ação por ID: GET /api/stock/{id}
Atualizar Ação: PUT /api/stock/{id}
Deletar Ação: DELETE /api/stock/{id}

### Comentários:
*Comente sobre qualquer ação.*
Obter Comentários: GET /api/comment
Obter Comentário por ID: GET /api/comment/{id}
Adicionar Comentário: POST /api/comment/{symbol}
Atualizar Comentário: PUT /api/comment/{id}
Deletar Comentário: DELETE /api/comment/{id}

### Portfolio:
*Gerencie suas ações preferidas, adicionando-as ao seu portfolio pessoal.*
Obter Portfolio: GET /api/portfolio
Adicionar Ação ao Portfolio: POST /api/portfolio
Deletar Ação do Portfolio: DELETE /api/portfolio

## 🛠️ Tecnologias Utilizadas
- .NET 8.0: Framework principal para desenvolvimento da API.
- ASP.NET Core: Para construir APIs web robustas.
- Entity Framework Core: Para interação com bancos de dados, suporte a SQL Server e MySQL.
- JWT Bearer Authentication: Para autenticação segura de usuários.
- ASP.NET Core Identity: Para gerenciamento de usuários e autenticação.
- Newtonsoft.Json: Para manipulação de JSON.
- Swashbuckle: Para geração automática de documentação Swagger da API.
  
## 🛠️ Como Usar
Clone o Repositório

``` git clone https://github.com/seuusuario/stockmarket-api.git ```

Instale as Dependências Navegue até o diretório do projeto e execute:

```dotnet restore ```

Configure o Banco de Dados, configure sua string de conexão no arquivo appsettings.json.

Execute a API Para iniciar o servidor:

``` dotnet watch run ```

## 📌 Finalidade
A finalidade desse projeto é aprender sobre o desenvolvimento de APIs, focando na criação e consumo de APIs, bem como entender conceitos de CRUD e autenticação.
