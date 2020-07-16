using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1431
{
    //    给你一个数组 candies 和一个整数 extraCandies ，其中 candies[i] 代表第 i 个孩子拥有的糖果数目。

    //对每一个孩子，检查是否存在一种方案，将额外的 extraCandies 个糖果分配给孩子们之后，此孩子有 最多 的糖果。注意，允许有多个孩子同时拥有 最多 的糖果数目。

    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/kids-with-the-greatest-number-of-candies
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            var max_val = Int32.MinValue;
            foreach(var n in candies)
            {
                max_val = Math.Max(max_val, n);
            }
            foreach(var n in candies)
            {
                if (n + extraCandies >= max_val)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }
            return result;
        }
    }
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void T1()
        {
            var candies = new int[] { 2, 3, 5, 1, 3 };
            var extraCandies = 3;
            var res = new bool[] {true, true, true, false, true};
            var s = new Solution();
            Enumerable.SequenceEqual(res, s.KidsWithCandies(candies, extraCandies));
        }
    }
}
