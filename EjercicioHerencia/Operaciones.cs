public class Operaciones
{
    protected double resultado;

        public virtual double CalcularAreaCirculo(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public virtual double CalcularVolumenCubo(double lado)
    {
        return Math.Pow(lado, 3);
    }

        public virtual double CalcularPerimetroRectangulo(double largo, double ancho)
    {
        return 2 * (largo + ancho);
    }
}
