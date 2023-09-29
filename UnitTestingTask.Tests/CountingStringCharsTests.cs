using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace UnitTestingTask.Tests
{
    public class UnitTestingTaskTests
    {
        [Test]
        public void CountMaxUnequalConsecutiveChars_NullString_ThrowsException()
        {
            string input = null;

            Assert.Throws<ArgumentNullException>(() => UnitTestingTask.CountMaxUnequalConsecutiveChars(input));
        }

        [Test]
        public void CountMaxUnequalConsecutiveChars_EmptyString_ReturnsZero()
        {
            string input = "";

            int result = UnitTestingTask.CountMaxUnequalConsecutiveChars(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountMaxUnequalConsecutiveChars_NoConsecutiveChars_ReturnsZero()
        {
            string input = "aaaa";

            int result = UnitTestingTask.CountMaxUnequalConsecutiveChars(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountMaxUnequalConsecutiveChars_ConsecutiveUnequalCharsAtStart_ReturnsCorrectCount()
        {
            string input = "abC12#dd";

            int result = UnitTestingTask.CountMaxUnequalConsecutiveChars(input);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void CountMaxUnequalConsecutiveChars_ConsecutiveUnequalCharsAtStartInMiddle_ReturnsCorrectCount()
        {
            string input = "aaabC12#dd";

            int result = UnitTestingTask.CountMaxUnequalConsecutiveChars(input);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void CountMaxUnequalConsecutiveChars_ConsecutiveUnequalCharsAtStartAtEnd_ReturnsCorrectCount()
        {
            string input = "aaabC12#";

            int result = UnitTestingTask.CountMaxUnequalConsecutiveChars(input);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void CountMaxUnequalConsecutiveChars_MultipleConsecutiveUnequalSequences_ReturnsCorrectCount()
        {
            string input = "abbbcddefg1hhij";

            int result = UnitTestingTask.CountMaxUnequalConsecutiveChars(input);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialLetters_NullString_ThrowsException()
        {
            string input = null;

            Assert.Throws<ArgumentNullException>(() => UnitTestingTask.CountMaxConsecutiveIdentialLetters(input));
        }

        [Test]
        public void CountMaxConsecutiveIdentialLetters_EmptyString_ReturnsZero()
        {
            string input = "";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialLetters(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialLetters_NoConsecutiveChars_ReturnsZero()
        {
            string input = "abcdED#";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialLetters(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialLetters_ConsecutiveIdentialLettersAtStart_ReturnsCorrectCount()
        {
            string input = "aaabC12222####";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialLetters(input);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialLetters_ConsecutiveIdentialLettersInMiddle_ReturnsCorrectCount()
        {
            string input = "abCCCC122#";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialLetters(input);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialLetters_ConsecutiveIdentialLettersStartAtEnd_ReturnsCorrectCount()
        {
            string input = "abc12###DD";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialLetters(input);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialLetters_MultipleConsecutiveIdentialLettersSequences_ReturnsCorrectCount()
        {
            string input = "abbbcddddefghhij";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialLetters(input);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialDigits_NullString_ThrowsException()
        {
            string input = null;

            Assert.Throws<ArgumentNullException>(() => UnitTestingTask.CountMaxConsecutiveIdentialDigits(input));
        }

        [Test]
        public void CountMaxConsecutiveIdentialDigits_EmptyString_ReturnsZero()
        {
            string input = "";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialDigits(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialDigits_NoConsecutiveChars_ReturnsZero()
        {
            string input = "1234aaBB###";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialDigits(input);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialDigits_ConsecutiveIdentialDigitsAtStart_ReturnsCorrectCount()
        {
            string input = "111aaabC12#";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialDigits(input);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialDigits_ConsecutiveIdentialDigitsInMiddle_ReturnsCorrectCount()
        {
            string input = "ab111112#";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialDigits(input);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialDigits_ConsecutiveIdentialDigitsAtEnd_ReturnsCorrectCount()
        {
            string input = "aaabc12##333";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialDigits(input);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void CountMaxConsecutiveIdentialDigits_MultipleConsecutiveIdentialDigitsSequences_ReturnsCorrectCount()
        {
            string input = "abbbbbc1111Efg22ij3#####444";

            int result = UnitTestingTask.CountMaxConsecutiveIdentialDigits(input);

            Assert.AreEqual(4, result);
        }
    }
}