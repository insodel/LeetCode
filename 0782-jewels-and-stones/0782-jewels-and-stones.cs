public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int total = 0;
        foreach (char letter in stones)
        {
            if (jewels.Contains(letter))
            total++;
        }
        return total;
    }
}