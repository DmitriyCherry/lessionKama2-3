int Max(int value1, int value2, int value3)
{
  int result = value1;
  if (value2 > result) result = value2; 
  if (value3 > result) result = value3;
  return result;  
}

int [] array = {11,21,31,45,555,4343,545,5455,12};

int max = Max(
    Max(array[0],array[1],array[2]), 
    Max(array[3],array[4],array[5]), 
    Max(array[6],array[7],array[8]));
Console.WriteLine(max);
 