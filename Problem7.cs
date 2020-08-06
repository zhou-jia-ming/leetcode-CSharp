using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Problem7
{
    public class Solution
    {
        public int Reverse(int x)
        {
            try
            {
                if (x >= 0)
                {
                    var arr = x.ToString().ToCharArray();
                    Array.Reverse(arr);
                    return int.Parse(new string(arr));
                }
                else
                {
                    var arr = x.ToString().Substring(1).ToCharArray();
                    Array.Reverse(arr);
                    return -int.Parse(new string(arr));
                }
            }
            catch
            {
                return 0;
            }
        }
    }

    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void T1()
        {
            var s = new Solution();
            var res = s.Reverse(123);
            Assert.AreEqual(res, 321);
        }

    }
}
