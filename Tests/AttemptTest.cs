using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pinger.Models;
using System.Net;

namespace Test
{
    [TestClass]
    public class AttemptTest
    {
        [TestMethod]
        public void RevertToDefaultDestination_ShouldSuccess()
        {
            // Arrange
            var expected = IPAddress.Parse("8.8.8.8");
            var attempt = new Attempt();

            // Act
            attempt.Destination = IPAddress.Parse("4.4.4.4");
            attempt.SetDefaultDestination();
            var actual = attempt.Destination;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("8.8.8.8")]
        [DataRow("192.168.0.0")]
        [DataRow("192.168.0.1")]
        [DataRow("192.168.0.255")]
        [DataRow("127.0.0.1")]
        [DataRow("0")]
        public void ValidateAValidAddress_ShouldSuccess(string address)
        {
            // Arrange
            var expected = IPAddress.Parse(address);
            var attempt = new Attempt();
            var exposedAttempt = new PrivateObject(attempt);

            // Act
            var actual = (IPAddress)exposedAttempt.Invoke(
                "ValidateAddress",
                address);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("999.999.999.999")]
        [DataRow("ABC")]
        [DataRow("AB12CD34")]
        [DataRow("")]
        [DataRow(" ")]
        public void ValidateAnInValidAddress_ShouldFail(string address)
        {
            // Arrange
            var attempt = new Attempt();
            var exposedAttempt = new PrivateObject(attempt);

            // Act
            var actual = (IPAddress)exposedAttempt.Invoke(
                "ValidateAddress",
                address);

            // Assert
            Assert.IsNull(actual);
        }
    }
}
