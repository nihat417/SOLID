using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_1;

#region before
//class Report
//{
//    public string Text { get; set; } = "";
//    public void GoToFirstPage() =>
//        Console.WriteLine("1 ci seyfeye kecid");
//
//    public void GoToLastPage() =>
//        Console.WriteLine("son seyfeye kecid");
//
//    public void GoToPage(int pageNumber) =>
//        Console.WriteLine($"{pageNumber} seyfesne kecid");
//
//
//    public void Print()
//    {
//        Console.WriteLine(Text);
//    }
//}

#endregion


#region after
class Report
{
    public string Text { get; set; } = "";
    public void GoToFirstPage() =>
        Console.WriteLine("1 ci seyfeye kecid");

    public void GoToLastPage() =>
        Console.WriteLine("son seyfeye kecid");

    public void GoToPage(int pageNumber) =>
        Console.WriteLine($"{pageNumber} seyfesine kecid");
}

class Printer
{
    public void PrintReport(Report report)
    {
        Console.WriteLine("cavab");
        Console.WriteLine(report.Text);
    }
}
#endregion