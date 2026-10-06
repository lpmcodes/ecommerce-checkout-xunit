# ecommerce-checkout-xunit

Solução .NET 10 para gerenciar o cálculo de cupons, itens e frete de uma loja online,
com testes unitários em xUnit.

Disciplina: Garantia da Qualidade de Software — Gestão e Qualidade de Software (Ânima Educação).

## Estrutura

```
ecommerce-checkout-xunit/
├── EcommerceCheckout.slnx
├── EcommerceCheckout.App/        # Código de produção
│   ├── PedidoService.cs
│   └── Program.cs
└── EcommerceCheckout.Tests/      # Testes unitários (xUnit)
    └── PedidoServiceTests.cs
```

## Métodos (`PedidoService`)

| Método | Retorno | Regra |
|---|---|---|
| `GerarCodigoRastreio(string regiao, int numeroPedido)` | `string` | Região em maiúsculas + `-` + número do pedido com 4 dígitos (zeros à esquerda). Ex.: `("sudeste", 42)` → `"SUDESTE-0042"` |
| `CalcularPontosFidelidade(int valorTotal)` | `int` | A cada R$ 10 em compras, 2 pontos. Ex.: `150` → `30` |
| `TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)` | `bool` | Frete grátis se `valorTotal >= 200` **ou** cliente VIP. |

## Cobertura dos testes (`PedidoServiceTests`)

| Teste | Asserção | Cenário |
|---|---|---|
| `GerarCodigoRastreio_DeveGerarMascaraExata` | `Assert.Equal` | `"sudeste"`, 42 → `"SUDESTE-0042"` |
| `CalcularPontosFidelidade_DeveCalcularPontosCorretamente` | `Assert.Equal` | 150 → 30 |
| `TemDireitoAFreteGratis_ClienteVipAbaixoDe200_DeveRetornarTrue` | `Assert.True` | R$ 150, VIP |
| `TemDireitoAFreteGratis_ClienteNaoVipAbaixoDe200_DeveRetornarFalse` | `Assert.False` | R$ 150, não-VIP |

## Como executar

Pré-requisito: [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/SEU-USUARIO/ecommerce-checkout-xunit.git
cd ecommerce-checkout-xunit
dotnet test
```

Alunos:
Lucas Paiva Magalhães - RA: 4251925101
Luca Fernandes - RA: 4251924436
Guilherme de Oliveira Navais – RA: 4251923674
Anthony Rafael Braga Magalhães – RA: 4251924039
