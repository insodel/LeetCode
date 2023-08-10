public class Solution {
    public string DefangIPaddr(string address) {
        string ip = address.Replace(".", "[.]");
        return ip;

    }
}