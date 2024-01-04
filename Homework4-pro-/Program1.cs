using System;

class City
{
    private int population;

    public int Population
    {
        get { return population; }
        set { population = value; }
    }

    public static City operator +(City city, int increase)
    {
        city.Population += increase;
        return city;
    }

    public static City operator -(City city, int decrease)
    {
        city.Population -= decrease;
        return city;
    }

    public static bool operator ==(City city1, City city2)
    {
        return city1.Population == city2.Population;
    }

    public static bool operator !=(City city1, City city2)
    {
        return city1.Population != city2.Population;
    }

    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }

    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }

    public override bool Equals(object obj)
    {
        if (obj is City otherCity)
        {
            return this.Population == otherCity.Population;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        City city1 = new City();
        city1.Population = 100000;

        City city2 = new City();
        city2.Population = 150000;

        City increasedCity = city1 + 5000;
        City decreasedCity = city2 - 10000;

        Console.WriteLine("Увеличенное население города: " + increasedCity.Population);
        Console.WriteLine("Уменьшенное население города: " + decreasedCity.Population);

        // Проверка на равенство
        bool areEqual = city1 == city2;
        Console.WriteLine("Города равны: " + areEqual);

        // Проверка на неравенство
        bool areNotEqual = city1 != city2;
        Console.WriteLine("Города не равны: " + areNotEqual);

        // Проверка на меньшее или больше
        bool isCity1Smaller = city1 < city2;
        Console.WriteLine("Город 1 меньше: " + isCity1Smaller);

        bool isCity1Greater = city1 > city2;
        Console.WriteLine("Город 1 больше: " + isCity1Greater);

        // Проверка метода Equals
        bool areEqualWithEquals = city1.Equals(city2);
        Console.WriteLine("Метод Equals: " + areEqualWithEquals);

    }
}
