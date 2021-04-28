using System;

namespace Application
{
	
	

	public class Class1{

		public static void Main (string[] args)
		{
			DateTime date1 = new DateTime(1999, 4, 10);
			DateTime date2 = DateTime.Now;
			// getting the difference
			TimeSpan t = date2.Subtract(date1);

			Console.WriteLine ("AGE "+ Math.Ceiling((t.TotalDays)/365));
			Console.WriteLine ("Days "+ Math.Ceiling(t.TotalDays));
			Console.WriteLine ("Total hours "+ Math.Ceiling( t.TotalHours));
			Console.WriteLine ("Total Minutes "+Math.Ceiling( t.TotalMinutes));

		
	}
	}
}

