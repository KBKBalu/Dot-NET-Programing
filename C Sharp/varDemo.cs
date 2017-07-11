
//Declaring Variable
using System;
namespace varDemoApplication
{
	class varDemo
  {
	static void Main()
	{
		int x=100;
		System.Console.WriteLine(x);
		System.Console.WriteLine(x.GetType());

		float f=3.14f;
		System.Console.WriteLine(f);
		System.Console.WriteLine(f.GetType());

		decimal de=113.1245m;
		System.Console.WriteLine(de);
		System.Console.WriteLine(de.GetType());
		Console.ReadKey();


	}
  }
}
