using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        int maxHt = 0;
        int Count = 0;
        foreach (int candle in candles)
        {
            if (candle > maxHt)
            {
                maxHt = candle;
                Count = 1;
            }
            else if (candle == maxHt)
            {
                Count++;
            }
        }
        return Count;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
        int result = Result.birthdayCakeCandles(candles);
        Console.WriteLine(result);
    }
}