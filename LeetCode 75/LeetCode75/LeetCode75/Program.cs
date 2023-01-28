// See https://aka.ms/new-console-template for more information
using LeetCode75.Code;

Console.WriteLine("1480. Running_Sum_of_1d_Array");
Console.WriteLine("-----------------------------");
var Code1480 = new Running_Sum_of_1d_Array_1480();
var data = Code1480.GetInitialData();
var result = Code1480.RunningSum(data);
Code1480.PrintResult(data, result);
Console.WriteLine();