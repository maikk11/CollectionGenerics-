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
    public override bool Equals(object? obj)
    {
        if(obj is not Car altra)
        {
            return false;
        }
        return this.Name==altra.Name && this.Price==altra.Price && this.Kilometers==altra.Kilometers;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Price, Kilometers);
    }
}