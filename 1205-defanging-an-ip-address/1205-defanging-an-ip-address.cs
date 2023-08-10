public class Solution {
    public string DefangIPaddr(string address) {
        string newaddress = address.Replace(".", "[.]");
        return newaddress;

    }
}