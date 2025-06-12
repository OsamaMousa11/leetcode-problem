using System.Linq;
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine( RomanToInt("MCMXCIV"));
      
    }

    public  static int RomanToInt(string s)
    {
        Dictionary<char, int> word = new Dictionary<char, int>();

        word['I'] = 1;
        word['V'] = 5;
        word['X'] = 10;
        word['L'] = 50;
        word['C'] = 100;
        word['D'] = 500;
        word['M'] = 1000;
        var sum = 0;
        var oldvalue = 0;

        foreach (var i in s)
        {
          int CurrentValue = word[i];
           sum+=(CurrentValue >oldvalue) ? CurrentValue-(oldvalue*2) : CurrentValue;
            oldvalue = CurrentValue;
        }
        return sum; 
    }
}

