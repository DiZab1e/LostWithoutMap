using System.Linq;

public class Kata
{
    public static int[] Maps(int[] x)
    {
        return x.Select(e => e * 2).ToArray();
    }
}