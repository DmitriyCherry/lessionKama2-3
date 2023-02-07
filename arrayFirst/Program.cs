int Max(int value1, int value2, int value3)
{
  int result = value1;
  if (value2 > result) result = value2; 
  if (value3 > result) result = value3;
  return result;  
}

int a1 = 22;
int b1 = 123;
int c1 = 13;
int a2 = 21;
int b2 = 1345;
int c2 = 65;
int a3 = 3;
int b3 = 12;
int c3 = 60933;

int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));
Console.WriteLine(max);
 