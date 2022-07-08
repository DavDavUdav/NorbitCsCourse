using System;
using System.Collections.Generic;

namespace ClassLibraryFrequencyOfWords
{
    public class Class1
    {
		public static Dictionary<string,int> CountingFrequencyWords(string str)
		{
			str = str.ToLower();  // Переводим в нижн регистр.
			var strList = new List<string>();
			
			// Заносим в лист разделяя строку.
			foreach (string word in str.Split(' ', '.', StringSplitOptions.RemoveEmptyEntries))
            {
				strList.Add(word);
            }

			var dict = new Dictionary<string, int>();

            foreach (string s in strList)
            {
				if (!dict.ContainsKey(s))
				{
					dict.Add(s, 1);
				}
				else dict[s] += 1;
            }
			
			return dict;
		}
	}
}
