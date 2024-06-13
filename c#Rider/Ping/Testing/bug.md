````csharp
namespace Testing;

using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

public class Pro : IEnumerable<string>
{
    static void Main(string[] args)
    {
        NetworkConnectionTest();
    }
    private readonly List<string> hosts;

    public string NetworkConnectionTest(IEnumerable<string> hosts)
    {
        this.hosts = new List<string>(hosts);
    }
````
````csharp
Method 'NetworkConnectionTest' has 1 parameter(s) but is invoked with 0 argument(s)
    Field 'hosts' is read-only (except in constructor or init-only setter of the type in which the field is defined). The assignment target must be an assignable variable, property, or indexer
    Return statement is missing
````


## Lösung:

````csharp
namespace Testing;

using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

public class Pro : IEnumerable<string>
{
    private readonly List<string> hosts;

    public Pro(IEnumerable<string> hosts)
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
````