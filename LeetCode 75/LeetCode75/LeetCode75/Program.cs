// See https://aka.ms/new-console-template for more information
using LeetCode75.Code;

No1480();
No724();
No205();
No392();
No21();
No206();

static void No1480()
{
    Console.WriteLine("1480. Running_Sum_of_1d_Array");
    Console.WriteLine("-----------------------------");
    int[] data, result;
    var Code1480 = new D1_1_Running_Sum_of_1d_Array_No1480();
    data = Code1480.GetInitialData();
    result = Code1480.RunningSum(data);
    Code1480.PrintResult(data, result);
    Console.WriteLine();
}

static void No724()
{
    Console.WriteLine("724. Find Pivot Index");
    Console.WriteLine("-----------------------------");
    var Code724 = new D1_2_Find_Pivot_Index_No724();
    var data = Code724.GetInitialData();
    var result = Code724.PivotIndex(data);
    Code724.PrintResult(data, result);
    Console.WriteLine();
}

static void No205()
{
    Console.WriteLine("205. Isomorphic Strings");
    Console.WriteLine("-----------------------------");
    var Code = new D2_1_Isomorphic_Strings_No205();
    var data = Code.GetInitialData();
    var result = Code.IsIsomorphic(data[0], data[1]);
    Code.PrintResult(data[0], data[1], result);
    Console.WriteLine();
}

static void No392()
{
    Console.WriteLine("392. Is Subsequence");
    Console.WriteLine("-----------------------------");
    var Code = new D2_2_Is_Subsequence_No392();
    var data = Code.GetInitialData();
    var result = Code.IsSubsequence(data[0], data[1]);
    Code.PrintResult(data[0], data[1], result);
    Console.WriteLine();
}

static void No21()
{
    Console.WriteLine("21. Merge Two Sorted Lists");
    Console.WriteLine("-----------------------------");
    var Code = new D3_1_Merge_Two_Sorted_Lists_No21();
    var data = Code.GetInitialData();
    var result = Code.MergeTwoLists(data[0], data[1]);
    Code.PrintResult(result);
    Console.WriteLine();
}

static void No206()
{
    Console.WriteLine("206. Reverse Linked List");
    Console.WriteLine("-----------------------------");
    var Code = new D3_2_Reverse_Linked_List_No206();
    var data = Code.GetInitialData();
    var result = Code.ReverseList(data[0]);
    Code.PrintResult(result);
    Console.WriteLine();
}