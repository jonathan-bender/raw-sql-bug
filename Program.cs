using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBugV3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string query =
                "SELECT CustomerId, FirstName AS CustomerName FROM Customers UNION ALL  SELECT CustomerId, LastName AS CustomerName FROM Customers";

            using (var db = new ApplicationContext())
            {
                var details = db.UnpivotedCustomers.FromSqlRaw(query).ToList();

                foreach (var detail in details)
                {
                    Console.WriteLine($"{detail.CustomerId}\t{detail.CustomerName}");
                }
            }

            Console.WriteLine();
        }
    }
}
