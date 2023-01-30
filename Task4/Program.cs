var list = new List<int>(){6, 4 ,5 ,3, 2, 1};


list.Sort();
var min = list.Take(3);

System.Console.Write(string.Join(' ',min));
  
