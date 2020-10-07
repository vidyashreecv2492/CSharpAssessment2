using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Customer
    {
        public Customer(int customerID, string name, string address, double salary)
        {
            CustomerID = customerID;
            Name = name;
            Address = address;
            Salary = salary;
        }

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
    }
    interface ICustomerManager
    {
        bool AddCustomer(Customer cm);
        bool DeleteCustomer(int id);
        bool UpdateCustomer(int id);
        bool ViewAllCustomer();
    }
    class CustomerManager : ICustomerManager
    {
        HashSet<Customer> customers = new HashSet<Customer>();
        public bool AddCustomer(Customer cm)
        {
            return customers.Add(cm);
        }

        public bool DeleteCustomer(int id)
        {
            foreach (Customer cm in customers)
            {
                if (cm.CustomerID == id)
                {
                    customers.Remove(cm);
                    return true;
                }
            }
            return false;
        }
        public bool UpdateCustomer(int id)
        {
            foreach (Customer cm in customers)
            {
                if (cm.CustomerID == id)
                {
                    Console.Write("Enter the New Name: ");
                    string newname = Console.ReadLine();
                    Console.Write("Enter the New Address: ");
                    string newaddress = Console.ReadLine();
                    Console.Write("Enter the New Salary: ");
                    double newsalary = double.Parse(Console.ReadLine());
                    cm.Name = newname;
                    cm.Address = newaddress;
                    cm.Salary = newsalary;
                    return true;
                }
            }
            return false;
        }
        public bool ViewAllCustomer()
        {
            foreach (var cm in customers)
            {
                C
                Console.WriteLine($"ID: {cm.CustomerID}");
                Console.WriteLine($"Name: {cm.Name}");
                Console.WriteLine($"Address: {cm.Address}");
                Console.WriteLine($"Author: {cm.Salary}");
               
            }
            return true;
        }
    }

    class CustomerManagerDemo
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(01, "vidya", "supreetha", 86900);
            Customer c2 = new Customer(02, "max", "john", 195610);
            Customer c3 = new Customer(03, "Raj", "Ram", 1200);
            CustomerManager mgr = new CustomerManager();
            mgr.AddCustomer(c1);
            mgr.AddCustomer(c2);
            mgr.AddCustomer(c3);

            mgr.ViewAllCustomer();
            mgr.DeleteCustomer(20);
            mgr.ViewAllCustomer();
        }

    }
}