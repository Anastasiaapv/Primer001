int [] array = {1,82,34,4,75,68,577,68};
int n = array.Length;
int find=68;
int index = 0;
while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}