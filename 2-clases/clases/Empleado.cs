namespace clases;

public class Empleado
{
    private String nombre;
    private string cargo;
    private double sueldo;


    private double CalcularBono(double percentage)
    {
        return sueldo * (percentage/100);
    }
}