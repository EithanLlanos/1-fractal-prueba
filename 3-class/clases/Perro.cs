namespace clases;

public class Perro:Animal
{
    public String onomatopeya = "Guau";
    public String raza;

    public Perro(string raza) : base("Canidae")
    {
        this.raza = raza;
    }

    
    public override void hacerSonido()
    {
        Console.WriteLine($"El perro hace {onomatopeya}");
    }

    public override void mostrarFamilia()
    {
        Console.WriteLine($"El perro es de la familia {familia}");
    }

    public override void mostrarInfo()
    {
        Console.WriteLine($"El perro tiene la onomatopeya: {onomatopeya}\n" +
                          $"El perro es de la familia    : {familia}\n" +
                          $"El perro es de la raza       : {raza}");
    }


}