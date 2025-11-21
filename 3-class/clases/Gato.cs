namespace clases;

public class Gato:Animal
{
    private string onomatopeya = "Miau";
    private string raza = "";

    public Gato(string raza) : base("Felinae")
    {
        this.raza = raza;
    }

    public override void hacerSonido()
    {
        Console.WriteLine($"El gato hace {onomatopeya}");
    }

    public override void mostrarFamilia()
    {
        Console.WriteLine($"El gato es de la familia {familia}");
    }

    public override void mostrarInfo()
    {
        Console.WriteLine($"El gato tiene la onomatopeya: {onomatopeya}\n" +
                          $"El gato es de la familia    : {familia}\n" +
                          $"El gato es de la raza       : {raza}");
    }

}