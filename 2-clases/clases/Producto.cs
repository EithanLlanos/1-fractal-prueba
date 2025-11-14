namespace clases;

public class Producto
{
    private String name = "";
    private int stock = 0;
    private double price = 0;



    private void ActualizarStock(int cant)
    {
        int currentStock = stock + cant;
        stock = currentStock < 0  ?  0 : currentStock  ;
    }

    public Producto(string name, int stock, double price)
    {
        this.name = name;
        this.stock = stock;
        this.price = price;
    }

    public string Name => name;

    public int Stock => stock;

    public double Price => price;
}