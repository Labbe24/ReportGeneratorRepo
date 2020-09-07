using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator
{
    public class ReportCompilerAgeFirst : IReportCompiler
    {
    void IReportCompiler.CompileReport(List<Employee> employees)
    {
        Console.WriteLine("Age-first report");
        foreach (var e in employees)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Age: {0}", e.Age);
            Console.WriteLine("Name: {0}", e.Name);
            Console.WriteLine("Salary: {0}", e.Salary);
            Console.WriteLine("------------------");
        }
    }
    }
}
