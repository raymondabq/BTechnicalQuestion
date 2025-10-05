using BTechnicalQuestion.Core;

namespace BTechnicalQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] _sequence1 = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Question 1
            int MaximumSum = Solver.MaxSequence(_sequence1);
            Console.WriteLine($"The result of question 1 is {MaximumSum}");

            //Question 2
            string filePath = "input.txt";
            int sum = Solver.SumOfWords(filePath);
            Console.WriteLine($"The result of question 2 is {sum}");
        }
    }
}
