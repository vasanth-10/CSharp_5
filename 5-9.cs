using System;

namespace Application
{
	//Write a program in C# Sharp to create a nested structure to store two data for an employee in an array

	public class Class1{
		
		struct employee{
			public FullName ename ;
			public int esalary ;
			public int ecode ;
		}  
          struct FullName {
			public string Fname ;
			public string Lname ;

		}

		public static void Main (string[] args)
		{
			int n = 2;
			employee []e = new employee[n];
			for (int i=0 ; i<n ; i++){
				Console.WriteLine("Enter the Fname");
				e [i].ename.Fname = Console.ReadLine ();
				Console.WriteLine("Enter the Lname");
				e[i].ename.Lname =Console.ReadLine();
				Console.WriteLine("Enter the salary");
				e[i].esalary = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter the Code(in number)");
				e[i].ecode = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine ("S.NO    Employee_Name   Employee_salary       Employee_code");

			for (int i=0 ; i<n ; i++){
				Console.Write (i + 1);
				Console.Write("  " + ( e[i].ename.Fname + e[i].ename.Lname) );
				Console.Write("         " +e[i].esalary);
				Console.Write("          "+e[i].ecode);
				Console.WriteLine (" ");


			}
		
	}
	}
}

