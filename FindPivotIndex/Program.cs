internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = new int[] { 1, 7, 3, 6, 5, 6 };
        SolutionOne solutionOne = new SolutionOne();
        var resultOne = solutionOne.PivotIndex(nums);
        Console.WriteLine("resultOne : " + resultOne);

        SolutionTwo solutionTwo = new SolutionTwo();
        var resultTwo = solutionTwo.PivotIndex(nums);
        Console.WriteLine("resultTwo : " + resultTwo);



    }

    public class SolutionOne
    {
        public int PivotIndex(int[] nums)
        {
            

            for (int i = 0; i < nums.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (j < i)
                        sumLeft += nums[j];
                    if (i < j)
                        sumRight += nums[j];
                }

                if (sumLeft == sumRight)
                    return i;
            }
            
            return -1;
        }
    }

    public class SolutionTwo
    {
        public int PivotIndex(int[] nums)
        {
            int sumRight = nums.Sum();
            int sumLeft = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sumRight -= nums[i];

                if (sumLeft == sumRight)
                {
                    return i;
                }

                sumLeft += nums[i];
            }

            return -1;
        }

    }
}