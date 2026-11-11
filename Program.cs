int[] n = { 4, 7, 2, 9 };
int sum = 0;

for (int i = 0;i < n.Length;i++)
{
   Console.WriteLine(n[i]);
   sum = sum + n[i];
}
Console.WriteLine(sum);

n[1] = 10;
sum = 0;

for (int i = 0;i < n.Length;i++)
{
   Console.WriteLine(n[i]);
   sum = sum + n[i];
}
Console.WriteLine(sum);
