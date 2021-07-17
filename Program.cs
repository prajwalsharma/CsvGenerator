using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace CsvGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Fetch data
            var employees = EmployeeRepository.GetEmployees();

            // 2. Set Path to store CSV file along with file name
            var pathToStoreFiles = $"D:\\Programming\\.NET Standard\\CsvGenerator\\CsvFiles\\employees.csv";

            // 3. Generate CSV 
            using (var writer = new StreamWriter(pathToStoreFiles))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(employees);
                }
            }
        }
    }
}
