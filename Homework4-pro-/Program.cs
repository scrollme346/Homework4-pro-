using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

     // Перегрузка оператора +
    public static Employee operator +(Employee employee, double amount)
    {
        employee.Salary += amount;
        return employee;
    }

    // Перегрузка оператора -
    public static Employee operator -(Employee employee, double amount)
    {
        employee.Salary -= amount;
        return employee;
    }

     // Перегрузка оператора ==
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        return employee1.Salary == employee2.Salary;
    }

    // Перегрузка оператора !=
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return employee1.Salary != employee2.Salary;
    }

    // Перегрузка оператора >
    public static bool operator >(Employee employee1, Employee employee2)
    {
        return employee1.Salary > employee2.Salary;
    }

    // Перегрузка оператора <
    public static bool operator <(Employee employee1, Employee employee2)
    {
        return employee1.Salary < employee2.Salary;
    }

    // Перегрузка метода Equals
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Employee otherEmployee = (Employee)obj;
        return this.Salary == otherEmployee.Salary;
    }

    // Перегрузка метода GetHashCode
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("John", 50000);

        Console.WriteLine("Имя сотрудника: " + employee.Name);
        Console.WriteLine("Зарплата сотрудника: " + employee.Salary);

        employee += 5000;

        Console.WriteLine("\nПосле изменения зарплаты");
        Console.WriteLine("Зарплата сотрудника: " + employee.Salary);
    }
}
