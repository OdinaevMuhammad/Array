    var list = new List<int>() { 1, 3, 3, 3, 4 };

int min = list.Min();
int max = list.Max();

// for(int i  =0; i< list.Count; i++)
// {
//     if(list[i] == max) list[i] = min;
// }



// foreach (var el in list)
//     System.Console.WriteLine(el);


    var linq =
           (from item in list
            where item == max
            select new {
                item = min
            });

   foreach (var item in linq)
   {
        System.Console.WriteLine(item);
   }