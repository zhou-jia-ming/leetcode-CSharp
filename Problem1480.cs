using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
namespace Problem1480
{
    // 一维数组的动态和
    //给你一个数组 nums 。数组「动态和」的计算公式为：runningSum[i] = sum(nums[0]…nums[i]) 。
    //请返回 nums 的动态和。

    //来源：力扣（LeetCode）
    //链接：https://leetcode-cn.com/problems/running-sum-of-1d-array
    //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
    public class Solution
    {
        public int[] RunningSum(int[] nums)
        {
            int cur_sum = 0;
            var res = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                cur_sum += nums[i];
                res[i] = cur_sum;
            }
            return res;
        }
    }
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void T1()
        {
            var nums1 = new int[4] { 1, 2, 3, 4 };
            var s = new Solution();
            Assert.AreEqual(true, Enumerable.SequenceEqual(s.RunningSum(nums1), new int[4] { 1, 3, 6, 10 }));
            return;
        }
    }




}
