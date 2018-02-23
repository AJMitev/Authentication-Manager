namespace AuthenticationManager.Common
{
    using System.Net;
    using System.Net.Sockets;

    public class IPHelper
    {
        public static string GetIpAddress()
        {
            IPHostEntry resolvedHostnameOrIpAddres = Dns.GetHostEntry(Dns.GetHostName());
            string ipAddress = string.Empty;
            foreach (var address in resolvedHostnameOrIpAddres.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = address.ToString();
                }
            }
            return ipAddress;
        }
    }
}
