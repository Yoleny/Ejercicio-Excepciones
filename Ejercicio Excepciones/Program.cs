using Ejercicio_Excepciones;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número: ");
        string numero1 = Console.ReadLine();

        Console.WriteLine("Ingrese el segundo número: ");
        string numero2 = Console.ReadLine();

        try
        {
            double a = Convert.ToDouble(numero1);
            double b = Convert.ToDouble(numero2);

            Operaciones.Sumar(a, b);
            Operaciones.Restar(a, b);
            Operaciones.Multiplicar(a, b);
            Operaciones.Dividir(a, b);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar números válidos.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }
}
