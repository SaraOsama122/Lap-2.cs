using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace HelloWorld
{
    public class Employee
    {
        private int id;
        private string name;
        private int age;
        private double salary;

        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0) id = value;
                else 
				Console.WriteLine("ID is not correct");
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18) 
				age = value;
                else 
				Console.WriteLine("Age not allowed");
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0) salary = value;
                else 
				Console.WriteLine("Salary is not correct");
            }
        }
    } 
    public class Program
    {
        static List<Employee> employeesList = new List<Employee>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Plz Enter 1 To Add Employee");
                Console.WriteLine("Plz Enter 3 To Delete Employee");
                Console.WriteLine("Plz Enter 4 To Get All Employee");

                int i = int.Parse(Console.ReadLine());

                if (i == 1) add();
                else if (i == 2) delete();
                else if (i == 3) get();
            }
        }
        public static void add()
        {
            Employee emp = new Employee();

            Console.Write("Enter ID: ");
            emp.ID = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Age: ");
            emp.Age = int.Parse(Console.ReadLine());

            Console.Write("Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());

            employeesList.Add(emp);
        }

        public static void delete()
        {
            Console.Write("Enter Id :");
            int id = int.Parse(Console.ReadLine());

            Employee emp = null;

            for (int i = 0; i < employeesList.Count; i++)
            {
                if (employeesList[i].ID == id)
                {
                    emp = employeesList[i];
                    break;
                }
            }

            if (emp != null)
            {
                employeesList.Remove(emp);
                Console.WriteLine("Employee is deleted");
            }
            else
            {
                Console.WriteLine("Employee is not Found");
            }
        }

        public static void get()
        {
            if (employeesList.Count == 0)
            {
                Console.WriteLine("no employee found");
            }
            else
            {
                for (int i = 0; i < employeesList.Count; i++)
                {
                    Console.WriteLine((i + 1) + " - " + employeesList[i].Name + " -" + employeesList[i].Age + " -" + employeesList[i].Salary);
                }
            }
        }
    } 
}
