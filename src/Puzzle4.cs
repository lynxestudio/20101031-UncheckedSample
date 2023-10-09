using System;
namespace Samples
{
public class Puzzle4
{
public static int Main(string[] args)
{
    long resp = 0;
    try
    {
	    unchecked{
 const long MICROS_PER_DAY = 24L * 60 * 60 * 1000 * 1000;
 const long MILIS_PER_DAY = 24L * 60 * 60 * 1000;   
 resp = (MICROS_PER_DAY / MILIS_PER_DAY);   
	    }
    }
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("{0}", resp);
return 0;
}
}
}
