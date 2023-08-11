public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int total = 0;
        foreach (char letter in jewels)
        {
            for (int i = 0; i < stones.Length; i++)
            {
                if (letter == stones[i])
                total++;
            }
        }
        return total;
    }
}