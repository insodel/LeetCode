public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int variable = 0;
        foreach (string s in operations)
        {
            if (s == "--X" || s == "X--")
                variable--;
            else
                variable++;
        }
        return variable;
    }
}