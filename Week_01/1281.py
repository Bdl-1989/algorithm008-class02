class Solution:
    def subtractProductAndSum(self, n: int) -> int:
        sum=0
        acm=1
        for i in str(n):
            sum+=int(i)
            acm*=int(i)
        return acm - sum