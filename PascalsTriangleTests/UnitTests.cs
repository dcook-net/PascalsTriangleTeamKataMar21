using NUnit.Framework;

namespace PascalsTriangleTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnsArrayOf1WhenGiven1Row()
        {
            var result = PascalsTriangle.PascalsTriangle.DrawTriangle(1);
            
            Assert.That(result, Is.EqualTo(new[] {1}));
        }
        
        [Test]
        public void ReturnsArrayOf0WhenGiven0Rows()
        {
            var result = PascalsTriangle.PascalsTriangle.DrawTriangle(0);
            
            Assert.That(result, Is.Empty);
        }
    }
}