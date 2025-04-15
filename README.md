# Cadastro Farmacia 🏥

Bem-vindo ao **CadastroFarma**! Este é um sistema desenvolvido para gerenciamento de cadastros farmacêuticos de maneira eficiente e organizada. 🚀

---

## 📋 Descrição

O **CadastroFarma** é uma aplicação web desenvolvida para facilitar o controle e registro de informações relacionadas a farmácias e seus produtos.  
Principais funcionalidades incluem:
- 🔐 Gerenciamento de categorias de medicamentos.
- 🔍 Consulta rápida e eficiente dos cadastros.
- 🔧 Interface amigável e intuitiva.

---

## 🛠️ Requisitos

Certifique-se de que você tenha as seguintes ferramentas instaladas para rodar o projeto:
- [.NET 7.0](https://dotnet.microsoft.com/) 🔧
- Banco de dados PostgreSQL 🐘
- Ferramentas como Visual Studio ou Visual Studio Code 🛠️

---

## ⚙️ Configuração

Siga os passos abaixo para configurar e executar o sistema:

1. Clone este repositório:
   ```bash
   git clone https://github.com/SeuUsuario/CadastroFarma.git
   ```

2. Navegue até a pasta do projeto:
   ```bash
   cd CadastroFarma-main/API
   ```

3. Configure a conexão com o banco de dados PostgreSQL no arquivo `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Database=CadastroFarma;Username=seu_usuario;Password=sua_senha"
   }
   ```

4. Execute as migrações para configurar o banco de dados:
   ```bash
   dotnet ef database update
   ```

5. Inicie a aplicação:
   ```bash
   dotnet run
   ```

---

## 🌐 API

A API do CadastroFarma foi desenvolvida em **ASP.NET Core** e segue padrões RESTful para facilitar a integração com outras aplicações.

### 🔐 Rotas Principais

- `/api/medicamentos`
  - **GET**: Retorna uma lista de todos os medicamentos cadastrados.
  - **POST**: Adiciona um novo medicamento.

- `/api/categorias`
  - **GET**: Retorna as categorias disponíveis.
  - **POST**: Adiciona uma nova categoria.

- `/api/usuarios`
  - **GET**: Lista os usuários cadastrados no sistema.
  - **POST**: Registra um novo usuário.

---

## 🛠️ Tecnologias Utilizadas

- **ASP.NET Core**: Framework principal para construção da API.
- **Entity Framework Core**: Mapeamento objeto-relacional (ORM) para acesso ao banco de dados.
- **PostgreSQL**: Banco de dados relacional.

A API foi projetada para ser extensível, facilitando a adição de novos endpoints e funcionalidades. 🌟

---

## 📂 Estrutura do Projeto

Abaixo está uma visão geral dos diretórios principais:

- `API/`: Contém o código principal da aplicação.
  - `Controllers/`: Controladores para gerenciar as rotas.
  - `Models/`: Modelos de dados utilizados pela aplicação.
  - `Context/`: Configuração do Entity Framework.
  - `Migrations/`: Arquivos de migração para o banco de dados.
- `appsettings.json`: Configurações da aplicação.
