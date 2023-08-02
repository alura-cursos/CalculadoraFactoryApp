using CalculadoraFactoryApp.Operacoes;

namespace CalculadoraFactoryApp.Factory
{
    internal static class FabricaDeOperacoes
    {
        public static IOperacao? GetOperacao(string operacao)
        {
            if (string.IsNullOrWhiteSpace(operacao)) { return null; }
            switch (operacao)
            {
                case "soma":
                    return new Soma();
                case "subtracao":
                    return new Subtracao();
                case "divisao":
                    return new Divisao();
                case "multiplicacao":
                    return new Multiplicacao();
                default:
                    return null;
            }
        }
    }
}
