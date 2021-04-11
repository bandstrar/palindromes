using System;
using Xunit;

namespace Palindromes.Tests
{
    public class CheckIfInputIsPalindrome
    {
        [Theory]
        [InlineData("Stars", false)]
        [InlineData("O, a kak Uwakov lil vo kawu kakao!", true)]
        [InlineData("Some men interpret nine memos", true)]
        public void the_string_is_a_palindrome(string inputToValidate, bool expectedBool)
        {
            //Arrange
            var palindrome = new PalindromeChecker();

            //Act
            var actualBool = palindrome.CheckIfPalindrome(inputToValidate);

            //Assert
            Assert.Equal(expectedBool, actualBool);
        }
    }
}
