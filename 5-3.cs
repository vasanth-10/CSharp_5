using System;

namespace Application
{
	public abstract class Animal{
		private string Name;
		public void SetName(string name){
			Name = name;
		}
		public string GetName(){
			return Name;
		}

		public abstract void Eat();
	}
	public class Dog : Animal
	{
		public override void Eat(){
			Console.WriteLine("Dog is Eating");
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter the dog name");
			Dog d = new Dog ();
			d.SetName(Console.ReadLine());
			Console.WriteLine("The dog name is"+d.GetName());
			d.Eat ();
			Console.ReadLine ();
		}
	}
}

