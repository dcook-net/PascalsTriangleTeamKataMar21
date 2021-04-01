using System.Linq;
using NUnit.Framework;
using PascalsTriangle;

namespace PascalsTriangleTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase((uint)1, new uint[] {1})]
        [TestCase((uint)2, new uint[] {1, 1, 1})]
        [TestCase((uint)5, new uint[]
        {
                1,
               1, 1,
              1, 2, 1, 
             1, 3, 3, 1,
            1, 4, 6, 4, 1
        })]
        [TestCase((uint)10, new uint[]
        {
            1,                         //0
            1, 1,                        //1
            1, 2, 1,                       //2
            1,  3, 3, 1,                     //3
            1, 4,  6, 4, 1,
            1, 5, 10, 10, 5, 1,
            1, 6, 15, 20, 15, 6, 1,
            1, 7, 21, 35, 35, 21, 7, 1,
            1, 8, 28 , 56, 70, 56, 28, 8, 1,
            1, 9 , 36, 84, 126, 126, 84, 36, 9, 1 
        })]
        public void ReturnsArrayOf1WhenGiven1Row(uint rows, uint[] expected)
        {
            var result = Triangle.DrawTriangle(rows);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ReturnsArrayOf0WhenGiven0Rows()
        {
            var result = Triangle.DrawTriangle(0);

            Assert.That(result, Is.Empty);
        }
    }
}