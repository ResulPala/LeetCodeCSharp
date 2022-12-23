public class Program
{
    private static void Main(string[] args)
    {
        SolutionOne solutionOne = new SolutionOne();
        Console.WriteLine(solutionOne.IsIsomorphic("paper", "title")); //true
        Console.WriteLine(solutionOne.IsIsomorphic("foo", "bar")); //false

    }
}

public class SolutionOne
{
    public bool IsIsomorphic(string s, string t)
    {
        var map = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (map.ContainsKey(c1))
            {
                if (map[c1] != c2)
                {
                    return false;
                }
            }
            else
            {
                if (map.ContainsValue(c2))
                {
                    return false;
                }

                map.Add(c1, c2);
            }
        }

        return true;
    }
}

public class SolutionTwo
{
    public bool IsIsomorphic(string s, string t)
    {
        var sMap = new Dictionary<char, char>();
        var tMap = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            // Build the map
            if (!sMap.ContainsKey(s[i]))
            {
                sMap.Add(s[i], t[i]);
            }
            if (!tMap.ContainsKey(t[i]))
            {
                tMap.Add(t[i], s[i]);
            }

            // Compare
            if (sMap[s[i]] != t[i] || tMap[t[i]] != s[i])
            {
                return false;
            }
        }

        return true;
    }
}