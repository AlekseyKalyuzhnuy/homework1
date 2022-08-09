int numberA =22;
int numberB =3;
int numberC =9;
int min =0;
int max =0;

if (numberA > numberB)
{
   max= numberA; 
   min= numberB;
}
else
{
    max=numberB;
    min=numberA;
}

if (max < numberC)
{
    max=numberC;
}
else
{ 
  if (numberC< min)
  {
    min=numberC;
  }
}
  Console.Write("min= ");
  Console.WriteLine(min);
  Console.Write("max= ");
  Console.WriteLine(max);
