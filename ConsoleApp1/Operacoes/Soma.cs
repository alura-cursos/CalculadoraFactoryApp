namespace CalculadoraFactoryApp.Operacoes
{
    internal class Soma : IOperacao
    {
        public double Calcular(double x, double y)
        {
            return x + y;
        }
    }
}
