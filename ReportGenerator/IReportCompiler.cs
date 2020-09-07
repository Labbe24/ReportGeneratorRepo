using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator
{
    public interface IReportCompiler
    {
        void CompileReport(List<Employee> employees);

    }
}
