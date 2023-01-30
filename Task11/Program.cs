using System.Collections.Generic;
var list = new List<int>(){3 ,3 ,2, 2, 1, 1, 2 };

// list.ForEach(i => {if(i%2==1) System.Console.WriteLine(i);});

var module = list.Where(x => x % 2 == 1);

System.Console.WriteLine(string.Join(" ", module));