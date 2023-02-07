int [] array = { 12, 23, 43, 54, 35, 56, 756, 876, 32, 11, 2 };

int n = array.Length;
int find = 56; 
int index = 0;

while(index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; 
}
