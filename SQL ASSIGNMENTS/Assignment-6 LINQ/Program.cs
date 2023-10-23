using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOJ { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> EmpList = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984,11,16), DOJ = new DateTime(2011, 8, 6), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 12, 4), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 7, 11), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 2, 12), DOJ = new DateTime(2015, 1, 6), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 6, 11), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 12, 8), DOJ = new DateTime(2014, 3, 12), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 2, 1), City = "Pune" }
        };

        // 1: Display employees who joined before 1/1/2015
        Console.WriteLine("1.Employees who joined before 1 / 1 / 2015:\n--------------------------");
        var before2015 = EmpList.Where(e => e.DOJ < new DateTime(2015, 1, 1));
        foreach (var emp in before2015)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}, {emp.DOJ.ToShortDateString()}");
        }

        Console.WriteLine();

        //2: Display employees born after 1/1/1990
        var BornAfter1990 = EmpList.Where(e => e.DOB > new DateTime(1990, 1, 1));
        Console.WriteLine("2.Employees born after 1/1/1990:\n-------------------------------------");
        foreach (var employee in BornAfter1990)
        {
            Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");
        }

        Console.WriteLine();

        //3: Display consultants and associates
        var consultantsAndAssociates = EmpList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
        Console.WriteLine("3.Consultants and Associates:\n------------------------------------------");
        foreach (var employee in consultantsAndAssociates)
        {
            Console.WriteLine($"{employee.EmployeeID}: {employee.FirstName} {employee.LastName}");
        }

        Console.WriteLine();

        //4: Total number of employees
        Console.WriteLine($"4.Total number of Employees :  {EmpList.Count} ");
        Console.WriteLine();

        //5: Total number of employees in Chennai
        Console.WriteLine($"5.Total number of employees belonging to Chennai : {EmpList.Count(e => e.City == "Chennai")}");
        Console.WriteLine();

        //6.Higest Employee id
        int maxEmployeeID = EmpList.Max(e => e.EmployeeID);
        Console.WriteLine($"6.Highest Employee ID: {maxEmployeeID}");
        Console.WriteLine();

        //7: Employees joined after 1/1/2015
        Console.WriteLine($"7.Total number of employees joined after 1/1/2015: {EmpList.Count(e => e.DOJ > new DateTime(2015, 1, 1))}");
        Console.WriteLine();

        //8: Employees with titles not "Associate"
        Console.WriteLine($"8.Total number of employees whose title is not 'Associate': {EmpList.Count(e => e.Title != "Associate")}");
        Console.WriteLine();

        // 9: Total number of employees based on city
        var cityCounts = EmpList.GroupBy(e => e.City).Select(g => new { City = g.Key, Count = g.Count() });
        Console.WriteLine("9.Total number of employees based on City:\n------------------------------------------------");
        foreach (var city in cityCounts)
        {
            Console.WriteLine($"{city.City}: {city.Count}");
        }
        Console.WriteLine();

        //10: Total number of employees based on city and title
        var employeesByCityAndTitle = EmpList.GroupBy(e => new { e.City, e.Title }).Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() });
        Console.WriteLine("10.Total number of employees based on City and Title:\n-----------------------------------------");
        foreach (var group in employeesByCityAndTitle)
        {
            Console.WriteLine($"{group.City}, {group.Title}: {group.Count}");
        }
        Console.WriteLine();

        // Task 11: Youngest employee
        var youngestEmployee = EmpList.OrderBy(e => e.DOB).Last();
        Console.WriteLine($"11.Youngest employee:{youngestEmployee.FirstName} {youngestEmployee.LastName}");

        Console.ReadLine();
    }
}