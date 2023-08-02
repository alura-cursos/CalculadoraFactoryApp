namespace CalculadoraFactoryApp.Operacoes
{
    internal class Subtracao : IOperacao
    {
        public double Calcular(double x, double y)
        {
            return x - y;
        }
    }
}
