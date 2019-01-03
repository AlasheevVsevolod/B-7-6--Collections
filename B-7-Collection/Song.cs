using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_7
{
	public class Song
	{
		public string Lyrics { get; set; }

		public override string ToString()
		{
			return Lyrics;
		}
	}
}
