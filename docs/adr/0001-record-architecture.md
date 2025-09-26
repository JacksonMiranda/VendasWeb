# ADR-0001: Arquitetura MVC com ASP.NET Core

## Status
Aceito

## Contexto
Precisamos definir a arquitetura base para o sistema de gestão de vendas VendasWeb. O sistema deve ser:
- Fácil de manter e estender
- Testável
- Escalável
- Familiar para a equipe de desenvolvimento

## Decisão
Escolhemos implementar o sistema usando o padrão **Model-View-Controller (MVC)** com **ASP.NET Core** como framework principal.

### Justificativa:

#### Vantagens do MVC:
1. **Separação de Responsabilidades**: Clara divisão entre lógica de apresentação, negócio e dados
2. **Testabilidade**: Cada camada pode ser testada independentemente
3. **Manutenibilidade**: Mudanças em uma camada não afetam diretamente as outras
4. **Escalabilidade**: Permite crescimento incremental da aplicação

#### Vantagens do ASP.NET Core:
1. **Performance**: Alto desempenho e throughput
2. **Cross-platform**: Executa em Windows, Linux e macOS
3. **Open Source**: Comunidade ativa e transparência
4. **Ecossistema**: Rica biblioteca de pacotes NuGet
5. **Familiaridade**: Equipe já possui conhecimento em C#/.NET

## Alternativas Consideradas

### 1. **ASP.NET Web API + SPA (Angular/React)**
- **Prós**: Interface mais dinâmica, API reutilizável
- **Contras**: Maior complexidade, curva de aprendizado para frontend frameworks

### 2. **Node.js + Express**
- **Prós**: JavaScript full-stack, rapid prototyping
- **Contras**: Mudança radical de tecnologia, menos expertise na equipe

## Consequências

### Positivas:
- Desenvolvimento mais rápido devido à familiaridade da equipe
- Estrutura bem definida facilita onboarding de novos desenvolvedores
- Boa separação de responsabilidades
- Facilita implementação de testes

### Negativas:
- Interface menos dinâmica comparada a SPAs
- Maior dependência do servidor para renderização

## Detalhes da Implementação

### Estrutura de Pastas:
```
VendasWebMVC/
├── Controllers/    # Lógica de controle e coordenação
├── Models/        # Entidades de domínio e ViewModels  
├── Views/         # Templates de apresentação (Razor)
├── Services/      # Lógica de negócio
├── Data/          # Contexto e mapeamento de dados
└── wwwroot/       # Assets estáticos (CSS, JS, imagens)
```

### Padrões Complementares:
- **Repository Pattern**: Para abstração de acesso a dados
- **Unit of Work**: Para controle de transações
- **Dependency Injection**: Para inversão de controle
- **DTO/ViewModel**: Para transferência de dados entre camadas

## Revisão
Esta decisão deve ser revisada quando houver mudanças significativas nos requisitos ou se surgirem problemas de performance.

## Referências
- [ASP.NET Core MVC Documentation](https://docs.microsoft.com/aspnet/core/mvc/)
- [Microsoft Architecture Guides](https://docs.microsoft.com/dotnet/architecture/)