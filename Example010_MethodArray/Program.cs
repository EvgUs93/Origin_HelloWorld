int[] array = { 14, 22, 88, 48, 35, 66, 17, 88 };

int n = array.Length;
int find = 88;

int index =0;

while ( index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}