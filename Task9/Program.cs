var list = new List<int>(){1, 2 ,3 ,4, 5,6,7,8,9,10};

var n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n*2; i++)
{
    if(i%2==1)
    {
        System.Console.Write(i);
        System.Console.Write(" ");
    }
}

