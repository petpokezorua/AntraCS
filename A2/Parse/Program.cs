﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a URL:");
        string url = Console.ReadLine();

        string protocol = "";
        string server = "";
        string resource = "";

        int protocolEndIndex = url.IndexOf("://");
        if (protocolEndIndex != -1)
        {
            protocol = url.Substring(0, protocolEndIndex);
            url = url.Substring(protocolEndIndex + 3); 


        int serverEndIndex = url.IndexOf('/');
        if (serverEndIndex != -1)
        {
            server = url.Substring(0, serverEndIndex);
            resource = url.Substring(serverEndIndex + 1); 
        }
        else
        {
            server = url; 
        }

        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}