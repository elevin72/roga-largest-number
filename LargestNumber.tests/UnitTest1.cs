using Xunit;
using LargestNumber;
using System.Xml.Linq;

namespace LargestNumber.UnitTests.Services
{
    public class LargestNumber_Test
    {

        [Fact]
        public void LargestNumber_EmptyList()
        {
            Assert.Throws<InvalidOperationException>(() => LargestNumber.GetLargestNumber(new List<long> { }));
        }

        [Fact]
        public void LargestNumber_False()
        {
            long result = LargestNumber.GetLargestNumber(new List<long> {1,2,3,4,5});
            Assert.NotEqual(4, result);
        }

        [Fact]
        public void LargestNumber_True()
        {
            long result = LargestNumber.GetLargestNumber(new List<long> {1,2,3,4,5});
            Assert.Equal(5, result);
        }

        [Fact]
        public void LargestNumber_Xml()
        {
            string xmlFileName = "data.xml";

            string fullXmlPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), xmlFileName);

            XDocument xmlDocument = XDocument.Load(fullXmlPath);

            long result = LargestNumber.GetLargestNumberFromXml(xmlDocument);

            Assert.Equal(42, result);
        }
    }
}
