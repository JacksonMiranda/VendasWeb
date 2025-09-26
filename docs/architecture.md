# Arquitetura do VendasWeb

## Visão Geral

O VendasWeb é construído seguindo os princípios da arquitetura MVC (Model-View-Controller) com ASP.NET Core, proporcionando uma separação clara de responsabilidades e facilitando a manutenção e escalabilidade.

## Diagrama de Arquitetura (C4 - Nível 1)

```
┌─────────────────────────────────────────────────────────────────┐
│                          Contexto                              │
└─────────────────────────────────────────────────────────────────┘

    ┌─────────────────┐
    │     Usuário     │ ──────────────────────────┐
    │   (Vendedor,    │                          │
    │   Gerente)      │                          │
    └─────────────────┘                          │
                                                 ▼
                                    ┌─────────────────┐
                                    │   VendasWeb     │
                                    │   (Sistema de   │
                                    │   Vendas)       │
                                    └─────────────────┘
                                                 │
                                                 ▼
                                    ┌─────────────────┐
                                    │   MySQL         │
                                    │   Database      │
                                    └─────────────────┘
```

## Diagrama de Container (C4 - Nível 2)

```
┌─────────────────────────────────────────────────────────────────┐
│                      Sistema VendasWeb                         │
├─────────────────────────────────────────────────────────────────┤
│                                                                 │
│    ┌─────────────────┐                                         │
│    │   Web Browser   │ ───── HTTP/HTTPS ─────┐                │
│    │   (Frontend)    │                        │                │
│    └─────────────────┘                        ▼                │
│                                   ┌─────────────────┐          │
│                                   │  Web Application│          │
│                                   │  (ASP.NET Core  │          │
│                                   │     MVC)        │          │
│                                   └─────────────────┘          │
│                                               │                 │
│                                               │ Entity         │
│                                               │ Framework      │
│                                               │ Core           │
│                                               ▼                 │
│                                   ┌─────────────────┐          │
│                                   │   MySQL         │          │
│                                   │   Database      │          │
│                                   └─────────────────┘          │
└─────────────────────────────────────────────────────────────────┘
```

## Tecnologias e Padrões

### Stack Tecnológico
- **Framework**: ASP.NET Core 2.1 (MVC)
- **Linguagem**: C# 8.0
- **ORM**: Entity Framework Core
- **Banco de Dados**: MySQL
- **Frontend**: HTML5, CSS3, JavaScript, Bootstrap

### Padrões Arquiteturais

#### 1. **Model-View-Controller (MVC)**
- **Models**: Representam os dados e regras de negócio
- **Views**: Interface do usuário e apresentação
- **Controllers**: Coordenam interação entre Model e View

#### 2. **Repository Pattern**
- Abstrai o acesso a dados
- Facilita testes unitários
- Centraliza consultas complexas

## Estrutura de Pastas

```
VendasWebMVC/
├── Controllers/         # Controladores MVC
├── Models/             # Modelos de domínio e ViewModels
├── Views/              # Templates Razor
├── Services/           # Lógica de negócio
├── Data/               # Context e configurações EF
├── Migrations/         # Migrações do banco
└── wwwroot/            # Arquivos estáticos
```

## Fluxo de Dados

1. **Requisição HTTP** → Controller
2. **Controller** → Service (se necessário)
3. **Service** → Repository/Context
4. **Repository** → Database
5. **Database** → Repository → Service → Controller
6. **Controller** → View
7. **View** → Response HTTP