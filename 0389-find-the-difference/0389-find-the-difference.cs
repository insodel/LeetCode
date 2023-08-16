public class Solution {
    public char FindTheDifference(string s, string t) {
         int x = 0;
        foreach (char c in s)
            x ^= (int)c;
        foreach (char c in t)
            x ^= (int)c;
        return (char)x;
    }
}