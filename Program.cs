using System;
using PrinterApp.Models;

namespace PrinterApp
{
    internal class Program
    {
        static SimpleHTTPServer _server;

        public static void Main(string[] args)
        {

            Console.WriteLine($"Hello, World");

            //start a webserver on the default port
            string serverPath;
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                serverPath = @"/home/pi/PrinterApp/wwwroot";
            else
                serverPath = @"..\..\wwwroot";
            _server = new SimpleHTTPServer(serverPath, 80);


        }
    }
}