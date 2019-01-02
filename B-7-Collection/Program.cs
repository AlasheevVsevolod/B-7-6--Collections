﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
	class Program
	{
		static void Main(string[] args)
		{
			//B7-P1/5. ArrayListPoemSort.
			B7_P1();


			Console.ReadLine();
		}


		//B7-P1/5. ArrayListPoemSort.
		public static void B7_P1()
		{
			ArrayList newArrList = new ArrayList();
			for (int i = 0; i < 3; i++)
			{
				newArrList.Add(Console.ReadLine());
			}
			Console.WriteLine();

			PrintArrList(newArrList);

			newArrList.Sort();
			PrintArrList(newArrList);

			newArrList.RemoveAt(newArrList.Count - 1);
			PrintArrList(newArrList);
		}

		public static void PrintArrList(ArrayList tmpArr)
		{
			foreach (string listString in tmpArr)
			{
				Console.WriteLine(listString);
			}
			Console.WriteLine();
		}



/*		public static void ArrayListExample()
		{
			var poem = new ArrayList();
			for (int i = 0; i < 5; i++)
			{
				var song = new Song();
				song.Lyrics = Console.ReadLine();
				poem.Add(song);
			}

			//poem.Sort();
			poem.RemoveAt(poem.Count - 1);

			object[] myArray = poem.ToArray();

			foreach (var item in myArray)
			{
				Console.WriteLine(item);
			}

		}

		public class Song : IComparable
		{
			public string Lyrics { get; set; }

			public int CompareTo(object obj)
			{
				throw new NotImplementedException();
			}
		}
		*/
	}
}
