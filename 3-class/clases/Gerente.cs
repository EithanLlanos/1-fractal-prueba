namespace clases;

public class Gerente:Empleado
{
    public double Bono;

    public Gerente(string nombre, string cargo, double sueldo, double bono) : base(nombre, cargo, sueldo)
    {
        Bono = bono;

        List<Empleado> equipo = new List<Empleado>();
        equipo.Add(new Empleado("Juan", "",3000));
        equipo.Add(new Empleado("Ana","",3200.100));

        foreach (Empleado empleado in equipo)
        {
            
        }
    }
    
    public override void MostrarInfo()
    {
        Console.WriteLine($"Gerente: {Nombre}, Salario: {this.Sueldo}, Bono: {Bono}");
    }


}