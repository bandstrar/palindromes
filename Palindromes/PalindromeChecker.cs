using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Palindromes
{
    public class PalindromeChecker
    {
        public bool CheckIfPalindrome(string inputToValidate)
        {
            var splitPalindrome = inputToValidate.Split( ',', ' ', '.', '!', '?', '\'');

            var joinedPalindrome = string.Join("", splitPalindrome).ToLower();

            var palindromeCharacters = joinedPalindrome.ToCharArray();

            Array.Reverse(palindromeCharacters);

            var reversedPalindrome = string.Join("", palindromeCharacters);

            if (joinedPalindrome != reversedPalindrome)
            {
                return false;
            }
            else return true;
        }
    }
}
