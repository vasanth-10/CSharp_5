using System;

namespace Application
{
	public class Person {
		public string Name{ get; set;}

		public Person(string name){
			Name = name;
		
		}
		public override string ToString(){
			return Name;
		}

		~Person(){
			Name = String.Empty;

		}

	}
	
	

	public class Class1{

		public static void Main (string[] args)
		{
			int n=3;
			Person[] Psn = new Person [n];
			Console.WriteLine ("Enter the 3 names");



		for (int i = 0; i < n; i++) {
				Psn [i] = new Person( Console.ReadLine ());
		}
			for (int i = 0; i < n; i++) {
				Console.WriteLine(	Psn[i].ToString());
			}

				
			Console.ReadLine ();
		}
		
	}
}

