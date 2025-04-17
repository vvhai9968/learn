using System.Text;

namespace Encode_And_Decode_Strings_271;

public class Program
{
    static void Main(string[] args)
    {
        var enCode = Encode(["neet","code","love","you"]);
        Console.WriteLine(enCode);
        var deCode = Decode(enCode);
    }

    private static string Encode(IList<string> strs)
    {
        var str = new StringBuilder();
        foreach (var item in strs)
        {
            str.Append(item.Length).Append('#').Append(item);
        }

        return str.ToString();
    }

    private static List<string> Decode(string s)
    {
        var res = new List<string>();
        var i = 0;
        while (i < s.Length)
        {
            var j = i;
            while (s[j] != '#') j++;
            var length = int.Parse(s.Substring(i, j - i));
            var word = s.Substring(j + 1, length);
            res.Add(word);
            i = j + 1 + length;
        }
        return res;
    }
}