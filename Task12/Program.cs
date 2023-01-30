using System.Collections.Generic;
var list = new List<int>(){13, 2, 5, 3, 11, 7 };

// list.ForEach(i => {if(i%2==1) System.Console.WriteLine(i);});

list.Sort();

System.Console.WriteLine(string.Join(" ", list.Where(x => x%2==1)));