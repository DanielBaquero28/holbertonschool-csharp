using NUnit.Framework;

namespace Str.Tests
{
    public class UniqueCharacterTests
    {
        [Test]
        public void NonDuplicatedCharacter()
        {
            string s = "session";

            int result = Text.Str.UniqueCharacter(s);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllDuplicateCharacters()
        {
            string s = "mama";

            int result = Text.Str.UniqueCharacter(s);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void OnlyOneLetter()
        {
            string s = "s";

            int result = Text.Str.UniqueCharacter(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void AtTheBeginning()
        {
            string s = "level";

            int result = Text.Str.UniqueCharacter(s);
            Assert.AreEqual(2, result);
        }

         [Test]
        public void AtTheEnd()
        {
            string s = "css";

            int result = Text.Str.UniqueCharacter(s);
            Assert.AreEqual(0, result);
        }
    }
}