using System;

namespace Application
{
	
	

	public class Class1{

		public static void Main (string[] args)
		{
			Console.WriteLine ("Year "+ DateTime.Now.ToString ("yyyy"));
			Console.WriteLine ("Month "+ DateTime.Now.ToString ("MM"));
			Console.WriteLine ("Day "+ DateTime.Now.ToString ("dd ':'dddd"));
			Console.WriteLine ("Hour "+ DateTime.Now.ToString ("HH"));
			Console.WriteLine ("Minute "+ DateTime.Now.ToString ("mm"));
			Console.WriteLine ("Second "+ DateTime.Now.ToString ("ss"));
			Console.WriteLine ("Millisecond "+ DateTime.Now.ToString ("ms"));
		
	}
	}
}

