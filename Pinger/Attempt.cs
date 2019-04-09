using System;
using System.Net;
using System.Net.NetworkInformation;

namespace Pinger
{
    class Attempt
    {
        public IPAddress Destination { get; set; }
        public IPStatus Status { get; set; }
        public DateTime Time { get; set; }

        public Attempt()
        {
            ResetTarget();
        }

        public void ResetTarget()
        {
            Destination = IPAddress.Parse("8.8.8.8");
        }

        public bool Send(string destination)
        {
            var validatedAddress = ValidateAddress(destination);
            if (validatedAddress != null) { Destination = validatedAddress; }

            var ping = new Ping();
            var result = ping.Send(Destination);

            this.Status = result.Status;
            this.Time = DateTime.Now;

            if (this.Status == IPStatus.Success) { return true; }
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
