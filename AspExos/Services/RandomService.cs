namespace AspExos.Services;

public class RandomService : IRandomService
{
    public int GenerateRandomNumber(int min, int max)
    {
        return Random.Shared.Next(min, max);
    }
}