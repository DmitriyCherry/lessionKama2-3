void FullArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
       collection[index] = new Random().Next(1, 10);
       index++;   
    }
}

void PrintArray(int [] randomNameArray)
{
    int index = 0;
    while(index < randomNameArray.Length)
    {
        Console.WriteLine(randomNameArray[index]);
        index++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int result = 0;
    while(index < count)
    {
        if(collection[index] == find) 
        {
           result = index;
           break;
        }
        index++;         
    }
    return result;
}

int [] array = new int [10];
FullArray(array);
PrintArray(array);

int position = IndexOf(array, 4);
Console.WriteLine();
Console.WriteLine(position);

