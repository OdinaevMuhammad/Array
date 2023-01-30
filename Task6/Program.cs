var list = new List<int>() { 5, 3, 1, 2, 5, 4, 3 };
list.Sort();
list.Reverse();
var max = list.Distinct().Take(3);

System.Console.Write(string.Join(' ',max));
