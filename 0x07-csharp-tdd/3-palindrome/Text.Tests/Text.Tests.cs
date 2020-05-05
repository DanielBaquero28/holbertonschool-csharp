using NUnit.Framework;
using System.Collections.Generic;


namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void IsPalindromeLower()
        {
            string s = "racecar";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindromeUpper()
        {
            string s = "RACECAR";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindromeCapital()
        {
            string s = "Racecar";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NotPalindrome()
        {
            string s = "hello";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = false;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IfStringEmpty()
        {
            string s = string.Empty;

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindromePunctuation()
        {
            string s = "Aman,aplan,acanal:Panama.";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NotPalindromePunctuation()
        {
            string s = "Ama,aplan,acanal:Panama.";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = false;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindromeSpaces()
        {
            string s = " Aman aplan acanal Panama ";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NotPalindromeSpaces()
        {
            string s = " Ama aplan acanal Panama ";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = false;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ComnbinedPuncAndSpaces()
        {
            string s = "A man, a plan, a canal: Panama.";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void OneLetter()
        {
            string s = "n";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindromePuncAndSpaces()
        {
            string s = ",,:.        ";

            bool result = Text.Str.IsPalindrome(s);
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }
    }
}