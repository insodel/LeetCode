public class Solution {
    public int MySqrt(int x) {
        double i = 1;
        while (i * i <= x)
            i++;
        return Convert.ToInt32(i - 1);
    }
}