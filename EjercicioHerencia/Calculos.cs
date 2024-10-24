public class Calculos : Operaciones
{
  
    public override double CalcularAreaCirculo(double radio)
    {
        resultado = base.CalcularAreaCirculo(radio);
        return resultado;
    }

    public override double CalcularVolumenCubo(double lado)
    {
        resultado = base.CalcularVolumenCubo(lado);
        return resultado;
    }

    public override double CalcularPerimetroRectangulo(double largo, double ancho)
    {
        resultado = base.CalcularPerimetroRectangulo(largo, ancho);
        return resultado;
    }

   
    public void Imprimir(double radio, double lado, double largo, double ancho)
    {
        Console.WriteLine("Resultados de las operaciones:");
        Console.WriteLine($"Área del círculo (radio = {radio}): {CalcularAreaCirculo(radio):F2}");
        Console.WriteLine($"Volumen del cubo (lado = {lado}): {CalcularVolumenCubo(lado):F2}");
        Console.WriteLine($"Perímetro del rectángulo (largo = {largo}, ancho = {ancho}): {CalcularPerimetroRectangulo(largo, ancho):F2}");
    }
}