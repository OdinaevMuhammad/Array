var list = new List<int>(){1, 2 ,3 ,1, 2};

var n = list.Select(x=>x*x*x).ToList();
System.Console.WriteLine(string.Join(',',n));
