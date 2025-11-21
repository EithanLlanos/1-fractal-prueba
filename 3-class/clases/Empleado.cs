namespace clases;

public class Empleado
{
    private String nombre;
    private string cargo;
    private double sueldo;

    public Empleado(string nombre, string cargo, double sueldo)
    {
        this.nombre = nombre;
        this.cargo = cargo;
        this.sueldo = sueldo;
    }

    private double CalcularBono(double percentage)
    {
        return sueldo * (percentage/100);
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Cargo
    {
        get => cargo;
        set => cargo = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Sueldo
    {
        get => sueldo;
        set => sueldo = value;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Empleado: {Nombre}, Salario: {sueldo}");
    }


    public virtual void MostrarStatus()
    {
        Console.WriteLine($"El estatus actual de {nombre} es Empleado");
    }

    public virtual void MostrarCargo()
    {
        Console.WriteLine($"El");
    }
}