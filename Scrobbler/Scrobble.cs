using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Scrobbler
{
	public class Scrobble
	{
		//private static Dictionary<string, HashSet<char>> scrabbleDictionary = new Dictionary<string, HashSet<char>>();
		private static List<string> scrabbleDictionary = new List<string>();

		static Scrobble() {
			string blob = Dictionaries.ScrabbleDictionary;

			MatchCollection allMatches = (new Regex(@"([^\r\n]+)")).Matches(blob);

			foreach (Match match in allMatches)
			{
				scrabbleDictionary.Add(match.Value);//, new HashSet<char>(match.Value));
			}
		}

		public SortedDictionary<int, List<string>> GetWords(string rack)
		{
			//HashSet<char> letters = new HashSet<char>(rack);

			SortedDictionary<int, List<string>> result = new SortedDictionary<int, List<string>>();
			//List<string> result = new List<string>();

			foreach (var word in scrabbleDictionary)
			{
				int len = 100 - word.Length;

				if (/*word.Value.IsSubsetOf(letters) &&*/ IsSpellable(word/*.Key*/, rack))
				{
					if (!result.ContainsKey(len)) result.Add(len, new List<string>());

					result[len].Add(word);

					//result.Add(word/*.Key*/);
				}
			}

			return result;
		}

		private static Dictionary<char, int> LetterFrequencies(string word)
		{
			Dictionary<char, int> count = new Dictionary<char, int>();

			foreach (char letter in word)
			{
				if (!count.ContainsKey(letter)) count.Add(letter, 0);
				count[letter] += 1;
			}

			return count;
		}

		private static bool IsSpellable(string word, string rack)
		{
			var wordFreq = LetterFrequencies(word);
			var rackFreq = LetterFrequencies(rack);

			foreach (char letter in word)
			{
				if (!rackFreq.ContainsKey(letter)) return false;
				if (wordFreq[letter] > rackFreq[letter]) return false;
			}

			return true;
		}
	}
}
