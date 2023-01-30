var list = new List<int>() { 12, 44, 55, 77, 89 };
var n = Convert.ToInt32(Console.ReadLine());
var min = 1e9;
int mn = 0;
list.ForEach(i =>
{
    int t = Math.Abs(n - i);
    if (min > t)
    {
        min = t;
        mn = i;
    }

});
System.Console.WriteLine(mn);