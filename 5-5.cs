using System;

namespace Application
{
	public class PhotoBook{
		public int numPages ;
		public int GetNumberPages(){
			return numPages;
		}
		public PhotoBook(){
			numPages = 16;
		}
		public  PhotoBook(int n){
			Console.WriteLine ("The number of pages in album is " + n);
		}

	}
	public class BigPhotoBook :PhotoBook
	{

		public BigPhotoBook(){
			numPages = 64;
		}
		
	}

	public class PhotoBookTest{

		public static void Main (string[] args)
		{
			PhotoBook PB = new PhotoBook ();
			Console.WriteLine ("The number of pages in PhotoBook is "+PB.GetNumberPages ());
			PhotoBook PB1 = new PhotoBook (24);
     		BigPhotoBook BPB = new BigPhotoBook ();
			Console.WriteLine ("The number of pages in BigPhotoBook is "+BPB.GetNumberPages ());
			Console.ReadLine ();
		}
		
	}
}

