//https://leetcode-cn.com/problems/number-of-burgers-with-no-waste-of-ingredients/

public class Solution {
    public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices) {
        return tomatoSlices % 2 == 0 && cheeseSlices * 2 <= tomatoSlices && tomatoSlices <= cheeseSlices * 4 ? new List<int>{
            tomatoSlices / 2 - cheeseSlices, cheeseSlices * 2 - tomatoSlices / 2} : new List<int>();
    }
}


// Explanation
// tomate number t should not be odd,
// and it should valid that c * 2 <= t && t <= c * 4.

// From
// jumbo + small = cheese
// jumbo * 2 + small = tomate / 2

// We can get that
// jumb0 = tomate / 2 - cheese
// So that
// small = cheese * 2 - tomate / 2


// Complexity
// Time O(1)
// Space O(1)