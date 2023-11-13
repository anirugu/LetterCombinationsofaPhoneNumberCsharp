public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        var phoneScreen = GetPhoneScreenNumbers();
        int total = 1;
        foreach (var c in digits)
        {
            int number = Convert.ToInt32(c.ToString());
            total *= phoneScreen[number].Count;
        }

        return new List<string>();
    }

    Dictionary<int, IList<char>> GetPhoneScreenNumbers()
    {
        Dictionary<int, IList<char>> nums = new Dictionary<int, IList<char>>();

        int start = 'a';
        int index = 2;

        while (index <= 9)
        {
            int plus = (index == 7 || index == 9) ? 4 : 3;

            List<char> chars = new List<char>();
            for (int i = start; i < start + plus; i++)
            {
                char c = (char)i;
                chars.Add(c);
            }
            start = start + plus;
            nums.Add(index, chars);
            index++;
        }
        return nums;
    }
}