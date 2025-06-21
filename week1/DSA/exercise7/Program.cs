using System;
using System.Collections.Generic;

class Program
{
    // Recursive method to calculate future value
    public static double ForecastValue(double initialValue, double growthRate, int years)
    {
        if (years == 0)
            return initialValue;

        return (1 + growthRate) * ForecastValue(initialValue, growthRate, years - 1);
    }

    // Optimized version using memoization
    public static double ForecastValueMemo(double initialValue, double growthRate, int years, Dictionary<int, double> memo)
    {
        if (years == 0)
            return initialValue;

        if (memo.ContainsKey(years))
            return memo[years];

        double result = (1 + growthRate) * ForecastValueMemo(initialValue, growthRate, years - 1, memo);
        memo[years] = result;
        return result;
    }

    static void Main(string[] args)
    {
        double initialValue = 1000;      // Starting amount
        double growthRate = 0.08;        // 8% annual growth
        int years = 5;

        Console.WriteLine("--- Recursive Forecast ---");
        double futureValue = ForecastValue(initialValue, growthRate, years);
        Console.WriteLine($"Future value after {years} years: {futureValue:F2}");

        Console.WriteLine("\n--- Optimized (Memoized) Forecast ---");
        double futureValueMemo = ForecastValueMemo(initialValue, growthRate, years, new Dictionary<int, double>());
        Console.WriteLine($"Future value after {years} years: {futureValueMemo:F2}");
    }
}
