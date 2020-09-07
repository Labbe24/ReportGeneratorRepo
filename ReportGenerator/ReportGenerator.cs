using System;
using System.Collections.Generic;

namespace ReportGenerator
{
    public enum ReportOutputFormatType
    {
        NameFirst,
        SalaryFirst,
        AgeFirst
    }

    public class ReportGenerator
    {
        private readonly EmployeeDB _employeeDb;
        private ReportOutputFormatType _currentOutputFormat;
        private IReportCompiler _irpCompiler;


        public ReportGenerator(EmployeeDB employeeDb)
        {
            if (employeeDb == null) throw new ArgumentNullException("employeeDb");
            _irpCompiler = new ReportCompilerNameFirst();
            _currentOutputFormat = ReportOutputFormatType.NameFirst;
            _employeeDb = employeeDb;
        }


        public void CompileReport()
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDb.Reset();

            // Get all employees
            while ((employee = _employeeDb.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }

            // All employees collected - let's output them
            _irpCompiler.CompileReport(employees);
        }

        public void SetOutputFormat(ReportOutputFormatType format)
        {
            _currentOutputFormat = format;
        }

        public void SetCompiler(IReportCompiler irCompiler)
        {
            _irpCompiler = irCompiler;
        }
    }
}