using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_1.Liskov_P;

#region before
//public class SumCalculator
//{
//    protected readonly int[] _numbers;
//    public SumCalculator(int[] numbers)
//    {
//        _numbers = numbers;
//    }
//    public int Calculate() => _numbers.Sum();
//}
//
//
//public class EvenNumbersSumCalculator : SumCalculator
//{
//    public EvenNumbersSumCalculator(int[] numbers)
//        : base(numbers)
//    {
//    }
//    public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
//}
//
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
//        SumCalculator sum = new SumCalculator(numbers);
//        Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");
//        Console.WriteLine();
//        EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
//        Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");
//    }
//}

#endregion

#region after


public abstract class Calculator
{
    protected readonly int[] _numbers;
    public Calculator(int[] numbers)
    {
        _numbers = numbers;
    }
    public abstract int Calculate();
}

public class SumCalculator : Calculator
{
    public SumCalculator(int[] numbers)
        : base(numbers)
    { }
    public override int Calculate() => _numbers.Sum();
}

public class EvenNumberSumCalculator : Calculator
{
    public EvenNumberSumCalculator(int[] numbers)
        : base(numbers)
    { }
    public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
}
#endregion
