//請實作一個 給定整數變數長、寬、高 ，計算並顯示長方體體積的功能
//使用者操作程式
//Enter Height of box(Meter):
//Enter Length of box(Meter):
//Enter Width of box(Meter):
//Volume(cublic meter):
//float ±1.5 x 10−45 到 ±3.4 x 1038

using Question1And2;

RectAngle rect = new RectAngle();
Console.WriteLine($"Enter Height of box(Meter):");
rect.Height = Console.ReadLine().StringToFloat();
Console.WriteLine($"Enter Length of box(Meter):");
rect.Length = Console.ReadLine().StringToFloat();
Console.WriteLine($"Enter Width of box(Meter):");
rect.Width = Console.ReadLine().StringToFloat();
Console.WriteLine($"Volume(cublic meter):  {rect}");

public static class Exception
{
    public static float StringToFloat(this string? input)
    {
        if (input == null) return 0;
        float.TryParse(input, out float result);
        return result;
    }
}