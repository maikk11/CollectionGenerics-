class Car
{
    public string Name {get;}
    public decimal Price {get;}
    public int Kilometers {get;}
    public Car(string name, decimal price, int kilometers)
    {
        this.Name=name;
        this.Price=price;
        this.Kilometers=kilometers;
    }
}