using System;
namespace AddNumApp
{
	class AddNum
 {
	static void Main(string[] args)
	{
		int x,y,z;
		Console.Write("Enter values for x:");
		string s1=Console.ReadLine();
		x=int.Parse(s1);

		Console.Write("Enter values for y:");
		string s2=Console.ReadLine();
		y=int.Parse(s2);

		z=x+y;
		Console.WriteLine("Sum of {0} & {1} is {2}",x,y,z);
		Console.ReadKey();
	}
 }
}
