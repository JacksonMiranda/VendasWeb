
# VendasWeb 🛒

*[English](#english) | [Português](#português)*

## Português 🇧🇷

### **Visão Geral**

O **VendasWeb** é um sistema de gestão de vendas moderno desenvolvido em .NET com C# utilizando a arquitetura MVC (Model-View-Controller). O sistema oferece uma solução completa para gerenciar vendas, controlar estoques e administrar clientes de forma eficiente e intuitiva.

### **Funcionalidades Principais**

- 📊 **Dashboard**: Visualização intuitiva de estatísticas de vendas, melhores clientes e produtos mais vendidos
- 💼 **Gestão de Vendas**: Registro completo de vendas com informações detalhadas de clientes e produtos
- 📦 **Controle de Estoque**: Atualização automática do estoque após cada transação
- 👥 **Gerenciamento de Clientes**: CRUD completo para administração de clientes
- 📈 **Relatórios**: Indicadores relevantes para tomada de decisão

### **Arquitetura (C4 Model)**

```
┌─────────────────┐
│     Usuário     │
└─────────────────┘
         │
         ▼
┌─────────────────┐
│   VendasWeb     │
│   (WebApp)      │
└─────────────────┘
         │
         ▼
┌─────────────────┐
│   .NET Core     │
│   MVC API       │
└─────────────────┘
         │
         ▼
┌─────────────────┐
│   MySQL         │
│   Database      │
└─────────────────┘
```

### **Tecnologias Utilizadas**

- 🏗️ **.NET Core**: Framework principal para desenvolvimento do backend
- 💻 **C#**: Linguagem de programação para lógica de negócios
- 🌐 **ASP.NET Core MVC**: Arquitetura MVC para interface web
- 🗄️ **Entity Framework Core**: ORM para interação com banco de dados
- 🎨 **HTML/CSS/JavaScript**: Frontend e interações dinâmicas
- 🐬 **MySQL**: Sistema de gerenciamento de banco de dados

### **Pré-requisitos**

- .NET Core SDK 2.1 ou superior
- MySQL Server
- IDE (Visual Studio, Visual Studio Code, ou Rider)

### **Instalação e Execução**

```bash
# 1. Clone o repositório
git clone https://github.com/JacksonMiranda/VendasWeb.git

# 2. Navegue até o diretório
cd VendasWeb

# 3. Restaure as dependências
dotnet restore

# 4. Execute as migrações do banco
dotnet ef database update --project VendasWebMVC

# 5. Execute a aplicação
dotnet run --project VendasWebMVC
```

### **Scripts de Build e Teste**

```bash
# Restaurar dependências
dotnet restore

# Build da aplicação
dotnet build

# Executar testes
dotnet test

# Build para produção
dotnet build --configuration Release

# Executar aplicação
dotnet run --project VendasWebMVC
```

### **Roadmap**

- [ ] ✨ Migração para .NET 8
- [ ] 🔐 Implementação de autenticação e autorização
- [ ] 📱 Interface responsiva aprimorada  
- [ ] 📊 Relatórios avançados com gráficos
- [ ] 🔄 API REST para integração
- [ ] 🧪 Cobertura completa de testes
- [ ] 🐳 Containerização com Docker
- [ ] ☁️ Deploy em nuvem

### **Contribuindo**

Contribuições são muito bem-vindas! Consulte o [CONTRIBUTING.md](CONTRIBUTING.md) para diretrizes detalhadas.

### **Licença**

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para detalhes.

---

## English 🇺🇸

### **Overview**

**VendasWeb** is a modern sales management system developed in .NET with C# using the MVC (Model-View-Controller) architecture. The system offers a complete solution to manage sales, control inventory, and administer customers efficiently and intuitively.

### **Key Features**

- 📊 **Dashboard**: Intuitive visualization of sales statistics, top customers, and best-selling products
- 💼 **Sales Management**: Complete sales registration with detailed customer and product information
- 📦 **Inventory Control**: Automatic stock updates after each transaction
- 👥 **Customer Management**: Full CRUD for customer administration  
- 📈 **Reports**: Relevant indicators for decision making

### **Architecture (C4 Model)**

```
┌─────────────────┐
│      User       │
└─────────────────┘
         │
         ▼
┌─────────────────┐
│   VendasWeb     │
│   (WebApp)      │
└─────────────────┘
         │
         ▼
┌─────────────────┐
│   .NET Core     │
│   MVC API       │
└─────────────────┘
         │
         ▼
┌─────────────────┐
│   MySQL         │
│   Database      │
└─────────────────┘
```

### **Technologies Used**

- 🏗️ **.NET Core**: Main framework for backend development
- 💻 **C#**: Programming language for business logic
- 🌐 **ASP.NET Core MVC**: MVC architecture for web interface
- 🗄️ **Entity Framework Core**: ORM for database interaction
- 🎨 **HTML/CSS/JavaScript**: Frontend and dynamic interactions
- 🐬 **MySQL**: Database management system

### **Prerequisites**

- .NET Core SDK 2.1 or higher
- MySQL Server
- IDE (Visual Studio, Visual Studio Code, or Rider)

### **Installation and Execution**

```bash
# 1. Clone the repository
git clone https://github.com/JacksonMiranda/VendasWeb.git

# 2. Navigate to directory
cd VendasWeb

# 3. Restore dependencies
dotnet restore

# 4. Run database migrations
dotnet ef database update --project VendasWebMVC

# 5. Run the application
dotnet run --project VendasWebMVC
```

### **Build and Test Scripts**

```bash
# Restore dependencies
dotnet restore

# Build application
dotnet build

# Run tests
dotnet test

# Production build
dotnet build --configuration Release

# Run application
dotnet run --project VendasWebMVC
```

### **Roadmap**

- [ ] ✨ Migration to .NET 8
- [ ] 🔐 Authentication and authorization implementation
- [ ] 📱 Enhanced responsive interface
- [ ] 📊 Advanced reports with charts
- [ ] 🔄 REST API for integration
- [ ] 🧪 Complete test coverage
- [ ] 🐳 Docker containerization
- [ ] ☁️ Cloud deployment

### **Contributing**

Contributions are very welcome! See [CONTRIBUTING.md](CONTRIBUTING.md) for detailed guidelines.

### **License**

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
