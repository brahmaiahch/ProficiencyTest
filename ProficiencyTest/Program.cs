using System;

namespace ProficiencyTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Question1
			Console.WriteLine("Average is "+MathUtils.Average (2, 3));


			//Question2
			Path path = new Path("/a/b/c/d");
			//test1

			//Console.WriteLine(path.Cd("../x").CurrentPath);

			//test2

			//Console.WriteLine(path.Cd("././x").CurrentPath);


			//test3

			//Console.WriteLine("Changed directiorary is "+path.Cd("../../../x").CurrentPath);
			//Console.WriteLine("Changed directiorary is "+path.Cd("../../../../x").CurrentPath);
//
			//Console.WriteLine("Changed directiorary is "+path.Cd("..").CurrentPath);
		//Console.WriteLine("Changed directiorary is "+path.Cd("/x").CurrentPath);
		Console.WriteLine("Changed directiorary is "+path.Cd(" x").CurrentPath);


			//Question3
			//test1

			int index= Run.IndexOfLongestRun ("abbcccddddcccbba");

			//test2
//			int index= Run.IndexOfLongestRun ("abbcccddddccccccbba");

			//test3
			//int index= Run.IndexOfLongestRun ("aaaaaabbcccddddccccbba");
			Console.WriteLine ("IndexOfLongestRun is "+ index);

			//Question4
			//test1

			Node n1 = new Node(1, null, null);
			Node n3 = new Node(3, null, null);
			Node n2 = new Node(2, n1, n3);

			//test2

//			Node n1 = new Node (1, null, null);
//			Node n3 = new Node(3, null, null);
//			Node n2 = new Node(3, n1, n3);
//			Node n5 = new Node (3, null, null);
//			Node n4 = new Node(2,n2,n5);

			//test3

//			Node n1 = new Node (1, null, null);
//			Node n3 = new Node(5, null, null);
//			Node n2 = new Node(3, n1, n3);
//			Node n7 = new Node (5, null, null);
//			Node n9 = new Node (9, null, null);
//			Node n8 = new Node (7, n9, null);
//			Node n5 = new Node (6, n7, n8);
//			Node n4 = new Node(5,n2,n5);

			Console.WriteLine("IsValidBST?  "+BinarySearchTree.IsValidBST(n2));

			Console.ReadLine ();
		}
	}
}
