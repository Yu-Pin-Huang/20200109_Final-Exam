using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilitaryTimeConversion;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Conv_檢查輸入時間1的回傳值()
        {
            // arrange
            Conv conv = new Conv();
            //string input = "00:00";

            // 期望值
            string expected = "12:00 AM";

            // act
            // 實際結果
            //string actual = conv.MilitaryTimeToRegularTime(input);
            string actual = conv.MilitaryTimeToRegularTime("00:00");

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Conv_檢查輸入時間2的回傳值()
        {
            // arrange
            Conv conv = new Conv();
            //string input = "00:00";

            // 期望值
            string expected = "1:00 AM";

            // act
            // 實際結果
            //string actual = conv.MilitaryTimeToRegularTime(input);
            string actual = conv.MilitaryTimeToRegularTime("01:00");

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Conv_檢查輸入時間3的回傳值()
        {
            // arrange
            Conv conv = new Conv();
            //string input = "00:00";

            // 期望值
            string expected = "12:00 PM";

            // act
            // 實際結果
            //string actual = conv.MilitaryTimeToRegularTime(input);
            string actual = conv.MilitaryTimeToRegularTime("12:00");

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Conv_檢查輸入時間4的回傳值()
        {
            // arrange
            Conv conv = new Conv();
            //string input = "00:00";

            // 期望值
            string expected = "6:00 PM";

            // act
            // 實際結果
            //string actual = conv.MilitaryTimeToRegularTime(input);
            string actual = conv.MilitaryTimeToRegularTime("18:00");

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Conv_檢查輸入時間5的回傳值()
        {
            // arrange
            Conv conv = new Conv();
            //string input = "00:00";

            // 期望值
            string expected = "error";

            // act
            // 實際結果
            //string actual = conv.MilitaryTimeToRegularTime(input);
            string actual = conv.MilitaryTimeToRegularTime("01:60");

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Conv_檢查輸入時間6的回傳值()
        {
            // arrange
            Conv conv = new Conv();
            //string input = "00:00";

            // 期望值
            string expected = "error";

            // act
            // 實際結果
            //string actual = conv.MilitaryTimeToRegularTime(input);
            string actual = conv.MilitaryTimeToRegularTime("03!50");

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Conv_檢查輸入時間7的回傳值()
        {
            // arrange
            Conv conv = new Conv();
            //string input = "00:00";

            // 期望值
            string expected = "error";

            // act
            // 實際結果
            //string actual = conv.MilitaryTimeToRegularTime(input);
            string actual = conv.MilitaryTimeToRegularTime("18:0x");

            // assert
            // 比對(請注意類型)
            Assert.AreEqual(expected, actual);
        }
    }
}
