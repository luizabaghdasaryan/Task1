namespace UnitTestingTask
{
    public class UnitTestingTask
    {
        public static int CountMaxUnequalConsecutiveChars(string str)
        {
            if (str is null)
                throw new ArgumentNullException(nameof(str));

            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str))
                return 0;

            int currentCount = 1;
            int maxCount = 1;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    currentCount++;

                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }

            if (maxCount == 1)
                return 0;

            return maxCount;
        }

        public static int CountMaxConsecutiveIdentialLetters(string str)
        {
            if (str is null)
                throw new ArgumentNullException(nameof(str));

            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str))
                return 0;

            int currentCount = 1;
            int maxCount = 1;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((char.IsLetter(str[i]) && char.IsLetter(str[i + 1])) && str[i] == str[i + 1])
                {
                    currentCount++;

                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }

            if (maxCount == 1)
                return 0;

            return maxCount;
        }

        public static int CountMaxConsecutiveIdentialDigits(string str)
        {
            if (str is null)
                throw new ArgumentNullException(nameof(str));

            if (string.IsNullOrWhiteSpace(str) || string.IsNullOrEmpty(str))
                return 0;

            int currentCount = 1;
            int maxCount = 1;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((char.IsDigit(str[i]) && char.IsDigit(str[i + 1])) && str[i] == str[i + 1])
                {
                    currentCount++;

                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 1;
                }
            }

            if (maxCount == 1)
                return 0;

            return maxCount;
        }
    }
}