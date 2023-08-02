﻿namespace CalculadoraFactoryApp.Operacoes
{
    internal class Multiplicacao : IOperacao
    {
        public double Calcular(double x, double y)
        {
            return x * y;
        }
    }
}
