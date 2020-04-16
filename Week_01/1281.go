func subtractProductAndSum(n int) int {
    var (
        sum = 0
        acm = 1
    )
    for n!=0 {
        sum+=n%10
        acm*=n%10
        n=(n-n%10)/10
    }
    return acm - sum
}