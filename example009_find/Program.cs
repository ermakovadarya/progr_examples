int[] array={11,12,13,14,15,666,777,333,14};

int n= array.Length;
int find=14;

int index=0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
