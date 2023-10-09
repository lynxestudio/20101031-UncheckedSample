using System;

namespace Samples{
public class Puzzle6{
public static int Main(string[] args){
    try
    {
        unchecked
        {
Console.WriteLine((int)(char)(byte)-1);
    }
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}
	return 0;
}
}
}
