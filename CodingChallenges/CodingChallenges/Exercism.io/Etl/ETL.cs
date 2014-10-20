using System.Collections.Generic;

class ETL
{
   public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> oldPair)
    {
        var dictionaryNew = new Dictionary<string, int>();
        foreach (var pair in oldPair)
            foreach (var character in pair.Value)
                dictionaryNew[character.ToLower()] = pair.Key;
        return dictionaryNew;
    }
}
