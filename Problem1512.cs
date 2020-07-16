using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Problem1512
{
    //    给你一个整数数组 nums 。

    //如果一组数字(i, j) 满足 nums[i] == nums[j] 且 i<j ，就可以认为这是一组 好数对 。

    //返回好数对的数目。

    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/number-of-good-pairs
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    public class Solution
    {
        private int timesOfPairsInN(int n)
        {
            return n * (n - 1) / 2;
        }
        public int NumIdenticalPairs(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            int result = 0;
            foreach(var n in nums)
            {
                if (dict.ContainsKey(n))
                {
                    dict[n] += 1;
                }
                else
                {
                    dict[n] = 1;
                }
            }
            foreach(var v in dict.Values)
            {
                result += timesOfPairsInN(v);
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
            var nums = new[] { 1, 2, 3, 1, 1, 3 };
            var s = new Solution();
            var result = s.NumIdenticalPairs(nums);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void T2()
        {
            var nums = new[] { 1, 1,1,1 };
            var s = new Solution();
            var result = s.NumIdenticalPairs(nums);
            Assert.AreEqual(6, result);
        }
    }
}
