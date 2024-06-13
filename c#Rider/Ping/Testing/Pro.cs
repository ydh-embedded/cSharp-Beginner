namespace Testing;

using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

public class Pro : IEnumerable<string>
{
    private readonly List<string> hosts;

    private Pro(IEnumerable<string> hosts)
    {
        this.hosts = new List<string>(hosts);
    }

    public IEnumerator<string> GetEnumerator()
    {
        foreach (string host in hosts)
        {
            if (PingHost(host))
            {
                yield return $"{host} is reachable.";
            }
            else
            {
                yield return $"{host} is not reachable.";
            }
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private bool PingHost(string host)
    {
        try
        {
            using (Ping ping = new Ping())
            {
                PingReply reply = ping.Send(host, 1000);
                return reply.Status == IPStatus.Success;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    static void Main(string[] args)
    {
        Pro pro = new Pro(new[] { "google.com", "example.com", "nonexistent.com" });
        foreach (string result in pro)
        {
            Console.WriteLine(result);
        }
    }
}