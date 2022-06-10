using System;

namespace Container_With_Most_Water
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
      Solution s = new Solution();
      var result = s.MaxArea(nums);
    }
  }
  
  // brute force solution using O(N2)
  // we are taking one index at a time and calculating all the areas after that index till the end.
  // as index with the min value will allow us to store water not the max value because when we try to put more water than min value of that index water will be spil out
  // thats why we calculate the area min * (r - l)
  public class Solution
  {
    public int MaxArea(int[] height)
    {
      int max = int.MinValue;
      for (int i = 0; i < height.Length; i++)
      {
        for (int j = i + 1; j < height.Length; j++)
        {
          int min = Math.Min(height[i], height[j]);
          int area = (j - i) * min;
          max = Math.Max(max, area);
        }
      }

      return max;
    }
  }
}
