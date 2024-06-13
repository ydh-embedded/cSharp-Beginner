using System;
using Nunit.Framework;
using Xunit.Framework;

namespace Checker
{
    public class Prg
    {
        static void Main(string[] args)
        {
            TestPalindrome();  // Add your code here
        }
    }

    public class MyUnitTests
    {
        public bool IsPalindrome(string text)
        {
            return text == ReverseString(text);
        }

        private string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        [Fact]
        public void TestPalindrome()
        {
            Assert.True(IsPalindrome("regallager"));
        }

        [Fact]
        public void TestNoPalindrome()
        {
            Assert.False(IsPalindrome("kevion"));
        }
    }
}