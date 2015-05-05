using System;
using System.Collections.Generic;

namespace ProficiencyTest
{
	public class Node
	{
		public int Value { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }
		public Node(int value, Node left, Node right)
		{
			Value = value;
			Left = left;
			Right = right;
		}
	}
	public class BinarySearchTree
	{
		private static int previous= 1;
		private static bool istrue= false;
		public static bool IsValidBST(Node root)
		{

			return validate (root, int.MinValue, int.MaxValue);
		}
		public static bool validate(Node root, int min, int max) {
			if (root == null) {
				return true;
			}

			// not in range
			if (root.Value < min || root.Value > max) {
				return false;
			} 

			// left subtree must be < root.val && right subtree must be > root.val
			return validate(root.Left, min, root.Value) && validate(root.Right, root.Value, max);
		}


	
	}

}

