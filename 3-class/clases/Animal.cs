namespace clases;

public class Animal
{
    public String ruido = "--------";
    public String familia;


    public Animal(String familia)
    {
        this.familia = familia;
    }

    public virtual void hacerSonido()
    {
        Console.WriteLine($"El animal hace: {ruido}");
    }

    public virtual void mostrarFamilia()
    {
        Console.WriteLine($"El animal es de la familia: {familia}");
    }

    public virtual void mostrarInfo()
    {
        Console.WriteLine($"El animal tiene la onomatopeya: {ruido}\nEs de la familia: {familia}");
    }
}