using System.Net;


// test
Console.WriteLine(UInt32ToIP(0));
Console.WriteLine(UInt32ToIP(2149583361));


// decision
string UInt32ToIP(uint ip)
{
    IPAddress newIP;
    if (IPAddress.TryParse(ip.ToString(), out newIP!)) return "-1";
    return newIP.ToString();
}