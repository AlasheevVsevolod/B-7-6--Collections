using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_7
{
	class Program
	{
		static void Main(string[] args)
		{
			//B7-P1/5. ArrayListPoemSort.
			//B7_P1();

			//B7-P2/5. ArrayListOfSongsSort.
			//B7_P2();

			//B7-P3/5. GenericListOfSongsSort:
			//B7_P3();

			//B7-P4/5. GenericListOfNeighborSearch:
			//B7_P4();

			//B7-P5/5. DictionaryOfNeighborSearch:
			B7_P5();


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

			object[] newArr = newArrList.ToArray();
			foreach (object item in newArr)
			{
				Console.WriteLine(item);
			}
		}

		public static void PrintArrList(ArrayList tmpArr)
		{
			foreach (string listString in tmpArr)
			{
				Console.WriteLine(listString);
			}
			Console.WriteLine();
		}

		//B7-P2/5. ArrayListOfSongsSort.
		public static void B7_P2()
		{
			ArrayList newArrList = new ArrayList();
			for (int i = 0; i < 3; i++)
			{
				Song song = new Song()
				{
					Lyrics = Console.ReadLine()
				};
				newArrList.Add(song);
			}
			Console.WriteLine();

			PrintLyrics(newArrList);

			//newArrList.Sort();
			//PrintLyrics(newArrList);

			newArrList.RemoveAt(newArrList.Count - 1);
			PrintLyrics(newArrList);

			object[] newArr = newArrList.ToArray();
			foreach (var item in newArr)
			{
				Console.WriteLine(item);
			}
		}

		public static void PrintLyrics(ArrayList tmpArr)
		{
			foreach (Song tmpSong in tmpArr)
			{
				Console.WriteLine(tmpSong.Lyrics);
			}
			Console.WriteLine();
		}


		//B7-P3/5. GenericListOfSongsSort:
		public static void B7_P3()
		{
			List<Song> newList = new List<Song>();
			for (int i = 0; i < 3; i++)
			{
				Song tmpSong = new Song()
				{
					Lyrics = Console.ReadLine()
				};
				newList.Add(tmpSong);
			}
			Console.WriteLine();

			PrintGenericList(newList);

//		А как тут сравнить списки-дженерики? Это нужно класс Song как-то изменять?
//			newList.Sort();
//			PrintGenericList(newList);

			newList.RemoveAt(newList.Count - 1);
			PrintGenericList(newList);

			object[] newArr = newList.ToArray();
			foreach (object item in newArr)
			{
				Console.WriteLine(item);
			}
		}

		public static void PrintGenericList(List<Song> tmpList)
		{
			foreach (Song listSong in tmpList)
			{
				Console.WriteLine(listSong.Lyrics);
			}
			Console.WriteLine();
		}


		//B7-P4/5. GenericListOfNeighborSearch:
		public static void B7_P4()
		{
			string consoleFlat;
			List<Neighbour> floorNeighbours = new List<Neighbour>() {};

			Neighbour n1 = new Neighbour("Тони Ким","31","147258");
			floorNeighbours.Add(n1);
			Neighbour n2 = new Neighbour("Джастин Поинтер", "32", "258369");
			floorNeighbours.Add(n2);

			Console.Write("Номер квартиры, на которую жалуетесь: ");
			consoleFlat = Console.ReadLine();

// Здесь .Contains не получится использовать, т.к. ему нужно передавать объект типа Neighbour
//а мы знаем только .FlatNumber
//			if(floorNeighbours.Contains(consoleFlat))

			foreach (Neighbour tmpNeighbour in floorNeighbours)
			{
				if(tmpNeighbour.FlatNumber == consoleFlat)
				{
					Console.WriteLine($"Зовут {tmpNeighbour.FullName}, телефон {tmpNeighbour.PhoneNumber}. Звоните сами");
					return;
				}
			}
			Console.WriteLine($"Такой квартиры не нашли. Проверьте ещё раз");
		}


		//B7-P5/5. DictionaryOfNeighborSearch:
		public static void B7_P5()
		{
			int consoleFlatkey;
			//List<Neighbour> floorNeighbours = new List<Neighbour>() { };

			Dictionary<int, Neighbour> floorNeighboursDict = new Dictionary<int, Neighbour>() {};

			Neighbour n1 = new Neighbour("Tony Kim", "31", "147258");
			floorNeighboursDict.Add(Convert.ToInt32(n1.FlatNumber), n1);
			Neighbour n2 = new Neighbour("Justin Pointer", "32", "258369");
			floorNeighboursDict.Add(Convert.ToInt32(n2.FlatNumber), n2);

			Console.Write("Номер квартиры, на которую жалуетесь: ");
			consoleFlatkey = Convert.ToInt32(Console.ReadLine());

			if(floorNeighboursDict.ContainsKey(consoleFlatkey))
			{
				Console.WriteLine($"Зовут {floorNeighboursDict[consoleFlatkey].FullName}, телефон {floorNeighboursDict[consoleFlatkey].PhoneNumber}. Звоните сами");
			}
			else
			{
				Console.WriteLine($"Такой квартиры не нашли. Проверьте ещё раз");
			}
		}
	}
}
