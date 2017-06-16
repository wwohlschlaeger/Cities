﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
	public class AreaComparer : IComparer<City>
	{
		public int Compare(City x, City y)
		{
			// Since we want to sort strings, we can use the
			// comparer for the built-in string class
			
			return (y.Area.CompareTo(x.Area));
		}
	}
}