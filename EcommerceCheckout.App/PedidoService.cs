namespace EcommerceCheckout.App;

public class PedidoService
{
    /// <summary>
    /// Gera o código de rastreio: região em maiúsculas + "-" + número do pedido com 4 dígitos.
    /// Exemplo: ("sudeste", 42) => "SUDESTE-0042".
    /// </summary>
    public string GerarCodigoRastreio(string regiao, int numeroPedido)
    {
        return $"{regiao.ToUpperInvariant()}-{numeroPedido:D4}";
    }

    /// <summary>
    /// Cada R$ 10 em compras rende 2 pontos de fidelidade.
    /// Exemplo: 150 => (150 / 10) * 2 = 30.
    /// </summary>
    public int CalcularPontosFidelidade(int valorTotal)
    {
        return (valorTotal / 10) * 2;
    }

    /// <summary>
    /// Frete grátis se o valor total for >= R$ 200 OU se o cliente for VIP.
    /// </summary>
    public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
    {
        return valorTotal >= 200 || eClienteVIP;
    }
}
