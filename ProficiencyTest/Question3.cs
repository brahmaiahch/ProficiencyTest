using System;
using System.Collections;
using System.Collections.Generic;


namespace ProficiencyTest
{
	public class Run
	{

		public static int IndexOfLongestRun(string str)
		{

			int indexOfLongest = 0,
			lengthOfLongest = 1,
			indexOfCurrent = 0,
			lengthOfCurrent = 1;
			char currentChar = str [0];
			for (int i = 1; i < str.Length; i++) {
				if (str [i] == currentChar) {
					lengthOfCurrent++;
				} else {
					if (lengthOfCurrent > lengthOfLongest) {
						lengthOfLongest	= lengthOfCurrent;
						indexOfLongest = indexOfCurrent;
					}
					lengthOfCurrent = 1;
					indexOfCurrent = i;
					currentChar = str [i];
				}
			}

			if (lengthOfCurrent > lengthOfLongest)
				indexOfLongest = indexOfCurrent;

			return indexOfLongest;
		}
	}}

