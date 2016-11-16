using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestString
{
    [TestClass]
    public class TestSplit
    {
        [TestMethod]
        public void Test_Check_Split_Char()
        {
            // arrange 
            string s = "This is a cat";
            string expected = "cat";
            // act  
            string actual = s.Split(' ')[3];
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }


        [TestMethod]
        public void Test_Check_Split_Char_Int32()
        {
            // arrange 
            string delimStr = ",.";
            char[] delimiter = delimStr.ToCharArray();
            string words = "one,two.three,four";
            string expected = "three,four";
            // act  
            var actual = words.Split(delimiter, 3)[2];
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Split_Char_StringSplitOption()
        {
            //arrange
            string phrase = "The,,quick,,,brown,fox";
            char[] charSeparators = new char[] { ',' };
            string expected = "brown";
            //act
            var actual = phrase.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries)[2];
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Split_Char_Int32_StringSplitOption()
        {
            //arrange
            string phrase = "The,,quick,,,brown,fox";
            char[] charSeparators = new char[] { ',' };
            string expected = "quick,,,brown,fox";
            //act
            var actual = phrase.Split(charSeparators, 2, StringSplitOptions.RemoveEmptyEntries)[1];
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Split_String_StringSplitOptions()
        {
            //arrange
            string phrase = "The[stop]quick[stop][stop]brown[stop]fox";
            string[] stringSeparators = new string[] { "[stop]" };
            string expected = "brown";
            //act
            var actual = phrase.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)[2];
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Split_String_Int32_StringSplitOptions()
        {
            //arrange
            string phrase = "The[stop][stop]quick[stop]brown[stop]fox";
            string[] stringSeparators = new string[] { "[stop]" };
            string expected = "quick[stop]brown[stop]fox";
            //act
            var actual = phrase.Split(stringSeparators, 2, StringSplitOptions.RemoveEmptyEntries)[1];
            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }
    }
}
