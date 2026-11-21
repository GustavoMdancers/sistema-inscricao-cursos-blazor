# Sistema de Inscrição em Cursos (Blazor)

Aplicação web desenvolvida em **ASP.NET Core Blazor (.NET 10)** para realização e validação de inscrições em cursos, com feedback visual de processamento assíncrono.

## Funcionalidades

- **Modelo de Dados Validado (`InscricaoModel`)**:
  - `Nome`: Obrigatório (`[Required]`).
  - `Email`: Obrigatório e validado como formato de e-mail (`[Required]`, `[EmailAddress]`).
  - `Idade`: Obrigatória e restrita à faixa de 16 a 100 anos (`[Required]`, `[Range(16, 100)]`).
  - `CursoId`: Seleção obrigatória de curso (`[Required]`).
- **Formulário Interativo (`Inscricao.razor`)**:
  - Mapeado na rota principal (`/`) e em `/inscricao`.
  - Construído com `<EditForm>` (`FormName="InscricaoForm"` e `[SupplyParameterFromForm]`).
  - Validação integrada via `<DataAnnotationsValidator />`, `<ValidationSummary />` e `<ValidationMessage>` por campo.
  - Seleção de cursos com `<InputSelect>` contendo opção padrão vazia e lista de cursos disponíveis.
- **Envio Assíncrono com Feedback Visual**:
  - Simulação de requisição assíncrona com `await Task.Delay(2000)`.
  - Desabilitação dinâmica do botão de envio (`disabled="@enviando"`) e alteração do texto entre `"Confirmar Inscrição"` e `"Processando..."`.
  - Exibição de mensagem de confirmação ao concluir o envio com sucesso.

## Estrutura do Projeto

```text
SistemaInscricaoCursosBlazor/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor
│   │   └── NavMenu.razor
│   ├── Models/
│   │   └── InscricaoModel.cs
│   ├── Pages/
│   │   ├── Inscricao.razor
│   │   ├── Error.razor
│   │   └── NotFound.razor
│   ├── App.razor
│   ├── Routes.razor
│   └── _Imports.razor
└── Program.cs
```

## Como Executar

1. Certifique-se de ter o **.NET 10 SDK** instalado.
2. No diretório raiz do repositório, execute:

```bash
dotnet run --project SistemaInscricaoCursosBlazor/SistemaInscricaoCursosBlazor.csproj
```

3. Acesse o endereço exibido no terminal (por padrão `https://localhost:7149` ou `http://localhost:5152`).
