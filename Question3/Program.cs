using System.Text;

//為不可變的參考類型 "abc"會產生不可變實體 str1與str2指向同一個實體
string str1 = "abc";
string str2 = "abc";
string str3 = "abcd"; // 產生不同實體"abcd"
Console.WriteLine($"Reference equal for string：{ReferenceEquals(str1, str2)}");
Console.WriteLine($"Reference equal for string：{ReferenceEquals(str1, str3)}");

//特別New 才會不同
string strnew1 = new string("abc");
string strnew2 = new string("abc");
Console.WriteLine($"Reference equal for string：{ReferenceEquals(strnew1, strnew2)}");

//不可變的 實值型別  比較參考會因為 value->reference 產生 boxing 永遠無法相等
int int1 = 1;
int int2 = 1;

Console.WriteLine($"Reference equal for int：{ReferenceEquals(int1, int2)}");

//像是一般的類別  相較普通的String可以重複使用實體  因本來就是不同參考 -> False
StringBuilder sb1 = new StringBuilder("abc");
StringBuilder sb2 = new StringBuilder("abc");

Console.WriteLine($"Reference equal for StringBuilder：{ReferenceEquals(sb1, sb2)}");