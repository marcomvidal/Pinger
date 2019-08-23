using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pinger.Models;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        [DataRow("8.8.8.8")]
        [DataRow("54.94.175.250")]
        [DataRow("127.0.0.1")]
        public async Task SendToActiveAddress_ShouldSuccess(string address)
        {
            // Arrange
            var attempt = new Attempt();

            // Act
            bool actual = await attempt.Send(address);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [DataRow("8.8.8.0")]
        [DataRow("192.168.0.0")]
        public async Task SendToInactiveAddress_ShouldFail(string address)
        {
            // Arrange
            var attempt = new Attempt();

            // Act
            bool actual = await attempt.Send(address);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}
