namespace Implement_common_interfaces___HW;

internal class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("BMW", 1000, 3, 80_000m);
        Car car2 = new Car("Mercedes", 2000, 1, 50_000m);
        Car car3 = new Car("Mitsubishi", 5000, 13, 100_000m);
        Car car4 = new Car("Mitsubishi", 5000, 13, 100_000m);

        CarComparer carComparer = new CarComparer("Price");

        Car[] cars = { car1, car2, car3 };

        Console.WriteLine("Result " + car1.CompareTo(car2));

        Array.Sort(cars, carComparer);

        Console.WriteLine("Sorted cars");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        Console.WriteLine(" Car3 and car 4 equal:" + car3.Equals(car4));


        Car clonedCar = (Car)car1.Clone();
        car1.Price = 200_000m;

        Console.WriteLine("Cloned car price: " + clonedCar.Price);
    }

}
