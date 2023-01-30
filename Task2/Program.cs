

var arr = new int[5];

for (int i = 0; i < 5; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());   
}

var sum = arr.Sum();
System.Console.WriteLine(string.Join(',', sum));