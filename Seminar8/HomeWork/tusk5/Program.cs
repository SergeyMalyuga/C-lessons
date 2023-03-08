int sum =0;
int a =1;
int x=0;
int count=0;

while (sum<=25)
{
for (int i=x; i<7; i++)
{
    a+=2;
    Console.Write($"{i} " );
    count+=1;
}
   sum+=count-1; 
   x+=3;
   for (int j=0; j<1; j++)
   {
     
     Console.Write($"({sum}) ");
    count+=1;
   }
}
Console.WriteLine();
Console.WriteLine($"{a} {sum}");
