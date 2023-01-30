var list = new List<int>() {4,3,1,2,5};
var n = list.Select(x=>x*x).ToList();
System.Console.WriteLine(string.Join(',',n));