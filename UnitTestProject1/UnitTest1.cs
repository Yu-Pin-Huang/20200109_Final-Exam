using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convert_檢查輸入時間1的回傳值()
        {
            // arrange
            Convert convert = new Convert();  //注入測試目標

            // 期望值
            int expected = "12:00 AM";

            // act
            // 實際結果
            int actual = convert.MilitaryTimeToRegularTime("00:00");

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);
        }
    }
}
