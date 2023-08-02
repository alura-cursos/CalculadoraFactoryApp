namespace CalculadoraFactoryApp.Operacoes
{
    internal class Divisao : IOperacao
    {
        public double Calcular(double x, double y)
        {
            if (y == 0)
                throw new ArgumentException("Segundo argumento não pode ser menor ou igual a zero!");
            return x/y;
        }
    }
}
