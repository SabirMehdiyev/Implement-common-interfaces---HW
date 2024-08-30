namespace Implement_common_interfaces___HW;

using System;
using System.Collections.Generic;

public class CarComparer : IComparer<Car>
{
    private readonly string _sortBy;

    public CarComparer(string sortBy)
    {
        _sortBy = sortBy ?? throw new ArgumentNullException();
    }

    public int Compare(Car x, Car y)
    {
        if (x == null) throw new ArgumentNullException();
        if (y == null) throw new ArgumentNullException();

        switch (_sortBy)
        {
            case "Name":
                return string.Compare(x.Name, y.Name);
            case "MaxMph":
                return x.MaxMph.CompareTo(y.MaxMph);
            case "Horsepower":
                return x.Horsepower.CompareTo(y.Horsepower);
            case "Price":
                return x.Price.CompareTo(y.Price);
            default:
                throw new ArgumentException("Invalid sort field");
        }
    }
}

