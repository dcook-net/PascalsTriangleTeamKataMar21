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