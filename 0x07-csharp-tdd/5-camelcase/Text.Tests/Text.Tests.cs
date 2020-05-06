using NUnit.Framework;

namespace Text.Tests
{
    public class CamelCaseTests
    {
        [Test]
        public void IfEmptyString()
        {
            string s = string.Empty;

            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void OneWord()
        {
            string s = "hello";

            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void OneWordLowerCase()
        {
            string s = "hello world";

            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TwoWordsUpperCase()
        {
            string s = "hello World";

            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TenWordsUpperCase()
        {
            string s = "hello World Hello World Hello World Hello World Hello World";

            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(10, result);
        }

         [Test]
        public void TenWordsLowerCase()
        {
            string s = "hello world hello world hello world hello world hello world";

            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(1, result);
        }

         [Test]
        public void TwoWordsJoined()
        {
            string s = "helloWorld";

            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(2, result);
        }

         [Test]
        public void TwoWordsCombinedUpperAndLowerCase()
        {
            string s = "helloWorld hello";

            int result = Text.Str.CamelCase(s);
            Assert.AreEqual(2, result);
        }
    }
}