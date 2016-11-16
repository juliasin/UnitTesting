using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestString
{
    [TestClass]
    public class TestSubstring
    {
        [TestMethod]
        public void Test_Check_Substring_Int32()
        {
            //arrange
            string phrase = "This is beautiful house";
            string expected = "beautiful house";
            //act
            var actual = phrase.Substring(8);
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Substring_Int32_Int32()
        {
            //arrange
            string phrase = "This is beautiful house";
            string expected = "beautiful";
            //act
            var actual = phrase.Substring(8, 9);
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Substring_Int32IndexOf()
        {
            //arrange
            string phrase = "This is! beautiful house";
            string expected = "! beautiful house";
            //act
            var actual = phrase.Substring(phrase.IndexOf('!'));
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Substring_Int32IndexOf_Int32()
        {
            //arrange
            string phrase = "This is! beautiful house";
            string expected = "! beautiful";
            //act
            var actual = phrase.Substring(phrase.IndexOf('!'), 11);
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

    }
}
