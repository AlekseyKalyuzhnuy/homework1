int numberA=-9;
int numberB=-3;
if(numberA> numberB)
{ 
   int max= numberA;
   int min= numberB;
   Console.Write("max= ");
   Console.WriteLine(max);
   Console.Write("min= ");
   Console.WriteLine(min);
}
if(numberA< numberB)
{
   int max = numberB;
   int min = numberA;
   Console.Write("max= ");
   Console.WriteLine(max);
   Console.Write("min= ");
   Console.WriteLine(min);

}
if(numberA == numberB)
{
    Console.WriteLine("no maximum");
}