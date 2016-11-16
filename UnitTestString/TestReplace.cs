using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestString
{
    [TestClass]
    public class TestReplace
    {
        [TestMethod]
        public void Test_Check_Replace_Char()
        {
            // arrange  
            string s="aaa";
            string expected = "ccc";
            // act  
            string actual= s.Replace("a", "c");

            // assert  
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Check_Replace_String()
        {
            // arrange  
            string s = "Hello world";
            string expected = "Hello everyone";
            // act  
            string actual = s.Replace("world", "everyone");

            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Replace_String_Two_Times()
        {
            // arrange  
            string s = "Hello world";
            string expected = "Hello people";
            // act  
            string actual = s.Replace("world", "everyone").Replace("everyone","people");

            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

        [TestMethod]
        public void Test_Check_Replace_String_And_Char()
        {
            // arrange  
            string s = "Good morning";
            string expected = "Good kvkning";
            // act  
            string actual = s.Replace("morning", "evening").Replace("e", "k");

            // assert  
            Assert.IsTrue(String.Equals(expected, actual));
        }

     }
}



