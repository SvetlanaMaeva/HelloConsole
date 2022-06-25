int[] array = { 15, 266, 34, 48, 599, 656, 76, 877, 877};

int n = array.Length;
int find = 877;

int index = 0;
 while (index < n)
 {
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

 }