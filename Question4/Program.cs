//陣列由小到大排序
var List = new TestSortArrary().SortArray(new int[] { 9, 2, 1, 8, 6 });
foreach (var item in List)
{
    Console.Write($"{item}  ");
}

public class TestSortArrary
{
    public int[] SortArray(int[] nums)
    {
        void Swap(ref int Value1, ref int Value2)
        {
            var temp = Value2;
            Value2 = Value1;
            Value1 = temp;
        }

        for (int Forout = 0; Forout < nums.Length; Forout++)
        {
            for (int Forin = Forout + 1; Forin < nums.Length; Forin++)
            {
                if (nums[Forout] > nums[Forin]) Swap(ref nums[Forout], ref nums[Forin]);
            }
        }

        return nums;
    }
}