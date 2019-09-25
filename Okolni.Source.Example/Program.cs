﻿using Okolni.Source.Query;
using Okolni.Source.Common;
using System;

namespace Okolni.Source.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueryConnection conn = new QueryConnection();

            // Exampleserver: ARK VALGUERO Server
            conn.Host = "89.163.146.91";
            conn.Port = 27023;
            
            conn.Connect();
            var info = conn.GetInfo();
            var players = conn.GetPlayers();
            var rules = conn.GetRules();
            //conn.Disconnect();
            Console.WriteLine(info.ToString());
        }
    }
}