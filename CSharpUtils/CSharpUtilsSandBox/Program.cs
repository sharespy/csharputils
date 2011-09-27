﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpUtils.Containers.RedBlackTree;

namespace CSharpUtilsSandBox
{
	class Program
	{
		static void Test1()
		{
			Console.WriteLine("-----------------------------------------");
			var Stats = (new RedBlackTreeWithStats<int>()).Clone();
			{
				var Start = DateTime.Now;
				for (int n = 0; n < 500000; n++)
				{
					Stats.insert(n); // 1
				}
				Console.WriteLine(DateTime.Now - Start);
			}
			//Stats.PrintTree();
			{
				var Start = DateTime.Now;
				int Value = 0;
				for (int n = 0; n < 100; n++)
				{
					Value = Stats.All.Length;
					Value = Stats.All.Skip(250000).Take(240000).Count();
				}
				Console.WriteLine(Value);
				Console.WriteLine(DateTime.Now - Start);
			}
			{
				var Start = DateTime.Now;
				int Value = 0;
				for (int n = 0; n < 1000; n++)
				{
					Value = Stats.All.GetOffsetPosition(250000);
				}
				Console.WriteLine(Value);
				Console.WriteLine(DateTime.Now - Start);
			}
			/*
			{
				var Start = DateTime.Now;
				int Value = 0;
				for (int n = 0; n < 100; n++)
				{
					//int Value = Stats.All.Count();
					Value = Stats.Count();
					Value = Stats.Skip(50000).Count();
				}
				Console.WriteLine(Value);
				Console.WriteLine(DateTime.Now - Start);
			}
			 * */
			/*
			foreach (var Item in Stats.All.Where(Item => Item > 3).Count())
			{
				Console.WriteLine(Item);
			}
			*/
			//Stats.DebugValidateTree();
		}

		static void Test2()
		{
			Console.WriteLine("-----------------------------------------");
			//var Stats = new Dictionary<int, int>();
			var Stats = new SortedList<int, int>();
			{
				var Start = DateTime.Now;
				for (int n = 0; n < 500000; n++)
				{
					Stats.Add(n, n); // 1
				}
				Console.WriteLine(DateTime.Now - Start);
			}
			//Stats.PrintTree();
			{
				var Start = DateTime.Now;
				int Value = 0;
				for (int n = 0; n < 100; n++)
				{
					Value = Stats.Count;
					Value = Stats.Skip(250000).Take(240000).Count();
				}
				Console.WriteLine(Value);
				Console.WriteLine(DateTime.Now - Start);
			}
			{
				var Start = DateTime.Now;
				int Value = 0;
				for (int n = 0; n < 1000; n++)
				{
					Value = Stats.IndexOfValue(250000);
				}
				Console.WriteLine(Value);
				Console.WriteLine(DateTime.Now - Start);
			}
			/*
			foreach (var Item in Stats.All.Where(Item => Item > 3).Count())
			{
				Console.WriteLine(Item);
			}
			*/
			//Stats.DebugValidateTree();
		}

		static void Main(string[] args)
		{
			Test1();
			Test2();
			Console.ReadKey();
		}
	}
}
