namespace BTechnicalQuestion.Core
{
    public class Solver
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr == null || arr.Length < 1)
            {
                Console.WriteLine($"Invalid input");
                return 0;
            }
            if (arr.All(x => x < 0))
            {
                Console.WriteLine($"All the inputs element are less than 0");
                return 0;
            }

            int max = arr[0];
            int maxOutput = max;
            for (int i = 1; i < arr.Length; i++)
            {
                // Compare accumulative sum and current element,
                // If the current element is greater than accumulated sum, set the maximum to current element
                max = (arr[i] < max + arr[i]) ? max + arr[i] : arr[i];

                //Historical maximum, override it when there is greater value
                if (max > maxOutput) { maxOutput = max; }
            }

            return maxOutput;
        }

        private enum numbers { one = 1, two, three, four, five, six, seven, eight, nine, }
        private static List<numbers> numList = Enum.GetValues(typeof(numbers)).Cast<numbers>().ToList();
        public static int SumOfWords(string filePath)
        {

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File path is not exist");
                return -1;
            }

            string[] words = File.ReadAllLines(filePath);
            if (words.Count() < 1)
            {
                Console.WriteLine($"Empty line");
                return -1;
            }

            int sum = 0; int firstNumber = 0; int lastNumber = 0;
            foreach (var word in words)
            {
                //Decode word into numbers
                string text = word.ToLower();
                foreach (var num in numList)
                {
                    text = text.Replace($"{num}", $"{(int)num}");
                }

                //Try to parse first index, if not number get 0
                Int32.TryParse($"{text.First()}", out firstNumber);
                Int32.TryParse($"{text.Last()}", out lastNumber);

                sum += firstNumber * 10 + lastNumber;
            }

            return sum;
        }

    }

}
