int Count = 0;
int Distanse = 10000;
int FFS = 1;
int SFS = 2;
int DS = 5;
int Friend = 2;
int Time = 0;
while (Distanse > 10)
{
    if (Friend == 1)
    {
        Time = Distanse / (FFS + DS);
        Friend = 2;
    }
    if (Friend == 2)
    {
        Time = Distanse / (SFS + DS);
        Friend = 1;
    }
    Distanse = Distanse - (FFS + SFS) * Time;
    Count ++;
}
Console.Write("Собака пробежала ");
Console.Write(Count);
Console.WriteLine(" раз");