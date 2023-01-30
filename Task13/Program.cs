using System.Collections.Generic;
var list = new List<int>(){1 ,2 ,3 ,4, 5, 6, 7, 8 };
// list.ForEach(i => {if(i%2==1) System.Console.WriteLine(i);});


var module =  list.Where(x => x % 2==1 );
System.Console.WriteLine(string.Join(" ",module.Select(x => x*x)));



var linq = (from e in list
            where e % 2==1
            select e*e);

            System.Console.WriteLine(string.Join(",",linq));