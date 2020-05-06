using NUnit.Framework;

namespace Text.Tests
{
    public class UniqueCharTests
    {
        [Test]
        public void NonDuplicatedCharacter()
        {
            string s = "session";

            int result = Text.Str.UniqueChar(s);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllDuplicateChar()
        {
            string s = "mama";

            int result = Text.Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void OnlyOneLetter()
        {
            string s = "s";

            int result = Text.Str.UniqueChar(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void AtTheBeginning()
        {
            string s = "palindrome";

            int result = Text.Str.UniqueChar(s);
            Assert.AreEqual(0, result);
        }

         [Test]
        public void AtTheEnd()
        {
            string s = "hghghghghj";

            int result = Text.Str.UniqueChar(s);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void IfEmptyString()
        {
            string s = string.Empty;

            int result = Text.Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
    }
}
