internal class Program
{
    private static void Main(string[] args)
    {
        SolutionOne solutionOne = new SolutionOne();
        var resultOne = solutionOne.Translator("MMMDCCXXIV");
        Console.WriteLine(resultOne);

        SolutionTwo solutionTwo = new SolutionTwo();
        var resultTwo = solutionTwo.RomanToInt("MMMDCCXXIV");
        Console.WriteLine(resultTwo);

        SolutionThree solutionThree = new SolutionThree();
        var resultThree= solutionThree.RomanToInt("MMMDCCXXIV");
        Console.WriteLine(resultThree);
    }


}

public class SolutionOne
{
    public int Translator(string s)
    {
        Dictionary<char, int> RomanValue = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        char[] romanCharArray = s.ToCharArray();


        int result = 0;
        int substraction = 0;

        for (int i = 0; i < romanCharArray.Length - 1; i++)
        {

            if (RomanValue[romanCharArray[i]] >= RomanValue[romanCharArray[i + 1]])
                result += RomanValue[romanCharArray[i]];
            else
            {
                result += RomanValue[romanCharArray[i]];
                substraction += 2 * RomanValue[romanCharArray[i]];
            }

        }

        return result + RomanValue[romanCharArray[romanCharArray.Length - 1]] - substraction;
    }


}

public class SolutionTwo
{
    public int RomanToInt(string s)
    {
        var dictionary = new Dictionary<char, int>();
        dictionary.Add('I', 1);
        dictionary.Add('V', 5);
        dictionary.Add('X', 10);
        dictionary.Add('L', 50);
        dictionary.Add('C', 100);
        dictionary.Add('D', 500);
        dictionary.Add('M', 1000);

        int solution = 0;

        /*
            They practically solved it, all we had to do was to read the question:
                I can be placed before V (5) and X (10) to make 4 and 9. 
                X can be placed before L (50) and C (100) to make 40 and 90. 
                C can be placed before D (500) and M (1000) to make 400 and 900.
        */
        s = s.Replace("IV", "IIII")
            .Replace("IX", "VIIII")
            .Replace("XL", "XXXX")
            .Replace("XC", "LXXXX")
            .Replace("CD", "CCCC")
            .Replace("CM", "DCCCC");

        foreach (char c in s)
        {
            solution += dictionary[c];
        }

        return solution;
    }
}

public class SolutionThree
{
    public int RomanToInt(string s)
    {
        var chars = s.ToCharArray();
        var result = 0;
        var currentValue = 0;

        for (var i = 0; i < chars.Length - 1; i++)
        {
            currentValue = RomanNumerals(chars[i]);
            result += (RomanNumerals(chars[i + 1]) > currentValue ? -1 : 1) * currentValue;
        }

        return result + RomanNumerals(chars[chars.Length - 1]);

    }

    public int RomanNumerals(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
        }
        return 0;
    }
}