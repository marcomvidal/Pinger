using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Pinger.Models
{
    public class Attempt
    {
        public IPAddress Destination { get; set; }
        public IPStatus Status { get; set; }
        public DateTime Time { get; set; }

        public Attempt()
        {
            SetDefaultDestination();
        }

        public void SetDefaultDestination()
        {
            Destination = IPAddress.Parse("8.8.8.8");
        }

        public async Task<bool> Send(string destination)
        {
            var validatedAddress = ValidateAddress(destination);
            if (validatedAddress != null) { Destination = validatedAddress; }

            var ping = new Ping();
            var result = await ping.SendPingAsync(Destination);

            Status = result.Status;
            Time = DateTime.Now;

            if (Status == IPStatus.Success) { return true; }
            return false;
        }

        private IPAddress ValidateAddress(string address)
        {
            bool isAnIPAddress = IPAddress.TryParse(address,
                out IPAddress parsedAddress);

            if (isAnIPAddress) { return parsedAddress; }
            return null;
        }
    }
}
