namespace Implement_common_interfaces___HW;

public class Car : IComparable<Car>, IEquatable<Car>, ICloneable
{
    public string Name { get; set; }
    public int MaxMph { get; set; }
    public int Horsepower { get; set; }
    public decimal Price { get; set; }

    public Car(string name, int maxMph, int horsepower, decimal price)
    {
        Name = name;
        MaxMph = maxMph;
        Horsepower = horsepower;
        Price = price;
    }

    public override string ToString()
    {
        return $"Name: {Name}, MaxMph: {MaxMph}, Horsepower: {Horsepower}, Price: {Price}";
    }

    public int CompareTo(Car? other)
    {
        if (other == null)
            throw new NullReferenceException();
        return Price.CompareTo(other.Price); 
    }

    public bool Equals(Car? other)
    {
        if (other == null) return false;
        return Name == other.Name &&
               MaxMph == other.MaxMph &&
               Horsepower == other.Horsepower &&
               Price == other.Price;
    }

    public object Clone()
    {
        return new Car(Name, MaxMph, Horsepower, Price);
    }

}
