using System;

namespace StringExtensions
{
	public static class StringUtils
	{
		public static string ReverseString(this string plainIn)
		{
			char[] charArray = plainIn.ToCharArray();
			Array.Reverse(charArray);

			return new string(charArray);
		}	

		public static string RemoveSpaces(this string plainIn)
		{
			plainIn = plainIn.Replace(" ", string.Empty);
			return plainIn;
		}
	}
}