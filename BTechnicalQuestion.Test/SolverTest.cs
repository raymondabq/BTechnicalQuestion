using BTechnicalQuestion.Core;

namespace BTechnicalQuestion.Test
{
    [TestClass]
    public class SolverTest
    {

        [TestInitialize]

        public void Setup() { }

        [TestMethod]

        [DataRow(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [DataRow(new int[] { 2, -2, -3, 1, -1, 2, -1, 3, -1 }, 4)]
        public void FindSequenceMax_RandomPositiveNegativeInputs_ReturnsCorrectSum(int[] _sequence, int expectedSum)
        {
            // Act
            int result = Solver.MaxSequence(_sequence);

            // Assert
            Assert.AreEqual(expectedSum, result);
        }


        [TestMethod]
        public void FindSequenceMax_NullInput_ReturnZero()
        {
            // Arrange
            int[] _sequence = null;

            // Act
            int result = Solver.MaxSequence(_sequence);

            // Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void FindSequenceMax_AllNegativeInputs_ReturnZero()
        {
            // Arrange
            int[] _sequence = new int[] { -2, -2, -3, -4, -1, -2, -1, -5, -4 };

            // Act
            int result = Solver.MaxSequence(_sequence);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FindSequenceMax_RandomPositiveNegative_ReturnsCorrectSum()
        {
            // Arrange

            int[] _sequence = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            // Act
            int result = Solver.MaxSequence(_sequence);

            // Assert
            Assert.AreEqual(6, result);
        }



        [TestMethod]
        [DataRow("input.txt", 183)]
        [DataRow("input2.txt", 80)]
        public void SumOfWords_ValidFilePath_ReturnsCorrectSum(string filePath, int expectedSum)
        {
            // Act
            int result = Solver.SumOfWords(filePath);

            // Assert
            Assert.AreEqual(expectedSum, result);
        }

        public void sumofWords_InvalidFilePath_ReturnsMinusOne()
        {
            // Arrange
            string filePath = "InvalidInput.txt";

            // Act
            int result = Solver.SumOfWords(filePath);

            // Assert
            Assert.AreEqual(-1, result);
        }
        public void sumofWords_EmptyLines_ReturnsMinusOne()
        {
            // Arrange
            string filePath = "empty.txt";

            // Act
            int result = Solver.SumOfWords(filePath);

            // Assert
            Assert.AreEqual(-1, result);
        }

    }
}