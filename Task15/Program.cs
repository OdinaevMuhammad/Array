var list = new List<int>() {1 ,2 ,3 ,4, 5};

var module = list.Where(x => x%2==1).Select(x => x*x*x);

System.Console.WriteLine(string.Join(" ", module));


var linq = (from e in list
            where e % 2==1
            select e*e*e);

            System.Console.WriteLine(string.Join(",",linq));