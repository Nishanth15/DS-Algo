Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
Note:

You must do this in-place without making a copy of the array.
Minimize the total number of operations.


Solution: C#

public class Solution {
    public void MoveZeroes(int[] nums) 
{
    int zeros = 0;
    for (int i = 0; i < nums.Length; i++)
    {
      if (nums[i] == 0)
        zeros++;
    else
      if (zeros > 0)
      {
      nums[i - zeros] = nums[i];
      nums[i] = 0;
      }
    }
}
}
