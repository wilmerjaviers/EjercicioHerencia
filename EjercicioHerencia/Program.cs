class Program
{
    static void Main(string[] args)
    {
       
        Calculos calculos = new Calculos();

        double radio = 5;
        double lado = 3;
        double largo = 10;
        double ancho = 5;

        
        calculos.Imprimir(radio, lado, largo, ancho);

    }
}