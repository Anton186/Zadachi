int Count = 0
int Distanse = 10000
int FFS = 1
int SFS = 2
int DS = 5
int Friend = 2
While (Distanse < 10)
{
    if (Friend == 1)
    {
        Time = distanse / (FFS + DS)
        Friend = 2
    }
    if (Friend == 2)
    {
        Time = distanse / (SFS + DS)
        Friend = 1
    }
    distanse = distanse - (FFS + SFS) * Time
}
Console.Write("Собака пробежала ");
Console.Write(max);
Console.WriteLine(" раз");