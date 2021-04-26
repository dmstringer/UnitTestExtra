using System;
using ExtraMethods;
using Xunit;

namespace UnitTestExtra
{
    public class UnitTest1
    {
        [Fact]
        public void WesternStyleEmoticon()
        {
            // Arrange
            var myTest = new MyExtraMethods();
            string[] emotArray = { ":-)", ":-(", ":/", ";)", ":o", ":|", "=)", "<3" };

            // Check all strings
            foreach (string emoticon in emotArray)
            {
                // Act
                bool actual = myTest.WesternStyleEmoticon(emoticon);

                // Assert
                Assert.True(actual);
            }
        }

        [Theory]
        [InlineData(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2, "abigailtheta")]
        [InlineData(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1, "oocccffuucccjjjkkkjyyyeehh")]
        [InlineData(new String[] { }, 3, "")]
        [InlineData(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2, "wlwsasphmxxowiaxujylentrklctozmymu")]
        [InlineData(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2, "")]
        [InlineData(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3, "ixoyx3452zzzzzzzzzzzz")]
        [InlineData(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15, "")]
        [InlineData(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0, "")]
        public void LongestConsecTest(string[] strArray, int num, string expected)
        {
            // Arrange
            var myTest = new MyExtraMethods();
            // Act
            string actual = myTest.LongestConsec(strArray, num);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(11, true)]
        [InlineData(30, false)]
        [InlineData(59, true)]
        [InlineData(72, false)]
        [InlineData(84, false)]
        [InlineData(96, false)]
        public void TestIfPrime(int num, bool expected)
        {
            // Arrange
            var myTest = new MyExtraMethods();
            // Act
            bool actual = myTest.IsPrime(num);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }, 5)]
        [InlineData(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 1, 2, 4, 4, -1, -2, 5 }, 20)]
        [InlineData(new[] { 10, -1, 2, -2, 3, 3, 5, 1, 2, 4, 10, 4, -1, -2, 5 }, 1)]
        [InlineData(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 1, 2, 4, 20, 4, 4, 4, 4, -1, -2, 5 }, 4)]
        
        public void FindOddInt(int[] nums, int expected)
        {
            // Arrange
            var myTest = new MyExtraMethods();
            // Act
            int actual = myTest.FindOddInt(nums);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("world", "dlrow")]
        [InlineData("jello", "ollej")]
        [InlineData("foobar", "raboof")]
        [InlineData("ducky", "ykcud")]
        [InlineData("supercalifragilisticexpialidocious", "suoicodilaipxecitsiligarfilacrepus")]

        public void ReversedString(string myWord, string expected)
        {
            // Arrange
            var myTest = new MyExtraMethods();
            // Act
            string actual = myTest.ReversedString(myWord);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
