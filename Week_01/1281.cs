public class Solution {
    public int SubtractProductAndSum(int n) {
        int sum = 0;
        int accumulate = 1;
        while(n!=0) {
            sum += n%10;
            accumulate *= n%10;
            n=(n-n%10)/10;
        }
        return accumulate - sum;
    }
}