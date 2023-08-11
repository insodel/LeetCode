public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string word1Sticked = "";
        string word2Sticked = "";
        foreach (string word in word1)
        {
            word1Sticked = word1Sticked += word; 
        }
        foreach (string word in word2)
        {
            word2Sticked += word; 
        }
        if (word1Sticked == word2Sticked)
            return true;
            return false;
    }
}