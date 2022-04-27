//找出陣列只出現一次的元素
var result = new TestSingle().SingleNumber(new int[] { 1 });
Console.WriteLine(result);

public class TestSingle
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;
        var IsFindTwo = false;
        for (int ForOut = 0; ForOut < nums.Length; ForOut++)
        {
            result = nums[ForOut];
            IsFindTwo = false; //重置比較bool
            for (int Forin = 0; Forin < nums.Length; Forin++)
            {
                if (nums[Forin] - nums[ForOut] == 0 && Forin != ForOut) IsFindTwo = true;
            }

            if (IsFindTwo == false) break;
        }

        return result;
    }
}