using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class StringExtensions
{
	public static bool IsStringInArray(this IEnumerable<string> source, string stringToFind)
	{
		return source.Any(s => s.Contains(stringToFind));
	}

	public static long SumNumsInStrings(this IEnumerable<string> source)
	{
		Regex regex = new Regex(@"-?[0-9]+");
		long total = 0;
		foreach(string part in source)
		{
			foreach(Match match in regex.Matches(part))
			{
				if(match.Success && long.TryParse(match.Value,out long result))
				{
					total += result;
				}
			}
		}
		return total;
	}
}
